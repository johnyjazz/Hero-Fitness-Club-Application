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

namespace HeroFitnessClub
{
    public partial class Login : Form
    {
        string Fnamestring, Snamestring, IDNumstring, Emailstring, Cellstring, package,accstate;
        string usernm, passwd;
        int cid = 0;
        int clntId = 0;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HeroFitness.mdf;Integrated Security=True");


        public Login()
        {
            InitializeComponent();

        }

        private void btnLgn_Click(object sender, EventArgs e)
        {
            usernm = txtUser.Text.ToLower();
          
            passwd = txtPass.Text;


            if (usernm == "admin")
            {
                Admin myNewForm = new Admin();
                myNewForm.ShowDialog();
            }

            else //if (usernm != "admin")
            {
                if (usernm == "" || passwd == "")
                {

                    MessageBox.Show("username/password cant be empty");
                    //   Admin myNewForm = new Admin();
                    //    myNewForm.ShowDialog();

                    txtUser.Clear();
                    txtPass.Clear();

                }

                if (CheckPasswd(usernm, passwd))
                {
                    
                        getCData();
                        //  MessageBox.Show(cid+" - " + package);
                        getAccData();
                        getpackID();

                        openClient();
                    

                }
                else
                { MessageBox.Show("Incorrect username/password combination "); }

                txtUser.Clear();
                txtPass.Clear();
            }
            
        }

        private void openClient()
        {
            Client myCForm = new Client();
            myCForm.PassingClientID = cid;
            myCForm.PassingState = accstate;
            myCForm.PassingPackage = package;
            myCForm.ShowDialog();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            Signup myNewForm = new Signup();
            myNewForm.ShowDialog();
        }

        private bool CheckPasswd(string usernme, string passwrd)
        {
            
            bool val = false;

            string usernms = usernme;
            
            try
            {
                 con.Open();
                string query = "Select * from LOGINS where Username = @usernms";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@usernms", usernms);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    cid = Convert.ToInt32(dr[1].ToString());
                    string userVal = dr[2].ToString().ToLower();
                    string passVal = dr[3].ToString();


                    if (userVal == usernme && passVal == passwrd)
                    {
                        val = true;
                    }
                    else
                    {
                        
                        val = false;
                    }
                }
                con.Close();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            return val;
        }



        public void getCData()
        {
            try 
            { 
                con.Open();
                string query = "Select * FROM CLIENT WHERE Client_ID = @clntId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@clntId", cid);

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
            catch(Exception er)
            { MessageBox.Show(er.Message); }
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

                if (dr[3].ToString() == "1")
                {
                    accstate = "ACTIVE";
                }
                else
                { accstate = "INACTIVE"; }

            }
            else
            { accstate = "No Contract"; }



            con.Close();
        }

        public void getpackID()
        {
           
            try
            {
                con.Open();
                string query = "Select Package_ID from PACKAGES where Package_ID =@package";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@package", package);
                SqlDataReader dr = cmd.ExecuteReader();
            }
            catch (Exception)
            { MessageBox.Show("No Package for Client " + cid); }

            con.Close();
        }
    }
}
