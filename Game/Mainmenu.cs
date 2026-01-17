using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{

    public partial class Mainmenu :Form
    {
        
        
        cutscene_player Cutscene_Player = new cutscene_player();
        debug_window debug_Window = new debug_window();
        


        

        public Mainmenu()
        {
            InitializeComponent();
            //debug_Window.Show(); //uncheck this when you need to debug
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            comboBox_lang.SelectedItem = "Türkçe";   //üniversite projesi için default dil Türkçe olacak
                                                     //for my uni project the default language will be Turkish
            
            //comboBox_lang.SelectedItem = "English";
                                                     //itch io'ya yükleyeceğim zaman default dili İngilizce olarak ayarlayacağım
                                                     //when im uploading the game to itch i will change the default language to English
           
            //ingilizce türkçe dil seçeneği fikrini zaman kısıtlamasından dolayı kaldırmak zorunda kaldım
            

            
        }

        private void btn_start_Click(object sender, EventArgs e) //starts first cutscene
        {
            this.Hide();
            Cutscene_Player.Show();
            
        }
        private void btn_exit_Click(object sender, EventArgs e) //exits...
        {
            Application.Exit();
        }
        
        
    }
}
