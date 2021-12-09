using Kredi_Kartı_Takip.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kredi_Kartı_Takip
{
    public partial class PaymentAddcs : Form
    {
        CreditCardTrackingEntities db = new CreditCardTrackingEntities();

        public PaymentAddcs()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cardAdd_Click(object sender, EventArgs e)
        {
            if (bankName.Text=="")
            {
                MessageBox.Show("Banka Alanını Doldurunuz");
            }
                else if (nameSurname.Text=="")
            {
                MessageBox.Show("İsim Alanını Doldurunuz");
            }
             else if (number.Text=="")
            {
                MessageBox.Show("Kart Numarasını Alanını Doldurunuz");
            }   
            else if (expireDate.Text=="")
            {
                MessageBox.Show("Kartın Son Kullanma Tarihi Alanını Doldurunuz");
            } 
            else if (ccv.Text=="")
            {
                MessageBox.Show("CCV Alanını Doldurunuz");
            }
             else if (balance.Text=="")
            {
                MessageBox.Show("Kart Bakiyesi Alanını Doldurunuz");
            }
            else
            {

                CreditCard newcard = new CreditCard();
                newcard.bankName = bankName.Text.ToString();
                newcard.nameSurname = nameSurname.Text.ToString();
                newcard.number = number.Text.ToString();
                newcard.expireDate = expireDate.Text.ToString();
                newcard.ccv = Convert.ToInt32(ccv.Text.ToString());
                newcard.cutDate = Convert.ToDateTime(cutDate.Text.ToString());
                newcard.paymentDueDate = Convert.ToDateTime(paymentDueDate.Text.ToString());
                newcard.balance = Convert.ToString(balance.Text.ToString());
                if (checkBox2.Checked)
                {
                    newcard.busniss = 0;
                }
                else
                {
                    newcard.busniss = 1;
                }
                db.CreditCard.Add(newcard);
                db.SaveChanges();
                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
                MessageBox.Show("Yeni Kart Eklendi");
                bankName.Text = "";
                nameSurname.Text = "";
                bankName.Text = "";
                number.Text = "";
                expireDate.Text = "";
                ccv.Text = "";
                balance.Text = "";
            }

        }

        private void balance_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void PaymentAddcs_Load(object sender, EventArgs e)
        {
            var creditcard = db.CreditCard.OrderBy(x => x.id).ToList();
           
       
            foreach (var item in creditcard)
            {
                kartlar.Items.Add(item.bankName);
                editkart.Items.Add(item.bankName);
            }
            aggreAmount.ReadOnly = true;



        }

        private void alinanfirma_SelectedIndexChanged(object sender, EventArgs e)
        {
           int combocoun=alinanfirma.Items.Count;
            if (alinanfirma.SelectedIndex== combocoun-1)
            {
                firmatext.Visible = true;
                alinanfirma.Visible = false;
            }
            else
            {
                firmatext.Visible = false;
                alinanfirma.Visible = true;
            }
        }

        private void expenseAdd_Click(object sender, EventArgs e)
        {

            if (kartlar.Text == "")
            {
                MessageBox.Show("Hangi Banka Olduğunu Seçiniz");
            }
            if (firmatext.Text==""&&alinanfirma.Text=="")
            {
                MessageBox.Show("Hangi Firma Olduğunu Seçiniz veya Yazınız");
            }
               else if (numberOfIns.Text=="0"|| numberOfIns.Text == "")
            {
                MessageBox.Show("Taksit Sayısı Giriniz ");
            }
            else if (insAmoun.Text=="0"|| insAmoun.Text == "")
            {
                MessageBox.Show("Taksit Tutarı Giriniz ");
            }
            else
            {
                AddExpense neweExpense = new AddExpense();
                var kartid = db.CreditCard.Where(x => x.bankName == kartlar.Text).FirstOrDefault();
                neweExpense.cardId = kartid.id;
                if (alinanfirma.Text == "Diğer")
                {
                    neweExpense.companyName = firmatext.Text.ToString(); ;

                }
                else
                {
                    neweExpense.companyName = alinanfirma.Text.ToString();

                }
                neweExpense.productCategory = productCategory.Text.ToString();
                neweExpense.numberOfInstallments = Convert.ToUInt16(numberOfIns.Text.ToString());
                neweExpense.installmentAmount = insAmoun.Text.ToString();
                neweExpense.aggregateAmount = gizlitoplamtutar.Text.ToString();
                neweExpense.addDate = Convert.ToDateTime(addDate.Text.ToString());
                neweExpense.explanationCompany = explanationCompany.Text.ToString();
                // 0 ise mail order
                if (checkBox1.Checked == true)
                {
                    neweExpense.mailOrder = 0;
                }
                else
                {
                    neweExpense.mailOrder = 1;
                }

                db.AddExpense.Add(neweExpense);
                db.SaveChanges();
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    this.Controls[i].ResetText();
                }
                MessageBox.Show("Harcama Eklendi");


                alinanfirma.Visible = true;
                firmatext.Visible = false;
                productCategory.Text = "";
                numberOfIns.Text = "0";
                insAmoun.Text = "0";
                explanationCompany.Text = "";
                checkBox1.Checked = false;

            }

            

        }

        private void numberOfIns_TextChanged(object sender, EventArgs e)

        {
            double taksit_sayisi=0, taksit_tutarı=0;
            if (numberOfIns.Text.ToString()!="")
            {
                taksit_sayisi = Convert.ToInt32(numberOfIns.Text.ToString());

            }
            if (insAmoun.Text.ToString()!="")
            {
                taksit_tutarı = Convert.ToDouble(insAmoun.Text.ToString());

            }


            double toplam_tutar = taksit_sayisi * taksit_tutarı;

            aggreAmount.Text = toplam_tutar.ToString();
        }

        private void insAmoun_TextChanged(object sender, EventArgs e)
        {
            string taksit_sayisi = "0", taksit_tutarı = "0";
          
            if (numberOfIns.Text.ToString() != "")
            {
                taksit_sayisi = numberOfIns.Text.ToString();

            }
            if (insAmoun.Text.ToString() != "")
            {
                
               taksit_tutarı =insAmoun.Text.ToString();
                taksit_tutarı = taksit_tutarı.Replace(".",",");

            }



            double toplam_tutar = Convert.ToDouble(taksit_sayisi) *Convert.ToDouble( taksit_tutarı);
            gizlitoplamtutar.Text = toplam_tutar.ToString();
            //aggreAmount.Text = toplam_tutar.ToString();

          
            decimal moneydonem = Convert.ToDecimal(toplam_tutar);

            string moneyFormatdonem = moneydonem.ToString("#,##0.00");
            aggreAmount.Text = moneyFormatdonem + " TL";
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
           
            if (number.Text.Length==4)
            {
                number.Text = number.Text+"-";
                number.SelectionStart = number.MaxLength;
            }  if (number.Text.Length==9)
            {
                number.Text = number.Text+"-";
                number.SelectionStart = number.MaxLength;
            }if (number.Text.Length==14)
            {
                number.Text = number.Text+"-";
                number.SelectionStart = number.MaxLength;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();


        }

        private void bankName_TextChanged(object sender, EventArgs e)
        {

        }

        private void aggreAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            var kartid = db.CreditCard.Where(x => x.bankName == editkart.Text).FirstOrDefault();
            CreditCard car = new CreditCard();
            kartid.nameSurname = editkartname.Text.ToString();
            kartid.number = editcardnumber.Text.ToString();
            kartid.expireDate = editenddate.Text;
            kartid.ccv =Convert.ToInt32(editccv.Text);
            kartid.cutDate =Convert.ToDateTime(editekstre.Text.ToString());
            kartid.paymentDueDate = Convert.ToDateTime(editekstreson.Text.ToString());
            kartid.balance = editkartlimit.Text.ToString();
            db.SaveChanges();
            MessageBox.Show("Kart Bilgileri Düzenlendi");
            
        }

        private void editkart_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kartid = db.CreditCard.Where(x => x.bankName == editkart.Text).FirstOrDefault();

            CreditCard editcard = new CreditCard();
            editkartname.Text = kartid.nameSurname;
            editcardnumber.Text = kartid.number;
            editenddate.Text = kartid.expireDate;
            editccv.Text = kartid.ccv.ToString();
            editekstre.Value= Convert.ToDateTime(kartid.cutDate);
            editekstreson.Value= Convert.ToDateTime(kartid.paymentDueDate);
            editkartlimit.Text= kartid.balance.ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
