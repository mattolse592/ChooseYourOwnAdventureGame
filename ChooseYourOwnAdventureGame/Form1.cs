//Matthew Olsen
//Choose your own adventure game
//October 27 2022

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace ChooseYourOwnAdventureGame
{
    public partial class Form1 : Form
    {
        Random ranGen = new Random();

        int page = 1;
        string bought = "";

        public Form1()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height + 50);

            outputLabel.Text = "You are choosing your first pokemon";
            button1.Text = "Squirtle";
            button2.Text = "Bulbasaur";
            button3.Text = "Charmander";

            button3.Visible = true;
            pictureBox1.Image = Properties.Resources.page_1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 3;
                bought = "yes";
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 90;
            }
            else if (page == 7)
            {
                if (bought == "yes")
                {
                    page = 9;
                }
                else
                {
                    page = 8;
                }
            }
            else if (page == 8)
            {
                page = 90;
            }
            else if (page == 9)
            {
                page = 92;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 90;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 92;
            }
            else if (page == 16)
            {
                page = 90;
            }
            else if (page == 17)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 90;
            }
            else if (page == 19)
            {
                page = 90;
            }
            else if (page == 20)
            {
                page = 21;
            }
            else if (page == 21)
            {
                page = 23;
            }
            else if (page == 22)
            {
                if (ranGen.Next(1, 101) > 50)
                {
                    page = 26;
                }
                else
                {
                    page = 25;
                }
            }
            else if (page == 23)
            {
                page = 90;
            }
            else if (page == 25)
            {
                if (ranGen.Next(1, 101) > 5)
                {
                    page = 30;
                }
                else
                {
                    page = 31;
                }
            }
            else if (page == 26)
            {
                if (ranGen.Next(1, 101) > 5)
                {
                    page = 30;
                }
                else
                {
                    page = 31;
                }
            }
            else if (page == 27)
            {
                page = 29;
            }
            else if (page == 28)
            {
                page = 92;
            }
            else if (page == 29)
            {
                page = 90;
            }
            else if (page == 30)
            {
                page = 90;
            }
            else if (page == 31)
            {
                page = 92;
            }
            else if (page == 90)
            {
                page = 1;
            }
            else if (page == 92)
            {
                page = 1;
            }
            switch (page)
            {
                case 1:
                    this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height + 50);

                    outputLabel.Text = "You are choosing your first pokemon";
                    button1.Text = "Squirtle";
                    button2.Text = "Bulbasaur";
                    button3.Text = "Charmander";

                    button3.Visible = true;
                    pictureBox1.Image = Properties.Resources.page_1;
                    break;
                case 2:
                    this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height - 50);

                    outputLabel.Text = "You pick Squirtle and then start to walk along the beach. Someone approaches you and tries to sell you a revive potion for 3 coins";
                    button1.Text = "Buy it";
                    button2.Text = "Leave it";

                    button3.Visible = false;
                    pictureBox1.Image = Properties.Resources.page_2;
                    break;
                case 3:
                    outputLabel.Text = "You buy the potion and continue your search for more pokemon";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_3;
                    SoundPlayer kaching = new SoundPlayer(Properties.Resources.kaching);
                    kaching.Play();
                    break;
                case 4:
                    outputLabel.Text = "You decide to leave and continue your walk saving those three coins for later.";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_3;
                    break;
                case 5:
                    outputLabel.Text = "You see a wild Horsea and decide to battle it.";
                    button1.Text = "Battle for xp";
                    button2.Text = "Battle to capture";

                    pictureBox1.Image = Properties.Resources.page_5;
                    break;
                case 6:
                    outputLabel.Text = "You are a new pokemon trainer and you are too trigger happy with your Squirtle's attacks. You kill the Horsea instead of knocking it out and the pokemon officials come to arrest you.";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_6;
                    break;
                case 7:
                    outputLabel.Text = "You successfully knock out and capture the Horsea.";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_7;
                    break;
                case 8:
                    outputLabel.Text = "The Horsea slowly dies because you did not buy the revive earlier. You lose";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_6;
                    break;
                case 9:
                    outputLabel.Text = "You revive the Horsea and continue on your pokemon trainer journey.";
                    button1.Text = "Click to continue";
                    button2.Text = "";
                    break;
                case 10:
                    button3.Visible = false;
                    this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height - 50);
                    SoundPlayer forest = new SoundPlayer(Properties.Resources.jungle);
                    forest.Play();

                    outputLabel.Text = "You pick Bulbasaur and then take a walk in the forest. You spot a group of Diglett off the path.";
                    button1.Text = "Check them out";
                    button2.Text = "Continue your walk";

                    pictureBox1.Image = Properties.Resources.page_10;
                    break;
                case 11:
                    outputLabel.Text = "You try to navigate the increasingly dense undergrowth. You can take Bulbasaur out to help you.";
                    button1.Text = "Take Bulbasaur out";
                    button2.Text = "Continue yourself";

                    pictureBox1.Image = Properties.Resources.page_11;
                    break;
                case 12:
                    outputLabel.Text = "You throw Bulbasaur's pokeball but then a whole group of Beedrill attack you and Bulbasaur.";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_12;
                    break;
                case 13:
                    outputLabel.Text = "You slowly pass by a group of Beedrill and when you make it to the group of Diglett, you find out that they have captured someone.";
                    button1.Text = "Save the person";
                    button2.Text = "Run away";

                    pictureBox1.Image = Properties.Resources.page_13;
                    break;
                case 14:
                    outputLabel.Text = "You throw Bulbasaur's Pokeball and use his vine attack. He whips all of the Digletts into the ground and you rescue the captured person";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_14;
                    break;
                case 15:
                    outputLabel.Text = "The person is so grateful that he gives you a max level Greninja.";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_15;
                    break;
                case 16:
                    outputLabel.Text = "You start running back to the path but then you slam into a Beedrill that you passed earlier. The whole swarm attacks you and you lose";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_12;
                    break;
                case 17:
                    outputLabel.Text = "You come across another Pokémon trainer and he insists that you battle. You throw Bulbasaur out of the Pokeball and decide what attack to make.";
                    button1.Text = "Vine whip";
                    button2.Text = "Razor leaf";

                    pictureBox1.Image = Properties.Resources.page_17;
                    break;
                case 18:
                    outputLabel.Text = "The whips come our of Bulbasaur's back but you are fighting a Chimchar and you automatically lose.";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_14;
                    break;
                case 19:
                    outputLabel.Text = "Bulbasaur's razor leaves spray everywhere and impale you in the throat.";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_19;
                    break;
                case 20:
                    this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height + 50);
                    button3.Visible = true;
                    pictureBox1.Image = Properties.Resources.page_20;

                    outputLabel.Text = "You pick Charmander and take a walk along the fire biome to look for more Pokémon.";
                    button1.Text = "Look behind the boulder";
                    button2.Text = "Look behind the rock pillar";
                    button3.Text = "Look behind the lavafall";
                    break;
                case 21:
                    outputLabel.Text = "Looking behind the boulder, you see a level 40 Arcanine";
                    button1.Text = "Battle it";
                    button2.Text = "Move on";

                    button3.Visible = false;
                    this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height - 50);
                    pictureBox1.Image = Properties.Resources.page_21;
                    break;
                case 22:
                    outputLabel.Text = "Circling around the rock pillar, you see a Litleo and decide to battle it.  ";
                    button1.Text = "";
                    button2.Text = "";

                    button3.Visible = false;
                    pictureBox1.Image = Properties.Resources.page_22;
                    break;
                case 23:
                    outputLabel.Text = "A level 40 Arcanine is too much for your starter Charmander and you lose.";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_23;
                    break;
                case 25:
                    outputLabel.Text = "You successfully battle the Litleo but your Pokeball misses and Litleo runs away.";
                    button1.Text = "Check behind lavafall";
                    button2.Text = "Walk into the forest";

                    pictureBox1.Image = Properties.Resources.page_25;
                    break;
                case 26:
                    outputLabel.Text = "You successfully battle the Litleo and capture him in your pokeball.";
                    button1.Text = "Check behind lavafall";
                    button2.Text = "Walk into the forest";

                    pictureBox1.Image = Properties.Resources.page_26;
                    break;
                case 27:
                    outputLabel.Text = "As you walk into the forest, another Pokémon trainer approaches you and asks to battle.";
                    button1.Text = "Run away";
                    button2.Text = "Battle";

                    pictureBox1.Image = Properties.Resources.page_17;
                    break;
                case 28:
                    outputLabel.Text = "Since you are in the forest, your fire pokemon have a great advantage and you win.";
                    button1.Text = "";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_28;
                    break;
                case 29:
                    outputLabel.Text = "You run away but the Pokemon trainer sends his Greninja after you and you get destroyed";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_29;
                    break;
                case 30:
                    outputLabel.Text = "You trip and fall and die in the lava";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_30;
                    SoundPlayer scream = new SoundPlayer(Properties.Resources.scream);
                    scream.Play();
                    break;
                case 31:
                    outputLabel.Text = "You see a legendary Entei that has already been knocked out. You quickly throw a Pokeball and capture it.";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_31;
                    SoundPlayer angel = new SoundPlayer(Properties.Resources.angel);
                    angel.Play();
                    break;
                case 90:
                    outputLabel.Text = "You lose. Would you like to play again?";
                    button1.Text = "Yes";
                    button2.Text = "No";

                    pictureBox1.Image = null;
                    SoundPlayer lose = new SoundPlayer(Properties.Resources.lose);
                    lose.Play();
                    break;
                case 92:
                    outputLabel.Text = "YOU WIN. Would you like to play again?";
                    button1.Text = "Yes";
                    button2.Text = "No";

                    pictureBox1.Image = null;
                    SoundPlayer win = new SoundPlayer(Properties.Resources.win);
                    win.Play();
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing";

                    button1.Visible = false;
                    button2.Visible = false;
                    Thread.Sleep(2000);
                    this.Close();
                    break;
                default:
                    outputLabel.Text = "aaaaahhh";
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 10;
            }
            else if (page == 2)
            {
                bought = "no";
                page = 4;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 7)
            {
                if (bought == "yes")
                {
                    page = 9;
                }
                else
                {
                    page = 8;
                }
            }
            else if (page == 8)
            {
                page = 90;
            }
            else if (page == 10)
            {
                page = 17;
            }
            else if (page == 11)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 16;
            }
            else if (page == 17)
            {
                page = 19;
            }
            else if (page == 20)
            {
                page = 22;
            }
            else if (page == 22)
            {
                if (ranGen.Next(1, 101) > 50)
                {
                    page = 26;
                }
                else
                {
                    page = 25;
                }
            }
            else if (page == 21)
            {
                page = 22;
            }
            else if (page == 22)
            {
                if (ranGen.Next(1, 101) > 50)
                {
                    page = 26;
                }
                else
                {
                    page = 25;
                }
            }
            else if (page == 25)
            {
                page = 27;
            }
            else if (page == 26)
            {
                page = 27;
            }
            else if (page == 27)
            {
                page = 28;
            }
            else if (page == 90)
            {
                page = 99;
            }
            else if (page == 92)
            {
                page = 99;
            }
            switch (page)
            {
                case 1:
                    this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height + 50);

                    outputLabel.Text = "You are choosing your first pokemon";
                    button1.Text = "Squirtle";
                    button2.Text = "Bulbasaur";
                    button3.Text = "Charmander";

                    button3.Visible = true;
                    pictureBox1.Image = Properties.Resources.page_1;
                    break;
                case 2:
                    this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height - 50);

                    outputLabel.Text = "You pick Squirtle and then start to walk along the beach. Someone approaches you and tries to sell you a revive potion for 3 coins";
                    button1.Text = "Buy it";
                    button2.Text = "Leave it";

                    button3.Visible = false;
                    pictureBox1.Image = Properties.Resources.page_2;
                    break;
                case 3:
                    outputLabel.Text = "You buy the potion and continue your search for more pokemon";
                    button1.Text = "";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_3;
                    SoundPlayer kaching = new SoundPlayer(Properties.Resources.kaching);
                    kaching.Play();
                    break;
                case 4:
                    outputLabel.Text = "You decide to leave and continue your walk saving those three coins for later.";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_3;
                    break;
                case 5:
                    outputLabel.Text = "You see a wild Horsea and decide to battle it.";
                    button1.Text = "Battle for xp";
                    button2.Text = "Battle to capture";

                    pictureBox1.Image = Properties.Resources.page_5;
                    break;
                case 6:
                    outputLabel.Text = "You are a new pokemon trainer and you are too trigger happy with your Squirtle's attacks. You kill the Horsea instead of knocking it out and the pokemon officials come to arrest you.";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_6;
                    break;
                case 7:
                    outputLabel.Text = "You successfully knock out and capture the Horsea.";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_7;
                    break;
                case 8:
                    outputLabel.Text = "The Horsea slowly dies because you did not buy the revive earlier. You lose";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_6;
                    break;
                case 9:
                    outputLabel.Text = "You revive the Horsea with the potion you bought earlier and continue on your pokemon trainer journey.";
                    button1.Text = "Click to continue";
                    button2.Text = "";
                    break;
                case 10:
                    button3.Visible = false;
                    this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height - 50);

                    outputLabel.Text = "You pick Bulbasaur and then take a walk in the forest. You spot a group of Diglett off the path.";
                    button1.Text = "Check them out";
                    button2.Text = "Continue your walk";

                    pictureBox1.Image = Properties.Resources.page_10;
                    break;
                case 11:
                    outputLabel.Text = "You try to navigate the increasingly dense undergrowth. You can take Bulbasaur out to help you.";
                    button1.Text = "Take Bulbasaur out";
                    button2.Text = "Continue yourself";

                    pictureBox1.Image = Properties.Resources.page_11;
                    break;
                case 12:
                    outputLabel.Text = "You throw Bulbasaur's pokeball but then a whole group of Beedrill attack you and Bulbasaur.";
                    button1.Text = "";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_12;
                    break;
                case 13:
                    outputLabel.Text = "You slowly pass by a group of Beedrill and when you make it to the group of Diglett, you find out that they have captured someone.";
                    button1.Text = "Save the person";
                    button2.Text = "Run away";

                    pictureBox1.Image = Properties.Resources.page_13;
                    break;
                case 14:
                    outputLabel.Text = "You throw Bulbasaur's Pokeball and use his vine attack. He whips all of the Digletts into the ground and you rescue the captured person";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_14;
                    break;
                case 15:
                    outputLabel.Text = "The person is so grateful that he gives you a max level Greninja.";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_15;
                    break;
                case 16:
                    outputLabel.Text = "You start running back to the path but then you slam into a Beedrill that you passed earlier. The whole swarm attacks you and you lose";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_12;
                    break;
                case 17:
                    outputLabel.Text = "You come across another Pokémon trainer and he insists that you battle. You throw Bulbasaur out of the Pokeball and decide what attack to make.";
                    button1.Text = "Vine whip";
                    button2.Text = "Razor leaf";

                    pictureBox1.Image = Properties.Resources.page_17;
                    break;
                case 18:
                    outputLabel.Text = "The whips come our of Bulbasaur's back but you are fighting a Chimchar and you automatically lose.";
                    button1.Text = "";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_14;
                    break;
                case 19:
                    outputLabel.Text = "Bulbasaur's razor leaves spray everywhere and impale you in the throat.";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_19;
                    break;
                case 20:
                    outputLabel.Text = "You pick Charmander and take a walk along the fire biome to look for more Pokémon.";
                    button1.Text = "Look behind the boulder";
                    button2.Text = "Look behind the rock pillar";
                    button3.Text = "Look behind the lavafall";

                    button3.Visible = true;
                    pictureBox1.Image = Properties.Resources.page_20;
                    break;
                case 21:
                    outputLabel.Text = "Looking behind the boulder, you see a level 40 Arcanine";
                    button1.Text = "Battle it";
                    button2.Text = "Move on";

                    button3.Visible = false;
                    this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height - 50);
                    pictureBox1.Image = Properties.Resources.page_21;
                    break;
                case 22:
                    button3.Visible = false;
                    this.Size = new System.Drawing.Size(this.Size.Width, 460);

                    outputLabel.Text = "Circling around the rock pillar, you see a Litleo and decide to battle it.  ";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_22;
                    break;
                case 23:
                    outputLabel.Text = "A level 40 Arcanine is too much for your starter Charmander and you lose.";
                    button1.Text = "";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_23;
                    break;
                case 25:
                    outputLabel.Text = "You successfully battle the Litleo but your Pokeball misses and Litleo runs away.";
                    button1.Text = "Check behind lavafall";
                    button2.Text = "Walk into the forest";

                    pictureBox1.Image = Properties.Resources.page_25;
                    break;
                case 26:
                    outputLabel.Text = "You successfully battle the Litleo and capture him in your pokeball.";
                    button1.Text = "Check behind lavafall";
                    button2.Text = "Walk into the forest";

                    pictureBox1.Image = Properties.Resources.page_26;
                    break;
                case 27:
                    outputLabel.Text = "As you walk into the forest, another Pokémon trainer approaches you and asks to battle.";
                    button1.Text = "Run away";
                    button2.Text = "Battle";

                    pictureBox1.Image = Properties.Resources.page_17;
                    break;
                case 28:
                    outputLabel.Text = "Since you are in the forest, your fire pokemon have a great advantage and you win.";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_28;
                    break;
                case 29:
                    outputLabel.Text = "You run away but the Pokemon trainer sends his Greninja after you and you get destroyed";
                    button1.Text = "";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_29;
                    break;
                case 30:
                    outputLabel.Text = "You trip and fall and die in the lava";
                    button1.Text = "";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_30;
                    SoundPlayer scream = new SoundPlayer(Properties.Resources.scream);
                    scream.Play();
                    break;
                case 31:
                    outputLabel.Text = "You see a legendary Entei that has already been knocked out. You quickly throw a Pokeball and capture it.";
                    button1.Text = "Click to continue";
                    button2.Text = "";

                    pictureBox1.Image = Properties.Resources.page_31;
                    SoundPlayer angel = new SoundPlayer(Properties.Resources.angel);
                    angel.Play();
                    break;
                case 90:
                    outputLabel.Text = "You lose. Would you like to play again?";
                    button1.Text = "Yes";
                    button2.Text = "No";

                    pictureBox1.Image = null;
                    SoundPlayer lose = new SoundPlayer(Properties.Resources.lose);
                    lose.Play();
                    break;
                case 92:
                    outputLabel.Text = "YOU WIN. Would you like to play again?";
                    button1.Text = "Yes";
                    button2.Text = "No";

                    SoundPlayer win = new SoundPlayer(Properties.Resources.win);
                    win.Play();
                    pictureBox1.Image = null;
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing";

                    button1.Visible = false;
                    button2.Visible = false;
                    Thread.Sleep(2000);
                    this.Close();
                    break;
                default:
                    outputLabel.Text = "aaaaahhh";
                    break;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 20;
            }
            //random generator for lava thing
            else if (page == 20)
            {
                if (ranGen.Next(1, 101) > 5)
                {
                    page = 30;
                }
                else
                {
                    page = 31;
                }
            }
            switch (page)
            {
                case 1:
                    this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height + 50);

                    outputLabel.Text = "You are choosing your first pokemon";
                    button1.Text = "Squirtle";
                    button2.Text = "Bulbasaur";
                    button3.Text = "Charmander";

                    button3.Visible = true;
                    break;
                case 2:
                    outputLabel.Text = "You pick Squirtle and then start to walk along the beach. Someone approaches you and tries to sell you a revive potion for 3 coins";
                    button3.Visible = false;
                    this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height - 50);
                    button1.Text = "Buy it";
                    button2.Text = "Leave it";
                    break;
                case 3:
                    outputLabel.Text = "You buy the potion and continue your search for more pokemon";
                    button1.Text = "";
                    button2.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "You decide to leave and continue your walk saving those three coins for later.";
                    button1.Text = "";
                    button2.Text = "";
                    break;
                case 5:
                    outputLabel.Text = "You see a wild Horsea and decide to battle it.";
                    button1.Text = "Battle for xp";
                    button2.Text = "Battle to capture";
                    break;
                case 6:
                    outputLabel.Text = "You are a new pokemon trainer and you are too trigger happy with your Squirtle's attacks. You kill the Horsea instead of knocking it out and the pokemon officials come to arrest you.";
                    button1.Text = "";
                    button2.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "You successfully knock out and capture the Horsea.";
                    button1.Text = "";
                    button2.Text = "";
                    break;
                case 8:
                    outputLabel.Text = "The Horsea slowly dies because you did not buy the revive earlier. You lose";
                    button1.Text = "";
                    button2.Text = "";
                    break;
                case 9:
                    outputLabel.Text = "You revive the Horsea and continue on your pokemon trainer journey.";
                    button1.Text = "";
                    button2.Text = "";
                    break;
                case 10:
                    button3.Visible = false;
                    this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height - 50);

                    outputLabel.Text = "You pick Bulbasaur and then take a walk in the forest. You spot a group of Diglett off the path.";
                    button1.Text = "Check them out";
                    button2.Text = "Continue your walk";
                    break;
                case 11:
                    outputLabel.Text = "You try to navigate the increasingly dense undergrowth. You can take Bulbasaur out to help you.";
                    button1.Text = "Take Bulbasaur out";
                    button2.Text = "Continue yourself";
                    break;
                case 12:
                    outputLabel.Text = "You throw Bulbasaur's pokeball but then a whole group of Beedrill attack you and Bulbasaur.";
                    button1.Text = "";
                    button2.Text = "";
                    break;
                case 13:
                    outputLabel.Text = "You slowly pass by a group of Beedrill and when you make it to the group of Diglett, you find out that they have captured someone.";
                    button1.Text = "Save the person";
                    button2.Text = "Run away";
                    break;
                case 14:
                    outputLabel.Text = "You throw Bulbasaur's Pokeball and use his vine attack. He whips all of the Digletts into the ground and you rescue the captured person";
                    button1.Text = "";
                    button2.Text = "";
                    break;
                case 15:
                    outputLabel.Text = "The person is so grateful that he gives you a max level Greninja.";
                    button1.Text = "";
                    button2.Text = "";
                    //win
                    break;
                case 16:
                    outputLabel.Text = "You start running back to the path but then you slam into a Beedrill that you passed earlier. The whole swarm attacks you and you lose";
                    button1.Text = "";
                    button2.Text = "";
                    //lose
                    break;
                case 17:
                    outputLabel.Text = "You come across another Pokémon trainer and he insists that you battle. You throw Bulbasaur out of the Pokeball and decide what attack to make.";
                    button1.Text = "Vine whip";
                    button2.Text = "Razor leaf";
                    break;
                case 18:
                    outputLabel.Text = "The whips come our of Bulbasaur's back but you are fighting a Chimchar and you automatically lose.";
                    button1.Text = "";
                    button2.Text = "";
                    //lose
                    break;
                case 19:
                    outputLabel.Text = "Bulbasaur's razor leaves spray everywhere and impale you in the throat.";
                    button1.Text = "";
                    button2.Text = "";
                    //lose
                    break;
                case 20:
                    outputLabel.Text = "You pick Charmander and take a walk along the fire biome to look for more Pokémon.";
                    button1.Text = "Look behind the boulder";
                    button2.Text = "Look behind the rock pillar";
                    button3.Text = "Look behind the lavafall";

                    pictureBox1.Image = Properties.Resources.page_20;
                    break;
                case 21:
                    outputLabel.Text = "Looking behind the boulder, you see a level 40 Arcanine";
                    button1.Text = "Battle it";
                    button2.Text = "Move on";

                    button3.Visible = false;
                    this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height - 50);
                    break;
                case 22:
                    button3.Visible = false;
                    this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height - 50);

                    outputLabel.Text = "Circling around the rock pillar, you see a Litleo and decide to battle it.  ";
                    button1.Text = "";
                    button2.Text = "";
                    break;
                case 23:
                    outputLabel.Text = "A level 40 Arcanine is too much for your starter Charmander and you lose.";
                    button1.Text = "";
                    button2.Text = "";
                    break;
                case 25:
                    outputLabel.Text = "You successfully battle the Litleo but your Pokeball misses and Litleo runs away.";
                    button1.Text = "Check behind lavafall";
                    button2.Text = "Walk into the forest";
                    break;
                case 26:
                    outputLabel.Text = "You successfully battle the Litleo and capture him in your pokeball.";
                    button1.Text = "Check behind lavafall";
                    button2.Text = "Walk into the forest";
                    break;
                case 27:
                    outputLabel.Text = "As you walk into the forest, another Pokémon trainer approaches you and asks to battle.";
                    button1.Text = "Run away";
                    button2.Text = "Battle";
                    break;
                case 28:
                    outputLabel.Text = "Since you are in the forest, your fire pokemon have a great advantage and you win.";
                    button1.Text = "";
                    button2.Text = "";
                    break;
                case 29:
                    outputLabel.Text = "You run away but the Pokemon trainer sends his Greninja after you and you get destroyed";
                    button1.Text = "";
                    button2.Text = "";
                    break;
                case 30:
                    this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height - 50);
                    button3.Visible = false;
                    outputLabel.Text = "You trip and fall and die in the lava";
                    button1.Text = "Click to continue";
                    button2.Text = "";
                    pictureBox1.Image = Properties.Resources.page_30;
                    SoundPlayer scream = new SoundPlayer(Properties.Resources.scream);
                    scream.Play();
                    break;
                case 31:
                    outputLabel.Text = "You see a legendary Entei that has already been knocked out. You quickly throw a Pokeball and capture it.";
                    button1.Text = "Click to continue";
                    button2.Text = "";
                    pictureBox1.Image = Properties.Resources.page_31;
                    SoundPlayer angel = new SoundPlayer(Properties.Resources.angel);
                    angel.Play();
                    break;
                case 90:
                    outputLabel.Text = "You lose. Would you like to play again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    break;
                case 92:
                    outputLabel.Text = "WOU WIN. Would you like to play again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing";
                    button1.Visible = false;
                    button2.Visible = false;
                    Thread.Sleep(2000);
                    this.Close();
                    break;
                default:
                    outputLabel.Text = "aaaaahhh";
                    break;
            }
        }
    }
}
