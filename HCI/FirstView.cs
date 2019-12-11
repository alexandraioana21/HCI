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
        Math math;

        public FirstView()
        {
            InitializeComponent();
        }


        private void playMain_Click(object sender, EventArgs e)
        {
            gameView = new GameView();
            this.Hide();
            gameView.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playMath_Click(object sender, EventArgs e)
        {
            math = new Math();
            this.Hide();
            math.Show();
        }

        private void playLingvistic_Click(object sender, EventArgs e)
        {
            gameView = new GameView();
            this.Hide();
            gameView.Show();
        }
    }
}
