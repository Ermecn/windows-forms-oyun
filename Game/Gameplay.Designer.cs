namespace Game
{
    partial class Gameplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gameplay));
            this.btn_attack = new System.Windows.Forms.Button();
            this.picture_king = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_hp = new System.Windows.Forms.Label();
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_en_hp = new System.Windows.Forms.Label();
            this.character_images_list = new System.Windows.Forms.ImageList(this.components);
            this.lbl_stage = new System.Windows.Forms.Label();
            this.Enemy_picture_boss_king = new System.Windows.Forms.PictureBox();
            this.picture_dragon = new System.Windows.Forms.PictureBox();
            this.Picture_enemy = new System.Windows.Forms.PictureBox();
            this.Enemy_picture_boss_dragon = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_king)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_picture_boss_king)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_dragon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_picture_boss_dragon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_attack
            // 
            this.btn_attack.Image = ((System.Drawing.Image)(resources.GetObject("btn_attack.Image")));
            this.btn_attack.Location = new System.Drawing.Point(148, 635);
            this.btn_attack.Name = "btn_attack";
            this.btn_attack.Size = new System.Drawing.Size(120, 60);
            this.btn_attack.TabIndex = 0;
            this.btn_attack.UseVisualStyleBackColor = true;
            this.btn_attack.Click += new System.EventHandler(this.btn_attack_Click);
            // 
            // picture_king
            // 
            this.picture_king.Image = ((System.Drawing.Image)(resources.GetObject("picture_king.Image")));
            this.picture_king.Location = new System.Drawing.Point(158, 372);
            this.picture_king.Name = "picture_king";
            this.picture_king.Size = new System.Drawing.Size(216, 216);
            this.picture_king.TabIndex = 2;
            this.picture_king.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_hp
            // 
            this.lbl_hp.AutoSize = true;
            this.lbl_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hp.Location = new System.Drawing.Point(171, 316);
            this.lbl_hp.Name = "lbl_hp";
            this.lbl_hp.Size = new System.Drawing.Size(27, 29);
            this.lbl_hp.TabIndex = 6;
            this.lbl_hp.Text = ":)";
            // 
            // game_timer
            // 
            this.game_timer.Tick += new System.EventHandler(this.game_timer_Tick);
            // 
            // lbl_en_hp
            // 
            this.lbl_en_hp.AutoSize = true;
            this.lbl_en_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_en_hp.Location = new System.Drawing.Point(1051, 316);
            this.lbl_en_hp.Name = "lbl_en_hp";
            this.lbl_en_hp.Size = new System.Drawing.Size(41, 29);
            this.lbl_en_hp.TabIndex = 7;
            this.lbl_en_hp.Text = ">:(";
            // 
            // character_images_list
            // 
            this.character_images_list.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("character_images_list.ImageStream")));
            this.character_images_list.TransparentColor = System.Drawing.Color.Transparent;
            this.character_images_list.Images.SetKeyName(0, "dragon_enemy.gif");
            this.character_images_list.Images.SetKeyName(1, "dragon_player.gif");
            this.character_images_list.Images.SetKeyName(2, "king_enemy.gif");
            this.character_images_list.Images.SetKeyName(3, "king_player.gif");
            // 
            // lbl_stage
            // 
            this.lbl_stage.AutoSize = true;
            this.lbl_stage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbl_stage.Location = new System.Drawing.Point(621, 9);
            this.lbl_stage.Name = "lbl_stage";
            this.lbl_stage.Size = new System.Drawing.Size(58, 22);
            this.lbl_stage.TabIndex = 8;
            this.lbl_stage.Text = "label1";
            // 
            // Enemy_picture_boss_king
            // 
            this.Enemy_picture_boss_king.Image = ((System.Drawing.Image)(resources.GetObject("Enemy_picture_boss_king.Image")));
            this.Enemy_picture_boss_king.Location = new System.Drawing.Point(936, 348);
            this.Enemy_picture_boss_king.Name = "Enemy_picture_boss_king";
            this.Enemy_picture_boss_king.Size = new System.Drawing.Size(216, 216);
            this.Enemy_picture_boss_king.TabIndex = 9;
            this.Enemy_picture_boss_king.TabStop = false;
            // 
            // picture_dragon
            // 
            this.picture_dragon.Image = ((System.Drawing.Image)(resources.GetObject("picture_dragon.Image")));
            this.picture_dragon.Location = new System.Drawing.Point(158, 372);
            this.picture_dragon.Name = "picture_dragon";
            this.picture_dragon.Size = new System.Drawing.Size(216, 216);
            this.picture_dragon.TabIndex = 10;
            this.picture_dragon.TabStop = false;
            // 
            // Picture_enemy
            // 
            this.Picture_enemy.Image = ((System.Drawing.Image)(resources.GetObject("Picture_enemy.Image")));
            this.Picture_enemy.Location = new System.Drawing.Point(936, 348);
            this.Picture_enemy.Name = "Picture_enemy";
            this.Picture_enemy.Size = new System.Drawing.Size(216, 216);
            this.Picture_enemy.TabIndex = 11;
            this.Picture_enemy.TabStop = false;
            // 
            // Enemy_picture_boss_dragon
            // 
            this.Enemy_picture_boss_dragon.Image = ((System.Drawing.Image)(resources.GetObject("Enemy_picture_boss_dragon.Image")));
            this.Enemy_picture_boss_dragon.Location = new System.Drawing.Point(936, 348);
            this.Enemy_picture_boss_dragon.Name = "Enemy_picture_boss_dragon";
            this.Enemy_picture_boss_dragon.Size = new System.Drawing.Size(216, 216);
            this.Enemy_picture_boss_dragon.TabIndex = 12;
            this.Enemy_picture_boss_dragon.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 710);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 13;
            this.button1.Text = "btn_cheat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gameplay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Enemy_picture_boss_dragon);
            this.Controls.Add(this.Picture_enemy);
            this.Controls.Add(this.picture_dragon);
            this.Controls.Add(this.Enemy_picture_boss_king);
            this.Controls.Add(this.lbl_stage);
            this.Controls.Add(this.lbl_en_hp);
            this.Controls.Add(this.lbl_hp);
            this.Controls.Add(this.picture_king);
            this.Controls.Add(this.btn_attack);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Gameplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gameplay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gameplay_FormClosing);
            this.Load += new System.EventHandler(this.Gameplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_king)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_picture_boss_king)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_dragon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_picture_boss_dragon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_attack;
        private System.Windows.Forms.PictureBox picture_king;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_hp;
        private System.Windows.Forms.Timer game_timer;
        private System.Windows.Forms.Label lbl_en_hp;
        private System.Windows.Forms.ImageList character_images_list;
        private System.Windows.Forms.Label lbl_stage;
        private System.Windows.Forms.PictureBox Enemy_picture_boss_king;
        private System.Windows.Forms.PictureBox picture_dragon;
        private System.Windows.Forms.PictureBox Picture_enemy;
        private System.Windows.Forms.PictureBox Enemy_picture_boss_dragon;
        private System.Windows.Forms.Button button1;
    }
}