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
using System.Security.Cryptography;

namespace FinalProject
{
    public partial class FillingForm : Form
    {
        public FillingForm()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void VaccineBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVaccineBrand.SelectedIndex == 0)
            {
                 pictureBox1.Image = Image.FromFile("C:\\Users\\Marwa's PC\\Desktop\\Final Project\\FinalProject\\FinalProject\\Properties\\Vaccine Images\\thumbs_b_c_42480f6f1636bbf268f1be270b6c994e.jpg");

            }
            else if (comboVaccineBrand.SelectedIndex == 1)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Marwa's PC\\Desktop\\Final Project\\FinalProject\\FinalProject\\Properties\\Vaccine Images\\57193799_401.jpg");

            }
            else if (comboVaccineBrand.SelectedIndex == 2)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Marwa's PC\\Desktop\\Final Project\\FinalProject\\FinalProject\\Properties\\Vaccine Images\\index.jpg");

            }
            else if (comboVaccineBrand.SelectedIndex == 3)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Marwa's PC\\Desktop\\Final Project\\FinalProject\\FinalProject\\Properties\\Vaccine Images\\thumbs_b_c_1676c0174b24a87a4e8b0974294c6daf.jpg");

            }
        }



        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            string pass = txtPassword.Text;
            //pass = EnryptString(pass);
            string fName = txtFNane.Text;
            string lName = txtLName.Text;
            string username = txtUsername.Text;
            string location = ComboLocation.SelectedItem.ToString();
            int age = (int)nudAge.Value;
            string gender = comboGender.SelectedItem.ToString();
            string vaccine = comboVaccineBrand.SelectedIndex.ToString();

            Insert("INSERT INTO LOGIN VALUES ('" + username + "', '" + pass + "', 'n');");
            Insert("INSERT INTO[User] (FName, LName, Username, Location, Age, Gender, VID, Pending) values('" + fName + "', '" + lName + "', '" + username + "', '" + location + "', " + age + ", '" + gender + "', '" + vaccine + "', 'n')");

            txtFNane.Clear();
            txtLName.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            ComboLocation.SelectedIndex = -1;
            comboGender.SelectedIndex = -1;
            comboVaccineBrand.SelectedIndex = -1;
            nudAge.Value = 1;

        }

        private void Insert(string q)
        {
            string conString = "Data source = (local); Initial catalog = VaccinationApp;Integrated Security = True";
            SqlConnection conn = new SqlConnection(conString);

            SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = q
            };

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }

        private void FillingForm_Load(object sender, EventArgs e)
        {

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

    }
}
