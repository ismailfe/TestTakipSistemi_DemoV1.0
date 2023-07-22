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
    public partial class Form_Yeni_Not : Form
    {
       public Form_Main Form_Main;

        public Form_Yeni_Not()
        {
            InitializeComponent();
        }

        private void B_Iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            Form_Main.Log_T1(CB_NotAmac.Text + ": " +  RTB_Not.Text.Replace("\n", " ") , Color.Blue);
           // .Replace(Chr(10), " ")
            //string date = DateTime.Now.ToShortDateString() + " ";
            //string time = DateTime.Now.ToLongTimeString() + " || ";

            //Form_Main.LOGYAZ(Form_Main.RTB_T1, date, Color.Black, true, false);
            //Form_Main.LOGYAZ(Form_Main.RTB_T1, time, Color.Black, false, false);
            //Form_Main.LOGYAZ(Form_Main.RTB_T1, " " + "Kullanıcı1" + " || ", Color.Purple, false, true);
            //Form_Main.LOGYAZ(Form_Main.RTB_T1, " " + Mesaj, Color.Red, false, false);
            //Form_Main.LOGYAZ(Form_Main.RTB_T1, "", Color.Black, false, false);

            this.Close();
        }
    }
}
