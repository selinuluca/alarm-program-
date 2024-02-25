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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString();
            label2.Text = DateTime.Now.Minute.ToString();

        }
        public void alarmçalıştır()
        {
            int bayrak = 0;

            int alarmsaat, alarmdakika;
            alarmsaat = Convert.ToInt32(textBox1.Text);
            alarmdakika = Convert.ToInt32(textBox2.Text);


            textBox1.Clear();
            textBox2.Clear();

            while (bayrak==0)
            {
                if (alarmsaat.ToString() == DateTime.Now.Hour.ToString() && alarmdakika.ToString() == DateTime.Now.Minute.ToString())
                {
                    Form2 form = new Form2(Convert.ToInt32(label1.Text), Convert.ToInt32(label2.Text));
                    form.ShowDialog();
                    //timer1.Enabled = false;
                    bayrak = 1;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ALARM KURULDU");
            alarmçalıştır();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
