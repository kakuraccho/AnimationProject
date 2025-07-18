namespace AnimationProject
{
    partial class Config
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Cansel = new System.Windows.Forms.Button();
            this.TrackBar_Ball = new System.Windows.Forms.TrackBar();
            this.TrackBar_Bar = new System.Windows.Forms.TrackBar();
            this.TrackBar_SE = new System.Windows.Forms.TrackBar();
            this.Label_BallValue = new System.Windows.Forms.Label();
            this.Label_BarValue = new System.Windows.Forms.Label();
            this.Label_SEValue = new System.Windows.Forms.Label();
            this.Label_SvCol = new System.Windows.Forms.Label();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Button_RChange = new System.Windows.Forms.Button();
            this.Button_LChange = new System.Windows.Forms.Button();
            this.Label_RightKey = new System.Windows.Forms.Label();
            this.Label_LeftKey = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_SE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 60F);
            this.label1.Location = new System.Drawing.Point(910, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 161);
            this.label1.TabIndex = 1;
            this.label1.Text = "Config";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label2.Location = new System.Drawing.Point(176, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 67);
            this.label2.TabIndex = 2;
            this.label2.Text = "ボールの移動速度";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label3.Location = new System.Drawing.Point(125, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(569, 67);
            this.label3.TabIndex = 3;
            this.label3.Text = "プレイヤーバーの長さ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label4.Location = new System.Drawing.Point(1388, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 67);
            this.label4.TabIndex = 4;
            this.label4.Text = "SE音量";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label6.Location = new System.Drawing.Point(352, 590);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(342, 67);
            this.label6.TabIndex = 6;
            this.label6.Text = "キーバインド";
            // 
            // Button_Save
            // 
            this.Button_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_Save.BackColor = System.Drawing.SystemColors.Info;
            this.Button_Save.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.Button_Save.Location = new System.Drawing.Point(351, 922);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(460, 149);
            this.Button_Save.TabIndex = 7;
            this.Button_Save.Text = "設定保存";
            this.Button_Save.UseVisualStyleBackColor = false;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_Cansel
            // 
            this.Button_Cansel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_Cansel.BackColor = System.Drawing.SystemColors.Window;
            this.Button_Cansel.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.Button_Cansel.Location = new System.Drawing.Point(1617, 922);
            this.Button_Cansel.Name = "Button_Cansel";
            this.Button_Cansel.Size = new System.Drawing.Size(397, 149);
            this.Button_Cansel.TabIndex = 8;
            this.Button_Cansel.Text = "キャンセル";
            this.Button_Cansel.UseVisualStyleBackColor = false;
            this.Button_Cansel.Click += new System.EventHandler(this.Button_Cansel_Click);
            // 
            // TrackBar_Ball
            // 
            this.TrackBar_Ball.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TrackBar_Ball.LargeChange = 1;
            this.TrackBar_Ball.Location = new System.Drawing.Point(817, 278);
            this.TrackBar_Ball.Maximum = 9;
            this.TrackBar_Ball.Minimum = 1;
            this.TrackBar_Ball.Name = "TrackBar_Ball";
            this.TrackBar_Ball.Size = new System.Drawing.Size(418, 90);
            this.TrackBar_Ball.TabIndex = 10;
            this.TrackBar_Ball.Value = 5;
            this.TrackBar_Ball.ValueChanged += new System.EventHandler(this.TrackBar_Move_ValueChanged);
            // 
            // TrackBar_Bar
            // 
            this.TrackBar_Bar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TrackBar_Bar.LargeChange = 1;
            this.TrackBar_Bar.Location = new System.Drawing.Point(817, 433);
            this.TrackBar_Bar.Maximum = 15;
            this.TrackBar_Bar.Minimum = 1;
            this.TrackBar_Bar.Name = "TrackBar_Bar";
            this.TrackBar_Bar.Size = new System.Drawing.Size(418, 90);
            this.TrackBar_Bar.TabIndex = 11;
            this.TrackBar_Bar.Value = 1;
            this.TrackBar_Bar.ValueChanged += new System.EventHandler(this.TrackBar_Bar_ValueChanged);
            // 
            // TrackBar_SE
            // 
            this.TrackBar_SE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TrackBar_SE.LargeChange = 1;
            this.TrackBar_SE.Location = new System.Drawing.Point(1757, 278);
            this.TrackBar_SE.Name = "TrackBar_SE";
            this.TrackBar_SE.Size = new System.Drawing.Size(418, 90);
            this.TrackBar_SE.TabIndex = 12;
            this.TrackBar_SE.Value = 5;
            this.TrackBar_SE.ValueChanged += new System.EventHandler(this.TrackBar_SE_ValueChanged);
            // 
            // Label_BallValue
            // 
            this.Label_BallValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_BallValue.AutoSize = true;
            this.Label_BallValue.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.Label_BallValue.Location = new System.Drawing.Point(748, 287);
            this.Label_BallValue.Name = "Label_BallValue";
            this.Label_BallValue.Size = new System.Drawing.Size(63, 67);
            this.Label_BallValue.TabIndex = 13;
            this.Label_BallValue.Text = "5";
            // 
            // Label_BarValue
            // 
            this.Label_BarValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_BarValue.AutoSize = true;
            this.Label_BarValue.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.Label_BarValue.Location = new System.Drawing.Point(748, 443);
            this.Label_BarValue.Name = "Label_BarValue";
            this.Label_BarValue.Size = new System.Drawing.Size(63, 67);
            this.Label_BarValue.TabIndex = 14;
            this.Label_BarValue.Text = "1";
            // 
            // Label_SEValue
            // 
            this.Label_SEValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_SEValue.AutoSize = true;
            this.Label_SEValue.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.Label_SEValue.Location = new System.Drawing.Point(1688, 287);
            this.Label_SEValue.Name = "Label_SEValue";
            this.Label_SEValue.Size = new System.Drawing.Size(63, 67);
            this.Label_SEValue.TabIndex = 15;
            this.Label_SEValue.Text = "5";
            // 
            // Label_SvCol
            // 
            this.Label_SvCol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_SvCol.AutoSize = true;
            this.Label_SvCol.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.Label_SvCol.Location = new System.Drawing.Point(940, 819);
            this.Label_SvCol.Name = "Label_SvCol";
            this.Label_SvCol.Size = new System.Drawing.Size(569, 67);
            this.Label_SvCol.TabIndex = 16;
            this.Label_SvCol.Text = "正しく保存されました";
            this.Label_SvCol.Visible = false;
            // 
            // Button_Reset
            // 
            this.Button_Reset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_Reset.BackColor = System.Drawing.SystemColors.Window;
            this.Button_Reset.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.Button_Reset.Location = new System.Drawing.Point(1005, 922);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(397, 149);
            this.Button_Reset.TabIndex = 17;
            this.Button_Reset.Text = "リセット";
            this.Button_Reset.UseVisualStyleBackColor = false;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label5.Location = new System.Drawing.Point(751, 602);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 54);
            this.label5.TabIndex = 18;
            this.label5.Text = "左移動";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label7.Location = new System.Drawing.Point(1262, 602);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 54);
            this.label7.TabIndex = 19;
            this.label7.Text = "右移動";
            // 
            // Button_RChange
            // 
            this.Button_RChange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_RChange.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.Button_RChange.Location = new System.Drawing.Point(1041, 603);
            this.Button_RChange.Name = "Button_RChange";
            this.Button_RChange.Size = new System.Drawing.Size(135, 54);
            this.Button_RChange.TabIndex = 20;
            this.Button_RChange.Text = "変更";
            this.Button_RChange.UseVisualStyleBackColor = true;
            this.Button_RChange.Click += new System.EventHandler(this.Button_RChange_Click);
            // 
            // Button_LChange
            // 
            this.Button_LChange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_LChange.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.Button_LChange.Location = new System.Drawing.Point(1605, 603);
            this.Button_LChange.Name = "Button_LChange";
            this.Button_LChange.Size = new System.Drawing.Size(135, 54);
            this.Button_LChange.TabIndex = 21;
            this.Button_LChange.Text = "変更";
            this.Button_LChange.UseVisualStyleBackColor = true;
            this.Button_LChange.Click += new System.EventHandler(this.Button_LChange_Click);
            // 
            // Label_RightKey
            // 
            this.Label_RightKey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_RightKey.AutoSize = true;
            this.Label_RightKey.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Label_RightKey.Location = new System.Drawing.Point(978, 602);
            this.Label_RightKey.Name = "Label_RightKey";
            this.Label_RightKey.Size = new System.Drawing.Size(57, 54);
            this.Label_RightKey.TabIndex = 22;
            this.Label_RightKey.Text = "A";
            // 
            // Label_LeftKey
            // 
            this.Label_LeftKey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_LeftKey.AutoSize = true;
            this.Label_LeftKey.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Label_LeftKey.Location = new System.Drawing.Point(1542, 602);
            this.Label_LeftKey.Name = "Label_LeftKey";
            this.Label_LeftKey.Size = new System.Drawing.Size(58, 54);
            this.Label_LeftKey.TabIndex = 23;
            this.Label_LeftKey.Text = "D";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2310, 1145);
            this.Controls.Add(this.Label_LeftKey);
            this.Controls.Add(this.Label_RightKey);
            this.Controls.Add(this.Button_LChange);
            this.Controls.Add(this.Button_RChange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.Label_SvCol);
            this.Controls.Add(this.Label_SEValue);
            this.Controls.Add(this.Label_BarValue);
            this.Controls.Add(this.Label_BallValue);
            this.Controls.Add(this.TrackBar_SE);
            this.Controls.Add(this.TrackBar_Bar);
            this.Controls.Add(this.TrackBar_Ball);
            this.Controls.Add(this.Button_Cansel);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Config";
            this.Text = "Config";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Config_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Config_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_SE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.TrackBar TrackBar_Ball;
        private System.Windows.Forms.TrackBar TrackBar_SE;
        private System.Windows.Forms.Label Label_BallValue;
        private System.Windows.Forms.Label Label_BarValue;
        private System.Windows.Forms.Label Label_SEValue;
        private System.Windows.Forms.TrackBar TrackBar_Bar;
        private System.Windows.Forms.Button Button_Cansel;
        private System.Windows.Forms.Label Label_SvCol;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Button_RChange;
        private System.Windows.Forms.Button Button_LChange;
        private System.Windows.Forms.Label Label_RightKey;
        private System.Windows.Forms.Label Label_LeftKey;
    }
}