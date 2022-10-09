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
    public partial class MillForm : RMESForm
    {

        protected override void SetFormDefaults()
        {
            _csvFileName = "MES MI prod. record.csv";
            _formData = new FormData(this);
            _cmbOperator = cmbOperator;
            _btnBack = btnBack;
            _btnForward = btnForward;
            _btnSubmit = btnSubmit;
            _genericPreviousDataWarning = lblPreviousDataWarning;
            _originalControlBackColor = txtNewLotNum.BackColor;
            _thisJob = jobs.Mill;
            _sidePanel = sidePanel;

            lblVersion.Text = $"RMES MES System \n Version {_version} [beta]";
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;

            PerformGeneralSetup(this);
        }

        public MillForm()
        {
            InitializeComponent();
            SetFormSizeandPosition(this);
            SetFormDefaults();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitData();
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
        private void btnCalcNetWeight_Click(object sender, EventArgs e)
        {
            if (nudRMESWeight.Value > nudPalletWeight.Value)
                nudNetWeight.Value = nudRMESWeight.Value - nudPalletWeight.Value;
            else
                MessageBox.Show("Pallet Weight is larger than RMES Weight.");
        }

        protected override void BuildFormData()
        {
            _formData.ClearAllFormData();
            _formData.AddFormDataGroup(new FormDataGroup(lblOperator, cmbOperator, cmbOperator.SelectedItem.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblLotNum, txtLotNum, txtLotNum.Text));
            _formData.AddFormDataGroup(new FormDataGroup(lblWeightOnBag, nudWeightOnBag, nudWeightOnBag.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblFarm, txtFarm, txtFarm.Text));
            _formData.AddFormDataGroup(new FormDataGroup(lblRMESWeight, nudRMESWeight, nudRMESWeight.Text));
            _formData.AddFormDataGroup(new FormDataGroup(lblPalletWeight, nudPalletWeight, nudPalletWeight.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblNetWeight, nudNetWeight, nudNetWeight.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblDateMilled, dtpDateMilled, dtpDateMilled.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblNewLotNum, txtNewLotNum, txtNewLotNum.Text));
        }

    }
}
