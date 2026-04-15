using System.Drawing;
using System.Windows.Forms;

namespace Super_Tic_Toe
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.titleLabel = new Label();
            this.playerScoreLabel = new Label();
            this.cpuScoreLabel = new Label();
            this.button1 = new Button();
            this.button2 = new Button();
            this.button3 = new Button();
            this.button4 = new Button();
            this.button5 = new Button();
            this.button6 = new Button();
            this.button7 = new Button();
            this.button8 = new Button();
            this.button9 = new Button();
            this.restartButton = new Button();
            CPU_Timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(0, 188, 242);
            titleLabel.Location = new Point(100, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(300, 50);
            titleLabel.Text = "Tic Tac Toe";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerScoreLabel
            // 
            playerScoreLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            playerScoreLabel.ForeColor = Color.FromArgb(0, 188, 242);
            playerScoreLabel.Location = new Point(30, 70);
            playerScoreLabel.Name = "playerScoreLabel";
            playerScoreLabel.Size = new Size(150, 30);
            playerScoreLabel.Text = "Player: 0";
            playerScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cpuScoreLabel
            // 
            cpuScoreLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            cpuScoreLabel.ForeColor = Color.FromArgb(255, 111, 0);
            cpuScoreLabel.Location = new Point(300, 70);
            cpuScoreLabel.Name = "cpuScoreLabel";
            cpuScoreLabel.Size = new Size(150, 30);
            cpuScoreLabel.Text = "CPU: 0";
            cpuScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            ConfigureGameButton(button1, 75, 110);
            // 
            // button2
            // 
            ConfigureGameButton(button2, 75, 216);
            // 
            // button3
            // 
            ConfigureGameButton(button3, 75, 322);
            // 
            // button4
            // 
            ConfigureGameButton(button4, 181, 110);
            // 
            // button5
            // 
            ConfigureGameButton(button5, 181, 216);
            // 
            // button6
            // 
            ConfigureGameButton(button6, 181, 322);
            // 
            // button7
            // 
            ConfigureGameButton(button7, 287, 110);
            // 
            // button8
            // 
            ConfigureGameButton(button8, 287, 216);
            // 
            // button9
            // 
            ConfigureGameButton(button9, 287, 322);
            // 
            // restartButton
            // 
            restartButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            restartButton.Location = new Point(165, 450);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(150, 50);
            restartButton.Text = "RESTART";
            restartButton.FlatStyle = FlatStyle.Flat;
            restartButton.BackColor = Color.FromArgb(0, 200, 120);
            restartButton.ForeColor = Color.White;
            restartButton.FlatAppearance.BorderSize = 0;
            restartButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 200, 120);
            restartButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 200, 120);
            restartButton.Click += Restart_Game;
            // 
            // CPU_Timer
            // 
            CPU_Timer.Interval = 800;
            CPU_Timer.Tick += CPU_move;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 35);
            ClientSize = new Size(484, 520);
            Controls.Add(restartButton);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cpuScoreLabel);
            Controls.Add(playerScoreLabel);
            Controls.Add(titleLabel);
            MaximumSize = new Size(500, 550);
            MinimumSize = new Size(500, 550);
            Name = "Form1";
            Padding = new Padding(10);
            Text = "Tic Tac Toe";
            ResumeLayout(false);
        }

        private void ConfigureGameButton(Button button, int x, int y)
        {
            button.Location = new Point(x, y);
            button.Name = "gameButton";
            button.Size = new Size(100, 100);
            button.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            button.Text = "";
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.FromArgb(50, 50, 60);
            button.ForeColor = Color.White;
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 60);
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 60);
            button.UseVisualStyleBackColor = false;
            button.Click += Player_Click_Button;
        }

        #endregion

        private Label titleLabel;
        private Label playerScoreLabel;
        private Label cpuScoreLabel;

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;

        private Button restartButton;
        private System.Windows.Forms.Timer CPU_Timer;
    }
}