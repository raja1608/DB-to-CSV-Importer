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
using SQL = System.Data;
using System.Configuration;
using System.IO;

namespace DbtoCsvReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuery.Text = string.Empty;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (txtQuery.Text != string.Empty)
            {
                try
                {
                    string connectionstr = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;
                    string query = txtQuery.Text.Trim();


                    using (SqlConnection con = new SqlConnection(connectionstr))
                    {
                        con.Open();

                        this.lbllog1.Text = "SQL Connection establised";

                        SQL.DataTable dttable = new SQL.DataTable();

                        using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                        {
                            da.Fill(dttable);
                        }

                        this.lbllog2.Text = "SQL Data Table Filled";

                        CreateCSVFile(dttable, "C:\\Temp\\Check.xlsx");
                    }
                }
                catch (SqlException es)
                {
                    MessageBox.Show("Enter a valid Sql Query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(es.Message);
                }
            }
            else
            {
                MessageBox.Show("The text box must not be empty, Enter a valid Sql Query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CreateCSVFile(DataTable dt, string strFilePath)
        {
            try
            {
                StreamWriter sw = new StreamWriter(strFilePath, false);
                int columnCount = dt.Columns.Count;

                this.lblRowsImported.Text = dt.Rows.Count.ToString();

                for (int i = 0; i < columnCount; i++)
                {
                    sw.Write(dt.Columns[i]);

                    if (i < columnCount - 1)
                    {
                        sw.Write(",");
                    }
                }

                sw.Write(sw.NewLine);
                
                foreach (DataRow dr in dt.Rows)
                {
                    for (int i = 0; i < columnCount; i++)
                    {
                        
                        if (!Convert.IsDBNull(dr[i]))
                        {
                           sw.Write(dr[i].ToString());
                        }
                        else
                        {
                            sw.Write("NULL");
                        }

                        if (i < columnCount - 1)
                        {
                            sw.Write(",");
                        }
                    }

                    sw.Write(sw.NewLine);
                    this.lbllog3.Text = "Data imported to .csv file";
                }

                MessageBox.Show("The Data was succesfully imported to .CSV File", "Import to CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sw.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
