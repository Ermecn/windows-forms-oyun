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
    public partial class Game_over : Form 
    {
        public Game_over()
        {
            InitializeComponent();
        }
        
        private void Game_over_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_retry_Click(object sender, EventArgs e)
        {
            GameHandler.create_player();
            Gameplay gameplay = new Gameplay();
            gameplay.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
