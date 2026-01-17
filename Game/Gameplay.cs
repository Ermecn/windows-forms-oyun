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
    public partial class Gameplay : Form
    {
        public bool players_turn = true;

        public bool player_alive = true;

        public bool enemy_alive = true;

        public bool boss_active = false;

        float timerbuffer; //we will use this so the enemy doesnt attack us the second we attack them

        

        Game_over gameover = new Game_over(); //form for when we lose

        public Gameplay()
        {
            InitializeComponent();
            
        }
        public void Gameplay_Load(object sender, EventArgs e)
        {
            GameHandler.stage = 1; //when the player restarts they restart from 1 instead of where they left of

            GameHandler.create_enemy(); //we create the first enemy here (for now it might change)

            Enemy_picture_boss_dragon.Visible = false;
            Enemy_picture_boss_king.Visible = false;

            switch (GameHandler.selected_character)  //imagelist gif desteklemiyormuş daha "yaratıcı" bir çözüm yaptım
            {
                case GameHandler.characters.King:
                    //Character_Picture.Image = character_images_list.Images["king_player.gif"];
                    picture_dragon.Visible = false;
                    break;
                    
                    

                case GameHandler.characters.Dragon:
                    //Character_Picture.Image = character_images_list.Images["dragon_player.gif"];
                    picture_king.Visible = false;
                    break;
                    
                    
                    

                case GameHandler.characters.Soldier:
                   // picture_king.Image = character_images_list.Images["character3 placeholder.png"];
                    break;
                    
                    
            }



            lbl_stage.Text = "Bölüm:1"; //label at the top

            lbl_hp.Text = GameHandler.player.health.ToString() +"/"+GameHandler.player.max_health.ToString(); //we put the health over the character
            lbl_en_hp.Text = GameHandler.enemy.health.ToString() + "/" + GameHandler.enemy.max_health.ToString();
            game_timer.Enabled = true;


        }
        public void update() //we will call this method whenever we need to update the health eg. health upgrade or damage taking and if either the enemy or the player dies it will return a boolean value and stop the gameplay loop or switch to the next enemy
        {
            


            if (GameHandler.player.health <= 0)
            {
                GameHandler.player.health = 0;
                player_alive = false;
                lbl_hp.Text = "0";

                
                gameover.Show();
                this.Hide();
            }
            else lbl_hp.Text = GameHandler.player.health.ToString() + "/" + GameHandler.player.max_health.ToString();

            if (GameHandler.enemy.health <= 0)
            {
                enemy_alive = false;
                lbl_en_hp.Text = "0";
                Picture_enemy.Visible = false;
                
                

                btn_attack.Enabled = false; //timer isnt fast enough to stop players from getting a hit in before the upgrades spawn so im disableing them here

                if (!boss_active) //if the boss is active(in this case dead) we wont spawn the upgrades
                {
                    GameHandler.spawn_upgrades();

                    upgrade.upgrade_time = true;

                }
                    GameHandler.create_enemy();
                
                
                enemy_alive=true;
                players_turn = true;
                
                update(); //we run this again so the respawned enemies health shows
                
                if (boss_active) //if boss is dead
                {
                    GameHandler.cutscene = GameHandler.Cutscene_Situations.ending_selection;
                    cutscene_player cutscene = new cutscene_player();
                    this.Hide();
                    cutscene.Show();

                }
                if (GameHandler.stage==10) //boss fight
                {
                    boss_active=true;
                    Picture_enemy.Visible = false;

                    lbl_stage.Text = "BOSS SAVAŞI";
                    GameHandler.enemy.health = 1000;
                    GameHandler.enemy.max_health = 1000;
                    GameHandler.enemy.damage = 50;

                    switch (GameHandler.selected_character)  
                    {
                        case GameHandler.characters.King:

                            Enemy_picture_boss_dragon.Visible=true;
                            break;



                        case GameHandler.characters.Dragon:
                            Enemy_picture_boss_king.Visible = true;
                            break;




                        case GameHandler.characters.Soldier:
                            // picture_king.Image = character_images_list.Images["character3 placeholder.png"];
                            break;


                    }


                }
                else 
                {
                    GameHandler.stage++;
                    lbl_stage.Text = "Bölüm:" + GameHandler.stage;
                }
                    
            }
            else lbl_en_hp.Text = GameHandler.enemy.health.ToString() + "/" + GameHandler.enemy.max_health.ToString();


            
            


        }
        
        private void Gameplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_attack_Click(object sender, EventArgs e)
        {
           
            if (players_turn&&player_alive) 
            {
                int dmg;
                dmg = GameHandler.player.calculate_damage(GameHandler.enemy);
                GameHandler.player.deal_damage(dmg, GameHandler.enemy);
                screen_shake(dmg);
                players_turn = false;
                timerbuffer = 0;
                update();
            }
        }

        private void game_timer_Tick(object sender, EventArgs e) //this runs every 100 ms and allows the enemy to attack our player
        {
            
            if (!players_turn&&timerbuffer>=1&&enemy_alive) //there is a delay for the enemy to hit us, otherwise we would get hit right after hitting the enemy and that wouldnt be fun
            {
                
                int dmg;
                dmg=GameHandler.enemy.calculate_damage(GameHandler.player);
                GameHandler.enemy.deal_damage(dmg, GameHandler.player);
                
                screen_shake(dmg);
                
                
                update();
                players_turn=true;
            }
            else if (!enemy_alive)
            {
                players_turn = true;
                update();
                
            }
            else if (!players_turn && timerbuffer < 1)
                timerbuffer += 0.1f;
            else timerbuffer = 0;

            if (upgrade.upgrade_time)
            {
                btn_attack.Enabled = false;
                
            }
            else
            {
                btn_attack.Enabled = true;
                if(!boss_active) { Picture_enemy.Visible = true; }
                
                update();
            }

        }

        
        private void button1_Click(object sender, EventArgs e) //cheat button
        {
            GameHandler.player.damage += 100;
        }



        private void screen_shake(int intensity) //shakes the form window up and down depending on the damage dealt
        {
            intensity = (int)Math.Sqrt(intensity); //we need to take the square root because if the damage is too high window just leaves the monitor


            int x, y;
            x = this.Location.X;
            y = this.Location.Y;
            
                    this.Location = new Point(x, y-intensity);
                System.Threading.Thread.Sleep(30);               //i used sleep because otherwise it would just move it so fast i looked like nothing happened
                    this.Location = new Point(x, y+intensity);
            System.Threading.Thread.Sleep(30);
            this.Location = new Point(x, y);
                    
            
                
            
            
            
        }
        
        

        

        
    }
}
