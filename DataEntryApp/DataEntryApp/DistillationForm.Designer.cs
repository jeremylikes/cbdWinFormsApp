using System;

namespace DataEntryApp
{
    partial class DistillationForm
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
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.nudInputWeight = new System.Windows.Forms.NumericUpDown();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.EndPanel = new System.Windows.Forms.Panel();
            this.txtTempProfile = new System.Windows.Forms.TextBox();
            this.nudRunTime = new System.Windows.Forms.NumericUpDown();
            this.nudDistillateWeight = new System.Windows.Forms.NumericUpDown();
            this.lblDistWaste = new System.Windows.Forms.Label();
            this.lblDistWeight = new System.Windows.Forms.Label();
            this.nudWasteWeight = new System.Windows.Forms.NumericUpDown();
            this.lblTempProf = new System.Windows.Forms.Label();
            this.lblRunTime = new System.Windows.Forms.Label();
            this.lblInputWeight = new System.Windows.Forms.Label();
            this.lblInputMaterialWO = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblWorkOrder = new System.Windows.Forms.Label();
            this.lblPreviousDataWarning = new System.Windows.Forms.Label();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.btnNextWO = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtWorkOrder = new System.Windows.Forms.TextBox();
            this.txtInputMaterialWO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputWeight)).BeginInit();
            this.EndPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistillateWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWasteWeight)).BeginInit();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(736, 1382);
            this.txtComment.Margin = new System.Windows.Forms.Padding(6);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(1522, 378);
            this.txtComment.TabIndex = 12;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.Color.White;
            this.lblComment.Location = new System.Drawing.Point(721, 1291);
            this.lblComment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(391, 85);
            this.lblComment.TabIndex = 72;
            this.lblComment.Text = "Comment:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(2341, 1382);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(565, 184);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start Run";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nudInputWeight
            // 
            this.nudInputWeight.DecimalPlaces = 1;
            this.nudInputWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInputWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudInputWeight.Location = new System.Drawing.Point(1688, 815);
            this.nudInputWeight.Margin = new System.Windows.Forms.Padding(6);
            this.nudInputWeight.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.nudInputWeight.Name = "nudInputWeight";
            this.nudInputWeight.Size = new System.Drawing.Size(284, 92);
            this.nudInputWeight.TabIndex = 6;
            // 
            // cmbOperator
            // 
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(1204, 306);
            this.cmbOperator.Margin = new System.Windows.Forms.Padding(12);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(238, 93);
            this.cmbOperator.TabIndex = 2;
            // 
            // EndPanel
            // 
            this.EndPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.EndPanel.Controls.Add(this.txtTempProfile);
            this.EndPanel.Controls.Add(this.nudRunTime);
            this.EndPanel.Controls.Add(this.nudDistillateWeight);
            this.EndPanel.Controls.Add(this.lblDistWaste);
            this.EndPanel.Controls.Add(this.lblDistWeight);
            this.EndPanel.Controls.Add(this.nudWasteWeight);
            this.EndPanel.Controls.Add(this.lblTempProf);
            this.EndPanel.Controls.Add(this.lblRunTime);
            this.EndPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndPanel.Location = new System.Drawing.Point(731, 924);
            this.EndPanel.Margin = new System.Windows.Forms.Padding(6);
            this.EndPanel.Name = "EndPanel";
            this.EndPanel.Size = new System.Drawing.Size(2175, 241);
            this.EndPanel.TabIndex = 67;
            // 
            // txtTempProfile
            // 
            this.txtTempProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempProfile.Location = new System.Drawing.Point(641, 17);
            this.txtTempProfile.Margin = new System.Windows.Forms.Padding(6);
            this.txtTempProfile.Name = "txtTempProfile";
            this.txtTempProfile.Size = new System.Drawing.Size(363, 92);
            this.txtTempProfile.TabIndex = 7;
            // 
            // nudRunTime
            // 
            this.nudRunTime.DecimalPlaces = 1;
            this.nudRunTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRunTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRunTime.Location = new System.Drawing.Point(715, 121);
            this.nudRunTime.Margin = new System.Windows.Forms.Padding(6);
            this.nudRunTime.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.nudRunTime.Name = "nudRunTime";
            this.nudRunTime.Size = new System.Drawing.Size(289, 92);
            this.nudRunTime.TabIndex = 9;
            // 
            // nudDistillateWeight
            // 
            this.nudDistillateWeight.DecimalPlaces = 1;
            this.nudDistillateWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDistillateWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudDistillateWeight.Location = new System.Drawing.Point(1863, 124);
            this.nudDistillateWeight.Margin = new System.Windows.Forms.Padding(6);
            this.nudDistillateWeight.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.nudDistillateWeight.Name = "nudDistillateWeight";
            this.nudDistillateWeight.Size = new System.Drawing.Size(280, 92);
            this.nudDistillateWeight.TabIndex = 10;
            // 
            // lblDistWaste
            // 
            this.lblDistWaste.AutoSize = true;
            this.lblDistWaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistWaste.ForeColor = System.Drawing.Color.White;
            this.lblDistWaste.Location = new System.Drawing.Point(1078, 20);
            this.lblDistWaste.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDistWaste.Name = "lblDistWaste";
            this.lblDistWaste.Size = new System.Drawing.Size(673, 85);
            this.lblDistWaste.TabIndex = 13;
            this.lblDistWaste.Text = "Waste Weight (kg)";
            // 
            // lblDistWeight
            // 
            this.lblDistWeight.AutoSize = true;
            this.lblDistWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistWeight.ForeColor = System.Drawing.Color.White;
            this.lblDistWeight.Location = new System.Drawing.Point(1078, 126);
            this.lblDistWeight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDistWeight.Name = "lblDistWeight";
            this.lblDistWeight.Size = new System.Drawing.Size(750, 85);
            this.lblDistWeight.TabIndex = 15;
            this.lblDistWeight.Text = "Distillate Weight (kg)";
            // 
            // nudWasteWeight
            // 
            this.nudWasteWeight.DecimalPlaces = 1;
            this.nudWasteWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWasteWeight.Location = new System.Drawing.Point(1863, 18);
            this.nudWasteWeight.Margin = new System.Windows.Forms.Padding(6);
            this.nudWasteWeight.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.nudWasteWeight.Name = "nudWasteWeight";
            this.nudWasteWeight.Size = new System.Drawing.Size(280, 92);
            this.nudWasteWeight.TabIndex = 8;
            // 
            // lblTempProf
            // 
            this.lblTempProf.AutoSize = true;
            this.lblTempProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempProf.ForeColor = System.Drawing.Color.White;
            this.lblTempProf.Location = new System.Drawing.Point(28, 20);
            this.lblTempProf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTempProf.Name = "lblTempProf";
            this.lblTempProf.Size = new System.Drawing.Size(475, 85);
            this.lblTempProf.TabIndex = 10;
            this.lblTempProf.Text = "Temp Profile";
            // 
            // lblRunTime
            // 
            this.lblRunTime.AutoSize = true;
            this.lblRunTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunTime.ForeColor = System.Drawing.Color.White;
            this.lblRunTime.Location = new System.Drawing.Point(28, 126);
            this.lblRunTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRunTime.Name = "lblRunTime";
            this.lblRunTime.Size = new System.Drawing.Size(634, 85);
            this.lblRunTime.TabIndex = 11;
            this.lblRunTime.Text = "Run Duration (hr)";
            // 
            // lblInputWeight
            // 
            this.lblInputWeight.AutoSize = true;
            this.lblInputWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputWeight.ForeColor = System.Drawing.Color.White;
            this.lblInputWeight.Location = new System.Drawing.Point(721, 815);
            this.lblInputWeight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInputWeight.Name = "lblInputWeight";
            this.lblInputWeight.Size = new System.Drawing.Size(627, 85);
            this.lblInputWeight.TabIndex = 69;
            this.lblInputWeight.Text = "Input Weight (kg)";
            // 
            // lblInputMaterialWO
            // 
            this.lblInputMaterialWO.AutoSize = true;
            this.lblInputMaterialWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputMaterialWO.ForeColor = System.Drawing.Color.White;
            this.lblInputMaterialWO.Location = new System.Drawing.Point(721, 633);
            this.lblInputMaterialWO.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInputMaterialWO.Name = "lblInputMaterialWO";
            this.lblInputMaterialWO.Size = new System.Drawing.Size(926, 85);
            this.lblInputMaterialWO.TabIndex = 68;
            this.lblInputMaterialWO.Text = "Input Material Work Order";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "hh:mm tt";
            this.dtpStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(1204, 524);
            this.dtpStartTime.Margin = new System.Windows.Forms.Padding(6);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(408, 92);
            this.dtpStartTime.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(1204, 417);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(1271, 92);
            this.dtpDate.TabIndex = 3;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(721, 531);
            this.lblStart.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(393, 85);
            this.lblStart.TabIndex = 64;
            this.lblStart.Text = "Start Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(726, 424);
            this.lblDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(200, 85);
            this.lblDate.TabIndex = 62;
            this.lblDate.Text = "Date";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.ForeColor = System.Drawing.Color.White;
            this.lblOperator.Location = new System.Drawing.Point(721, 309);
            this.lblOperator.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(342, 85);
            this.lblOperator.TabIndex = 60;
            this.lblOperator.Text = "Operator";
            // 
            // lblWorkOrder
            // 
            this.lblWorkOrder.AutoSize = true;
            this.lblWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkOrder.ForeColor = System.Drawing.Color.White;
            this.lblWorkOrder.Location = new System.Drawing.Point(726, 199);
            this.lblWorkOrder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWorkOrder.Name = "lblWorkOrder";
            this.lblWorkOrder.Size = new System.Drawing.Size(435, 85);
            this.lblWorkOrder.TabIndex = 59;
            this.lblWorkOrder.Text = "Work Order";
            // 
            // lblPreviousDataWarning
            // 
            this.lblPreviousDataWarning.AutoSize = true;
            this.lblPreviousDataWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousDataWarning.ForeColor = System.Drawing.Color.Black;
            this.lblPreviousDataWarning.Location = new System.Drawing.Point(1971, 199);
            this.lblPreviousDataWarning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPreviousDataWarning.Name = "lblPreviousDataWarning";
            this.lblPreviousDataWarning.Size = new System.Drawing.Size(667, 61);
            this.lblPreviousDataWarning.TabIndex = 74;
            this.lblPreviousDataWarning.Text = "Previously Entered Values";
            this.lblPreviousDataWarning.Visible = false;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.ForeColor = System.Drawing.Color.White;
            this.btnForward.Location = new System.Drawing.Point(2703, 186);
            this.btnForward.Margin = new System.Windows.Forms.Padding(6);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(202, 144);
            this.btnForward.TabIndex = 106;
            this.btnForward.Text = "🢂";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(488, 195);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(202, 144);
            this.btnBack.TabIndex = 105;
            this.btnBack.Text = "🢀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(2341, 1585);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(6);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(565, 175);
            this.btnEnd.TabIndex = 14;
            this.btnEnd.Text = "End Run";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "hh:mm tt";
            this.dtpEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(1165, 1185);
            this.dtpEndTime.Margin = new System.Windows.Forms.Padding(6);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(382, 92);
            this.dtpEndTime.TabIndex = 11;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.ForeColor = System.Drawing.Color.White;
            this.lblEndTime.Location = new System.Drawing.Point(721, 1192);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(366, 85);
            this.lblEndTime.TabIndex = 117;
            this.lblEndTime.Text = "End Time";
            // 
            // btnNextWO
            // 
            this.btnNextWO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.btnNextWO.FlatAppearance.BorderSize = 0;
            this.btnNextWO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextWO.ForeColor = System.Drawing.Color.White;
            this.btnNextWO.Location = new System.Drawing.Point(2103, 740);
            this.btnNextWO.Name = "btnNextWO";
            this.btnNextWO.Size = new System.Drawing.Size(322, 66);
            this.btnNextWO.TabIndex = 118;
            this.btnNextWO.Text = "Next Work Order";
            this.btnNextWO.UseVisualStyleBackColor = false;
            this.btnNextWO.Click += new System.EventHandler(this.btnNextWO_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.sidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sidePanel.Controls.Add(this.lblVersion);
            this.sidePanel.Controls.Add(this.picLogo);
            this.sidePanel.Location = new System.Drawing.Point(-7, -4);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(451, 1829);
            this.sidePanel.TabIndex = 169;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(33, 259);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(349, 29);
            this.lblVersion.TabIndex = 139;
            this.lblVersion.Text = "Version {_version} [beta]";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Image = global::DataEntryApp.Properties.Resources.RMES_MES_LogoLarger1;
            this.picLogo.Location = new System.Drawing.Point(0, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(448, 252);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Location = new System.Drawing.Point(337, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2663, 143);
            this.panel3.TabIndex = 170;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(132, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(574, 118);
            this.label2.TabIndex = 140;
            this.label2.Text = "Distillation";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(2557, -3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 143);
            this.btnClose.TabIndex = 140;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtWorkOrder
            // 
            this.txtWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkOrder.Location = new System.Drawing.Point(1204, 196);
            this.txtWorkOrder.Margin = new System.Windows.Forms.Padding(6);
            this.txtWorkOrder.Name = "txtWorkOrder";
            this.txtWorkOrder.Size = new System.Drawing.Size(697, 92);
            this.txtWorkOrder.TabIndex = 1;
            // 
            // txtInputMaterialWO
            // 
            this.txtInputMaterialWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputMaterialWO.Location = new System.Drawing.Point(1688, 633);
            this.txtInputMaterialWO.Margin = new System.Windows.Forms.Padding(6);
            this.txtInputMaterialWO.Name = "txtInputMaterialWO";
            this.txtInputMaterialWO.Size = new System.Drawing.Size(737, 92);
            this.txtInputMaterialWO.TabIndex = 5;
            // 
            // DistillationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(3000, 1825);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnNextWO);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.txtInputMaterialWO);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPreviousDataWarning);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nudInputWeight);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.EndPanel);
            this.Controls.Add(this.lblInputWeight);
            this.Controls.Add(this.lblInputMaterialWO);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblWorkOrder);
            this.Controls.Add(this.txtWorkOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DistillationForm";
            this.Text = "DistillationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nudInputWeight)).EndInit();
            this.EndPanel.ResumeLayout(false);
            this.EndPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistillateWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWasteWeight)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nudInputWeight;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Panel EndPanel;
        private System.Windows.Forms.TextBox txtTempProfile;
        private System.Windows.Forms.NumericUpDown nudRunTime;
        private System.Windows.Forms.NumericUpDown nudDistillateWeight;
        private System.Windows.Forms.Label lblDistWaste;
        private System.Windows.Forms.Label lblDistWeight;
        private System.Windows.Forms.NumericUpDown nudWasteWeight;
        private System.Windows.Forms.Label lblTempProf;
        private System.Windows.Forms.Label lblRunTime;
        private System.Windows.Forms.Label lblInputWeight;
        private System.Windows.Forms.Label lblInputMaterialWO;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblWorkOrder;
        private System.Windows.Forms.Label lblPreviousDataWarning;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Button btnNextWO;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label lblVersion;
        public System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtWorkOrder;
        private System.Windows.Forms.TextBox txtInputMaterialWO;
    }
}