namespace WorldOfSoftuniRPG.Forms
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_StartGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_NewGame = new System.Windows.Forms.PictureBox();
            this.pic_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NewGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Exit.FlatAppearance.BorderSize = 0;
            this.bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Exit.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Exit.Image = ((System.Drawing.Image)(resources.GetObject("bt_Exit.Image")));
            this.bt_Exit.Location = new System.Drawing.Point(122, 387);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(241, 71);
            this.bt_Exit.TabIndex = 4;
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            this.bt_Exit.MouseLeave += new System.EventHandler(this.bt_Exit_MouseLeave);
            // 
            // bt_StartGame
            // 
            this.bt_StartGame.BackColor = System.Drawing.Color.Transparent;
            this.bt_StartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_StartGame.FlatAppearance.BorderSize = 0;
            this.bt_StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_StartGame.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_StartGame.Image = ((System.Drawing.Image)(resources.GetObject("bt_StartGame.Image")));
            this.bt_StartGame.Location = new System.Drawing.Point(122, 312);
            this.bt_StartGame.Name = "bt_StartGame";
            this.bt_StartGame.Size = new System.Drawing.Size(241, 71);
            this.bt_StartGame.TabIndex = 3;
            this.bt_StartGame.UseVisualStyleBackColor = false;
            this.bt_StartGame.Click += new System.EventHandler(this.bt_StartGame_Click);
            this.bt_StartGame.MouseLeave += new System.EventHandler(this.bt_StartGame_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 465);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(-8, 269);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(494, 194);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pic_NewGame
            // 
            this.pic_NewGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_NewGame.BackgroundImage")));
            this.pic_NewGame.Location = new System.Drawing.Point(167, 323);
            this.pic_NewGame.Name = "pic_NewGame";
            this.pic_NewGame.Size = new System.Drawing.Size(156, 49);
            this.pic_NewGame.TabIndex = 7;
            this.pic_NewGame.TabStop = false;
            this.pic_NewGame.MouseHover += new System.EventHandler(this.pic_NewGame_MouseHover);
            // 
            // pic_Exit
            // 
            this.pic_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Exit.BackgroundImage")));
            this.pic_Exit.Location = new System.Drawing.Point(167, 400);
            this.pic_Exit.Name = "pic_Exit";
            this.pic_Exit.Size = new System.Drawing.Size(156, 49);
            this.pic_Exit.TabIndex = 8;
            this.pic_Exit.TabStop = false;
            this.pic_Exit.MouseHover += new System.EventHandler(this.pic_Exit_MouseHover);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.pic_Exit);
            this.Controls.Add(this.pic_NewGame);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_StartGame);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NewGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_StartGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pic_NewGame;
        private System.Windows.Forms.PictureBox pic_Exit;
    }
}