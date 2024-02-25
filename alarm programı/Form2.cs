using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alarm_programı
{
    public partial class Form2 : Form
    {
        
        public Form2(int saat, int dakika)
        {
            InitializeComponent();
            saatbasma(saat, dakika);
        }
        public void saatbasma(int  saat,int dakika)
        {
            label2.Text = DateTime.Now.Hour.ToString();
            label3.Text= DateTime.Now.Minute.ToString();
        } 
        private void Form2_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\iseli\\Music\\dreams.mp3";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
