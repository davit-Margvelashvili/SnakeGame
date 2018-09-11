namespace SnakeGame
{
    partial class MainForm
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
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.downButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gameStatsTitleLabel = new System.Windows.Forms.Label();
            this.scoreTitleLabel = new System.Windows.Forms.Label();
            this.scoreValueLabel = new System.Windows.Forms.Label();
            this.playerNameTitleLabel = new System.Windows.Forms.Label();
            this.playerNameValueLabel = new System.Windows.Forms.Label();
            this.gameStatusTitleLabel = new System.Windows.Forms.Label();
            this.gameStatusValueLabel = new System.Windows.Forms.Label();
            this.gameInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.gameInfoGroupBox.SuspendLayout();
            this.controlsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingPanel.Location = new System.Drawing.Point(12, 12);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(561, 474);
            this.DrawingPanel.TabIndex = 0;
            // 
            // downButton
            // 
            this.downButton.Image = global::SnakeGame.Properties.Resources.downArrow_;
            this.downButton.Location = new System.Drawing.Point(87, 182);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(37, 37);
            this.downButton.TabIndex = 1;
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Image = global::SnakeGame.Properties.Resources.rightArrow;
            this.rightButton.Location = new System.Drawing.Point(126, 143);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(37, 37);
            this.rightButton.TabIndex = 1;
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Image = global::SnakeGame.Properties.Resources.leftArrow;
            this.leftButton.Location = new System.Drawing.Point(48, 143);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(37, 37);
            this.leftButton.TabIndex = 1;
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // upButton
            // 
            this.upButton.Image = global::SnakeGame.Properties.Resources.upArrow;
            this.upButton.Location = new System.Drawing.Point(87, 105);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(37, 37);
            this.upButton.TabIndex = 1;
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 579);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // gameStatsTitleLabel
            // 
            this.gameStatsTitleLabel.AutoSize = true;
            this.gameStatsTitleLabel.Font = new System.Drawing.Font("Monotype Corsiva", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStatsTitleLabel.ForeColor = System.Drawing.Color.Navy;
            this.gameStatsTitleLabel.Location = new System.Drawing.Point(6, 16);
            this.gameStatsTitleLabel.Name = "gameStatsTitleLabel";
            this.gameStatsTitleLabel.Size = new System.Drawing.Size(195, 52);
            this.gameStatsTitleLabel.TabIndex = 3;
            this.gameStatsTitleLabel.Text = "Game Info";
            // 
            // scoreTitleLabel
            // 
            this.scoreTitleLabel.AutoSize = true;
            this.scoreTitleLabel.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.scoreTitleLabel.Location = new System.Drawing.Point(15, 131);
            this.scoreTitleLabel.Name = "scoreTitleLabel";
            this.scoreTitleLabel.Size = new System.Drawing.Size(55, 19);
            this.scoreTitleLabel.TabIndex = 3;
            this.scoreTitleLabel.Text = "Score  :";
            // 
            // scoreValueLabel
            // 
            this.scoreValueLabel.AutoSize = true;
            this.scoreValueLabel.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreValueLabel.ForeColor = System.Drawing.Color.Black;
            this.scoreValueLabel.Location = new System.Drawing.Point(70, 131);
            this.scoreValueLabel.Name = "scoreValueLabel";
            this.scoreValueLabel.Size = new System.Drawing.Size(17, 19);
            this.scoreValueLabel.TabIndex = 3;
            this.scoreValueLabel.Text = "0";
            // 
            // playerNameTitleLabel
            // 
            this.playerNameTitleLabel.AutoSize = true;
            this.playerNameTitleLabel.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.playerNameTitleLabel.Location = new System.Drawing.Point(15, 102);
            this.playerNameTitleLabel.Name = "playerNameTitleLabel";
            this.playerNameTitleLabel.Size = new System.Drawing.Size(56, 19);
            this.playerNameTitleLabel.TabIndex = 3;
            this.playerNameTitleLabel.Text = "Player :";
            // 
            // playerNameValueLabel
            // 
            this.playerNameValueLabel.AutoSize = true;
            this.playerNameValueLabel.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameValueLabel.ForeColor = System.Drawing.Color.Black;
            this.playerNameValueLabel.Location = new System.Drawing.Point(70, 102);
            this.playerNameValueLabel.Name = "playerNameValueLabel";
            this.playerNameValueLabel.Size = new System.Drawing.Size(97, 19);
            this.playerNameValueLabel.TabIndex = 3;
            this.playerNameValueLabel.Text = "Default Player";
            // 
            // gameStatusTitleLabel
            // 
            this.gameStatusTitleLabel.AutoSize = true;
            this.gameStatusTitleLabel.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStatusTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.gameStatusTitleLabel.Location = new System.Drawing.Point(16, 159);
            this.gameStatusTitleLabel.Name = "gameStatusTitleLabel";
            this.gameStatusTitleLabel.Size = new System.Drawing.Size(58, 19);
            this.gameStatusTitleLabel.TabIndex = 3;
            this.gameStatusTitleLabel.Text = "Status  :";
            // 
            // gameStatusValueLabel
            // 
            this.gameStatusValueLabel.AutoSize = true;
            this.gameStatusValueLabel.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStatusValueLabel.ForeColor = System.Drawing.Color.Black;
            this.gameStatusValueLabel.Location = new System.Drawing.Point(71, 159);
            this.gameStatusValueLabel.Name = "gameStatusValueLabel";
            this.gameStatusValueLabel.Size = new System.Drawing.Size(83, 19);
            this.gameStatusValueLabel.TabIndex = 3;
            this.gameStatusValueLabel.Text = "Uninitialized";
            // 
            // gameInfoGroupBox
            // 
            this.gameInfoGroupBox.Controls.Add(this.gameStatusValueLabel);
            this.gameInfoGroupBox.Controls.Add(this.playerNameValueLabel);
            this.gameInfoGroupBox.Controls.Add(this.gameStatsTitleLabel);
            this.gameInfoGroupBox.Controls.Add(this.scoreTitleLabel);
            this.gameInfoGroupBox.Controls.Add(this.scoreValueLabel);
            this.gameInfoGroupBox.Controls.Add(this.gameStatusTitleLabel);
            this.gameInfoGroupBox.Controls.Add(this.playerNameTitleLabel);
            this.gameInfoGroupBox.Location = new System.Drawing.Point(579, 12);
            this.gameInfoGroupBox.Name = "gameInfoGroupBox";
            this.gameInfoGroupBox.Size = new System.Drawing.Size(209, 204);
            this.gameInfoGroupBox.TabIndex = 4;
            this.gameInfoGroupBox.TabStop = false;
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.stopButton);
            this.controlsGroupBox.Controls.Add(this.pauseButton);
            this.controlsGroupBox.Controls.Add(this.startButton);
            this.controlsGroupBox.Controls.Add(this.upButton);
            this.controlsGroupBox.Controls.Add(this.downButton);
            this.controlsGroupBox.Controls.Add(this.leftButton);
            this.controlsGroupBox.Controls.Add(this.rightButton);
            this.controlsGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.controlsGroupBox.Location = new System.Drawing.Point(579, 251);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(200, 235);
            this.controlsGroupBox.TabIndex = 5;
            this.controlsGroupBox.TabStop = false;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(139, 19);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(55, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(78, 19);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(55, 23);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(17, 19);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(55, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.controlsGroupBox);
            this.Controls.Add(this.gameInfoGroupBox);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.DrawingPanel);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.gameInfoGroupBox.ResumeLayout(false);
            this.gameInfoGroupBox.PerformLayout();
            this.controlsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label gameStatsTitleLabel;
        private System.Windows.Forms.Label scoreTitleLabel;
        private System.Windows.Forms.Label scoreValueLabel;
        private System.Windows.Forms.Label playerNameTitleLabel;
        private System.Windows.Forms.Label playerNameValueLabel;
        private System.Windows.Forms.Label gameStatusTitleLabel;
        private System.Windows.Forms.Label gameStatusValueLabel;
        private System.Windows.Forms.GroupBox gameInfoGroupBox;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
    }
}

