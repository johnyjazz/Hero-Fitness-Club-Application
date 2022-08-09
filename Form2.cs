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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HeroFitness.mdf;Integrated Security=True");
        SqlDataAdapter myAdapter;
        DataSet myDataSet;
        string memNum;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegstr_Click(object sender, EventArgs e)
        {
            int myNum, myAge, MyIDnum, myCell, myCode;
            string myName, mySurname, myEmail, myGndr, myPack, myAddress, myPay, myBGoal;

            myNum = Convert.ToInt32(txtMemNum.Text);

            myName = txtCName.Text;
            mySurname = txtCSrn.Text;
            myAge = Convert.ToInt32(txtCAge.Text);

            MyIDnum = (int)Convert.ToInt64(txtIDnum.Text);
            myEmail = txtEml.Text;
            myCell = (int)Convert.ToInt64(txtCell.Text);

            myGndr = "";
            if (radMale.Checked)
            {
                myGndr = "Male";
            }
            else if (radFem.Checked)
            {
                myGndr = "Female";
            }
            else
            {
                MessageBox.Show("Please select Gender");
            }

            myAddress = txtAdrs1.Text + ", " + txtAdrs2.Text;
            myCode = Convert.ToInt32(txtAdCod.Text);

            myPack = "" + cmbPack.SelectedValue;
            myPay = "" + cmbPay.SelectedValue;
            myBGoal = "" + cmbGoal.SelectedValue;

            try
            {
                con.Open();

                string insert_query = "INSERT INTO ClientMaster VALUES('" + myNum + "','" + myName + "', '" + mySurname + "', '" + myAge + "','" + myEmail + "','" + myCell + "','" + myGndr + "','" + myAddress + "', '" + myCode + "', '" + myPack + "', '" + myPay + "', '" + myBGoal + "', '" + MyIDnum + "')";
                myAdapter = new SqlDataAdapter();

                SqlCommand cmd = new SqlCommand(insert_query, con);


                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data successfully inserted");

                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            
            loadSearch();
            getMemberNum();


            //con.Close();
        }

        private void getMemberNum()
        {
            //con.Open();
            string query = "Select memberNumber from ClientMaster order by memberNumber desc";
            

            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                memNum = id.ToString("00000");
            }
            else if (Convert.IsDBNull(dr))
            {
                memNum = "00001";
            }
            else
            {
                memNum = "00001";
            }

            con.Close();

            txtMemNum.Text = memNum.ToString();
            txtAdrs1.Clear();
            txtAdCod.Clear();
            txtAdrs2.Clear();
            txtCAge.Clear();
            txtCell.Clear();
            txtCName.Clear();
            txtCSrn.Clear();
            txtEml.Clear();
            txtIDnum.Clear();
            
        }

        private void getPayType() 
        {
            cmbPay.Items.Add("Cash/Card");
            cmbPay.Items.Add("EFT Transfer");
            cmbPay.Items.Add("Debit Order");
        }
        private void getPack()
        {
            cmbPack.Items.Add("Student - A");
            cmbPack.Items.Add("Student - B");
            cmbPack.Items.Add("Student - C");

            cmbPack.Items.Add("Month1 - A");
            cmbPack.Items.Add("Month2 - B");
            cmbPack.Items.Add("Month3 - C");

            cmbPack.Items.Add("Contract - A");
            cmbPack.Items.Add("Contract - B");
            cmbPack.Items.Add("Contract - C");

        }
        private void getBodyGoal()
        {
            cmbGoal.Items.Add("Weight loss");
            cmbGoal.Items.Add("Toning");
            cmbGoal.Items.Add("Muscle Gain");
            cmbGoal.Items.Add("Endurance");            
        }

        private void loadSearch()
        {
            con.Open();
            SqlCommand SqlQuery = new SqlCommand(@"Select FORMAT(memberNumber,'00000') as [Membership Number], Name,  Surname FROM ClientMaster", con);
            myAdapter = new SqlDataAdapter();
            myDataSet = new DataSet();

            myAdapter.SelectCommand = SqlQuery;
            myAdapter.Fill(myDataSet, "ClientMaster");

            dtgSearch.DataSource = myDataSet;
            dtgSearch.DataMember = "ClientMaster";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con.Open();
            getMemberNum();
            getPayType();
            getPack();
            getBodyGoal();
            con.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "Select FORMAT(memberNumber,'00000') as [Membership Number], Name,  Surname FROM ClientMaster WHERE Name like '%" + textBox1.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "ClientMaster");
            dtgSearch.DataSource = ds;
            dtgSearch.DataMember = "ClientMaster";
        }
    }
}
