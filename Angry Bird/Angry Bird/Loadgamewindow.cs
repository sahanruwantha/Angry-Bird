using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angry_Bird
{
    public partial class Loadgamewindow : Form
    {
        public Loadgamewindow()
        {
            InitializeComponent();
        }

        private void Loadgame(object sender, EventArgs e)
        {
            Form1 loadgame = new Form1();
           // Loadgamewindow.close();
            loadgame.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void highestscore_Click(object sender, EventArgs e)
        {
            Highesscore highesscore = new Highesscore();    
            highesscore.Show();
        }
    }
}
