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
    public partial class RequestsFrm : Form
    {
        public RequestsFrm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source= (local); Initial Catalog = VaccinationApp; Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();

        private void RequestsFrm_Load(object sender, EventArgs e)
        {
            cmd.Connection = con;
            try
            {
                LVReq.Items.Clear();
                con.Open();
                ListViewItem itm;
                cmd.CommandText = "SELECT * from [User] WHERE Pending = 'y'";
                SqlDataReader reader = cmd.ExecuteReader();
                string v = "";
                while (reader.Read())
                {
                    v = reader["VID"].ToString();
                    if (v.Equals("0"))
                        v = "Pfizer-BioNTech";
                    else if (v.Equals("1"))
                        v = "Johnson & Johnson’s Janssen";
                    else if (v.Equals("2"))
                        v = "Sputnik V";
                    else v = "AstraZeneca";

                    itm = new ListViewItem(reader["Username"].ToString());
                    itm.SubItems.Add(reader["Location"].ToString());
                    itm.SubItems.Add(reader["Age"].ToString());
                    itm.SubItems.Add(reader["Gender"].ToString());
                    itm.SubItems.Add(v);
                    LVReq.Items.Add(itm);
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (LVReq.SelectedItems.Count == 1)
            {
                grpAptInfo.Enabled = true;
            }
            else MessageBox.Show("Please select a request to approve");
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            if (LVReq.SelectedItems.Count == 0)
                MessageBox.Show("Please select a request to deny");
            else
            {
                string conString = "Data source = (local); Initial catalog = VaccinationApp;Integrated Security = True";
                SqlConnection conn = new SqlConnection(conString);
                string user = LVReq.SelectedItems[0].SubItems[0].Text;
                string Vaccine = LVReq.SelectedItems[0].SubItems[4].Text;
                
                string q = "INSERT INTO Appointment (Username, Vaccine, Status) VALUES ('" + user + "', '" + Vaccine + "', 'Denied');";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = q;

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
                updateUser();
                LVReq.SelectedItems[0].Remove();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string conString = "Data source = (local); Initial catalog = VaccinationApp;Integrated Security = True";
            SqlConnection conn = new SqlConnection(conString);
            string user = LVReq.SelectedItems[0].SubItems[0].Text;
            string date = datePicker.Text;
            string hospital = ComboHosp.SelectedItem.ToString();
            string Vaccine = LVReq.SelectedItems[0].SubItems[4].Text;

            string q = "INSERT INTO Appointment VALUES ('" + user + "', '" + date + "', '" + hospital + "', '" + Vaccine + "', 'Approved');";

            SqlCommand cmd = new SqlCommand(q, conn);

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
            updateUser();
            LVReq.SelectedItems[0].Remove();
            reset();
        }

        private void updateUser()
        {
            if (LVReq.SelectedItems.Count == 0)
                MessageBox.Show("Please select the person again!");
            else
            {
                string conString = "Data source = (local); Initial catalog = VaccinationApp;Integrated Security = True";
                SqlConnection conn = new SqlConnection(conString);

                string user = LVReq.SelectedItems[0].SubItems[0].Text;

                string q = "UPDATE [User] SET Pending = 'n' WHERE Username = '" + user + "'";
                SqlCommand cmd = new SqlCommand(q, conn);

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
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            LVReq.Enabled = true;
            grpAptInfo.Enabled = false;
        }
    }
}
