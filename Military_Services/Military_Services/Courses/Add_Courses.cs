using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military_Services.Courses
{
    public partial class Add_Courses : Form
    {
        public Add_Courses()
        {

            InitializeComponent();
            txtCourseFilaureReason.Enabled = false;
            LCourseFilaureReason.Enabled = false;
        }

        private void rbCourseFilaure_CheckedChanged(object sender, EventArgs e)
        {
            txtCourseFilaureReason.Enabled = true;
            LCourseFilaureReason.Enabled = true;
        }

        private void rbCoursePass_CheckedChanged(object sender, EventArgs e)
        {
            txtCourseFilaureReason.Enabled = false;
            LCourseFilaureReason.Enabled = false;
        }
    }
}
