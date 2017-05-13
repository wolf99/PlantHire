namespace FisherPlantHire
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HirerCode = new System.Windows.Forms.ComboBox();
            this.HirerDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HirerName = new System.Windows.Forms.TextBox();
            this.HirerAddressLn1 = new System.Windows.Forms.TextBox();
            this.HirerAddressLn2 = new System.Windows.Forms.TextBox();
            this.HirerAddressLn3 = new System.Windows.Forms.TextBox();
            this.HirerAddressLn4 = new System.Windows.Forms.TextBox();
            this.HirerAddressLn5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SiteName = new System.Windows.Forms.TextBox();
            this.SiteAddressLn1 = new System.Windows.Forms.TextBox();
            this.SiteAddressLn2 = new System.Windows.Forms.TextBox();
            this.SiteAddressLn3 = new System.Windows.Forms.TextBox();
            this.SiteAddressLn4 = new System.Windows.Forms.TextBox();
            this.SiteAddressLn5 = new System.Windows.Forms.TextBox();
            this.PlantCode = new System.Windows.Forms.ComboBox();
            this.PlantDetailLn1 = new System.Windows.Forms.TextBox();
            this.PlantDetailLn2 = new System.Windows.Forms.TextBox();
            this.PlantDetailLn3 = new System.Windows.Forms.TextBox();
            this.PlantDetailLn4 = new System.Windows.Forms.TextBox();
            this.PlantDetailLn5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CommencementDate = new System.Windows.Forms.DateTimePicker();
            this.MachineDataGridView = new System.Windows.Forms.DataGridView();
            this.AddHirer = new System.Windows.Forms.Button();
            this.UpdateHirer = new System.Windows.Forms.Button();
            this.DeleteHirer = new System.Windows.Forms.Button();
            this.AddPlant = new System.Windows.Forms.Button();
            this.UpdatePlant = new System.Windows.Forms.Button();
            this.DeletePlant = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.WeeklyRate = new System.Windows.Forms.TextBox();
            this.DailyRate = new System.Windows.Forms.TextBox();
            this.DeliveryRate = new System.Windows.Forms.TextBox();
            this.CollectRate = new System.Windows.Forms.TextBox();
            this.OrderNumber = new System.Windows.Forms.TextBox();
            this.Note = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HirerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HirerCode
            // 
            this.HirerCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.HirerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HirerCode.FormattingEnabled = true;
            this.HirerCode.Location = new System.Drawing.Point(12, 38);
            this.HirerCode.Margin = new System.Windows.Forms.Padding(2);
            this.HirerCode.Name = "HirerCode";
            this.HirerCode.Size = new System.Drawing.Size(122, 33);
            this.HirerCode.TabIndex = 1;
            // 
            // HirerDataGridView
            // 
            this.HirerDataGridView.AllowUserToAddRows = false;
            this.HirerDataGridView.AllowUserToDeleteRows = false;
            this.HirerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HirerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HirerDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.HirerDataGridView.Location = new System.Drawing.Point(0, 0);
            this.HirerDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.HirerDataGridView.Name = "HirerDataGridView";
            this.HirerDataGridView.ReadOnly = true;
            this.HirerDataGridView.RowHeadersVisible = false;
            this.HirerDataGridView.RowTemplate.Height = 24;
            this.HirerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HirerDataGridView.ShowEditingIcon = false;
            this.HirerDataGridView.Size = new System.Drawing.Size(522, 392);
            this.HirerDataGridView.TabIndex = 18;
            this.HirerDataGridView.TabStop = false;
            this.HirerDataGridView.SelectionChanged += new System.EventHandler(this.HirerDataGridView_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hirer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // HirerName
            // 
            this.HirerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.HirerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HirerName.Location = new System.Drawing.Point(12, 108);
            this.HirerName.Margin = new System.Windows.Forms.Padding(2);
            this.HirerName.Name = "HirerName";
            this.HirerName.Size = new System.Drawing.Size(215, 30);
            this.HirerName.TabIndex = 3;
            this.HirerName.Tag = "";
            // 
            // HirerAddressLn1
            // 
            this.HirerAddressLn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.HirerAddressLn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HirerAddressLn1.Location = new System.Drawing.Point(12, 168);
            this.HirerAddressLn1.Margin = new System.Windows.Forms.Padding(2);
            this.HirerAddressLn1.Name = "HirerAddressLn1";
            this.HirerAddressLn1.Size = new System.Drawing.Size(215, 30);
            this.HirerAddressLn1.TabIndex = 5;
            // 
            // HirerAddressLn2
            // 
            this.HirerAddressLn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.HirerAddressLn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HirerAddressLn2.Location = new System.Drawing.Point(12, 204);
            this.HirerAddressLn2.Margin = new System.Windows.Forms.Padding(2);
            this.HirerAddressLn2.Name = "HirerAddressLn2";
            this.HirerAddressLn2.Size = new System.Drawing.Size(215, 30);
            this.HirerAddressLn2.TabIndex = 6;
            // 
            // HirerAddressLn3
            // 
            this.HirerAddressLn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.HirerAddressLn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HirerAddressLn3.Location = new System.Drawing.Point(12, 240);
            this.HirerAddressLn3.Margin = new System.Windows.Forms.Padding(2);
            this.HirerAddressLn3.Name = "HirerAddressLn3";
            this.HirerAddressLn3.Size = new System.Drawing.Size(215, 30);
            this.HirerAddressLn3.TabIndex = 7;
            // 
            // HirerAddressLn4
            // 
            this.HirerAddressLn4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.HirerAddressLn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HirerAddressLn4.Location = new System.Drawing.Point(12, 276);
            this.HirerAddressLn4.Margin = new System.Windows.Forms.Padding(2);
            this.HirerAddressLn4.Name = "HirerAddressLn4";
            this.HirerAddressLn4.Size = new System.Drawing.Size(215, 30);
            this.HirerAddressLn4.TabIndex = 8;
            // 
            // HirerAddressLn5
            // 
            this.HirerAddressLn5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.HirerAddressLn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HirerAddressLn5.Location = new System.Drawing.Point(12, 312);
            this.HirerAddressLn5.Margin = new System.Windows.Forms.Padding(2);
            this.HirerAddressLn5.Name = "HirerAddressLn5";
            this.HirerAddressLn5.Size = new System.Drawing.Size(215, 30);
            this.HirerAddressLn5.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Site";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Address";
            // 
            // SiteName
            // 
            this.SiteName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SiteName.Enabled = false;
            this.SiteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteName.Location = new System.Drawing.Point(361, 108);
            this.SiteName.Margin = new System.Windows.Forms.Padding(2);
            this.SiteName.Name = "SiteName";
            this.SiteName.Size = new System.Drawing.Size(215, 30);
            this.SiteName.TabIndex = 11;
            // 
            // SiteAddressLn1
            // 
            this.SiteAddressLn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SiteAddressLn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteAddressLn1.Location = new System.Drawing.Point(361, 168);
            this.SiteAddressLn1.Margin = new System.Windows.Forms.Padding(2);
            this.SiteAddressLn1.Name = "SiteAddressLn1";
            this.SiteAddressLn1.Size = new System.Drawing.Size(215, 30);
            this.SiteAddressLn1.TabIndex = 13;
            // 
            // SiteAddressLn2
            // 
            this.SiteAddressLn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SiteAddressLn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteAddressLn2.Location = new System.Drawing.Point(361, 204);
            this.SiteAddressLn2.Margin = new System.Windows.Forms.Padding(2);
            this.SiteAddressLn2.Name = "SiteAddressLn2";
            this.SiteAddressLn2.Size = new System.Drawing.Size(215, 30);
            this.SiteAddressLn2.TabIndex = 14;
            // 
            // SiteAddressLn3
            // 
            this.SiteAddressLn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SiteAddressLn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteAddressLn3.Location = new System.Drawing.Point(361, 240);
            this.SiteAddressLn3.Margin = new System.Windows.Forms.Padding(2);
            this.SiteAddressLn3.Name = "SiteAddressLn3";
            this.SiteAddressLn3.Size = new System.Drawing.Size(215, 30);
            this.SiteAddressLn3.TabIndex = 15;
            // 
            // SiteAddressLn4
            // 
            this.SiteAddressLn4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SiteAddressLn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteAddressLn4.Location = new System.Drawing.Point(361, 276);
            this.SiteAddressLn4.Margin = new System.Windows.Forms.Padding(2);
            this.SiteAddressLn4.Name = "SiteAddressLn4";
            this.SiteAddressLn4.Size = new System.Drawing.Size(215, 30);
            this.SiteAddressLn4.TabIndex = 16;
            // 
            // SiteAddressLn5
            // 
            this.SiteAddressLn5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SiteAddressLn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteAddressLn5.Location = new System.Drawing.Point(361, 312);
            this.SiteAddressLn5.Margin = new System.Windows.Forms.Padding(2);
            this.SiteAddressLn5.Name = "SiteAddressLn5";
            this.SiteAddressLn5.Size = new System.Drawing.Size(215, 30);
            this.SiteAddressLn5.TabIndex = 17;
            // 
            // PlantCode
            // 
            this.PlantCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlantCode.FormattingEnabled = true;
            this.PlantCode.Location = new System.Drawing.Point(12, 432);
            this.PlantCode.Margin = new System.Windows.Forms.Padding(2);
            this.PlantCode.Name = "PlantCode";
            this.PlantCode.Size = new System.Drawing.Size(122, 33);
            this.PlantCode.TabIndex = 23;
            // 
            // PlantDetailLn1
            // 
            this.PlantDetailLn1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PlantDetailLn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlantDetailLn1.Location = new System.Drawing.Point(12, 502);
            this.PlantDetailLn1.Margin = new System.Windows.Forms.Padding(2);
            this.PlantDetailLn1.Name = "PlantDetailLn1";
            this.PlantDetailLn1.Size = new System.Drawing.Size(215, 30);
            this.PlantDetailLn1.TabIndex = 25;
            // 
            // PlantDetailLn2
            // 
            this.PlantDetailLn2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PlantDetailLn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlantDetailLn2.Location = new System.Drawing.Point(12, 539);
            this.PlantDetailLn2.Margin = new System.Windows.Forms.Padding(2);
            this.PlantDetailLn2.Name = "PlantDetailLn2";
            this.PlantDetailLn2.Size = new System.Drawing.Size(215, 30);
            this.PlantDetailLn2.TabIndex = 26;
            // 
            // PlantDetailLn3
            // 
            this.PlantDetailLn3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PlantDetailLn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlantDetailLn3.Location = new System.Drawing.Point(12, 575);
            this.PlantDetailLn3.Margin = new System.Windows.Forms.Padding(2);
            this.PlantDetailLn3.Name = "PlantDetailLn3";
            this.PlantDetailLn3.Size = new System.Drawing.Size(215, 30);
            this.PlantDetailLn3.TabIndex = 27;
            // 
            // PlantDetailLn4
            // 
            this.PlantDetailLn4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PlantDetailLn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlantDetailLn4.Location = new System.Drawing.Point(12, 611);
            this.PlantDetailLn4.Margin = new System.Windows.Forms.Padding(2);
            this.PlantDetailLn4.Name = "PlantDetailLn4";
            this.PlantDetailLn4.Size = new System.Drawing.Size(215, 30);
            this.PlantDetailLn4.TabIndex = 28;
            // 
            // PlantDetailLn5
            // 
            this.PlantDetailLn5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PlantDetailLn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlantDetailLn5.Location = new System.Drawing.Point(12, 648);
            this.PlantDetailLn5.Margin = new System.Windows.Forms.Padding(2);
            this.PlantDetailLn5.Name = "PlantDetailLn5";
            this.PlantDetailLn5.Size = new System.Drawing.Size(215, 30);
            this.PlantDetailLn5.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 405);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Plant Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 475);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Plant Detail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(236, 470);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Weekly Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(236, 506);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "Daily Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(236, 542);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 25);
            this.label10.TabIndex = 34;
            this.label10.Text = "Delivery Rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(236, 578);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Collect Rate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(236, 612);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 25);
            this.label12.TabIndex = 38;
            this.label12.Text = "Order Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(236, 650);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 25);
            this.label13.TabIndex = 40;
            this.label13.Text = "Commencement Date";
            // 
            // CommencementDate
            // 
            this.CommencementDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommencementDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CommencementDate.Location = new System.Drawing.Point(442, 646);
            this.CommencementDate.Margin = new System.Windows.Forms.Padding(2);
            this.CommencementDate.Name = "CommencementDate";
            this.CommencementDate.Size = new System.Drawing.Size(133, 30);
            this.CommencementDate.TabIndex = 41;
            // 
            // MachineDataGridView
            // 
            this.MachineDataGridView.AllowUserToAddRows = false;
            this.MachineDataGridView.AllowUserToDeleteRows = false;
            this.MachineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MachineDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MachineDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MachineDataGridView.Location = new System.Drawing.Point(0, 0);
            this.MachineDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.MachineDataGridView.Name = "MachineDataGridView";
            this.MachineDataGridView.ReadOnly = true;
            this.MachineDataGridView.RowHeadersVisible = false;
            this.MachineDataGridView.RowTemplate.Height = 24;
            this.MachineDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MachineDataGridView.Size = new System.Drawing.Size(522, 444);
            this.MachineDataGridView.TabIndex = 42;
            this.MachineDataGridView.TabStop = false;
            this.MachineDataGridView.SelectionChanged += new System.EventHandler(this.MachineDataGridView_SelectionChanged);
            // 
            // AddHirer
            // 
            this.AddHirer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHirer.Location = new System.Drawing.Point(256, 348);
            this.AddHirer.Margin = new System.Windows.Forms.Padding(2);
            this.AddHirer.Name = "AddHirer";
            this.AddHirer.Size = new System.Drawing.Size(114, 32);
            this.AddHirer.TabIndex = 19;
            this.AddHirer.Text = "Add New Hirer";
            this.AddHirer.UseVisualStyleBackColor = true;
            this.AddHirer.Click += new System.EventHandler(this.AddHirer_Click);
            // 
            // UpdateHirer
            // 
            this.UpdateHirer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateHirer.Location = new System.Drawing.Point(374, 348);
            this.UpdateHirer.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateHirer.Name = "UpdateHirer";
            this.UpdateHirer.Size = new System.Drawing.Size(98, 32);
            this.UpdateHirer.TabIndex = 20;
            this.UpdateHirer.Text = "Update Hirer";
            this.UpdateHirer.UseVisualStyleBackColor = true;
            this.UpdateHirer.Click += new System.EventHandler(this.UpdateHirer_Click);
            // 
            // DeleteHirer
            // 
            this.DeleteHirer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteHirer.Location = new System.Drawing.Point(476, 348);
            this.DeleteHirer.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteHirer.Name = "DeleteHirer";
            this.DeleteHirer.Size = new System.Drawing.Size(98, 32);
            this.DeleteHirer.TabIndex = 21;
            this.DeleteHirer.Text = "Delete Hirer";
            this.DeleteHirer.UseVisualStyleBackColor = true;
            this.DeleteHirer.Click += new System.EventHandler(this.DeleteHirer_Click);
            // 
            // AddPlant
            // 
            this.AddPlant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPlant.Location = new System.Drawing.Point(256, 785);
            this.AddPlant.Margin = new System.Windows.Forms.Padding(2);
            this.AddPlant.Name = "AddPlant";
            this.AddPlant.Size = new System.Drawing.Size(114, 32);
            this.AddPlant.TabIndex = 43;
            this.AddPlant.Text = "Add New Plant";
            this.AddPlant.UseVisualStyleBackColor = true;
            this.AddPlant.Click += new System.EventHandler(this.AddPlant_Click);
            // 
            // UpdatePlant
            // 
            this.UpdatePlant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePlant.Location = new System.Drawing.Point(374, 785);
            this.UpdatePlant.Margin = new System.Windows.Forms.Padding(2);
            this.UpdatePlant.Name = "UpdatePlant";
            this.UpdatePlant.Size = new System.Drawing.Size(98, 32);
            this.UpdatePlant.TabIndex = 44;
            this.UpdatePlant.Text = "Update Plant";
            this.UpdatePlant.UseVisualStyleBackColor = true;
            this.UpdatePlant.Click += new System.EventHandler(this.UpdatePlant_Click);
            // 
            // DeletePlant
            // 
            this.DeletePlant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePlant.Location = new System.Drawing.Point(476, 785);
            this.DeletePlant.Margin = new System.Windows.Forms.Padding(2);
            this.DeletePlant.Name = "DeletePlant";
            this.DeletePlant.Size = new System.Drawing.Size(98, 32);
            this.DeletePlant.TabIndex = 45;
            this.DeletePlant.Text = "Delete Plant";
            this.DeletePlant.UseVisualStyleBackColor = true;
            this.DeletePlant.Click += new System.EventHandler(this.DeletePlant_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(12, 825);
            this.Clear.Margin = new System.Windows.Forms.Padding(2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 32);
            this.Clear.TabIndex = 46;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Print
            // 
            this.Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.Location = new System.Drawing.Point(92, 825);
            this.Print.Margin = new System.Windows.Forms.Padding(2);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 32);
            this.Print.TabIndex = 47;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(581, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.HirerDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MachineDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(522, 844);
            this.splitContainer1.SplitterDistance = 392;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 48;
            // 
            // WeeklyRate
            // 
            this.WeeklyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeeklyRate.Location = new System.Drawing.Point(442, 467);
            this.WeeklyRate.Name = "WeeklyRate";
            this.WeeklyRate.Size = new System.Drawing.Size(133, 30);
            this.WeeklyRate.TabIndex = 31;
            // 
            // DailyRate
            // 
            this.DailyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyRate.Location = new System.Drawing.Point(442, 503);
            this.DailyRate.Name = "DailyRate";
            this.DailyRate.Size = new System.Drawing.Size(133, 30);
            this.DailyRate.TabIndex = 33;
            // 
            // DeliveryRate
            // 
            this.DeliveryRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryRate.Location = new System.Drawing.Point(443, 539);
            this.DeliveryRate.Name = "DeliveryRate";
            this.DeliveryRate.Size = new System.Drawing.Size(133, 30);
            this.DeliveryRate.TabIndex = 35;
            // 
            // CollectRate
            // 
            this.CollectRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectRate.Location = new System.Drawing.Point(443, 575);
            this.CollectRate.Name = "CollectRate";
            this.CollectRate.Size = new System.Drawing.Size(133, 30);
            this.CollectRate.TabIndex = 37;
            // 
            // OrderNumber
            // 
            this.OrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNumber.Location = new System.Drawing.Point(442, 611);
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Size = new System.Drawing.Size(133, 30);
            this.OrderNumber.TabIndex = 39;
            // 
            // Note
            // 
            this.Note.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note.Location = new System.Drawing.Point(11, 714);
            this.Note.Margin = new System.Windows.Forms.Padding(2);
            this.Note.Multiline = true;
            this.Note.Name = "Note";
            this.Note.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Note.Size = new System.Drawing.Size(564, 65);
            this.Note.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 687);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 25);
            this.label14.TabIndex = 50;
            this.label14.Text = "Note";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1115, 868);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.OrderNumber);
            this.Controls.Add(this.CollectRate);
            this.Controls.Add(this.DeliveryRate);
            this.Controls.Add(this.DailyRate);
            this.Controls.Add(this.WeeklyRate);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.DeletePlant);
            this.Controls.Add(this.UpdatePlant);
            this.Controls.Add(this.AddPlant);
            this.Controls.Add(this.DeleteHirer);
            this.Controls.Add(this.UpdateHirer);
            this.Controls.Add(this.AddHirer);
            this.Controls.Add(this.CommencementDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PlantDetailLn5);
            this.Controls.Add(this.PlantDetailLn4);
            this.Controls.Add(this.PlantDetailLn3);
            this.Controls.Add(this.PlantDetailLn2);
            this.Controls.Add(this.PlantDetailLn1);
            this.Controls.Add(this.PlantCode);
            this.Controls.Add(this.SiteAddressLn5);
            this.Controls.Add(this.SiteAddressLn4);
            this.Controls.Add(this.SiteAddressLn3);
            this.Controls.Add(this.SiteAddressLn2);
            this.Controls.Add(this.SiteAddressLn1);
            this.Controls.Add(this.SiteName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HirerAddressLn5);
            this.Controls.Add(this.HirerAddressLn4);
            this.Controls.Add(this.HirerAddressLn3);
            this.Controls.Add(this.HirerAddressLn2);
            this.Controls.Add(this.HirerAddressLn1);
            this.Controls.Add(this.HirerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HirerCode);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Fisher Plant Hire Invoice Generation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HirerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineDataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox HirerCode;
        private System.Windows.Forms.DataGridView HirerDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HirerName;
        private System.Windows.Forms.TextBox HirerAddressLn1;
        private System.Windows.Forms.TextBox HirerAddressLn2;
        private System.Windows.Forms.TextBox HirerAddressLn3;
        private System.Windows.Forms.TextBox HirerAddressLn4;
        private System.Windows.Forms.TextBox HirerAddressLn5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SiteName;
        private System.Windows.Forms.TextBox SiteAddressLn1;
        private System.Windows.Forms.TextBox SiteAddressLn2;
        private System.Windows.Forms.TextBox SiteAddressLn3;
        private System.Windows.Forms.TextBox SiteAddressLn4;
        private System.Windows.Forms.TextBox SiteAddressLn5;
        private System.Windows.Forms.ComboBox PlantCode;
        private System.Windows.Forms.TextBox PlantDetailLn1;
        private System.Windows.Forms.TextBox PlantDetailLn2;
        private System.Windows.Forms.TextBox PlantDetailLn3;
        private System.Windows.Forms.TextBox PlantDetailLn4;
        private System.Windows.Forms.TextBox PlantDetailLn5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker CommencementDate;
        private System.Windows.Forms.DataGridView MachineDataGridView;
        private System.Windows.Forms.Button AddHirer;
        private System.Windows.Forms.Button UpdateHirer;
        private System.Windows.Forms.Button DeleteHirer;
        private System.Windows.Forms.Button AddPlant;
        private System.Windows.Forms.Button UpdatePlant;
        private System.Windows.Forms.Button DeletePlant;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox WeeklyRate;
        private System.Windows.Forms.TextBox DailyRate;
        private System.Windows.Forms.TextBox DeliveryRate;
        private System.Windows.Forms.TextBox CollectRate;
        private System.Windows.Forms.TextBox OrderNumber;
        private System.Windows.Forms.TextBox Note;
        private System.Windows.Forms.Label label14;
    }
}

