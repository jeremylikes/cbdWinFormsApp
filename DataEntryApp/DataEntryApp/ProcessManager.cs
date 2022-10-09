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

    public partial class ProcessManager : Form
    {
        public string _version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        public ProcessManager() 
        {
            InitializeComponent();
            lblVersion.Text = $"RMES MES System \n Version {_version} [beta]";
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;
        }

        #region Form Navigation

        private void btnPMClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDecarb_Click(object sender, EventArgs e)
        {
            DecarbForm decarb = new DecarbForm();
            decarb.ShowDialog();
        }

        private void btnReactor_Click(object sender, EventArgs e)
        {
            ReactorForm reactor = new ReactorForm();
            reactor.ShowDialog();
        }

        private void btn40L_Click(object sender, EventArgs e)
        {
            _40LForm fortyL = new _40LForm();
            fortyL.ShowDialog();
        }

        private void btn200L_Click(object sender, EventArgs e)
        {
            _200LForm twoL = new _200LForm();
            twoL.ShowDialog();
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            CustomerWOForm customerWOForm = new CustomerWOForm();
            customerWOForm.ShowDialog();
        }

        private void btnDist_Click(object sender, EventArgs e)
        {
            DistillationForm distillationForm = new DistillationForm();
            distillationForm.ShowDialog();
        }

        private void btnMill_Click(object sender, EventArgs e)
        {
            MillForm mill = new MillForm();
            mill.ShowDialog();
        }

        private void btnPast_Click(object sender, EventArgs e)
        {
            PastForm past = new PastForm();
            past.ShowDialog();
        }

        #endregion

    }

}
