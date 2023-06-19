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
    public partial class AppointmentsFrm : Form
    {
        public AppointmentsFrm()
        {
            InitializeComponent();
        }

        private void AppointmentsFrm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source= (local); Initial Catalog = VaccinationApp; Integrated Security=True;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                LVApt.Items.Clear();
                con.Open();
                ListViewItem itm;
                cmd.CommandText = "SELECT * FROM Appointment";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    itm = new ListViewItem(reader["Username"].ToString());
                    itm.SubItems.Add(reader["Date"].ToString());
                    itm.SubItems.Add(reader["Hospital"].ToString());
                    itm.SubItems.Add(reader["Vaccine"].ToString());
                    itm.SubItems.Add(reader["Status"].ToString());
                    LVApt.Items.Add(itm);
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
