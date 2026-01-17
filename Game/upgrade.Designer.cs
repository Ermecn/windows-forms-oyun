namespace Game
{
    partial class upgrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(upgrade));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_current = new System.Windows.Forms.Label();
            this.picture_background = new System.Windows.Forms.PictureBox();
            this.lbl_explain = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture_background)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_current
            // 
            this.lbl_current.AutoSize = true;
            this.lbl_current.BackColor = System.Drawing.Color.Black;
            this.lbl_current.ForeColor = System.Drawing.Color.White;
            this.lbl_current.Location = new System.Drawing.Point(148, 221);
            this.lbl_current.Name = "lbl_current";
            this.lbl_current.Size = new System.Drawing.Size(44, 16);
            this.lbl_current.TabIndex = 1;
            this.lbl_current.Text = "label2";
            // 
            // picture_background
            // 
            this.picture_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_background.Image = ((System.Drawing.Image)(resources.GetObject("picture_background.Image")));
            this.picture_background.Location = new System.Drawing.Point(0, 0);
            this.picture_background.Name = "picture_background";
            this.picture_background.Size = new System.Drawing.Size(410, 402);
            this.picture_background.TabIndex = 2;
            this.picture_background.TabStop = false;
            this.picture_background.Click += new System.EventHandler(this.picture_background_Click);
            // 
            // lbl_explain
            // 
            this.lbl_explain.AutoSize = true;
            this.lbl_explain.BackColor = System.Drawing.Color.Black;
            this.lbl_explain.ForeColor = System.Drawing.Color.White;
            this.lbl_explain.Location = new System.Drawing.Point(22, 284);
            this.lbl_explain.Name = "lbl_explain";
            this.lbl_explain.Size = new System.Drawing.Size(44, 16);
            this.lbl_explain.TabIndex = 3;
            this.lbl_explain.Text = "label2";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "upgrade_health.png");
            this.ımageList1.Images.SetKeyName(1, "upgrade_damage.png");
            this.ımageList1.Images.SetKeyName(2, "upgrade_defence.png");
            this.ımageList1.Images.SetKeyName(3, "upgrade_lifesteal.png");
            this.ımageList1.Images.SetKeyName(4, "upgrade_reflect.png");
            this.ımageList1.Images.SetKeyName(5, "upgrade_luck.png");
            this.ımageList1.Images.SetKeyName(6, "upgrade_crit.png");
            // 
            // upgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(410, 402);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_explain);
            this.Controls.Add(this.lbl_current);
            this.Controls.Add(this.picture_background);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "upgrade";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "upgrade";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.upgrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_current;
        private System.Windows.Forms.PictureBox picture_background;
        private System.Windows.Forms.Label lbl_explain;
        private System.Windows.Forms.ImageList ımageList1;
    }
}