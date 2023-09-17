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
using NLHBaseWindow;

namespace NLHospital
{
    public partial class frmAdmissions : NLHBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PNOASJ4\SQLEXPRESS;Initial Catalog=NLH;Integrated Security=True");
        public frmAdmissions()
        {
            InitializeComponent();
        }

        public void displayTableAdmissions()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM AdmissionRecords";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }

        public void displayTablePatients()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Patients";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }
        public void displayTableExtras()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Extras";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }


        private void AddAdmissionRecordbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_INSERT_AdmissionRecords", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("AdmissionID", SqlDbType.VarChar).Value = AdmissionIDtxt.Text;
                cmd.Parameters.AddWithValue("PatientID", SqlDbType.VarChar).Value = APatientIDtxt.Text;
                cmd.Parameters.AddWithValue("BedNumber", SqlDbType.VarChar).Value = BedNumbertxt.Text;
                cmd.Parameters.AddWithValue("SurgeryScheduled", SqlDbType.Bit).Value = SurgeryScheduledtxt.Text;
                cmd.Parameters.AddWithValue("AdmitDate", SqlDbType.DateTime).Value = Convert.ToDateTime(AdmitDatetxt.Text);
                cmd.Parameters.AddWithValue("SurgeryDate", SqlDbType.DateTime).Value = Convert.ToDateTime(SurgeryDatetxt.Text);
                cmd.Parameters.AddWithValue("DischargeDate", SqlDbType.DateTime).Value = Convert.ToDateTime(DischargeDatetxt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New admission has been recorded.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
                displayTableAdmissions();
            }
        }

        private void AddPatientbtn_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_INSERT_Patients", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("PatientID", SqlDbType.VarChar).Value = PatientIDtxt.Text;
                cmd.Parameters.AddWithValue("HealthNumber", SqlDbType.VarChar).Value = HealthNumbertxt.Text;
                cmd.Parameters.AddWithValue("DateOfBirth", SqlDbType.VarChar).Value = DateOfBirthtxt.Text;
                cmd.Parameters.AddWithValue("LastName", SqlDbType.VarChar).Value = LNtxt.Text;
                cmd.Parameters.AddWithValue("FirstName", SqlDbType.VarChar).Value = FNtxt.Text;
                cmd.Parameters.AddWithValue("Address", SqlDbType.VarChar).Value = Addresstxt.Text;
                cmd.Parameters.AddWithValue("City", SqlDbType.VarChar).Value = Citytxt.Text;
                cmd.Parameters.AddWithValue("Province", SqlDbType.VarChar).Value = Provincetxt.Text;
                cmd.Parameters.AddWithValue("PostalCode", SqlDbType.VarChar).Value = PostalCodetxt.Text;
                cmd.Parameters.AddWithValue("Phone", SqlDbType.VarChar).Value = Phonetxt.Text;
                cmd.Parameters.AddWithValue("InsuranceCompany", SqlDbType.VarChar).Value = InsuranceCompanytxt.Text;
                cmd.Parameters.AddWithValue("InsuranceNumber", SqlDbType.VarChar).Value = InsuranceNumbertxt.Text;
                cmd.Parameters.AddWithValue("NextOfKin", SqlDbType.VarChar).Value = NextOfKintxt.Text;
                cmd.Parameters.AddWithValue("NextOfKinRelationship", SqlDbType.VarChar).Value = NOKRelationshiptxt.Text;
                cmd.Parameters.AddWithValue("Doctor", SqlDbType.VarChar).Value = Doctortxt.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient has been succesfully added to the table.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                displayTablePatients();
            }
        }

        private void findbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Patients WHERE PatientID='" + PatientIDtxt.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void AddExtrasbtn_Click(object sender, EventArgs e)
        {
            var TV = 0;
            var Phone = 0;
            var SP = 0;
            var priv = 0;
            var ward = 0;
            try
            {
                if (TVrbtn.Checked)
                {
                    TV = 1;
                }
                if (Phonerbtn.Checked)
                {
                    Phone = 1;
                }
                if (SPrbtn.Checked)
                {
                    SP = 1;
                }
                if (Privaterbtn.Checked)
                {
                    priv = 1;
                }
                if (Wardrbtn.Checked)
                {
                    ward = 1;
                }

                con.Open();
                SqlCommand cmd = new SqlCommand("SP_INSERT_Extras", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("PatientID", SqlDbType.VarChar).Value = EPatientIDtxt.Text;
                cmd.Parameters.AddWithValue("AdmissionRecordID", SqlDbType.VarChar).Value = AdmissionRecordIDtxt.Text;
                cmd.Parameters.AddWithValue("TV", SqlDbType.Bit).Value = TV;
                cmd.Parameters.AddWithValue("Phone", SqlDbType.Bit).Value = Phone;
                cmd.Parameters.AddWithValue("SemiPrivate", SqlDbType.Bit).Value = SP;
                cmd.Parameters.AddWithValue("Private", SqlDbType.Bit).Value = priv;
                cmd.Parameters.AddWithValue("Ward", SqlDbType.Bit).Value = ward;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Extras has been succesfully added to the table.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                displayTableExtras();
            }
        }
    }
}
