using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldOfSoftuniRPG.Core;
using System.Media;


namespace WorldOfSoftuniRPG.Forms
{
    public partial class Frm_Menu : Form
    {
        private SoundPlayer menuPlayer = new SoundPlayer();
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.bt_StartGame.Visible = false;
            this.bt_Exit.Visible = false;

            Image image =
                Image.FromFile(
                    @"C:\Users\Borislav\Desktop\WorldOfSoftUniGAME\Forms\Resources\tumblr_ni186jsRPw1skb54qo1_500.gif");
            this.pictureBox1.Image = image;
            this.pictureBox1.Height = image.Height;
            this.pictureBox1.Width = image.Width;
            this.menuPlayer = new SoundPlayer(@"C:\Users\Borislav\Desktop\WorldOfSoftUniGAME\Forms\Resources\menu.wav");
            this.menuPlayer.Play();
        }

        private void bt_StartGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Frm_HeroSelection();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pic_NewGame_MouseHover(object sender, EventArgs e)
        {
            this.pic_NewGame.Visible = false;
            this.bt_StartGame.Visible = true;
        }

        private void pic_Exit_MouseHover(object sender, EventArgs e)
        {
            this.pic_Exit.Visible = false;
            this.bt_Exit.Visible = true;
        }

        private void bt_StartGame_MouseLeave(object sender, EventArgs e)
        {
            this.bt_StartGame.Visible = false;
            this.pic_NewGame.Visible = true;
        }

        private void bt_Exit_MouseLeave(object sender, EventArgs e)
        {
            this.bt_Exit.Visible = false;
            this.pic_Exit.Visible = true;
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Game game = new Game();
            game.Stop();
        }
    }
}
