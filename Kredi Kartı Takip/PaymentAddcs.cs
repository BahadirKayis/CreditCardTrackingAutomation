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
            CreditCard newcard = new CreditCard();
            newcard.bankName = bankName.Text.ToString();
            newcard.nameSurname = nameSurname.Text.ToString();
            newcard.number = number.Text.ToString();
            newcard.expireDate = expireDate.Text.ToString();
            newcard.ccv = Convert.ToInt32(ccv.Text.ToString());
            newcard.cutDate = Convert.ToDateTime(cutDate.Text.ToString());
            newcard.paymentDueDate = Convert.ToDateTime(paymentDueDate.Text.ToString());
            newcard.balance = Convert.ToString(balance.Text.ToString());
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
            AddExpense neweExpense = new AddExpense();
            var kartid = db.CreditCard.Where(x => x.bankName == kartlar.Text).FirstOrDefault();
            neweExpense.cardId = kartid.id;
            if (alinanfirma.Text=="Diğer")
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
            neweExpense.aggregateAmount = aggreAmount.Text.ToString();   
            neweExpense.addDate = Convert.ToDateTime(addDate.Text.ToString());
            // 0 ise mail order
            if (checkBox1.Checked==true)
            {
                neweExpense.mailOrder = 0;
            }
            else
            {
                neweExpense.mailOrder = 1;
            }

            db.AddExpense.Add(neweExpense);
            db.SaveChanges();
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            MessageBox.Show("Harcama Eklendi");


        }

        private void numberOfIns_TextChanged(object sender, EventArgs e)

        {
            int taksit_sayisi=0, taksit_tutarı=0;
            if (numberOfIns.Text.ToString()!="")
            {
                taksit_sayisi = Convert.ToInt32(numberOfIns.Text.ToString());

            }
            if (insAmoun.Text.ToString()!="")
            {
                taksit_tutarı = Convert.ToInt32(insAmoun.Text.ToString());

            }


            double toplam_tutar = taksit_sayisi * taksit_tutarı;

            aggreAmount.Text = toplam_tutar.ToString();
        }

        private void insAmoun_TextChanged(object sender, EventArgs e)
        {
            int taksit_sayisi = 0, taksit_tutarı = 0;
            if (numberOfIns.Text.ToString() != "")
            {
                taksit_sayisi = Convert.ToInt32(numberOfIns.Text.ToString());

            }
            if (insAmoun.Text.ToString() != "")
            {
                taksit_tutarı = Convert.ToInt32(insAmoun.Text.ToString());

            }


            double toplam_tutar = taksit_sayisi * taksit_tutarı;

            aggreAmount.Text = toplam_tutar.ToString();
        }
    }
}
