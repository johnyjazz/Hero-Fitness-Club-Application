
namespace HeroFitnessClub
{
    partial class Report2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.HeroFitnessDataSet3 = new HeroFitnessClub.HeroFitnessDataSet3();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new HeroFitnessClub.HeroFitnessDataSet3TableAdapters.DataTable1TableAdapter();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pACKAGESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pACKAGESTableAdapter = new HeroFitnessClub.HeroFitnessDataSet3TableAdapters.PACKAGESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HeroFitnessDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACKAGESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HeroFitnessClub.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 99);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1063, 420);
            this.reportViewer1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pACKAGESBindingSource;
            this.comboBox1.DisplayMember = "Package_Desc";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Package_Desc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Package:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HeroFitnessDataSet3
            // 
            this.HeroFitnessDataSet3.DataSetName = "HeroFitnessDataSet3";
            this.HeroFitnessDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.HeroFitnessDataSet3;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.HeroFitnessDataSet3;
            // 
            // pACKAGESBindingSource
            // 
            this.pACKAGESBindingSource.DataMember = "PACKAGES";
            this.pACKAGESBindingSource.DataSource = this.HeroFitnessDataSet3;
            // 
            // pACKAGESTableAdapter
            // 
            this.pACKAGESTableAdapter.ClearBeforeFill = true;
            // 
            // Report2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report2";
            this.Text = "Report2";
            this.Load += new System.EventHandler(this.Report2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeroFitnessDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACKAGESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private HeroFitnessDataSet3 HeroFitnessDataSet3;
        private HeroFitnessDataSet3TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.BindingSource pACKAGESBindingSource;
        private HeroFitnessDataSet3TableAdapters.PACKAGESTableAdapter pACKAGESTableAdapter;
    }
}