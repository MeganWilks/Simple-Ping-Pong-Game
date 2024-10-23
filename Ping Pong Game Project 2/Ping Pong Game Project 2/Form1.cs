namespace Ping_Pong_Game_Project_2
{
    public partial class Player : Form
    {

        //Variables--------------------------------
        int BallSpeedX = 4;
        int BallSpeedY = 4;
        int Speed = 2;
        int PlayerSpeed = 8;
        Random rond = new Random(); // Selects Random Speed for the ball
        bool GoDown, GoUp;// Controls if the player moves up or down
        int ChangeComputerSpeed = 50;
        int PlayersScore = 0;
        int ComputersScore = 0;
        int[] a = {5, 6, 8, 9}; // Random Ball Speeds
        int[] b = { 10, 9, 8, 11, 12 }; // Random ball speeds for top variables
        public Player()
        {
            InitializeComponent();
        }

        private void GameTimeEvent(object sender, EventArgs e)
        {
            Ball.Top -= BallSpeedY; //
            Ball.Left -= BallSpeedX; //

            this.Text = "Score = Player Score: " + PlayersScore + "   Computer Score: " + ComputersScore;

            if(Ball.Top < 0 || Ball.Bottom > this.ClientSize.Height) // If the ball has reached the top of the screen
            {
                BallSpeedY = -BallSpeedY; // Reduce Y Axis (Ball goes down)

            }

            if(Ball.Left < -2) // if Ball reaches left border
            {
                Ball.Left = 300; //
                BallSpeedX = -BallSpeedX; // Send ball to the right
                ComputersScore++;  // Add a point to Computer
            }

            if(Ball.Right > this.ClientSize.Width + 2) // if ball has reached right border
            {
                Ball.Left = 300; // Send ball to the Left
                BallSpeedX = -BallSpeedX; //
                PlayersScore++; // Add a point to computer
            }
            if(Computer.Top <= 1) // Stopping Computer from leaving the screen
            {
                Computer.Top = 0;
            }
            else if (Computer.Bottom >= this.ClientSize.Height)//
            {
                Computer.Top = this.ClientSize.Height - Computer.Height;
            }

            if(Ball.Top < Computer.Top + (Computer.Height / 2) && Ball.Left > 300)
            {
                Computer.Top -= Speed; 
            }

            if (Ball.Top > Computer.Top + (Computer.Height / 2) && Ball.Left > 300)
            {
                Computer.Top += Speed; // If ball is moving down and below computer then the computer will go down
            }

            ChangeComputerSpeed -= 1;

            if(ChangeComputerSpeed < 0)
            {
               Speed = a[rond.Next(a.Length)];
               ChangeComputerSpeed = 50; // Randomises Ball Speed it comes of as
            }

            if(GoDown && players.Top + players.Height < this.ClientSize.Height)
            {
                players.Top += PlayerSpeed; // Stops player moving outside the boundaries
            }

            if(GoUp && players.Top > 0 )
            {
                players.Top -= PlayerSpeed; // stops player leaving the boundaries
            }

            CollisionCheck(Ball, players, players.Right + 5); // Using the Collison Check functions and passing in the parameters I need
            CollisionCheck(Ball, players, Computer.Left - 35);

            if (ComputersScore > 5)
            {
                FinishGame("Sorry the computer has won the game");
                
            }
            else if (PlayersScore > 5)
            {
                FinishGame("Well done you have won the game");
                
            }
               
       

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                GoDown = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                GoUp = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                GoDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                GoUp = false;
            }

        }

       private void CollisionCheck(PictureBox Pic1, PictureBox Pic2, int offset)
            // Checks whether player/computer have collided with ball if they have then moves ball to an offset
        {
            if (Pic1.Bounds.IntersectsWith(Pic2.Bounds)) // Checks whether pics have collided
            {
                Pic1.Left = offset;

                int x = b[rond.Next(b.Length)]; // Randomises Ball Speed
                int y = b[rond.Next(b.Length)];

                if (BallSpeedX < 0)
                {
                    BallSpeedX = x;
                }
                else
                {
                    BallSpeedX = -x;
                }

                if (BallSpeedY < 0)
                {
                    BallSpeedY = -y;
                }
                else
                {
                    BallSpeedY = y;
                }
            }


        }

        private void FinishGame(string GameOver)
        {
            GameTime.Stop(); // Stops Timer
            MessageBox.Show(GameOver); // Shows Players Score
            PlayersScore = 0; // Resetting Players Score
            ComputersScore = 0; // Resetting Computers Score
            BallSpeedX = BallSpeedY = 4; // Resetting Balls Speed
            ChangeComputerSpeed = 50; // Resetting Computers Speed
            GameTime.Start(); // Replays the game
          
        }
    }
}


