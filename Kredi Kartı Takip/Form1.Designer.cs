
namespace Kredi_Kartı_Takip
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cardCCV = new System.Windows.Forms.Label();
            this.cardDate = new System.Windows.Forms.Label();
            this.cardNumber = new System.Windows.Forms.Label();
            this.cardName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cardlastpay = new System.Windows.Forms.Label();
            this.cardekstrekesim = new System.Windows.Forms.Label();
            this.cardbuay = new System.Windows.Forms.Label();
            this.cardKullnabilir = new System.Windows.Forms.Label();
            this.cardlimit = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.carddonem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfInstallments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installmentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aggregateAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditCardTrackingDataSet = new Kredi_Kartı_Takip.CreditCardTrackingDataSet();
            this.creditCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creditCardTableAdapter = new Kredi_Kartı_Takip.CreditCardTrackingDataSetTableAdapters.CreditCardTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCardTrackingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.cardCCV);
            this.groupBox2.Controls.Add(this.cardDate);
            this.groupBox2.Controls.Add(this.cardNumber);
            this.groupBox2.Controls.Add(this.cardName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(160, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kart Bilgileri";
            // 
            // cardCCV
            // 
            this.cardCCV.AutoSize = true;
            this.cardCCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cardCCV.Location = new System.Drawing.Point(538, 50);
            this.cardCCV.Name = "cardCCV";
            this.cardCCV.Size = new System.Drawing.Size(32, 16);
            this.cardCCV.TabIndex = 7;
            this.cardCCV.Text = "833";
            // 
            // cardDate
            // 
            this.cardDate.AutoSize = true;
            this.cardDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cardDate.Location = new System.Drawing.Point(392, 48);
            this.cardDate.Name = "cardDate";
            this.cardDate.Size = new System.Drawing.Size(45, 16);
            this.cardDate.TabIndex = 6;
            this.cardDate.Text = "09/22";
            // 
            // cardNumber
            // 
            this.cardNumber.AutoSize = true;
            this.cardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cardNumber.Location = new System.Drawing.Point(167, 50);
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.Size = new System.Drawing.Size(167, 16);
            this.cardNumber.TabIndex = 5;
            this.cardNumber.Text = "XXXX-XXXX-XXXX-XXXX";
            // 
            // cardName
            // 
            this.cardName.AutoSize = true;
            this.cardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cardName.Location = new System.Drawing.Point(25, 50);
            this.cardName.Name = "cardName";
            this.cardName.Size = new System.Drawing.Size(104, 16);
            this.cardName.TabIndex = 4;
            this.cardName.Text = "Bahadır Kayış";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CCV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Son Kullanma Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kart Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kart Üzerindeki İsim";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cardlastpay);
            this.groupBox3.Controls.Add(this.cardekstrekesim);
            this.groupBox3.Controls.Add(this.cardbuay);
            this.groupBox3.Controls.Add(this.cardKullnabilir);
            this.groupBox3.Controls.Add(this.cardlimit);
            this.groupBox3.Location = new System.Drawing.Point(804, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 200);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bakiye Bilgileri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Son Kesim Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ekstre Kesim Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Bu Ay Ödenecek Tutar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kullanılabilir Bakiye";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kart Limiti";
            // 
            // cardlastpay
            // 
            this.cardlastpay.AutoSize = true;
            this.cardlastpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cardlastpay.Location = new System.Drawing.Point(178, 168);
            this.cardlastpay.Name = "cardlastpay";
            this.cardlastpay.Size = new System.Drawing.Size(28, 15);
            this.cardlastpay.TabIndex = 4;
            this.cardlastpay.Text = "xxx";
            // 
            // cardekstrekesim
            // 
            this.cardekstrekesim.AutoSize = true;
            this.cardekstrekesim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cardekstrekesim.Location = new System.Drawing.Point(178, 135);
            this.cardekstrekesim.Name = "cardekstrekesim";
            this.cardekstrekesim.Size = new System.Drawing.Size(28, 15);
            this.cardekstrekesim.TabIndex = 3;
            this.cardekstrekesim.Text = "xxx";
            // 
            // cardbuay
            // 
            this.cardbuay.AutoSize = true;
            this.cardbuay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cardbuay.Location = new System.Drawing.Point(178, 100);
            this.cardbuay.Name = "cardbuay";
            this.cardbuay.Size = new System.Drawing.Size(29, 16);
            this.cardbuay.TabIndex = 2;
            this.cardbuay.Text = "xxx";
            // 
            // cardKullnabilir
            // 
            this.cardKullnabilir.AutoSize = true;
            this.cardKullnabilir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cardKullnabilir.Location = new System.Drawing.Point(178, 62);
            this.cardKullnabilir.Name = "cardKullnabilir";
            this.cardKullnabilir.Size = new System.Drawing.Size(29, 16);
            this.cardKullnabilir.TabIndex = 1;
            this.cardKullnabilir.Text = "xxx";
            // 
            // cardlimit
            // 
            this.cardlimit.AutoSize = true;
            this.cardlimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cardlimit.Location = new System.Drawing.Point(178, 29);
            this.cardlimit.Name = "cardlimit";
            this.cardlimit.Size = new System.Drawing.Size(29, 16);
            this.cardlimit.TabIndex = 0;
            this.cardlimit.Text = "xxx";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.bankName,
            this.companyName,
            this.productCategory,
            this.numberOfInstallments,
            this.installmentAmount,
            this.aggregateAmount,
            this.addDate,
            this.mailOrder,
            this.idDataGridViewTextBoxColumn,
            this.bankNameDataGridViewTextBoxColumn,
            this.nameSurnameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.expireDateDataGridViewTextBoxColumn,
            this.ccvDataGridViewTextBoxColumn,
            this.cutDateDataGridViewTextBoxColumn,
            this.paymentDueDateDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.creditCardBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(160, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(951, 330);
            this.dataGridView1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(479, 610);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kart Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(632, 610);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Harcama ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1102, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Dönem İçi Harcanan tutar";
            // 
            // carddonem
            // 
            this.carddonem.AutoSize = true;
            this.carddonem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carddonem.Location = new System.Drawing.Point(1129, 41);
            this.carddonem.Name = "carddonem";
            this.carddonem.Size = new System.Drawing.Size(88, 16);
            this.carddonem.TabIndex = 7;
            this.carddonem.Text = "100.000.000";
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::Kredi_Kartı_Takip.Properties.Resources.removee;
            this.button1.Location = new System.Drawing.Point(1259, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 25);
            this.button1.TabIndex = 8;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // bankName
            // 
            this.bankName.HeaderText = "Kart Adı";
            this.bankName.Name = "bankName";
            // 
            // companyName
            // 
            this.companyName.HeaderText = "Alınan Şirket Adı";
            this.companyName.Name = "companyName";
            // 
            // productCategory
            // 
            this.productCategory.HeaderText = "Alınan Kategori";
            this.productCategory.Name = "productCategory";
            // 
            // numberOfInstallments
            // 
            this.numberOfInstallments.HeaderText = "Taksit Sayısı";
            this.numberOfInstallments.Name = "numberOfInstallments";
            // 
            // installmentAmount
            // 
            this.installmentAmount.HeaderText = "Taksit Tutarı";
            this.installmentAmount.Name = "installmentAmount";
            // 
            // aggregateAmount
            // 
            this.aggregateAmount.HeaderText = "Toplam Tutar";
            this.aggregateAmount.Name = "aggregateAmount";
            // 
            // addDate
            // 
            this.addDate.HeaderText = "Alınan Tarih";
            this.addDate.Name = "addDate";
            // 
            // mailOrder
            // 
            this.mailOrder.HeaderText = "Mail Order";
            this.mailOrder.Name = "mailOrder";
            // 
            // creditCardTrackingDataSet
            // 
            this.creditCardTrackingDataSet.DataSetName = "CreditCardTrackingDataSet";
            this.creditCardTrackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // creditCardBindingSource
            // 
            this.creditCardBindingSource.DataMember = "CreditCard";
            this.creditCardBindingSource.DataSource = this.creditCardTrackingDataSet;
            // 
            // creditCardTableAdapter
            // 
            this.creditCardTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankNameDataGridViewTextBoxColumn
            // 
            this.bankNameDataGridViewTextBoxColumn.DataPropertyName = "bankName";
            this.bankNameDataGridViewTextBoxColumn.HeaderText = "bankName";
            this.bankNameDataGridViewTextBoxColumn.Name = "bankNameDataGridViewTextBoxColumn";
            // 
            // nameSurnameDataGridViewTextBoxColumn
            // 
            this.nameSurnameDataGridViewTextBoxColumn.DataPropertyName = "nameSurname";
            this.nameSurnameDataGridViewTextBoxColumn.HeaderText = "nameSurname";
            this.nameSurnameDataGridViewTextBoxColumn.Name = "nameSurnameDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // expireDateDataGridViewTextBoxColumn
            // 
            this.expireDateDataGridViewTextBoxColumn.DataPropertyName = "expireDate";
            this.expireDateDataGridViewTextBoxColumn.HeaderText = "expireDate";
            this.expireDateDataGridViewTextBoxColumn.Name = "expireDateDataGridViewTextBoxColumn";
            // 
            // ccvDataGridViewTextBoxColumn
            // 
            this.ccvDataGridViewTextBoxColumn.DataPropertyName = "ccv";
            this.ccvDataGridViewTextBoxColumn.HeaderText = "ccv";
            this.ccvDataGridViewTextBoxColumn.Name = "ccvDataGridViewTextBoxColumn";
            // 
            // cutDateDataGridViewTextBoxColumn
            // 
            this.cutDateDataGridViewTextBoxColumn.DataPropertyName = "cutDate";
            this.cutDateDataGridViewTextBoxColumn.HeaderText = "cutDate";
            this.cutDateDataGridViewTextBoxColumn.Name = "cutDateDataGridViewTextBoxColumn";
            // 
            // paymentDueDateDataGridViewTextBoxColumn
            // 
            this.paymentDueDateDataGridViewTextBoxColumn.DataPropertyName = "paymentDueDate";
            this.paymentDueDateDataGridViewTextBoxColumn.HeaderText = "paymentDueDate";
            this.paymentDueDateDataGridViewTextBoxColumn.Name = "paymentDueDateDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1290, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.carddonem);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCardTrackingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCardBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label cardCCV;
        private System.Windows.Forms.Label cardDate;
        private System.Windows.Forms.Label cardNumber;
        private System.Windows.Forms.Label cardName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label cardlastpay;
        private System.Windows.Forms.Label cardekstrekesim;
        private System.Windows.Forms.Label cardbuay;
        private System.Windows.Forms.Label cardKullnabilir;
        private System.Windows.Forms.Label cardlimit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label carddonem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfInstallments;
        private System.Windows.Forms.DataGridViewTextBoxColumn installmentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn aggregateAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailOrder;
        private CreditCardTrackingDataSet creditCardTrackingDataSet;
        private System.Windows.Forms.BindingSource creditCardBindingSource;
        private CreditCardTrackingDataSetTableAdapters.CreditCardTableAdapter creditCardTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
    }
}

