using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
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
        Adunare mathView;
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

            string x = (Assembly.GetEntryAssembly().Location + "");
            x = x.Replace("HCI.exe", "galben.wav");
            playerGalben = new SoundPlayer(x);

            x = (Assembly.GetEntryAssembly().Location + "");
            x = x.Replace("HCI.exe", "verde.wav");
            playerVerde = new SoundPlayer(x);

            x = (Assembly.GetEntryAssembly().Location + "");
            x = x.Replace("HCI.exe", "negru.wav");
            playerNegru = new SoundPlayer(x);

            x = (Assembly.GetEntryAssembly().Location + "");
            x = x.Replace("HCI.exe", "albastru.wav");
            playerAlbastru = new SoundPlayer(x);

            x = (Assembly.GetEntryAssembly().Location + "");
            x = x.Replace("HCI.exe", "rosu.wav");
            playerRosu = new SoundPlayer(x);

            x = (Assembly.GetEntryAssembly().Location + "");
            x = x.Replace("HCI.exe", "portocaliu.wav");
            playerPortocaliu = new SoundPlayer(x);

            InitializeComponent();
        }

        public async void stop()
        {
            if (this.checkAlbastru &&this.checkGalben&& this.checkNegru &&this.checkPortocaliu &&this.checkRosu&&this.checkVerde)
            {
                await Task.Delay(5000);
                mathView = new Adunare();
                this.Hide();
                mathView.Show();
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
