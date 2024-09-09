namespace SemesterProject
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
            this.OilLubeGroupBox = new System.Windows.Forms.GroupBox();
            this.FlushGroupBox = new System.Windows.Forms.GroupBox();
            this.MiscGroupBox = new System.Windows.Forms.GroupBox();
            this.AdditionalChargesGroupBox = new System.Windows.Forms.GroupBox();
            this.SummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.OilChangeCheckedBox = new System.Windows.Forms.CheckBox();
            this.LubeJobCheckedBox = new System.Windows.Forms.CheckBox();
            this.RadiatorFlushCheckedBox = new System.Windows.Forms.CheckBox();
            this.TransmissionFlushCheckedBox = new System.Windows.Forms.CheckBox();
            this.InspectionCheckedBox = new System.Windows.Forms.CheckBox();
            this.ReplaceMufflerCheckedBox = new System.Windows.Forms.CheckBox();
            this.TireRotationCheckedBox = new System.Windows.Forms.CheckBox();
            this.PartsPromptLabel = new System.Windows.Forms.Label();
            this.LaborPromptLabel = new System.Windows.Forms.Label();
            this.PartsTextBox = new System.Windows.Forms.TextBox();
            this.LaborTextbox = new System.Windows.Forms.TextBox();
            this.ServiceChargeLabel = new System.Windows.Forms.Label();
            this.TotalFeesLabel = new System.Windows.Forms.Label();
            this.TaxOnPartsLabel = new System.Windows.Forms.Label();
            this.AdditionalLaborLabel = new System.Windows.Forms.Label();
            this.AdditionalPartsLabel = new System.Windows.Forms.Label();
            this.ServiceChargePromptLabel = new System.Windows.Forms.Label();
            this.AdditionalPartsPromptLabel = new System.Windows.Forms.Label();
            this.AdditionalLaborPromptLabel = new System.Windows.Forms.Label();
            this.TaxOnPartsPromptLabel = new System.Windows.Forms.Label();
            this.TotalFeesPromptLabel = new System.Windows.Forms.Label();
            this.itemizedSelectedPromptLabel = new System.Windows.Forms.Label();
            this.ItemizedSelectedListBox = new System.Windows.Forms.ListBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ProgrammedByLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OilLubeGroupBox.SuspendLayout();
            this.FlushGroupBox.SuspendLayout();
            this.MiscGroupBox.SuspendLayout();
            this.AdditionalChargesGroupBox.SuspendLayout();
            this.SummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OilLubeGroupBox
            // 
            this.OilLubeGroupBox.Controls.Add(this.LubeJobCheckedBox);
            this.OilLubeGroupBox.Controls.Add(this.OilChangeCheckedBox);
            this.OilLubeGroupBox.Location = new System.Drawing.Point(13, 13);
            this.OilLubeGroupBox.Name = "OilLubeGroupBox";
            this.OilLubeGroupBox.Size = new System.Drawing.Size(160, 70);
            this.OilLubeGroupBox.TabIndex = 0;
            this.OilLubeGroupBox.TabStop = false;
            this.OilLubeGroupBox.Text = "Oil and Lube";
            // 
            // FlushGroupBox
            // 
            this.FlushGroupBox.Controls.Add(this.TransmissionFlushCheckedBox);
            this.FlushGroupBox.Controls.Add(this.RadiatorFlushCheckedBox);
            this.FlushGroupBox.Location = new System.Drawing.Point(179, 13);
            this.FlushGroupBox.Name = "FlushGroupBox";
            this.FlushGroupBox.Size = new System.Drawing.Size(178, 70);
            this.FlushGroupBox.TabIndex = 1;
            this.FlushGroupBox.TabStop = false;
            this.FlushGroupBox.Text = "Flushes";
            // 
            // MiscGroupBox
            // 
            this.MiscGroupBox.Controls.Add(this.TireRotationCheckedBox);
            this.MiscGroupBox.Controls.Add(this.ReplaceMufflerCheckedBox);
            this.MiscGroupBox.Controls.Add(this.InspectionCheckedBox);
            this.MiscGroupBox.Location = new System.Drawing.Point(13, 89);
            this.MiscGroupBox.Name = "MiscGroupBox";
            this.MiscGroupBox.Size = new System.Drawing.Size(160, 100);
            this.MiscGroupBox.TabIndex = 2;
            this.MiscGroupBox.TabStop = false;
            this.MiscGroupBox.Text = "Misc";
            // 
            // AdditionalChargesGroupBox
            // 
            this.AdditionalChargesGroupBox.Controls.Add(this.LaborTextbox);
            this.AdditionalChargesGroupBox.Controls.Add(this.PartsTextBox);
            this.AdditionalChargesGroupBox.Controls.Add(this.LaborPromptLabel);
            this.AdditionalChargesGroupBox.Controls.Add(this.PartsPromptLabel);
            this.AdditionalChargesGroupBox.Location = new System.Drawing.Point(179, 89);
            this.AdditionalChargesGroupBox.Name = "AdditionalChargesGroupBox";
            this.AdditionalChargesGroupBox.Size = new System.Drawing.Size(178, 100);
            this.AdditionalChargesGroupBox.TabIndex = 3;
            this.AdditionalChargesGroupBox.TabStop = false;
            this.AdditionalChargesGroupBox.Text = "Other Additional Charges";
            // 
            // SummaryGroupBox
            // 
            this.SummaryGroupBox.Controls.Add(this.ItemizedSelectedListBox);
            this.SummaryGroupBox.Controls.Add(this.itemizedSelectedPromptLabel);
            this.SummaryGroupBox.Controls.Add(this.TotalFeesPromptLabel);
            this.SummaryGroupBox.Controls.Add(this.TaxOnPartsPromptLabel);
            this.SummaryGroupBox.Controls.Add(this.AdditionalLaborPromptLabel);
            this.SummaryGroupBox.Controls.Add(this.AdditionalPartsPromptLabel);
            this.SummaryGroupBox.Controls.Add(this.ServiceChargePromptLabel);
            this.SummaryGroupBox.Controls.Add(this.AdditionalPartsLabel);
            this.SummaryGroupBox.Controls.Add(this.AdditionalLaborLabel);
            this.SummaryGroupBox.Controls.Add(this.TaxOnPartsLabel);
            this.SummaryGroupBox.Controls.Add(this.TotalFeesLabel);
            this.SummaryGroupBox.Controls.Add(this.ServiceChargeLabel);
            this.SummaryGroupBox.Location = new System.Drawing.Point(13, 195);
            this.SummaryGroupBox.Name = "SummaryGroupBox";
            this.SummaryGroupBox.Size = new System.Drawing.Size(344, 287);
            this.SummaryGroupBox.TabIndex = 4;
            this.SummaryGroupBox.TabStop = false;
            this.SummaryGroupBox.Text = "Summary";
            // 
            // OilChangeCheckedBox
            // 
            this.OilChangeCheckedBox.AutoSize = true;
            this.OilChangeCheckedBox.Location = new System.Drawing.Point(6, 20);
            this.OilChangeCheckedBox.Name = "OilChangeCheckedBox";
            this.OilChangeCheckedBox.Size = new System.Drawing.Size(117, 17);
            this.OilChangeCheckedBox.TabIndex = 0;
            this.OilChangeCheckedBox.Text = "Oil Change: $26.00";
            this.OilChangeCheckedBox.UseVisualStyleBackColor = true;
            this.OilChangeCheckedBox.CheckedChanged += new System.EventHandler(this.OilChangeCheckedBox_CheckedChanged);
            // 
            // LubeJobCheckedBox
            // 
            this.LubeJobCheckedBox.AutoSize = true;
            this.LubeJobCheckedBox.Location = new System.Drawing.Point(6, 42);
            this.LubeJobCheckedBox.Name = "LubeJobCheckedBox";
            this.LubeJobCheckedBox.Size = new System.Drawing.Size(109, 17);
            this.LubeJobCheckedBox.TabIndex = 1;
            this.LubeJobCheckedBox.Text = "Lube Job: $18.00";
            this.LubeJobCheckedBox.UseVisualStyleBackColor = true;
            this.LubeJobCheckedBox.CheckedChanged += new System.EventHandler(this.LubeJobCheckedBox_CheckedChanged);
            // 
            // RadiatorFlushCheckedBox
            // 
            this.RadiatorFlushCheckedBox.AutoSize = true;
            this.RadiatorFlushCheckedBox.Location = new System.Drawing.Point(6, 19);
            this.RadiatorFlushCheckedBox.Name = "RadiatorFlushCheckedBox";
            this.RadiatorFlushCheckedBox.Size = new System.Drawing.Size(133, 17);
            this.RadiatorFlushCheckedBox.TabIndex = 2;
            this.RadiatorFlushCheckedBox.Text = "Radiator Flush: $30.00";
            this.RadiatorFlushCheckedBox.UseVisualStyleBackColor = true;
            this.RadiatorFlushCheckedBox.CheckedChanged += new System.EventHandler(this.RadiatorFlushCheckedBox_CheckedChanged);
            // 
            // TransmissionFlushCheckedBox
            // 
            this.TransmissionFlushCheckedBox.AutoSize = true;
            this.TransmissionFlushCheckedBox.Location = new System.Drawing.Point(6, 42);
            this.TransmissionFlushCheckedBox.Name = "TransmissionFlushCheckedBox";
            this.TransmissionFlushCheckedBox.Size = new System.Drawing.Size(154, 17);
            this.TransmissionFlushCheckedBox.TabIndex = 3;
            this.TransmissionFlushCheckedBox.Text = "Transmission Flush: $80.00";
            this.TransmissionFlushCheckedBox.UseVisualStyleBackColor = true;
            this.TransmissionFlushCheckedBox.CheckedChanged += new System.EventHandler(this.TransmissionFlushCheckedBox_CheckedChanged);
            // 
            // InspectionCheckedBox
            // 
            this.InspectionCheckedBox.AutoSize = true;
            this.InspectionCheckedBox.Location = new System.Drawing.Point(6, 19);
            this.InspectionCheckedBox.Name = "InspectionCheckedBox";
            this.InspectionCheckedBox.Size = new System.Drawing.Size(114, 17);
            this.InspectionCheckedBox.TabIndex = 4;
            this.InspectionCheckedBox.Text = "Inspection: $15.00";
            this.InspectionCheckedBox.UseVisualStyleBackColor = true;
            this.InspectionCheckedBox.CheckedChanged += new System.EventHandler(this.InspectionCheckedBox_CheckedChanged);
            // 
            // ReplaceMufflerCheckedBox
            // 
            this.ReplaceMufflerCheckedBox.AutoSize = true;
            this.ReplaceMufflerCheckedBox.Location = new System.Drawing.Point(6, 42);
            this.ReplaceMufflerCheckedBox.Name = "ReplaceMufflerCheckedBox";
            this.ReplaceMufflerCheckedBox.Size = new System.Drawing.Size(146, 17);
            this.ReplaceMufflerCheckedBox.TabIndex = 5;
            this.ReplaceMufflerCheckedBox.Text = "Replace Muffler: $100.00";
            this.ReplaceMufflerCheckedBox.UseVisualStyleBackColor = true;
            this.ReplaceMufflerCheckedBox.CheckedChanged += new System.EventHandler(this.ReplaceMufflerCheckedBox_CheckedChanged);
            // 
            // TireRotationCheckedBox
            // 
            this.TireRotationCheckedBox.AutoSize = true;
            this.TireRotationCheckedBox.Location = new System.Drawing.Point(6, 65);
            this.TireRotationCheckedBox.Name = "TireRotationCheckedBox";
            this.TireRotationCheckedBox.Size = new System.Drawing.Size(126, 17);
            this.TireRotationCheckedBox.TabIndex = 6;
            this.TireRotationCheckedBox.Text = "Tire Rotation: $20.00";
            this.TireRotationCheckedBox.UseVisualStyleBackColor = true;
            this.TireRotationCheckedBox.CheckedChanged += new System.EventHandler(this.TireRotationCheckedBox_CheckedChanged);
            // 
            // PartsPromptLabel
            // 
            this.PartsPromptLabel.AutoSize = true;
            this.PartsPromptLabel.Location = new System.Drawing.Point(21, 25);
            this.PartsPromptLabel.Name = "PartsPromptLabel";
            this.PartsPromptLabel.Size = new System.Drawing.Size(46, 13);
            this.PartsPromptLabel.TabIndex = 0;
            this.PartsPromptLabel.Text = "Parts ($)";
            // 
            // LaborPromptLabel
            // 
            this.LaborPromptLabel.AutoSize = true;
            this.LaborPromptLabel.Location = new System.Drawing.Point(21, 51);
            this.LaborPromptLabel.Name = "LaborPromptLabel";
            this.LaborPromptLabel.Size = new System.Drawing.Size(49, 13);
            this.LaborPromptLabel.TabIndex = 1;
            this.LaborPromptLabel.Text = "Labor ($)";
            // 
            // PartsTextBox
            // 
            this.PartsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PartsTextBox.Location = new System.Drawing.Point(73, 23);
            this.PartsTextBox.Name = "PartsTextBox";
            this.PartsTextBox.Size = new System.Drawing.Size(51, 20);
            this.PartsTextBox.TabIndex = 2;
            this.PartsTextBox.TextChanged += new System.EventHandler(this.PartsTextBox_TextChanged);
            // 
            // LaborTextbox
            // 
            this.LaborTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LaborTextbox.Location = new System.Drawing.Point(73, 49);
            this.LaborTextbox.Name = "LaborTextbox";
            this.LaborTextbox.Size = new System.Drawing.Size(51, 20);
            this.LaborTextbox.TabIndex = 3;
            this.LaborTextbox.TextChanged += new System.EventHandler(this.LaborTextbox_TextChanged);
            // 
            // ServiceChargeLabel
            // 
            this.ServiceChargeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ServiceChargeLabel.Location = new System.Drawing.Point(143, 22);
            this.ServiceChargeLabel.Name = "ServiceChargeLabel";
            this.ServiceChargeLabel.Size = new System.Drawing.Size(126, 20);
            this.ServiceChargeLabel.TabIndex = 4;
            this.ServiceChargeLabel.Click += new System.EventHandler(this.ServiceChargeLabel_Click);
            // 
            // TotalFeesLabel
            // 
            this.TotalFeesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalFeesLabel.Location = new System.Drawing.Point(143, 102);
            this.TotalFeesLabel.Name = "TotalFeesLabel";
            this.TotalFeesLabel.Size = new System.Drawing.Size(126, 20);
            this.TotalFeesLabel.TabIndex = 5;
            this.TotalFeesLabel.Click += new System.EventHandler(this.TotalFeesLabel_Click);
            // 
            // TaxOnPartsLabel
            // 
            this.TaxOnPartsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TaxOnPartsLabel.Location = new System.Drawing.Point(143, 82);
            this.TaxOnPartsLabel.Name = "TaxOnPartsLabel";
            this.TaxOnPartsLabel.Size = new System.Drawing.Size(126, 20);
            this.TaxOnPartsLabel.TabIndex = 7;
            this.TaxOnPartsLabel.Click += new System.EventHandler(this.TaxOnPartsLabel_Click);
            // 
            // AdditionalLaborLabel
            // 
            this.AdditionalLaborLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AdditionalLaborLabel.Location = new System.Drawing.Point(143, 62);
            this.AdditionalLaborLabel.Name = "AdditionalLaborLabel";
            this.AdditionalLaborLabel.Size = new System.Drawing.Size(126, 20);
            this.AdditionalLaborLabel.TabIndex = 8;
            this.AdditionalLaborLabel.Click += new System.EventHandler(this.AdditionalLaborLabel_Click);
            // 
            // AdditionalPartsLabel
            // 
            this.AdditionalPartsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AdditionalPartsLabel.Location = new System.Drawing.Point(143, 42);
            this.AdditionalPartsLabel.Name = "AdditionalPartsLabel";
            this.AdditionalPartsLabel.Size = new System.Drawing.Size(126, 20);
            this.AdditionalPartsLabel.TabIndex = 9;
            this.AdditionalPartsLabel.Click += new System.EventHandler(this.AdditionalPartsLabel_Click);
            // 
            // ServiceChargePromptLabel
            // 
            this.ServiceChargePromptLabel.AutoSize = true;
            this.ServiceChargePromptLabel.Location = new System.Drawing.Point(6, 22);
            this.ServiceChargePromptLabel.Name = "ServiceChargePromptLabel";
            this.ServiceChargePromptLabel.Size = new System.Drawing.Size(131, 13);
            this.ServiceChargePromptLabel.TabIndex = 4;
            this.ServiceChargePromptLabel.Text = "Standard Service Charges";
            // 
            // AdditionalPartsPromptLabel
            // 
            this.AdditionalPartsPromptLabel.AutoSize = true;
            this.AdditionalPartsPromptLabel.Location = new System.Drawing.Point(57, 43);
            this.AdditionalPartsPromptLabel.Name = "AdditionalPartsPromptLabel";
            this.AdditionalPartsPromptLabel.Size = new System.Drawing.Size(80, 13);
            this.AdditionalPartsPromptLabel.TabIndex = 10;
            this.AdditionalPartsPromptLabel.Text = "Additional Parts";
            // 
            // AdditionalLaborPromptLabel
            // 
            this.AdditionalLaborPromptLabel.AutoSize = true;
            this.AdditionalLaborPromptLabel.Location = new System.Drawing.Point(54, 63);
            this.AdditionalLaborPromptLabel.Name = "AdditionalLaborPromptLabel";
            this.AdditionalLaborPromptLabel.Size = new System.Drawing.Size(83, 13);
            this.AdditionalLaborPromptLabel.TabIndex = 11;
            this.AdditionalLaborPromptLabel.Text = "Additional Labor";
            // 
            // TaxOnPartsPromptLabel
            // 
            this.TaxOnPartsPromptLabel.AutoSize = true;
            this.TaxOnPartsPromptLabel.Location = new System.Drawing.Point(65, 83);
            this.TaxOnPartsPromptLabel.Name = "TaxOnPartsPromptLabel";
            this.TaxOnPartsPromptLabel.Size = new System.Drawing.Size(72, 13);
            this.TaxOnPartsPromptLabel.TabIndex = 12;
            this.TaxOnPartsPromptLabel.Text = "Tax (on parts)";
            // 
            // TotalFeesPromptLabel
            // 
            this.TotalFeesPromptLabel.AutoSize = true;
            this.TotalFeesPromptLabel.Location = new System.Drawing.Point(80, 103);
            this.TotalFeesPromptLabel.Name = "TotalFeesPromptLabel";
            this.TotalFeesPromptLabel.Size = new System.Drawing.Size(57, 13);
            this.TotalFeesPromptLabel.TabIndex = 13;
            this.TotalFeesPromptLabel.Text = "Total Fees";
            // 
            // itemizedSelectedPromptLabel
            // 
            this.itemizedSelectedPromptLabel.AutoSize = true;
            this.itemizedSelectedPromptLabel.Location = new System.Drawing.Point(3, 157);
            this.itemizedSelectedPromptLabel.Name = "itemizedSelectedPromptLabel";
            this.itemizedSelectedPromptLabel.Size = new System.Drawing.Size(91, 13);
            this.itemizedSelectedPromptLabel.TabIndex = 14;
            this.itemizedSelectedPromptLabel.Text = "Itemized Selected";
            // 
            // ItemizedSelectedListBox
            // 
            this.ItemizedSelectedListBox.FormattingEnabled = true;
            this.ItemizedSelectedListBox.Location = new System.Drawing.Point(6, 183);
            this.ItemizedSelectedListBox.Name = "ItemizedSelectedListBox";
            this.ItemizedSelectedListBox.Size = new System.Drawing.Size(332, 95);
            this.ItemizedSelectedListBox.TabIndex = 15;
            this.ItemizedSelectedListBox.SelectedIndexChanged += new System.EventHandler(this.ItemizedSelectedListBox_SelectedIndexChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(61, 488);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(142, 488);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ProgrammedByLabel
            // 
            this.ProgrammedByLabel.AutoSize = true;
            this.ProgrammedByLabel.Location = new System.Drawing.Point(93, 514);
            this.ProgrammedByLabel.Name = "ProgrammedByLabel";
            this.ProgrammedByLabel.Size = new System.Drawing.Size(165, 13);
            this.ProgrammedByLabel.TabIndex = 4;
            this.ProgrammedByLabel.Text = "Programmed By: Michael Wagner";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(223, 488);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 532);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ProgrammedByLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SummaryGroupBox);
            this.Controls.Add(this.AdditionalChargesGroupBox);
            this.Controls.Add(this.MiscGroupBox);
            this.Controls.Add(this.FlushGroupBox);
            this.Controls.Add(this.OilLubeGroupBox);
            this.Name = "Form1";
            this.Text = "Automotive";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.OilLubeGroupBox.ResumeLayout(false);
            this.OilLubeGroupBox.PerformLayout();
            this.FlushGroupBox.ResumeLayout(false);
            this.FlushGroupBox.PerformLayout();
            this.MiscGroupBox.ResumeLayout(false);
            this.MiscGroupBox.PerformLayout();
            this.AdditionalChargesGroupBox.ResumeLayout(false);
            this.AdditionalChargesGroupBox.PerformLayout();
            this.SummaryGroupBox.ResumeLayout(false);
            this.SummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox OilLubeGroupBox;
        private System.Windows.Forms.GroupBox FlushGroupBox;
        private System.Windows.Forms.GroupBox MiscGroupBox;
        private System.Windows.Forms.GroupBox AdditionalChargesGroupBox;
        private System.Windows.Forms.GroupBox SummaryGroupBox;
        private System.Windows.Forms.CheckBox LubeJobCheckedBox;
        private System.Windows.Forms.CheckBox OilChangeCheckedBox;
        private System.Windows.Forms.CheckBox TransmissionFlushCheckedBox;
        private System.Windows.Forms.CheckBox RadiatorFlushCheckedBox;
        private System.Windows.Forms.CheckBox TireRotationCheckedBox;
        private System.Windows.Forms.CheckBox ReplaceMufflerCheckedBox;
        private System.Windows.Forms.CheckBox InspectionCheckedBox;
        private System.Windows.Forms.Label LaborPromptLabel;
        private System.Windows.Forms.Label PartsPromptLabel;
        private System.Windows.Forms.TextBox LaborTextbox;
        private System.Windows.Forms.TextBox PartsTextBox;
        private System.Windows.Forms.Label ServiceChargeLabel;
        private System.Windows.Forms.Label ServiceChargePromptLabel;
        private System.Windows.Forms.Label AdditionalPartsLabel;
        private System.Windows.Forms.Label AdditionalLaborLabel;
        private System.Windows.Forms.Label TaxOnPartsLabel;
        private System.Windows.Forms.Label TotalFeesLabel;
        private System.Windows.Forms.Label AdditionalPartsPromptLabel;
        private System.Windows.Forms.Label AdditionalLaborPromptLabel;
        private System.Windows.Forms.Label TaxOnPartsPromptLabel;
        private System.Windows.Forms.Label TotalFeesPromptLabel;
        private System.Windows.Forms.ListBox ItemizedSelectedListBox;
        private System.Windows.Forms.Label itemizedSelectedPromptLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label ProgrammedByLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}

