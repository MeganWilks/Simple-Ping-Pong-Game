namespace Ping_Pong_Game_Project_2
{
    partial class Player
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            players = new PictureBox();
            Computer = new PictureBox();
            Ball = new PictureBox();
            GameTime = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)players).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Computer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ball).BeginInit();
            SuspendLayout();
            // 
            // players
            // 
            players.Image = (Image)resources.GetObject("players.Image");
            players.Location = new Point(12, 131);
            players.Name = "players";
            players.Size = new Size(30, 120);
            players.SizeMode = PictureBoxSizeMode.StretchImage;
            players.TabIndex = 0;
            players.TabStop = false;
            // 
            // Computer
            // 
            Computer.Image = (Image)resources.GetObject("Computer.Image");
            Computer.Location = new Point(758, 131);
            Computer.Name = "Computer";
            Computer.Size = new Size(30, 120);
            Computer.SizeMode = PictureBoxSizeMode.StretchImage;
            Computer.TabIndex = 1;
            Computer.TabStop = false;
            // 
            // Ball
            // 
            Ball.Image = (Image)resources.GetObject("Ball.Image");
            Ball.Location = new Point(391, 184);
            Ball.Name = "Ball";
            Ball.Size = new Size(30, 30);
            Ball.SizeMode = PictureBoxSizeMode.StretchImage;
            Ball.TabIndex = 2;
            Ball.TabStop = false;
            // 
            // GameTime
            // 
            GameTime.Enabled = true;
            GameTime.Interval = 20;
            GameTime.Tick += GameTimeEvent;
            // 
            // Player
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(Ball);
            Controls.Add(Computer);
            Controls.Add(players);
            Name = "Player";
            Text = "Score - Player 0 Computer: 0";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)players).EndInit();
            ((System.ComponentModel.ISupportInitialize)Computer).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ball).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox players;
        private PictureBox Computer;
        private PictureBox Ball;
        private System.Windows.Forms.Timer GameTime;
    }
}
