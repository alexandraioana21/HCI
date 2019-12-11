using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI
{
    public partial class Math : Form
    {
        int contor;
        public Math()
        {
            InitializeComponent();
            this.contor = 0;
        }

        public void sound(int c)
        {
            SoundPlayer p;
            if (c==1)
                p=new SoundPlayer(@"C:\Users\ale\source\repos\HCI\1.wav");
            else if (c==2)
                p= new SoundPlayer(@"C:\Users\ale\source\repos\HCI\2.wav");
            else if (c == 3)
                p = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\3.wav");
            else if (c == 4)
                p = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\4.wav");
            else if (c == 5)
                p = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\5.wav");
            else if (c == 6)
                p = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\6.wav");
            else if (c == 7)
                p = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\7.wav");
            else if (c == 8)
                p = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\8.wav");
            else if (c == 9)
                p = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\9.wav");
            else
                p = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\10.wav");
            p.Play();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
        }  

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
        }

        
    }
}
