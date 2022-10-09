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
    public partial class ReactorForm : RMESForm
    {

        #region Initialization
        
        public ReactorForm()
        {
            InitializeComponent();
            SetFormSizeandPosition(this);
            SetFormDefaults();
        }

        protected override void SetFormDefaults()
        {
            // Set globals : Unique to THIS form
            _btnBack = btnBack;
            _btnForward = btnForward;
            _btnSubmit = btnSubmit;
            _txtExtractionWorkOrder = txtExtractionWorkOrder;
            _btnNextWorkOrder = btnNextWO;
            _genericPreviousDataWarning = lblPreviousDataWarning;
            _originalControlBackColor = txtWorkOrder.BackColor;
            _formData = new FormData(this);
            _thisJob = jobs.Reactor;
            _cmbOperator = cmbOperator;
            _sidePanel = sidePanel;
            lblVersion.Text = $"RMES MES System \n Version {_version} [beta]";
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;
            _csvFileName = "MES DC.35 prod. record.csv";

            // General setup for any form
            PerformGeneralSetup(this);

            //Override defaults with custom values if you like
            
        }

        protected override void BuildFormData()
        {
            _formData.DeleteAllFormData();
            _formData.AddFormDataGroup(new FormDataGroup(lblWorkOrder, txtWorkOrder, txtWorkOrder.Text));
            _formData.AddFormDataGroup(new FormDataGroup(lblOperator, cmbOperator, cmbOperator.SelectedItem.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblDate, pickerDate, pickerDate.Value.ToShortDateString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblStartTime, pickerStartTime, pickerStartTime.Value.ToShortTimeString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblExtractionWO, txtExtractionWorkOrder, txtExtractionWorkOrder.Text));
            _formData.AddFormDataGroup(new FormDataGroup(lblExtractionMass, numExtractionMass, numExtractionMass.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblTerpenes, numTerpSetPoint, numTerpSetPoint.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblTerpenesRunDur, numTerpRunDir, numTerpRunDir.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblDecarbTemp, numDecarbTempSetPoint, numDecarbTempSetPoint.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblDecarbRunDur, numDecarbTempSetRunDur, numDecarbTempSetRunDur.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblVolatileMass, numVolatileMass, numVolatileMass.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblDecarbedOil, numDecarbedOil, numDecarbedOil.Value.ToString()));
        }

        #endregion

        #region Button Events


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitData();
        }
        private void btnNextWO_Click(object sender, EventArgs e)
        {
            AddExtraWorkOrderTextBoxes(txtExtractionWorkOrder, btnNextWO);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ToNextOlderEntry();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            ToNextMostRecentEntry();
        }

        #endregion

        #region Form Manipulation

        #endregion

        #region Data Manipulation

        #endregion

    }
}
