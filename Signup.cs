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
using System.Text.RegularExpressions;

namespace HeroFitnessClub
{
    public partial class Signup : Form
    {
        int logIdCount, memIdCount;
        int myBodyId = 0;
        int myPackId = 0;
        public decimal jFee = 0.00M;
        public decimal mFee = 0.00M;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");

        int myNum = 0; string MyIDnum = ""; string myCell = "";
        string myName, mySurname, myEmail, myGndr, myPack;

        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
           // openPay();
            txtCell.Clear();
            txtCName.Clear();
            txtCSrn.Clear();
            txtEml.Clear();
            txtIDnum.Clear();
            getMemberNum();
            getPayType();
            getPack();
            getBodyType();
        }

        private void getMemberNum()
        {
           // memIdCount = 0;

          //  SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");
            con.Open();
            string query = "Select Max(Client_ID) from CLIENT";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    memIdCount = memIdCount + 1;
                    txtMemNum.Text = memIdCount.ToString("000000");
                }
                else
                {
                    memIdCount = Convert.ToInt32(dr[0].ToString());
                    memIdCount = memIdCount + 1;
                    txtMemNum.Text = memIdCount.ToString("000000");
                }
            }
            con.Close();
        }

        private void getPayType()
        {
            cmbPay.Items.Add("Cash/Card");
            cmbPay.Items.Add("EFT Transfer");
            cmbPay.Items.Add("Debit Order");
        }

        private void getPack()
        {
        //    SqlConnection SQLConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");
            con.Open();

            string query = "Select * FROM PACKAGES";
            SqlCommand SqlQuery = new SqlCommand(query, con);
            SqlDataAdapter myAdapter = new SqlDataAdapter();
            DataSet myDataSet = new DataSet();

           

            myAdapter.SelectCommand = SqlQuery;
            myAdapter.Fill(myDataSet, "PACKAGES");

            cmbPack.DataSource = myDataSet.Tables["PACKAGES"];
            cmbPack.DisplayMember = "Package_Desc";
            cmbPack.ValueMember = "Package_ID";

           // SqlCommand cmd = new SqlCommand(query, SQLConn);
           
            con.Close();
        }

        private void getBodyType()
        {
          //  SqlConnection SQLConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");

            SqlCommand SqlQuery = new SqlCommand(@"Select * FROM BODY_TYPE", con);
            SqlDataAdapter myAdapter = new SqlDataAdapter();
            DataSet myDataSet = new DataSet();

           con.Open();


            myAdapter.SelectCommand = SqlQuery;
            myAdapter.Fill(myDataSet, "BODY_TYPE");

           
            
            cmbGoal.ValueMember = "Body_Id";
            cmbGoal.DisplayMember = "BMI";
            cmbGoal.DataSource = myDataSet.Tables["BODY_TYPE"];

            con.Close();
                                    
        }

        private void btnRegstrC_Click(object sender, EventArgs e)
        {

            myGndr = "";
            if (radMale.Checked)
            {
                myGndr = "M";
            }
            else if (radFem.Checked)
            {
                myGndr = "F";
            }
            setBodyID();

            MyIDnum = txtIDnum.Text;

            myNum = Convert.ToInt32(txtMemNum.Text);
            myName = txtCName.Text;
            mySurname = txtCSrn.Text;

            myEmail = txtEml.Text;
            myCell = txtCell.Text;


            if (cmbPack.SelectedIndex > -1) //something was selected
            {

                myPackId = (int)cmbPack.SelectedValue;
            }
            else
            {
                MessageBox.Show("Please select Package");
            }

            if (cmbGoal.SelectedIndex > -1) //something was selected
            {

                myBodyId = (int)cmbGoal.SelectedValue;
            }
            else
            {
                MessageBox.Show("Please select Body type");
            }
            getFees();
            try
            {

               //

                con.Open();
                
                string insert_query = $"INSERT INTO CLIENT VALUES('{myNum}','{myName}', '{mySurname}',  '{MyIDnum}', '{myEmail}','{myCell}','{myGndr}', '{myBodyId}', '{myPackId}')";
                SqlDataAdapter myAdapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(insert_query, con);
                
                

                cmd.ExecuteNonQuery();
                savePasswd();
                con.Close();
                // MessageBox.Show("Data successfully inserted");

                this.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }


            openPay();

        }

        public void getFees()
        {
            try
            {
                //SqlConnection SQLConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");
                con.Open();

                string cmd = "Select * FROM PACKAGES where Package_Id = @myPackId";
                
                SqlCommand SqlQuery = new SqlCommand(cmd, con);

                SqlQuery.Parameters.AddWithValue("myPackId", myPackId) ;

                SqlDataReader dr = SqlQuery.ExecuteReader();
                if (dr.Read())
                {
                    myPack = dr[1].ToString();
                    jFee = (decimal)dr[2];
                    mFee = (decimal)dr[3];
                    
                }


            }
            catch (Exception)
            {
                MessageBox.Show("No Package Selected");
            }
        }

        private void txtEml_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(txtEml.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtEml.Select(0, txtEml.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderEmail.SetError(txtEml, errorMsg);
            }
            else
            {
                e.Cancel = false;
                errorProviderEmail.SetError(txtEml, "");
            }
        }

        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (emailAddress.Length == 0)
            {
                errorMessage = "Valid email address is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "email address must be valid email address format.\n" +
               "For example 'someone@example.com' ";
            return false;
        }

        private void txtCName_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidField(txtCName.Text, out errorMsg))
            {
                e.Cancel = true;
                txtCName.Focus();

                errorMsg = "Name" + errorMsg;
                // Set the ErrorProvider error with the text to display. 
                this.errorProviderName.SetError(txtCName, errorMsg);
            }
            else
            {
                e.Cancel = false;
                errorProviderName.SetError(txtCName, "");
            }
        }

        public bool ValidField(string field, out string errorMessage)
        {
            // Confirm that the string is not empty.
            if (field.Length == 0 || string.IsNullOrWhiteSpace(field))
            {
                errorMessage = " should not be left blank.";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
            
        }

        private void txtCSrn_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidField(txtCSrn.Text, out errorMsg))
            {
                e.Cancel = true;
                txtCSrn.Focus(); 

                errorMsg = "Surname" + errorMsg;
                // Set the ErrorProvider error with the text to display. 
                this.errorProviderSurname.SetError(txtCSrn, errorMsg);
            }
            else
            {
                e.Cancel = false;
                errorProviderSurname.SetError(txtCSrn, "");
            }
        }

        private void txtIDnum_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if ((!ValidField(txtIDnum.Text, out errorMsg)) || (txtIDnum.Text.Length != 13) || string.IsNullOrWhiteSpace(txtIDnum.Text))
            {
                e.Cancel = true;
                txtCSrn.Focus();

                errorMsg = "ID Number" + errorMsg;
                // Set the ErrorProvider error with the text to display. 
                this.errorProviderId.SetError(txtIDnum, errorMsg);
            }
            else
            {
                e.Cancel = false;
                errorProviderId.SetError(txtIDnum, "");
            }
        }

        private void txtCell_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidField(txtCell.Text, out errorMsg))
            {
                e.Cancel = true;
                txtCell.Focus(); 

                errorMsg = "Cell Number" + errorMsg;
                // Set the ErrorProvider error with the text to display. 
                this.errorProviderPhone.SetError(txtCell, errorMsg);
            }
            else
            {
                e.Cancel = false;
                errorProviderPhone.SetError(txtCell, "");
            }
        }

        
        private void radMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radMale.Checked || radFem.Checked)
            {
                errorProviderGender.SetError(panel1, "");
            }
        }

        private void radFem_CheckedChanged(object sender, EventArgs e)
        {
            if (radMale.Checked || radFem.Checked)
            {
                errorProviderGender.SetError(panel1, "");
            }
        }

        public void savePasswd()
        {

            int logId = getLogId();
            string usrNm = tbUserName.Text;
            string pass = tbUserPass.Text;

            try
            {
              //  SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");

                con.Open();
                
                string insert_query = $"INSERT INTO LOGINS VALUES('{logId}', '{memIdCount}',  '{usrNm}', '{pass}')";
                SqlDataAdapter myAdapter = new SqlDataAdapter();

                SqlCommand cmd = new SqlCommand(insert_query, con);


                cmd.ExecuteNonQuery();
                con.Close();
               // MessageBox.Show("password inserted");


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

         //   return true;

        }

        public void openPay()
        {

            MakePayment myNewForm = new MakePayment();
            myNewForm.PassingJoin = jFee;
            myNewForm.PassingMon = mFee;
            myNewForm.PassingNew = "New";
            myNewForm.PassingPackage = myPack;
            myNewForm.PassingClientID = memIdCount;
            myNewForm.ShowDialog();
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidField(tbUserName.Text, out errorMsg))
            {
                e.Cancel = true;
                tbUserName.Focus(); 

                errorMsg = "Username" + errorMsg;
                // Set the ErrorProvider error with the text to display. 
                this.errorProviderPhone.SetError(tbUserName, errorMsg);
            }
            else
            {
                e.Cancel = false;
                errorProviderPhone.SetError(tbUserName, "");
            }
        }

        private void tbUserPass_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "";
            
            if (!CheckPassword(tbUserPass.Text) || !ValidField(tbUserPass.Text, out errorMsg))
            {
                e.Cancel = true;
                tbUserPass.Select(0, tbUserPass.Text.Length);

                errorMsg = "Password should not be left blank." ;
                // Set the ErrorProvider error with the text to display. 
                this.errorProviderPhone.SetError(tbUserPass, errorMsg);
            }
            else
            {
                e.Cancel = false;
                errorProviderPhone.SetError(tbUserPass, "");
            }
        }

        private int getLogId()
        {
            logIdCount = 0;

          //  SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");
            con.Open();
            string query = "Select Max(Login_ID) from LOGINS";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    logIdCount = logIdCount + 1;
                    
                }
                else
                {
                    logIdCount = Convert.ToInt32(dr[0].ToString());
                    logIdCount = logIdCount + 1;
                }
            }
            con.Close();
            return logIdCount;
            
        }

        public bool CheckPassword(string password)
        {
                      
            if (password != null && password.Length > 8 )
            {

                return true;
            }
                
            else 
                return false;

        }
        public int setBodyID()
        {
             
        //    SqlConnection SQLConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");
            string query = "Select Body_ID,BMI FROM BODY_TYPE";
            SqlCommand SqlQuery = new SqlCommand(query, con);
            SqlDataAdapter myAdapter = new SqlDataAdapter();
            DataSet myDataSet = new DataSet();

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[1].ToString() == "18.50")
                {
                    myBodyId = (int)dr[0];
                }
                else if (dr[0].ToString() == "24.99")
                {
                    myBodyId = (int)dr[0];
                }
                if (dr[0].ToString() == "29.90")
                {
                    myBodyId = (int)dr[0];
                }
                else
                {
                    myBodyId = (int)dr[0];
                }

            }
            con.Close();
            return myBodyId;

        }




    }
}