using Military_Services.Database_Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military_Services.Soldiers
{
    public partial class Soldiers_Manage : Form
    {


        public Soldiers_Manage()
        {
            InitializeComponent();
        }

        private void Soldiers_Manage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'militaryDataset.Saraya_Details' table. You can move, or remove it, as needed.
            this.saraya_DetailsTableAdapter.Fill(this.militaryDataset.Saraya_Details);
            // TODO: This line of code loads data into the 'militaryDataset.Saraya_Main' table. You can move, or remove it, as needed.
            this.saraya_MainTableAdapter.Fill(this.militaryDataset.Saraya_Main);
            // TODO: This line of code loads data into the 'militaryViews_Dataset.Soldiers_View' table. You can move, or remove it, as needed.
            this.soldiers_ViewTableAdapter.Fill(this.militaryViews_Dataset.Soldiers_View);

        }

        private void gvSoldiersData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Soldiers_Registration UpdateSoldiers = new Soldiers_Registration(gvSoldiersData.CurrentRow.Cells[0].Value.ToString());

            UpdateSoldiers.btnSaveSoldierData.Text = "حفظ التعديل";






            foreach (DataGridViewRow row in gvSoldiersData.SelectedRows)
            {
                try
                {
                    //MemoryStream ms = new MemoryStream((byte[])militaryViews_Dataset.Soldiers_View.Rows[0]["Soldier_Image"]);

                    byte[] imgg = (byte[])militaryViews_Dataset.Soldiers_View.Rows[0]["Soldier_Image"];



                if (row.Cells[8].Value == DBNull.Value && row.Cells[9].Value == DBNull.Value && row.Cells[10].Value == DBNull.Value)
                {
                    UpdateSoldiers.rdNoneAttach.Checked = true;

                    UpdateSoldiers.txtMilitray_No.Text = this.gvSoldiersData.CurrentRow.Cells[1].Value.ToString();
                    UpdateSoldiers.txtClassification.Text = this.gvSoldiersData.CurrentRow.Cells[5].Value.ToString();
                    //  UpdateSoldiers.cbRank.SelectedValue = this.gvSoldiersData.CurrentRow.Cells[2].Value.ToString();
                    UpdateSoldiers.cbSaraya.SelectedValue = this.gvSoldiersData.CurrentRow.Cells[6].Value.ToString();
                    UpdateSoldiers.txtSoldier_Name.Text = this.gvSoldiersData.CurrentRow.Cells[3].Value.ToString();
                    UpdateSoldiers.cbSarayaDept.SelectedValue = this.gvSoldiersData.CurrentRow.Cells[7].Value.ToString();
                    UpdateSoldiers.txtAttachDestination.Text = this.gvSoldiersData.CurrentRow.Cells[9].Value.ToString();
                    UpdateSoldiers.txtAttachType_Details.Text = this.gvSoldiersData.CurrentRow.Cells[10].Value.ToString();
                    UpdateSoldiers.dtpFirstAttach.Text = this.gvSoldiersData.CurrentRow.Cells[8].Value.ToString();
                    UpdateSoldiers.dtpAttachDestDate.Text = this.gvSoldiersData.CurrentRow.Cells[11].Value.ToString();
                    UpdateSoldiers.txtDebara.Text = this.gvSoldiersData.CurrentRow.Cells[4].Value.ToString();

                    ///Image Load
                    militaryViews_Dataset.EnforceConstraints = false;
                    soldiers_ViewTableAdapter.FillByImage(this.militaryViews_Dataset.Soldiers_View, int.Parse(gvSoldiersData.CurrentRow.Cells[0].Value.ToString()));
                    MemoryStream ms = new MemoryStream(imgg);
                    UpdateSoldiers.pictureBox1.Image = Image.FromStream(ms);

                    ///cbRank Load
                    foreach (object o in UpdateSoldiers.cbRank.Items)
                    {
                        DataRowView dr = (DataRowView)o;
                        if (dr.Row[1].ToString() == this.gvSoldiersData.CurrentRow.Cells[2].Value.ToString())
                        {
                            UpdateSoldiers.cbRank.SelectedValue = dr.Row[0].ToString();
                            break;
                        }
                    }


                }
                else
                {
                    UpdateSoldiers.rdAttach.Checked = true;

                    UpdateSoldiers.txtMilitray_No.Text = gvSoldiersData.CurrentRow.Cells[1].Value.ToString();
                    UpdateSoldiers.txtClassification.Text = gvSoldiersData.CurrentRow.Cells[5].Value.ToString();
                    UpdateSoldiers.cbRank.SelectedValue = gvSoldiersData.CurrentRow.Cells["gvRank"].Value.ToString();
                    UpdateSoldiers.cbSaraya.SelectedText = row.Cells[6].Value.ToString();
                    UpdateSoldiers.txtSoldier_Name.Text = gvSoldiersData.CurrentRow.Cells[3].Value.ToString();
                    UpdateSoldiers.cbSarayaDept.SelectedValue = this.gvSoldiersData.CurrentRow.Cells[7].Value.ToString();
                    UpdateSoldiers.txtAttachDestination.Text = this.gvSoldiersData.CurrentRow.Cells[9].Value.ToString();
                    UpdateSoldiers.txtAttachType_Details.Text = this.gvSoldiersData.CurrentRow.Cells[10].Value.ToString();
                    UpdateSoldiers.dtpFirstAttach.Text = this.gvSoldiersData.CurrentRow.Cells[8].Value.ToString();
                    UpdateSoldiers.dtpAttachDestDate.Text = this.gvSoldiersData.CurrentRow.Cells[11].Value.ToString();
                    UpdateSoldiers.txtDebara.Text = this.gvSoldiersData.CurrentRow.Cells[4].Value.ToString();

                    ///Image Load
                    militaryViews_Dataset.EnforceConstraints = false;
                    soldiers_ViewTableAdapter.FillByImage(this.militaryViews_Dataset.Soldiers_View, int.Parse(gvSoldiersData.CurrentRow.Cells[0].Value.ToString()));
                    MemoryStream ms = new MemoryStream(imgg);
                    UpdateSoldiers.pictureBox1.Image = Image.FromStream(ms);

                    ///cbRank Load
                    //foreach (object o in UpdateSoldiers.cbSaraya.Items)
                    //{
                    //    DataRowView dr = (DataRowView)o;
                    //    if (dr.Row[1].ToString() == this.gvSoldiersData.CurrentRow.Cells[6].Value.ToString())
                    //    {
                    //        UpdateSoldiers.cbRank.SelectedValue = dr.Row[0].ToString();
                    //        break;
                    //    }
                    //}

                }
                    UpdateSoldiers.ShowDialog();
                }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



           
                this.soldiers_ViewTableAdapter.Fill(this.militaryViews_Dataset.Soldiers_View);

            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            soldiers_ViewTableAdapter.FillBySearch(this.militaryViews_Dataset.Soldiers_View, txtSearch.Text);
        }

        private void تسجيلالافرادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Soldiers_Registration SoldierReg = new Soldiers_Registration();

            SoldierReg.ShowDialog();
            this.soldiers_ViewTableAdapter.Fill(this.militaryViews_Dataset.Soldiers_View);


        }
    }
}
