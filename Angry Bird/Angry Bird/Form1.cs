using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Angry_Bird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8; // default pipe speed defined with an integer
        int gravity = 15; // default gravity speed defined with an integer
        int score = 0; // default score integer set to 0

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity; // link the flappy bird picture box to the gravity, += means it will add the speed of gravity to the picture boxes top location so it will move down
            pipeBottom.Left -= pipeSpeed; // link the bottom pipes left position to the pipe speed integer, it will reduce the pipe speed value from the left position of the pipe picture box so it will move left with each tick


            pipeTop.Left -= pipeSpeed; // the same is happening with the top pipe, reduce the value of pipe speed integer from the left position of the pipe using the -= sign


            scoreText.Text = "Score: " + score; // show the current score on the score text label

            // below we are checking if any of the pipes have left the screen

            if (pipeBottom.Left < -150)
            {
                // if the bottom pipes location is -150 then we will reset it back to 800 and add 1 to the score
                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left < -180)
            {
                // if the top pipe location is -180 then we will reset the pipe back to the 950 and add 1 to the score
                pipeTop.Left = 950;
                score++;
            }


            if (bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
               bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
               bird.Bounds.IntersectsWith(ground.Bounds) || bird.Top < -25
               )
            {
                // if any of the conditions are met from above then we will run the end game function
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-2ASBBC1;Initial Catalog=angrybird;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("update highestscore set score = @score", con);
                cmd.Parameters.AddWithValue("@score", score);
                cmd.ExecuteNonQuery();
                con.Close();
                endGame();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {

            // this is the game key is down event thats linked to the main form
            if (e.KeyCode == Keys.Space)
            {
                // if the space key is pressed then the gravity will be set to -15
                gravity = -15;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            // this is the game key is up event thats linked to the main form

            if (e.KeyCode == Keys.Space)
            {
                // if the space key is released then gravity is set back to 15
                gravity = 15;
            }

        }

        private void endGame()
        {
            // this is the game end function, this function will when the bird touches the ground or the pipes
            gametimer.Stop(); // stop the main timer
            scoreText.Text += " Game over!!!"; // show the game over text on the score text, += is used to add the new string of text next to the score instead of overriding it
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
      