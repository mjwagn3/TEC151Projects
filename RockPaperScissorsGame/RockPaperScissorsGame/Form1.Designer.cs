namespace RockPaperScissorsGame
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
            this.scissorsPictureBox = new System.Windows.Forms.PictureBox();
            this.paperPictureBox = new System.Windows.Forms.PictureBox();
            this.rockPictureBox = new System.Windows.Forms.PictureBox();
            this.selectPromptLabel = new System.Windows.Forms.Label();
            this.rockPromptLabel = new System.Windows.Forms.Label();
            this.paperPromptLabel = new System.Windows.Forms.Label();
            this.scissorsPromptLabel = new System.Windows.Forms.Label();
            this.shootButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // scissorsPictureBox
            // 
            this.scissorsPictureBox.Image = global::RockPaperScissorsGame.Properties.Resources.scissors__1_;
            this.scissorsPictureBox.Location = new System.Drawing.Point(342, 67);
            this.scissorsPictureBox.Name = "scissorsPictureBox";
            this.scissorsPictureBox.Size = new System.Drawing.Size(159, 200);
            this.scissorsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scissorsPictureBox.TabIndex = 2;
            this.scissorsPictureBox.TabStop = false;
            this.scissorsPictureBox.Click += new System.EventHandler(this.scissorsPictureBox_Click);
            // 
            // paperPictureBox
            // 
            this.paperPictureBox.Image = global::RockPaperScissorsGame.Properties.Resources.paper__1_;
            this.paperPictureBox.Location = new System.Drawing.Point(177, 67);
            this.paperPictureBox.Name = "paperPictureBox";
            this.paperPictureBox.Size = new System.Drawing.Size(159, 200);
            this.paperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paperPictureBox.TabIndex = 1;
            this.paperPictureBox.TabStop = false;
            this.paperPictureBox.Click += new System.EventHandler(this.paperPictureBox_Click);
            // 
            // rockPictureBox
            // 
            this.rockPictureBox.Image = global::RockPaperScissorsGame.Properties.Resources.theRock;
            this.rockPictureBox.Location = new System.Drawing.Point(12, 67);
            this.rockPictureBox.Name = "rockPictureBox";
            this.rockPictureBox.Size = new System.Drawing.Size(159, 200);
            this.rockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rockPictureBox.TabIndex = 0;
            this.rockPictureBox.TabStop = false;
            this.rockPictureBox.Click += new System.EventHandler(this.rockPictureBox_Click);
            // 
            // selectPromptLabel
            // 
            this.selectPromptLabel.AutoSize = true;
            this.selectPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPromptLabel.Location = new System.Drawing.Point(12, 9);
            this.selectPromptLabel.Name = "selectPromptLabel";
            this.selectPromptLabel.Size = new System.Drawing.Size(102, 20);
            this.selectPromptLabel.TabIndex = 3;
            this.selectPromptLabel.Text = "Click on One:";
            // 
            // rockPromptLabel
            // 
            this.rockPromptLabel.AutoSize = true;
            this.rockPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockPromptLabel.Location = new System.Drawing.Point(8, 44);
            this.rockPromptLabel.Name = "rockPromptLabel";
            this.rockPromptLabel.Size = new System.Drawing.Size(50, 20);
            this.rockPromptLabel.TabIndex = 4;
            this.rockPromptLabel.Text = "Rock:";
            // 
            // paperPromptLabel
            // 
            this.paperPromptLabel.AutoSize = true;
            this.paperPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paperPromptLabel.Location = new System.Drawing.Point(173, 44);
            this.paperPromptLabel.Name = "paperPromptLabel";
            this.paperPromptLabel.Size = new System.Drawing.Size(55, 20);
            this.paperPromptLabel.TabIndex = 5;
            this.paperPromptLabel.Text = "Paper:";
            // 
            // scissorsPromptLabel
            // 
            this.scissorsPromptLabel.AutoSize = true;
            this.scissorsPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissorsPromptLabel.Location = new System.Drawing.Point(338, 44);
            this.scissorsPromptLabel.Name = "scissorsPromptLabel";
            this.scissorsPromptLabel.Size = new System.Drawing.Size(73, 20);
            this.scissorsPromptLabel.TabIndex = 6;
            this.scissorsPromptLabel.Text = "Scissors:";
            // 
            // shootButton
            // 
            this.shootButton.Location = new System.Drawing.Point(531, 146);
            this.shootButton.Name = "shootButton";
            this.shootButton.Size = new System.Drawing.Size(75, 23);
            this.shootButton.TabIndex = 7;
            this.shootButton.Text = "Shoot!";
            this.shootButton.UseVisualStyleBackColor = true;
            this.shootButton.Click += new System.EventHandler(this.shootButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Programmed By Michael Wagner";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shootButton);
            this.Controls.Add(this.scissorsPromptLabel);
            this.Controls.Add(this.paperPromptLabel);
            this.Controls.Add(this.rockPromptLabel);
            this.Controls.Add(this.selectPromptLabel);
            this.Controls.Add(this.scissorsPictureBox);
            this.Controls.Add(this.paperPictureBox);
            this.Controls.Add(this.rockPictureBox);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scissorsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rockPictureBox;
        private System.Windows.Forms.PictureBox paperPictureBox;
        private System.Windows.Forms.PictureBox scissorsPictureBox;
        private System.Windows.Forms.Label selectPromptLabel;
        private System.Windows.Forms.Label rockPromptLabel;
        private System.Windows.Forms.Label paperPromptLabel;
        private System.Windows.Forms.Label scissorsPromptLabel;
        private System.Windows.Forms.Button shootButton;
        private System.Windows.Forms.Label label1;
    }
}

