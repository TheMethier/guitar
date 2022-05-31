using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guitarr
{
    public partial class Form1 : Form
    {
        int Score = 0;
        bool isKeyy = false;
        int objectspeed = 30;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GameEvents(object sender, EventArgs e)
        {

        }

        

        private void Stage(object sender, EventArgs e)
        {
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Q)
            {
                isKeyy = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isKeyy)
            {
                isKeyy = false;
            }

        }

        private void Hitbox(object sender, EventArgs e)
        {

        }
    }
}
