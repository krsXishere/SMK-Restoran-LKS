using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heeh
{
    public partial class FormAdminNavigation : Form
    {
        public FormAdminNavigation()
        {
            InitializeComponent();
        }

        private void FormAdminNavigation_Load(object sender, EventArgs e)
        {
            ucOrderAdminNavigation1.Visible = true;
            adminName.Text = FormLogin.passing;
            position.Text = FormLogin.position;
            nameAdmin.Text = FormLogin.passing;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucOrderAdminNavigation1.Visible = true;
            ucOrderAdminNavigation1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucManageMenuAdminNavigation1.Visible = true;
            ucManageMenuAdminNavigation1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            if(MessageBox.Show("Anda akan log-out?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                fl.Show();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucManageMemberAdminNavigation1.Visible = true;
            ucManageMemberAdminNavigation1.BringToFront();
        }
    }
}
