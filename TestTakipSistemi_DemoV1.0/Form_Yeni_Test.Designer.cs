namespace TestTakipSistemi_Demo
{
    partial class Form_Yeni_Test
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
            this.CB_TestBolgesi = new System.Windows.Forms.ComboBox();
            this.CB_Test_Adi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Test_Bankosu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Test_Sorumlusu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Date_Bas_Tarih = new System.Windows.Forms.DateTimePicker();
            this.Date_Bit_Tarih = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Num_Set_Cycle = new System.Windows.Forms.NumericUpDown();
            this.B_OK = new System.Windows.Forms.Button();
            this.B_Iptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Set_Cycle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TEST BÖLGESİ :";
            // 
            // CB_TestBolgesi
            // 
            this.CB_TestBolgesi.FormattingEnabled = true;
            this.CB_TestBolgesi.Items.AddRange(new object[] {
            "TEST 1",
            "TEST 2",
            "TEST 3",
            "TEST 4"});
            this.CB_TestBolgesi.Location = new System.Drawing.Point(124, 5);
            this.CB_TestBolgesi.Name = "CB_TestBolgesi";
            this.CB_TestBolgesi.Size = new System.Drawing.Size(157, 21);
            this.CB_TestBolgesi.TabIndex = 1;
            // 
            // CB_Test_Adi
            // 
            this.CB_Test_Adi.FormattingEnabled = true;
            this.CB_Test_Adi.Items.AddRange(new object[] {
            "HIZLI",
            "OFKELİ",
            "YAVAŞ",
            "SAKİN"});
            this.CB_Test_Adi.Location = new System.Drawing.Point(124, 31);
            this.CB_Test_Adi.Name = "CB_Test_Adi";
            this.CB_Test_Adi.Size = new System.Drawing.Size(157, 21);
            this.CB_Test_Adi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TEST ADI :";
            // 
            // CB_Test_Bankosu
            // 
            this.CB_Test_Bankosu.FormattingEnabled = true;
            this.CB_Test_Bankosu.Items.AddRange(new object[] {
            "BANKO 1",
            "BANKO 2",
            "BANKO 3",
            "BANKO 4",
            "BANKO 5"});
            this.CB_Test_Bankosu.Location = new System.Drawing.Point(124, 58);
            this.CB_Test_Bankosu.Name = "CB_Test_Bankosu";
            this.CB_Test_Bankosu.Size = new System.Drawing.Size(157, 21);
            this.CB_Test_Bankosu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TEST BANKOSU :";
            // 
            // CB_Test_Sorumlusu
            // 
            this.CB_Test_Sorumlusu.FormattingEnabled = true;
            this.CB_Test_Sorumlusu.Items.AddRange(new object[] {
            "Ahmet",
            "Hüseyin",
            "Deniz",
            "Murat",
            "Cihan"});
            this.CB_Test_Sorumlusu.Location = new System.Drawing.Point(124, 85);
            this.CB_Test_Sorumlusu.Name = "CB_Test_Sorumlusu";
            this.CB_Test_Sorumlusu.Size = new System.Drawing.Size(157, 21);
            this.CB_Test_Sorumlusu.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TEST SORUMLUSU :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "TEST BAŞLANGIÇ TARİHİ :";
            // 
            // Date_Bas_Tarih
            // 
            this.Date_Bas_Tarih.Location = new System.Drawing.Point(461, 6);
            this.Date_Bas_Tarih.Name = "Date_Bas_Tarih";
            this.Date_Bas_Tarih.Size = new System.Drawing.Size(166, 20);
            this.Date_Bas_Tarih.TabIndex = 9;
            // 
            // Date_Bit_Tarih
            // 
            this.Date_Bit_Tarih.Location = new System.Drawing.Point(461, 32);
            this.Date_Bit_Tarih.Name = "Date_Bit_Tarih";
            this.Date_Bit_Tarih.Size = new System.Drawing.Size(166, 20);
            this.Date_Bit_Tarih.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "TEST BİTİŞ TARİHİ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "SET CYCLE :";
            // 
            // Num_Set_Cycle
            // 
            this.Num_Set_Cycle.Location = new System.Drawing.Point(124, 112);
            this.Num_Set_Cycle.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.Num_Set_Cycle.Name = "Num_Set_Cycle";
            this.Num_Set_Cycle.Size = new System.Drawing.Size(156, 20);
            this.Num_Set_Cycle.TabIndex = 14;
            this.Num_Set_Cycle.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // B_OK
            // 
            this.B_OK.Location = new System.Drawing.Point(552, 152);
            this.B_OK.Name = "B_OK";
            this.B_OK.Size = new System.Drawing.Size(75, 23);
            this.B_OK.TabIndex = 15;
            this.B_OK.Text = "OK";
            this.B_OK.UseVisualStyleBackColor = true;
            this.B_OK.Click += new System.EventHandler(this.B_OK_Click);
            // 
            // B_Iptal
            // 
            this.B_Iptal.Location = new System.Drawing.Point(471, 152);
            this.B_Iptal.Name = "B_Iptal";
            this.B_Iptal.Size = new System.Drawing.Size(75, 23);
            this.B_Iptal.TabIndex = 16;
            this.B_Iptal.Text = "İptal";
            this.B_Iptal.UseVisualStyleBackColor = true;
            this.B_Iptal.Click += new System.EventHandler(this.B_Iptal_Click);
            // 
            // Form_Yeni_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 178);
            this.Controls.Add(this.B_Iptal);
            this.Controls.Add(this.B_OK);
            this.Controls.Add(this.Num_Set_Cycle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Date_Bit_Tarih);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Date_Bas_Tarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CB_Test_Sorumlusu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_Test_Bankosu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_Test_Adi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_TestBolgesi);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Yeni_Test";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Test Oluştur";
            ((System.ComponentModel.ISupportInitialize)(this.Num_Set_Cycle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox CB_TestBolgesi;
        public System.Windows.Forms.ComboBox CB_Test_Adi;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox CB_Test_Bankosu;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox CB_Test_Sorumlusu;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker Date_Bas_Tarih;
        public System.Windows.Forms.DateTimePicker Date_Bit_Tarih;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.NumericUpDown Num_Set_Cycle;
        private System.Windows.Forms.Button B_OK;
        private System.Windows.Forms.Button B_Iptal;

    }
}