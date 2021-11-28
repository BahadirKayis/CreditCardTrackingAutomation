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
            var count = db.CreditCard.OrderBy(x => x.id).ToList();
            MessageBox.Show(count.Count().ToString());
        }
        void cardButtonAdd() {
           
          

          


            //string tablecount = string.Format("SELECT COUNT(*) FROM {0}", table);

         
        
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'creditCardTrackingDataSet.CreditCard' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
         
            paymentShow();
            cardButtonAdd();

            var creditcard = db.CreditCard.OrderByDescending(x => x.id).ToList();
            foreach (var item in creditcard)
            {
                int x = 60;
                Button newButton = new Button();
                this.Controls.Add(newButton);

                newButton.Text = item.bankName;
               
                newButton.Location = new Point(49, x);
                newButton.Name = Convert.ToString(item.id);
                x += 20;
                newButton.Size = new Size(100, 30);
                newButton.Click += new EventHandler(button_Click);

            }
             
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        protected void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            dataGridView1.AutoGenerateColumns = true;
           
            //Bu ay ödenecek tutar bilgileri
            DateTime dt_Ay_ilkGun = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // Ayın ilk günü
            DateTime dt_Ay_sonGun1 = dt_Ay_ilkGun.AddMonths(-1);// önceki ayın ilk günü 
            DateTime dt_Ay_sonGun = dt_Ay_ilkGun.AddMonths(-1).AddDays(-1);// önceki ayın son günü
            DateTime dt_Ay_ekstresongn= dt_Ay_ilkGun.AddMonths(1).AddDays(14);// gösterme ve kullanılabilri bakiye son gün


            List<Verigoster> verilist = new List<Verigoster>();
            int cardid = Convert.ToInt32(button.Name);
            var bankkartları = db.AddExpense.Where(x => x.cardId == cardid&&(x.addDate>= dt_Ay_ilkGun&&x.addDate<= dt_Ay_sonGun)).ToList();
            Verigoster veriler = new Verigoster();
            double ayiciharcama = 0,kullanılabilirbakiye=0;
            foreach (var item in bankkartları)
            {
                string mail = "";
                if (item.mailOrder==0)
                {
                    mail = "Mail Order";
                }
                veriler = new Verigoster { id = item.id, bankName = item.CreditCard.bankName, companyName=item.companyName ,productCategory = item.productCategory, numberOfInstallments = Convert.ToInt32(item.numberOfInstallments), installmentAmount = Convert.ToInt32(item.installmentAmount)
                , aggregateAmount =  Convert.ToDouble(item.aggregateAmount),addDate=Convert.ToDateTime(item.addDate),mailOrder= mail  };
                verilist.Add(veriler);
                cardName.Text= item.CreditCard.nameSurname;
                cardNumber.Text= item.CreditCard.number;
                cardDate.Text= item.CreditCard.expireDate;
                cardCCV.Text= Convert.ToString(item.CreditCard.ccv);
                cardlimit.Text= item.CreditCard.balance;
                cardekstrekesim.Text = Convert.ToString(item.CreditCard.cutDate);

                ayiciharcama = + Convert.ToDouble(item.aggregateAmount);
            //bu ay ödenecek tutar aslında geçen aaydan ödenecek tutar
            //dönem içi harcama bu ayın hacaası
              //kullanılabilirbakiye=
              //  cardlastpay.Text = Convert.ToString(item.CreditCard.paymentDueDate);
            }

            
            carddonem.Text = "HESAPLANACAK";
            cardbuay.Text = "HESAPLANACAK";
            cardKullnabilir.Text = "";
            dataGridView1.DataSource = verilist.ToList();

          
            // identify which button was clicked and perform necessary actions
        }


        private void button2_Click(object sender, EventArgs e)
        {
            PaymentAddcs payment = new PaymentAddcs();
            
            payment.Show();
            this.Hide();
        }

       
    }
}
