using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestTakipSistemi_Demo
{
    public partial class Form_Yeni_Test : Form
    {

       public Form_Main Form_Main;// = new Form_Main();

        public Form_Yeni_Test()
        {
            InitializeComponent();
        }

        private void B_Iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_OK_Click(object sender, EventArgs e)
        {

            if (CB_TestBolgesi.Text != "" && CB_Test_Adi.Text != "" && CB_Test_Bankosu.Text != "" && CB_Test_Sorumlusu.Text != "" && Num_Set_Cycle.Value > 0)
            {
                     
            DialogResult result = MessageBox.Show("Girilen bilgilere göre yeni testi oluşturmak istediğinizden emin misiniz?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

         if (result == DialogResult.Yes)
         {
             if (CB_TestBolgesi.Text == "TEST 1")
             {
                 Form_Main.LB_T1_Ad.Text = CB_Test_Adi.Text;
                 Form_Main.LB_T1_Banko.Text = CB_Test_Bankosu.Text;
                 Form_Main.LB_T1_Sorumlu.Text = CB_Test_Sorumlusu.Text;

                 Form_Main.LB_T1_Bas_Tarih.Text = Date_Bas_Tarih.Text;
                 Form_Main.LB_T1_Bit_Tarih.Text = Date_Bit_Tarih.Text;
             }

             if (CB_TestBolgesi.Text == "TEST 2")
             {
                 Form_Main.LB_T2_Ad.Text = CB_Test_Adi.Text;
                 Form_Main.LB_T2_Banko.Text = CB_Test_Bankosu.Text;
                 Form_Main.LB_T2_Sorumlu.Text = CB_Test_Sorumlusu.Text;

                 Form_Main.LB_T2_Bas_Tarih.Text = Date_Bas_Tarih.Text;
                 Form_Main.LB_T2_Bit_Tarih.Text = Date_Bit_Tarih.Text;
             }

             if (CB_TestBolgesi.Text == "TEST 3")
             {
                 Form_Main.LB_T3_Ad.Text = CB_Test_Adi.Text;
                 Form_Main.LB_T3_Banko.Text = CB_Test_Bankosu.Text;
                 Form_Main.LB_T3_Sorumlu.Text = CB_Test_Sorumlusu.Text;

                 Form_Main.LB_T3_Bas_Tarih.Text = Date_Bas_Tarih.Text;
                 Form_Main.LB_T3_Bit_Tarih.Text = Date_Bit_Tarih.Text;
             }


             if (CB_TestBolgesi.Text == "TEST 4")
             {
                 Form_Main.LB_T4_Ad.Text = CB_Test_Adi.Text;
                 Form_Main.LB_T4_Banko.Text = CB_Test_Bankosu.Text;
                 Form_Main.LB_T4_Sorumlu.Text = CB_Test_Sorumlusu.Text;

                 Form_Main.LB_T4_Bas_Tarih.Text = Date_Bas_Tarih.Text;
                 Form_Main.LB_T4_Bit_Tarih.Text = Date_Bit_Tarih.Text;
             }


             this.Close();
         }

            }
            else
            {
                DialogResult result = MessageBox.Show("Eksik ya da hatalı bilgi girişi! Bilgileri lütfen tekrar kontrol ediniz.", "Eksik ya da Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
 
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
