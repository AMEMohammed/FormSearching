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

namespace FrmSearching
{
    public partial class FormSearching : Form
    {
        private SqlConnection  sqlConnction;//object coonection for sql server
        private  string Query;
        private DataTable DataTAbleForResult = new DataTable();
        /// Deleget For Pass Data from another Form
        public delegate void ResultDelegtDataTable(DataTable dt);
        public ResultDelegtDataTable resultDelegetDataTable;
        ////////////
        public FormSearching()
        {
            InitializeComponent();
        }
        ///// contstroctr 
        public FormSearching(string TitleSearch,string ConnctionServer,string Qury,Dictionary<string,string>ListColmn)
        {
            InitializeComponent();
            this.labTitleSearch.Text = TitleSearch; // Add title form
            ////////// start loading data for comboxes
            LoadDataForCom(comBoxColumn1, ListColmn);
            LoadDataForCom(comBoxColumn2, ListColmn);
            LoadDataForCom(comBoxColumn3, ListColmn);
            LoadDataForCom(comBoxColumn4, ListColmn);
            ///////// end loading data for comboxes

            // get data about Server
            sqlConnction = new SqlConnection(ConnctionServer);
            Query = Qury;
        }

        // event Loading form
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                comBoxColumn1.SelectedIndex = 0;
                comBoxLogic1.SelectedIndex = 0;
                comBoxOprat1.SelectedIndex = 0;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { 
        }
        /// event check for checkbox2
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            /// check2 enbaled ==true
            if (checkBox2.Checked)
            {
                try
                {
                    panel2.Enabled = true;
                    comBoxColumn2.SelectedIndex = 0;
                    comBoxLogic2.SelectedIndex = 0;
                    comBoxOprat2.SelectedIndex = 0;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            /// check2 enbaled ==false
            else
            {
                panel2.Enabled = false;

            }
        }

        /// event check for checkbox3
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            /// check3 enbaled ==true
            if (checkBox3.Checked)
            {
                try
                {
                    panel3.Enabled = true;
                    comBoxColumn3.SelectedIndex = 0;
                    comBoxLogic3.SelectedIndex = 0;
                    comBoxOprat3.SelectedIndex = 0;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            /// check3 enbaled ==false
            else
            {
                panel3.Enabled = false;

            }
        }

        /// event check for checkbox4
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            /// check4 enbaled ==true
            if (checkBox4.Checked)
            {
                try
                {
                    comBoxColumn4.SelectedIndex = 0;
                    comBoxLogic4.SelectedIndex = 0;
                    comBoxOprat4.SelectedIndex = 0;
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                panel4.Enabled = true;
            }
            /// check4 enbaled ==false
            else
            {
                panel4.Enabled = false;

            }
        }
        /////btn Exite
        private void btnExite_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ////  btn Clean All
        private void btnNewSearch_Click(object sender, EventArgs e)
        {
            txtSearching1.Text = "";
            txtSearching2.Text = "";
            txtSearching3.Text = "";
            txtSearching4.Text = "";
            try
            {
                comBoxColumn1.SelectedIndex = 0;
                comBoxColumn2.SelectedIndex = 0;
                comBoxColumn3.SelectedIndex = 0;
                comBoxColumn4.SelectedIndex = 0;
                comBoxLogic1.SelectedIndex = 0;
                comBoxLogic2.SelectedIndex = 0;
                comBoxLogic3.SelectedIndex = 0;
                comBoxLogic4.SelectedIndex = 0;
                comBoxOprat1.SelectedIndex = 0;
                comBoxOprat2.SelectedIndex = 0;
                comBoxOprat3.SelectedIndex = 0;
                comBoxOprat4.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        /// btn Searching
        private void btnSearch_Click(object sender, EventArgs e)
        {  /// 
            string Query1 = Query;
            DataTAbleForResult = new DataTable();
            if (txtSearching1.Text.Length<=0)
            {
                MessageBox.Show("يجب اكمال الشرط");
            }
            else  if(checkBox2.Checked && txtSearching2.Text.Length<=0)
            {
                MessageBox.Show("يجب اكمال الشرط");
            }
            else if (checkBox3.Checked && txtSearching3.Text.Length <= 0)
            {
                MessageBox.Show("يجب اكمال الشرط");
            }
            else if (checkBox4.Checked && txtSearching4.Text.Length <= 0)
            {
                MessageBox.Show("يجب اكمال الشرط");
            }
            else
            {


                /// pass datatable for aonter form using this deleget
                  if( resultDelegetDataTable !=null)
                {
                    SqlParameter[] parm = new SqlParameter[4];
                    Query1 +=" where "+ GetFristCondition(comBoxOprat1, comBoxColumn1, txtSearching1.Text);/// get Frist Condition
                    if(checkBox2.Checked)
                    {
                        Query1 += " " + GetCondition(comBoxLogic2, comBoxOprat2, comBoxColumn2, txtSearching2.Text);
                    }
                    if (checkBox3.Checked)
                    {
                        Query1 += " " + GetCondition(comBoxLogic3, comBoxOprat3, comBoxColumn3, txtSearching3.Text);
                    }
                    if (checkBox4.Checked)
                    {
                        Query1 += " " + GetCondition(comBoxLogic4, comBoxOprat4, comBoxColumn4, txtSearching4.Text);
                    }
                    MessageBox.Show(Query1);
                 
                   
                  
                    SqlDataAdapter dr = new SqlDataAdapter(Query1, sqlConnction);
                    dr.Fill(DataTAbleForResult);
                    labResult.Text =" عدد النتائج :  "+ DataTAbleForResult.Rows.Count.ToString() ;
                   resultDelegetDataTable(DataTAbleForResult);
                }


                
            }
           
        }

        //funactions
        //// load data Form Combox
        private void LoadDataForCom(ComboBox box,Dictionary<string,string>lis)
        {
            try
            {
                box.DataSource = new BindingSource(lis, null);
                box.ValueMember = "value";
                box.DisplayMember = "key";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        ///
        /// Get String frist Condition
        private string GetFristCondition( ComboBox comOp, ComboBox Comn, string textSearch)
        {
          
            string opre = "";
            string column = "";

           
            ////
            /////Condition op
            if (comOp.SelectedIndex == 0)
            {
                opre = " like "+"'%"+ textSearch + "%'";
            }
            else if (comOp.SelectedIndex == 1)
            {
                opre = "= " + textSearch;
            }
            else
            {
                opre = "!= " + textSearch;
            }
            column = (string)Comn.SelectedValue;

            //////
            return  column + opre;

        }
        ///Get string condition
        private string GetCondition(ComboBox comLogic,ComboBox comOp,ComboBox Comn,string textSearch)
        {
            string Logic = "";
            string opre = "";
            string column = "";

            //Condition Logic
            if (comLogic.SelectedIndex == 0)
            {
                Logic = "and ";
            }
            else
            {
                Logic = "or ";
            }
            ////
            /////Condition op
            if(comOp.SelectedIndex==0)
            {
                opre = " like " + "'%" + textSearch + "%'";
            }
            else if(comOp.SelectedIndex==1)
            {
                opre ="= " + textSearch;
            }
            else
            {
                opre = "!= " + textSearch ;
            }
            column = (string)Comn.SelectedValue;

            //////
            return Logic + column + opre;

        }


       

        
    }
}
