using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class debug_window : Form //this is mostly used to test sections of the game without having to play from the beginning
    {
        static int test=0;
        public debug_window()
        {
            InitializeComponent();
            timer1.Start();
            this.StartPosition = FormStartPosition.Manual;
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            decision dec = new decision();
            dec.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label1.Text = "character: "+GameHandler.selected_character;
            this.Location = new Point(0,test); //just testing if we can move the windows(yes yes we can)
        }
    }
}
