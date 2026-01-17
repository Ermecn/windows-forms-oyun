namespace Game
{
    partial class cutscene_player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cutscene_player));
            this.lbl_cutscene = new System.Windows.Forms.Label();
            this.Cutscene_timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cutscene
            // 
            this.lbl_cutscene.AutoSize = true;
            this.lbl_cutscene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_cutscene.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.lbl_cutscene.ForeColor = System.Drawing.Color.White;
            this.lbl_cutscene.Location = new System.Drawing.Point(12, 99);
            this.lbl_cutscene.Name = "lbl_cutscene";
            this.lbl_cutscene.Size = new System.Drawing.Size(1244, 56);
            this.lbl_cutscene.TabIndex = 0;
            this.lbl_cutscene.Text = "Bir zamanlar, uzak diyarlarda birbirine düşman iki krallık varmış\\n";
            // 
            // Cutscene_timer
            // 
            this.Cutscene_timer.Tick += new System.EventHandler(this.Cutscene_timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1284, 724);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(868, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Atlamak için esc\'ye basın...";
            // 
            // cutscene_player
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1284, 724);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cutscene);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "cutscene_player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cutscene_player";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cutscene_player_FormClosed);
            this.Load += new System.EventHandler(this.cutscene_player_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cutscene_player_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cutscene;
        private System.Windows.Forms.Timer Cutscene_timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}