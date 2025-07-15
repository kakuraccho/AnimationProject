namespace AnimationProject
{
    partial class GameResult
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
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Point = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_HighScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.label1.Location = new System.Drawing.Point(378, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(701, 107);
            this.label1.TabIndex = 0;
            this.label1.Text = "あなたの得点は";
            // 
            // Label_Point
            // 
            this.Label_Point.AutoSize = true;
            this.Label_Point.Font = new System.Drawing.Font("MS UI Gothic", 50F);
            this.Label_Point.Location = new System.Drawing.Point(1131, 171);
            this.Label_Point.Name = "Label_Point";
            this.Label_Point.Size = new System.Drawing.Size(258, 134);
            this.Label_Point.TabIndex = 1;
            this.Label_Point.Text = "000";
            this.Label_Point.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.label3.Location = new System.Drawing.Point(1400, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 107);
            this.label3.TabIndex = 2;
            this.label3.Text = "点でした";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.label2.Location = new System.Drawing.Point(629, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 107);
            this.label2.TabIndex = 3;
            this.label2.Text = "ハイスコア";
            // 
            // Label_HighScore
            // 
            this.Label_HighScore.AutoSize = true;
            this.Label_HighScore.Font = new System.Drawing.Font("MS UI Gothic", 50F);
            this.Label_HighScore.Location = new System.Drawing.Point(1131, 387);
            this.Label_HighScore.Name = "Label_HighScore";
            this.Label_HighScore.Size = new System.Drawing.Size(258, 134);
            this.Label_HighScore.TabIndex = 4;
            this.Label_HighScore.Text = "000";
            this.Label_HighScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.label5.Location = new System.Drawing.Point(1400, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 107);
            this.label5.TabIndex = 5;
            this.label5.Text = "点";
            // 
            // Button_Remove
            // 
            this.Button_Remove.Font = new System.Drawing.Font("MS UI Gothic", 60F);
            this.Button_Remove.Location = new System.Drawing.Point(681, 660);
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.Size = new System.Drawing.Size(881, 216);
            this.Button_Remove.TabIndex = 7;
            this.Button_Remove.Text = "Remove";
            this.Button_Remove.UseVisualStyleBackColor = true;
            this.Button_Remove.Click += new System.EventHandler(this.Button_Remove_Click);
            // 
            // GameResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2310, 1145);
            this.Controls.Add(this.Button_Remove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Label_HighScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label_Point);
            this.Controls.Add(this.label1);
            this.Name = "GameResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GameResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Point;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_HighScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button_Remove;
    }
}