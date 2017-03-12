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

            Hirers.DataSource = GetList<Hirer>(hf, HirerCsvPath); // Nind factories to BindingSources
            Machines.DataSource = GetList<Machine>(mf, PlantCsvPath);
            
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

        private List<T> GetList<T>(RecordFactory factory, string path)
        {
            List<T> list = new List<T>();
            TextFieldParser parser = new TextFieldParser(path);
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
    }
}
