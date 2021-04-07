﻿namespace JungleDiamond
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.fLabel = new System.Windows.Forms.Label();
            this.functionBox = new System.Windows.Forms.ComboBox();
            this.scriptList = new System.Windows.Forms.ListView();
            this.nbCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.argCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.activePanel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.LoadBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loadText = new System.Windows.Forms.TextBox();
            this.WaitBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.waitText = new System.Windows.Forms.TextBox();
            this.CopyBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.destText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.srcText = new System.Windows.Forms.TextBox();
            this.saveBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saveText = new System.Windows.Forms.TextBox();
            this.generateScript = new System.Windows.Forms.Button();
            this.RecalibBox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.InteractBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.compoundText = new System.Windows.Forms.TextBox();
            this.AddVcBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.compoundVCText = new System.Windows.Forms.TextBox();
            this.CCSBox = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ccsText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.compoundCCSText = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.resetButton = new System.Windows.Forms.Button();
            this.LoadBox.SuspendLayout();
            this.WaitBox.SuspendLayout();
            this.CopyBox.SuspendLayout();
            this.saveBox.SuspendLayout();
            this.RecalibBox.SuspendLayout();
            this.AddVcBox.SuspendLayout();
            this.CCSBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fLabel
            // 
            this.fLabel.AutoSize = true;
            this.fLabel.Location = new System.Drawing.Point(49, 142);
            this.fLabel.Name = "fLabel";
            this.fLabel.Size = new System.Drawing.Size(53, 13);
            this.fLabel.TabIndex = 5;
            this.fLabel.Text = "Function";
            // 
            // functionBox
            // 
            this.functionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.functionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.functionBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.functionBox.ForeColor = System.Drawing.SystemColors.Window;
            this.functionBox.FormattingEnabled = true;
            this.functionBox.Items.AddRange(new object[] {
            "Load",
            "Save",
            "Copy/transfer",
            "Wait",
            "Recalibrate",
            "Add VC to display Geometry",
            "Custom content space conversion",
            "Blending recalculation [3D]",
            "Blending adjustment standard ",
            "Blending adjustment spline",
            "Export via script ",
            "Export"});
            this.functionBox.Location = new System.Drawing.Point(49, 159);
            this.functionBox.Name = "functionBox";
            this.functionBox.Size = new System.Drawing.Size(228, 21);
            this.functionBox.TabIndex = 6;
            this.functionBox.SelectedIndexChanged += new System.EventHandler(this.functionBox_indexChanged);
            // 
            // scriptList
            // 
            this.scriptList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(102)))), ((int)(((byte)(145)))));
            this.scriptList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scriptList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nbCol,
            this.nameCol,
            this.argCol});
            this.scriptList.ForeColor = System.Drawing.SystemColors.Window;
            this.scriptList.HideSelection = false;
            this.scriptList.Location = new System.Drawing.Point(433, 21);
            this.scriptList.Name = "scriptList";
            this.scriptList.Size = new System.Drawing.Size(700, 330);
            this.scriptList.TabIndex = 12;
            this.scriptList.UseCompatibleStateImageBehavior = false;
            this.scriptList.View = System.Windows.Forms.View.Details;
            // 
            // nbCol
            // 
            this.nbCol.Text = "     Nb";
            // 
            // nameCol
            // 
            this.nameCol.Text = "Name";
            this.nameCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameCol.Width = 130;
            // 
            // argCol
            // 
            this.argCol.Text = "Arguments";
            this.argCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.argCol.Width = 499;
            // 
            // activePanel
            // 
            this.activePanel.BackColor = System.Drawing.Color.Transparent;
            this.activePanel.Location = new System.Drawing.Point(49, 197);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(267, 142);
            this.activePanel.TabIndex = 13;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.ForestGreen;
            this.addButton.Enabled = false;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(340, 197);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(56, 44);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add ";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_click);
            // 
            // LoadBox
            // 
            this.LoadBox.Controls.Add(this.label3);
            this.LoadBox.Controls.Add(this.label2);
            this.LoadBox.Controls.Add(this.loadText);
            this.LoadBox.ForeColor = System.Drawing.SystemColors.Window;
            this.LoadBox.Location = new System.Drawing.Point(49, 689);
            this.LoadBox.Name = "LoadBox";
            this.LoadBox.Size = new System.Drawing.Size(232, 84);
            this.LoadBox.TabIndex = 14;
            this.LoadBox.TabStop = false;
            this.LoadBox.Text = "Load";
            this.LoadBox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "(.sps)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "File ";
            // 
            // loadText
            // 
            this.loadText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.loadText.ForeColor = System.Drawing.SystemColors.Window;
            this.loadText.Location = new System.Drawing.Point(15, 38);
            this.loadText.Name = "loadText";
            this.loadText.Size = new System.Drawing.Size(136, 22);
            this.loadText.TabIndex = 0;
            // 
            // WaitBox
            // 
            this.WaitBox.Controls.Add(this.label8);
            this.WaitBox.Controls.Add(this.label9);
            this.WaitBox.Controls.Add(this.waitText);
            this.WaitBox.ForeColor = System.Drawing.SystemColors.Window;
            this.WaitBox.Location = new System.Drawing.Point(49, 593);
            this.WaitBox.Name = "WaitBox";
            this.WaitBox.Size = new System.Drawing.Size(123, 90);
            this.WaitBox.TabIndex = 15;
            this.WaitBox.TabStop = false;
            this.WaitBox.Text = "Wait";
            this.WaitBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "ms";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Time";
            // 
            // waitText
            // 
            this.waitText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.waitText.ForeColor = System.Drawing.SystemColors.Window;
            this.waitText.Location = new System.Drawing.Point(15, 46);
            this.waitText.Name = "waitText";
            this.waitText.Size = new System.Drawing.Size(56, 22);
            this.waitText.TabIndex = 0;
            // 
            // CopyBox
            // 
            this.CopyBox.Controls.Add(this.label6);
            this.CopyBox.Controls.Add(this.label7);
            this.CopyBox.Controls.Add(this.destText);
            this.CopyBox.Controls.Add(this.label4);
            this.CopyBox.Controls.Add(this.label5);
            this.CopyBox.Controls.Add(this.srcText);
            this.CopyBox.ForeColor = System.Drawing.SystemColors.Window;
            this.CopyBox.Location = new System.Drawing.Point(49, 463);
            this.CopyBox.Name = "CopyBox";
            this.CopyBox.Size = new System.Drawing.Size(224, 124);
            this.CopyBox.TabIndex = 16;
            this.CopyBox.TabStop = false;
            this.CopyBox.Text = "Copy/transfer";
            this.CopyBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "(.sps)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Destination";
            // 
            // destText
            // 
            this.destText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.destText.ForeColor = System.Drawing.SystemColors.Window;
            this.destText.Location = new System.Drawing.Point(15, 85);
            this.destText.Name = "destText";
            this.destText.Size = new System.Drawing.Size(136, 22);
            this.destText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "(.sps)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Source";
            // 
            // srcText
            // 
            this.srcText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.srcText.ForeColor = System.Drawing.SystemColors.Window;
            this.srcText.Location = new System.Drawing.Point(15, 46);
            this.srcText.Name = "srcText";
            this.srcText.Size = new System.Drawing.Size(136, 22);
            this.srcText.TabIndex = 0;
            // 
            // saveBox
            // 
            this.saveBox.Controls.Add(this.label1);
            this.saveBox.Controls.Add(this.label10);
            this.saveBox.Controls.Add(this.saveText);
            this.saveBox.ForeColor = System.Drawing.SystemColors.Window;
            this.saveBox.Location = new System.Drawing.Point(52, 779);
            this.saveBox.Name = "saveBox";
            this.saveBox.Size = new System.Drawing.Size(232, 84);
            this.saveBox.TabIndex = 15;
            this.saveBox.TabStop = false;
            this.saveBox.Text = "Save";
            this.saveBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "(.sps)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "File";
            // 
            // saveText
            // 
            this.saveText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.saveText.ForeColor = System.Drawing.SystemColors.Window;
            this.saveText.Location = new System.Drawing.Point(15, 38);
            this.saveText.Name = "saveText";
            this.saveText.Size = new System.Drawing.Size(136, 22);
            this.saveText.TabIndex = 0;
            // 
            // generateScript
            // 
            this.generateScript.BackColor = System.Drawing.Color.Transparent;
            this.generateScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateScript.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateScript.ForeColor = System.Drawing.Color.White;
            this.generateScript.Location = new System.Drawing.Point(1020, 396);
            this.generateScript.Name = "generateScript";
            this.generateScript.Size = new System.Drawing.Size(113, 44);
            this.generateScript.TabIndex = 17;
            this.generateScript.Text = "Generate";
            this.generateScript.UseVisualStyleBackColor = false;
            this.generateScript.Click += new System.EventHandler(this.generateScript_Click);
            // 
            // RecalibBox
            // 
            this.RecalibBox.Controls.Add(this.label11);
            this.RecalibBox.Controls.Add(this.InteractBox);
            this.RecalibBox.Controls.Add(this.label12);
            this.RecalibBox.Controls.Add(this.compoundText);
            this.RecalibBox.ForeColor = System.Drawing.SystemColors.Window;
            this.RecalibBox.Location = new System.Drawing.Point(327, 463);
            this.RecalibBox.Name = "RecalibBox";
            this.RecalibBox.Size = new System.Drawing.Size(229, 107);
            this.RecalibBox.TabIndex = 16;
            this.RecalibBox.TabStop = false;
            this.RecalibBox.Text = "Recalibrate";
            this.RecalibBox.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Interaction Level";
            // 
            // InteractBox
            // 
            this.InteractBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.InteractBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InteractBox.ForeColor = System.Drawing.SystemColors.Window;
            this.InteractBox.FormattingEnabled = true;
            this.InteractBox.Items.AddRange(new object[] {
            "None",
            "Minimal",
            "Reduced",
            "All"});
            this.InteractBox.Location = new System.Drawing.Point(120, 69);
            this.InteractBox.Name = "InteractBox";
            this.InteractBox.Size = new System.Drawing.Size(103, 21);
            this.InteractBox.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Compound Name";
            // 
            // compoundText
            // 
            this.compoundText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.compoundText.ForeColor = System.Drawing.SystemColors.Window;
            this.compoundText.Location = new System.Drawing.Point(15, 41);
            this.compoundText.Name = "compoundText";
            this.compoundText.Size = new System.Drawing.Size(206, 22);
            this.compoundText.TabIndex = 0;
            // 
            // AddVcBox
            // 
            this.AddVcBox.Controls.Add(this.label14);
            this.AddVcBox.Controls.Add(this.compoundVCText);
            this.AddVcBox.ForeColor = System.Drawing.SystemColors.Window;
            this.AddVcBox.Location = new System.Drawing.Point(327, 586);
            this.AddVcBox.Name = "AddVcBox";
            this.AddVcBox.Size = new System.Drawing.Size(229, 75);
            this.AddVcBox.TabIndex = 17;
            this.AddVcBox.TabStop = false;
            this.AddVcBox.Text = "Add VC to display geometry";
            this.AddVcBox.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Compound Name";
            // 
            // compoundVCText
            // 
            this.compoundVCText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.compoundVCText.ForeColor = System.Drawing.SystemColors.Window;
            this.compoundVCText.Location = new System.Drawing.Point(15, 42);
            this.compoundVCText.Name = "compoundVCText";
            this.compoundVCText.Size = new System.Drawing.Size(206, 22);
            this.compoundVCText.TabIndex = 0;
            // 
            // CCSBox
            // 
            this.CCSBox.Controls.Add(this.label15);
            this.CCSBox.Controls.Add(this.ccsText);
            this.CCSBox.Controls.Add(this.label13);
            this.CCSBox.Controls.Add(this.compoundCCSText);
            this.CCSBox.ForeColor = System.Drawing.SystemColors.Window;
            this.CCSBox.Location = new System.Drawing.Point(327, 689);
            this.CCSBox.Name = "CCSBox";
            this.CCSBox.Size = new System.Drawing.Size(229, 125);
            this.CCSBox.TabIndex = 18;
            this.CCSBox.TabStop = false;
            this.CCSBox.Text = "Custom Content Space";
            this.CCSBox.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Content Space";
            // 
            // ccsText
            // 
            this.ccsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ccsText.ForeColor = System.Drawing.SystemColors.Window;
            this.ccsText.Location = new System.Drawing.Point(13, 90);
            this.ccsText.Name = "ccsText";
            this.ccsText.Size = new System.Drawing.Size(206, 22);
            this.ccsText.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Compound Name";
            // 
            // compoundCCSText
            // 
            this.compoundCCSText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.compoundCCSText.ForeColor = System.Drawing.SystemColors.Window;
            this.compoundCCSText.Location = new System.Drawing.Point(13, 45);
            this.compoundCCSText.Name = "compoundCCSText";
            this.compoundCCSText.Size = new System.Drawing.Size(206, 22);
            this.compoundCCSText.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "ini";
            this.saveFileDialog1.FileName = "MyScript";
            this.saveFileDialog1.Filter = "VIOSO script |*.ini";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.resetButton.Location = new System.Drawing.Point(52, 396);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(54, 44);
            this.resetButton.TabIndex = 19;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1155, 460);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.CCSBox);
            this.Controls.Add(this.AddVcBox);
            this.Controls.Add(this.RecalibBox);
            this.Controls.Add(this.generateScript);
            this.Controls.Add(this.saveBox);
            this.Controls.Add(this.LoadBox);
            this.Controls.Add(this.WaitBox);
            this.Controls.Add(this.CopyBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.activePanel);
            this.Controls.Add(this.fLabel);
            this.Controls.Add(this.scriptList);
            this.Controls.Add(this.functionBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Opacity = 0.98D;
            this.Load += new System.EventHandler(this.Main_Load);
            this.LoadBox.ResumeLayout(false);
            this.LoadBox.PerformLayout();
            this.WaitBox.ResumeLayout(false);
            this.WaitBox.PerformLayout();
            this.CopyBox.ResumeLayout(false);
            this.CopyBox.PerformLayout();
            this.saveBox.ResumeLayout(false);
            this.saveBox.PerformLayout();
            this.RecalibBox.ResumeLayout(false);
            this.RecalibBox.PerformLayout();
            this.AddVcBox.ResumeLayout(false);
            this.AddVcBox.PerformLayout();
            this.CCSBox.ResumeLayout(false);
            this.CCSBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label fLabel;
        private System.Windows.Forms.ComboBox functionBox;
        private System.Windows.Forms.ListView scriptList;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader argCol;
        private System.Windows.Forms.ColumnHeader nbCol;
        private System.Windows.Forms.Panel activePanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox LoadBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loadText;
        private System.Windows.Forms.GroupBox WaitBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox waitText;
        public System.Windows.Forms.GroupBox CopyBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox destText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox srcText;
        private System.Windows.Forms.GroupBox saveBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox saveText;
        private System.Windows.Forms.Button generateScript;
        private System.Windows.Forms.GroupBox RecalibBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox compoundText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox InteractBox;
        private System.Windows.Forms.GroupBox AddVcBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox compoundVCText;
        private System.Windows.Forms.GroupBox CCSBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ccsText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox compoundCCSText;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button resetButton;
    }
}

