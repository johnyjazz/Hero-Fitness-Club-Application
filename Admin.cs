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
    public partial class Admin : Form
    {
        /*
         *  MPHO KUALI (33526966) 
            SR MASHAPA (36951250) – Deregistered
            J MOTSAMAI (34835296) 
            MP RAMOGALE (35074744)

         * 
         * 
        */



        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");
        SqlDataAdapter myAdapter = new SqlDataAdapter();
        int packIdCount = 0;
        int gridID = 0;
        int accID = 0;
        int packID = 0;

        decimal joinfee = 0.00m;
        decimal monfee = 0.00m;

        string packDesc,Fnamestring, Snamestring, IDNumstring, Emailstring, Cellstring;

        string packIdString = "";
        string packDescString = "";
        decimal packJoinString = 0.00m;
        decimal packMonString = 0.00m;

        public Admin()
        {
            InitializeComponent();
        }

        private void getData()  // To show the data in the DataGridView  
        {
            con.Open();
            string query = "Select * FROM CLIENT";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "CLIENT");
            dtgSearch.DataSource = ds;
            dtgSearch.DataMember = "CLIENT";
            con.Close();
        }

        public void getPackages()  // To show the data in the DataGridView  
        {
            con.Open();
            string query = "Select * FROM PACKAGES";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "PACKAGES");
            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = "PACKAGES";
            con.Close();

        }


        private void getMemberNum()
        {

            int memIdCount = 0;

        //    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");
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
                    
                }
                else
                {
                    memIdCount = Convert.ToInt32(dr[0].ToString());
                    memIdCount = memIdCount + 1;
                   
                }
            }

            con.Close();
                        
        }

        private void getPackNum()
        {

        //    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");
            con.Open();
            string query = "Select Max(Package_ID) from PACKAGES";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    packIdCount = 10000;
                    packIdCount = packIdCount + 1;

                }
                else
                {
                    packIdCount = Convert.ToInt32(dr[0].ToString());
                    packIdCount = packIdCount + 1;

                }
            }

            con.Close();

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HeroFitnessDataSet2.DataTable1' table. You can move, or remove it, as needed.
           
            // con.Open();
            getMemberNum();
            getPackages();
           // this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * FROM CLIENT WHERE FirstName like '%" + tbSrchName.Text + "%'";
           
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "CLIENT");
            dtgSearch.DataSource = ds;
            dtgSearch.DataMember = "CLIENT";
            con.Close();
        }

        

        private void txbSurnmae_TextChanged(object sender, EventArgs e)
        {
            clientSearch(txbSurnmae.Text);
        }

        private void txbClientId_TextChanged(object sender, EventArgs e)
        {
           
            con.Open();
            string query = "Select * FROM CLIENT WHERE Client_ID like '%" + txbClientId.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "CLIENT");
            dtgSearch.DataSource = ds;
            dtgSearch.DataMember = "CLIENT";
            con.Close();
        }

       

        private void clientSearch(string field)
        {
            con.Open();
            string query = "Select * FROM CLIENT WHERE Surname like '%" + field + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "CLIENT");
            dtgSearch.DataSource = ds;
            dtgSearch.DataMember = "CLIENT";
            con.Close();
        }

        private void dtgSearch_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gridID = Convert.ToInt32(dtgSearch.Rows[e.RowIndex].Cells[0].Value.ToString());
            Fnamestring = dtgSearch.Rows[e.RowIndex].Cells[1].Value.ToString();
            Snamestring = dtgSearch.Rows[e.RowIndex].Cells[2].Value.ToString();
            IDNumstring = dtgSearch.Rows[e.RowIndex].Cells[3].Value.ToString();
            Emailstring = dtgSearch.Rows[e.RowIndex].Cells[4].Value.ToString();
            Cellstring = dtgSearch.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (accID != 0)
            {
                con.Open();
                string query = "Select * FROM ACCOUNT";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "ACCOUNT");
                dtgSearch.DataSource = ds;
                dtgSearch.DataMember = "ACCOUNT";
                con.Close();

                try
                {
                    con.Open();
                    string deleteSQL = "DELETE ACCOUNT WHERE Client_ID = @accID";

                    SqlCommand cmd = new SqlCommand(deleteSQL, con);
                    cmd.Parameters.AddWithValue("@accID", accID);

                    int numberOfRows = cmd.ExecuteNonQuery();
                    MessageBox.Show(numberOfRows + " Record(s) deleted Successfully");

                    cmd.Dispose();
                    con.Close();

                }
                catch (Exception)
                { MessageBox.Show("Record not deleted"); }

            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void dtgAccounts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            accID = Convert.ToInt32(dtgAccounts.Rows[e.RowIndex].Cells[1].Value.ToString());

            try
            {
             //   SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\u722691\Documents\john\2nd year\1st semester\Hero Fitness\HeroFitnessClub\HeroFitness.mdf;Integrated Security=True");
                con.Open();
                string query = "Select * FROM CLIENT WHERE Client_ID = '" + accID + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr[1].ToString();
                    textBox4.Text = dr[2].ToString();
                    
                }
                con.Close();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * FROM ACCOUNT WHERE AccStatus like '%" + textBox3.Text + "%'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "ACCOUNT");
            dtgAccounts.DataSource = ds;
            dtgAccounts.DataMember = "ACCOUNT";
            con.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * FROM ACCOUNT WHERE Client_ID like '%" + textBox1.Text + "%'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "ACCOUNT");
            dtgAccounts.DataSource = ds;
            dtgAccounts.DataMember = "ACCOUNT";
            con.Close();
        }

        private void buttonUpdatePack_Click(object sender, EventArgs e)
        {
          

            if (packID != 0)
            {
                packIdString = textBox8.Text;
                packDescString = textBox7.Text;
                packJoinString = Convert.ToDecimal(textBox6.Text);
                packMonString = Convert.ToDecimal(textBox5.Text);

                if (packIdString != "")
                {
                    updatePackDetails();
                }

                
                getPackages();
            }

            else 
            {
                MessageBox.Show("Select Row to update");
            }
            

            
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            packID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            packDesc = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            joinfee = (decimal)dataGridView2.Rows[e.RowIndex].Cells[2].Value;
            monfee = (decimal)dataGridView2.Rows[e.RowIndex].Cells[3].Value;



            textBox8.Text = packID.ToString();
            textBox7.Text = packDesc.ToString();
            textBox6.Text = joinfee.ToString();
            textBox5.Text = monfee.ToString();

        /*    textBox8.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox5.ReadOnly = true;*/
        }

        private void btnInsertPack_Click(object sender, EventArgs e)
        {
            getPackNum();

            packDescString = textBox7.Text;
            packJoinString = Convert.ToDecimal(textBox6.Text);
            packMonString = Convert.ToDecimal(textBox5.Text);

            if (String.IsNullOrWhiteSpace(textBox7.Text) && String.IsNullOrWhiteSpace(textBox6.Text) && String.IsNullOrWhiteSpace(textBox5.Text)) 
            {
                MessageBox.Show("Fields cannot be empty");               
            }
            else
            {
                con.Open();

                string insert_query = "INSERT INTO PACKAGES(Package_ID, Package_Desc,Joining_Fee,Monthly_Fee) VALUES(@Package_ID, @Package_Desc,@Joining_Fee,@Monthly_Fee)";
                SqlDataAdapter myAdapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(insert_query, con);

                cmd.Parameters.AddWithValue("Package_ID", packIdCount);
                cmd.Parameters.AddWithValue("Package_Desc", packDescString);
                cmd.Parameters.AddWithValue("Joining_Fee", packJoinString);
                cmd.Parameters.AddWithValue("Monthly_Fee", packMonString);

                int numberOfRows = cmd.ExecuteNonQuery();

                MessageBox.Show(numberOfRows + " Record(s) Updated Successfully");

                con.Close();
            }

            getPackages();



        }

        private void btnRep1_Click(object sender, EventArgs e)
        {
            Report1 repForm = new Report1();
            repForm.ShowDialog();
        }

        private void btnRep2_Click(object sender, EventArgs e)
        {
            Report2 repForm = new Report2();
            repForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (gridID != 0)
            {
                /*gridID = Convert.ToInt32(dtgSearch.Rows[e.RowIndex].Cells[0].Value.ToString());
                Fnamestring = dtgSearch.Rows[e.RowIndex].Cells[1].Value.ToString();
                Snamestring = dtgSearch.Rows[e.RowIndex].Cells[2].Value.ToString();
                IDNumstring = dtgSearch.Rows[e.RowIndex].Cells[3].Value.ToString();
                Emailstring = dtgSearch.Rows[e.RowIndex].Cells[4].Value.ToString();
                Cellstring = dtgSearch.Rows[e.RowIndex].Cells[5].Value.ToString();*/
                updateDetails();

            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gridID != 0)
            {
                deleteDetails();

            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        public void deleteDetails()
        {
         
            try
            {
                con.Open();
                string deleteSQL = "DELETE CLIENT WHERE Client_ID = @gridID";
                
                SqlCommand cmd = new SqlCommand(deleteSQL, con);
                cmd.Parameters.AddWithValue("@gridID", gridID);

                int numberOfRows = cmd.ExecuteNonQuery();
                MessageBox.Show(numberOfRows + " Record(s) deleted Successfully");

                cmd.Dispose();
                con.Close();

            }
            catch (Exception)
            { MessageBox.Show("Record not deleted"); }
        }

        public void updateDetails()
        {
     /*       con.Open();
            string query = "Select * FROM CLIENT";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "CLIENT");
            dtgSearch.DataSource = ds;
            dtgSearch.DataMember = "CLIENT";
            con.Close();*/

            try
            {
                con.Open();
                string updateSQL = "UPDATE CLIENT SET FirstName = @Fnamestring, Surname = @Snamestring," +
                    " ID_Number = @IDNumstring,Email = @Emailstring, Cell_Number = @Cellstring " +
                    "WHERE Client_ID = @gridID";

                SqlCommand cmd = new SqlCommand(updateSQL, con);
                cmd.Parameters.AddWithValue("@gridID", gridID);
                cmd.Parameters.AddWithValue("@Fnamestring", Fnamestring);
                cmd.Parameters.AddWithValue("@Snamestring", Snamestring);
                cmd.Parameters.AddWithValue("@IDNumstring", IDNumstring);
                cmd.Parameters.AddWithValue("@Emailstring", Emailstring);
                cmd.Parameters.AddWithValue("@Cellstring", Cellstring);

                MessageBox.Show(Snamestring);
                //    myAdapter.UpdateCommand = cmd;

              //  myAdapter.Update(ds,"CLIENT");  

                // myAdapter.UpdateCommand.ExecuteNonQuery();

                int numberOfRows = cmd.ExecuteNonQuery();
                MessageBox.Show(" Record(s) Updated Successfully");

                cmd.Dispose();
                con.Close();
            }
            catch (Exception er)
            { MessageBox.Show(er.Message); }
            getData();
        }

        public void updatePackDetails()
        {
            //getPackages();

            try
            {
                con.Open();
                string updateSQL = "UPDATE PACKAGES SET  Package_Desc = @packDescString," +
                    " Joining_Fee = @packJoinString, Monthly_Fee = @packMonString " +
                    "WHERE Package_ID = @packIdString";

                SqlCommand cmd = new SqlCommand(updateSQL, con);
                cmd.Parameters.AddWithValue("@packIdString", packIdString);
                cmd.Parameters.AddWithValue("@packDescString", packDescString);
                cmd.Parameters.AddWithValue("@packJoinString", packJoinString);
                cmd.Parameters.AddWithValue("@packMonString", packMonString);
                
                int numberOfRows = cmd.ExecuteNonQuery();
                MessageBox.Show(numberOfRows + " Record(s) Updated Successfully");

                cmd.Dispose();
                con.Close();
            }
            catch (Exception er)
            { MessageBox.Show(er.Message); }
            
        }






    }
}   
