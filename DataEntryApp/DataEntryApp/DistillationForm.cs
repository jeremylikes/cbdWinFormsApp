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
    public partial class DistillationForm : RMESForm
    {
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
            _endControls.Add(dtpEndTime);
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
                btnStart.Enabled = false;
                btnEnd.Enabled = true;

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

            _csvFileName = "MES DS.20 prod. record.csv";
            _formData = new FormData(this);
            _txtExtractionWorkOrder = txtInputMaterialWO;
            _btnNextWorkOrder = btnNextWO;
            _cmbOperator = cmbOperator;
            _btnBack = btnBack;
            _btnForward = btnForward;
            _btnSubmit = btnStart;
            _genericPreviousDataWarning = lblPreviousDataWarning;
            _originalControlBackColor = txtComment.BackColor;
            _thisJob = jobs.Distillation;
            _sidePanel = sidePanel;

            lblVersion.Text = $"RMES MES System \n Version {_version} [beta]";
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;

            MapStartControls();
            MapEndControls();

            PerformGeneralSetup(this);

            foreach (Control c in _endControls)
            {
                c.Enabled = false;
            }
        }

        public DistillationForm()
        {
            InitializeComponent();
            SetFormSizeandPosition(this);
            SetFormDefaults();
            btnEnd.Enabled = false;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            ToNextMostRecentEntry();
            if (_formData._currentPage == -1)
            {
                foreach (Control c in _endControls)
                {
                    c.Enabled = false;
                }
                btnStart.Enabled = true;
                btnEnd.Enabled = false;
                btnEnd.Text = "End Run";
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
            btnStart.Enabled = false;
            btnEnd.Enabled = true;
            btnEnd.Text = "Submit";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNextWO_Click(object sender, EventArgs e)
        {
            AddExtraWorkOrderTextBoxes(txtInputMaterialWO, btnNextWO, "");
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            EndRun();
            if (_formData._currentPage >= 0)
            {
                foreach (Control c in _endControls)
                {
                    c.Enabled = true;
                }
            }
            btnEnd.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartRun();
        }

        protected override void BuildFormData()
        {
            _formData.ClearAllFormData();
            _formData.AddFormDataGroup(new FormDataGroup(lblWorkOrder, txtWorkOrder, txtWorkOrder.Text));
            _formData.AddFormDataGroup(new FormDataGroup(lblOperator, cmbOperator, cmbOperator.SelectedItem.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblDate, dtpDate, dtpDate.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblStart, dtpStartTime, dtpStartTime.Value.ToShortTimeString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblInputMaterialWO, txtInputMaterialWO, txtInputMaterialWO.Text));
            _formData.AddFormDataGroup(new FormDataGroup(lblInputWeight, nudInputWeight, nudInputWeight.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblTempProf, txtTempProfile, txtTempProfile.Text));
            _formData.AddFormDataGroup(new FormDataGroup(lblRunTime, nudWasteWeight, nudWasteWeight.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblDistWaste, nudDistillateWeight, nudDistillateWeight.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblDistWeight, nudRunTime, nudRunTime.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblEndTime, dtpEndTime, dtpEndTime.Value.ToShortTimeString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblComment, txtComment, txtComment.Text));
        }
    }
}
