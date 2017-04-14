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
        private Word.Application wordApp = null;
        private Word.Document wordDoc = null;

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

            // Bind factories to BindingSources
            if (File.Exists(HirerCsvPath))
                Hirers.DataSource = new SortableBindingList<Hirer>(GetListFromCsvFile<Hirer>(hf, HirerCsvPath));
            else
                Hirers.DataSource = new SortableBindingList<Hirer>();

            if (File.Exists(PlantCsvPath))
                Machines.DataSource = new SortableBindingList<Machine>(GetListFromCsvFile<Machine>(mf, PlantCsvPath));
            else
                Machines.DataSource = new SortableBindingList<Machine>();

            HirerDataGridView.DataSource = Hirers; // Bind form controls to BindingSources
            HirerCode.DataSource = Hirers;
            HirerCode.DisplayMember = "Code";
            HirerCode.ValueMember = "Code";

            MachineDataGridView.DataSource = Machines;
            PlantCode.DataSource = Machines;
            PlantCode.DisplayMember = "Code";
            PlantCode.ValueMember = "Code";

            // Start data sources alphabetically sorted by the Code column (i.e. A to Z)
            HirerDataGridView.Sort(HirerDataGridView.Columns["Code"], ListSortDirection.Ascending);
            MachineDataGridView.Sort(MachineDataGridView.Columns["Code"], ListSortDirection.Ascending);

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

            // Code column should only be the minimum width.
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

            // Add handlers for the event raised when adding a new row using 
            // the "Add" button
            HirerDataGridView.RowsAdded += DataGridView_RowsAdded;
            MachineDataGridView.RowsAdded += DataGridView_RowsAdded;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // This overrides the forms ProcessCmdKey method so that we can
            // catch certain keyboard shortcuts (WinForms, only normally
            // supports this type of functionality for specific controls 
            // otherwise)

            var e = new KeyEventArgs(keyData);

            // Check if the command key combination is 'Ctrl + P'
            if (e.Control && e.KeyCode == Keys.P)
            {
                // Run the Print button handler
                Print_Click(Print, new EventArgs());
                // Indicate that the command key has been handled
                return true;
            }

            // Handle the command key normally, using the overridden method
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void HirerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (HirerDataGridView.SelectedRows?.Count > 0)
            {
                var h = (Hirer)HirerDataGridView.SelectedRows[0].DataBoundItem;
                HirerCode.Text = h.Code;
                HirerName.Text = h.Name;
                HirerAddressLn1.Text = h.AddressLn1;
                HirerAddressLn2.Text = h.AddressLn2;
                HirerAddressLn3.Text = h.AddressLn3;
                HirerAddressLn4.Text = h.AddressLn4;
                HirerAddressLn5.Text = h.AddressLn5;
            }
        }

        private void MachineDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (MachineDataGridView.SelectedRows?.Count > 0)
            {
                var m = (Machine)MachineDataGridView.SelectedRows[0].DataBoundItem;
                PlantCode.Text = m.Code;
                PlantDetailLn1.Text = m.DetailLn1;
                PlantDetailLn2.Text = m.DetailLn2;
                PlantDetailLn3.Text = m.DetailLn3;
                PlantDetailLn4.Text = m.DetailLn4;
                PlantDetailLn5.Text = m.DetailLn5;
                WeeklyRate.Text = m.WeeklyRate.ToString();
                DailyRate.Text = m.DailyRate.ToString();
            }
        }

        private void AddHirer_Click(object sender, EventArgs e)
        {
            // Create and populate a new Hirer object
            var h = new Hirer()
            {
                Code = HirerCode.Text,
                Name = HirerName.Text,
                AddressLn1 = HirerAddressLn1.Text,
                AddressLn2 = HirerAddressLn2.Text,
                AddressLn3 = HirerAddressLn3.Text,
                AddressLn4 = HirerAddressLn4.Text,
                AddressLn5 = HirerAddressLn5.Text,
            };

            // Add the new object to the Binding source
            // This causes the RowsAdded event to be raised
            Hirers.Add(h);
            // Save the change to file
            UpdateCsvFile<Hirer>(((SortableBindingList<Hirer>)Hirers.DataSource).ToList(), HirerCsvPath);
        }

        private void AddPlant_Click(object sender, EventArgs e)
        {
            // Create and populate a new Machine object
            var m = new Machine()
            {
                Code = HirerCode.Text,
                DetailLn1 = PlantDetailLn1.Text,
                DetailLn2 = PlantDetailLn2.Text,
                DetailLn3 = PlantDetailLn3.Text,
                DetailLn4 = PlantDetailLn4.Text,
                DetailLn5 = PlantDetailLn5.Text,
                WeeklyRate = Decimal.Parse(WeeklyRate.Text),
                DailyRate = Decimal.Parse(DailyRate.Text)
            };

            // Add the new object to the Binding source
            // This causes the RowsAdded event to be raised
            Machines.Add(m);
            // Save the change to file
            UpdateCsvFile<Machine>(((SortableBindingList<Machine>)Machines.DataSource).ToList(), PlantCsvPath);
        }

        private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // De-select any currently selected rows
            foreach (DataGridViewRow Row in ((DataGridView)sender).SelectedRows)
            {
                Row.Selected = false;
            }
            // Select the newly added row.
            // This means the other fields will show the new object details
            ((DataGridView)sender).Rows[e.RowIndex].Selected = true;
        }

        private void UpdateHirer_Click(object sender, EventArgs e)
        {
            // Create and populate a new Hirer object
            var h = new Hirer()
            {
                Code = HirerCode.Text,
                Name = HirerName.Text,
                AddressLn1 = HirerAddressLn1.Text,
                AddressLn2 = HirerAddressLn2.Text,
                AddressLn3 = HirerAddressLn3.Text,
                AddressLn4 = HirerAddressLn4.Text,
                AddressLn5 = HirerAddressLn5.Text
            };

            // Get indes of selected item to update
            var i = HirerDataGridView.SelectedRows[0].Index;

            // Update the item on the binding source
            var l = (SortableBindingList<Hirer>)Hirers.DataSource;
            l[i] = h;
            Hirers.DataSource = l;

            // Save the changes to file
            UpdateCsvFile<Hirer>(l.ToList(), HirerCsvPath);
        }

        private void UpdatePlant_Click(object sender, EventArgs e)
        {
            // Create and populate a new Machine object
            var m = new Machine()
            {
                Code = PlantCode.Text,
                DetailLn1 = PlantDetailLn1.Text,
                DetailLn2 = PlantDetailLn2.Text,
                DetailLn3 = PlantDetailLn3.Text,
                DetailLn4 = PlantDetailLn4.Text,
                DetailLn5 = PlantDetailLn5.Text,
                WeeklyRate = Decimal.Parse(WeeklyRate.Text),
                DailyRate = Decimal.Parse(DailyRate.Text)
            };

            // Get index of selected item to update
            var i = MachineDataGridView.SelectedRows[0].Index;

            // Update the item on the binding source
            var l = (SortableBindingList<Machine>)Machines.DataSource;
            l[i] = m;
            Machines.DataSource = l;

            // Save the change to file
            UpdateCsvFile<Machine>(l.ToList(), PlantCsvPath);
        }

        private void DeleteHirer_Click(object sender, EventArgs e)
        {
            // TODO: Implement hirer delete
            //// Remove the item from the binding source
            //Hirers.RemoveCurrent();

            //// Save the change to file
            //UpdateCsvFile<Hirer>(((SortableBindingList<Hirer>)Hirers.DataSource).ToList(), HirerCsvPath);
        }

        private void DeletePlant_Click(object sender, EventArgs e)
        {
            // TODO: Implement plant delete
            //// Remove the item from the binding source
            //Hirers.RemoveCurrent();

            //// Save the change to file
            //UpdateCsvFile<Hirer>(((SortableBindingList<Hirer>)Hirers.DataSource).ToList(), HirerCsvPath);
        }

        private void Print_Click(object sender, EventArgs e)
        {
            // Open MS Word template ready for use
            OpenTemplate(ContractTemplatePath);

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
                    wordDoc.PrintOut(Copies: pd.PrinterSettings.Copies);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            // Change the cursor to indicate the application is busy
            Cursor.Current = Cursors.WaitCursor;

            // Wait until the printing is done
            while (wordApp.BackgroundPrintingStatus != 0)
            {
                Application.DoEvents();
                Application.DoEvents();
            }

            // Revert the cursor to normal
            Cursor.Current = Cursors.Default;


            // Close the MS Word template document, discarding any changes
            CloseTemplate();
        }

        private void OpenTemplate(string path)
        {
            // Check MS Word dotx template exists
            if (!File.Exists(path))
            {
                string message = string.Format("Cant find: {0}\nWill not be able to print or save contract", path);
                var response = MessageBox.Show(message, "Cannot find contract template", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (response == DialogResult.Cancel)
                {
                    Environment.Exit(0);
                }
            }

            try
            {
                // Attempt to open the MS Word application via Office Interop
                wordApp = new Word.Application();
            }
            catch (Exception error)
            {
                MessageBox.Show("Could not open MS Word via Interop\n" + error.Message);
                wordApp = null;
                return;
            }

            try
            {
                // Attempt to open the template document in MS Word invisibly
                wordDoc = wordApp.Documents.Add(Template: path, Visible: false);
            }
            catch (Exception error)
            {
                MessageBox.Show("Could not open MS Word template document\n" + error.Message);
                wordApp.Quit();
                wordDoc = null;
                wordApp = null;
                return;
            }
        }

        private void CloseTemplate()
        {
            if (wordDoc != null)
            {
                // Attempt to close the MS Word dotx template file without
                // saving any changes. Then close the MS Word application.
                try
                {
                    wordDoc.Close(SaveChanges: false);
                    wordApp.Quit(SaveChanges: false);
                    wordDoc = null;
                    wordApp = null;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
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

        private void UpdateCsvFile<T>(List<T> records, string path)
        {
            FileStream fs;
            StreamWriter sw;

            if (records.Count == 0)
                return;

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
            foreach (T r in records)
            {
                sw.WriteLine(r.ToString());
            }

            // Close the StreamWriter and then the file stream (clsoes the file)
            sw.Close();
            fs.Close();
        }
    }
}
