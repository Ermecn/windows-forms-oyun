namespace Game
{
    partial class Character_Select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Character_Select));
            this.Character_Picture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.character_images_list = new System.Windows.Forms.ImageList(this.components);
            this.btn_continue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Character_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Character_Picture
            // 
            this.Character_Picture.Image = ((System.Drawing.Image)(resources.GetObject("Character_Picture.Image")));
            this.Character_Picture.Location = new System.Drawing.Point(523, 204);
            this.Character_Picture.Name = "Character_Picture";
            this.Character_Picture.Size = new System.Drawing.Size(264, 264);
            this.Character_Picture.TabIndex = 0;
            this.Character_Picture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_next
            // 
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.Location = new System.Drawing.Point(1054, 278);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(132, 132);
            this.btn_next.TabIndex = 2;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Image = ((System.Drawing.Image)(resources.GetObject("btn_previous.Image")));
            this.btn_previous.Location = new System.Drawing.Point(106, 278);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(132, 132);
            this.btn_previous.TabIndex = 3;
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // character_images_list
            // 
            this.character_images_list.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("character_images_list.ImageStream")));
            this.character_images_list.TransparentColor = System.Drawing.Color.Transparent;
            this.character_images_list.Images.SetKeyName(0, "king_cs_tr.png");
            this.character_images_list.Images.SetKeyName(1, "dragon_cs_tr.png");
            // 
            // btn_continue
            // 
            this.btn_continue.Image = ((System.Drawing.Image)(resources.GetObject("btn_continue.Image")));
            this.btn_continue.Location = new System.Drawing.Point(623, 523);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(80, 80);
            this.btn_continue.TabIndex = 5;
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // Character_Select
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.Character_Picture);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Character_Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character_Select";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Character_Select_FormClosing);
            this.Load += new System.EventHandler(this.Character_Select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Character_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Character_Picture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.ImageList character_images_list;
        private System.Windows.Forms.Button btn_continue;
    }
}