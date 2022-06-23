namespace heeh.UserController
{
    partial class UCOrderAdminNavigation
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.menuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karbohidrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewOrderDetail = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.txtNamaMenu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karbohidrat1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protein1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetail)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Order";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewMenu);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 370);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuID,
            this.namaMenu,
            this.harga,
            this.foto,
            this.karbohidrat,
            this.protein});
            this.dataGridViewMenu.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersWidth = 62;
            this.dataGridViewMenu.RowTemplate.Height = 28;
            this.dataGridViewMenu.Size = new System.Drawing.Size(849, 369);
            this.dataGridViewMenu.TabIndex = 0;
            this.dataGridViewMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellClick);
            // 
            // menuID
            // 
            this.menuID.DataPropertyName = "id";
            this.menuID.HeaderText = "Menu ID";
            this.menuID.MinimumWidth = 8;
            this.menuID.Name = "menuID";
            this.menuID.Width = 150;
            // 
            // namaMenu
            // 
            this.namaMenu.DataPropertyName = "namaMenu";
            this.namaMenu.HeaderText = "Nama Menu";
            this.namaMenu.MinimumWidth = 8;
            this.namaMenu.Name = "namaMenu";
            this.namaMenu.Width = 150;
            // 
            // harga
            // 
            this.harga.DataPropertyName = "harga";
            this.harga.HeaderText = "Harga";
            this.harga.MinimumWidth = 8;
            this.harga.Name = "harga";
            this.harga.Width = 150;
            // 
            // foto
            // 
            this.foto.DataPropertyName = "foto";
            this.foto.HeaderText = "Foto";
            this.foto.MinimumWidth = 8;
            this.foto.Name = "foto";
            this.foto.Width = 150;
            // 
            // karbohidrat
            // 
            this.karbohidrat.DataPropertyName = "karbohidrat";
            this.karbohidrat.HeaderText = "Karbohidrat";
            this.karbohidrat.MinimumWidth = 8;
            this.karbohidrat.Name = "karbohidrat";
            this.karbohidrat.Width = 150;
            // 
            // protein
            // 
            this.protein.DataPropertyName = "protein";
            this.protein.HeaderText = "Protein";
            this.protein.MinimumWidth = 8;
            this.protein.Name = "protein";
            this.protein.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewOrderDetail);
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 254);
            this.panel2.TabIndex = 2;
            // 
            // dataGridViewOrderDetail
            // 
            this.dataGridViewOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama,
            this.jumlah,
            this.karbohidrat1,
            this.protein1,
            this.hargaa,
            this.totalHarga});
            this.dataGridViewOrderDetail.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrderDetail.Name = "dataGridViewOrderDetail";
            this.dataGridViewOrderDetail.RowHeadersWidth = 62;
            this.dataGridViewOrderDetail.RowTemplate.Height = 28;
            this.dataGridViewOrderDetail.Size = new System.Drawing.Size(849, 253);
            this.dataGridViewOrderDetail.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.txtJumlah);
            this.panel3.Controls.Add(this.txtNamaMenu);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(855, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 370);
            this.panel3.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(499, 207);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 42);
            this.button5.TabIndex = 7;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hapus";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tambahkan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(339, 127);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(255, 26);
            this.txtJumlah.TabIndex = 4;
            // 
            // txtNamaMenu
            // 
            this.txtNamaMenu.Location = new System.Drawing.Point(339, 76);
            this.txtNamaMenu.Name = "txtNamaMenu";
            this.txtNamaMenu.Size = new System.Drawing.Size(255, 26);
            this.txtNamaMenu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jumlah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Menu ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(26, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 173);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(855, 434);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(849, 254);
            this.panel4.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(475, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 42);
            this.button3.TabIndex = 6;
            this.button3.Text = "Order";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Harga : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Protein : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Karbohidrat : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(463, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(499, -2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // nama
            // 
            this.nama.DataPropertyName = "namaMenu";
            this.nama.HeaderText = "Nama Menu";
            this.nama.MinimumWidth = 8;
            this.nama.Name = "nama";
            this.nama.Width = 150;
            // 
            // jumlah
            // 
            this.jumlah.DataPropertyName = "jumlah";
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.MinimumWidth = 8;
            this.jumlah.Name = "jumlah";
            this.jumlah.Width = 150;
            // 
            // karbohidrat1
            // 
            this.karbohidrat1.DataPropertyName = "karbohidrat";
            this.karbohidrat1.HeaderText = "Karbohidrat";
            this.karbohidrat1.MinimumWidth = 8;
            this.karbohidrat1.Name = "karbohidrat1";
            this.karbohidrat1.Width = 150;
            // 
            // protein1
            // 
            this.protein1.DataPropertyName = "protein";
            this.protein1.HeaderText = "Protein";
            this.protein1.MinimumWidth = 8;
            this.protein1.Name = "protein1";
            this.protein1.Width = 150;
            // 
            // hargaa
            // 
            this.hargaa.DataPropertyName = "harga";
            this.hargaa.HeaderText = "Harga";
            this.hargaa.MinimumWidth = 8;
            this.hargaa.Name = "hargaa";
            this.hargaa.Width = 150;
            // 
            // totalHarga
            // 
            this.totalHarga.HeaderText = "Total Harga";
            this.totalHarga.MinimumWidth = 8;
            this.totalHarga.Name = "totalHarga";
            this.totalHarga.Width = 150;
            // 
            // UCOrderAdminNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UCOrderAdminNavigation";
            this.Size = new System.Drawing.Size(1720, 700);
            this.Load += new System.EventHandler(this.UCOrderAdminNavigation_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetail;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.TextBox txtNamaMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn karbohidrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn protein;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn karbohidrat1;
        private System.Windows.Forms.DataGridViewTextBoxColumn protein1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHarga;
    }
}
