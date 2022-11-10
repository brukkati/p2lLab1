using player;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2lLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Player player = new Player();
            int amount = 5;
            player.Lifes = 8;
            
            label1.Text = player.Lifes.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
