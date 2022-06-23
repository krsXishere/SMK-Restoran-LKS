using heeh.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace heeh.UserController
{
    public partial class UCManageMenuAdminNavigation : UserControl
    {
        Helper helper = new Helper();
        String imageLocation;
        String query;
        public UCManageMenuAdminNavigation()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            txtMenuID.Clear();
            txtNamaMenu.Clear();
            txtHarga.Clear();
            txtFilename.Clear();
            txtKarbohidrat.Clear();
            txtProtein.Clear();
            pictureBox.ImageLocation = null;
        }

        private void UCManageMenuAdminNavigation_Load(object sender, EventArgs e)
        {
            query = "select * from MsMenu";
            DataSet dataSet = helper.getData(query);
            dataGridView1.DataSource = dataSet.Tables[0]; ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg;)|*.jpg;*.jpeg;", Multiselect = false })
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = openFileDialog.FileName;
                    txtFilename.Text = openFileDialog.FileName;
                    pictureBox.ImageLocation = imageLocation;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtNamaMenu.Text != "" && txtHarga.Text != "" && txtFilename.Text != "" && txtKarbohidrat.Text != "" && txtProtein.Text != "")
            {
                String nama = txtNamaMenu.Text;
                String harga = txtHarga.Text;
                String karbohidrat = txtKarbohidrat.Text;
                String protein = txtProtein.Text;

                if (MessageBox.Show("Tambahkan menu makanan?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    query = "insert into MsMenu (namaMenu, harga, foto, karbohidrat, protein) values('" + nama + "','" + harga + "','" + imageLocation + "','" + karbohidrat + "','" + protein + "')";
                    helper.setData(query, "Berhasil menambahkan menu.");
                    clearAll();
                    UCManageMenuAdminNavigation_Load(this, null);
                }
                else
                {
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Isi semua data!!!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtFilename.Enabled = true;
            String id = txtMenuID.Text;
            if(MessageBox.Show("Data Menu akan dihapus, data yang telah dihapus tidak dapat dikembalikan. Lanjutkan?", "Konfirmasi?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                query = "delete from MsMenu where id='"+id+"'";
                helper.setData(query, "Menu berhasil dihapus.");
                txtFilename.Enabled = false;
                clearAll();
                UCManageMenuAdminNavigation_Load(this, null);
            }
            else
            {
                clearAll();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFilename.Enabled = true;
            if (e.RowIndex != -1)
            {
                txtMenuID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNamaMenu.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHarga.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtFilename.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtKarbohidrat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtProtein.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                pictureBox.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(txtHarga.Text, "[^0-9]"))
            {
                MessageBox.Show("Data harga harus diisi dengan nomor!!!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHarga.Text = txtHarga.Text.Remove(txtHarga.Text.Length - 1);
            }
        }

        private void txtKarbohidrat_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(txtKarbohidrat.Text, "[^0-9]"))
            {
                MessageBox.Show("Data karbohidrat harus diisi dengan nomor!!!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKarbohidrat.Text = txtKarbohidrat.Text.Remove(txtKarbohidrat.Text.Length - 1);
            }
        }

        private void txtProtein_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtProtein.Text, "[^0-9]"))
            {
                MessageBox.Show("Data Proteing harus diisi dengan nomor!!!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProtein.Text = txtProtein.Text.Remove(txtProtein.Text.Length - 1);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clearAll();
            txtFilename.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtFilename.Enabled = true;
            if (txtNamaMenu.Text != "" && txtHarga.Text != "" && txtFilename.Text != "" && txtKarbohidrat.Text != "" && txtProtein.Text != "")
            {
                String id = txtMenuID.Text;
                String nama = txtNamaMenu.Text;
                String harga = txtHarga.Text;
                String karbohidrat = txtKarbohidrat.Text;
                String protein = txtProtein.Text;

                if (MessageBox.Show("Simpan perubahan data?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    query = "update MsMenu set namaMenu='" + nama + "', harga='" + harga + "', foto='"+imageLocation+"', karbohidrat='" + karbohidrat + "', protein='" + protein + "' where id='" + id + "'";
                    helper.setData(query, "Menu berhasil diperbarui.");
                    txtFilename.Enabled = false;
                    clearAll();
                    UCManageMenuAdminNavigation_Load(this, null);
                }
                else
                {
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Isi semua data!!!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clearAll();
            txtFilename.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from MsMenu where namaMenu like '"+textBox1.Text+"%' or harga like '"+textBox1.Text+"%' or karbohidrat like '"+textBox1.Text+"%' or protein like '"+textBox1.Text+"%'";
            DataSet dataSet = helper.getData(query);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
