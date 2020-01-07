using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace HCI
{
    public partial class GameView : Form
    {

        
        List<Gunoi> randomList = new List<Gunoi>();
        int scor = 0;
        SoundPlayer playerYay;
        SoundPlayer playerAww;
        Adunare math;


        public GameView()
        {
            InitializeComponent();

            playerYay = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\yay.wav");
            playerAww = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\aww.wav");

            scoreLabel.Text = "SCOR: "+scor.ToString();  
            
            incarcaLista();
            gunoi.ImageLocation = @randomList[0].image;
        }

        private void incarcaLista()
        {
            List<Gunoi> listGunoaie = new List<Gunoi>();
            listGunoaie.Add(new Gunoi()
            {
                image = "C:\\Users\\ale\\source\\repos\\HCI\\sticla1.png",
                type="sticla"
            }) ;
            listGunoaie.Add(new Gunoi()
            {
                image = "C:\\Users\\ale\\source\\repos\\HCI\\sticla2.png",
                type = "sticla"
            });
            listGunoaie.Add(new Gunoi()
            {
                image = "C:\\Users\\ale\\source\\repos\\HCI\\menajer1.png",
                type = "menajer"
            }); 
            listGunoaie.Add(new Gunoi()
            {
                image = "C:\\Users\\ale\\source\\repos\\HCI\\menajer2.png",
                type = "menajer"
            }); 
            listGunoaie.Add(new Gunoi()
            {
                image = "C:\\Users\\ale\\source\\repos\\HCI\\elec1.png",
                type = "electronice"
            }); 
            listGunoaie.Add(new Gunoi()
            {
                image = "C:\\Users\\ale\\source\\repos\\HCI\\elec2.png",
                type = "electronice"
            });
            listGunoaie.Add(new Gunoi()
            {
                image = "C:\\Users\\ale\\source\\repos\\HCI\\hartie1.png",
                type = "hartie"
            });
            listGunoaie.Add(new Gunoi()
            {
                image = "C:\\Users\\ale\\source\\repos\\HCI\\hartie2.png",
                type = "hartie"
            });
            listGunoaie.Add(new Gunoi()
            {
                image = "C:\\Users\\ale\\source\\repos\\HCI\\metal1.png",
                type = "metal"
            });
            listGunoaie.Add(new Gunoi()
            {
                image = "C:\\Users\\ale\\source\\repos\\HCI\\metal2.png",
                type = "metal"
            });
            listGunoaie.Add(new Gunoi()
            {
                image = "C:\\Users\\ale\\source\\repos\\HCI\\plastic1.png",
                type = "plastic"
            });
            listGunoaie.Add(new Gunoi()
            {
                image = "C:\\Users\\ale\\source\\repos\\HCI\\plastic2.png",
                type = "plastic"
            });

            Random r = new Random();
            int randomIndex = 0;
            while (listGunoaie.Count > 0)
            {
                randomIndex = r.Next(0, listGunoaie.Count);
                randomList.Add(listGunoaie[randomIndex]);
                listGunoaie.RemoveAt(randomIndex);
            }

                  

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void blackBin_Click(object sender, EventArgs e)
        {

            if (randomList[0].type.Equals("electronice"))
            {
                playerYay.Play();
                scor += 10;
                scoreLabel.Text = "SCOR: " + scor.ToString();
                randomList.Remove(randomList[0]);
                if (randomList.Count > 0)
                {
                    gunoi.ImageLocation = @randomList[0].image;
                }
                else
                {
                    gunoi.Hide();
                    math = new Adunare();
                    this.Hide();
                    math.Show();
                
            }
            }
            else playerAww.Play();
        }

        private void yellowBin_Click(object sender, EventArgs e)
        {
            if (randomList[0].type.Equals("hartie"))
            {
                playerYay.Play();
                scor += 10;
                scoreLabel.Text = "SCOR: " + scor.ToString();
                randomList.Remove(randomList[0]);
                if (randomList.Count > 0)
                {
                    gunoi.ImageLocation = @randomList[0].image;
                }
                else
                {

                    gunoi.Hide();
                    math = new Adunare();
                    this.Hide();
                    math.Show();
                }
            }
            else playerAww.Play();
        }

        private void greenBin_Click(object sender, EventArgs e)
        {
            if (randomList[0].type.Equals("sticla"))
            {
                playerYay.Play();
                scor += 10;
                scoreLabel.Text = "SCOR: " + scor.ToString();
                randomList.Remove(randomList[0]);
                if (randomList.Count > 0)
                {
                    gunoi.ImageLocation = @randomList[0].image;
                }
                else
                {
                    
                    gunoi.Hide();
                    math = new Adunare();
                    this.Hide();
                    math.Show();
                }
            }
            else playerAww.Play();
        }

        private void blueBin_Click(object sender, EventArgs e)
        {
            if (randomList[0].type.Equals("plastic"))
            {
                playerYay.Play();
                scor += 10;
                scoreLabel.Text = scor.ToString();
                randomList.Remove(randomList[0]);
                if (randomList.Count > 0)
                {
                    gunoi.ImageLocation = @randomList[0].image;
                }
                else
                {
                    gunoi.Hide();
                    math = new Adunare();
                    this.Hide();
                    math.Show();
                }
                }
            else playerAww.Play();
        }

        private void redBin_Click(object sender, EventArgs e)
        {
            if (randomList[0].type.Equals("metal"))
            {
                playerYay.Play();
                scor += 10;
                scoreLabel.Text = "SCOR: " + scor.ToString();
                randomList.Remove(randomList[0]);
                if (randomList.Count > 0)
                {
                    gunoi.ImageLocation = @randomList[0].image;
                }
                else
                {
                    gunoi.Hide();
                    math = new Adunare();
                    this.Hide();
                    math.Show();
                }
                }
            else playerAww.Play();
        }

        private void brownBin_Click(object sender, EventArgs e)
        {
            if (randomList[0].type.Equals("menajer"))
            {
                playerYay.Play();
                scor+=10;
                scoreLabel.Text = "SCOR: "+ scor.ToString();
                randomList.Remove(randomList[0]);
                if (randomList.Count > 0)
                {
                    gunoi.ImageLocation = @randomList[0].image;
                }
                else
                {
                    gunoi.Hide();
                    math = new Adunare();
                    this.Hide();
                    math.Show();
                }
                }
            else playerAww.Play();
        }

        
    }
}
