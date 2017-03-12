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
            this.WeeklyRate = new System.Windows.Forms.MaskedTextBox();
            this.DailyRate = new System.Windows.Forms.MaskedTextBox();
            this.DeliveryRate = new System.Windows.Forms.MaskedTextBox();
            this.CollectRate = new System.Windows.Forms.MaskedTextBox();
            this.OrderNumber = new System.Windows.Forms.MaskedTextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.HirerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HirerCode
            // 
            this.HirerCode.FormattingEnabled = true;
            this.HirerCode.Location = new System.Drawing.Point(12, 29);
            this.HirerCode.Name = "HirerCode";
            this.HirerCode.Size = new System.Drawing.Size(121, 24);
            this.HirerCode.TabIndex = 1;
            // 
            // HirerDataGridView
            // 
            this.HirerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HirerDataGridView.Location = new System.Drawing.Point(511, 12);
            this.HirerDataGridView.Name = "HirerDataGridView";
            this.HirerDataGridView.RowTemplate.Height = 24;
            this.HirerDataGridView.Size = new System.Drawing.Size(523, 290);
            this.HirerDataGridView.TabIndex = 18;
            this.HirerDataGridView.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hirer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // HirerName
            // 
            this.HirerName.Location = new System.Drawing.Point(12, 90);
            this.HirerName.Name = "HirerName";
            this.HirerName.Size = new System.Drawing.Size(203, 22);
            this.HirerName.TabIndex = 3;
            // 
            // HirerAddressLn1
            // 
            this.HirerAddressLn1.Location = new System.Drawing.Point(12, 135);
            this.HirerAddressLn1.Name = "HirerAddressLn1";
            this.HirerAddressLn1.Size = new System.Drawing.Size(203, 22);
            this.HirerAddressLn1.TabIndex = 5;
            // 
            // HirerAddressLn2
            // 
            this.HirerAddressLn2.Location = new System.Drawing.Point(12, 163);
            this.HirerAddressLn2.Name = "HirerAddressLn2";
            this.HirerAddressLn2.Size = new System.Drawing.Size(203, 22);
            this.HirerAddressLn2.TabIndex = 6;
            // 
            // HirerAddressLn3
            // 
            this.HirerAddressLn3.Location = new System.Drawing.Point(12, 191);
            this.HirerAddressLn3.Name = "HirerAddressLn3";
            this.HirerAddressLn3.Size = new System.Drawing.Size(203, 22);
            this.HirerAddressLn3.TabIndex = 7;
            // 
            // HirerAddressLn4
            // 
            this.HirerAddressLn4.Location = new System.Drawing.Point(12, 219);
            this.HirerAddressLn4.Name = "HirerAddressLn4";
            this.HirerAddressLn4.Size = new System.Drawing.Size(203, 22);
            this.HirerAddressLn4.TabIndex = 8;
            // 
            // HirerAddressLn5
            // 
            this.HirerAddressLn5.Location = new System.Drawing.Point(12, 247);
            this.HirerAddressLn5.Name = "HirerAddressLn5";
            this.HirerAddressLn5.Size = new System.Drawing.Size(203, 22);
            this.HirerAddressLn5.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Site";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Address";
            // 
            // SiteName
            // 
            this.SiteName.Location = new System.Drawing.Point(302, 90);
            this.SiteName.Name = "SiteName";
            this.SiteName.Size = new System.Drawing.Size(203, 22);
            this.SiteName.TabIndex = 11;
            // 
            // SiteAddressLn1
            // 
            this.SiteAddressLn1.Location = new System.Drawing.Point(302, 135);
            this.SiteAddressLn1.Name = "SiteAddressLn1";
            this.SiteAddressLn1.Size = new System.Drawing.Size(203, 22);
            this.SiteAddressLn1.TabIndex = 13;
            // 
            // SiteAddressLn2
            // 
            this.SiteAddressLn2.Location = new System.Drawing.Point(302, 163);
            this.SiteAddressLn2.Name = "SiteAddressLn2";
            this.SiteAddressLn2.Size = new System.Drawing.Size(203, 22);
            this.SiteAddressLn2.TabIndex = 14;
            // 
            // SiteAddressLn3
            // 
            this.SiteAddressLn3.Location = new System.Drawing.Point(302, 191);
            this.SiteAddressLn3.Name = "SiteAddressLn3";
            this.SiteAddressLn3.Size = new System.Drawing.Size(203, 22);
            this.SiteAddressLn3.TabIndex = 15;
            // 
            // SiteAddressLn4
            // 
            this.SiteAddressLn4.Location = new System.Drawing.Point(302, 219);
            this.SiteAddressLn4.Name = "SiteAddressLn4";
            this.SiteAddressLn4.Size = new System.Drawing.Size(203, 22);
            this.SiteAddressLn4.TabIndex = 16;
            // 
            // SiteAddressLn5
            // 
            this.SiteAddressLn5.Location = new System.Drawing.Point(302, 247);
            this.SiteAddressLn5.Name = "SiteAddressLn5";
            this.SiteAddressLn5.Size = new System.Drawing.Size(203, 22);
            this.SiteAddressLn5.TabIndex = 17;
            // 
            // PlantCode
            // 
            this.PlantCode.FormattingEnabled = true;
            this.PlantCode.Location = new System.Drawing.Point(12, 345);
            this.PlantCode.Name = "PlantCode";
            this.PlantCode.Size = new System.Drawing.Size(121, 24);
            this.PlantCode.TabIndex = 23;
            // 
            // PlantDetailLn1
            // 
            this.PlantDetailLn1.Location = new System.Drawing.Point(12, 406);
            this.PlantDetailLn1.Name = "PlantDetailLn1";
            this.PlantDetailLn1.Size = new System.Drawing.Size(203, 22);
            this.PlantDetailLn1.TabIndex = 25;
            // 
            // PlantDetailLn2
            // 
            this.PlantDetailLn2.Location = new System.Drawing.Point(12, 434);
            this.PlantDetailLn2.Name = "PlantDetailLn2";
            this.PlantDetailLn2.Size = new System.Drawing.Size(203, 22);
            this.PlantDetailLn2.TabIndex = 26;
            // 
            // PlantDetailLn3
            // 
            this.PlantDetailLn3.Location = new System.Drawing.Point(12, 462);
            this.PlantDetailLn3.Name = "PlantDetailLn3";
            this.PlantDetailLn3.Size = new System.Drawing.Size(203, 22);
            this.PlantDetailLn3.TabIndex = 27;
            // 
            // PlantDetailLn4
            // 
            this.PlantDetailLn4.Location = new System.Drawing.Point(12, 490);
            this.PlantDetailLn4.Name = "PlantDetailLn4";
            this.PlantDetailLn4.Size = new System.Drawing.Size(203, 22);
            this.PlantDetailLn4.TabIndex = 28;
            // 
            // PlantDetailLn5
            // 
            this.PlantDetailLn5.Location = new System.Drawing.Point(12, 518);
            this.PlantDetailLn5.Name = "PlantDetailLn5";
            this.PlantDetailLn5.Size = new System.Drawing.Size(203, 22);
            this.PlantDetailLn5.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Plant Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Plant Detail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Weekly Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Daily Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Delivery Rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(236, 463);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Collect Rate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(236, 491);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "Order Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(236, 519);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 17);
            this.label13.TabIndex = 40;
            this.label13.Text = "Commencement Date";
            // 
            // WeeklyRate
            // 
            this.WeeklyRate.Location = new System.Drawing.Point(385, 376);
            this.WeeklyRate.Name = "WeeklyRate";
            this.WeeklyRate.Size = new System.Drawing.Size(120, 22);
            this.WeeklyRate.TabIndex = 31;
            // 
            // DailyRate
            // 
            this.DailyRate.Location = new System.Drawing.Point(385, 404);
            this.DailyRate.Name = "DailyRate";
            this.DailyRate.Size = new System.Drawing.Size(120, 22);
            this.DailyRate.TabIndex = 33;
            // 
            // DeliveryRate
            // 
            this.DeliveryRate.Location = new System.Drawing.Point(385, 432);
            this.DeliveryRate.Name = "DeliveryRate";
            this.DeliveryRate.Size = new System.Drawing.Size(120, 22);
            this.DeliveryRate.TabIndex = 35;
            // 
            // CollectRate
            // 
            this.CollectRate.Location = new System.Drawing.Point(385, 460);
            this.CollectRate.Name = "CollectRate";
            this.CollectRate.Size = new System.Drawing.Size(120, 22);
            this.CollectRate.TabIndex = 37;
            // 
            // OrderNumber
            // 
            this.OrderNumber.Location = new System.Drawing.Point(385, 488);
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Size = new System.Drawing.Size(120, 22);
            this.OrderNumber.TabIndex = 39;
            // 
            // CommencementDate
            // 
            this.CommencementDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CommencementDate.Location = new System.Drawing.Point(385, 516);
            this.CommencementDate.Name = "CommencementDate";
            this.CommencementDate.Size = new System.Drawing.Size(120, 22);
            this.CommencementDate.TabIndex = 41;
            // 
            // MachineDataGridView
            // 
            this.MachineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MachineDataGridView.Location = new System.Drawing.Point(511, 325);
            this.MachineDataGridView.Name = "MachineDataGridView";
            this.MachineDataGridView.RowTemplate.Height = 24;
            this.MachineDataGridView.Size = new System.Drawing.Size(523, 246);
            this.MachineDataGridView.TabIndex = 42;
            this.MachineDataGridView.TabStop = false;
            // 
            // AddHirer
            // 
            this.AddHirer.Location = new System.Drawing.Point(183, 275);
            this.AddHirer.Name = "AddHirer";
            this.AddHirer.Size = new System.Drawing.Size(114, 27);
            this.AddHirer.TabIndex = 19;
            this.AddHirer.Text = "Add New Hirer";
            this.AddHirer.UseVisualStyleBackColor = true;
            // 
            // UpdateHirer
            // 
            this.UpdateHirer.Location = new System.Drawing.Point(303, 275);
            this.UpdateHirer.Name = "UpdateHirer";
            this.UpdateHirer.Size = new System.Drawing.Size(98, 27);
            this.UpdateHirer.TabIndex = 20;
            this.UpdateHirer.Text = "Update Hirer";
            this.UpdateHirer.UseVisualStyleBackColor = true;
            // 
            // DeleteHirer
            // 
            this.DeleteHirer.Location = new System.Drawing.Point(407, 275);
            this.DeleteHirer.Name = "DeleteHirer";
            this.DeleteHirer.Size = new System.Drawing.Size(98, 27);
            this.DeleteHirer.TabIndex = 21;
            this.DeleteHirer.Text = "Delete Hirer";
            this.DeleteHirer.UseVisualStyleBackColor = true;
            // 
            // AddPlant
            // 
            this.AddPlant.Location = new System.Drawing.Point(182, 544);
            this.AddPlant.Name = "AddPlant";
            this.AddPlant.Size = new System.Drawing.Size(114, 27);
            this.AddPlant.TabIndex = 43;
            this.AddPlant.Text = "Add New Plant";
            this.AddPlant.UseVisualStyleBackColor = true;
            // 
            // UpdatePlant
            // 
            this.UpdatePlant.Location = new System.Drawing.Point(302, 544);
            this.UpdatePlant.Name = "UpdatePlant";
            this.UpdatePlant.Size = new System.Drawing.Size(98, 27);
            this.UpdatePlant.TabIndex = 44;
            this.UpdatePlant.Text = "Update Plant";
            this.UpdatePlant.UseVisualStyleBackColor = true;
            // 
            // DeletePlant
            // 
            this.DeletePlant.Location = new System.Drawing.Point(407, 544);
            this.DeletePlant.Name = "DeletePlant";
            this.DeletePlant.Size = new System.Drawing.Size(98, 27);
            this.DeletePlant.TabIndex = 45;
            this.DeletePlant.Text = "Delete Plant";
            this.DeletePlant.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(12, 590);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 27);
            this.Clear.TabIndex = 46;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(94, 590);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 27);
            this.Print.TabIndex = 47;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 632);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.DeletePlant);
            this.Controls.Add(this.UpdatePlant);
            this.Controls.Add(this.AddPlant);
            this.Controls.Add(this.DeleteHirer);
            this.Controls.Add(this.UpdateHirer);
            this.Controls.Add(this.AddHirer);
            this.Controls.Add(this.MachineDataGridView);
            this.Controls.Add(this.CommencementDate);
            this.Controls.Add(this.OrderNumber);
            this.Controls.Add(this.CollectRate);
            this.Controls.Add(this.DeliveryRate);
            this.Controls.Add(this.DailyRate);
            this.Controls.Add(this.WeeklyRate);
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
            this.Controls.Add(this.HirerDataGridView);
            this.Controls.Add(this.HirerCode);
            this.Name = "Form1";
            this.Text = "Fisher Plant HIre";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HirerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineDataGridView)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox WeeklyRate;
        private System.Windows.Forms.MaskedTextBox DailyRate;
        private System.Windows.Forms.MaskedTextBox DeliveryRate;
        private System.Windows.Forms.MaskedTextBox CollectRate;
        private System.Windows.Forms.MaskedTextBox OrderNumber;
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
    }
}

