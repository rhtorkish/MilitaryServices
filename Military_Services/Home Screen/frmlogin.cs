using Military_Services.Database_Connection;
using Military_Services.Database_Connection.militaryDatasetTableAdapters;
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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            militaryDataset.UesrLoginDataTable DtTech = new militaryDataset.UesrLoginDataTable();
            //UesrLoginTableAdapter Login = new UesrLoginTableAdapter();

            //  LdapAuthentication Ldap = new LdapAuthentication("LDAP://dalgroup.com");

            if (UserValdation())
            {
                MessageBox.Show("يجب مل الحقول");
            }
            else
            {
                //  string Name = Ldap.IsAuthenticated("DALGROUP", txtUserName.Text, txtPassword.Text);
                if (Name != "")
                {

                    if (uesrLoginTableAdapter.Userlogin(DtTech, txtPassword.Text).ToString() == "1")
                    {
                        string Tech_Id = DtTech.Rows[0]["id"].ToString();
                        //string Tech_Email = DtTech.Rows[0]["Tech_Email"].ToString();
                       

                       Home_Screen.mainscreen mngScreen = new Home_Screen.mainscreen();
                        mngScreen.ShowDialog();

                        //Devices newDevice = new Devices(txtUserName.Text, Tech_Id);
                        //mngScreen.Show();
                        //this.Hide();

                    }

                    else

                        MessageBox.Show("الرجاء التأكد من اسم المستخدم وكلمة المرور");
                    txtPassword.Clear();
                    txtUserName.Focus();
                }


                
                }
            }    
            
            
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }

        
        
        private bool UserValdation()
        {
            if (txtPassword.Text.Trim() == string.Empty)
                return true;
            if (txtUserName.Text.Trim() == string.Empty)
                return true;

            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
