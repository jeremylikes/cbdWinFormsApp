using System;

namespace DataEntryApp
{
    partial class MillForm
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
            this.nudRMESWeight = new System.Windows.Forms.NumericUpDown();
            this.nudPalletWeight = new System.Windows.Forms.NumericUpDown();
            this.lblPalletWeight = new System.Windows.Forms.Label();
            this.lblRMESWeight = new System.Windows.Forms.Label();
            this.lblWeightOnBag = new System.Windows.Forms.Label();
            this.txtLotNum = new System.Windows.Forms.TextBox();
            this.nudNetWeight = new System.Windows.Forms.NumericUpDown();
            this.lblNetWeight = new System.Windows.Forms.Label();
            this.dtpDateMilled = new System.Windows.Forms.DateTimePicker();
            this.lblDateMilled = new System.Windows.Forms.Label();
            this.txtNewLotNum = new System.Windows.Forms.TextBox();
            this.lblNewLotNum = new System.Windows.Forms.Label();
            this.lblPreviousDataWarning = new System.Windows.Forms.Label();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtFarm = new System.Windows.Forms.TextBox();
            this.lblFarm = new System.Windows.Forms.Label();
            this.lblLotNum = new System.Windows.Forms.Label();
            this.nudWeightOnBag = new System.Windows.Forms.NumericUpDown();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCalcNetWeight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRMESWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPalletWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNetWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeightOnBag)).BeginInit();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudRMESWeight
            // 
            this.nudRMESWeight.DecimalPlaces = 1;
            this.nudRMESWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRMESWeight.Location = new System.Drawing.Point(1208, 510);
            this.nudRMESWeight.Margin = new System.Windows.Forms.Padding(6);
            this.nudRMESWeight.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.nudRMESWeight.Name = "nudRMESWeight";
            this.nudRMESWeight.Size = new System.Drawing.Size(217, 56);
            this.nudRMESWeight.TabIndex = 5;
            // 
            // nudPalletWeight
            // 
            this.nudPalletWeight.DecimalPlaces = 1;
            this.nudPalletWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPalletWeight.Location = new System.Drawing.Point(840, 586);
            this.nudPalletWeight.Margin = new System.Windows.Forms.Padding(6);
            this.nudPalletWeight.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.nudPalletWeight.Name = "nudPalletWeight";
            this.nudPalletWeight.Size = new System.Drawing.Size(215, 56);
            this.nudPalletWeight.TabIndex = 6;
            // 
            // lblPalletWeight
            // 
            this.lblPalletWeight.AutoSize = true;
            this.lblPalletWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletWeight.ForeColor = System.Drawing.Color.White;
            this.lblPalletWeight.Location = new System.Drawing.Point(354, 584);
            this.lblPalletWeight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPalletWeight.Name = "lblPalletWeight";
            this.lblPalletWeight.Size = new System.Drawing.Size(430, 55);
            this.lblPalletWeight.TabIndex = 78;
            this.lblPalletWeight.Text = "Pallet Weight (lbs)";
            // 
            // lblRMESWeight
            // 
            this.lblRMESWeight.AutoSize = true;
            this.lblRMESWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMESWeight.ForeColor = System.Drawing.Color.White;
            this.lblRMESWeight.Location = new System.Drawing.Point(353, 509);
            this.lblRMESWeight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRMESWeight.Name = "lblRMESWeight";
            this.lblRMESWeight.Size = new System.Drawing.Size(814, 55);
            this.lblRMESWeight.TabIndex = 79;
            this.lblRMESWeight.Text = "RMES Weight (includes pallet) (lbs)";
            // 
            // lblWeightOnBag
            // 
            this.lblWeightOnBag.AutoSize = true;
            this.lblWeightOnBag.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightOnBag.ForeColor = System.Drawing.Color.White;
            this.lblWeightOnBag.Location = new System.Drawing.Point(353, 359);
            this.lblWeightOnBag.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWeightOnBag.Name = "lblWeightOnBag";
            this.lblWeightOnBag.Size = new System.Drawing.Size(681, 55);
            this.lblWeightOnBag.TabIndex = 64;
            this.lblWeightOnBag.Text = "Identified weight on bag (lbs) ";
            // 
            // txtLotNum
            // 
            this.txtLotNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLotNum.Location = new System.Drawing.Point(1080, 286);
            this.txtLotNum.Margin = new System.Windows.Forms.Padding(6);
            this.txtLotNum.Name = "txtLotNum";
            this.txtLotNum.Size = new System.Drawing.Size(308, 56);
            this.txtLotNum.TabIndex = 2;
            // 
            // nudNetWeight
            // 
            this.nudNetWeight.DecimalPlaces = 1;
            this.nudNetWeight.Enabled = false;
            this.nudNetWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNetWeight.Location = new System.Drawing.Point(840, 660);
            this.nudNetWeight.Margin = new System.Windows.Forms.Padding(6);
            this.nudNetWeight.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.nudNetWeight.Name = "nudNetWeight";
            this.nudNetWeight.ReadOnly = true;
            this.nudNetWeight.Size = new System.Drawing.Size(215, 56);
            this.nudNetWeight.TabIndex = 7;
            // 
            // lblNetWeight
            // 
            this.lblNetWeight.AutoSize = true;
            this.lblNetWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeight.ForeColor = System.Drawing.Color.White;
            this.lblNetWeight.Location = new System.Drawing.Point(354, 659);
            this.lblNetWeight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNetWeight.Name = "lblNetWeight";
            this.lblNetWeight.Size = new System.Drawing.Size(383, 55);
            this.lblNetWeight.TabIndex = 83;
            this.lblNetWeight.Text = "Net Weight (lbs)";
            // 
            // dtpDateMilled
            // 
            this.dtpDateMilled.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateMilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateMilled.Location = new System.Drawing.Point(840, 730);
            this.dtpDateMilled.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDateMilled.Name = "dtpDateMilled";
            this.dtpDateMilled.Size = new System.Drawing.Size(749, 56);
            this.dtpDateMilled.TabIndex = 8;
            // 
            // lblDateMilled
            // 
            this.lblDateMilled.AutoSize = true;
            this.lblDateMilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateMilled.ForeColor = System.Drawing.Color.White;
            this.lblDateMilled.Location = new System.Drawing.Point(354, 734);
            this.lblDateMilled.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDateMilled.Name = "lblDateMilled";
            this.lblDateMilled.Size = new System.Drawing.Size(274, 55);
            this.lblDateMilled.TabIndex = 85;
            this.lblDateMilled.Text = "Date Milled";
            // 
            // txtNewLotNum
            // 
            this.txtNewLotNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewLotNum.Location = new System.Drawing.Point(840, 804);
            this.txtNewLotNum.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewLotNum.Name = "txtNewLotNum";
            this.txtNewLotNum.Size = new System.Drawing.Size(342, 56);
            this.txtNewLotNum.TabIndex = 9;
            // 
            // lblNewLotNum
            // 
            this.lblNewLotNum.AutoSize = true;
            this.lblNewLotNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewLotNum.ForeColor = System.Drawing.Color.White;
            this.lblNewLotNum.Location = new System.Drawing.Point(354, 809);
            this.lblNewLotNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewLotNum.Name = "lblNewLotNum";
            this.lblNewLotNum.Size = new System.Drawing.Size(400, 55);
            this.lblNewLotNum.TabIndex = 86;
            this.lblNewLotNum.Text = "New Lot Number";
            // 
            // lblPreviousDataWarning
            // 
            this.lblPreviousDataWarning.AutoSize = true;
            this.lblPreviousDataWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousDataWarning.ForeColor = System.Drawing.Color.Black;
            this.lblPreviousDataWarning.Location = new System.Drawing.Point(779, 112);
            this.lblPreviousDataWarning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPreviousDataWarning.Name = "lblPreviousDataWarning";
            this.lblPreviousDataWarning.Size = new System.Drawing.Size(535, 48);
            this.lblPreviousDataWarning.TabIndex = 88;
            this.lblPreviousDataWarning.Text = "Previously Entered Values";
            this.lblPreviousDataWarning.Visible = false;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.ForeColor = System.Drawing.Color.White;
            this.btnForward.Location = new System.Drawing.Point(1607, 104);
            this.btnForward.Margin = new System.Windows.Forms.Padding(6);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(116, 75);
            this.btnForward.TabIndex = 110;
            this.btnForward.Text = "🢂";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(362, 104);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 75);
            this.btnBack.TabIndex = 109;
            this.btnBack.Text = "🢀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtFarm
            // 
            this.txtFarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFarm.Location = new System.Drawing.Point(840, 434);
            this.txtFarm.Margin = new System.Windows.Forms.Padding(6);
            this.txtFarm.Name = "txtFarm";
            this.txtFarm.Size = new System.Drawing.Size(387, 56);
            this.txtFarm.TabIndex = 4;
            // 
            // lblFarm
            // 
            this.lblFarm.AutoSize = true;
            this.lblFarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarm.ForeColor = System.Drawing.Color.White;
            this.lblFarm.Location = new System.Drawing.Point(352, 434);
            this.lblFarm.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFarm.Name = "lblFarm";
            this.lblFarm.Size = new System.Drawing.Size(140, 55);
            this.lblFarm.TabIndex = 111;
            this.lblFarm.Text = "Farm";
            // 
            // lblLotNum
            // 
            this.lblLotNum.AutoSize = true;
            this.lblLotNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotNum.ForeColor = System.Drawing.Color.White;
            this.lblLotNum.Location = new System.Drawing.Point(352, 284);
            this.lblLotNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLotNum.Name = "lblLotNum";
            this.lblLotNum.Size = new System.Drawing.Size(438, 55);
            this.lblLotNum.TabIndex = 63;
            this.lblLotNum.Text = "Lot Number (BAG)";
            // 
            // nudWeightOnBag
            // 
            this.nudWeightOnBag.DecimalPlaces = 1;
            this.nudWeightOnBag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWeightOnBag.Location = new System.Drawing.Point(1080, 360);
            this.nudWeightOnBag.Margin = new System.Windows.Forms.Padding(6);
            this.nudWeightOnBag.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.nudWeightOnBag.Name = "nudWeightOnBag";
            this.nudWeightOnBag.Size = new System.Drawing.Size(229, 56);
            this.nudWeightOnBag.TabIndex = 3;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.sidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sidePanel.Controls.Add(this.lblVersion);
            this.sidePanel.Controls.Add(this.picLogo);
            this.sidePanel.Location = new System.Drawing.Point(-10, -1);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(347, 1030);
            this.sidePanel.TabIndex = 169;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(25, 181);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(313, 26);
            this.lblVersion.TabIndex = 139;
            this.lblVersion.Text = "Version {_version} [beta]";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Image = global::DataEntryApp.Properties.Resources.RMES_MES_Logo2;
            this.picLogo.Location = new System.Drawing.Point(22, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(310, 175);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Location = new System.Drawing.Point(325, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1459, 96);
            this.panel3.TabIndex = 170;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 60);
            this.label2.TabIndex = 140;
            this.label2.Text = "Milling";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(1384, -3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 99);
            this.btnClose.TabIndex = 140;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbOperator
            // 
            this.cmbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(1080, 209);
            this.cmbOperator.Margin = new System.Windows.Forms.Padding(6);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(265, 59);
            this.cmbOperator.TabIndex = 1;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.ForeColor = System.Drawing.Color.White;
            this.lblOperator.Location = new System.Drawing.Point(354, 209);
            this.lblOperator.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(222, 55);
            this.lblOperator.TabIndex = 172;
            this.lblOperator.Text = "Operator";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(190)))), ((int)(((byte)(110)))));
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(240)))), ((int)(((byte)(130)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Image = global::DataEntryApp.Properties.Resources.Upload1;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.Location = new System.Drawing.Point(1358, 825);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(365, 179);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCalcNetWeight
            // 
            this.btnCalcNetWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.btnCalcNetWeight.FlatAppearance.BorderSize = 0;
            this.btnCalcNetWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcNetWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcNetWeight.ForeColor = System.Drawing.Color.White;
            this.btnCalcNetWeight.Location = new System.Drawing.Point(1099, 586);
            this.btnCalcNetWeight.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalcNetWeight.Name = "btnCalcNetWeight";
            this.btnCalcNetWeight.Size = new System.Drawing.Size(289, 56);
            this.btnCalcNetWeight.TabIndex = 173;
            this.btnCalcNetWeight.Text = "Calculate Net Weight";
            this.btnCalcNetWeight.UseVisualStyleBackColor = false;
            this.btnCalcNetWeight.Click += new System.EventHandler(this.btnCalcNetWeight_Click);
            // 
            // MillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1774, 1029);
            this.Controls.Add(this.btnCalcNetWeight);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtFarm);
            this.Controls.Add(this.lblFarm);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPreviousDataWarning);
            this.Controls.Add(this.txtNewLotNum);
            this.Controls.Add(this.lblNewLotNum);
            this.Controls.Add(this.dtpDateMilled);
            this.Controls.Add(this.lblDateMilled);
            this.Controls.Add(this.nudNetWeight);
            this.Controls.Add(this.lblNetWeight);
            this.Controls.Add(this.txtLotNum);
            this.Controls.Add(this.nudRMESWeight);
            this.Controls.Add(this.nudWeightOnBag);
            this.Controls.Add(this.nudPalletWeight);
            this.Controls.Add(this.lblPalletWeight);
            this.Controls.Add(this.lblRMESWeight);
            this.Controls.Add(this.lblWeightOnBag);
            this.Controls.Add(this.lblLotNum);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MillForm";
            this.Text = "MillForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nudRMESWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPalletWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNetWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeightOnBag)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudRMESWeight;
        private System.Windows.Forms.NumericUpDown nudPalletWeight;
        private System.Windows.Forms.Label lblPalletWeight;
        private System.Windows.Forms.Label lblRMESWeight;
        private System.Windows.Forms.Label lblWeightOnBag;
        private System.Windows.Forms.TextBox txtLotNum;
        private System.Windows.Forms.NumericUpDown nudNetWeight;
        private System.Windows.Forms.Label lblNetWeight;
        private System.Windows.Forms.DateTimePicker dtpDateMilled;
        private System.Windows.Forms.Label lblDateMilled;
        private System.Windows.Forms.TextBox txtNewLotNum;
        private System.Windows.Forms.Label lblNewLotNum;
        private System.Windows.Forms.Label lblPreviousDataWarning;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtFarm;
        private System.Windows.Forms.Label lblFarm;
        private System.Windows.Forms.Label lblLotNum;
        private System.Windows.Forms.NumericUpDown nudWeightOnBag;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label lblVersion;
        public System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCalcNetWeight;
    }
}