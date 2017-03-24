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
using Word = Microsoft.Office.Interop.Word;

namespace FisherPlantHire
{
    public partial class Form1 : Form
    {
        private BindingSource Hirers = new BindingSource(); // Create BindingSources
        private BindingSource Machines = new BindingSource();
        private String HirerCsvPath;
        private String PlantCsvPath;
        private string ContractTemplatePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HirerFactory hf = new HirerFactory(); // Create record factories
            MachineFactory mf = new MachineFactory();

            ContractTemplatePath = Path.GetFullPath(Properties.Resources.ContractTemplatePath);
            HirerCsvPath = Path.GetFullPath(Properties.Resources.HirerCsvPath);
            PlantCsvPath = Path.GetFullPath(Properties.Resources.PlantCsvPath);

            // Check template exists
            if (!File.Exists(ContractTemplatePath))
            {
                string message = string.Format("Cant find: {0}\nWill not be able to print or save contract", ContractTemplatePath);
                var response = MessageBox.Show(message, "Cannot find contract template", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (response == DialogResult.Cancel)
                {
                    Environment.Exit(0);
                }
            }

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

            // Make the DataGridView column headings nicer
            HirerDataGridView.Columns[2].HeaderText = "Address 1";
            HirerDataGridView.Columns[3].HeaderText = "Address 2";
            HirerDataGridView.Columns[4].HeaderText = "Address 3";
            HirerDataGridView.Columns[5].HeaderText = "Address 4";
            HirerDataGridView.Columns[6].HeaderText = "Address 5";

            MachineDataGridView.Columns[1].HeaderText = "Detail 1";
            MachineDataGridView.Columns[2].HeaderText = "Detail 2";
            MachineDataGridView.Columns[3].HeaderText = "Detail 3";
            MachineDataGridView.Columns[4].HeaderText = "Detail 4";
            MachineDataGridView.Columns[5].HeaderText = "Detail 5";
            MachineDataGridView.Columns[6].HeaderText = "Weekly Rate";
            MachineDataGridView.Columns[7].HeaderText = "Daily Rate";

            // Set column widths to automatically set to the best width for the 
            // width of the window.
            // Code column should only be the minimum width.
            // Name column should have highest width priority.
            // Address columns should then equally take up all remaining width.
            HirerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HirerDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            HirerDataGridView.Columns[0].FillWeight = 3;
            HirerDataGridView.Columns[1].FillWeight = 2;
            HirerDataGridView.Columns[2].FillWeight = 1;
            HirerDataGridView.Columns[3].FillWeight = 1;
            HirerDataGridView.Columns[4].FillWeight = 1;
            HirerDataGridView.Columns[5].FillWeight = 1;
            HirerDataGridView.Columns[6].FillWeight = 1;

            // Code column should only be the minimu width.
            // First detail line column should have preference.
            // Subsequent detail lines have equal preference.
            // Rate columns should both only be as wide as they need to be
            MachineDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MachineDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MachineDataGridView.Columns[0].FillWeight = 4;
            MachineDataGridView.Columns[1].FillWeight = 3;
            MachineDataGridView.Columns[2].FillWeight = 2;
            MachineDataGridView.Columns[3].FillWeight = 2;
            MachineDataGridView.Columns[4].FillWeight = 2;
            MachineDataGridView.Columns[5].FillWeight = 2;
            MachineDataGridView.Columns[6].FillWeight = 1;
            MachineDataGridView.Columns[7].FillWeight = 1;

            // Make the Code ComboBoxes boxes show autocomplete suggestions
            // based on the databound list contents
            HirerCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            HirerCode.AutoCompleteSource = AutoCompleteSource.ListItems;

            PlantCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            PlantCode.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Print_Click(object sender, EventArgs e)
        {
            // Open the MS Word application via Office Interop
            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc;

            // Attempt to open the template
            try
            {
                wordDoc = wordApp.Documents.Add(Template: ContractTemplatePath, Visible: false);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                wordApp.Quit();
                return;
            }

            // Ensure the opened document is the currently active one
            wordDoc.Activate();

            // Set the text for each bookmark from the corresponding data in the GUI
            SetBookmarkText(wordDoc, "Hirer", HirerName.Text);
            SetBookmarkText(wordDoc, "HirerAddress1", HirerAddressLn1.Text);
            SetBookmarkText(wordDoc, "HirerAddress2", HirerAddressLn2.Text);
            SetBookmarkText(wordDoc, "HirerAddress3", HirerAddressLn3.Text);
            SetBookmarkText(wordDoc, "HirerAddress4", HirerAddressLn4.Text);
            SetBookmarkText(wordDoc, "HirerAddress5", HirerAddressLn5.Text);
            SetBookmarkText(wordDoc, "SiteAddress1", SiteAddressLn1.Text);
            SetBookmarkText(wordDoc, "SiteAddress2", SiteAddressLn2.Text);
            SetBookmarkText(wordDoc, "SiteAddress3", SiteAddressLn3.Text);
            SetBookmarkText(wordDoc, "SiteAddress4", SiteAddressLn4.Text);
            SetBookmarkText(wordDoc, "SiteAddress5", SiteAddressLn5.Text);
            SetBookmarkText(wordDoc, "OrderNo", OrderNumber.Text);
            SetBookmarkText(wordDoc, "CommencementDate", CommencementDate.Text);
            SetBookmarkText(wordDoc, "WeeklyRate", WeeklyRate.Text);
            SetBookmarkText(wordDoc, "DailyRate", DailyRate.Text);
            SetBookmarkText(wordDoc, "DeliveryCharge", DeliveryRate.Text);
            SetBookmarkText(wordDoc, "CollectionCharge", CollectRate.Text);
            SetBookmarkText(wordDoc, "PlantNo", PlantCode.Text);
            SetBookmarkText(wordDoc, "PlantDetail1", PlantDetailLn1.Text);
            SetBookmarkText(wordDoc, "PlantDetail2", PlantDetailLn2.Text);
            SetBookmarkText(wordDoc, "PlantDetail3", PlantDetailLn3.Text);
            SetBookmarkText(wordDoc, "PlantDetail4", PlantDetailLn4.Text);
            SetBookmarkText(wordDoc, "PlantDetail5", PlantDetailLn5.Text);

            // Instantiate and configure the PrintDialog
            var pd = new PrintDialog();
            pd.UseEXDialog = true;
            pd.AllowSomePages = false;
            pd.AllowSelection = false;
            pd.AllowCurrentPage = false;
            pd.AllowPrintToFile = false;

            // Check the response from the PrintDialog
            if (pd.ShowDialog(this) == DialogResult.OK)
            {
                // Attempt to print the document
                try
                {
                    wordApp.ActivePrinter = pd.PrinterSettings.PrinterName;
                    wordDoc.PrintOut();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            // Attemt to close the document without saving the changes (once 
            // the document is printed we don't need it anymore). Then close 
            // the MS Word application.
            try
            {
                wordDoc.Close(SaveChanges: false);
                wordApp.Quit(SaveChanges: false);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private List<T> GetListFromCsvFile<T>(RecordFactory factory, string path)
        {
            List<T> list = new List<T>();
            TextFieldParser parser;

            // Attempt to open the text file with the parser
            try
            {
                parser = new TextFieldParser(path); 
            }
            catch (FileNotFoundException)
            {
                // The file or path was not found, in this case we can have the 
                // program create a new file to use
                string message = string.Format("Could not find file\n{0}\nA new file will be created when adding new records.", path);
                MessageBox.Show(message, "File not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new List<T>();
            }
            catch (System.Exception e)
            {
                // Some other error prevented the parser from opening the file,
                // this is more serious
                string message = string.Format("The file could not be opened.\n{0}\n{2}", path, e.Message);
                MessageBox.Show(message, "Cannot open file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            // Tell the parser how the file data is delimited (CSV)
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");

            while (!parser.EndOfData)
            {
                string[] fields = new string[0];
                Record r;

                try
                {
                    // Read all fields on current line
                    fields = parser.ReadFields();
                    // Desearialize fields to create a record object
                    r = factory.MakeRecord(fields); 
                }
                catch (MalformedLineException e)
                {
                    // The line read from the file was not in the format 
                    // expected by the parser
                    string message = string.Format("Line {0} malformed\nIn file: {2}\nLine will not be included.", e.LineNumber, path);
                    MessageBox.Show(message, "CSV parser error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                catch (System.ArgumentException e)
                {
                    // The fields were not as expected by the factory
                    string message = string.Format("Could not parse {0}\nLine {1}\n\n{2}", e.ParamName, (parser.LineNumber - 1), path);
                    MessageBox.Show(message, "CSV field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                // Add record object to list
                list.Add((T)(object)r); 
            }
            // Close the parser (closes the file)
            parser.Close();
            return list;
        }

        private void UpdateCsvFile(List<Record> records, string path)
        {
            FileStream fs;
            StreamWriter sw;

            // TODO: Handle the case where the file does not yet exist - we should create  new one.

            // Attempt to open the file as a stream and use that to instantiate 
            // a StreamWriter
            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
            }
            catch (System.Exception e)
            {
                // The file could not be opened or if it did the StreamWriter 
                // had a problem with it. Either way, from a user's perspective, 
                // the file could not be opened
                string message = string.Format("Could not open file for writing\n{0}\n{1}", path, e.Message);
                MessageBox.Show("Cannot open file", message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Serialize each record, writing each to the file as a single line
            foreach (Record r in records)
            {
                sw.WriteLine(r.ToString());
            }

            // Close the StreamWriter and then the file stream (clsoes the file)
            sw.Close();
            fs.Close();
        }

        private void SetBookmarkText(Word.Document document, string bookmark, string text)
        {
            // Check bookmark exists
            if (document.Bookmarks.Exists(bookmark)) 
            {
                // Set bookmark text
                document.Bookmarks[bookmark].Range.Text = text; 
            }
        }

        private void UpdateHirer_Click(object sender, EventArgs e)
        {
            // TODO: Change record details

            // TODO: Update file

            // We dont wait until the user "saves", instead the file gets 
            // updated immediately anytime an operation happens.
        }

        private void AddHirer_Click(object sender, EventArgs e)
        {

        }

        private void DeleteHirer_Click(object sender, EventArgs e)
        {

        }

        private void AddPlant_Click(object sender, EventArgs e)
        {

        }

        private void UpdatePlant_Click(object sender, EventArgs e)
        {

        }

        private void DeletePlant_Click(object sender, EventArgs e)
        {

        }
    }
}
