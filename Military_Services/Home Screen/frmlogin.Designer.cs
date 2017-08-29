namespace Military_Services.Home_Screen
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1login = new System.Windows.Forms.PictureBox();
            this.militaryDataset = new Military_Services.Database_Connection.militaryDataset();
            this.uesrLoginTableAdapter = new Military_Services.Database_Connection.militaryDatasetTableAdapters.UesrLoginTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم";
            this.label1.UseWaitCursor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(213, 27);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(136, 21);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.UseWaitCursor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(213, 54);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(136, 21);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "كلمة المرور";
            this.label2.UseWaitCursor = true;
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(319, 90);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(87, 23);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "دخول";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.UseWaitCursor = true;
            this.loginbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1login);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.loginbutton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 159);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الدخول للنظام";
            this.groupBox2.UseWaitCursor = true;
            // 
            // pictureBox1login
            // 
            this.pictureBox1login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1login.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1login.Image")));
            this.pictureBox1login.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1login.Name = "pictureBox1login";
            this.pictureBox1login.Size = new System.Drawing.Size(165, 152);
            this.pictureBox1login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1login.TabIndex = 4;
            this.pictureBox1login.TabStop = false;
            this.pictureBox1login.UseWaitCursor = true;
            // 
            // militaryDataset
            // 
            this.militaryDataset.DataSetName = "militaryDatase";
            this.militaryDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uesrLoginTableAdapter
            // 
            this.uesrLoginTableAdapter.ClearBeforeFill = true;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(448, 164);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmlogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تسجيل الدخول";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1login;
        private Database_Connection.militaryDataset militaryDataset;
        private Database_Connection.militaryDatasetTableAdapters.UesrLoginTableAdapter uesrLoginTableAdapter;
    }
}