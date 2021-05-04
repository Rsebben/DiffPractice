
namespace DiffPractice
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
            this.heroName = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.playerNameInput = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.diffText = new System.Windows.Forms.Label();
            this.welcomeText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // heroName
            // 
            this.heroName.AutoSize = true;
            this.heroName.BackColor = System.Drawing.Color.Black;
            this.heroName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroName.ForeColor = System.Drawing.Color.White;
            this.heroName.Location = new System.Drawing.Point(12, 9);
            this.heroName.Name = "heroName";
            this.heroName.Size = new System.Drawing.Size(228, 24);
            this.heroName.TabIndex = 0;
            this.heroName.Text = "Enter Hero Name Here:";
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.Color.Black;
            this.easyButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.easyButton.FlatAppearance.BorderSize = 2;
            this.easyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.easyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.ForeColor = System.Drawing.Color.White;
            this.easyButton.Location = new System.Drawing.Point(75, 180);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(140, 54);
            this.easyButton.TabIndex = 1;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.BackColor = System.Drawing.Color.Black;
            this.mediumButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mediumButton.FlatAppearance.BorderSize = 2;
            this.mediumButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mediumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.ForeColor = System.Drawing.Color.White;
            this.mediumButton.Location = new System.Drawing.Point(345, 180);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(128, 54);
            this.mediumButton.TabIndex = 2;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = false;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hardButton.FlatAppearance.BorderSize = 2;
            this.hardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.hardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.ForeColor = System.Drawing.Color.White;
            this.hardButton.Location = new System.Drawing.Point(596, 180);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(133, 54);
            this.hardButton.TabIndex = 3;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // playerNameInput
            // 
            this.playerNameInput.Location = new System.Drawing.Point(273, 11);
            this.playerNameInput.Name = "playerNameInput";
            this.playerNameInput.Size = new System.Drawing.Size(362, 22);
            this.playerNameInput.TabIndex = 4;
            // 
            // startButton
            // 
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startButton.FlatAppearance.BorderSize = 2;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(354, 292);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(102, 49);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Begin!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // diffText
            // 
            this.diffText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diffText.ForeColor = System.Drawing.Color.White;
            this.diffText.Location = new System.Drawing.Point(269, 102);
            this.diffText.Name = "diffText";
            this.diffText.Size = new System.Drawing.Size(284, 23);
            this.diffText.TabIndex = 6;
            this.diffText.Text = "Select Your Difficult Level:";
            // 
            // welcomeText
            // 
            this.welcomeText.ForeColor = System.Drawing.Color.White;
            this.welcomeText.Location = new System.Drawing.Point(324, 371);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(149, 23);
            this.welcomeText.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(658, 31);
            this.label2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.diffText);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.playerNameInput);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.heroName);
            this.Name = "Form1";
            this.Text = "Hero Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heroName;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.TextBox playerNameInput;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label diffText;
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

