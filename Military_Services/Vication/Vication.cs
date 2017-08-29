using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military_Services.Vication
{
    public partial class Vication : Form
    {
        private string _SoldierID;

        public Vication(string SoldierID)
        {
            InitializeComponent();
            _SoldierID = SoldierID;
        }

        public Vication()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Vication_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'militaryDataset.Vection_Type' table. You can move, or remove it, as needed.
            this.vection_TypeTableAdapter.Fill(this.militaryDataset.Vection_Type);
            // TODO: This line of code loads data into the 'militaryDataset.Vectaions_type' table. You can move, or remove it, as needed.

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vectionsTableAdapter.Vection_insert(int.Parse(_SoldierID), int.Parse(cbVectionType.SelectedValue.ToString()),Convert.ToDateTime(dateStar.Text),Convert.ToDateTime(dateEnd.Text));
            MessageBox.Show("لقد تم الحفظ");
        }
    }
}
