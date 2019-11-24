using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI
{
    public partial class FirstView : Form
    {
        GameView gameView;
        public FirstView()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            gameView = new GameView();
            this.Hide();
            gameView.Show();
        }
    }
}
