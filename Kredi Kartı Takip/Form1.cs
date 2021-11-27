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

namespace Kredi_Kartı_Takip
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();


        public Form1()
        {
            InitializeComponent();
        }
        void paymentShow()
        {      
            con = new SqlConnection(@"Server = DESKTOP-GF4R2QG\SQLSAMBA; User id=sa; Password=yasak123; Database = CreditCardTracking; Trusted_Connection = True;");
            da = new SqlDataAdapter("Select * From AddExpense", con);
            ds = new DataSet();
            DataTable table = new DataTable();
            con.Open();
            da.Fill(table);
            dataGridView1.DataSource = table;
          
            con.Close();
        }
        void cardButtonAdd() {
            con = new SqlConnection(@"Server = DESKTOP-GF4R2QG\SQLSAMBA; User id=sa; Password=yasak123; Database = CreditCardTracking; Trusted_Connection = True;");
            da = new SqlDataAdapter("Select * From CreditCard", con);
       
           

            string queryString = "Select COUNT(*)From CreditCard";
            cmd = new SqlCommand(queryString, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            var cmsss = reader;
            MessageBox.Show(cmsss.ToString());
          

          


            //string tablecount = string.Format("SELECT COUNT(*) FROM {0}", table);

         
        
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            paymentShow();
            cardButtonAdd();
        }
    }
}
