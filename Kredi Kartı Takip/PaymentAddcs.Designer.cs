﻿
namespace Kredi_Kartı_Takip
{
    partial class PaymentAddcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfIns = new System.Windows.Forms.TextBox();
            this.insAmoun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aggreAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kartlar = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.expenseAdd = new System.Windows.Forms.Button();
            this.addDate = new System.Windows.Forms.DateTimePicker();
            this.firmatext = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.productCategory = new System.Windows.Forms.TextBox();
            this.alinanfirma = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.paymentDueDate = new System.Windows.Forms.DateTimePicker();
            this.cutDate = new System.Windows.Forms.DateTimePicker();
            this.expireDate = new System.Windows.Forms.TextBox();
            this.bankName = new System.Windows.Forms.TextBox();
            this.cardAdd = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.TextBox();
            this.ccv = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.nameSurname = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taksit Sayısı";
            // 
            // numberOfIns
            // 
            this.numberOfIns.Location = new System.Drawing.Point(86, 150);
            this.numberOfIns.Name = "numberOfIns";
            this.numberOfIns.Size = new System.Drawing.Size(119, 20);
            this.numberOfIns.TabIndex = 1;
            this.numberOfIns.Text = "0";
            this.numberOfIns.TextChanged += new System.EventHandler(this.numberOfIns_TextChanged);
            // 
            // insAmoun
            // 
            this.insAmoun.Location = new System.Drawing.Point(86, 195);
            this.insAmoun.Name = "insAmoun";
            this.insAmoun.Size = new System.Drawing.Size(119, 20);
            this.insAmoun.TabIndex = 3;
            this.insAmoun.Text = "0";
            this.insAmoun.TextChanged += new System.EventHandler(this.insAmoun_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Taksit tutarı";
            // 
            // aggreAmount
            // 
            this.aggreAmount.Location = new System.Drawing.Point(84, 231);
            this.aggreAmount.Name = "aggreAmount";
            this.aggreAmount.Size = new System.Drawing.Size(121, 20);
            this.aggreAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Toplam Tutar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "eklenen tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kart Seç";
            // 
            // kartlar
            // 
            this.kartlar.FormattingEnabled = true;
            this.kartlar.Location = new System.Drawing.Point(84, 34);
            this.kartlar.Name = "kartlar";
            this.kartlar.Size = new System.Drawing.Size(121, 21);
            this.kartlar.TabIndex = 9;
            this.kartlar.Text = "Kart Seçiniz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.expenseAdd);
            this.groupBox1.Controls.Add(this.addDate);
            this.groupBox1.Controls.Add(this.firmatext);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.productCategory);
            this.groupBox1.Controls.Add(this.alinanfirma);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numberOfIns);
            this.groupBox1.Controls.Add(this.kartlar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.insAmoun);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.aggreAmount);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 500);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Harcama Ekle";
            // 
            // expenseAdd
            // 
            this.expenseAdd.Location = new System.Drawing.Point(102, 416);
            this.expenseAdd.Name = "expenseAdd";
            this.expenseAdd.Size = new System.Drawing.Size(75, 23);
            this.expenseAdd.TabIndex = 18;
            this.expenseAdd.Text = "Ekle";
            this.expenseAdd.UseVisualStyleBackColor = true;
            this.expenseAdd.Click += new System.EventHandler(this.expenseAdd_Click);
            // 
            // addDate
            // 
            this.addDate.Location = new System.Drawing.Point(86, 279);
            this.addDate.Name = "addDate";
            this.addDate.Size = new System.Drawing.Size(149, 20);
            this.addDate.TabIndex = 17;
            // 
            // firmatext
            // 
            this.firmatext.Location = new System.Drawing.Point(211, 70);
            this.firmatext.Name = "firmatext";
            this.firmatext.Size = new System.Drawing.Size(119, 20);
            this.firmatext.TabIndex = 16;
            this.firmatext.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(131, 305);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Mail Order";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // productCategory
            // 
            this.productCategory.Location = new System.Drawing.Point(84, 111);
            this.productCategory.Name = "productCategory";
            this.productCategory.Size = new System.Drawing.Size(121, 20);
            this.productCategory.TabIndex = 14;
            // 
            // alinanfirma
            // 
            this.alinanfirma.FormattingEnabled = true;
            this.alinanfirma.Items.AddRange(new object[] {
            "N11",
            "Trendyol",
            "Hepsiburada",
            "Diğer"});
            this.alinanfirma.Location = new System.Drawing.Point(84, 69);
            this.alinanfirma.Name = "alinanfirma";
            this.alinanfirma.Size = new System.Drawing.Size(121, 21);
            this.alinanfirma.TabIndex = 13;
            this.alinanfirma.Text = "Alınan Firma seç";
            this.alinanfirma.SelectedIndexChanged += new System.EventHandler(this.alinanfirma_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Firma";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ürün kategori";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.paymentDueDate);
            this.groupBox2.Controls.Add(this.cutDate);
            this.groupBox2.Controls.Add(this.expireDate);
            this.groupBox2.Controls.Add(this.bankName);
            this.groupBox2.Controls.Add(this.cardAdd);
            this.groupBox2.Controls.Add(this.balance);
            this.groupBox2.Controls.Add(this.ccv);
            this.groupBox2.Controls.Add(this.number);
            this.groupBox2.Controls.Add(this.nameSurname);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(619, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 487);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kart Ekle";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // paymentDueDate
            // 
            this.paymentDueDate.Location = new System.Drawing.Point(159, 250);
            this.paymentDueDate.Name = "paymentDueDate";
            this.paymentDueDate.Size = new System.Drawing.Size(175, 20);
            this.paymentDueDate.TabIndex = 26;
            // 
            // cutDate
            // 
            this.cutDate.Location = new System.Drawing.Point(159, 215);
            this.cutDate.Name = "cutDate";
            this.cutDate.Size = new System.Drawing.Size(175, 20);
            this.cutDate.TabIndex = 25;
            // 
            // expireDate
            // 
            this.expireDate.Location = new System.Drawing.Point(159, 143);
            this.expireDate.Name = "expireDate";
            this.expireDate.Size = new System.Drawing.Size(121, 20);
            this.expireDate.TabIndex = 24;
            // 
            // bankName
            // 
            this.bankName.Location = new System.Drawing.Point(159, 41);
            this.bankName.Name = "bankName";
            this.bankName.Size = new System.Drawing.Size(121, 20);
            this.bankName.TabIndex = 23;
            // 
            // cardAdd
            // 
            this.cardAdd.Location = new System.Drawing.Point(120, 393);
            this.cardAdd.Name = "cardAdd";
            this.cardAdd.Size = new System.Drawing.Size(75, 33);
            this.cardAdd.TabIndex = 22;
            this.cardAdd.Text = "Ekle";
            this.cardAdd.UseVisualStyleBackColor = true;
            this.cardAdd.Click += new System.EventHandler(this.cardAdd_Click);
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(159, 289);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(121, 20);
            this.balance.TabIndex = 21;
            this.balance.TextChanged += new System.EventHandler(this.balance_TextChanged);
            // 
            // ccv
            // 
            this.ccv.Location = new System.Drawing.Point(159, 179);
            this.ccv.Name = "ccv";
            this.ccv.Size = new System.Drawing.Size(121, 20);
            this.ccv.TabIndex = 18;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(159, 117);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(121, 20);
            this.number.TabIndex = 16;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // nameSurname
            // 
            this.nameSurname.Location = new System.Drawing.Point(159, 89);
            this.nameSurname.Name = "nameSurname";
            this.nameSurname.Size = new System.Drawing.Size(121, 20);
            this.nameSurname.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 292);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Bakiye";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Ekstre Son ödeme Tarihi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Ekstre Kesim Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "CCV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Son Kullanım Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kart Numarası";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hangi Banka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kart Üzerindeki İsim";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(503, 489);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 12;
            this.back.Text = "Geri";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // PaymentAddcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 557);
            this.Controls.Add(this.back);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaymentAddcs";
            this.Text = "PaymentAddcs";
            this.Load += new System.EventHandler(this.PaymentAddcs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberOfIns;
        private System.Windows.Forms.TextBox insAmoun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aggreAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox kartlar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox productCategory;
        private System.Windows.Forms.ComboBox alinanfirma;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.TextBox ccv;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox nameSurname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cardAdd;
        private System.Windows.Forms.TextBox bankName;
        private System.Windows.Forms.TextBox expireDate;
        private System.Windows.Forms.DateTimePicker paymentDueDate;
        private System.Windows.Forms.DateTimePicker cutDate;
        private System.Windows.Forms.TextBox firmatext;
        private System.Windows.Forms.DateTimePicker addDate;
        private System.Windows.Forms.Button expenseAdd;
        private System.Windows.Forms.Button back;
    }
}