using System;

namespace DataEntryApp
{
    partial class ProcessManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessManager));
            this.lblPreviousDataWarning = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPMClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnPast = new System.Windows.Forms.Button();
            this.btnMill = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnDist = new System.Windows.Forms.Button();
            this.btn200L = new System.Windows.Forms.Button();
            this.btn40L = new System.Windows.Forms.Button();
            this.btnReactor = new System.Windows.Forms.Button();
            this.btnDecarb = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPreviousDataWarning
            // 
            this.lblPreviousDataWarning.AutoSize = true;
            this.lblPreviousDataWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousDataWarning.Location = new System.Drawing.Point(780, 118);
            this.lblPreviousDataWarning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPreviousDataWarning.Name = "lblPreviousDataWarning";
            this.lblPreviousDataWarning.Size = new System.Drawing.Size(535, 48);
            this.lblPreviousDataWarning.TabIndex = 40;
            this.lblPreviousDataWarning.Text = "Previously Entered Values";
            this.lblPreviousDataWarning.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1696, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 84);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnPMClose);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(265, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1516, 99);
            this.panel1.TabIndex = 42;
            // 
            // btnPMClose
            // 
            this.btnPMClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.btnPMClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPMClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnPMClose.FlatAppearance.BorderSize = 0;
            this.btnPMClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPMClose.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPMClose.ForeColor = System.Drawing.Color.White;
            this.btnPMClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPMClose.Location = new System.Drawing.Point(1438, 0);
            this.btnPMClose.Name = "btnPMClose";
            this.btnPMClose.Size = new System.Drawing.Size(72, 96);
            this.btnPMClose.TabIndex = 141;
            this.btnPMClose.Text = "X";
            this.btnPMClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPMClose.UseVisualStyleBackColor = false;
            this.btnPMClose.Click += new System.EventHandler(this.btnPMClose_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.lblVersion);
            this.panel2.Controls.Add(this.picLogo);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(1, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 1044);
            this.panel2.TabIndex = 43;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(0, 182);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(313, 26);
            this.lblVersion.TabIndex = 141;
            this.lblVersion.Text = "Version {_version} [beta]";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Image = global::DataEntryApp.Properties.Resources.RMES_MES_Logo2;
            this.picLogo.Location = new System.Drawing.Point(3, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(310, 175);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 140;
            this.picLogo.TabStop = false;
            // 
            // btnPast
            // 
            this.btnPast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.btnPast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPast.FlatAppearance.BorderSize = 0;
            this.btnPast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPast.ForeColor = System.Drawing.Color.White;
            this.btnPast.Image = global::DataEntryApp.Properties.Resources._304505_200;
            this.btnPast.Location = new System.Drawing.Point(1059, 595);
            this.btnPast.Name = "btnPast";
            this.btnPast.Size = new System.Drawing.Size(327, 277);
            this.btnPast.TabIndex = 8;
            this.btnPast.Text = "Pasteurization";
            this.btnPast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPast.UseVisualStyleBackColor = false;
            this.btnPast.Click += new System.EventHandler(this.btnPast_Click);
            // 
            // btnMill
            // 
            this.btnMill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.btnMill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMill.FlatAppearance.BorderSize = 0;
            this.btnMill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMill.ForeColor = System.Drawing.Color.White;
            this.btnMill.Image = global::DataEntryApp.Properties.Resources.bag_wheat_rye_grain_farming_agriculture_flour_5121;
            this.btnMill.Location = new System.Drawing.Point(377, 299);
            this.btnMill.Name = "btnMill";
            this.btnMill.Size = new System.Drawing.Size(327, 277);
            this.btnMill.TabIndex = 7;
            this.btnMill.Text = "Milling";
            this.btnMill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMill.UseVisualStyleBackColor = false;
            this.btnMill.Click += new System.EventHandler(this.btnMill_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.btnCustom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCustom.FlatAppearance.BorderSize = 0;
            this.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustom.ForeColor = System.Drawing.Color.White;
            this.btnCustom.Image = global::DataEntryApp.Properties.Resources.group_vector_customer;
            this.btnCustom.Location = new System.Drawing.Point(1400, 595);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(327, 277);
            this.btnCustom.TabIndex = 5;
            this.btnCustom.Text = "Customer Orders";
            this.btnCustom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustom.UseVisualStyleBackColor = false;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnDist
            // 
            this.btnDist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.btnDist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDist.FlatAppearance.BorderSize = 0;
            this.btnDist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDist.ForeColor = System.Drawing.Color.White;
            this.btnDist.Image = global::DataEntryApp.Properties.Resources._2131342;
            this.btnDist.Location = new System.Drawing.Point(718, 595);
            this.btnDist.Name = "btnDist";
            this.btnDist.Size = new System.Drawing.Size(327, 277);
            this.btnDist.TabIndex = 4;
            this.btnDist.Text = "Distillation";
            this.btnDist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDist.UseVisualStyleBackColor = false;
            this.btnDist.Click += new System.EventHandler(this.btnDist_Click);
            // 
            // btn200L
            // 
            this.btn200L.AutoSize = true;
            this.btn200L.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.btn200L.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn200L.FlatAppearance.BorderSize = 0;
            this.btn200L.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn200L.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn200L.ForeColor = System.Drawing.Color.White;
            this.btn200L.Image = global::DataEntryApp.Properties.Resources.noun_extraction_7540571;
            this.btn200L.Location = new System.Drawing.Point(1400, 299);
            this.btn200L.Name = "btn200L";
            this.btn200L.Size = new System.Drawing.Size(327, 277);
            this.btn200L.TabIndex = 3;
            this.btn200L.Text = "200L";
            this.btn200L.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn200L.UseVisualStyleBackColor = false;
            this.btn200L.Click += new System.EventHandler(this.btn200L_Click);
            // 
            // btn40L
            // 
            this.btn40L.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.btn40L.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn40L.FlatAppearance.BorderSize = 0;
            this.btn40L.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn40L.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn40L.ForeColor = System.Drawing.Color.White;
            this.btn40L.Image = global::DataEntryApp.Properties.Resources.noun_extraction_7540571;
            this.btn40L.Location = new System.Drawing.Point(1059, 299);
            this.btn40L.Name = "btn40L";
            this.btn40L.Size = new System.Drawing.Size(327, 277);
            this.btn40L.TabIndex = 2;
            this.btn40L.Text = "40L";
            this.btn40L.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn40L.UseVisualStyleBackColor = false;
            this.btn40L.Click += new System.EventHandler(this.btn40L_Click);
            // 
            // btnReactor
            // 
            this.btnReactor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.btnReactor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReactor.FlatAppearance.BorderSize = 0;
            this.btnReactor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReactor.ForeColor = System.Drawing.Color.White;
            this.btnReactor.Image = global::DataEntryApp.Properties.Resources.oil_refinery_icon_vector_73237831;
            this.btnReactor.Location = new System.Drawing.Point(377, 595);
            this.btnReactor.Name = "btnReactor";
            this.btnReactor.Size = new System.Drawing.Size(327, 277);
            this.btnReactor.TabIndex = 1;
            this.btnReactor.Text = "Reactor";
            this.btnReactor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReactor.UseVisualStyleBackColor = false;
            this.btnReactor.Click += new System.EventHandler(this.btnReactor_Click);
            // 
            // btnDecarb
            // 
            this.btnDecarb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.btnDecarb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDecarb.FlatAppearance.BorderSize = 0;
            this.btnDecarb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecarb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecarb.ForeColor = System.Drawing.Color.White;
            this.btnDecarb.Image = global::DataEntryApp.Properties.Resources.oven_vector_icon_31;
            this.btnDecarb.Location = new System.Drawing.Point(718, 299);
            this.btnDecarb.Name = "btnDecarb";
            this.btnDecarb.Size = new System.Drawing.Size(327, 277);
            this.btnDecarb.TabIndex = 0;
            this.btnDecarb.Text = "Decarb Oven";
            this.btnDecarb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDecarb.UseVisualStyleBackColor = false;
            this.btnDecarb.Click += new System.EventHandler(this.btnDecarb_Click);
            // 
            // ProcessManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1774, 1029);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPreviousDataWarning);
            this.Controls.Add(this.btnPast);
            this.Controls.Add(this.btnMill);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnDist);
            this.Controls.Add(this.btn200L);
            this.Controls.Add(this.btn40L);
            this.Controls.Add(this.btnReactor);
            this.Controls.Add(this.btnDecarb);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ProcessManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RMES Process Manager";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnDecarb;
        private System.Windows.Forms.Button btnReactor;
        private System.Windows.Forms.Button btn40L;
        private System.Windows.Forms.Button btn200L;
        private System.Windows.Forms.Button btnDist;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnMill;
        private System.Windows.Forms.Button btnPast;
        private System.Windows.Forms.Label lblPreviousDataWarning;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblVersion;
        public System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnPMClose;
    }
}

