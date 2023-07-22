//21.09.2017 ID
//V1.0.0 Demo Version
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
    public partial class Form_Main : Form
    {
        #region GLobal_Variable
        Form_Yeni_Test Form_Yeni_Test = new Form_Yeni_Test();
        Form_Yeni_Not Form_Yeni_Not = new Form_Yeni_Not();
        #endregion

        #region Form_Function
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Form_Yeni_Test.Form_Main = this;
            Form_Yeni_Not.Form_Main = this;
        }
        #endregion

        #region Screen_Button
        private void B_Gizle_Click(object sender, EventArgs e)
        {
            Split_Main.Panel1Collapsed = true;
            B_Ac.Visible = true;
        }

        private void B_Ac_Click(object sender, EventArgs e)
        {
            Split_Main.Panel1Collapsed = false;
            B_Ac.Visible = false;
        }

        private void B_Yeni_Test_Olustur_Click(object sender, EventArgs e)
        {
            Form_Yeni_Test.ShowDialog();
        }

        private void B_T1_Not_Ekle_Click(object sender, EventArgs e)
        {
        //    RTB_T1.Text = RTB_T1.Text + "\n"+ "Merhaba";
            Form_Yeni_Not.ShowDialog();
          //  Log_T1("SELAMLAR");
        }

        #endregion

        #region Tooltip_Bonus
        private void B_Ac_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.B_Ac, "Kullanıcı Menüsünü Aç");
        }
        private void B_Gizle_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.B_Gizle, "Kullanıcı Menüsünü Gizle");
        }
        private void LB_Giris_Hata_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.LB_Giris_Hata, "Hatalı Kullanıcı adı ya da Şifre. \n Lütfen tekrar deneyiniz.");
        }
        #endregion

        #region Operation_Button
        private void B_T1_Start_Click(object sender, EventArgs e)
        {
          DialogResult PauseResult = MessageBox.Show("Testi girdiğiniz parametreler ile başlatmak istediğinizden emin misiniz?", "TEST BAŞLATILIYOR!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

          if (PauseResult == DialogResult.Yes)
          {
              T1_System_Knt(true, false, false);

              Log_TempSave_T1();
              Log_TempSave_T2();
              Log_TempSave_T3();
              Log_TempSave_T4();

              Log_T1("Test başladı.", Color.Blue);
          }
        }

        private void B_T1_Pause_Click(object sender, EventArgs e)
        {
            DialogResult PauseResult = MessageBox.Show("Testi bekleme moduna almak istediğinizden emin misiniz?", "TEST BEKLEME MODUNA ALINIYOR!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (PauseResult == DialogResult.Yes)
            {
                T1_System_Knt(false, true, false);
                Log_T1("Test Bekleme moduna alındı.", Color.DarkOrange);
            }
        }

        private void B_T1_Stop_Click(object sender, EventArgs e)
        {
            DialogResult StopResult = MessageBox.Show("Eğer testi durdurursanız test iptal edilecek ve test verileri sıfırlanacak. \n Testi gerçekten durdurmak istediğinizden emin misiniz?", "TEST İPTAL EDİLİYOR!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (StopResult == DialogResult.Yes)
            {
                T1_System_Knt(false, false, true);

                Bar_T1.Value = 0;
                LB_Yuzde_T1.Text = "% " + Bar_T1.Value.ToString();
                LB_T1_IslemTamam.Visible = false;

                Log_T1("Test iptal edildi. Değerler kaydedilmeden silindi.", Color.Red);
            }
        }

        private void B_T2_Start_Click(object sender, EventArgs e)
        {
            DialogResult PauseResult = MessageBox.Show("Testi girdiğiniz parametreler ile başlatmak istediğinizden emin misiniz?", "TEST BAŞLATILIYOR!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (PauseResult == DialogResult.Yes)
            {
                B_T2_Start.Enabled = false;
                B_T2_Pause.Enabled = true;
                B_T2_Stop.Enabled = true;
                LB_T2_Led.BackColor = Color.LawnGreen;
            }
        }

        private void B_T2_Pause_Click(object sender, EventArgs e)
        {
            DialogResult PauseResult = MessageBox.Show("Testi bekleme moduna almak istediğinizden emin misiniz?", "TEST BEKLEME MODUNA ALINIYOR!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (PauseResult == DialogResult.Yes)
            {
                B_T2_Start.Enabled = true;
                B_T2_Pause.Enabled = false;
                B_T2_Stop.Enabled = true;
                LB_T2_Led.BackColor = Color.Yellow;
            }
        }

        private void B_T2_Stop_Click(object sender, EventArgs e)
        {
            DialogResult StopResult = MessageBox.Show("Eğer testi durdurursanız test iptal edilecek ve test verileri sıfırlanacak. \n Testi gerçekten durdurmak istediğinizden emin misiniz?", "TEST İPTAL EDİLİYOR!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (StopResult == DialogResult.Yes)
            {
                B_T2_Start.Enabled = true;
                B_T2_Pause.Enabled = false;
                B_T2_Stop.Enabled = false;
                LB_T2_Led.BackColor = Color.Transparent;
            }
        }

        private void B_T3_Start_Click(object sender, EventArgs e)
        {
            DialogResult PauseResult = MessageBox.Show("Testi girdiğiniz parametreler ile başlatmak istediğinizden emin misiniz?", "TEST BAŞLATILIYOR!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (PauseResult == DialogResult.Yes)
            {
                B_T3_Start.Enabled = false;
                B_T3_Pause.Enabled = true;
                B_T3_Stop.Enabled = true;
                LB_T3_Led.BackColor = Color.LawnGreen;
            }
        }

        private void B_T3_Pause_Click(object sender, EventArgs e)
        {
            DialogResult PauseResult = MessageBox.Show("Testi bekleme moduna almak istediğinizden emin misiniz?", "TEST BEKLEME MODUNA ALINIYOR!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (PauseResult == DialogResult.Yes)
            {
                B_T3_Start.Enabled = true;
                B_T3_Pause.Enabled = false;
                B_T3_Stop.Enabled = true;
                LB_T3_Led.BackColor = Color.Yellow;
            }
        }

        private void B_T3_Stop_Click(object sender, EventArgs e)
        {
            DialogResult StopResult = MessageBox.Show("Eğer testi durdurursanız test iptal edilecek ve test verileri sıfırlanacak. \n Testi gerçekten durdurmak istediğinizden emin misiniz?", "TEST İPTAL EDİLİYOR!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (StopResult == DialogResult.Yes)
            {
                B_T3_Start.Enabled = true;
                B_T3_Pause.Enabled = false;
                B_T3_Stop.Enabled = false;
                LB_T3_Led.BackColor = Color.Transparent;
            }
        }

        private void B_T4_Start_Click(object sender, EventArgs e)
        {
            DialogResult PauseResult = MessageBox.Show("Testi girdiğiniz parametreler ile başlatmak istediğinizden emin misiniz?", "TEST BAŞLATILIYOR!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (PauseResult == DialogResult.Yes)
            {
                B_T4_Start.Enabled = false;
                B_T4_Pause.Enabled = true;
                B_T4_Stop.Enabled = true;
                LB_T4_Led.BackColor = Color.LawnGreen;
            }
        }

        private void B_T4_Pause_Click(object sender, EventArgs e)
        {
            DialogResult PauseResult = MessageBox.Show("Testi bekleme moduna almak istediğinizden emin misiniz?", "TEST BEKLEME MODUNA ALINIYOR!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (PauseResult == DialogResult.Yes)
            {
                B_T4_Start.Enabled = true;
                B_T4_Pause.Enabled = false;
                B_T4_Stop.Enabled = true;
                LB_T4_Led.BackColor = Color.Yellow;
            }
        }

        private void B_T4_Stop_Click(object sender, EventArgs e)
        {
            DialogResult StopResult = MessageBox.Show("Eğer testi durdurursanız test iptal edilecek ve test verileri sıfırlanacak. \n Testi gerçekten durdurmak istediğinizden emin misiniz?", "TEST İPTAL EDİLİYOR!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (StopResult == DialogResult.Yes)
            {
                B_T4_Start.Enabled = true;
                B_T4_Pause.Enabled = false;
                B_T4_Stop.Enabled = false;
                LB_T4_Led.BackColor = Color.Transparent;
            }
        }

        #endregion

        void T1_System_Knt(bool Start, bool Pause, bool Stop)
        {
            if (Start)
            {
                B_T1_Start.Enabled = false;
                B_T1_Pause.Enabled = true;
                B_T1_Stop.Enabled = true;
                LB_T1_Led.BackColor = Color.LawnGreen;

                Timer_T1.Enabled = true;

                if (Bar_T1.Value > 99.9)
                {
                    Bar_T1.Value = 0;
                    LB_Yuzde_T1.Text = "% " + Bar_T1.Value.ToString();
                    LB_T1_IslemTamam.Visible = false;
                }
            }
            else if (Pause)
            {
                B_T1_Start.Enabled = true;
                B_T1_Pause.Enabled = false;
                B_T1_Stop.Enabled = true;
                LB_T1_Led.BackColor = Color.Yellow;

                Timer_T1.Enabled = false;
            }
            else if (Stop)
            {
                B_T1_Start.Enabled = true;
                B_T1_Pause.Enabled = false;
                B_T1_Stop.Enabled = false;
                LB_T1_Led.BackColor = Color.Transparent;

                Timer_T1.Enabled = false;
            }

        }

        public void Log_TempSave_T1()
        {
            string path = Application.ExecutablePath;
            string path2 = Application.StartupPath;
            RTB_T1.SaveFile(path2 + "/T1.txt", RichTextBoxStreamType.PlainText);
        }

        public void Log_TempSave_T2()
        {
            string path = Application.ExecutablePath;
            string path2 = Application.StartupPath;
            RTB_T2.SaveFile(path2 + "/T2.txt", RichTextBoxStreamType.PlainText);
        }

        public void Log_TempSave_T3()
        {
            string path = Application.ExecutablePath;
            string path2 = Application.StartupPath;
            RTB_T3.SaveFile(path2 + "/T3.txt", RichTextBoxStreamType.PlainText);
        }

        public void Log_TempSave_T4()
        {
            string path = Application.ExecutablePath;
            string path2 = Application.StartupPath;
            RTB_T4.SaveFile(path2 + "/T4.txt", RichTextBoxStreamType.PlainText);
        }

        public void LOGYAZ(RichTextBox box, string text, Color color, bool addNewLine, bool Bold)
        {
        string mesaj;

        if (addNewLine) 
        { mesaj = "\n" + text; } else 
        { mesaj = text; }

        if (Bold) 
        { box.SelectionFont = new Font(box.Font, FontStyle.Bold); } else 
        { box.SelectionFont = new Font(box.Font, FontStyle.Regular); }

        box.SuspendLayout();
        box.SelectionColor = color;
        box.AppendText(mesaj);
        box.ScrollToCaret();
        box.ResumeLayout();
   
        }

        public void Log_T1(string Mesaj, Color Renk)
        {
            string date = DateTime.Now.ToShortDateString() +" ";
            string time = DateTime.Now.ToLongTimeString()  + " || ";

            LOGYAZ(RTB_T1, date, Color.Black, true, false);
            LOGYAZ(RTB_T1, time, Color.Black, false, false);
            LOGYAZ(RTB_T1, " " + "Kullanıcı1" + " || ", Color.Purple, false, true);
            LOGYAZ(RTB_T1, " " + Mesaj, Renk, false, false);
            LOGYAZ(RTB_T1, "", Color.Black, false, false);
        }

        private void Timer_T1_Tick(object sender, EventArgs e)
        {
            if (Bar_T1.Value < 100) { Bar_T1.Value += 1; }
            LB_Yuzde_T1.Text = "% " + Bar_T1.Value.ToString();

            if (Bar_T1.Value >= 100)
            {
                T1_System_Knt(false, false, true);
                LB_T1_IslemTamam.Visible = true;
                LB_Yuzde_T1.BackColor = Color.LawnGreen;

                Log_T1("Test tamamlandı.", Color.DarkGreen);
            
            }



        }
















    }
}
