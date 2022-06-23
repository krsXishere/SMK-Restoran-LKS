namespace heeh
{
    partial class FormAdminNavigation
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.adminName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.nameAdmin = new System.Windows.Forms.Label();
            this.ucManageMemberAdminNavigation1 = new heeh.UserController.UCManageMemberAdminNavigation();
            this.ucManageMenuAdminNavigation1 = new heeh.UserController.UCManageMenuAdminNavigation();
            this.ucOrderAdminNavigation1 = new heeh.UserController.UCOrderAdminNavigation();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(18, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 810);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Navigation";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(-1, 538);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 110);
            this.button4.TabIndex = 3;
            this.button4.Text = "Log-out";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-1, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 110);
            this.button3.TabIndex = 2;
            this.button3.Text = "Manage Member";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 110);
            this.button2.TabIndex = 1;
            this.button2.Text = "Manage Menu\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 110);
            this.button1.TabIndex = 0;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.ucManageMemberAdminNavigation1);
            this.panel2.Controls.Add(this.ucManageMenuAdminNavigation1);
            this.panel2.Controls.Add(this.ucOrderAdminNavigation1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(176, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1720, 810);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selamat datang, ";
            // 
            // adminName
            // 
            this.adminName.AutoSize = true;
            this.adminName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminName.Location = new System.Drawing.Point(210, 9);
            this.adminName.Name = "adminName";
            this.adminName.Size = new System.Drawing.Size(77, 32);
            this.adminName.TabIndex = 3;
            this.adminName.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1104, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Anda log-in sebagai : ";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.Location = new System.Drawing.Point(1363, 9);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(100, 32);
            this.position.TabIndex = 5;
            this.position.Text = "position";
            // 
            // nameAdmin
            // 
            this.nameAdmin.AutoSize = true;
            this.nameAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameAdmin.Location = new System.Drawing.Point(1469, 9);
            this.nameAdmin.Name = "nameAdmin";
            this.nameAdmin.Size = new System.Drawing.Size(74, 32);
            this.nameAdmin.TabIndex = 6;
            this.nameAdmin.Text = "name";
            // 
            // ucManageMemberAdminNavigation1
            // 
            this.ucManageMemberAdminNavigation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ucManageMemberAdminNavigation1.Location = new System.Drawing.Point(0, 0);
            this.ucManageMemberAdminNavigation1.Name = "ucManageMemberAdminNavigation1";
            this.ucManageMemberAdminNavigation1.Size = new System.Drawing.Size(1720, 795);
            this.ucManageMemberAdminNavigation1.TabIndex = 2;
            this.ucManageMemberAdminNavigation1.Visible = false;
            // 
            // ucManageMenuAdminNavigation1
            // 
            this.ucManageMenuAdminNavigation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ucManageMenuAdminNavigation1.Location = new System.Drawing.Point(0, 0);
            this.ucManageMenuAdminNavigation1.Name = "ucManageMenuAdminNavigation1";
            this.ucManageMenuAdminNavigation1.Size = new System.Drawing.Size(1736, 795);
            this.ucManageMenuAdminNavigation1.TabIndex = 1;
            this.ucManageMenuAdminNavigation1.Visible = false;
            // 
            // ucOrderAdminNavigation1
            // 
            this.ucOrderAdminNavigation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ucOrderAdminNavigation1.Location = new System.Drawing.Point(0, 0);
            this.ucOrderAdminNavigation1.Name = "ucOrderAdminNavigation1";
            this.ucOrderAdminNavigation1.Size = new System.Drawing.Size(1720, 810);
            this.ucOrderAdminNavigation1.TabIndex = 0;
            this.ucOrderAdminNavigation1.Visible = false;
            // 
            // FormAdminNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 846);
            this.Controls.Add(this.nameAdmin);
            this.Controls.Add(this.position);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdminNavigation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Admin Navigation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAdminNavigation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private UserController.UCOrderAdminNavigation ucOrderAdminNavigation1;
        private System.Windows.Forms.Label label3;
        private UserController.UCManageMenuAdminNavigation ucManageMenuAdminNavigation1;
        private UserController.UCManageMemberAdminNavigation ucManageMemberAdminNavigation1;
        private System.Windows.Forms.Label adminName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label nameAdmin;
    }
}