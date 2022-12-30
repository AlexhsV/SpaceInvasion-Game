namespace Space_Invasion
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxUFO = new System.Windows.Forms.PictureBox();
            this.pictureBoxSpaceship = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.pictureBoxHeart3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeart2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeart1 = new System.Windows.Forms.PictureBox();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.labelCountDown = new System.Windows.Forms.Label();
            this.labelCountDownTitle = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.PictureBox();
            this.game_Over = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.topScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpaceship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxUFO
            // 
            this.pictureBoxUFO.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUFO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxUFO.Image = global::Space_Invasion.Properties.Resources.UFO;
            this.pictureBoxUFO.Location = new System.Drawing.Point(328, 12);
            this.pictureBoxUFO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxUFO.Name = "pictureBoxUFO";
            this.pictureBoxUFO.Size = new System.Drawing.Size(219, 98);
            this.pictureBoxUFO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUFO.TabIndex = 1;
            this.pictureBoxUFO.TabStop = false;
            // 
            // pictureBoxSpaceship
            // 
            this.pictureBoxSpaceship.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSpaceship.Image = global::Space_Invasion.Properties.Resources.spaceship;
            this.pictureBoxSpaceship.Location = new System.Drawing.Point(365, 701);
            this.pictureBoxSpaceship.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSpaceship.Name = "pictureBoxSpaceship";
            this.pictureBoxSpaceship.Size = new System.Drawing.Size(181, 156);
            this.pictureBoxSpaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSpaceship.TabIndex = 0;
            this.pictureBoxSpaceship.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Summer Pixel 22", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(703, 37);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(143, 33);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "SCORE: 0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxHeart3
            // 
            this.pictureBoxHeart3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeart3.Image = global::Space_Invasion.Properties.Resources.heart;
            this.pictureBoxHeart3.Location = new System.Drawing.Point(813, 796);
            this.pictureBoxHeart3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxHeart3.Name = "pictureBoxHeart3";
            this.pictureBoxHeart3.Size = new System.Drawing.Size(56, 46);
            this.pictureBoxHeart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeart3.TabIndex = 3;
            this.pictureBoxHeart3.TabStop = false;
            // 
            // pictureBoxHeart2
            // 
            this.pictureBoxHeart2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeart2.Image = global::Space_Invasion.Properties.Resources.heart;
            this.pictureBoxHeart2.Location = new System.Drawing.Point(751, 796);
            this.pictureBoxHeart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxHeart2.Name = "pictureBoxHeart2";
            this.pictureBoxHeart2.Size = new System.Drawing.Size(57, 46);
            this.pictureBoxHeart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeart2.TabIndex = 4;
            this.pictureBoxHeart2.TabStop = false;
            // 
            // pictureBoxHeart1
            // 
            this.pictureBoxHeart1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeart1.Image = global::Space_Invasion.Properties.Resources.heart;
            this.pictureBoxHeart1.Location = new System.Drawing.Point(688, 796);
            this.pictureBoxHeart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxHeart1.Name = "pictureBoxHeart1";
            this.pictureBoxHeart1.Size = new System.Drawing.Size(57, 46);
            this.pictureBoxHeart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeart1.TabIndex = 5;
            this.pictureBoxHeart1.TabStop = false;
            // 
            // timerCountDown
            // 
            this.timerCountDown.Interval = 1000;
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // labelCountDown
            // 
            this.labelCountDown.AutoSize = true;
            this.labelCountDown.BackColor = System.Drawing.Color.Transparent;
            this.labelCountDown.Font = new System.Drawing.Font("Summer Pixel 22", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountDown.ForeColor = System.Drawing.Color.White;
            this.labelCountDown.Location = new System.Drawing.Point(85, 36);
            this.labelCountDown.Name = "labelCountDown";
            this.labelCountDown.Size = new System.Drawing.Size(47, 33);
            this.labelCountDown.TabIndex = 7;
            this.labelCountDown.Text = "60";
            // 
            // labelCountDownTitle
            // 
            this.labelCountDownTitle.AutoSize = true;
            this.labelCountDownTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelCountDownTitle.Font = new System.Drawing.Font("Summer Pixel 22", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountDownTitle.ForeColor = System.Drawing.Color.White;
            this.labelCountDownTitle.Location = new System.Drawing.Point(4, 37);
            this.labelCountDownTitle.Name = "labelCountDownTitle";
            this.labelCountDownTitle.Size = new System.Drawing.Size(95, 33);
            this.labelCountDownTitle.TabIndex = 8;
            this.labelCountDownTitle.Text = "Time:";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.Image = global::Space_Invasion.Properties.Resources.startButton1;
            this.btn_start.Location = new System.Drawing.Point(235, 378);
            this.btn_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(419, 187);
            this.btn_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_start.TabIndex = 9;
            this.btn_start.TabStop = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            this.btn_start.MouseEnter += new System.EventHandler(this.btn_start_MouseEnter);
            this.btn_start.MouseLeave += new System.EventHandler(this.btn_start_MouseLeave);
            // 
            // game_Over
            // 
            this.game_Over.AutoSize = true;
            this.game_Over.BackColor = System.Drawing.Color.Transparent;
            this.game_Over.Font = new System.Drawing.Font("Summer Pixel 22", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_Over.ForeColor = System.Drawing.Color.White;
            this.game_Over.Location = new System.Drawing.Point(121, 299);
            this.game_Over.Name = "game_Over";
            this.game_Over.Size = new System.Drawing.Size(655, 120);
            this.game_Over.TabIndex = 11;
            this.game_Over.Text = "GAME - OVER";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 30);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.topScoresToolStripMenuItem,
            this.toolStripSeparator2});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.gameToolStripMenuItem.Text = "View";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // topScoresToolStripMenuItem
            // 
            this.topScoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.topScoresToolStripMenuItem.Name = "topScoresToolStripMenuItem";
            this.topScoresToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.topScoresToolStripMenuItem.Text = "Top-Scores";
            this.topScoresToolStripMenuItem.Click += new System.EventHandler(this.topScoresToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Space_Invasion.Properties.Resources.space;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 1055);
            this.Controls.Add(this.labelCountDown);
            this.Controls.Add(this.labelCountDownTitle);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.game_Over);
            this.Controls.Add(this.pictureBoxHeart1);
            this.Controls.Add(this.pictureBoxHeart2);
            this.Controls.Add(this.pictureBoxHeart3);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.pictureBoxSpaceship);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBoxUFO);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpaceship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSpaceship;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxUFO;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox pictureBoxHeart3;
        private System.Windows.Forms.PictureBox pictureBoxHeart2;
        private System.Windows.Forms.PictureBox pictureBoxHeart1;
        private System.Windows.Forms.Timer timerCountDown;
        private System.Windows.Forms.Label labelCountDown;
        private System.Windows.Forms.Label labelCountDownTitle;
        private System.Windows.Forms.PictureBox btn_start;
        private System.Windows.Forms.Label game_Over;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

