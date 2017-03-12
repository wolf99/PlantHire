using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace FisherPlantHire
{
    public partial class Form1 : Form
    {
        private BindingSource Hirers = new BindingSource(); // Create BindingSources
        private BindingSource Machines = new BindingSource();
        private String HirerCsvPath;
        private String PlantCsvPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HirerFactory hf = new HirerFactory(); // Create record factories
            MachineFactory mf = new MachineFactory();
            
            HirerCsvPath = Path.GetFullPath(Properties.Resources.HirerCsvPath);
            PlantCsvPath = Path.GetFullPath(Properties.Resources.PlantCsvPath);

            // Bind factories to BindingSources
            if (File.Exists(HirerCsvPath))
                Hirers.DataSource = GetListFromCsvFile<Hirer>(hf, HirerCsvPath);
            else
                Hirers.DataSource = new List<Hirer>();

            if (File.Exists(PlantCsvPath))
                Machines.DataSource = GetListFromCsvFile<Machine>(mf, PlantCsvPath);
            else
                Machines.DataSource = new List<Machine>();
            
            HirerDataGridView.DataSource = Hirers; // Bind form controls to BindingSources
            HirerCode.DataSource = Hirers;
            HirerCode.DisplayMember = "Code";
            HirerCode.ValueMember = "Code";
            HirerName.DataBindings.Add("Text", Hirers, "Name");
            HirerAddressLn1.DataBindings.Add("Text", Hirers, "AddressLn1");
            HirerAddressLn2.DataBindings.Add("Text", Hirers, "AddressLn2");
            HirerAddressLn3.DataBindings.Add("Text", Hirers, "AddressLn3");
            HirerAddressLn4.DataBindings.Add("Text", Hirers, "AddressLn4");
            HirerAddressLn5.DataBindings.Add("Text", Hirers, "AddressLn5");

            MachineDataGridView.DataSource = Machines;
            PlantCode.DataSource = Machines;
            PlantCode.DisplayMember = "Code";
            PlantCode.ValueMember = "Code";
            PlantDetailLn1.DataBindings.Add("Text", Machines, "DetailLn1");
            PlantDetailLn2.DataBindings.Add("Text", Machines, "DetailLn2");
            PlantDetailLn3.DataBindings.Add("Text", Machines, "DetailLn3");
            PlantDetailLn4.DataBindings.Add("Text", Machines, "DetailLn4");
            PlantDetailLn5.DataBindings.Add("Text", Machines, "DetailLn5");
            WeeklyRate.DataBindings.Add("Text", Machines, "WeeklyRate");
            DailyRate.DataBindings.Add("Text", Machines, "DailyRate");

            // MOAR WURK HERE !
        }

        private List<T> GetListFromCsvFile<T>(RecordFactory factory, string path)
        {
            List<T> list = new List<T>();
            TextFieldParser parser;
            try
            {
                parser = new TextFieldParser(path); // Open the text file for parsing
            }
            catch (FileNotFoundException e)
            {
                string message = string.Format("Could not find file\n{0}\nA new file will be created when adding new records.", path);
                MessageBox.Show(message, "File not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            catch (System.Exception e)
            {
                string message = string.Format("The file could not be opened.\n{0}\n{2}", path, e.Message);
                MessageBox.Show(message, "Cannot open file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");

            while (!parser.EndOfData)
            {
                string[] fields = new string[0];
                Record r;
                try
                {
                    fields = parser.ReadFields(); // Read all fields on current line
                    r = factory.MakeRecord(fields); // Use fileds to create a record object
                }
                catch (MalformedLineException e)
                {
                    string message = string.Format("Line {0} malformed\nIn file: {2}\nLine will not be included.", e.LineNumber, path);
                    MessageBox.Show(message, "CSV parser error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                catch (System.ArgumentException e)
                {
                    string message = string.Format("Could not parse {0}\nLine {1}\n\n{2}", e.ParamName, (parser.LineNumber - 1), path);
                    MessageBox.Show(message, "CSV field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                list.Add((T)(object)r); // Add record object to list
            }
            parser.Close();
            return list;
        }

        private void UpdateCsvFile(List<Record> records, string path)
        {
            FileStream fs;
            StreamWriter sw;
            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
            }
            catch (System.Exception e)
            {
                string message = string.Format("Could not open file for writing\n{0}\n{1}", path, e.Message);
                MessageBox.Show("Cannot open file", message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Record r in records)
            {
                sw.WriteLine(r.ToString());
            }
            sw.Close();
            fs.Close();
        }
    }
}
