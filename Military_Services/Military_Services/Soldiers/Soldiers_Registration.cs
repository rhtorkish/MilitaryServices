using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military_Services.Soldiers
{
    public partial class Soldiers_Registration : Form
    {


        private string _Soldier_ID;
        string imgLocation = "";

        public Soldiers_Registration(string Soldier_ID)
        {
            InitializeComponent();
            _Soldier_ID = Soldier_ID;
            gbAttachData.Enabled = false;
        }

        /// <summary>
        /// Constructer no Value
        /// </summary>
        public Soldiers_Registration()
        {
            InitializeComponent();
            gbAttachData.Enabled = false;
        }

        private void Soldiers_Registration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'militaryDataset.Saraya_Details' table. You can move, or remove it, as needed.
            this.saraya_DetailsTableAdapter.Fill(this.militaryDataset.Saraya_Details);

            // TODO: This line of code loads data into the 'militaryDataset.Saraya_Main' table. You can move, or remove it, as needed.
            this.saraya_MainTableAdapter.Fill(this.militaryDataset.Saraya_Main);
            // TODO: This line of code loads data into the 'militaryDataset.Ranks' table. You can move, or remove it, as needed.
            this.ranksTableAdapter.Fill(this.militaryDataset.Ranks);

            cbSarayaDept.DataSource = this.saraya_DetailsTableAdapter.GetDataByMainSaraya_ID(int.Parse(cbSaraya.SelectedValue.ToString()));

        }

        private void cbSaraya_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                cbSarayaDept.DataSource = this.saraya_DetailsTableAdapter.GetDataByMainSaraya_ID(int.Parse(cbSaraya.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnSaveSoldierData_Click(object sender, EventArgs e)
        {
            //try
            //{
                byte[] byteImg = PerisitImage(pictureBox1.Image.ToString());

                if (btnSaveSoldierData.Text == "حفظ")
                {

                    
                    if (txtValdation())
                    {
                        MessageBox.Show("الرجاء كتابة جميع البيانات");
                    }
                    else
                    {




                        if (rdAttach.Checked == true)
                        {

                            militaryAttache_TypeTableAdapter.Insert(txtAttachDestination.Text, Convert.ToDateTime(dtpAttachDestDate.Text), txtAttachType_Details.Text, int.Parse(txtMilitray_No.Text)
                                , txtSoldier_Name.Text, txtClassification.Text, Convert.ToDateTime(dtpFirstAttach.Text), int.Parse(cbRank.SelectedValue.ToString()),
                                int.Parse(cbSarayaDept.SelectedValue.ToString()), byteImg,txtDebara.Text);

                            MessageBox.Show("تم الحفظ بنجاح");
                        this.soldiers_ViewTableAdapter.Fill(this.militaryViews_Dataset.Soldiers_View);

                    }

                        else
                                if (rdNoneAttach.Checked == true)
                        {
                            soldiersTableAdapter.SoldiersNoAttache_Insert(int.Parse(txtMilitray_No.Text), txtSoldier_Name.Text, txtClassification.Text, Convert.ToDateTime(dtpFirstAttach.Text), int.Parse(cbRank.SelectedValue.ToString()),
                                int.Parse(cbSarayaDept.SelectedValue.ToString()), byteImg,txtDebara.Text);

                            MessageBox.Show("تم الحفظ بنجاح");
                        this.soldiers_ViewTableAdapter.Fill(this.militaryViews_Dataset.Soldiers_View);
                    }


                    }
                }

                else
                    if(btnSaveSoldierData.Text== "حفظ التعديل")
                {
                    soldiers_ViewTableAdapter.UpdateSoldiersData(int.Parse(_Soldier_ID),int.Parse(txtMilitray_No.Text),txtSoldier_Name.Text,txtClassification.Text,Convert.ToDateTime(dtpFirstAttach.Text)
                        ,int.Parse(cbRank.SelectedValue.ToString()),int.Parse(cbSarayaDept.SelectedValue.ToString()),byteImg,txtDebara.Text,txtAttachDestination.Text,Convert.ToDateTime(dtpAttachDestDate.Text)
                        ,txtAttachType_Details.Text);

                    MessageBox.Show("تم التعديل بنجاح");
                this.soldiers_ViewTableAdapter.Fill(this.militaryViews_Dataset.Soldiers_View);
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }
    

        private void rdAttach_CheckedChanged(object sender, EventArgs e)
        {
            gbAttachData.Enabled = true;
            
        }

        private void rdNoneAttach_CheckedChanged(object sender, EventArgs e)
        {
            gbAttachData.Enabled = false;
        }

        public byte[] ImageToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            // FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            //BinaryReader br = new BinaryReader(fs);
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
           // ddd
            return ms.ToArray();
        }

        //public static void PerisitImage(string path)
        //{

        //        Image img = Image.FromFile(path);
        //        MemoryStream tmpStream = new MemoryStream();
        //        img.Save(tmpStream, ImageFormat.Jpeg); // change to other format
        //        tmpStream.Seek(0, SeekOrigin.Begin);
        //        byte[] imgBytes = new byte[90000000];
        //        tmpStream.Read(imgBytes, 0,90000000);

        //}

        //public byte[] DisplayPhoto(byte[] photo)
        //{
        //    if (!(photo == null))
        //    {
        //        MemoryStream tmpStream = new MemoryStream();
        //        img.Save(tmpStream, ImageFormat.Jpeg); // change to other format
        //        tmpStream.Seek(0, SeekOrigin.Begin);
        //        byte[] imgBytes = new byte[90000000];
        //        tmpStream.Read(imgBytes, 0, 90000000);
        //        return stream.ToArray();
        //    }
        //}

        private void txtMilitray_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Title = "أختيار صورة المجند";
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                imgLocation = open.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
               
                // image file path  
                textBox1.Text = open.FileName;
            }
        }

        private bool txtValdation()
        {
            if (txtMilitray_No.Text.Trim() == String.Empty)
                return true; // Returns true if no input or only space is found
            if (txtClassification.Text.Trim() == String.Empty)
                return true;
            if (txtSoldier_Name.Text.Trim() == String.Empty)
                return true;

            //if (txtAttachType_Details.Text.Trim() == String.Empty)
            //    return true;
            //if (pictureBox1.Text.Trim() == String.Empty)
            //    return true;

            // Other textBoxes.

            return false;
        }
    }
}
