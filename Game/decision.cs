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
    public partial class decision : Form
    {
        public decision() //oyunun sonunda verilen kararın formu (ortadaki resim)
        {
            InitializeComponent();
        }

        private void decision_Load(object sender, EventArgs e) //merhamet ve öldürme seçeneklerini spawnlar(selections.cs) ve karakterimize göre ortadaki fotoğrafı değiştirir
        {
            for (int i = 1; i <= 2; i++) 
            {
                selections selections = new selections();
                selections.Show();
            }
            switch(GameHandler.selected_character) 
            {
                case GameHandler.characters.King:
                    picture.Image = ımageList1.Images["king_victory.png"];
                    
                    break;

                    case GameHandler.characters.Dragon:
                    picture.Image = ımageList1.Images["dragon_victory.png"];
                    break;
            }
        }

        private void decision_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e) //seçim yapılınca bu form kapanır
        {
           if (selections.closed == true)
            {
                this.Hide();
            }
        }
    }
}
