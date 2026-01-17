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
    
    public partial class Character_Select : Form
    {
        

        public Character_Select()
        {
            InitializeComponent();
        }

        public void Character_Select_Load(object sender, EventArgs e) //i keep the characters in the gamehandler class because we will use them later
        {
            GameHandler.selected_character = GameHandler.characters.King; 
            
        }

        private void Character_Select_FormClosing(object sender, FormClosingEventArgs e) //bunu her forma koymak zorundayım yoksa arka planda sakladığım formlar kapanmıyor
        {
            Application.Exit();
        }

        //karakter seçim (doubly linked list kullanabilirdim ama 3 karakter için direkt çok ilkel bir kod yazdım)

        private void btn_next_Click(object sender, EventArgs e) //we set the selected character here and view images and names accordingly
        {
            switch (GameHandler.selected_character) 
            {
                case GameHandler.characters.King:

                    GameHandler.selected_character = GameHandler.characters.Dragon; //set the character image and data to dragon and say dragon in the label
                    //lbl_char_name.Text = "Ejderha";
                    Character_Picture.Image = character_images_list.Images["dragon_cs_tr.png"];
                    break;
                    
                        

                case GameHandler.characters.Dragon:
                    GameHandler.selected_character= GameHandler.characters.King;
                    //lbl_char_name.Text = "Kral";
                    Character_Picture.Image = character_images_list.Images["king_cs_tr.png"];
                    break;
                

               /* case GameHandler.characters.Soldier:
                    GameHandler.selected_character = GameHandler.characters.King;
                    lbl_char_name.Text = "Kral";
                    Character_Picture.Image = character_images_list.Images["character placeholder.png"];
                    break;*/

            }

        }
            
            

        private void btn_previous_Click(object sender, EventArgs e) //the top one but reverse
        {
            switch (GameHandler.selected_character)
            {
                case GameHandler.characters.King:
                    GameHandler.selected_character = GameHandler.characters.Dragon;
                    //lbl_char_name.Text = "Ejderha";
                    Character_Picture.Image = character_images_list.Images["dragon_cs_tr.png"];
                    break;

                case GameHandler.characters.Dragon:
                    GameHandler.selected_character = GameHandler.characters.King;
                    //lbl_char_name.Text = "Kral";
                    Character_Picture.Image = character_images_list.Images["king_cs_tr.png"];
                    
                    break;

               /* case GameHandler.characters.Soldier:
                    GameHandler.selected_character = GameHandler.characters.Dragon;
                    lbl_char_name.Text = "Ejderha";
                    Character_Picture.Image = character_images_list.Images["character2 placeholder.png"];
                    break;*/
            }
        }

        private void btn_continue_Click(object sender, EventArgs e) //butona bastığımızda ekranda olan karakteri seçer ve ara sahneye girer
        {
            GameHandler.create_player(); //we create the player
            cutscene_player Cutscene_Player = new cutscene_player();
            this.Hide();
            Cutscene_Player.Show();
        }
    }
}
