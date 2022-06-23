using heeh.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heeh.UserController
{
    public partial class UCManageMemberAdminNavigation : UserControl
    {
        Helper helper = new Helper();
        String query;

        public void clearAll()
        {
            txtMemberID.Clear();
            txtNamaMember.Clear();
            txtEmailMember.Clear();
            txtHPMember.Clear();
            txtPassword.Clear();
            txtPosition.SelectedIndex = -1;
        }

        public UCManageMemberAdminNavigation()
        {
            InitializeComponent();
        }

        private void UCManageMemberAdminNavigation_Load(object sender, EventArgs e)
        {
            query = "select * from MsEmployee";
            DataSet dataSet = helper.getData(query);
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Member ID";
            dataGridView1.Columns[1].HeaderText = "Nama";
            dataGridView1.Columns[2].HeaderText = "Email";
            dataGridView1.Columns[3].HeaderText = "Password";
            dataGridView1.Columns[4].HeaderText = "No. Handphone";
            dataGridView1.Columns[5].HeaderText = "Jabatan";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNamaMember.Text != "" && txtEmailMember.Text != "" && txtPassword.Text != "" && txtHPMember.Text != "" && txtPosition.Text != "")
            {
                String id = txtMemberID.Text;
                String namaMember = txtNamaMember.Text;
                String emailMember = txtEmailMember.Text;
                String passwordMember = txtPassword.Text;
                String hpMember = txtHPMember.Text;
                String position = txtPosition.Text;

                query = "insert into MsEmployee (id, namaEmployee, email, pass, handphone, position) values ('"+id+"','"+namaMember+"','"+emailMember+"','"+passwordMember+"','"+hpMember+"','"+position+"')";
                helper.setData(query, "Anggota ditambahkan.");
                clearAll();
                UCManageMemberAdminNavigation_Load(this, null);
            }
            else
            {
                MessageBox.Show("Isi semua data!!!","Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UCManageMemberAdminNavigation_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UCManageMemberAdminNavigation_Enter(object sender, EventArgs e)
        {
            UCManageMemberAdminNavigation_Load(this, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtMemberID.Enabled = true;
            String id = txtMemberID.Text;
            String namaMember = txtNamaMember.Text;
            String emailMember = txtEmailMember.Text;
            String passwordMember = txtPassword.Text;
            String hpMember = txtHPMember.Text;
            String position = txtPosition.Text;
            query = "update MsEmployee set namaEmployee='"+namaMember+ "', email='" + emailMember + "', pass='" + passwordMember + "', handphone='" + hpMember + "', position='" + position + "' where id='" + id + "'";
            helper.setData(query, "Berhasil memperbarui data Employee.");
            clearAll();
            UCManageMemberAdminNavigation_Load(this, null);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String search = txtSearch.Text;
            query = "select * from MsEmployee where namaEmployee like '" + search + "%' or email like '" + search + "%' or handphone like '" + search + "%' or position like '" + search + "%'";
            DataSet dataSet = helper.getData(query);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String search = txtSearch.Text;
            query = "select * from MsEmployee where namaEmployee like '" + search + "%' or email like '" + search + "%' or handphone like '" + search + "%' or position like '" + search + "%'";
            DataSet dataSet = helper.getData(query);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            txtMemberID.Enabled = false;
            if (e.RowIndex != -1)
            {
                txtMemberID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNamaMember.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtEmailMember.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtHPMember.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPosition.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtMemberID.Enabled = true;
            String id = txtMemberID.Text;
            if(MessageBox.Show("Data Employee akan dihapus, data yang telah dihapus tidak dapat dikembalikan. Lanjutkan?", "Konfirmasi?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                query = "delete from MsEmployee where id='" + id + "'";
                helper.setData(query, "Berhasil menghapus Employee.");
                clearAll();
                UCManageMemberAdminNavigation_Load(this, null);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMemberID.Enabled = true;
            clearAll();
        }
    }
}
