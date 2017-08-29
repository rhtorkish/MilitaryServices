namespace Military_Services.Soldiers
{
    partial class Soldiers_Registration
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Soldiers_Registration));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDebara = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSaveSoldierData = new System.Windows.Forms.Button();
            this.rdNoneAttach = new System.Windows.Forms.RadioButton();
            this.gbAttachData = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAttachType_Details = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpAttachDestDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAttachDestination = new System.Windows.Forms.TextBox();
            this.rdAttach = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFirstAttach = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSarayaDept = new System.Windows.Forms.ComboBox();
            this.sarayaDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.militaryDataset = new Military_Services.Database_Connection.militaryDataset();
            this.cbRank = new System.Windows.Forms.ComboBox();
            this.ranksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cbSaraya = new System.Windows.Forms.ComboBox();
            this.sarayaMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtClassification = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMilitray_No = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoldier_Name = new System.Windows.Forms.TextBox();
            this.ranksTableAdapter = new Military_Services.Database_Connection.militaryDatasetTableAdapters.RanksTableAdapter();
            this.saraya_MainTableAdapter = new Military_Services.Database_Connection.militaryDatasetTableAdapters.Saraya_MainTableAdapter();
            this.saraya_DetailsTableAdapter = new Military_Services.Database_Connection.militaryDatasetTableAdapters.Saraya_DetailsTableAdapter();
            this.soldiersTableAdapter = new Military_Services.Database_Connection.militaryDatasetTableAdapters.SoldiersTableAdapter();
            this.militaryAttache_TypeTableAdapter = new Military_Services.Database_Connection.militaryDatasetTableAdapters.MilitaryAttache_TypeTableAdapter();
            this.soldiers_ViewTableAdapter = new Military_Services.Database_Connection.MilitaryViews_DatasetTableAdapters.Soldiers_ViewTableAdapter();
            this.militaryViews_Dataset = new Military_Services.Database_Connection.MilitaryViews_Dataset();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbAttachData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sarayaDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sarayaMainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryViews_Dataset)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtDebara);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSaveSoldierData);
            this.groupBox1.Controls.Add(this.rdNoneAttach);
            this.groupBox1.Controls.Add(this.gbAttachData);
            this.groupBox1.Controls.Add(this.rdAttach);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpFirstAttach);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbSarayaDept);
            this.groupBox1.Controls.Add(this.cbRank);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbSaraya);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtClassification);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMilitray_No);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSoldier_Name);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1189, 547);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تسجيل جديد";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1058, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "رقم الضبارة:";
            // 
            // txtDebara
            // 
            this.txtDebara.Location = new System.Drawing.Point(792, 166);
            this.txtDebara.Name = "txtDebara";
            this.txtDebara.Size = new System.Drawing.Size(260, 22);
            this.txtDebara.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnAddPhoto);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(33, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 260);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الصورة العسكرية";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 24;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(58, 227);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnAddPhoto.TabIndex = 23;
            this.btnAddPhoto.Text = "إضافة صورة";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(23, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnSaveSoldierData
            // 
            this.btnSaveSoldierData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSoldierData.Location = new System.Drawing.Point(437, 503);
            this.btnSaveSoldierData.Name = "btnSaveSoldierData";
            this.btnSaveSoldierData.Size = new System.Drawing.Size(267, 38);
            this.btnSaveSoldierData.TabIndex = 21;
            this.btnSaveSoldierData.Text = "حفظ";
            this.btnSaveSoldierData.UseVisualStyleBackColor = true;
            this.btnSaveSoldierData.Click += new System.EventHandler(this.btnSaveSoldierData_Click);
            // 
            // rdNoneAttach
            // 
            this.rdNoneAttach.AutoSize = true;
            this.rdNoneAttach.Checked = true;
            this.rdNoneAttach.Location = new System.Drawing.Point(819, 244);
            this.rdNoneAttach.Name = "rdNoneAttach";
            this.rdNoneAttach.Size = new System.Drawing.Size(75, 21);
            this.rdNoneAttach.TabIndex = 19;
            this.rdNoneAttach.TabStop = true;
            this.rdNoneAttach.Text = "غير ملحق";
            this.rdNoneAttach.UseVisualStyleBackColor = true;
            this.rdNoneAttach.CheckedChanged += new System.EventHandler(this.rdNoneAttach_CheckedChanged);
            // 
            // gbAttachData
            // 
            this.gbAttachData.Controls.Add(this.label10);
            this.gbAttachData.Controls.Add(this.txtAttachType_Details);
            this.gbAttachData.Controls.Add(this.label9);
            this.gbAttachData.Controls.Add(this.dtpAttachDestDate);
            this.gbAttachData.Controls.Add(this.label8);
            this.gbAttachData.Controls.Add(this.txtAttachDestination);
            this.gbAttachData.Location = new System.Drawing.Point(722, 311);
            this.gbAttachData.Name = "gbAttachData";
            this.gbAttachData.Size = new System.Drawing.Size(442, 181);
            this.gbAttachData.TabIndex = 20;
            this.gbAttachData.TabStop = false;
            this.gbAttachData.Text = "بيانات الإلحاق:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "تفاصيل الإلحاق:";
            // 
            // txtAttachType_Details
            // 
            this.txtAttachType_Details.Location = new System.Drawing.Point(71, 79);
            this.txtAttachType_Details.Name = "txtAttachType_Details";
            this.txtAttachType_Details.Size = new System.Drawing.Size(249, 22);
            this.txtAttachType_Details.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "تاريخ الإلحاق:";
            // 
            // dtpAttachDestDate
            // 
            this.dtpAttachDestDate.Location = new System.Drawing.Point(71, 135);
            this.dtpAttachDestDate.Name = "dtpAttachDestDate";
            this.dtpAttachDestDate.Size = new System.Drawing.Size(249, 22);
            this.dtpAttachDestDate.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "جهة الإلحاق:";
            // 
            // txtAttachDestination
            // 
            this.txtAttachDestination.Location = new System.Drawing.Point(71, 32);
            this.txtAttachDestination.Name = "txtAttachDestination";
            this.txtAttachDestination.Size = new System.Drawing.Size(249, 22);
            this.txtAttachDestination.TabIndex = 16;
            // 
            // rdAttach
            // 
            this.rdAttach.AutoSize = true;
            this.rdAttach.Location = new System.Drawing.Point(986, 244);
            this.rdAttach.Name = "rdAttach";
            this.rdAttach.Size = new System.Drawing.Size(53, 21);
            this.rdAttach.TabIndex = 18;
            this.rdAttach.Text = "ملحق";
            this.rdAttach.UseVisualStyleBackColor = true;
            this.rdAttach.CheckedChanged += new System.EventHandler(this.rdAttach_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "تاريخ الإلتحاق بالخدمة العسكرية:";
            // 
            // dtpFirstAttach
            // 
            this.dtpFirstAttach.Location = new System.Drawing.Point(91, 340);
            this.dtpFirstAttach.Name = "dtpFirstAttach";
            this.dtpFirstAttach.Size = new System.Drawing.Size(249, 22);
            this.dtpFirstAttach.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "القسم:";
            // 
            // cbSarayaDept
            // 
            this.cbSarayaDept.DataSource = this.sarayaDetailsBindingSource;
            this.cbSarayaDept.DisplayMember = "SarayaDetails_Name";
            this.cbSarayaDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSarayaDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSarayaDept.FormattingEnabled = true;
            this.cbSarayaDept.Location = new System.Drawing.Point(281, 112);
            this.cbSarayaDept.Name = "cbSarayaDept";
            this.cbSarayaDept.Size = new System.Drawing.Size(198, 24);
            this.cbSarayaDept.TabIndex = 11;
            this.cbSarayaDept.ValueMember = "SaryaDetails_Id";
            // 
            // sarayaDetailsBindingSource
            // 
            this.sarayaDetailsBindingSource.DataMember = "Saraya_Details";
            this.sarayaDetailsBindingSource.DataSource = this.militaryDataset;
            // 
            // militaryDataset
            // 
            this.militaryDataset.DataSetName = "militaryDataset";
            this.militaryDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbRank
            // 
            this.cbRank.DataSource = this.ranksBindingSource;
            this.cbRank.DisplayMember = "Rank_Name";
            this.cbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRank.FormattingEnabled = true;
            this.cbRank.Location = new System.Drawing.Point(560, 49);
            this.cbRank.Name = "cbRank";
            this.cbRank.Size = new System.Drawing.Size(163, 24);
            this.cbRank.TabIndex = 10;
            this.cbRank.ValueMember = "Rank_Id";
            // 
            // ranksBindingSource
            // 
            this.ranksBindingSource.DataMember = "Ranks";
            this.ranksBindingSource.DataSource = this.militaryDataset;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "السرايا:";
            // 
            // cbSaraya
            // 
            this.cbSaraya.DataSource = this.sarayaMainBindingSource;
            this.cbSaraya.DisplayMember = "MainSaraya_Name";
            this.cbSaraya.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSaraya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSaraya.FormattingEnabled = true;
            this.cbSaraya.Location = new System.Drawing.Point(281, 48);
            this.cbSaraya.Name = "cbSaraya";
            this.cbSaraya.Size = new System.Drawing.Size(198, 24);
            this.cbSaraya.TabIndex = 8;
            this.cbSaraya.ValueMember = "MainSaraya_Id";
            this.cbSaraya.SelectedIndexChanged += new System.EventHandler(this.cbSaraya_SelectedIndexChanged);
            // 
            // sarayaMainBindingSource
            // 
            this.sarayaMainBindingSource.DataMember = "Saraya_Main";
            this.sarayaMainBindingSource.DataSource = this.militaryDataset;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(720, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "التصنيف:";
            // 
            // txtClassification
            // 
            this.txtClassification.Location = new System.Drawing.Point(551, 115);
            this.txtClassification.Name = "txtClassification";
            this.txtClassification.Size = new System.Drawing.Size(163, 22);
            this.txtClassification.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(729, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "الرتبة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1058, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "الرقم العسكري:";
            // 
            // txtMilitray_No
            // 
            this.txtMilitray_No.Location = new System.Drawing.Point(792, 51);
            this.txtMilitray_No.Name = "txtMilitray_No";
            this.txtMilitray_No.Size = new System.Drawing.Size(260, 22);
            this.txtMilitray_No.TabIndex = 2;
            this.txtMilitray_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMilitray_No_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1058, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "الأسم الرباعي:";
            // 
            // txtSoldier_Name
            // 
            this.txtSoldier_Name.Location = new System.Drawing.Point(792, 114);
            this.txtSoldier_Name.Name = "txtSoldier_Name";
            this.txtSoldier_Name.Size = new System.Drawing.Size(260, 22);
            this.txtSoldier_Name.TabIndex = 0;
            // 
            // ranksTableAdapter
            // 
            this.ranksTableAdapter.ClearBeforeFill = true;
            // 
            // saraya_MainTableAdapter
            // 
            this.saraya_MainTableAdapter.ClearBeforeFill = true;
            // 
            // saraya_DetailsTableAdapter
            // 
            this.saraya_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // soldiersTableAdapter
            // 
            this.soldiersTableAdapter.ClearBeforeFill = true;
            // 
            // militaryAttache_TypeTableAdapter
            // 
            this.militaryAttache_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // soldiers_ViewTableAdapter
            // 
            this.soldiers_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // militaryViews_Dataset
            // 
            this.militaryViews_Dataset.DataSetName = "MilitaryViews_Dataset";
            this.militaryViews_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Soldiers_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 571);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Soldiers_Registration";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شئون الأفراد";
            this.Load += new System.EventHandler(this.Soldiers_Registration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbAttachData.ResumeLayout(false);
            this.gbAttachData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sarayaDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sarayaMainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryViews_Dataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbAttachData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddPhoto;
        private Database_Connection.militaryDataset militaryDataset;
        private System.Windows.Forms.BindingSource ranksBindingSource;
        private Database_Connection.militaryDatasetTableAdapters.RanksTableAdapter ranksTableAdapter;
        private System.Windows.Forms.BindingSource sarayaMainBindingSource;
        private Database_Connection.militaryDatasetTableAdapters.Saraya_MainTableAdapter saraya_MainTableAdapter;
        private System.Windows.Forms.BindingSource sarayaDetailsBindingSource;
        private Database_Connection.militaryDatasetTableAdapters.Saraya_DetailsTableAdapter saraya_DetailsTableAdapter;
        private Database_Connection.militaryDatasetTableAdapters.SoldiersTableAdapter soldiersTableAdapter;
        private System.Windows.Forms.Label label10;
        private Database_Connection.militaryDatasetTableAdapters.MilitaryAttache_TypeTableAdapter militaryAttache_TypeTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox txtSoldier_Name;
        public System.Windows.Forms.TextBox txtMilitray_No;
        public System.Windows.Forms.TextBox txtClassification;
        public System.Windows.Forms.ComboBox cbSaraya;
        public System.Windows.Forms.ComboBox cbSarayaDept;
        public System.Windows.Forms.ComboBox cbRank;
        public System.Windows.Forms.DateTimePicker dtpFirstAttach;
        public System.Windows.Forms.TextBox txtAttachDestination;
        public System.Windows.Forms.DateTimePicker dtpAttachDestDate;
        public System.Windows.Forms.Button btnSaveSoldierData;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtAttachType_Details;
        public System.Windows.Forms.RadioButton rdNoneAttach;
        public System.Windows.Forms.RadioButton rdAttach;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtDebara;
        public Database_Connection.MilitaryViews_DatasetTableAdapters.Soldiers_ViewTableAdapter soldiers_ViewTableAdapter;
        public Database_Connection.MilitaryViews_Dataset militaryViews_Dataset;
    }
}