using System;

namespace DataEntryApp
{
    partial class CustomerWOForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerWOForm));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtInputMaterialWO = new System.Windows.Forms.TextBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPreviousDataWarning = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtFinalProd = new System.Windows.Forms.TextBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.nudOutputMass = new System.Windows.Forms.NumericUpDown();
            this.lblOutputMass = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnNextWO = new System.Windows.Forms.Button();
            this.nudInputMass = new System.Windows.Forms.NumericUpDown();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblFinalProd = new System.Windows.Forms.Label();
            this.lblInputMass = new System.Windows.Forms.Label();
            this.lblInputMaterialWO = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblWorkOrder = new System.Windows.Forms.Label();
            this.txtWorkOrder = new System.Windows.Forms.TextBox();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputMass)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(190)))), ((int)(((byte)(110)))));
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(240)))), ((int)(((byte)(130)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Image = global::DataEntryApp.Properties.Resources.Upload1;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.Location = new System.Drawing.Point(2332, 1503);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(518, 289);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtInputMaterialWO
            // 
            this.txtInputMaterialWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputMaterialWO.Location = new System.Drawing.Point(1536, 814);
            this.txtInputMaterialWO.Margin = new System.Windows.Forms.Padding(6);
            this.txtInputMaterialWO.Name = "txtInputMaterialWO";
            this.txtInputMaterialWO.Size = new System.Drawing.Size(678, 86);
            this.txtInputMaterialWO.TabIndex = 6;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.sidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sidePanel.Controls.Add(this.lblVersion);
            this.sidePanel.Controls.Add(this.picLogo);
            this.sidePanel.Location = new System.Drawing.Point(-2, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(451, 1822);
            this.sidePanel.TabIndex = 171;
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
            this.panel3.Location = new System.Drawing.Point(384, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2615, 143);
            this.panel3.TabIndex = 172;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(132, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(838, 118);
            this.label2.TabIndex = 140;
            this.label2.Text = "Customer Order";
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
            this.btnClose.Location = new System.Drawing.Point(2508, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 143);
            this.btnClose.TabIndex = 140;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.ForeColor = System.Drawing.Color.White;
            this.btnForward.Location = new System.Drawing.Point(2685, 156);
            this.btnForward.Margin = new System.Windows.Forms.Padding(6);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(165, 124);
            this.btnForward.TabIndex = 112;
            this.btnForward.Text = "🢂";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(578, 156);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(165, 124);
            this.btnBack.TabIndex = 111;
            this.btnBack.Text = "🢀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPreviousDataWarning
            // 
            this.lblPreviousDataWarning.AutoSize = true;
            this.lblPreviousDataWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousDataWarning.ForeColor = System.Drawing.Color.Black;
            this.lblPreviousDataWarning.Location = new System.Drawing.Point(1390, 166);
            this.lblPreviousDataWarning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPreviousDataWarning.Name = "lblPreviousDataWarning";
            this.lblPreviousDataWarning.Size = new System.Drawing.Size(866, 79);
            this.lblPreviousDataWarning.TabIndex = 69;
            this.lblPreviousDataWarning.Text = "Previously Entered Values";
            this.lblPreviousDataWarning.Visible = false;
            this.lblPreviousDataWarning.Click += new System.EventHandler(this.lblPreviousDataWarning_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(563, 393);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(371, 85);
            this.lblCustomer.TabIndex = 68;
            this.lblCustomer.Text = "Customer";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(1404, 393);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(590, 86);
            this.txtCustomer.TabIndex = 2;
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(578, 1503);
            this.txtComment.Margin = new System.Windows.Forms.Padding(6);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(1661, 289);
            this.txtComment.TabIndex = 11;
            // 
            // txtFinalProd
            // 
            this.txtFinalProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalProd.Location = new System.Drawing.Point(1536, 1306);
            this.txtFinalProd.Margin = new System.Windows.Forms.Padding(6);
            this.txtFinalProd.Name = "txtFinalProd";
            this.txtFinalProd.Size = new System.Drawing.Size(1314, 92);
            this.txtFinalProd.TabIndex = 10;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(1536, 1201);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(1314, 92);
            this.dtpEndDate.TabIndex = 9;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(563, 1208);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(358, 85);
            this.lblEndDate.TabIndex = 63;
            this.lblEndDate.Text = "End Date";
            // 
            // nudOutputMass
            // 
            this.nudOutputMass.DecimalPlaces = 1;
            this.nudOutputMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudOutputMass.Location = new System.Drawing.Point(1536, 1097);
            this.nudOutputMass.Margin = new System.Windows.Forms.Padding(6);
            this.nudOutputMass.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudOutputMass.Name = "nudOutputMass";
            this.nudOutputMass.Size = new System.Drawing.Size(240, 92);
            this.nudOutputMass.TabIndex = 8;
            // 
            // lblOutputMass
            // 
            this.lblOutputMass.AutoSize = true;
            this.lblOutputMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputMass.ForeColor = System.Drawing.Color.White;
            this.lblOutputMass.Location = new System.Drawing.Point(562, 1100);
            this.lblOutputMass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOutputMass.Name = "lblOutputMass";
            this.lblOutputMass.Size = new System.Drawing.Size(629, 85);
            this.lblOutputMass.TabIndex = 62;
            this.lblOutputMass.Text = "Output Mass (kg)";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(1404, 706);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(1349, 92);
            this.dtpStartDate.TabIndex = 5;
            // 
            // btnNextWO
            // 
            this.btnNextWO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.btnNextWO.FlatAppearance.BorderSize = 0;
            this.btnNextWO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextWO.ForeColor = System.Drawing.Color.White;
            this.btnNextWO.Location = new System.Drawing.Point(1898, 909);
            this.btnNextWO.Name = "btnNextWO";
            this.btnNextWO.Size = new System.Drawing.Size(316, 73);
            this.btnNextWO.TabIndex = 59;
            this.btnNextWO.Text = "Next Work Order";
            this.btnNextWO.UseVisualStyleBackColor = false;
            this.btnNextWO.Click += new System.EventHandler(this.btnNextWO_Click);
            // 
            // nudInputMass
            // 
            this.nudInputMass.DecimalPlaces = 1;
            this.nudInputMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInputMass.Location = new System.Drawing.Point(1536, 993);
            this.nudInputMass.Margin = new System.Windows.Forms.Padding(6);
            this.nudInputMass.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudInputMass.Name = "nudInputMass";
            this.nudInputMass.Size = new System.Drawing.Size(240, 92);
            this.nudInputMass.TabIndex = 7;
            // 
            // cmbOperator
            // 
            this.cmbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(1404, 493);
            this.cmbOperator.Margin = new System.Windows.Forms.Padding(6);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(309, 93);
            this.cmbOperator.TabIndex = 3;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.Color.White;
            this.lblComment.Location = new System.Drawing.Point(563, 1404);
            this.lblComment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(369, 85);
            this.lblComment.TabIndex = 58;
            this.lblComment.Text = "Comment";
            // 
            // lblFinalProd
            // 
            this.lblFinalProd.AutoSize = true;
            this.lblFinalProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalProd.ForeColor = System.Drawing.Color.White;
            this.lblFinalProd.Location = new System.Drawing.Point(563, 1309);
            this.lblFinalProd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFinalProd.Name = "lblFinalProd";
            this.lblFinalProd.Size = new System.Drawing.Size(904, 85);
            this.lblFinalProd.TabIndex = 56;
            this.lblFinalProd.Text = "Final Product Description";
            // 
            // lblInputMass
            // 
            this.lblInputMass.AutoSize = true;
            this.lblInputMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputMass.ForeColor = System.Drawing.Color.White;
            this.lblInputMass.Location = new System.Drawing.Point(563, 995);
            this.lblInputMass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInputMass.Name = "lblInputMass";
            this.lblInputMass.Size = new System.Drawing.Size(570, 85);
            this.lblInputMass.TabIndex = 51;
            this.lblInputMass.Text = "Input Mass (kg)";
            // 
            // lblInputMaterialWO
            // 
            this.lblInputMaterialWO.AutoSize = true;
            this.lblInputMaterialWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputMaterialWO.ForeColor = System.Drawing.Color.White;
            this.lblInputMaterialWO.Location = new System.Drawing.Point(560, 808);
            this.lblInputMaterialWO.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInputMaterialWO.Name = "lblInputMaterialWO";
            this.lblInputMaterialWO.Size = new System.Drawing.Size(926, 85);
            this.lblInputMaterialWO.TabIndex = 50;
            this.lblInputMaterialWO.Text = "Input Material Work Order";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(1404, 600);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(1349, 92);
            this.dtpDate.TabIndex = 4;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(562, 699);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(385, 85);
            this.lblStartDate.TabIndex = 46;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(563, 597);
            this.lblDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(200, 85);
            this.lblDate.TabIndex = 44;
            this.lblDate.Text = "Date";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.ForeColor = System.Drawing.Color.White;
            this.lblOperator.Location = new System.Drawing.Point(563, 495);
            this.lblOperator.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(342, 85);
            this.lblOperator.TabIndex = 42;
            this.lblOperator.Text = "Operator";
            // 
            // lblWorkOrder
            // 
            this.lblWorkOrder.AutoSize = true;
            this.lblWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkOrder.ForeColor = System.Drawing.Color.White;
            this.lblWorkOrder.Location = new System.Drawing.Point(562, 291);
            this.lblWorkOrder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWorkOrder.Name = "lblWorkOrder";
            this.lblWorkOrder.Size = new System.Drawing.Size(790, 85);
            this.lblWorkOrder.TabIndex = 41;
            this.lblWorkOrder.Text = "Customer Work Order";
            // 
            // txtWorkOrder
            // 
            this.txtWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkOrder.Location = new System.Drawing.Point(1404, 293);
            this.txtWorkOrder.Margin = new System.Windows.Forms.Padding(6);
            this.txtWorkOrder.Name = "txtWorkOrder";
            this.txtWorkOrder.Size = new System.Drawing.Size(590, 86);
            this.txtWorkOrder.TabIndex = 1;
            // 
            // CustomerWOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(3000, 1825);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtInputMaterialWO);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPreviousDataWarning);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtFinalProd);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.nudOutputMass);
            this.Controls.Add(this.lblOutputMass);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnNextWO);
            this.Controls.Add(this.nudInputMass);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblFinalProd);
            this.Controls.Add(this.lblInputMass);
            this.Controls.Add(this.lblInputMaterialWO);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblWorkOrder);
            this.Controls.Add(this.txtWorkOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerWOForm";
            this.Text = "Customer Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void lblPreviousDataWarning_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnNextWO;
        private System.Windows.Forms.NumericUpDown nudInputMass;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Label lblInputMass;
        private System.Windows.Forms.Label lblInputMaterialWO;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblWorkOrder;
        private System.Windows.Forms.TextBox txtWorkOrder;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.NumericUpDown nudOutputMass;
        private System.Windows.Forms.Label lblOutputMass;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblFinalProd;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtFinalProd;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblPreviousDataWarning;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label lblVersion;
        public System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtInputMaterialWO;
        private System.Windows.Forms.Button btnSubmit;
    }
}