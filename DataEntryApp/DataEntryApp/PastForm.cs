using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DataEntryApp
{
    public partial class PastForm : RMESForm
    {

        protected override void SetFormDefaults()
        {
            _csvFileName = "MES PO prod. record.csv";
            _formData = new FormData(this);
            _cmbOperator = cmbOperator;
            _btnBack = btnBack;
            _btnForward = btnForward;
            _btnSubmit = btnSubmit;
            _genericPreviousDataWarning = lblPreviousDataWarning;
            _originalControlBackColor = txtContainerNum.BackColor;
            _thisJob = jobs.Pasteur;
            _sidePanel = sidePanel;

            lblVersion.Text = $"RMES MES System \n Version {_version} [beta]";
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;

            PerformGeneralSetup(this);
        }

        public PastForm()
        {
            InitializeComponent();
            SetFormSizeandPosition(this);
            SetFormDefaults();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitData();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            ToNextMostRecentEntry();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ToNextOlderEntry();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        protected override void BuildFormData()
        {
            _formData.ClearAllFormData();
            _formData.AddFormDataGroup(new FormDataGroup(lblTimeIn, dtpTimeIn, dtpTimeIn.Value.ToShortTimeString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblDate, dtpDate, dtpDate.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblContainerNum, txtContainerNum, txtContainerNum.Text));
            _formData.AddFormDataGroup(new FormDataGroup(lblOperator, cmbOperator, cmbOperator.SelectedItem.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblTemp, nudTemp, nudTemp.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblTimeOut, dtpTimeOut, dtpTimeOut.Value.ToShortTimeString()));
        }
    }
}
