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

        public InfoView()
        {

            playerGalben = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\galben.wav");
             playerVerde = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\verde.wav");
            playerNegru = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\negru.wav");
            playerAlbastru = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\albastru.wav");
            playerRosu = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\rosu.wav");
            playerPortocaliu = new SoundPlayer(@"C:\Users\ale\source\repos\HCI\portocaliu.wav");

            InitializeComponent();
        }

        private void yellowBin_Click(object sender, EventArgs e)
        {
            playerGalben.Play();
        }

        private void greenBin_Click(object sender, EventArgs e)
        {
            playerVerde.Play();
        }

        private void blackBin_Click(object sender, EventArgs e)
        {
            playerNegru.Play();
        }

        private void blueBin_Click(object sender, EventArgs e)
        {
            playerAlbastru.Play();
        }

        private void redBin_Click(object sender, EventArgs e)
        {
            playerRosu.Play();
        }

        private void orangeBin_Click(object sender, EventArgs e)
        {
            playerPortocaliu.Play();
        }

        
    }
}
