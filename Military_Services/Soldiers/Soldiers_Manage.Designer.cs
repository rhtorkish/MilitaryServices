namespace Military_Services.Soldiers
{
    partial class Soldiers_Manage
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
            this.gvSoldiersData = new System.Windows.Forms.DataGridView();
            this.gvSoldier_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvMilitary_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSoldier_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSoldier_FileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvMain_Saraya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSaraya_Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAttach_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAttach_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAttachType_Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAttachType_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldiersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.militaryViews_Dataset = new Military_Services.Database_Connection.MilitaryViews_Dataset();
            this.soldiers_ViewTableAdapter = new Military_Services.Database_Connection.MilitaryViews_DatasetTableAdapters.Soldiers_ViewTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.sarayaDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.militaryDataset = new Military_Services.Database_Connection.militaryDataset();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sarayaMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saraya_MainTableAdapter = new Military_Services.Database_Connection.militaryDatasetTableAdapters.Saraya_MainTableAdapter();
            this.saraya_DetailsTableAdapter = new Military_Services.Database_Connection.militaryDatasetTableAdapters.Saraya_DetailsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvSoldiersData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldiersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryViews_Dataset)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sarayaDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sarayaMainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gvSoldiersData
            // 
            this.gvSoldiersData.AllowUserToAddRows = false;
            this.gvSoldiersData.AutoGenerateColumns = false;
            this.gvSoldiersData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSoldiersData.BackgroundColor = System.Drawing.Color.White;
            this.gvSoldiersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSoldiersData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvSoldier_Id,
            this.gvMilitary_No,
            this.gvRank,
            this.gvSoldier_Name,
            this.gvSoldier_FileNumber,
            this.gvClassification,
            this.gvMain_Saraya,
            this.gvSaraya_Details,
            this.gvAttach_Date,
            this.gvAttach_Type,
            this.gvAttachType_Details,
            this.gvAttachType_Date});
            this.gvSoldiersData.DataSource = this.soldiersViewBindingSource;
            this.gvSoldiersData.Location = new System.Drawing.Point(6, 23);
            this.gvSoldiersData.Name = "gvSoldiersData";
            this.gvSoldiersData.ReadOnly = true;
            this.gvSoldiersData.RowTemplate.Height = 24;
            this.gvSoldiersData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSoldiersData.Size = new System.Drawing.Size(1274, 303);
            this.gvSoldiersData.TabIndex = 0;
            this.gvSoldiersData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSoldiersData_CellContentDoubleClick);
            // 
            // gvSoldier_Id
            // 
            this.gvSoldier_Id.DataPropertyName = "Soldier_Id";
            this.gvSoldier_Id.HeaderText = "الرقم التسلسلي";
            this.gvSoldier_Id.Name = "gvSoldier_Id";
            this.gvSoldier_Id.ReadOnly = true;
            // 
            // gvMilitary_No
            // 
            this.gvMilitary_No.DataPropertyName = "SoldierMilitary_Number";
            this.gvMilitary_No.HeaderText = "الرقم العسكري";
            this.gvMilitary_No.Name = "gvMilitary_No";
            this.gvMilitary_No.ReadOnly = true;
            // 
            // gvRank
            // 
            this.gvRank.DataPropertyName = "Rank_Name";
            this.gvRank.HeaderText = "الرتبة";
            this.gvRank.Name = "gvRank";
            this.gvRank.ReadOnly = true;
            // 
            // gvSoldier_Name
            // 
            this.gvSoldier_Name.DataPropertyName = "Soldier_Name";
            this.gvSoldier_Name.HeaderText = "الأسم";
            this.gvSoldier_Name.Name = "gvSoldier_Name";
            this.gvSoldier_Name.ReadOnly = true;
            // 
            // gvSoldier_FileNumber
            // 
            this.gvSoldier_FileNumber.DataPropertyName = "Soldier_FileNumber";
            this.gvSoldier_FileNumber.HeaderText = "رقم الضبارة";
            this.gvSoldier_FileNumber.Name = "gvSoldier_FileNumber";
            this.gvSoldier_FileNumber.ReadOnly = true;
            // 
            // gvClassification
            // 
            this.gvClassification.DataPropertyName = "Soldier_Classification";
            this.gvClassification.HeaderText = "التصنيف";
            this.gvClassification.Name = "gvClassification";
            this.gvClassification.ReadOnly = true;
            // 
            // gvMain_Saraya
            // 
            this.gvMain_Saraya.DataPropertyName = "MainSaraya_Name";
            this.gvMain_Saraya.HeaderText = "السرية";
            this.gvMain_Saraya.Name = "gvMain_Saraya";
            this.gvMain_Saraya.ReadOnly = true;
            // 
            // gvSaraya_Details
            // 
            this.gvSaraya_Details.DataPropertyName = "SarayaDetails_Name";
            this.gvSaraya_Details.HeaderText = "القسم";
            this.gvSaraya_Details.Name = "gvSaraya_Details";
            this.gvSaraya_Details.ReadOnly = true;
            // 
            // gvAttach_Date
            // 
            this.gvAttach_Date.DataPropertyName = "Soldier_AttachDate";
            this.gvAttach_Date.HeaderText = "تاريخ الإلتحاق بالخدمة";
            this.gvAttach_Date.Name = "gvAttach_Date";
            this.gvAttach_Date.ReadOnly = true;
            // 
            // gvAttach_Type
            // 
            this.gvAttach_Type.DataPropertyName = "MilitaryAttacheType_Name";
            this.gvAttach_Type.HeaderText = "الإلحاق";
            this.gvAttach_Type.Name = "gvAttach_Type";
            this.gvAttach_Type.ReadOnly = true;
            // 
            // gvAttachType_Details
            // 
            this.gvAttachType_Details.DataPropertyName = "MilitaryAttacheType_Details";
            this.gvAttachType_Details.HeaderText = "بيانات الإلحاق";
            this.gvAttachType_Details.Name = "gvAttachType_Details";
            this.gvAttachType_Details.ReadOnly = true;
            // 
            // gvAttachType_Date
            // 
            this.gvAttachType_Date.DataPropertyName = "MilitaryAttacheType_Date";
            this.gvAttachType_Date.HeaderText = "تاريخ الإلحاق";
            this.gvAttachType_Date.Name = "gvAttachType_Date";
            this.gvAttachType_Date.ReadOnly = true;
            // 
            // soldiersViewBindingSource
            // 
            this.soldiersViewBindingSource.DataMember = "Soldiers_View";
            this.soldiersViewBindingSource.DataSource = this.militaryViews_Dataset;
            // 
            // militaryViews_Dataset
            // 
            this.militaryViews_Dataset.DataSetName = "MilitaryViews_Dataset";
            this.militaryViews_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soldiers_ViewTableAdapter
            // 
            this.soldiers_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvSoldiersData);
            this.groupBox1.Location = new System.Drawing.Point(10, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1284, 350);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الأفراد";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(9, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1101, 97);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "أدوات البحث";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "حسب القسم:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "حسب السرية:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(996, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "بحث:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(789, 51);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.sarayaDetailsBindingSource;
            this.comboBox2.DisplayMember = "SarayaDetails_Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(278, 51);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "SaryaDetails_Id";
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
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sarayaMainBindingSource;
            this.comboBox1.DisplayMember = "MainSaraya_Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(537, 51);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "MainSaraya_Id";
            // 
            // sarayaMainBindingSource
            // 
            this.sarayaMainBindingSource.DataMember = "Saraya_Main";
            this.sarayaMainBindingSource.DataSource = this.militaryDataset;
            // 
            // saraya_MainTableAdapter
            // 
            this.saraya_MainTableAdapter.ClearBeforeFill = true;
            // 
            // saraya_DetailsTableAdapter
            // 
            this.saraya_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "اضافة اجازة ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Soldiers_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1306, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Soldiers_Manage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إدارة شئون الأفراد";
            this.Load += new System.EventHandler(this.Soldiers_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSoldiersData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldiersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryViews_Dataset)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sarayaDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sarayaMainBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvSoldiersData;
        private Database_Connection.MilitaryViews_Dataset militaryViews_Dataset;
        private System.Windows.Forms.BindingSource soldiersViewBindingSource;
        private Database_Connection.MilitaryViews_DatasetTableAdapters.Soldiers_ViewTableAdapter soldiers_ViewTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Database_Connection.militaryDataset militaryDataset;
        private System.Windows.Forms.BindingSource sarayaMainBindingSource;
        private Database_Connection.militaryDatasetTableAdapters.Saraya_MainTableAdapter saraya_MainTableAdapter;
        private System.Windows.Forms.BindingSource sarayaDetailsBindingSource;
        private Database_Connection.militaryDatasetTableAdapters.Saraya_DetailsTableAdapter saraya_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSoldier_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvMilitary_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSoldier_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSoldier_FileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvMain_Saraya;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSaraya_Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAttach_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAttach_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAttachType_Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAttachType_Date;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem الملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسجيلالافرادToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button button1;
    }
}