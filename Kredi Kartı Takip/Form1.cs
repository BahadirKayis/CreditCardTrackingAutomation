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
using Kredi_Kartı_Takip.Model;

namespace Kredi_Kartı_Takip
{
    public partial class Form1 : Form
    {
        CreditCardTrackingEntities db = new CreditCardTrackingEntities();


        public Form1()
        {
            InitializeComponent();
        }
        void paymentShow()
        {      
       
        }
        void cardButtonAdd() {
           
          

          


            //string tablecount = string.Format("SELECT COUNT(*) FROM {0}", table);

         
        
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            paymentShow();
            cardButtonAdd();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
