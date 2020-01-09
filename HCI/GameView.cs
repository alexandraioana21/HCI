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
using System.Reflection;

namespace HCI
{
    public partial class GameView : Form
    { 
        List<Gunoi> randomList = new List<Gunoi>();
        int scor = 0;
        SoundPlayer playerYay;
        SoundPlayer playerAww;
        int nrDeseuri;


        public GameView()
        {
            InitializeComponent();
            nrDeseuri = 0;
            stea.Visible = false;
            string x = (Assembly.GetEntryAssembly().Location + "");
            x = x.Replace("HCI.exe", "yay.wav");
            playerYay = new SoundPlayer(x);

            x = (Assembly.GetEntryAssembly().Location + "");
            x = x.Replace("HCI.exe", "aww.wav");
            playerAww = new SoundPlayer(x);

            scoreLabel.Text = "SCOR: "+scor.ToString();  
            
            incarcaLista();
            gunoi.ImageLocation = @randomList[0].image;
            punctaj.Visible = false;

        }

        private void incarcaLista()
        {
            List<Gunoi> listGunoaie = new List<Gunoi>();
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string temp = path.Replace("HCI.exe", "sticla1.png");
            listGunoaie.Add(new Gunoi()
            {
                image = temp,
                type="sticla"
            }) ;
            temp = path.Replace("HCI.exe", "sticla2.png");
            listGunoaie.Add(new Gunoi()
            {
                image = temp,
                type = "sticla"
            });
            temp = path.Replace("HCI.exe", "sticla3.png");
            listGunoaie.Add(new Gunoi()
            {
                image = temp,
                type = "sticla"
            });
            temp = path.Replace("HCI.exe", "menajer1.png");
            listGunoaie.Add(new Gunoi()
            {
                image = temp,
                type = "menajer"
            });
            temp = path.Replace("HCI.exe", "menajer2.png");
            listGunoaie.Add(new Gunoi()
            {
                image = temp,
                type = "menajer"
            });
            temp = path.Replace("HCI.exe", "menajer3.png");
            listGunoaie.Add(new Gunoi()
            {
                image = temp,
                type = "menajer"
            });
            temp = path.Replace("HCI.exe", "elec1.png");
            listGunoaie.Add(new Gunoi()
            {
                image = temp,
                type = "electronice"
            });
            temp = path.Replace("HCI.exe", "elec2.png");
            listGunoaie.Add(new Gunoi()
            {
                image = temp,
                type = "electronice"
            });
            temp = path.Replace("HCI.exe", "elec3.png");
            listGunoaie.Add(new Gunoi()
            {
                image = temp,
                type = "electronice"
            });
            temp = path.Replace("HCI.exe", "hartie1.png");
            listGunoaie.Add(new Gunoi()
            {
                image = temp,
                type = "hartie"
            });
            temp = path.Replace("HCI.exe", "hartie2.png");
            listGunoaie.Add(new Gunoi()
            {
                image = temp,
                type = "hartie"
            });
            temp = path.Replace("HCI.exe", "hartie3.png");
            listGunoaie.Add(new Gunoi()
            {
                image = temp,
                type = "hartie"
            });
            temp = path.Replace("HCI.exe", "metal1.png");
            listGunoaie.Add(new Gunoi()
            {
                image = temp,
                type = "metal"
            });
            temp = path.Replace("HCI.exe", "metal2.png");
            listGunoaie.Add(new Gunoi()
            {
                image = temp,
                type = "metal"
            });
            temp = path.Replace("HCI.exe", "metal3.png");
            listGunoaie.Add(new Gunoi()
            {
                image = temp,
                type = "metal"
            });
            temp = path.Replace("HCI.exe", "plastic1.png");
            listGunoaie.Add(new Gunoi()
            {
                image = temp,
                type = "plastic"
            });
            temp = path.Replace("HCI.exe", "plastic2.png");
            listGunoaie.Add(new Gunoi()
            {
                image = temp,
                type = "plastic"
            });
            temp = path.Replace("HCI.exe", "plastic3.png");
            listGunoaie.Add(new Gunoi()
            {
                image = temp,
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

        public void showStar()
        {
            if (nrDeseuri == 10)
            {
                gunoi.Visible = false;
                int s = scor / 10;
                punctaj.Visible = true;
                punctaj.Font = new System.Drawing.Font("Arial", 40, FontStyle.Bold);
                punctaj.Text = s.ToString();
                stea.Visible = true;
                scoreLabel.Visible = false;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void blackBin_Click(object sender, EventArgs e)
        {
            nrDeseuri++;

            if (randomList[0].type.Equals("electronice"))
            {
                playerYay.Play();
                scor += 10;
                scoreLabel.Text = "SCOR: " + scor.ToString();
                randomList.Remove(randomList[0]);
                if ((nrDeseuri < 10) && (randomList.Count > 0))
                {
                    gunoi.ImageLocation = @randomList[0].image;
                }
                
                
            }
            else if (nrDeseuri < 10) 
                playerAww.Play();
            showStar();

        }

        private void yellowBin_Click(object sender, EventArgs e)
        {
            nrDeseuri++;

            if (randomList[0].type.Equals("hartie"))
            {
                playerYay.Play();
                scor += 10;
                scoreLabel.Text = "SCOR: " + scor.ToString();
                randomList.Remove(randomList[0]);
                if ((nrDeseuri < 10) && (randomList.Count > 0))
                {
                    gunoi.ImageLocation = @randomList[0].image;
                }
               
            }
            else if (nrDeseuri < 10) 
                playerAww.Play();
            showStar();

        }

        private void greenBin_Click(object sender, EventArgs e)
        {
            nrDeseuri++;

            if (randomList[0].type.Equals("sticla"))
            {
                playerYay.Play();
                scor += 10;
                scoreLabel.Text = "SCOR: " + scor.ToString();
                randomList.Remove(randomList[0]);
                if ((nrDeseuri < 10) && (randomList.Count > 0))
                {
                    gunoi.ImageLocation = @randomList[0].image;
                }
                
            }
            else if (nrDeseuri < 10) 
                playerAww.Play();
            showStar();

        }

        private void blueBin_Click(object sender, EventArgs e)
        {
            nrDeseuri++;

            if (randomList[0].type.Equals("plastic"))
            {
                playerYay.Play();
                scor += 10;
                scoreLabel.Text ="SCOR: "+ scor.ToString();
                randomList.Remove(randomList[0]);
                if ((nrDeseuri < 10) && (randomList.Count > 0))
                {
                    gunoi.ImageLocation = @randomList[0].image;
                }
                

            }
            else if(nrDeseuri < 10)
                playerAww.Play();
            showStar();

        }

        private void redBin_Click(object sender, EventArgs e)
        {
            nrDeseuri++;

            if (randomList[0].type.Equals("metal"))
            {
                playerYay.Play();
                scor += 10;
                scoreLabel.Text = "SCOR: " + scor.ToString();
                randomList.Remove(randomList[0]);
                if ((nrDeseuri < 10) && (randomList.Count > 0))
                {
                    gunoi.ImageLocation = @randomList[0].image;
                }
                
            }
            else if (nrDeseuri < 10) 
                playerAww.Play();
            showStar();

        }

        private void brownBin_Click(object sender, EventArgs e)
        {
                        nrDeseuri++;

            if (randomList[0].type.Equals("menajer"))
            {
                playerYay.Play();
                scor += 10;
                scoreLabel.Text = "SCOR: " + scor.ToString();
                randomList.Remove(randomList[0]);
                if ((nrDeseuri < 10) && (randomList.Count > 0))
                {
                    gunoi.ImageLocation = @randomList[0].image;
                }
            }
            else if (nrDeseuri < 10)
                playerAww.Play();
            showStar();

        }


    }
}
