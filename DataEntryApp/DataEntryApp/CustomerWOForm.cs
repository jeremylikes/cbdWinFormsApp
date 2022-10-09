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
    public partial class CustomerWOForm : RMESForm
    {

        #region Global Values
        string AddZeroes(string str)
        {
            for (int i = 0; i < 5 - str.Length; i++)
            {
                str.Insert(0, "0");
            }
            return str;
        }
        #endregion
        public CustomerWOForm()
        {
            InitializeComponent();
            SetFormSizeandPosition(this);
            SetFormDefaults();
        }

        protected override void SetFormDefaults()
        {
            _csvFileName = "MES CO prod. record.csv";
            _formData = new FormData(this);
            _cmbOperator = cmbOperator;
            _btnBack = btnBack;
            _btnForward = btnForward;
            _btnSubmit = btnSubmit;
            _genericPreviousDataWarning = lblPreviousDataWarning;
            _txtExtractionWorkOrder = txtInputMaterialWO;
            _btnNextWorkOrder = btnNextWO;
            _sidePanel = sidePanel;
            
            _originalControlBackColor = txtComment.BackColor;
            _thisJob = jobs.CustomerOrders;
            lblVersion.Text = $"RMES MES System \n Version {_version} [beta]";
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;

            PerformGeneralSetup(this);

            txtWorkOrder.Text = "CO.TF-";
        }

        #region GUIEvents

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitData();
        }

        private void btnNextWO_Click(object sender, EventArgs e)
        {
            AddExtraWorkOrderTextBoxes(_txtExtractionWorkOrder, _btnNextWorkOrder);
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

        #endregion

        #region DataManipulation
        protected override void BuildFormData()
        {
            string dt = DateTime.Now.ToShortTimeString();
            _formData.DeleteAllFormData();
            _formData.AddFormDataGroup(new FormDataGroup(lblWorkOrder, txtWorkOrder, txtWorkOrder.Text));
            _formData.AddFormDataGroup(new FormDataGroup(lblCustomer, txtCustomer, txtCustomer.Text));
            _formData.AddFormDataGroup(new FormDataGroup(lblOperator, cmbOperator, cmbOperator.SelectedItem.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblDate, dtpDate, dtpDate.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblStartDate, dtpStartDate, dtpStartDate.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblInputMaterialWO, txtInputMaterialWO, txtInputMaterialWO.Text));
            _formData.AddFormDataGroup(new FormDataGroup(lblInputMass, nudInputMass, nudInputMass.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblOutputMass, nudOutputMass, nudOutputMass.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblEndDate, dtpEndDate, dtpEndDate.Value.ToString()));
            _formData.AddFormDataGroup(new FormDataGroup(lblFinalProd, txtFinalProd, txtFinalProd.Text));
            _formData.AddFormDataGroup(new FormDataGroup(lblComment, txtComment, txtComment.Text));
            
        }

        #endregion
    }
}
