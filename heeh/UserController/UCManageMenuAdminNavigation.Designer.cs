namespace heeh.UserController
{
    partial class UCManageMenuAdminNavigation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karbohidrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtProtein = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKarbohidrat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaMenu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMenuID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Manage Menu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 656);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuID,
            this.namaMenu,
            this.harga,
            this.foto,
            this.karbohidrat,
            this.protein});
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(809, 632);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            this.foto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.foto.Width = 150;
            // 
            // karbohidrat
            // 
            this.karbohidrat.DataPropertyName = "karbohidrat";
            this.karbohidrat.HeaderText = "Karbohidrat";
            this.karbohidrat.MinimumWidth = 8;
            this.karbohidrat.Name = "karbohidrat";
            this.karbohidrat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.karbohidrat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtProtein);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtKarbohidrat);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtFilename);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtHarga);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNamaMenu);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMenuID);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(816, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 656);
            this.panel2.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(368, 458);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 29);
            this.button6.TabIndex = 19;
            this.button6.Text = "Bersihkan";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(487, 458);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 29);
            this.button5.TabIndex = 18;
            this.button5.Text = "Hapus";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(260, 458);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 29);
            this.button4.TabIndex = 17;
            this.button4.Text = "Perbarui";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 458);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 29);
            this.button3.TabIndex = 16;
            this.button3.Text = "Tambahkan";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox);
            this.panel3.Location = new System.Drawing.Point(26, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 193);
            this.panel3.TabIndex = 15;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 193);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // txtProtein
            // 
            this.txtProtein.Location = new System.Drawing.Point(349, 356);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Size = new System.Drawing.Size(132, 26);
            this.txtProtein.TabIndex = 14;
            this.txtProtein.TextChanged += new System.EventHandler(this.txtProtein_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Protein";
            // 
            // txtKarbohidrat
            // 
            this.txtKarbohidrat.Location = new System.Drawing.Point(349, 307);
            this.txtKarbohidrat.Name = "txtKarbohidrat";
            this.txtKarbohidrat.Size = new System.Drawing.Size(132, 26);
            this.txtKarbohidrat.TabIndex = 12;
            this.txtKarbohidrat.TextChanged += new System.EventHandler(this.txtKarbohidrat_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Karbohidrat";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(487, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cari";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Enabled = false;
            this.txtFilename.Location = new System.Drawing.Point(349, 255);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(132, 26);
            this.txtFilename.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Foto";
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(349, 203);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(132, 26);
            this.txtHarga.TabIndex = 7;
            this.txtHarga.TextChanged += new System.EventHandler(this.txtHarga_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Harga";
            // 
            // txtNamaMenu
            // 
            this.txtNamaMenu.Location = new System.Drawing.Point(349, 139);
            this.txtNamaMenu.Name = "txtNamaMenu";
            this.txtNamaMenu.Size = new System.Drawing.Size(132, 26);
            this.txtNamaMenu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Menu ID";
            // 
            // txtMenuID
            // 
            this.txtMenuID.Enabled = false;
            this.txtMenuID.Location = new System.Drawing.Point(349, 82);
            this.txtMenuID.Name = "txtMenuID";
            this.txtMenuID.Size = new System.Drawing.Size(132, 26);
            this.txtMenuID.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cari";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UCManageMenuAdminNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UCManageMenuAdminNavigation";
            this.Size = new System.Drawing.Size(1456, 700);
            this.Load += new System.EventHandler(this.UCManageMenuAdminNavigation_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtProtein;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKarbohidrat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamaMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMenuID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn karbohidrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn protein;
    }
}
