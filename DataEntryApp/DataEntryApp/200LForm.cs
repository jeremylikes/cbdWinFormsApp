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
    public partial class _200LForm : RMESForm
    {
        string dt = DateTime.Now.ToShortTimeString();

        public List<Control> _startControls = new List<Control>();
        public List<Control> _endControls = new List<Control>();
        protected string FieldsThatAreEmpty(List<Control> controls)
        {
            string fields = "";
            foreach (Control control in controls)
            {

                if (string.IsNullOrWhiteSpace(control.Text) && !(control is Label) && !(control is Panel) && !(control.Name.Contains("Comment")))
                {
                    fields += control.Name.Substring(3) + " is empty \n";
                }

                if (control is NumericUpDown)
                {
                    NumericUpDown nud = control as NumericUpDown;
                    if (nud.Value == 0)
                    {
                        fields += nud.Name.Substring(3) + " is set to 0 \n";
                    }
                }
                if (control is Panel)
                {
                    foreach (Control control2 in control.Controls)
                    {
                        if (control2 is TextBox)
                        {
                            TextBox textbox = control2 as TextBox;
                            if (string.IsNullOrWhiteSpace(textbox.Text) && !(textbox.Name.Contains("Comment")))
                            {
                                fields += textbox.Name.Substring(3) + " is empty \n";

                            }
                        }
                        if (control2 is NumericUpDown)
                        {
                            NumericUpDown nud = control2 as NumericUpDown;
                            if (nud.Value == 0)
                            {
                                fields += nud.Name.Substring(3) + " is set to 0 \n";
                            }
                        }
                    }
                }
            }
            return fields;
        }
        protected bool AreFieldsEmpty(List<Control> controls)
        {
            int count = 0;
            bool validData = false;
            foreach (Control control in controls)
            {
                if (string.IsNullOrWhiteSpace(control.Text) && !(control is Label) && !(control is Panel) && !(control.Name.Contains("Comment")))
                {
                    count++;
                }

                if (control is NumericUpDown)
                {
                    NumericUpDown nud = control as NumericUpDown;
                    if (nud.Value == 0)
                    {
                        count++;
                    }
                }
                if (control is Panel)
                {
                    foreach (Control control2 in control.Controls)
                    {
                        if (control2 is TextBox)
                        {
                            TextBox textbox = control2 as TextBox;
                            if (string.IsNullOrWhiteSpace(textbox.Text) && !(textbox.Name.Contains("Comment")))
                            {
                                count++;
                            }
                        }
                        if (control2 is NumericUpDown)
                        {
                            NumericUpDown nud = control2 as NumericUpDown;
                            if (nud.Value == 0)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            if (count > 0)
            {
                validData = true;
            }
            else
                validData = false;
            return validData;
        }
        void MapStartControls()
        {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox || c is NumericUpDown || c is ComboBox || c is DateTimePicker)
                        _startControls.Add(c);
                    if (c is Panel && !(c.Name == "EndPanel"))
                    {
                        foreach (Control c2 in c.Controls)
                        {
                            if (c2 is TextBox || c2 is NumericUpDown || c2 is ComboBox)
                                _startControls.Add(c2);
                        }
                    }
                }
        }
        void MapEndControls()
        {
            foreach (Control c in EndPanel.Controls)
            {
                if (c is TextBox || c is NumericUpDown || c is DateTimePicker)
                    _endControls.Add(c);
            }
            _endControls.Add(txtComment);
        }
        void StartRun()
        {
            if (AreFieldsEmpty(_startControls) == false)
            {
                foreach (Control c in _startControls)
                {
                    c.Enabled = false;
                }
                foreach (Control c in _endControls)
                {
                    c.Enabled = true;
                }
                MessageBox.Show("Run Started");
                btnStartRun.Enabled = false;
                btnEndRun.Enabled = true;

            }
            else
                MessageBox.Show(FieldsThatAreEmpty(_startControls));
            

        }
        void EndRun()
        {
            if (AreFieldsEmpty(_endControls) == false)
            {
                foreach (Control c in _endControls)
                {
                    c.Enabled = false;
                }
                foreach (Control c in _startControls)
                {
                    c.Enabled = true;
                }
                SubmitData();
            }
            else
                MessageBox.Show(FieldsThatAreEmpty(_endControls));
        }
        
        protected override void SetFormDefaults()
        {
            _csvFileName = "MES 200L prod. record.csv";
            _formData = new FormData(this);
            _cmbOperator = cmbOperator;
            _btnBack = btnBack;
            _btnForward = btnForward;
            _genericPreviousDataWarning = lblPreviousDataWarning;
            _originalControlBackColor = txtBagNumber.BackColor;
            _thisJob = jobs.L200;
            _btnSubmit = btnStartRun;
            _sidePanel = sidePanel;

            lblVersion.Text = $"RMES MES System \n Version {_version} [beta]";
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;
            dtpDate.Value = DateTime.Now;
            dtpStart.Value = DateTime.Now;
            cmbSolvent.Items.Add("1"); cmbSolvent.Items.Add("2");
            cmbExpansion.Items.Add("1"); cmbExpansion.Items.Add("2");
            cmbSolvent.SelectedIndex = 0;
            cmbExpansion.SelectedIndex = 0;
            txtComment.Text = "";


            MapStartControls();
            MapEndControls();

            foreach (Control c in _endControls)
            {
                c.Enabled = false;
            }
            btnEndRun.Enabled = false;

            PerformGeneralSetup(this);


        }

        protected override void BuildFormData()
        {
            _formData.DeleteAllFormData();
            _formData.AddFormDataGroup(new FormDataGroup(lblWorkOrder, txtWorkOrder, txtWorkOrder.Text));
            _formData.AddFormDataGroup(new FormDataGroup(lblOperator, cmbOperator, cmbOperator.SelectedItem.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblDate, dtpDate, dtpDate.Value.ToShortDateString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblStart, dtpStart, dtpStart.Value.ToShortTimeString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblFarm, txtFarm, txtFarm.Text));
            _formData.AddFormDataGroup(new FormDataGroup(lblBagNumber, txtBagNumber, txtBagNumber.Text));
            _formData.AddFormDataGroup(new FormDataGroup(lblSolventPressure, nudSolventPressure, nudSolventPressure.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblSolventTemp, nudSolventTemp, nudSolventTemp.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblExpPressure, nudExpPressure, nudExpPressure.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblExpTemp, nudExpTemp, nudExpTemp.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblOriStart, nudOriStart, nudOriStart.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblSolvent, cmbSolvent, cmbSolvent.SelectedItem.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblRuntime, nudRuntime, nudRuntime.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblBioWeight, nudBioWeight, nudBioWeight.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblOriFinish, nudOriFinish, nudOriFinish.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblExtWeight, nudExtWeight, nudExtWeight.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblEndTime, dtpEndTime, dtpEndTime.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblComment, txtComment, txtComment.Text));

        }
        public _200LForm()
        {
            InitializeComponent();
            SetFormSizeandPosition(this);
            SetFormDefaults();
        }

        #region GUIEvents

        private void btnForward_Click(object sender, EventArgs e)
        {
            ToNextMostRecentEntry();
            if (_formData._currentPage == -1)
            {
                foreach (Control c in _endControls)
                {
                    c.Enabled = false;
                }
                btnStartRun.Enabled = true;
                btnEndRun.Enabled = false;
                btnEndRun.Text = "End Run";
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ToNextOlderEntry();
            foreach (Control c in _startControls)
            {
                c.Enabled = Enabled;
            }
            foreach (Control c in _endControls)
            {
                c.Enabled = Enabled;
            }
            btnStartRun.Enabled = false;
            btnEndRun.Enabled = true;
            btnEndRun.Text = "Submit";
        }

        private void btnStartRun_Click(object sender, EventArgs e)
        {
            StartRun();
        }

        private void btnEndRun_Click(object sender, EventArgs e)
        {
            EndRun();
           
            if (_formData._currentPage >= 0)
            {
                foreach(Control c in _endControls)
                {
                    c.Enabled = true;
                }
            }
            btnEndRun.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Form Management

        #endregion

        #region Data Manipulation


        #endregion
    }
}
