using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI
{
    public partial class Adunare : Form
    {
        int contor;
        List<String> randomList = new List<String>();
        GameView gameView;
        public Adunare()
        {
            InitializeComponent();
            this.contor = 0;
            incarcaLista();
            adaugaImagini();
        }

        private void incarcaLista()
        {
            List<String> listGunoaie = new List<String>();
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string temp = path.Replace("HCI.exe", "sticla1.png");
            listGunoaie.Add(temp);
            temp = path.Replace("HCI.exe", "sticla2.png");
            listGunoaie.Add(temp);
            temp = path.Replace("HCI.exe", "sticla3.png");
            listGunoaie.Add(temp);
            temp = path.Replace("HCI.exe", "menajer1.png");
            listGunoaie.Add(temp);
            temp = path.Replace("HCI.exe", "menajer2.png");
            listGunoaie.Add(temp);
            temp = path.Replace("HCI.exe", "menajer3.png");
            listGunoaie.Add(temp);
            temp = path.Replace("HCI.exe", "elec1.png");
            listGunoaie.Add(temp);
            temp = path.Replace("HCI.exe", "elec2.png");
            listGunoaie.Add(temp);
            temp = path.Replace("HCI.exe", "elec3.png");
            listGunoaie.Add(temp);
            temp = path.Replace("HCI.exe", "hartie1.png");
            listGunoaie.Add(temp);
            temp = path.Replace("HCI.exe", "hartie2.png");
            listGunoaie.Add(temp);
            temp = path.Replace("HCI.exe", "hartie3.png");
            listGunoaie.Add(temp);
            temp = path.Replace("HCI.exe", "metal1.png");
            listGunoaie.Add(temp);
            temp = path.Replace("HCI.exe", "metal2.png");
            listGunoaie.Add(temp);
            temp = path.Replace("HCI.exe", "metal3.png");
            listGunoaie.Add(temp);
            temp = path.Replace("HCI.exe", "plastic1.png");
            listGunoaie.Add(temp);
            temp = path.Replace("HCI.exe", "plastic2.png");
            listGunoaie.Add(temp);
            temp = path.Replace("HCI.exe", "plastic3.png");
            listGunoaie.Add(temp);



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
            
            pictureBox1.Image =Image.FromFile(randomList[0]);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile(@randomList[1]);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile(@randomList[2]);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile(@randomList[3]);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Image.FromFile(@randomList[4]);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile(@randomList[5]);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = Image.FromFile(@randomList[6]);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.Image = Image.FromFile(@randomList[7]);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.Image = Image.FromFile(@randomList[8]);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.Image = Image.FromFile(@randomList[9]);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void sound(int c)
        {
            SoundPlayer p;
            if (c == 1)
            {
                string x = (Assembly.GetEntryAssembly().Location + "");
                x = x.Replace("HCI.exe", "1.wav");
                p = new SoundPlayer(x);
            }
            else if (c == 2)
            {
                string x = (Assembly.GetEntryAssembly().Location + "");
                x = x.Replace("HCI.exe", "2.wav");
                p = new SoundPlayer(x);
            }
            else if (c == 3)
            {
                string x = (Assembly.GetEntryAssembly().Location + "");
                x = x.Replace("HCI.exe", "3.wav");
                p = new SoundPlayer(x);
            }
            else if (c == 4)
            {
                string x = (Assembly.GetEntryAssembly().Location + "");
                x = x.Replace("HCI.exe", "4.wav");
                p = new SoundPlayer(x);
            }
            else if (c == 5)
            {
                string x = (Assembly.GetEntryAssembly().Location + "");
                x = x.Replace("HCI.exe", "5.wav");
                p = new SoundPlayer(x);
            }
            else if (c == 6)
            {
                string x = (Assembly.GetEntryAssembly().Location + "");
                x = x.Replace("HCI.exe", "6.wav");
                p = new SoundPlayer(x);
            }
            else if (c == 7)
            {
                string x = (Assembly.GetEntryAssembly().Location + "");
                x = x.Replace("HCI.exe", "7.wav");
                p = new SoundPlayer(x);
            }
            else if (c == 8)
            {
                string x = (Assembly.GetEntryAssembly().Location + "");
                x = x.Replace("HCI.exe", "8.wav");
                p = new SoundPlayer(x);
            }
            else if (c == 9)
            {
                string x = (Assembly.GetEntryAssembly().Location + "");
                x = x.Replace("HCI.exe", "9.wav");
                p = new SoundPlayer(x);
            }
            else
            {
                string x = (Assembly.GetEntryAssembly().Location + "");
                x = x.Replace("HCI.exe", "10.wav");
                p = new SoundPlayer(x);
            }
            p.Play();
        }

        public async void stop(int contor)
        {
            if (contor == 10)
            {
                await Task.Delay(1000);
                gameView = new GameView();
                this.Close();
                gameView.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
            pictureBox1.Hide();
            stop(contor);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
            pictureBox9.Hide();
            stop(contor);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
            pictureBox5.Hide();
            stop(contor);

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
            pictureBox10.Hide();
            stop(contor);

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
            pictureBox8.Hide();
            stop(contor);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
            pictureBox4.Hide();
            stop(contor);

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
            pictureBox7.Hide();
            stop(contor);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
            pictureBox2.Hide();
            stop(contor);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
            pictureBox3.Hide();
            stop(contor);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.contor++;
            sound(this.contor);
            pictureBox6.Hide();
            stop(contor);

        }
    }
}
