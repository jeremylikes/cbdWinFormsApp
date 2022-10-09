using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataEntryApp
{
    public partial class DecarbForm : RMESForm
    {
        #region Global Values
        Button currentButton = new Button();
        Color leftPanelColor = Color.FromArgb(200, 244, 64);
        Color decarbOriginColor = Color.FromArgb(10, 50, 0);
        Panel leftBorderPanel = new Panel();
        private string currentOven = "1";

        private void ActivateButton(Object senderBtn, Color customColor)
        {
            //Disable Current Button
            DisableButton(decarbOriginColor);
            
            //Button
            currentButton = senderBtn as Button;
            currentOven = currentButton.Name.Substring(currentButton.Name.Length - 1);
            currentButton.ForeColor = customColor;
            currentButton.BackColor = Color.FromArgb(20, 50, 10);
            currentButton.TextAlign = ContentAlignment.MiddleCenter;
            currentButton.ImageAlign = ContentAlignment.MiddleRight;
            currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            lblTitle.Text = "Decarb Oven " + currentOven;
            
            //Left Border
            leftBorderPanel.Size = new Size(5, currentButton.Height);
            leftBorderPanel.BackColor = customColor;
            leftBorderPanel.Location = new Point(0, currentButton.Location.Y);
            this.Controls.Add(leftBorderPanel);
            leftBorderPanel.Visible = true;
            leftBorderPanel.BringToFront();
           
            //Change file name to match button
            _csvFileName = "MES DO" + currentOven + " prod. record.csv";
            
            //Activate editable controls
            foreach (Control c in _editableControls)
            {
                if (c is TextBox || c is ComboBox || c is NumericUpDown || c is DateTimePicker)
                    c.Enabled = true;
                if (c is Panel)
                {
                    foreach (Control c2 in c.Controls)
                    {
                        if (c2 is TextBox || c2 is ComboBox || c2 is NumericUpDown)
                        {
                            c2.Enabled = true;
                        }
                    }
                }
            }

            foreach (Control c in _dataWarningControls)
            {
                if (c is TextBox || c is ComboBox || c is NumericUpDown || c is DateTimePicker)
                    ToggleControlWarningColor(false, c);
                if (c is Panel)
                {
                    foreach (Control c2 in c.Controls)
                    {
                        if (c2 is TextBox || c2 is ComboBox || c2 is NumericUpDown)
                        {
                            ToggleControlWarningColor(false, c2);
                        }
                    }
                }
            }

            TogglePreviousDataWarning(false, lblPreviousDataWarning);
            btnSubmit.Enabled = true;
            btnBack.Visible = true;
        }

        public void DisableButton(Color customColor)
        {
            //Button
            currentButton.ForeColor = Color.White;
            currentButton.BackColor = customColor;
            currentButton.TextAlign = ContentAlignment.MiddleRight;
            currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            
            //Left Border
            leftBorderPanel.Visible = false;
        }
        #endregion

        public DecarbForm()
        {
            InitializeComponent();
            SetFormSizeandPosition(this);
            SetFormDefaults();
            foreach (Control c in _editableControls)
            {
                if (c is TextBox || c is ComboBox || c is NumericUpDown || c is DateTimePicker)
                    c.Enabled = false;
                if (c is Panel)
                {
                    foreach (Control c2 in c.Controls)
                    {
                        if (c2 is TextBox || c2 is ComboBox || c2 is NumericUpDown)
                        {
                            c2.Enabled = false;
                        }
                    }
                }
            }
            btnBack.Visible = false;
            btnSubmit.Enabled = false;
        }

        #region GUIEvents
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitData();
            btnSubmit.Enabled = false;
            nudRunNumber.Value++;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            ToNextOlderEntry();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            ToNextMostRecentEntry();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOven1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, _warningColor);
            SetFormDefaults();
        }

        private void btnOven2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, _warningColor);
            SetFormDefaults();
        }
        #endregion

        #region Form Management

        protected override void SetFormDefaults()
        {
            _csvFileName = "MES DO" + currentOven + " prod. record.csv";
            _formData = new FormData(this);
            _cmbOperator = cmbOperator;
            _btnBack = btnBack;
            _btnForward = btnForward;
            _btnSubmit = btnSubmit;
            _genericPreviousDataWarning = lblPreviousDataWarning;
            _originalControlBackColor = txtBagNumber.BackColor;
            _thisJob = jobs.Decarb;
            _sidePanel = sidePanel;

            lblVersion.Text = $"RMES MES System \n Version {_version} [beta]";
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;
            cmbOrgNorg.Items.Add("Org");
            cmbOrgNorg.Items.Add("Non-Org");
            cmbOrgNorg.SelectedIndex = 0;
            nudWeightPerPan.Value = 1.6m;
            nudTemp.Value = 280;       

            PerformGeneralSetup(this);
        }

        protected override void BuildFormData()
        {
            _formData.AddFormDataGroup(new FormDataGroup(lblRunNumber, nudRunNumber, nudRunNumber.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblOperator, cmbOperator, cmbOperator.SelectedItem.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblDate, dtpDate, dtpDate.Value.ToShortDateString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblStart, dtpStart, dtpStart.Value.ToShortTimeString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblBagNumber, txtBagNumber, txtBagNumber.Text));
            _formData.AddFormDataGroup(new FormDataGroup(lblFarm, txtFarm, txtFarm.Text));
            _formData.AddFormDataGroup(new FormDataGroup(lblOrgNorg, cmbOrgNorg, cmbOrgNorg.SelectedItem.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblShelves, nudShelves, nudShelves.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblWeightPerPan, nudWeightPerPan, nudWeightPerPan.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblTemp, nudTemp, nudTemp.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblRuntime, nudRuntime, nudRuntime.Value.ToString()));
        }
        #endregion

    }
}
