using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroFitnessClub
{
    public partial class Report1 : Form
    {
        public Report1()
        {
            InitializeComponent();
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HeroFitnessDataSet2.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.HeroFitnessDataSet2.DataTable1);



        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  this.HeroFitnessDataSet2.EnforceConstraints = false;
            this.DataTable1TableAdapter.Fill(this.HeroFitnessDataSet2.DataTable1,comboBox1.SelectedValue);*/
            this.reportViewer1.RefreshReport();
        }
    }
}
