using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroFitnessClub
{
    public partial class SignContract : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");

        string Fnamestring, Snamestring, IDNumstring, Emailstring, Cellstring, package;

        int accIdCount = 0;
        int conIdCount = 0;
        int clntId = 0;
        public decimal monFee;
        

        private DateTime paydate = DateTime.Now;
        public bool AccStatus = false;

        public SignContract()
        {
            InitializeComponent();
        }

        public int PassingClientID
        {
            get { return clntId; }
            set { clntId = value; }
        }

        public decimal PassingMonFee
        {
            get { return monFee; }
            set { monFee = value; }
        }

        public string PassingPackage
        {
            get { return package; }
            set { package = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getAccId();
            getConId();
            AccStatus = true;
            writeAccount();


            this.Close();
        }

        private void SignContract_Load(object sender, EventArgs e)
        {

            getCData();
            textBox1.Text = "This contract in entered into by and between HERO FITNESS CLUB " +
                "and " + Fnamestring + " " + Snamestring + ".  The client is on package: " + package +
                " and the monthly amount to be paid is R" + monFee.ToString("F") + ". " +
                "The contract commences on " + DateTime.Now.ToString("dddd, dd MMMM yyyy") + ". " +
                "Clicking on the button below serves as an agreement to this contract";

        }

        public void writeAccount()
        {
            try
            {
                paydate = DateTime.Now;
               
                con.Open();

                string insert_query = "INSERT INTO ACCOUNT(Account_ID,Client_ID,Date_Created,AccStatus) VALUES(@accIdCount,@clntId, @paydate, @AccStatus)";
                SqlDataAdapter myAdapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(insert_query, con);

                cmd.Parameters.AddWithValue("@accIdCount", accIdCount);
                cmd.Parameters.AddWithValue("@clntId", clntId);
                cmd.Parameters.AddWithValue("@paydate", paydate);
                cmd.Parameters.AddWithValue("@AccStatus", AccStatus);


                cmd.ExecuteNonQuery();
                con.Close();

                writeContract();

                MessageBox.Show("Account activated");
            }
            catch (Exception)
            {
                MessageBox.Show("Could not save record. ");


            }

        }

        private int getAccId()
        {
            accIdCount = 0;

           // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");
            con.Open();
            string query = "Select Max(Payment_ID) from PAYMENT";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    accIdCount = accIdCount + 1;

                }
                else
                {
                    accIdCount = Convert.ToInt32(dr[0].ToString());
                    accIdCount = accIdCount + 1;
                }
            }
            con.Close();
            return accIdCount;

        }


        private int getConId()
        {
            conIdCount = 0;

           // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");
            con.Open();
            string query = "Select Max(Contract_ID) from CONTRACTS";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    conIdCount = conIdCount + 1;

                }
                else
                {
                    conIdCount = Convert.ToInt32(dr[0].ToString());
                    conIdCount = conIdCount + 1;
                }
            }
            con.Close();
            return conIdCount;

        }

        public void getCData()
        {
            try
            {
                con.Open();
                string query = "Select * FROM CLIENT WHERE Client_ID = @clntId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@clntId", clntId);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    Fnamestring = dr[1].ToString();
                    Snamestring = dr[2].ToString();
                    IDNumstring = dr[3].ToString();
                    Emailstring = dr[4].ToString();
                    Cellstring = dr[5].ToString();
                    package = dr[8].ToString();
                }

                con.Close();
            }
            catch (Exception er)
            { MessageBox.Show(er.Message); }
        }

        private void SignContract_FormClosing(object sender, FormClosingEventArgs e)
        {
            AccStatus = false;
            writeAccount();
        }

        public void writeContract()
        {

            con.Open();

            string insert_query1 = "INSERT INTO CONTRACTS(Contract_ID,Client_ID,Date_Signed) VALUES(@conIdCount,@clntId, @paydate)";
            SqlDataAdapter myAdapter1 = new SqlDataAdapter();
            SqlCommand cmd1 = new SqlCommand(insert_query1, con);

            cmd1.Parameters.AddWithValue("@conIdCount", conIdCount);
            cmd1.Parameters.AddWithValue("@clntId", clntId);
            cmd1.Parameters.AddWithValue("@paydate", paydate);


            cmd1.ExecuteNonQuery();
            con.Close();
        }
    }
}
