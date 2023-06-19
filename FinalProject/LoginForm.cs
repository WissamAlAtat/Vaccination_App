using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Btn_ExitMainForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string user = txtUserName.Text;
            string pass = txtPassword.Text;

            string conString = "Data source = (local); Initial catalog = VaccinationApp;Integrated Security = True";
            SqlConnection conn = new SqlConnection(conString);

            string isAdminQuery = "SELECT * FROM Login WHERE UserName = '" + user + "' AND Password = '" + pass + "'";

            SqlCommand cmd = new SqlCommand(isAdminQuery, conn);

            try
            {
                conn.Open();
                SqlDataReader r = cmd.ExecuteReader();

                if (r.Read())
                {
                    if (r["IsAdmin"].ToString() == "y")
                    {
                        ClearSignin();
                        RequestsFrm a1 = new RequestsFrm();
                        a1.Show();
                    }
                    else
                    {
                        ClearSignin();
                        AppointmentsFrm apt = new AppointmentsFrm();
                        apt.Show();
                    }
                }
                else
                {
                    ClearSignin();
                    MessageBox.Show("User does not exist");
                }

                r.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void ClearSignin()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            ClearSignin();
            FillingForm frm = new FillingForm();
            frm.Show();
        }

        /*public  string DecryptString(string encrString)
        {
            byte[] b;
            string decrypted;
            try
            {
                b = Convert.FromBase64String(encrString);
                decrypted = System.Text.ASCIIEncoding.ASCII.GetString(b);
            }
            catch 
            {
                decrypted = "";
            }
            return decrypted.ToLower();
        }

        public  string EnryptString(string strEncrypted)
        {
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(strEncrypted);
            string encrypted = Convert.ToBase64String(b);
            return encrypted.ToLower();
        }*/

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
