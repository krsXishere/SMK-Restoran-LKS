using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using heeh.models;

namespace heeh
{
    public partial class FormLogin : Form
    {
        Helper helper = new Helper();
        public static string position;
        public static string passing;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminNavigation fan = new FormAdminNavigation();
            FormCashierNavigation fcn = new FormCashierNavigation();
            String email = txtEmail.Text;
            String password = txtPassword.Text;

            invalidEmailPassword.Visible = false;

            if (txtEmail.Text != "" && txtPassword.Text != "")
            {
                DataTable dataTable = helper.Login(email, password);
                Console.WriteLine(dataTable.Rows.Count);
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        Console.WriteLine(item);
                    }
                }
                if (dataTable.Rows.Count == 1)
                {
                    String nma;
                    
                    position = dataTable.Rows[0][0].ToString();
                    nma = dataTable.Rows[0][1].ToString();
                    Console.WriteLine("Cek : " + nma);
                    passing = nma;
                    if (position == "admin")
                    {
                        this.Hide();
                        fan.Show();
                        MessageBox.Show("Berhasil Log-in sebagai "+position+" "+nma+"", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        this.Hide();
                        fcn.Show();
                        MessageBox.Show("Berhasil Log-in sebagai " + position + " " + nma + "", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    clearAll();
                    MessageBox.Show("Email atau password salah!!!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    invalidEmailPassword.Visible = true;
                }
                clearAll();
            }
            else
            {
                MessageBox.Show("Isi semua data!!!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Clear();
                txtPassword.Clear();
            }
        }
    }
}
