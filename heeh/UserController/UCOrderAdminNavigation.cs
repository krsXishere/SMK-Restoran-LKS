using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using heeh.models;

namespace heeh.UserController
{
    public partial class UCOrderAdminNavigation : UserControl
    {
        Helper helper = new Helper();
        String query;
        String query2;
        String menuId;
        String orderId;

        public UCOrderAdminNavigation()
        {
            InitializeComponent();
        }

        private void UCOrderAdminNavigation_Load(object sender, EventArgs e)
        {
            query = "select * from MsMenu";
            DataSet dataSet = helper.getData(query);
            dataGridViewMenu.DataSource = dataSet.Tables[0];

            query2 = "select MsMenu.namaMenu, OrderDetail.jumlah, MsMenu.karbohidrat, MsMenu.protein, MsMenu.harga from MsMenu inner join OrderDetail on MsMenu.id = OrderDetail.id where OrderDetail.statusOrder='dipesan'";
            DataSet dataSet2 = helper.getData(query2);
            DataTable dataTable = dataSet2.Tables[0];
            dataGridViewOrderDetail.DataSource = dataSet2.Tables[0];

            //foreach(DataRow row in dataTable.Rows)
            //{
              //  row["totalHarga"] = Int64.Parse(row["jumlah"].ToString()) * Int64.Parse(row["harga"].ToString());
            //}
        }

        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                txtNamaMenu.Text = dataGridViewMenu.Rows[e.RowIndex].Cells[1].Value.ToString();
                pictureBox1.ImageLocation = dataGridViewMenu.Rows[e.RowIndex].Cells[3].Value.ToString();
                //menuId = dataGridViewMenu.
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            UCOrderAdminNavigation_Load(this, null);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from MsMenu where namaMenu like '"+textBox1.Text+"%'";
            DataSet dataSet = helper.getData(query);
            dataGridViewMenu.DataSource = dataSet.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            query = "select * from MsMenu where namaMenu like '" + textBox1.Text + "%'";
            DataSet dataSet = helper.getData(query);
            dataGridViewMenu.DataSource = dataSet.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String jumlah = txtJumlah.Text;
            query = "insert into OrderDetail (menuId, orderId, jumlah, statusOrder) values('"+jumlah+"', 'dipesan')";
            helper.setData(query, "Pesanan berhasil diproses.");
            UCOrderAdminNavigation_Load(this, null);
        }
    }
}
