using ProjectFieldsManager.Forms;
using ProjectFieldsManager.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFieldsManager
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void rbOnline_CheckedChanged(object sender, EventArgs e)
        {
            lDomain.Visible = false;
            tbDomain.Visible = false;
        }

        private void rbOnPremise_CheckedChanged(object sender, EventArgs e)
        {
            lDomain.Visible = true;
            tbDomain.Visible = true;
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                PSContext.IsOnline = rbOnline.Checked;
                PSContext.PSUrl = tbUrl.Text;
                PSContext.UserName = tbUsername.Text;
                PSContext.Password = tbPass.Text;
                PSContext.Domain = tbDomain.Text;

                using (var ctx = new PSContext())
                {
                    this.Hide();
                    ExportImportForm form = new ExportImportForm();
                    form.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
