namespace WorldOfSoftuniRPG.Forms
{
    partial class Frm_HeroSelection
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
            System.Windows.Forms.PictureBox pictureBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HeroSelection));
            this.pic_WarriorLil = new System.Windows.Forms.PictureBox();
            this.pic_MageLil = new System.Windows.Forms.PictureBox();
            this.pic_Warrior = new System.Windows.Forms.PictureBox();
            this.pic_Mage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_WarriorLil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MageLil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warrior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Mage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBox2.Location = new System.Drawing.Point(166, 151);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(165, 275);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pic_WarriorLil
            // 
            this.pic_WarriorLil.BackColor = System.Drawing.Color.Transparent;
            this.pic_WarriorLil.Image = ((System.Drawing.Image)(resources.GetObject("pic_WarriorLil.Image")));
            this.pic_WarriorLil.Location = new System.Drawing.Point(448, 52);
            this.pic_WarriorLil.Name = "pic_WarriorLil";
            this.pic_WarriorLil.Size = new System.Drawing.Size(70, 70);
            this.pic_WarriorLil.TabIndex = 11;
            this.pic_WarriorLil.TabStop = false;
            this.pic_WarriorLil.Click += new System.EventHandler(this.pic_WarriorLil_Click);
            this.pic_WarriorLil.MouseHover += new System.EventHandler(this.pic_WarriorLil_MouseHover);
            // 
            // pic_MageLil
            // 
            this.pic_MageLil.BackColor = System.Drawing.Color.Transparent;
            this.pic_MageLil.Image = ((System.Drawing.Image)(resources.GetObject("pic_MageLil.Image")));
            this.pic_MageLil.Location = new System.Drawing.Point(215, 52);
            this.pic_MageLil.Name = "pic_MageLil";
            this.pic_MageLil.Size = new System.Drawing.Size(70, 70);
            this.pic_MageLil.TabIndex = 10;
            this.pic_MageLil.TabStop = false;
            this.pic_MageLil.MouseHover += new System.EventHandler(this.pic_MageLil_MouseHover);
            // 
            // pic_Warrior
            // 
            this.pic_Warrior.BackColor = System.Drawing.Color.Transparent;
            this.pic_Warrior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Warrior.Image = ((System.Drawing.Image)(resources.GetObject("pic_Warrior.Image")));
            this.pic_Warrior.Location = new System.Drawing.Point(433, 35);
            this.pic_Warrior.Name = "pic_Warrior";
            this.pic_Warrior.Size = new System.Drawing.Size(100, 100);
            this.pic_Warrior.TabIndex = 9;
            this.pic_Warrior.TabStop = false;
            this.pic_Warrior.Click += new System.EventHandler(this.pic_Warrior_Click);
            this.pic_Warrior.MouseLeave += new System.EventHandler(this.pic_Warrior_MouseLeave);
            // 
            // pic_Mage
            // 
            this.pic_Mage.BackColor = System.Drawing.Color.Transparent;
            this.pic_Mage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Mage.Image = ((System.Drawing.Image)(resources.GetObject("pic_Mage.Image")));
            this.pic_Mage.Location = new System.Drawing.Point(199, 35);
            this.pic_Mage.Name = "pic_Mage";
            this.pic_Mage.Size = new System.Drawing.Size(100, 100);
            this.pic_Mage.TabIndex = 8;
            this.pic_Mage.TabStop = false;
            this.pic_Mage.Click += new System.EventHandler(this.pic_Mage_Click);
            this.pic_Mage.MouseLeave += new System.EventHandler(this.pic_Mage_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 275);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_HeroSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.pic_WarriorLil);
            this.Controls.Add(this.pic_MageLil);
            this.Controls.Add(this.pic_Warrior);
            this.Controls.Add(this.pic_Mage);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_HeroSelection";
            this.Text = "HeroSelection";
            this.Load += new System.EventHandler(this.HeroSelection_Load);
            this.MouseHover += new System.EventHandler(this.HeroSelection_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_WarriorLil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MageLil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Warrior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Mage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_WarriorLil;
        private System.Windows.Forms.PictureBox pic_MageLil;
        private System.Windows.Forms.PictureBox pic_Warrior;
        private System.Windows.Forms.PictureBox pic_Mage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}