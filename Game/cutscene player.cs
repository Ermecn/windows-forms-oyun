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
   

    public partial class cutscene_player : Form
    {


        //GameHandler handler = new GameHandler();
        
        public static Character_Select Character_Selection = new Character_Select(); //bunu static yapmaz isem character select bunu oluşturuyor bu character select oluşturuyor ve sonsuz döngüye giriyor 
        
        public static decision decision = new decision(); //bağışlama bağışlamama sahnesinin classı

        public static Gameplay Gameplay = new Gameplay(); //"oynanış" sekansının classı
         
        float Time_elapsed=0; //ara sahneleri belli bir süre sonra geçmek için kullandım
        
        public cutscene_player()
        {
            InitializeComponent();
            
            
        }

        private void cutscene_player_Load(object sender, EventArgs e)
        {
            Cutscene_timer.Start();
            Time_elapsed = 0f;
            switch (GameHandler.cutscene)
            {
                case GameHandler.Cutscene_Situations.character: //character according cutscene
                    switch (GameHandler.selected_character)
                    {
                        case GameHandler.characters.King:
                            lbl_cutscene.Text = "Generallerle toplantı yapan kral, savaşın aleyhine gittiği kararını almıştır.\ncephelerde ağır kayıplar vardır ve askerlerde savaşacak güç kalmamıştır...\n\nKral kara kara düşünürken odaya bir haberci gelir.\n\nhaberci savaş alanında herkese saldıran bir ejderha olduğu haberi ile gelmiştir.\n\nKral yapması gerekeni bilerek kılıcını çekip savaş alanına yönelir...";
                            break;
                        case GameHandler.characters.Dragon:
                            lbl_cutscene.Text = "Savaş alanının hemen dışındaki bir mağarada, yavrusu ile uyuyan bir ejderha vardır\n anne ejderha uyurken yavru ejderhanın dikkatini dışarıdan gelen sesler çekmiştir\nMerak duygusuna yenik düşen ejder yavrusu mağaradan ayrılır...\n\nUykusundan uyanan ejderha yavrusunu mağarada bulamayınca dehşete düşer\nhemen onu aramak için mağaradan ayrılır.\nHedefinde savaş alanı vardır...";
                            break;
                        case GameHandler.characters.Soldier:
                            lbl_cutscene.Text = "Askerin hikaye ara sahnesi";
                            break;
                    }
                    break;
                    
                case GameHandler.Cutscene_Situations.boss_encounter: //scrapped
                    //normalde 10 düşman yenip bossa ulaşınca bir ara sahne oynatmayı planlıyordum ama zaman kısıtlaması dolayısı ile iptal etmem gerekti
                    break;

                case GameHandler.Cutscene_Situations.ending_selection:
                   
                    if(GameHandler.selected_character==GameHandler.characters.King)
                    {
                    lbl_cutscene.Text = "Kralın kılıcına gücünü yetiremeyen ejder, yere yığılır.\n\no sırada kral kılıcını hazırlar...";
                    }
                    else lbl_cutscene.Text = "Ejderhayı hafife alan kral kendini yerde bulur\n\nejderha gözlerinin içine nefret ile bakıyordur...";
                    break;

                case GameHandler.Cutscene_Situations.ending_good: //good selection
                    if (GameHandler.selected_character == GameHandler.characters.King)
                    {
                        lbl_cutscene.Text = "Ejderhayı bağışlamayı seçen kral kılıcını kınına koyar.\nTam oradan ayrılıp ordusunun başına dönecek iken...\nBir ejder yavrusu belirir.\nYavrusu ile özlem gideren ejderha krala saygı babında boynunu eğer,\nve yavrusu ile mağaraya doğru yönelir...\n\nKralın bu merhamet ve cesaretinden etkilenen ordu,\nkralın önderliğinde savaşı kazanma yoluna girmiştir...\n\n\nSon.";
                    }
                    else lbl_cutscene.Text = "Kralı yendikten sonra, tam işini bitirecek iken duraksayan ejderha, \nneden burada olduğunu hatırlar.\n\nKralı yerde öylece bırakıp evladını aramaya devam etmek için arksını döner...\nTam havalanacak iken arkasından bir ses duyar, bu yavrusudur!\n\nYavru ejder şaşkınlık ile yerdeki krala bakıyordur,kral gülümser\nEjderha yavrusunu alıp mağaraya dönmeye yola koyulur.\n\nYorgun düşen kral orduyu yönetemeyecek haldedir. \nsavaşı kaybedeceğini kabullenen kral bulunduğu tepeden savaşın seyrini izler...\n\nSon.";
                    break;
                
                case GameHandler.Cutscene_Situations.ending_bad:  //bad selection
                    if (GameHandler.selected_character == GameHandler.characters.King)
                    {
                        lbl_cutscene.Text = "Ejderhayı alt eden kral, acımasız bir şekilde ejderhanın canını alır\nEjderhayı öldürdükten sonra muhteşem bir güce kavuşan kral \nOrdusunun başına dönüp savaşa katılır\nzafer kaçınılmazdır...\n\n\niki yaşlı göz hariç herkes mutludur...";
                    }
                    else lbl_cutscene.Text = "Kralı yendikten sonra, hiç düşünmeden kralın canını alır\n\nyavrusunu aramaya devam etmek için arkasını döndüğünde yavrusunu görür\nyavru korkmuş bir ifade ile annesine bakar\nEjderha yavrusunu savaş alanından çıkartıp mağraya geri döner\n\nO sırada kralın ölmesi ile birlikte ordu iyice dağılmış, generaller taht peşinde koşmaktadır\nyenilgi kaçınılmazdır...\n\n\nSon.";
                    break;

                   
                    default: //beginning cutscene
                    lbl_cutscene.Text = "Eski bir zamanda, uzak diyarlarda birbirine düşman iki krallık varmış\n\nBu iki krallık, günümüze kadar yıllar boyu savaş içerisinde bulunmuşlardır\nNeredeyse 100 yıl süren savaştan iki krallıkta çok bitkin ve bıkkın haldedirler\n\n\nFakat bugün... savaşın son günü olacaktır.";
                    break;
                    

            }
        }

        public void Cutscene_timer_Tick(object sender, EventArgs e) //runs every 100 ms ; her 100 ms de tekrar edecek
        {
            
            Time_elapsed += 0.1f;


            switch (GameHandler.cutscene) //her cutscene'in zaman ve kendinden sonraki formu açacağı switch bloğu
            {
                case GameHandler.Cutscene_Situations.beginning: //beginning cutscene
                    if (Time_elapsed >= 15f)
                    {
                        Cutscene_timer.Stop();
                        Time_elapsed = 0;
                        Character_Selection.Show();
                        this.Hide();
                        GameHandler.cutscene = GameHandler.Cutscene_Situations.character; //the next cutscene that plays will be the character one
                    }
                    break;
                    
                case GameHandler.Cutscene_Situations.character: //character according cutscene
                    if (Time_elapsed >= 20f)
                    {
                        Cutscene_timer.Stop();
                        Time_elapsed = 0;
                        Gameplay.Show();
                        this.Hide();
                         
                    }
                    break;
                
                case GameHandler.Cutscene_Situations.ending_selection: //bunu ne zaman yazdım hatırlamıyorum
                    if (Time_elapsed >= 10f)
                    {
                        Cutscene_timer.Stop();
                        Time_elapsed = 0;
                        this.Hide();
                        decision.Show();

                    }
                    break;
                
                case GameHandler.Cutscene_Situations.ending_bad: //character according cutscene
                    if (Time_elapsed >= 50f)
                    {
                        Cutscene_timer.Stop();
                        Time_elapsed = 0;
                        this.Hide();
                        Application.Exit();
                        

                    }
                    break;
                
                case GameHandler.Cutscene_Situations.ending_good: //character according cutscene
                    if (Time_elapsed >= 50f)
                    {
                        Cutscene_timer.Stop();
                        Time_elapsed = 0;
                        this.Hide();
                        Application.Exit();

                    }
                    break;
            }
            
   
        }

        private void cutscene_player_FormClosed(object sender, FormClosedEventArgs e) //eğer bunu koymazsam main menu arkada çalışmaya devam edecek
        {
            Application.Exit();
        }

        private void cutscene_player_KeyDown(object sender, KeyEventArgs e) //skip cutscene when pressed escape
        {
            switch (e.KeyCode) 
            {
                case Keys.Escape:
                    Time_elapsed = 50f;
                    break;
            }
        }
    }
}
