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
    public partial class InfoView : Form
    {

        SoundPlayer playerGalben;
        SoundPlayer playerVerde;
        SoundPlayer playerNegru;
        SoundPlayer playerAlbastru;
        SoundPlayer playerRosu;
        SoundPlayer playerPortocaliu;
        GameView gameView;
        bool checkGalben;
        bool checkVerde;
        bool checkNegru;
        bool checkAlbastru;
        bool checkRosu;
        bool checkPortocaliu;

        public InfoView()
        {
            checkGalben=false;
            checkVerde=false;
            checkNegru=false;
            checkAlbastru=false;
            checkRosu=false;
            checkPortocaliu=false;

            playerGalben = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\galben.wav");
             playerVerde = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\verde.wav");
            playerNegru = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\negru.wav");
            playerAlbastru = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\albastru.wav");
            playerRosu = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\rosu.wav");
            playerPortocaliu = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\portocaliu.wav");

            InitializeComponent();
        }

        public void stop()
        {
            if (this.checkAlbastru &&this.checkGalben&& this.checkNegru &&this.checkPortocaliu &&this.checkRosu&&this.checkVerde)
            {
                gameView = new GameView();
                this.Hide();
                gameView.Show();
            }
        }

        private void yellowBin_Click(object sender, EventArgs e)
        {
            this.checkGalben = true;
            playerGalben.Play();
            stop();
        }

        private void greenBin_Click(object sender, EventArgs e)
        {
            this.checkVerde = true;
            playerVerde.Play();
            stop();
        }

        private void blackBin_Click(object sender, EventArgs e)
        {
            this.checkNegru=true;
            playerNegru.Play();
            stop();
        }

        private void blueBin_Click(object sender, EventArgs e)
        {
            this.checkAlbastru = true;
            playerAlbastru.Play();
            stop();
        }

        private void redBin_Click(object sender, EventArgs e)
        {
            this.checkRosu = true;
            playerRosu.Play();
            stop();
        }

        private void orangeBin_Click(object sender, EventArgs e)
        {
            this.checkPortocaliu=true;
            playerPortocaliu.Play();
            stop();
        }

        
    }
}
