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
    public partial class MakePayment : Form
    {
        int payIdCount = 0;
        int clntId = 0;
        string mFee = "";
        string package = "";

        DateTime paydate;

        decimal fee = 0.0M;
        public decimal joinFee = 0.0M;
        public decimal monFee = 0.0M;
        public string status = "";

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");


        public MakePayment()
        {
            InitializeComponent();
        }

        public decimal PassingJoin
        {
            get { return joinFee; }
            set { joinFee = value; }
        }

        public decimal PassingMon
        {
            get { return monFee; }
            set { monFee = value; }
        }

        public string PassingNew
        {
            get { return status; }
            set { status = value; }
        }

        public int PassingClientID
        {
            get { return clntId; }
            set { clntId = value; }
        }

        public string PassingPackage
        {
            get { return package; }
            set { package = value; }
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
           
                insertPayment();
                openContract();
                this.Close();
             
            
            
        }


        private void insertPayment()
        {
            getPayId();


            paydate = DateTime.Now;

            try
            {
                
                con.Open();

                string insert_query = "INSERT INTO PAYMENT (Payment_ID,Client_ID,Payment_Amount,Payment_Date) VALUES(@Payment_ID,@Client_ID,@Payment_Amount,@Payment_Date)";
              //  SqlDataAdapter myAdapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(insert_query, con);

                cmd.Parameters.AddWithValue("@Payment_ID", payIdCount);
                cmd.Parameters.AddWithValue("@Client_ID", clntId);
                cmd.Parameters.AddWithValue("@Payment_Amount", fee);
                cmd.Parameters.AddWithValue("@Payment_Date", paydate);


                cmd.ExecuteNonQuery();
                con.Close();
                             

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }


        }

        private void openContract()
        {
            SignContract myNewForm2 = new SignContract();
            myNewForm2.PassingMonFee = fee;
            myNewForm2.PassingClientID = clntId;
            myNewForm2.PassingPackage = package;
            myNewForm2.ShowDialog();

        }

        private int getPayId()
        {
            payIdCount = 0;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");
            con.Open();
            string query = "Select Max(Payment_ID) from PAYMENT";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    payIdCount = payIdCount + 1;

                }
                else
                {
                    payIdCount = Convert.ToInt32(dr[0].ToString());
                    payIdCount = payIdCount + 1;
                }
            }
            con.Close();
            return payIdCount;

        }

        private void MakePayment_Load(object sender, EventArgs e)
        {
            setFee();
            lblAmount.Text = lblAmount.Text + " R " + fee;
        }

        public void setFee()
        {
            string feestring;
            if (status == "New")
            {
                fee = joinFee + monFee;

            }        
            else
            { 
                  fee = monFee;
            }

            feestring = fee.ToString("F");
            mFee = feestring;
            fee = Convert.ToDecimal(feestring);

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;



            if (!ValidField(textBox1.Text, out errorMsg) || (textBox1.Text.Length != 16) || !textBox1.Text.All(char.IsDigit))
            {
                e.Cancel = true;
                textBox1.Focus();

                errorMsg = "Number" + errorMsg;
                // Set the ErrorProvider error with the text to display. 
                this.errorProviderCardNum.SetError(textBox1, errorMsg);
            }
            else
            {
                e.Cancel = false;
                errorProviderCardNum.SetError(textBox1, "");
                      
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidField(textBox2.Text, out errorMsg) || !textBox2.Text.All(char.IsLetter))
            {
                e.Cancel = true;
                textBox2.Focus();

                errorMsg = "Name" + errorMsg;
                // Set the ErrorProvider error with the text to display. 
                this.errorProviderCardNum.SetError(textBox2, errorMsg);
            }
            else
            {
                e.Cancel = false;
                errorProviderCardNum.SetError(textBox2, "");
            }
        }


        public bool ValidField(string field, out string errorMessage)
        {
            // Confirm that the string is not empty.
            if (field.Length == 0 || string.IsNullOrWhiteSpace(field) )
            {


                errorMessage = " should not be blank and must have 16 numbers";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }

        }

        private void numericUpDown2_Validating(object sender, CancelEventArgs e)
        {
            decimal val = numericUpDown1.Value;

            decimal val2 = numericUpDown2.Value;

            string errorMsg;

            if (val.ToString() == "0" || val2.ToString() == "0")
            {
                e.Cancel = true;
                numericUpDown2.Focus();

                errorMsg = "Month and Year are both required";
                // Set the ErrorProvider error with the text to display. 
                this.errorProviderDate.SetError(numericUpDown2, errorMsg);
            }
            else
            {
                e.Cancel = false;
                errorProviderDate.SetError(numericUpDown2, "");
            }
        }
        
    }
}
