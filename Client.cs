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
    public partial class Client : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");
        //  SqlDataAdapter myAdapter = new SqlDataAdapter();

        int clntId = 0;
        string accstate;
        string package = "";
        decimal monFee = 0.0M;
        public bool conState = false;
        
        public Client()
        {
            InitializeComponent();
        }


        public int PassingClientID
        {
            get { return clntId; }
            set { clntId = value; }
        }

        public string PassingState
        {
            get { return accstate; }
            set { accstate = value; }
        }

        public string PassingPackage
        {
            get { return package; }
            set { package = value; }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            loadForm();
            
        }

        private void getCData()
        {

            con.Open();
            string query = "Select * FROM CLIENT WHERE Client_ID = @clntId";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@clntId", clntId);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtMemNum.Text = dr[0].ToString();
                txtCName.Text = dr[1].ToString();
                txtCSrn.Text = dr[2].ToString();
                txtIDnum.Text = dr[3].ToString();
                txtEml.Text = dr[4].ToString();
                txtCell.Text = dr[5].ToString();

            }
            con.Close();
        }

        private void getAccData()
        {

            con.Open();
            string query = "Select * FROM ACCOUNT WHERE Account_ID = @clntId";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@clntId", clntId);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                accstate = dr[3].ToString();

            }
            con.Close();
        }
       

        private void openContract()
        {
            SignContract myNewForm2 = new SignContract();
            myNewForm2.PassingMonFee = monFee;
            myNewForm2.PassingMonFee = monFee;
            myNewForm2.PassingClientID = clntId;
            myNewForm2.PassingPackage = package;
            myNewForm2.ShowDialog();

        }

        private void checkContract()
        {
            con.Open();
            string query = "Select * FROM CONTRACTS WHERE Contract_ID = @clntId";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@clntId", clntId);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                conState = true;

            }
            else
            { conState = false; }
            con.Close();
        }

        public void getFees()
        {
            try
            {
                //    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");
                con.Open();

                string cmd = "Select * FROM PACKAGES where Package_Id = @myPackId";

                SqlCommand SqlQuery = new SqlCommand(cmd, con);

                SqlQuery.Parameters.AddWithValue("myPackId", package);

                SqlDataReader dr = SqlQuery.ExecuteReader();
                if (dr.Read())
                {
                 //   myPack = dr[1].ToString();
                 //   jFee = (decimal)dr[2];
                    monFee = (decimal)dr[3];

                }


            }
            catch (Exception)
            {
                MessageBox.Show("No Package Selected");
            }
        }

        public void openPay()
        {

            MakePayment myNewForm = new MakePayment();
          //  myNewForm.PassingJoin = jFee;
            myNewForm.PassingMon = monFee;
            myNewForm.PassingNew = "Existing";
            myNewForm.PassingPackage = package;
            myNewForm.PassingClientID = clntId;
            myNewForm.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            openPay();
            getAccData();
            loadForm();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            openContract();
            getAccData();
            loadForm();
        
        }
        private void loadForm()
        {
            getCData();
            getFees();


            if (accstate == "" || accstate == null)
            {
                accstate = "INACTIVE";
            }

            textBox1.Text = accstate;

            checkContract();
            if (accstate == "ACTIVE")
            {
                button2.Hide();
                button1.Hide();

            }
            else if (accstate == "INACTIVE")
            {
                button2.Hide();
            }
            else if (accstate == "No Contract")
            {
                button1.Hide();
            }

        }
    }
}
