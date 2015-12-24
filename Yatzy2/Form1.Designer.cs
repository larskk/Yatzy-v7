namespace Yatzy
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.terning0 = new System.Windows.Forms.Button();
            this.terning1 = new System.Windows.Forms.Button();
            this.terning2 = new System.Windows.Forms.Button();
            this.terning3 = new System.Windows.Forms.Button();
            this.terning4 = new System.Windows.Forms.Button();
            this.rollButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.currentPlayer = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.terning0);
            this.flowLayoutPanel1.Controls.Add(this.terning1);
            this.flowLayoutPanel1.Controls.Add(this.terning2);
            this.flowLayoutPanel1.Controls.Add(this.terning3);
            this.flowLayoutPanel1.Controls.Add(this.terning4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(230, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(234, 48);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // terning0
            // 
            this.terning0.ForeColor = System.Drawing.Color.Black;
            this.terning0.Location = new System.Drawing.Point(3, 3);
            this.terning0.Name = "terning0";
            this.terning0.Size = new System.Drawing.Size(40, 40);
            this.terning0.TabIndex = 0;
            this.terning0.Text = "Y";
            this.terning0.UseVisualStyleBackColor = true;
            this.terning0.Click += new System.EventHandler(this.dice_Click);
            // 
            // terning1
            // 
            this.terning1.Location = new System.Drawing.Point(49, 3);
            this.terning1.Name = "terning1";
            this.terning1.Size = new System.Drawing.Size(40, 40);
            this.terning1.TabIndex = 1;
            this.terning1.Text = "A";
            this.terning1.UseVisualStyleBackColor = true;
            this.terning1.Click += new System.EventHandler(this.dice_Click);
            // 
            // terning2
            // 
            this.terning2.ForeColor = System.Drawing.Color.Black;
            this.terning2.Location = new System.Drawing.Point(95, 3);
            this.terning2.Name = "terning2";
            this.terning2.Size = new System.Drawing.Size(40, 40);
            this.terning2.TabIndex = 2;
            this.terning2.Text = "T";
            this.terning2.UseVisualStyleBackColor = true;
            this.terning2.Click += new System.EventHandler(this.dice_Click);
            // 
            // terning3
            // 
            this.terning3.Location = new System.Drawing.Point(141, 3);
            this.terning3.Name = "terning3";
            this.terning3.Size = new System.Drawing.Size(40, 40);
            this.terning3.TabIndex = 3;
            this.terning3.Text = "Z";
            this.terning3.UseVisualStyleBackColor = true;
            this.terning3.Click += new System.EventHandler(this.dice_Click);
            // 
            // terning4
            // 
            this.terning4.Location = new System.Drawing.Point(187, 3);
            this.terning4.Name = "terning4";
            this.terning4.Size = new System.Drawing.Size(40, 40);
            this.terning4.TabIndex = 4;
            this.terning4.Text = "Y";
            this.terning4.UseVisualStyleBackColor = true;
            this.terning4.Click += new System.EventHandler(this.dice_Click);
            // 
            // rollButton
            // 
            this.rollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.Location = new System.Drawing.Point(275, 81);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(157, 31);
            this.rollButton.TabIndex = 1;
            this.rollButton.Text = "Kast terninger";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(0, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.AutoSize = true;
            this.currentPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPlayerLabel.Location = new System.Drawing.Point(23, 69);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(109, 16);
            this.currentPlayerLabel.TabIndex = 4;
            this.currentPlayerLabel.Text = "Current player:";
            // 
            // currentPlayer
            // 
            this.currentPlayer.AutoSize = true;
            this.currentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPlayer.Location = new System.Drawing.Point(23, 91);
            this.currentPlayer.Name = "currentPlayer";
            this.currentPlayer.Size = new System.Drawing.Size(45, 16);
            this.currentPlayer.TabIndex = 5;
            this.currentPlayer.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 283);
            this.Controls.Add(this.currentPlayer);
            this.Controls.Add(this.currentPlayerLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button terning0;
        private System.Windows.Forms.Button terning1;
        private System.Windows.Forms.Button terning2;
        private System.Windows.Forms.Button terning3;
        private System.Windows.Forms.Button terning4;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label currentPlayerLabel;
        private System.Windows.Forms.Label currentPlayer;
    }
}

