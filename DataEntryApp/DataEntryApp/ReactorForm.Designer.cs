namespace DataEntryApp
{
    partial class ReactorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReactorForm));
            this.numExtractionMass = new System.Windows.Forms.NumericUpDown();
            this.numDecarbedOil = new System.Windows.Forms.NumericUpDown();
            this.numVolatileMass = new System.Windows.Forms.NumericUpDown();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.lblDecarbedOil = new System.Windows.Forms.Label();
            this.lblVolatileMass = new System.Windows.Forms.Label();
            this.pnlReactorDecarb = new System.Windows.Forms.Panel();
            this.numDecarbTempSetPoint = new System.Windows.Forms.NumericUpDown();
            this.numDecarbTempSetRunDur = new System.Windows.Forms.NumericUpDown();
            this.lblDecarbTemp = new System.Windows.Forms.Label();
            this.lblDecarbRunDur = new System.Windows.Forms.Label();
            this.pnlReactorTrp = new System.Windows.Forms.Panel();
            this.numTerpRunDir = new System.Windows.Forms.NumericUpDown();
            this.numTerpSetPoint = new System.Windows.Forms.NumericUpDown();
            this.lblTerpenes = new System.Windows.Forms.Label();
            this.lblTerpenesRunDur = new System.Windows.Forms.Label();
            this.lblExtractionMass = new System.Windows.Forms.Label();
            this.txtExtractionWorkOrder = new System.Windows.Forms.TextBox();
            this.lblExtractionWO = new System.Windows.Forms.Label();
            this.pickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.pickerDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblWorkOrder = new System.Windows.Forms.Label();
            this.txtWorkOrder = new System.Windows.Forms.TextBox();
            this.lblPreviousDataWarning = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNextWO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numExtractionMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDecarbedOil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolatileMass)).BeginInit();
            this.pnlReactorDecarb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDecarbTempSetPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDecarbTempSetRunDur)).BeginInit();
            this.pnlReactorTrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTerpRunDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTerpSetPoint)).BeginInit();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // numExtractionMass
            // 
            this.numExtractionMass.DecimalPlaces = 1;
            this.numExtractionMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numExtractionMass.Location = new System.Drawing.Point(1585, 482);
            this.numExtractionMass.Margin = new System.Windows.Forms.Padding(6);
            this.numExtractionMass.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numExtractionMass.Name = "numExtractionMass";
            this.numExtractionMass.Size = new System.Drawing.Size(166, 49);
            this.numExtractionMass.TabIndex = 6;
            // 
            // numDecarbedOil
            // 
            this.numDecarbedOil.DecimalPlaces = 1;
            this.numDecarbedOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDecarbedOil.Location = new System.Drawing.Point(1046, 998);
            this.numDecarbedOil.Margin = new System.Windows.Forms.Padding(6);
            this.numDecarbedOil.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numDecarbedOil.Name = "numDecarbedOil";
            this.numDecarbedOil.Size = new System.Drawing.Size(134, 49);
            this.numDecarbedOil.TabIndex = 12;
            // 
            // numVolatileMass
            // 
            this.numVolatileMass.DecimalPlaces = 1;
            this.numVolatileMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numVolatileMass.Location = new System.Drawing.Point(1046, 932);
            this.numVolatileMass.Margin = new System.Windows.Forms.Padding(6);
            this.numVolatileMass.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numVolatileMass.Name = "numVolatileMass";
            this.numVolatileMass.Size = new System.Drawing.Size(134, 49);
            this.numVolatileMass.TabIndex = 11;
            // 
            // cmbOperator
            // 
            this.cmbOperator.BackColor = System.Drawing.Color.White;
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(845, 277);
            this.cmbOperator.Margin = new System.Windows.Forms.Padding(12);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(308, 50);
            this.cmbOperator.TabIndex = 2;
            // 
            // lblDecarbedOil
            // 
            this.lblDecarbedOil.AutoSize = true;
            this.lblDecarbedOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecarbedOil.ForeColor = System.Drawing.Color.White;
            this.lblDecarbedOil.Location = new System.Drawing.Point(398, 1002);
            this.lblDecarbedOil.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDecarbedOil.Name = "lblDecarbedOil";
            this.lblDecarbedOil.Size = new System.Drawing.Size(432, 42);
            this.lblDecarbedOil.TabIndex = 37;
            this.lblDecarbedOil.Text = "Decarbed Oil Mass (kg)";
            // 
            // lblVolatileMass
            // 
            this.lblVolatileMass.AutoSize = true;
            this.lblVolatileMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolatileMass.ForeColor = System.Drawing.Color.White;
            this.lblVolatileMass.Location = new System.Drawing.Point(398, 935);
            this.lblVolatileMass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVolatileMass.Name = "lblVolatileMass";
            this.lblVolatileMass.Size = new System.Drawing.Size(332, 42);
            this.lblVolatileMass.TabIndex = 35;
            this.lblVolatileMass.Text = "Volatile Mass (kg)";
            // 
            // pnlReactorDecarb
            // 
            this.pnlReactorDecarb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.pnlReactorDecarb.Controls.Add(this.numDecarbTempSetPoint);
            this.pnlReactorDecarb.Controls.Add(this.numDecarbTempSetRunDur);
            this.pnlReactorDecarb.Controls.Add(this.lblDecarbTemp);
            this.pnlReactorDecarb.Controls.Add(this.lblDecarbRunDur);
            this.pnlReactorDecarb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlReactorDecarb.Location = new System.Drawing.Point(386, 761);
            this.pnlReactorDecarb.Margin = new System.Windows.Forms.Padding(6);
            this.pnlReactorDecarb.Name = "pnlReactorDecarb";
            this.pnlReactorDecarb.Size = new System.Drawing.Size(812, 151);
            this.pnlReactorDecarb.TabIndex = 31;
            // 
            // numDecarbTempSetPoint
            // 
            this.numDecarbTempSetPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDecarbTempSetPoint.Location = new System.Drawing.Point(660, 12);
            this.numDecarbTempSetPoint.Margin = new System.Windows.Forms.Padding(6);
            this.numDecarbTempSetPoint.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numDecarbTempSetPoint.Name = "numDecarbTempSetPoint";
            this.numDecarbTempSetPoint.Size = new System.Drawing.Size(134, 56);
            this.numDecarbTempSetPoint.TabIndex = 9;
            // 
            // numDecarbTempSetRunDur
            // 
            this.numDecarbTempSetRunDur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDecarbTempSetRunDur.Location = new System.Drawing.Point(660, 81);
            this.numDecarbTempSetRunDur.Margin = new System.Windows.Forms.Padding(6);
            this.numDecarbTempSetRunDur.Name = "numDecarbTempSetRunDur";
            this.numDecarbTempSetRunDur.Size = new System.Drawing.Size(134, 56);
            this.numDecarbTempSetRunDur.TabIndex = 10;
            // 
            // lblDecarbTemp
            // 
            this.lblDecarbTemp.AutoSize = true;
            this.lblDecarbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecarbTemp.ForeColor = System.Drawing.Color.White;
            this.lblDecarbTemp.Location = new System.Drawing.Point(12, 24);
            this.lblDecarbTemp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDecarbTemp.Name = "lblDecarbTemp";
            this.lblDecarbTemp.Size = new System.Drawing.Size(507, 42);
            this.lblDecarbTemp.TabIndex = 10;
            this.lblDecarbTemp.Text = "Decarb Temp Set Point (°C)";
            // 
            // lblDecarbRunDur
            // 
            this.lblDecarbRunDur.AutoSize = true;
            this.lblDecarbRunDur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecarbRunDur.ForeColor = System.Drawing.Color.White;
            this.lblDecarbRunDur.Location = new System.Drawing.Point(12, 89);
            this.lblDecarbRunDur.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDecarbRunDur.Name = "lblDecarbRunDur";
            this.lblDecarbRunDur.Size = new System.Drawing.Size(342, 42);
            this.lblDecarbRunDur.TabIndex = 11;
            this.lblDecarbRunDur.Text = "Run Duration (hrs)";
            // 
            // pnlReactorTrp
            // 
            this.pnlReactorTrp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.pnlReactorTrp.Controls.Add(this.numTerpRunDir);
            this.pnlReactorTrp.Controls.Add(this.numTerpSetPoint);
            this.pnlReactorTrp.Controls.Add(this.lblTerpenes);
            this.pnlReactorTrp.Controls.Add(this.lblTerpenesRunDur);
            this.pnlReactorTrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlReactorTrp.Location = new System.Drawing.Point(386, 601);
            this.pnlReactorTrp.Margin = new System.Windows.Forms.Padding(6);
            this.pnlReactorTrp.Name = "pnlReactorTrp";
            this.pnlReactorTrp.Size = new System.Drawing.Size(812, 148);
            this.pnlReactorTrp.TabIndex = 28;
            // 
            // numTerpRunDir
            // 
            this.numTerpRunDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTerpRunDir.Location = new System.Drawing.Point(660, 82);
            this.numTerpRunDir.Margin = new System.Windows.Forms.Padding(6);
            this.numTerpRunDir.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numTerpRunDir.Name = "numTerpRunDir";
            this.numTerpRunDir.Size = new System.Drawing.Size(134, 56);
            this.numTerpRunDir.TabIndex = 8;
            // 
            // numTerpSetPoint
            // 
            this.numTerpSetPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTerpSetPoint.Location = new System.Drawing.Point(660, 14);
            this.numTerpSetPoint.Margin = new System.Windows.Forms.Padding(6);
            this.numTerpSetPoint.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numTerpSetPoint.Name = "numTerpSetPoint";
            this.numTerpSetPoint.Size = new System.Drawing.Size(134, 56);
            this.numTerpSetPoint.TabIndex = 7;
            // 
            // lblTerpenes
            // 
            this.lblTerpenes.AutoSize = true;
            this.lblTerpenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerpenes.ForeColor = System.Drawing.Color.White;
            this.lblTerpenes.Location = new System.Drawing.Point(12, 20);
            this.lblTerpenes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTerpenes.Name = "lblTerpenes";
            this.lblTerpenes.Size = new System.Drawing.Size(437, 42);
            this.lblTerpenes.TabIndex = 10;
            this.lblTerpenes.Text = "Terpenes Set Point (°C)";
            // 
            // lblTerpenesRunDur
            // 
            this.lblTerpenesRunDur.AutoSize = true;
            this.lblTerpenesRunDur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerpenesRunDur.ForeColor = System.Drawing.Color.White;
            this.lblTerpenesRunDur.Location = new System.Drawing.Point(12, 86);
            this.lblTerpenesRunDur.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTerpenesRunDur.Name = "lblTerpenesRunDur";
            this.lblTerpenesRunDur.Size = new System.Drawing.Size(342, 42);
            this.lblTerpenesRunDur.TabIndex = 11;
            this.lblTerpenesRunDur.Text = "Run Duration (hrs)";
            // 
            // lblExtractionMass
            // 
            this.lblExtractionMass.AutoSize = true;
            this.lblExtractionMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtractionMass.ForeColor = System.Drawing.Color.White;
            this.lblExtractionMass.Location = new System.Drawing.Point(1183, 484);
            this.lblExtractionMass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblExtractionMass.Name = "lblExtractionMass";
            this.lblExtractionMass.Size = new System.Drawing.Size(378, 42);
            this.lblExtractionMass.TabIndex = 30;
            this.lblExtractionMass.Text = "Extraction Mass (kg)";
            // 
            // txtExtractionWorkOrder
            // 
            this.txtExtractionWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtractionWorkOrder.Location = new System.Drawing.Point(845, 479);
            this.txtExtractionWorkOrder.Margin = new System.Windows.Forms.Padding(6);
            this.txtExtractionWorkOrder.Name = "txtExtractionWorkOrder";
            this.txtExtractionWorkOrder.Size = new System.Drawing.Size(308, 49);
            this.txtExtractionWorkOrder.TabIndex = 5;
            this.txtExtractionWorkOrder.Text = "EX.";
            // 
            // lblExtractionWO
            // 
            this.lblExtractionWO.AutoSize = true;
            this.lblExtractionWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtractionWO.ForeColor = System.Drawing.Color.White;
            this.lblExtractionWO.Location = new System.Drawing.Point(379, 484);
            this.lblExtractionWO.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblExtractionWO.Name = "lblExtractionWO";
            this.lblExtractionWO.Size = new System.Drawing.Size(407, 42);
            this.lblExtractionWO.TabIndex = 29;
            this.lblExtractionWO.Text = "Extraction Work Order";
            // 
            // pickerStartTime
            // 
            this.pickerStartTime.CustomFormat = "hh:mm tt";
            this.pickerStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerStartTime.Location = new System.Drawing.Point(845, 412);
            this.pickerStartTime.Margin = new System.Windows.Forms.Padding(6);
            this.pickerStartTime.Name = "pickerStartTime";
            this.pickerStartTime.ShowUpDown = true;
            this.pickerStartTime.Size = new System.Drawing.Size(306, 49);
            this.pickerStartTime.TabIndex = 4;
            // 
            // pickerDate
            // 
            this.pickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerDate.Location = new System.Drawing.Point(845, 345);
            this.pickerDate.Margin = new System.Windows.Forms.Padding(6);
            this.pickerDate.Name = "pickerDate";
            this.pickerDate.Size = new System.Drawing.Size(716, 49);
            this.pickerDate.TabIndex = 3;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.ForeColor = System.Drawing.Color.White;
            this.lblStartTime.Location = new System.Drawing.Point(377, 416);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(198, 42);
            this.lblStartTime.TabIndex = 25;
            this.lblStartTime.Text = "Start Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(377, 348);
            this.lblDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(101, 42);
            this.lblDate.TabIndex = 23;
            this.lblDate.Text = "Date";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.ForeColor = System.Drawing.Color.White;
            this.lblOperator.Location = new System.Drawing.Point(377, 280);
            this.lblOperator.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(173, 42);
            this.lblOperator.TabIndex = 21;
            this.lblOperator.Text = "Operator";
            // 
            // lblWorkOrder
            // 
            this.lblWorkOrder.AutoSize = true;
            this.lblWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkOrder.ForeColor = System.Drawing.Color.White;
            this.lblWorkOrder.Location = new System.Drawing.Point(377, 212);
            this.lblWorkOrder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWorkOrder.Name = "lblWorkOrder";
            this.lblWorkOrder.Size = new System.Drawing.Size(220, 42);
            this.lblWorkOrder.TabIndex = 20;
            this.lblWorkOrder.Text = "Work Order";
            // 
            // txtWorkOrder
            // 
            this.txtWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkOrder.Location = new System.Drawing.Point(845, 210);
            this.txtWorkOrder.Margin = new System.Windows.Forms.Padding(6);
            this.txtWorkOrder.Name = "txtWorkOrder";
            this.txtWorkOrder.Size = new System.Drawing.Size(308, 49);
            this.txtWorkOrder.TabIndex = 1;
            this.txtWorkOrder.Text = "DC.";
            // 
            // lblPreviousDataWarning
            // 
            this.lblPreviousDataWarning.AutoSize = true;
            this.lblPreviousDataWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousDataWarning.Location = new System.Drawing.Point(806, 132);
            this.lblPreviousDataWarning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPreviousDataWarning.Name = "lblPreviousDataWarning";
            this.lblPreviousDataWarning.Size = new System.Drawing.Size(554, 51);
            this.lblPreviousDataWarning.TabIndex = 39;
            this.lblPreviousDataWarning.Text = "Previously Entered Values";
            this.lblPreviousDataWarning.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(386, 121);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 75);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "🢀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.ForeColor = System.Drawing.Color.White;
            this.btnForward.Location = new System.Drawing.Point(1635, 121);
            this.btnForward.Margin = new System.Windows.Forms.Padding(6);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(116, 75);
            this.btnForward.TabIndex = 41;
            this.btnForward.Text = "🢂";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.sidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sidePanel.Controls.Add(this.lblVersion);
            this.sidePanel.Controls.Add(this.picLogo);
            this.sidePanel.Location = new System.Drawing.Point(-1, -1);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(347, 1101);
            this.sidePanel.TabIndex = 142;
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
            this.panel3.Location = new System.Drawing.Point(337, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1463, 96);
            this.panel3.TabIndex = 143;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 60);
            this.label2.TabIndex = 140;
            this.label2.Text = "Reactor";
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
            this.btnClose.Location = new System.Drawing.Point(1384, -10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 108);
            this.btnClose.TabIndex = 140;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnSubmit.Location = new System.Drawing.Point(1390, 847);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(361, 197);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNextWO
            // 
            this.btnNextWO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.btnNextWO.FlatAppearance.BorderSize = 0;
            this.btnNextWO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextWO.ForeColor = System.Drawing.Color.White;
            this.btnNextWO.Location = new System.Drawing.Point(934, 537);
            this.btnNextWO.Name = "btnNextWO";
            this.btnNextWO.Size = new System.Drawing.Size(219, 48);
            this.btnNextWO.TabIndex = 151;
            this.btnNextWO.Text = "Next Work Order";
            this.btnNextWO.UseVisualStyleBackColor = false;
            this.btnNextWO.Click += new System.EventHandler(this.btnNextWO_Click);
            // 
            // ReactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1800, 1100);
            this.Controls.Add(this.btnNextWO);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPreviousDataWarning);
            this.Controls.Add(this.numExtractionMass);
            this.Controls.Add(this.numDecarbedOil);
            this.Controls.Add(this.numVolatileMass);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.lblDecarbedOil);
            this.Controls.Add(this.lblVolatileMass);
            this.Controls.Add(this.pnlReactorDecarb);
            this.Controls.Add(this.pnlReactorTrp);
            this.Controls.Add(this.lblExtractionMass);
            this.Controls.Add(this.txtExtractionWorkOrder);
            this.Controls.Add(this.lblExtractionWO);
            this.Controls.Add(this.pickerStartTime);
            this.Controls.Add(this.pickerDate);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblWorkOrder);
            this.Controls.Add(this.txtWorkOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReactorForm";
            this.Text = "ReactorForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.numExtractionMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDecarbedOil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolatileMass)).EndInit();
            this.pnlReactorDecarb.ResumeLayout(false);
            this.pnlReactorDecarb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDecarbTempSetPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDecarbTempSetRunDur)).EndInit();
            this.pnlReactorTrp.ResumeLayout(false);
            this.pnlReactorTrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTerpRunDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTerpSetPoint)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numExtractionMass;
        private System.Windows.Forms.NumericUpDown numDecarbedOil;
        private System.Windows.Forms.NumericUpDown numVolatileMass;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Label lblDecarbedOil;
        private System.Windows.Forms.Label lblVolatileMass;
        private System.Windows.Forms.Panel pnlReactorDecarb;
        private System.Windows.Forms.NumericUpDown numDecarbTempSetPoint;
        private System.Windows.Forms.NumericUpDown numDecarbTempSetRunDur;
        private System.Windows.Forms.Label lblDecarbTemp;
        private System.Windows.Forms.Label lblDecarbRunDur;
        private System.Windows.Forms.Panel pnlReactorTrp;
        private System.Windows.Forms.NumericUpDown numTerpRunDir;
        private System.Windows.Forms.NumericUpDown numTerpSetPoint;
        private System.Windows.Forms.Label lblTerpenes;
        private System.Windows.Forms.Label lblTerpenesRunDur;
        private System.Windows.Forms.Label lblExtractionMass;
        private System.Windows.Forms.TextBox txtExtractionWorkOrder;
        private System.Windows.Forms.Label lblExtractionWO;
        private System.Windows.Forms.DateTimePicker pickerStartTime;
        private System.Windows.Forms.DateTimePicker pickerDate;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblWorkOrder;
        private System.Windows.Forms.TextBox txtWorkOrder;
        private System.Windows.Forms.Label lblPreviousDataWarning;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label lblVersion;
        public System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNextWO;
    }
}