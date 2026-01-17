namespace Game
{
    partial class Mainmenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainmenu));
            this.pic_mainmenubg = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.comboBox_lang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mainmenubg)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_mainmenubg
            // 
            this.pic_mainmenubg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_mainmenubg.Image = ((System.Drawing.Image)(resources.GetObject("pic_mainmenubg.Image")));
            this.pic_mainmenubg.Location = new System.Drawing.Point(0, 0);
            this.pic_mainmenubg.Margin = new System.Windows.Forms.Padding(0);
            this.pic_mainmenubg.Name = "pic_mainmenubg";
            this.pic_mainmenubg.Size = new System.Drawing.Size(1280, 720);
            this.pic_mainmenubg.TabIndex = 0;
            this.pic_mainmenubg.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.Image = ((System.Drawing.Image)(resources.GetObject("btn_start.Image")));
            this.btn_start.Location = new System.Drawing.Point(499, 344);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(276, 92);
            this.btn_start.TabIndex = 1;
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(499, 497);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(276, 92);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // comboBox_lang
            // 
            this.comboBox_lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_lang.FormattingEnabled = true;
            this.comboBox_lang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_lang.Items.AddRange(new object[] {
            "Türkçe",
            "English"});
            this.comboBox_lang.Location = new System.Drawing.Point(1111, 621);
            this.comboBox_lang.Name = "comboBox_lang";
            this.comboBox_lang.Size = new System.Drawing.Size(121, 24);
            this.comboBox_lang.TabIndex = 3;
            this.comboBox_lang.Visible = false;
            // 
            // Mainmenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.comboBox_lang);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pic_mainmenubg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_mainmenubg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_mainmenubg;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox comboBox_lang;
    }
}

