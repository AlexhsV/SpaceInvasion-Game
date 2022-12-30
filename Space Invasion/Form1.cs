using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Space_Invasion
{
    public partial class Form1 : Form
    {

        bool isGameOver = true;
        int score;
        int seconds;
        int hearts;
        SoundPlayer pew;
        SoundPlayer music;
        SoundPlayer hurtSound;
        SoundPlayer gameOver;
        Random r;

        List<PictureBox> bullets = new List<PictureBox>();
        List<PictureBox> bullets2 = new List<PictureBox>();
        int[] scores = new int[10];
        

        private bool _moveUp;
        private bool _moveDown;
        private bool _moveLeft;
        private bool _moveRight;

        //https://stackoverflow.com/questions/29942437/removing-the-delay-after-keydown-event
        //code for improved movement

        private System.Windows.Forms.Timer _movementTimer = new Timer { Interval = 100 };
        public Form1()
        {
            InitializeComponent();

            game_Over.Hide();

            _movementTimer.Tick += movementTimer_Tick;
        }

        private void movementTimer_Tick(object sender, EventArgs e)
        {
            _DoMovement();
        }

        private void _DoMovement()
        {
            if (_moveLeft && (pictureBoxSpaceship.Right - 20) > 145 && isGameOver == false) pictureBoxSpaceship.Location = new Point(pictureBoxSpaceship.Location.X - 20, pictureBoxSpaceship.Location.Y);
            if (_moveRight && (pictureBoxSpaceship.Left + 20 ) < (this.Width - 155) && isGameOver == false) pictureBoxSpaceship.Location = new Point(pictureBoxSpaceship.Location.X + 20, pictureBoxSpaceship.Location.Y);
            if (_moveUp && (pictureBoxSpaceship.Top - 20) > 0 && isGameOver == false ) pictureBoxSpaceship.Location = new Point(pictureBoxSpaceship.Location.X, pictureBoxSpaceship.Location.Y - 20);
            if (_moveDown && (pictureBoxSpaceship.Bottom + 20) < (this.Height - 50) && isGameOver == false ) pictureBoxSpaceship.Location = new Point(pictureBoxSpaceship.Location.X, pictureBoxSpaceship.Location.Y + 20);
        }

        // We could of course override the OnKeyDown() method instead assuming the handler is in the Form subclass generating the event.


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode.ToString().Equals("Space") && isGameOver == false)
            {
                createBullet(pictureBoxSpaceship.Location.X);
            }

            switch (e.KeyCode)
            {
                case Keys.Up:
                    _moveUp = true;
                    break;
                case Keys.Down:
                    _moveDown = true;
                    break;
                case Keys.Left:
                    _moveLeft = true;
                    break;
                case Keys.Right:
                    _moveRight = true;
                    break;
            }

            _DoMovement();
            _movementTimer.Start();


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxSpaceship.ImageLocation = "spaceship.png";
            r = new Random();
            pew = new SoundPlayer("shooting.wav");
            music = new SoundPlayer("retromusic.wav");
            hurtSound = new SoundPlayer("hurt.wav");
            gameOver = new SoundPlayer("gameOver.wav");
            music.PlayLooping();

            //loading from scores.txt
            string[] lines = File.ReadAllLines("scores.txt");
            scores = Array.ConvertAll(lines, s => int.TryParse(s, out var x) ? x : -1);
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    _moveUp = false;
                    break;
                case Keys.Down:
                    _moveDown = false;
                    break;
                case Keys.Left:
                    _moveLeft = false;
                    break;
                case Keys.Right:
                    _moveRight = false;
                    break;
            }

            if (!(_moveUp || _moveDown || _moveLeft || _moveRight))
            {
                _movementTimer.Stop();
            }
        }


        private void createBullet(int startX)
        {
            PictureBox p = new PictureBox();
            p.ImageLocation = "lasershot.png";
            p.BackColor = Color.Transparent;
            p.Location = new Point(startX + 40, pictureBoxSpaceship.Location.Y );
            p.Size = new Size(60, 50);
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(p);
            bullets.Add(p);
            pew.Play();
            
        }



        private void timer1_Tick(object sender, EventArgs e)
        {


            foreach (PictureBox p in bullets)
            {
                p.Location = new Point(p.Location.X, p.Location.Y - 10);

                //to p.Location.X > pictureBoxUFO.Location.X - 20 einai gia to aristera tou ufo kai to mesaio gia to deksia

                if (p.Location.Y == 20 && p.Location.X < pictureBoxUFO.Location.X + 130 && p.Location.X > pictureBoxUFO.Location.X - 20) {
                    p.Hide();
                    score += 10;
                    labelScore.Text = "SCORE: " + score;
                    pictureBoxUFO.ImageLocation = "UFOdamaged.png";

                }

            }


            for (int i = 0; i < bullets2.Count; i++) {

                bullets2[i].Location = new Point(bullets2[i].Location.X, bullets2[i].Location.Y + 10);

                if ((bullets2[i].Location.Y >= pictureBoxSpaceship.Location.Y + 10) && (bullets2[i].Location.Y < pictureBoxSpaceship.Location.Y +35) && bullets2[i].Location.X < pictureBoxSpaceship.Location.X + 110 && bullets2[i].Location.X > pictureBoxSpaceship.Location.X - 20)
                {
                    hurtSound.Play();
                    bullets2[i].Hide();
                    bullets2.Remove(bullets2[i]); //removing bullet so we don't get hurt by the same bullet as we move for example downwards 
                    pictureBoxSpaceship.ImageLocation = "spaceshipDamaged.png";
                    if (hearts == 3)
                    {
                        pictureBoxHeart3.Hide();
                        hearts -= 1;

                    }
                    else if (hearts == 2)
                    {
                        pictureBoxHeart2.Hide();
                        hearts -= 1;

                    }

                    else if (hearts == 1)   //if spaceship got shot and had only 1 heart left, it's game over
                    {
                        pictureBoxHeart1.Hide();
                        hearts -= 1;

                        isGameOver = true;
                        timer1.Stop();
                        timer2.Stop();
                        timerCountDown.Stop();
                        game_Over.Show();
                        btn_start.Show();
                        gameOver.Play();

  
                        if (score > scores[9])
                        {
                            scores[9] = score;
                            bubbleSort(scores, scores.Length);
                            break;
                        }

                    }

                    break;

                }
            }
        }

        static void bubbleSort(int[] arr,int n)
        {
            if (n == 1)
                return;

            int count = 0;

            for (int i = 0; i < n - 1; i++)
                if (arr[i] < arr[i + 1])
                {
                    (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    count++;
                }

            if (count == 0)
                return;

            bubbleSort(arr, n - 1);
        }


        private void createBullet2(int startX)
        {
            PictureBox p2 = new PictureBox();
            p2.ImageLocation = "lasershot2.png";
            p2.BackColor = Color.Transparent;
            p2.Location = new Point(startX + 58, pictureBoxUFO.Location.Y - 25);
            p2.Size = new Size(60, 50);
            p2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(p2);
            bullets2.Add(p2);
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           pictureBoxUFO.Location = new Point(r.Next(Width - pictureBoxUFO.Width), pictureBoxUFO.Location.Y);
           pictureBoxUFO.ImageLocation = "UFO.png";

           pictureBoxSpaceship.ImageLocation = "spaceship.png";


            createBullet2(pictureBoxUFO.Location.X);

        }



        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            labelCountDown.Text = seconds--.ToString();
            if (seconds < 0)
            {
                isGameOver = true;
                timerCountDown.Stop();
                timer1.Stop();
                timer2.Stop();
                game_Over.Show();
                btn_start.Show();
                gameOver.Play();

                if (score > scores[9])
                {
                    scores[9] = score;
                    bubbleSort(scores, scores.Length);
                }
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {

            isGameOver = false;
            hearts = 3;
            seconds = 60;
            score = 0;
            labelScore.Text = "SCORE: " + score;
            pictureBoxHeart1.Show();
            pictureBoxHeart2.Show();
            pictureBoxHeart3.Show();
            game_Over.Hide();
            pictureBoxSpaceship.Location = new Point(275, 700);

         for (int i = 0; i < bullets2.Count; i++)
         {
                bullets2[i].Hide();
                bullets2[i].Location = new Point(-100, -100);
         }

         for (int i = 0; i < bullets.Count; i++)
         {
             bullets[i].Hide();
             bullets[i].Location = new Point(-100, -100);
             //bullets[i] = null;  trwei exception
         }

            timerCountDown.Start();
            timer1.Start();
            timer2.Start();
            btn_start.Hide();
            music.Stop();


        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.ImageLocation = "startbutton1.png";
        }

        private void btn_start_MouseEnter(object sender, EventArgs e)
        {
            btn_start.ImageLocation = "startbutton2.png";
            btn_start.BackColor = Color.Transparent;
        }

        private void topScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string toDisplay = string.Join(Environment.NewLine, scores);
            MessageBox.Show("SCOREBOARD: " + Environment.NewLine +Environment.NewLine + toDisplay );

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            FileStream fs = File.Open("scores.txt", FileMode.Open, FileAccess.Write) ;
            {
                StreamWriter sw = new StreamWriter(fs);
                for(int i = 0; i < scores.Length; i++) { sw.WriteLine(scores[i]); }
                sw.Close();

            }

        }
    }
}
