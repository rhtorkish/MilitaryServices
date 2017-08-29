using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military_Services.Home_Screen
{
    public partial class mainscreen : Form
    {

        public mainscreen()
        {
            InitializeComponent();
                }

        private void اضافةجديدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Soldiers.Soldiers_Registration ua = new Soldiers.Soldiers_Registration();
            ua.ShowDialog();
        }

        private void تسجيلالدوراتالحاصلعليهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Courses.Add_Courses ua = new Courses.Add_Courses();
            ua.ShowDialog();
        }

        private void حسبالفصائلToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Soldiers.Soldiers_Manage ua = new Soldiers.Soldiers_Manage();
            ua.ShowDialog();
        }

        private void تسجيلخروجالمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void حسبالفصائلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Soldiers.Soldiers_Manage ua = new Soldiers.Soldiers_Manage();
            ua.Show();
        }
    }

}
