using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class GameHandler
    {
        //-----static objects-----
        public static Player player;
        public static Enemy enemy;
        
        //-----character enums-----
        public enum characters { King, Dragon, Soldier }
        static public characters selected_character;
        
        //-----gameplay stuff-----
        public static int stage=1; //this will change a bar at the top, and define how strong our enemies will be and how far we have come

        


        //-----cutscene thingies-----
        public enum Cutscene_Situations { beginning, character, boss_encounter, ending_selection, ending_good, ending_bad}
        static public Cutscene_Situations cutscene;

        

        //-----methods-----
        public static void create_player() //we need this to create the player after the character selection, or when we restart after dying
        {
           player = new Player();
            
            
        }

        public static void create_enemy() //to spawn new enemies in the gameplay
        {
            enemy = new Enemy(stage);
        }
        public static void spawn_upgrades() //we spawn 3 upgrade boxes
        {
            for (int i = 1; i <= 3; i++)
            {
                upgrade upgrade = new upgrade();
                upgrade.Show();
            }
                
                
        }
    }
    
    
    internal class Player : GameHandler //i used inheritance here so we can get the selected character from gamehandler and give different stats based on the character
    {
        public int health;
        public int max_health;
        public int damage;
        public int defence;
        public float crit_multiplier; 
        public int luck;     
        public int lifesteal;
        public int reflect;


        public int calculate_damage(Enemy en)//we will calculate based on enemy
        {
            Random random = new Random();
            int dmg=damage-(en.defence/damage);
            if (dmg < 0) dmg = 0;

            if (random.Next(101)<luck) //successful dice roll based on character luck
            {
                dmg = (int)(dmg * crit_multiplier);
            }
            
            return dmg;
        }

        public void deal_damage(int dmg,Enemy en)
        {
            
            en.health -=dmg;
            health += lifesteal;
            if (health > max_health) health = max_health; //make sure we dont overheal
        }
        public Player() //constructor
        {
            
            switch (selected_character) 
            {
                case characters.King:
                    max_health = 150;
                    health = max_health;
                    damage = 15;
                    defence = 10;
                    luck = 20;
                    crit_multiplier = 1.5f;
                    lifesteal = 0;
                    reflect = 10;
                    break;
                    
                case characters.Dragon:
                    max_health = 300;
                    health = max_health;
                    damage = 20;
                    defence = 15;
                    luck = 5;
                    crit_multiplier = 2f;
                    lifesteal = 0;
                    reflect = 0;
                    break;
                    
                case characters.Soldier:
                    max_health = 100;
                    health = max_health;
                    damage = 5;
                    defence = 5;
                    luck = 30;
                    crit_multiplier = 1.25f;
                    lifesteal = 0;
                    reflect = 3;
                    break;
            }
                    
        }
        
    }
    
    interface Ienemy //i used an interface because i initially planned to have more than one type of enemy class that can do different types of attacks but didnt have enough time
    {
        int health { get; set; }

        int max_health { get; set; }

        int damage { get; set; }

        int defence { get; set; }

        int calculate_damage(Player pl);

        void deal_damage(int dmg,Player pl);


    }


    
    internal class Enemy : Ienemy
    {
        public int health { get; set; } = 100;
        public int max_health { get; set; } = 100;
        public int damage { get; set; } = 100;
        public int defence { get; set; } = 100;

        public int calculate_damage(Player pl)
        {
            int dmg = damage-(pl.defence/damage);
            if (dmg < 0) { dmg = 0; }

            
            
            return dmg;
        }

        public void deal_damage(int dmg, Player pl)
        {
            Random random = new Random();
            
            if (random.Next(101)<(pl.luck)/2) //succesful dice roll for reflect (harder to achieve)
            {
                health -= dmg;
            }
            else
                pl.health -= dmg;
        }
        public Enemy(int stage) //enemy constructor where we define values we use the stage we are currently in to assign the power of the enemy(and some randomness)
        {
            Random rng = new Random();
            double multiplier;

            multiplier = rng.NextDouble() + 1; //returns a value between 1.0 and 2.0
            max_health = (int)(100*multiplier*Math.Sqrt(stage));
            health = max_health;
            damage = (int)(5*multiplier * Math.Sqrt(stage));
            defence = (int)(2*multiplier * Math.Sqrt(stage));
        }  
        
    }
}
        
        
        
        
       







