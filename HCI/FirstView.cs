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
        
        InfoView lingvistic;

        public FirstView()
        {
            InitializeComponent();
        }


        private void playMain_Click(object sender, EventArgs e)
        {
            lingvistic = new InfoView();
            this.Hide();
            lingvistic.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
