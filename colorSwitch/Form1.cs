using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorSwitch
{
    public partial class Form1 : Form
    {
        List<Color> colors; // create a list of colors for the game

        Random rnd = new Random(); // new instance of the random class called rnd

        Random blockPosition = new Random(); // new instance of the random class called block position

        int blockColor = 0; // integer that will determine the block colors

        int i; // integer that will change the players color

        int speed = 5; // speed of the blocks in the beginning of the game

        int score = 0; // default score of the game

        bool gameOver = false; // the default game over Boolean

        public Form1()
        {
            InitializeComponent();
            resetGame();
        }

        private void playGame(object sender, EventArgs e)
        {
            block1.Top += speed; // bring the block 1 towards the bottom of this form
            block2.Top += speed; // bring the block 2 towards the bottom of this form
            label1.Text = "Score " + score; // update the label to show how much score we have

            Console.WriteLine($"-block1.Top ==> {block1.Top}");
            //Console.WriteLine($"-block2.Top ==> {block2.Top}");

            // if block 1 has reached bottom of the form then
            if (block1.Top > 500)
            {

                blockColor = rnd.Next(colors.Count); // choose a random color from the list
                block1.BackColor = colors[blockColor]; // apply the random color to block 1
                block1.Top = blockPosition.Next(200, 300) * -1; // randomly position the block on top of the form
                score++; // add 1 to the score

            }


            // if block 2 has reached bottom of the form
            if (block2.Top > 500)
            {
                // add block 1 is already on its way to the form and passed 200 pixels
                if (block1.Top > 100)
                {
                    blockColor = rnd.Next(colors.Count); // choose a random color from the list
                    block2.BackColor = colors[blockColor]; // apply the color to block 2
                    block2.Top = (block1.Top * 8) * -1; // randomly position the block on top of the form
                    score++; //add 1 to the score
                }
            }

            // if the player collides with block 1
            if (player.Bounds.IntersectsWith(block1.Bounds))
            {
                // if the player and block 1 DON'T have the same background color
                if (player.BackColor != block1.BackColor)
                {
                    // we will add the current score to the list box with the time which they were played
                    scoreList.Items.Add("Scored: " + score + " @" + string.Format(" {0:HH:mm:ss tt}", DateTime.Now));
                    // game over
                    gameTimer.Stop(); // stop the timer

                    gameOver = true; // set game over to true now that the player has lost
                }
            }

            // if the player collides with block 2
            if (player.Bounds.IntersectsWith(block2.Bounds))
            {
                // if the player and block 2 DON'T have the same background color
                if (player.BackColor != block2.BackColor)
                {
                    // we will add the current score to the list box with the time which they were played
                    scoreList.Items.Add("Scored: " + score + " @" + string.Format(" {0:HH:mm:ss tt}", DateTime.Now));
                    // game over
                    gameTimer.Stop(); // stop the timer

                    gameOver = true; // set game over to true now that the player has lost
                }
            }

            // if the score is greater than 5 then we increase the speed to 6
            if (score > 5)
            {
                speed = 6;
            }
            // if the score is greater then 10 then we increase the speed to 8
            if (score > 10)
            {
                speed = 8;
            }


            block1.Refresh(); // refresh the block one so its not glitchy when scrolling down
            block2.Refresh(); // refresh the block two so its not glitchy when scrolling down
        }

        private void KeyisDonw(object sender, KeyPressEventArgs e)
        {
            // if the player presses the space key we do the following
            if (e.KeyChar == (char)Keys.Space)
            {
                i++; // increase the i integer by 1

                // if the i integer is greater than the total colours we have in the list
                if (i > colors.Count - 1)
                {
                    // reset i back to 0
                    i = 0;
                }

                player.BackColor = colors[i]; // apply the color to players background
            }

            // if the key capital R or lower case r is pressed then we do the following
            // if the game is also true only then the game will reset else it will not do anything
            if (e.KeyChar == (char)Keys.R || e.KeyChar == char.ToLower((char)Keys.R) && gameOver)
            {
                // invoke the reset game function
                resetGame();
                gameOver = false; // now the game is reset we will set game over to false
            }
        }

        public void resetGame()
        {
            // this is the reset game function
            block1.Top = -80; // set the block 1 to top of the screen at -80 pixels
            block2.Top = -300; // set the block 2 to top of the screen at -300 pixels
                               //below is the list of colors we will add for the player and the blocks

            colors = new List<Color> { System.Drawing.Color.Red, System.Drawing.Color.Yellow, System.Drawing.Color.White, System.Drawing.Color.Purple };

            i = 0; // i is set to 0 as default
            gameTimer.Start(); // start the game timer
            speed = 5; // set the default speed to 5 for the blocks
            score = 0; // default score is 0
        }


    }
}
