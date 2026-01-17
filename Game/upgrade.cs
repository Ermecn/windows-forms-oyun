using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class upgrade : Form
    {
        public static bool upgrade_time=false; //we need this bool to disable the attack/defend buttons in gameplay inorder to stop players to keep attacking without selecting upgrades
        static bool upgrade_is_selected=false; //this guy will tell other forms(2 other upgrades) to close when we pick our upgrades
        static int upgrade_count = 0; //we use this variable to have a count of how many upgrades there are and use that to move them accordingly

        Random rnd = new Random(); //we will use this guy to randomly generate which upgrade option we will get

        enum Upgrades { can_upgrade, hasar_upgrade, savunma_upgrade, can_calma, geri_sektirme,sans,krit_hasar} //upgrade list 
        // first three are self explainatory, lifesteal will heal the player per damage, reflect will reflect some of the damage back to the enemy,luck decides if we roll a succesful lifesteal or crit or reflect.

        
        static Upgrades randUpgrade; //we use this to store the randomly selected upgrade so we can compare if its the same as the last one
        
        static Upgrades? ExistingUpgrade1;  //i tried using arrays but it kind of didnt work so we have two now i guess
        static Upgrades? ExistingUpgrade2;  //those question marks mean nullable, makes me able to reset them after the third upgrade spawns


        public upgrade()
        {
            InitializeComponent();
            upgrade_count++;
            upgrade_is_selected = false;

        }

        

        private void upgrade_Load(object sender, EventArgs e) //this runs for every upgrade window spawned
        {
            
            
            while (ExistingUpgrade1 == randUpgrade||ExistingUpgrade2 == randUpgrade) //we run this loop until all 3 of the upgrades are different from eachother
                {
                
                Array values = Enum.GetValues(typeof(Upgrades));
                randUpgrade = (Upgrades)values.GetValue(rnd.Next(values.Length)); //we pull a random upgrade type here(i took this from stackoverflow) :)
            }
            
                
                
            
            






            switch (upgrade_count) //we put the upgrades one by one
            {
                case 1:
                    label1.Text=randUpgrade.ToString(); //we write the upgrade name on a label that the player cannot see. so the code can read and know what the upgrade is (i know this is not really a good way of doing it but i had no other working ideas)
                    getcurrentvalue();
                    ExistingUpgrade1=randUpgrade; //we take this to use it on that loop above
                    break;

                case 2:
                    label1.Text = randUpgrade.ToString();
                    getcurrentvalue();
                    ExistingUpgrade2=randUpgrade;
                    break;

                case 3:
                    label1.Text = randUpgrade.ToString();
                    getcurrentvalue();
                    ExistingUpgrade1 = null; //we set the existing upgrades as null so we can run this code however many times as we like
                    ExistingUpgrade2=null;
                    break;
            }






            //upgradelerin sağ sol ve ortada spawn olması

            Point location= new Point(this.Location.X, this.Location.Y); //we get the location of them so we can slide them outwards 
            
            switch (upgrade_count) //we spawn the first one 400 pixels to the left keep the middle one where it is and push the last one 400 pixels to the right
            {
                case 1:
                    this.Location = new Point(location.X-400, location.Y);
                    break;
                    
                case 2:
                    //do nothing lol
                    break;
                    
                case 3:
                    this.Location = new Point(location.X+400,location.Y);
                    upgrade_count = 0;
                    break;
            }
        }

       


        private void timer1_Tick(object sender, EventArgs e) //oyuncunun upgrade seçip seçmediğini kontrol ediyoruz, seçtiği zaman diger upgrade formlarını kapatıyoruz
        {
            if (upgrade_is_selected)
            {
                this.Hide();
                upgrade_time = false;
            }
            
            
        }
        public void getcurrentvalue() //we read the invisible label on the upgrade form, write the upgrades result and show the upgrade image accordingly
        {
            switch (label1.Text)
            {
                case "can_upgrade":
                    lbl_current.Text=GameHandler.player.max_health.ToString()+"->"+(GameHandler.player.max_health + (int)(GameHandler.player.max_health / 4)).ToString();
                    picture_background.Image=ımageList1.Images["upgrade_health.png"];
                    lbl_explain.Text = "Can geliştirmesi, max canı arttırır ve biraz can iyileştirir";
                    break;
                case "hasar_upgrade":
                    lbl_current.Text = GameHandler.player.damage.ToString()+"->"+(GameHandler.player.damage + (int)(GameHandler.player.damage / 2)).ToString();
                    picture_background.Image = ımageList1.Images["upgrade_damage.png"];
                    lbl_explain.Text = "hasar geliştirmesi, karakterin verdiği hasarı arttırır ";
                    break;
                case "savunma_upgrade":
                    lbl_current.Text = GameHandler.player.defence.ToString() + "->" + (GameHandler.player.defence + (int)(1 + GameHandler.player.defence / 2)).ToString();
                    picture_background.Image = ımageList1.Images["upgrade_defence.png"];
                    lbl_explain.Text = "savunma geliştirmesi, karakterin aldığı hasarı azaltır";
                    break;
                case "can_calma":
                    lbl_current.Text = GameHandler.player.lifesteal.ToString() + "->" + (GameHandler.player.lifesteal + (int)(5 + GameHandler.player.lifesteal / 2)).ToString();
                    picture_background.Image = ımageList1.Images["upgrade_lifesteal.png"];
                    lbl_explain.Text = "Can çalma, düşmana her vurulduğunda belli bir miktar\ncan iyileştirir";
                    break;
                case "geri_sektirme":
                    lbl_current.Text = GameHandler.player.reflect.ToString() + "->" + (GameHandler.player.reflect + (int)(5 + GameHandler.player.reflect / 2)).ToString();
                    picture_background.Image = ımageList1.Images["upgrade_reflect.png"];
                    lbl_explain.Text = "Geri sektirme, şans denk gelirse hasardan kaçınılır\nve karakter yerine düşman hasar alır";
                    break;
                case "sans":
                    lbl_current.Text = GameHandler.player.luck.ToString() + "->" + (GameHandler.player.luck + 10).ToString();
                    picture_background.Image = ımageList1.Images["upgrade_luck.png"];
                    lbl_explain.Text = "şans, kritik hasar ve geri sektirme denk gelme olasılığını\narttırır";
                    break;
                case "krit_hasar":
                    lbl_current.Text = GameHandler.player.crit_multiplier.ToString() + "->" + (GameHandler.player.crit_multiplier + 2).ToString();
                    picture_background.Image = ımageList1.Images["upgrade_crit.png"];
                    lbl_explain.Text = "Kritik hasar oranı, karakter kritik hasar vurduğu zaman\nnormal hasarın x katı olmasını sağlar";
                    break;
            }
        }

        private void picture_background_Click(object sender, EventArgs e) //give player the selected upgrade and close the forms
        {
            
            upgrade_is_selected = true;
            switch (label1.Text) //gizli labeli okuyarak upgradenin ne olduguna karar veriyoruz
            {
                case "can_upgrade":
                    GameHandler.player.max_health += (int)(GameHandler.player.max_health / 4); //25% max health increase+12.5%heal
                    GameHandler.player.health += (int)(GameHandler.player.max_health / 8);
                    if (GameHandler.player.health > GameHandler.player.max_health) GameHandler.player.health = GameHandler.player.max_health;
                    break;
                case "hasar_upgrade":
                    GameHandler.player.damage += (int)(GameHandler.player.damage / 2); //50% damage increase
                    break;
                case "savunma_upgrade":
                    GameHandler.player.defence += (int)(1 + GameHandler.player.defence / 2); //50%+1 defence increase
                    break;
                case "can_calma":
                    GameHandler.player.lifesteal += (int)(5 + GameHandler.player.lifesteal / 2); //5+50% lifesteal upgrade
                    break;
                case "geri_sektirme":
                    GameHandler.player.reflect += (int)(5 + GameHandler.player.reflect / 2); //5+50% reflect upgrade
                    break;
                case "sans":
                    GameHandler.player.luck += 10; //10% more lucky lol(its just too op to make it exponantial
                    break;
                case "krit_hasar":
                    GameHandler.player.crit_multiplier += 2; //this will be op
                    break;
            }
            this.Hide();
        }
    }
}
