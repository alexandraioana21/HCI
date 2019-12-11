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
        List<String> randomList = new List<String>();

        public Math()
        {
            InitializeComponent();
            this.contor = 0;
            incarcaLista();
            adaugaImagini();
        }

        private void incarcaLista()
        {
            List<String> listGunoaie = new List<String>();
            listGunoaie.Add( "C:\\Users\\ale\\source\\repos\\HCI\\sticla1.png");
            listGunoaie.Add( "C:\\Users\\ale\\source\\repos\\HCI\\sticla2.png");
            listGunoaie.Add( "C:\\Users\\ale\\source\\repos\\HCI\\menajer1.png");
            listGunoaie.Add( "C:\\Users\\ale\\source\\repos\\HCI\\menajer2.png");
            listGunoaie.Add( "C:\\Users\\ale\\source\\repos\\HCI\\elec1.png");
            listGunoaie.Add( "C:\\Users\\ale\\source\\repos\\HCI\\elec2.png");
            listGunoaie.Add( "C:\\Users\\ale\\source\\repos\\HCI\\hartie1.png");
            listGunoaie.Add( "C:\\Users\\ale\\source\\repos\\HCI\\hartie2.png");
            listGunoaie.Add( "C:\\Users\\ale\\source\\repos\\HCI\\metal1.png");
            listGunoaie.Add( "C:\\Users\\ale\\source\\repos\\HCI\\metal2.png");
            listGunoaie.Add( "C:\\Users\\ale\\source\\repos\\HCI\\plastic1.png");
            listGunoaie.Add( "C:\\Users\\ale\\source\\repos\\HCI\\plastic2.png");
            
            Random r = new Random();
            int randomIndex = 0;
            while (listGunoaie.Count > 0)
            {
                randomIndex = r.Next(0, listGunoaie.Count);
                randomList.Add(listGunoaie[randomIndex]);
                listGunoaie.RemoveAt(randomIndex);
            }

        }

        private void adaugaImagini()
        {
            pictureBox1.ImageLocation = @randomList[0];
            pictureBox2.ImageLocation = @randomList[1];
            pictureBox3.ImageLocation = @randomList[2];
            pictureBox4.ImageLocation = @randomList[3];
            pictureBox5.ImageLocation = @randomList[4];
            pictureBox6.ImageLocation = @randomList[5];
            pictureBox7.ImageLocation = @randomList[6];
            pictureBox8.ImageLocation = @randomList[7];
            pictureBox9.ImageLocation = @randomList[8];
            pictureBox10.ImageLocation = @randomList[9];
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
            pictureBox10.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
            pictureBox1.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
            pictureBox2.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
            pictureBox3.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
            pictureBox4.Hide();
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
            pictureBox6.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
            pictureBox7.Hide();
        }  

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
            pictureBox8.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
            pictureBox9.Hide();
        }

        
    }
}
