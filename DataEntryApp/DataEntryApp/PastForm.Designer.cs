using System;

namespace DataEntryApp
{
    partial class PastForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PastForm));
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.nudTemp = new System.Windows.Forms.NumericUpDown();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtContainerNum = new System.Windows.Forms.TextBox();
            this.lblContainerNum = new System.Windows.Forms.Label();
            this.dtpTimeIn = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTimeIn = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.dtpTimeOut = new System.Windows.Forms.DateTimePicker();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.lblPreviousDataWarning = new System.Windows.Forms.Label();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp)).BeginInit();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pm
            // 
            this._pm.Location = new System.Drawing.Point(609, 438);
            // 
            // cmbOperator
            // 
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(893, 551);
            this.cmbOperator.Margin = new System.Windows.Forms.Padding(6);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(180, 63);
            this.cmbOperator.TabIndex = 4;
            // 
            // nudTemp
            // 
            this.nudTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTemp.Location = new System.Drawing.Point(893, 659);
            this.nudTemp.Margin = new System.Windows.Forms.Padding(6);
            this.nudTemp.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.nudTemp.Name = "nudTemp";
            this.nudTemp.Size = new System.Drawing.Size(156, 62);
            this.nudTemp.TabIndex = 5;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.White;
            this.lblTemp.Location = new System.Drawing.Point(388, 661);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(466, 55);
            this.lblTemp.TabIndex = 10;
            this.lblTemp.Text = "Temp Set Point (°F)";
            // 
            // txtContainerNum
            // 
            this.txtContainerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContainerNum.Location = new System.Drawing.Point(893, 444);
            this.txtContainerNum.Margin = new System.Windows.Forms.Padding(6);
            this.txtContainerNum.Name = "txtContainerNum";
            this.txtContainerNum.Size = new System.Drawing.Size(272, 62);
            this.txtContainerNum.TabIndex = 3;
            // 
            // lblContainerNum
            // 
            this.lblContainerNum.AutoSize = true;
            this.lblContainerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContainerNum.ForeColor = System.Drawing.Color.White;
            this.lblContainerNum.Location = new System.Drawing.Point(388, 447);
            this.lblContainerNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblContainerNum.Name = "lblContainerNum";
            this.lblContainerNum.Size = new System.Drawing.Size(448, 55);
            this.lblContainerNum.TabIndex = 70;
            this.lblContainerNum.Text = "Container Number ";
            // 
            // dtpTimeIn
            // 
            this.dtpTimeIn.CustomFormat = "hh:mm tt";
            this.dtpTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeIn.Location = new System.Drawing.Point(893, 227);
            this.dtpTimeIn.Margin = new System.Windows.Forms.Padding(6);
            this.dtpTimeIn.Name = "dtpTimeIn";
            this.dtpTimeIn.ShowUpDown = true;
            this.dtpTimeIn.Size = new System.Drawing.Size(282, 62);
            this.dtpTimeIn.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(893, 334);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(807, 62);
            this.dtpDate.TabIndex = 2;
            // 
            // lblTimeIn
            // 
            this.lblTimeIn.AutoSize = true;
            this.lblTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeIn.ForeColor = System.Drawing.Color.White;
            this.lblTimeIn.Location = new System.Drawing.Point(388, 233);
            this.lblTimeIn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTimeIn.Name = "lblTimeIn";
            this.lblTimeIn.Size = new System.Drawing.Size(190, 55);
            this.lblTimeIn.TabIndex = 68;
            this.lblTimeIn.Text = "Time In";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(388, 341);
            this.lblDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(130, 55);
            this.lblDate.TabIndex = 66;
            this.lblDate.Text = "Date";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.ForeColor = System.Drawing.Color.White;
            this.lblOperator.Location = new System.Drawing.Point(388, 554);
            this.lblOperator.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(222, 55);
            this.lblOperator.TabIndex = 64;
            this.lblOperator.Text = "Operator";
            // 
            // dtpTimeOut
            // 
            this.dtpTimeOut.CustomFormat = "hh:mm tt";
            this.dtpTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeOut.Location = new System.Drawing.Point(893, 769);
            this.dtpTimeOut.Margin = new System.Windows.Forms.Padding(6);
            this.dtpTimeOut.Name = "dtpTimeOut";
            this.dtpTimeOut.ShowUpDown = true;
            this.dtpTimeOut.Size = new System.Drawing.Size(282, 62);
            this.dtpTimeOut.TabIndex = 6;
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOut.ForeColor = System.Drawing.Color.White;
            this.lblTimeOut.Location = new System.Drawing.Point(388, 769);
            this.lblTimeOut.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(228, 55);
            this.lblTimeOut.TabIndex = 81;
            this.lblTimeOut.Text = "Time Out";
            // 
            // lblPreviousDataWarning
            // 
            this.lblPreviousDataWarning.AutoSize = true;
            this.lblPreviousDataWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousDataWarning.ForeColor = System.Drawing.Color.Black;
            this.lblPreviousDataWarning.Location = new System.Drawing.Point(781, 120);
            this.lblPreviousDataWarning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPreviousDataWarning.Name = "lblPreviousDataWarning";
            this.lblPreviousDataWarning.Size = new System.Drawing.Size(535, 48);
            this.lblPreviousDataWarning.TabIndex = 82;
            this.lblPreviousDataWarning.Text = "Previously Entered Values";
            this.lblPreviousDataWarning.Visible = false;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.ForeColor = System.Drawing.Color.White;
            this.btnForward.Location = new System.Drawing.Point(1583, 120);
            this.btnForward.Margin = new System.Windows.Forms.Padding(6);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(116, 75);
            this.btnForward.TabIndex = 112;
            this.btnForward.Text = "🢂";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(398, 120);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 75);
            this.btnBack.TabIndex = 111;
            this.btnBack.Text = "🢀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.label2.Size = new System.Drawing.Size(347, 60);
            this.label2.TabIndex = 140;
            this.label2.Text = "Pasterization";
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
            this.btnSubmit.Location = new System.Drawing.Point(1343, 769);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(357, 196);
            this.btnSubmit.TabIndex = 140;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // PastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1774, 1029);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblPreviousDataWarning);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.nudTemp);
            this.Controls.Add(this.dtpTimeOut);
            this.Controls.Add(this.lblTimeOut);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.txtContainerNum);
            this.Controls.Add(this.lblContainerNum);
            this.Controls.Add(this.dtpTimeIn);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblTimeIn);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblOperator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PastForm";
            this.Text = "PastForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.NumericUpDown nudTemp;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox txtContainerNum;
        private System.Windows.Forms.Label lblContainerNum;
        private System.Windows.Forms.DateTimePicker dtpTimeIn;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTimeIn;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.DateTimePicker dtpTimeOut;
        private System.Windows.Forms.Label lblTimeOut;
        private System.Windows.Forms.Label lblPreviousDataWarning;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label lblVersion;
        public System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
    }
}