namespace Military_Services.Courses
{
    partial class Add_Courses
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveCourses = new System.Windows.Forms.Button();
            this.LCourseFilaureReason = new System.Windows.Forms.Label();
            this.rbCourseFilaure = new System.Windows.Forms.RadioButton();
            this.rbCoursePass = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseFilaureReason = new System.Windows.Forms.TextBox();
            this.txtCourseDegree = new System.Windows.Forms.TextBox();
            this.txtCourseDept = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveCourses);
            this.groupBox1.Controls.Add(this.LCourseFilaureReason);
            this.groupBox1.Controls.Add(this.rbCourseFilaure);
            this.groupBox1.Controls.Add(this.rbCoursePass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCourseName);
            this.groupBox1.Controls.Add(this.txtCourseFilaureReason);
            this.groupBox1.Controls.Add(this.txtCourseDegree);
            this.groupBox1.Controls.Add(this.txtCourseDept);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(622, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تفاصيل الدورات";
            // 
            // btnSaveCourses
            // 
            this.btnSaveCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCourses.Location = new System.Drawing.Point(214, 177);
            this.btnSaveCourses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveCourses.Name = "btnSaveCourses";
            this.btnSaveCourses.Size = new System.Drawing.Size(89, 24);
            this.btnSaveCourses.TabIndex = 10;
            this.btnSaveCourses.Text = "حفظ";
            this.btnSaveCourses.UseVisualStyleBackColor = true;
            // 
            // LCourseFilaureReason
            // 
            this.LCourseFilaureReason.AutoSize = true;
            this.LCourseFilaureReason.Location = new System.Drawing.Point(224, 128);
            this.LCourseFilaureReason.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCourseFilaureReason.Name = "LCourseFilaureReason";
            this.LCourseFilaureReason.Size = new System.Drawing.Size(116, 13);
            this.LCourseFilaureReason.TabIndex = 9;
            this.LCourseFilaureReason.Text = "سبب عدم إجتياز الدورة:";
            // 
            // rbCourseFilaure
            // 
            this.rbCourseFilaure.AutoSize = true;
            this.rbCourseFilaure.Location = new System.Drawing.Point(66, 46);
            this.rbCourseFilaure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCourseFilaure.Name = "rbCourseFilaure";
            this.rbCourseFilaure.Size = new System.Drawing.Size(102, 17);
            this.rbCourseFilaure.TabIndex = 8;
            this.rbCourseFilaure.Text = "عدم إجتياز الدورة";
            this.rbCourseFilaure.UseVisualStyleBackColor = true;
            this.rbCourseFilaure.CheckedChanged += new System.EventHandler(this.rbCourseFilaure_CheckedChanged);
            // 
            // rbCoursePass
            // 
            this.rbCoursePass.AutoSize = true;
            this.rbCoursePass.Checked = true;
            this.rbCoursePass.Location = new System.Drawing.Point(168, 46);
            this.rbCoursePass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCoursePass.Name = "rbCoursePass";
            this.rbCoursePass.Size = new System.Drawing.Size(79, 17);
            this.rbCoursePass.TabIndex = 7;
            this.rbCoursePass.TabStop = true;
            this.rbCoursePass.Text = "إجتياز الدورة";
            this.rbCoursePass.UseVisualStyleBackColor = true;
            this.rbCoursePass.CheckedChanged += new System.EventHandler(this.rbCoursePass_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "معدل النجاح:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "أقسام الدورة:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "أسم الدورة:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(355, 41);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(175, 20);
            this.txtCourseName.TabIndex = 3;
            // 
            // txtCourseFilaureReason
            // 
            this.txtCourseFilaureReason.Location = new System.Drawing.Point(46, 125);
            this.txtCourseFilaureReason.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCourseFilaureReason.Name = "txtCourseFilaureReason";
            this.txtCourseFilaureReason.Size = new System.Drawing.Size(175, 20);
            this.txtCourseFilaureReason.TabIndex = 2;
            // 
            // txtCourseDegree
            // 
            this.txtCourseDegree.Location = new System.Drawing.Point(355, 127);
            this.txtCourseDegree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCourseDegree.Name = "txtCourseDegree";
            this.txtCourseDegree.Size = new System.Drawing.Size(175, 20);
            this.txtCourseDegree.TabIndex = 1;
            // 
            // txtCourseDept
            // 
            this.txtCourseDept.Location = new System.Drawing.Point(355, 81);
            this.txtCourseDept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCourseDept.Name = "txtCourseDept";
            this.txtCourseDept.Size = new System.Drawing.Size(175, 20);
            this.txtCourseDept.TabIndex = 0;
            // 
            // Add_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 226);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Add_Courses";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "بيانات دورات الأفراد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseFilaureReason;
        private System.Windows.Forms.TextBox txtCourseDegree;
        private System.Windows.Forms.TextBox txtCourseDept;
        private System.Windows.Forms.RadioButton rbCourseFilaure;
        private System.Windows.Forms.RadioButton rbCoursePass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LCourseFilaureReason;
        private System.Windows.Forms.Button btnSaveCourses;
    }
}