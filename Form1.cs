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
using Excel=Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;


namespace Excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-HBD9E76;Integrated Security=True";
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from sys.databases", conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbVeriTabani.Items.Add(dr["Name"].ToString());
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int baslamaKolonu = 1;
            int baslamaSatiri = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[baslamaSatiri, baslamaKolonu + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            baslamaSatiri++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[baslamaSatiri + i, baslamaKolonu + j];
                    myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Select();
                }
            }
        }        
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-HBD9E76;Initial Catalog=" + cmbVeriTabani.SelectedItem.ToString() + ";Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from " + cmbTablo.SelectedItem.ToString();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void cmbVeriTabani_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-HBD9E76;Initial Catalog=" + cmbVeriTabani.SelectedItem.ToString() + ";Integrated Security=True";
            conn.Open();
            cmbTablo.Items.Clear();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = conn.GetSchema("Tables");

            foreach (DataRow row in dt.Rows)
            {
                string tablename = (string)row[2];
                cmbTablo.Items.Add(tablename);
            }
        }
    }
}
