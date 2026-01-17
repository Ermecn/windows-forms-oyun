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
    public partial class selections : Form
    {
        static int counter = 0; //bu formdan iki tane spawnlayacağımız için hangisinin hangisi olacağına karar vermek için
        cutscene_player cutscene= new cutscene_player(); //final sahneyi oynatmak için
        public static bool closed=false;


        public selections()
        {
            InitializeComponent();
            this.Opacity=0;
            
        }

        private void selections_Load(object sender, EventArgs e)
        {
            counter++;
            
            switch (counter) 
            {
                case 1:
                    lbl_selection.Text = "Merhamet et";
                    pictureBox2.Hide();
                    break;

                case 2:
                    lbl_selection.Text = "Öldür";
                    pictureBox1.Hide();
                    break;

               
            }

            Point location = new Point(this.Location.X, this.Location.Y); //we get the location of them so we can move them outwards 

            switch (counter) //we spawn the first one 400 pixels to the left and push the second one 400 pixels to the right (like the upgrade ones)
            {
                case 1:
                    this.Location = new Point(location.X - 400, location.Y);
                    break;

                case 2:
                    this.Location = new Point(location.X + 400, location.Y);
                    break;

                
            }


        }

        private void timer1_Tick(object sender, EventArgs e) //yavaş yavaş opaklığı arttırır (dramatik efekt için)
        {

            this.Opacity+=0.03;
            if (closed)
            {
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) //no mercy
        {
            if (lbl_selection.Text == "Merhamet et")
            {
                GameHandler.cutscene = GameHandler.Cutscene_Situations.ending_good;
                cutscene.Show();
            }
            else
            {
                GameHandler.cutscene = GameHandler.Cutscene_Situations.ending_bad;
                cutscene.Show();
            }
            this.Hide();
            closed = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e) //mercy
        {
            if (lbl_selection.Text == "Merhamet et")
            {
                GameHandler.cutscene = GameHandler.Cutscene_Situations.ending_good;
                cutscene.Show();
            }
            else
            {
                GameHandler.cutscene = GameHandler.Cutscene_Situations.ending_bad;
                cutscene.Show();
            }
            this.Hide();
            closed = true;
        }
    }
}
