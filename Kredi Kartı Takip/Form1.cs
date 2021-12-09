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
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            

            var creditcard = db.CreditCard.OrderByDescending(x => x.id).ToList();
            
            int xy = 5;
            int yx = 5;
            int i =0;
            foreach (var item in creditcard)
            {
                Button newButton = new Button();
              
               
                if (item.busniss==0)
                {
                    xy = xy + 150;

                    newButton.Location = new Point(xy, 575);

                }
                else
                {
                    yx = yx + 150;
                    newButton.Location = new Point(yx, 625);
                }
                this.Controls.Add(newButton);
                newButton.Text = item.bankName;
               
                newButton.Name = Convert.ToString(item.id);
               
                newButton.Size = new Size(140, 30);
                newButton.BackColor = Color.White;
                newButton.Click += new EventHandler(button_Click);
                newButton.FlatStyle = FlatStyle.Popup;
                newButton.Font = new Font("Microsoft Tai Le", 10);
              
            }

            double buayekstretopla = 0;
            double kullanilabilir = 0;
            double donemici = 0;
           
            dataGridView1.AutoGenerateColumns = true;
            
            //Bu ay ödenecek tutar bilgileri
            DateTime dt_Ay_ilkGun = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // Ayın ilk günü
            DateTime dt_Ay_sonGun1 = dt_Ay_ilkGun.AddMonths(-1);// önceki ayın ilk günü 
            DateTime dt_Ay_sonGun = dt_Ay_ilkGun.AddMonths(-1).AddDays(-1);// önceki ayın son günü
            DateTime dt_Ay_ekstresongn = dt_Ay_ilkGun.AddMonths(1).AddDays(14);// gösterme ve kullanılabilri bakiye son gün

            DateTime dt_Ay_son = dt_Ay_ilkGun.AddMonths(1).AddDays(-1);// ayın son günü


            List<Verigoster> verilist = new List<Verigoster>();
          
            //&&(x.addDate>= dt_Ay_ilkGun&&x.addDate<= dt_Ay_sonGun)
            var bankkartları = db.AddExpense.Where(x => x.cardId == 1).ToList();
            Verigoster veriler = new Verigoster();
            double ayiciharcama = 0, kullanılabilirbakiye = 0;
            foreach (var item in bankkartları)
            {
                DateTime tarihhesap = Convert.ToDateTime(item.addDate);
                int tarihekle = Convert.ToInt32(item.numberOfInstallments);
                tarihhesap = tarihhesap.AddMonths(tarihekle);
                //DateTime tarihkontrol = DateTime.Now.AddMonths(Convert.ToInt32(item.numberOfInstallments));


                if (item.addDate >= dt_Ay_ilkGun && item.addDate <= dt_Ay_son)
                {
                    donemici = donemici + Convert.ToDouble(item.installmentAmount);



                    decimal moneydonem = Convert.ToDecimal(donemici);

                    string moneyFormatdonem = moneydonem.ToString("#,##0.00");
                    carddonem.Text = moneyFormatdonem + "TL";
                }
                if (tarihhesap >= item.CreditCard.paymentDueDate)
                {


                    string mail = "";
                    if (item.mailOrder == 0)
                    {
                        mail = "Mail Order";
                    }
                    veriler = new Verigoster
                    {
                        id = item.id,
                        bankName = item.CreditCard.bankName,
                        companyName = item.companyName,
                        productCategory = item.productCategory,
                        numberOfInstallments = Convert.ToInt32(item.numberOfInstallments),
                        installmentAmount = Convert.ToInt32(item.installmentAmount),

                        aggregateAmount = Convert.ToDouble(item.aggregateAmount),
                        addDate = Convert.ToDateTime(item.addDate),
                        mailOrder = mail,
                        explantationCompany = item.explanationCompany
                        
                    };
                    verilist.Add(veriler);
                    buayekstretopla = buayekstretopla + Convert.ToDouble(item.installmentAmount);

                    decimal buay = Convert.ToDecimal(buayekstretopla);
                    string moneyFormatbuay = buay.ToString("#,##0.00");
                    cardbuay.Text = moneyFormatbuay + "TL";
                   
                  


                    kullanılabilirbakiye = Convert.ToDouble(item.CreditCard.balance) - (buayekstretopla + donemici);
                    decimal kullan = Convert.ToDecimal(kullanılabilirbakiye);

                    string moneyFormatkullan = kullan.ToString("#,##0.00");
                    cardKullnabilir.Text = moneyFormatkullan + " TL";
                }
                cardName.Text = item.CreditCard.nameSurname;
                cardNumber.Text = item.CreditCard.number;
                cardDate.Text = item.CreditCard.expireDate;
                cardCCV.Text = Convert.ToString(item.CreditCard.ccv);
               
                decimal money = Convert.ToDecimal(item.CreditCard.balance);

                string moneyFormat = money.ToString("#,##0.00");
                cardlimit.Text = moneyFormat + "TL";

                cardekstrekesim.Text = item.CreditCard.cutDate.ToString() ;
                cardlastpay.Text = item.CreditCard.paymentDueDate.ToString();

                ayiciharcama = +Convert.ToDouble(item.aggregateAmount);
                //bu ay ödenecek tutar aslında geçen aaydan ödenecek tutar
                //dönem içi harcama bu ayın hacaası
                //kullanılabilirbakiye=
                //  cardlastpay.Text = Convert.ToString(item.CreditCard.paymentDueDate);


            }





            dataGridView1.DataSource = verilist.ToList();
            dataGridView1.Columns[0].HeaderText = "Sıra";
            dataGridView1.Columns[2].HeaderText = "Alınan Firma";
            dataGridView1.Columns[1].HeaderText = "Alınan Şirket";
            dataGridView1.Columns[3].HeaderText = "Kart Adı";
            dataGridView1.Columns[4].HeaderText = "Kategori";
            dataGridView1.Columns[5].HeaderText = "Taksit Sayısı";
            dataGridView1.Columns[6].HeaderText = "Taksit Tutarı";
            dataGridView1.Columns[7].HeaderText = "Toplam Tutar";
            dataGridView1.Columns[8].HeaderText = "Eklenme Tarihi";
            dataGridView1.Columns[9].HeaderText = "Mail Order";
            



            // identify which button was clicked and perform necessary actions
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        protected void button_Click(object sender, EventArgs e)
        {
            double buayekstretopla = 0;
            double kullanilabilir = 0;
            double donemici = 0;
            Button button = sender as Button;
            //dataGridView1.AutoGenerateColumns = false;  
       
           
            //Bu ay ödenecek tutar bilgileri
            DateTime dt_Ay_ilkGun = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // Ayın ilk günü
            DateTime dt_Ay_sonGun1 = dt_Ay_ilkGun.AddMonths(-1);// önceki ayın ilk günü 
            DateTime dt_Ay_sonGun = dt_Ay_ilkGun.AddMonths(-1).AddDays(-1);// önceki ayın son günü
            DateTime dt_Ay_ekstresongn= dt_Ay_ilkGun.AddMonths(1).AddDays(14);// gösterme ve kullanılabilri bakiye son gün

            DateTime dt_Ay_son = dt_Ay_ilkGun.AddMonths(1).AddDays(-1);// ayın son günü


            List<Verigoster> verilist = new List<Verigoster>();
            int cardid = Convert.ToInt32(button.Name);

            //KART BİLGİLERİNİ GETİR
            var kartlarigetir = db.CreditCard.Where(x => x.id == cardid).FirstOrDefault();
            decimal money = Convert.ToDecimal(kartlarigetir.balance);
            string moneyFormat = money.ToString("#,##0.00");
            cardlimit.Text = moneyFormat + " TL";
            cardName.Text = kartlarigetir.nameSurname;
            cardNumber.Text = kartlarigetir.number;
            cardDate.Text = kartlarigetir.expireDate;
            cardCCV.Text = Convert.ToString(kartlarigetir.ccv);

            //
            //&&(x.addDate>= dt_Ay_ilkGun&&x.addDate<= dt_Ay_sonGun)
            //HARCAMA VE HESAPLAMALARI YAP
            var bankkartları = db.AddExpense.Where(x => x.cardId == cardid).ToList();
            Verigoster veriler = new Verigoster();
            double ayiciharcama = 0,kullanılabilirbakiye=0;
            foreach (var item in bankkartları)
            {
                DateTime tarihhesap = Convert.ToDateTime(item.addDate);
                int tarihekle = Convert.ToInt32(item.numberOfInstallments);
                tarihhesap= tarihhesap.AddMonths(tarihekle);
                //DateTime tarihkontrol = DateTime.Now.AddMonths(Convert.ToInt32(item.numberOfInstallments));
                if (item.addDate >= dt_Ay_ilkGun && item.addDate <= dt_Ay_son)
                {
                    donemici = donemici + Convert.ToDouble(item.installmentAmount);
                    decimal moneydonem = Convert.ToDecimal(donemici);

                    string moneyFormatdonem = moneydonem.ToString("#,##0.00");
                    carddonem.Text = moneyFormatdonem + " TL";
                }
                if (tarihhesap >=item.CreditCard.paymentDueDate)
                {

                    string mail = "";
                    if (item.mailOrder == 0)
                    {
                        mail = "Mail Order";
                    }
                    veriler = new Verigoster
                    {
                        id = item.id,
                        bankName = item.CreditCard.bankName,
                        companyName = item.companyName,
                        productCategory = item.productCategory,
                        numberOfInstallments = Convert.ToDouble(item.numberOfInstallments),
                        installmentAmount = Convert.ToDouble(item.installmentAmount)
                    ,
                        aggregateAmount = Convert.ToDouble(item.aggregateAmount),
                        addDate = Convert.ToDateTime(item.addDate),
                        mailOrder = mail,
                        explantationCompany = item.explanationCompany
                    };
                    verilist.Add(veriler);

                    buayekstretopla = buayekstretopla + Convert.ToDouble(item.installmentAmount);
                    decimal buay = Convert.ToDecimal(buayekstretopla);
                    string moneyFormatbuay = buay.ToString("#,##0.00");
                    cardbuay.Text = moneyFormatbuay + " TL";


                   

                   
                  
                   
                }

                cardName.Text = item.CreditCard.nameSurname;
                cardNumber.Text = item.CreditCard.number;
                cardDate.Text = item.CreditCard.expireDate;
                cardCCV.Text = Convert.ToString(item.CreditCard.ccv);

                 money = Convert.ToDecimal(item.CreditCard.balance);
                 moneyFormat = money.ToString("#,##0.00");
                cardlimit.Text = moneyFormat + " TL";

                cardekstrekesim.Text = item.CreditCard.cutDate.ToString();
                cardlastpay.Text = item.CreditCard.paymentDueDate.ToString();

                //ayiciharcama = +Convert.ToDouble(item.aggregateAmount);
                //bu ay ödenecek tutar aslında geçen aaydan ödenecek tutar
                //dönem içi harcama bu ayın hacaası
                //kullanılabilirbakiye=
                //  cardlastpay.Text = Convert.ToString(item.CreditCard.paymentDueDate);

               
            }

            kullanılabilirbakiye = Convert.ToDouble(kartlarigetir.balance) - (buayekstretopla);
            decimal kullan = Convert.ToDecimal(kullanılabilirbakiye);

            string moneyFormatkullan = kullan.ToString("#,##0.00");
            cardKullnabilir.Text = moneyFormatkullan + " TL";


    
            dataGridView1.DataSource = verilist.ToList();
            dataGridView1.Columns[0].HeaderText = "Sıra";
            dataGridView1.Columns[2].HeaderText = "Alınan Firma";
            dataGridView1.Columns[1].HeaderText = "Alınan Şirket";
            dataGridView1.Columns[3].HeaderText = "Kart Adı";
            dataGridView1.Columns[4].HeaderText = "Kategori";
            dataGridView1.Columns[5].HeaderText = "Taksit Sayısı";
            dataGridView1.Columns[6].HeaderText = "Taksit Tutarı";
            dataGridView1.Columns[7].HeaderText = "Toplam Tutar";
            dataGridView1.Columns[8].HeaderText = "Eklenme Tarihi";
            dataGridView1.Columns[9].HeaderText = "Mail Order";




            // identify which button was clicked and perform necessary actions
        }


        private void button2_Click(object sender, EventArgs e)
        {
            PaymentAddcs payment = new PaymentAddcs();
            payment.groupBox1.Visible = false;
            payment.groupBox2.Visible = true;
            payment.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PaymentAddcs payment = new PaymentAddcs();
            payment.groupBox1.Visible = true;
            payment.groupBox2.Visible = false;
            payment.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            var creditcard = db.CreditCard.OrderByDescending(x => x.id).ToList();

            int xy = 60;
            foreach (var item in creditcard)
            {
                Button newButton = new Button();


                this.Controls.Add(newButton);
                newButton.Text = item.bankName;
                xy = xy + 50;
                newButton.Location = new Point(49, xy);
                newButton.Name = Convert.ToString(item.id);

                newButton.Size = new Size(100, 30);
                newButton.Click += new EventHandler(button_Click);
                newButton.FlatStyle = FlatStyle.Popup;
                newButton.Font = new Font("Microsoft Tai Le", 10);

            }

            double buayekstretopla = 0;
            double kullanilabilir = 0;
            double donemici = 0;

            dataGridView1.AutoGenerateColumns = true;

            //Bu ay ödenecek tutar bilgileri
            DateTime dt_Ay_ilkGun = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // Ayın ilk günü
            DateTime dt_Ay_sonGun1 = dt_Ay_ilkGun.AddMonths(-1);// önceki ayın ilk günü 
            DateTime dt_Ay_sonGun = dt_Ay_ilkGun.AddMonths(-1).AddDays(-1);// önceki ayın son günü
            DateTime dt_Ay_ekstresongn = dt_Ay_ilkGun.AddMonths(1).AddDays(14);// gösterme ve kullanılabilri bakiye son gün

            DateTime dt_Ay_son = dt_Ay_ilkGun.AddMonths(1).AddDays(-1);// ayın son günü


            List<Verigoster> verilist = new List<Verigoster>();

            //&&(x.addDate>= dt_Ay_ilkGun&&x.addDate<= dt_Ay_sonGun)
            var bankkartları = db.AddExpense.Where(x => x.cardId == 1).ToList();
            Verigoster veriler = new Verigoster();
            double ayiciharcama = 0, kullanılabilirbakiye = 0;
            foreach (var item in bankkartları)
            {
                DateTime tarihhesap = Convert.ToDateTime(item.addDate);
                int tarihekle = Convert.ToInt32(item.numberOfInstallments);
                tarihhesap = tarihhesap.AddMonths(tarihekle);
                //DateTime tarihkontrol = DateTime.Now.AddMonths(Convert.ToInt32(item.numberOfInstallments));


                if (item.addDate >= dt_Ay_ilkGun && item.addDate <= dt_Ay_son)
                {
                    donemici = donemici + Convert.ToDouble(item.installmentAmount);



                    decimal moneydonem = Convert.ToDecimal(donemici);

                    string moneyFormatdonem = moneydonem.ToString("#,##0.00");
                    carddonem.Text = moneyFormatdonem + "TL";
                }
                if (tarihhesap >= item.CreditCard.paymentDueDate)
                {


                    string mail = "";
                    if (item.mailOrder == 0)
                    {
                        mail = "Mail Order";
                    }
                    veriler = new Verigoster
                    {
                        id = item.id,
                        bankName = item.CreditCard.bankName,
                        companyName = item.companyName,
                        productCategory = item.productCategory,
                        numberOfInstallments = Convert.ToInt32(item.numberOfInstallments),
                        installmentAmount = Convert.ToInt32(item.installmentAmount),

                        aggregateAmount = Convert.ToDouble(item.aggregateAmount),
                        addDate = Convert.ToDateTime(item.addDate),
                        mailOrder = mail,
                        explantationCompany = item.explanationCompany

                    };
                    verilist.Add(veriler);
                    buayekstretopla = buayekstretopla + Convert.ToDouble(item.installmentAmount);

                    decimal buay = Convert.ToDecimal(buayekstretopla);
                    string moneyFormatbuay = buay.ToString("#,##0.00");
                    cardbuay.Text = moneyFormatbuay + "TL";




                    kullanılabilirbakiye = Convert.ToDouble(item.CreditCard.balance) - (buayekstretopla + donemici);
                    decimal kullan = Convert.ToDecimal(kullanılabilirbakiye);

                    string moneyFormatkullan = kullan.ToString("#,##0.00");
                    cardKullnabilir.Text = moneyFormatkullan + " TL";
                }
                cardName.Text = item.CreditCard.nameSurname;
                cardNumber.Text = item.CreditCard.number;
                cardDate.Text = item.CreditCard.expireDate;
                cardCCV.Text = Convert.ToString(item.CreditCard.ccv);

                decimal money = Convert.ToDecimal(item.CreditCard.balance);

                string moneyFormat = money.ToString("#,##0.00");
                cardlimit.Text = moneyFormat + "TL";

                cardekstrekesim.Text = item.CreditCard.cutDate.ToString();
                cardlastpay.Text = item.CreditCard.paymentDueDate.ToString();

                ayiciharcama = +Convert.ToDouble(item.aggregateAmount);
                //bu ay ödenecek tutar aslında geçen aaydan ödenecek tutar
                //dönem içi harcama bu ayın hacaası
                //kullanılabilirbakiye=
                //  cardlastpay.Text = Convert.ToString(item.CreditCard.paymentDueDate);


            }





            dataGridView1.DataSource = verilist.ToList();
            dataGridView1.Columns[0].HeaderText = "Sıra";
            dataGridView1.Columns[2].HeaderText = "Alınan Firma";
            dataGridView1.Columns[1].HeaderText = "Alınan Şirket";
            dataGridView1.Columns[3].HeaderText = "Kart Adı";
            dataGridView1.Columns[4].HeaderText = "Kategori";
            dataGridView1.Columns[5].HeaderText = "Taksit Sayısı";
            dataGridView1.Columns[6].HeaderText = "Taksit Tutarı";
            dataGridView1.Columns[7].HeaderText = "Toplam Tutar";
            dataGridView1.Columns[8].HeaderText = "Eklenme Tarihi";
            dataGridView1.Columns[9].HeaderText = "Mail Order";


        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
