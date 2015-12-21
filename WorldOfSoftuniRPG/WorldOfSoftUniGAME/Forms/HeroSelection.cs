using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldOfSoftuniRPG.Core;
using WorldOfSoftuniRPG.Models.Fields;
using WorldOfSoftuniRPG.Models.Players;

namespace WorldOfSoftuniRPG.Forms
{
    public partial class Frm_HeroSelection : Form
    {
        private SoundPlayer music;

        public Frm_HeroSelection()
        {
            InitializeComponent();
        }

        private void HeroSelection_MouseHover(object sender, EventArgs e)
        {

        }

        private void pic_MageLil_MouseHover(object sender, EventArgs e)
        {
            this.pic_MageLil.Visible = false;
            this.pic_Mage.Visible = true;
        }

        private void HeroSelection_Load(object sender, EventArgs e)
        {
            this.music = new SoundPlayer(@"C:\Users\Borislav\Desktop\WorldOfSoftUniGAME\Forms\Resources\pick.wav");
            this.music.Play();
            this.pic_Mage.Visible = false;
            this.pic_Warrior.Visible = false;
        }

        private void pic_Mage_MouseLeave(object sender, EventArgs e)
        {
            this.pic_MageLil.Visible = true;
            this.pic_Mage.Visible = false;
        }

        private void pic_Mage_Click(object sender, EventArgs e)
        {
            this.Close();
            Game game = new Game();
            game.Start();
            Field.Hero = new Mage();
            this.DrawSoftUni();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(
                "-------------------Welcome to our game \"World of SofrUni\".-------------------");
            Console.WriteLine();
            Console.WriteLine(new string(Constants.LineSeparator, 79));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have create new hero Mage.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(new string(Constants.LineSeparator, 79));
            Console.WriteLine("1.To continue playing please enter command \"help\" to show you all command.");
            Console.WriteLine(new string(Constants.LineSeparator, 79));
            Console.WriteLine("2.To exit the game enter command \"exit\".");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void pic_Warrior_Click(object sender, EventArgs e)
        {
            this.Close();
            Game game = new Game();
            game.Start();
            Field.Hero = new Warrior();
            this.DrawSoftUni();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(
               "-------------------Welcome to our game \"World of SofrUni\".-------------------");
            Console.WriteLine();
            Console.WriteLine(new string(Constants.LineSeparator, 79));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have create new Warrior.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(new string(Constants.LineSeparator, 79));
            Console.WriteLine("1.To continue playing please enter command \"help\" to show you all command.");
            Console.WriteLine(new string(Constants.LineSeparator, 79));
            Console.WriteLine("2.To exit the game enter command \"exit\".");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void pic_WarriorLil_Click(object sender, EventArgs e)
        {

        }

        private void pic_WarriorLil_MouseHover(object sender, EventArgs e)
        {
            this.pic_WarriorLil.Visible = false;
            this.pic_Warrior.Visible = true;
        }

        private void pic_Warrior_MouseLeave(object sender, EventArgs e)
        {

            this.pic_Warrior.Visible = false;
            this.pic_WarriorLil.Visible = true;
        }

        public void DrawSoftUni()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"             **       **              **  *****       ****   *****");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"              **     **   * *   ****  **  **   *     **  **  **   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"               ** * **   *   *  **    **  **   *     **  **  *****");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"                ** **     * *   **    **  *****       ****   **");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"                 *****                        **   **         **");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"                 **            *****  ******  **   **           ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                 *****   * *   **       **    **   **  **  *  **");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                    **  *   *  *****    **    **   **  * * *  **");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                 *****   * *   **       **     *****   *  **  **");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
