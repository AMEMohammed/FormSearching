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
using FrmSearching;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection sql;
        string con = @"Data Source = .\s2008; Initial Catalog =EntityTest; Integrated Security=true";
        public Form1()
        {
            InitializeComponent();

            sql = new SqlConnection(con);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dr = new SqlDataAdapter("select * from View_1",sql);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> lis=new Dictionary<string, string>();
            lis.Add("اسم الموظف", "NMEmp");
            lis.Add("رقم التلفون", "PHONEmp");
            lis.Add("اسم القسم", "IDDepart");


            FrmSearching.FormSearching fmSearching = new FormSearching("بحث في اسماء الموظفين",con, "select * from View_1", lis);
            fmSearching.resultDelegetDataTable = new FormSearching.ResultDelegtDataTable(ShowDate);
            fmSearching.Show();
        }

        void ShowDate(DataTable dt)
        {
            dataGridView1.DataSource = dt;
        }
    }
}
