namespace AnimationProject
{
    partial class Title
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Button_start = new System.Windows.Forms.Button();
            this.Button_modechange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 100F);
            this.label1.Location = new System.Drawing.Point(506, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1305, 267);
            this.label1.TabIndex = 0;
            this.label1.Text = "ブロック崩し";
            // 
            // Button_start
            // 
            this.Button_start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_start.BackColor = System.Drawing.SystemColors.Info;
            this.Button_start.Font = new System.Drawing.Font("MS UI Gothic", 75F);
            this.Button_start.Location = new System.Drawing.Point(957, 517);
            this.Button_start.Name = "Button_start";
            this.Button_start.Size = new System.Drawing.Size(352, 228);
            this.Button_start.TabIndex = 1;
            this.Button_start.Text = "start";
            this.Button_start.UseVisualStyleBackColor = false;
            this.Button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // Button_modechange
            // 
            this.Button_modechange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_modechange.Font = new System.Drawing.Font("MS UI Gothic", 50F);
            this.Button_modechange.Location = new System.Drawing.Point(835, 811);
            this.Button_modechange.Name = "Button_modechange";
            this.Button_modechange.Size = new System.Drawing.Size(574, 169);
            this.Button_modechange.TabIndex = 2;
            this.Button_modechange.Text = "ModeChange";
            this.Button_modechange.UseVisualStyleBackColor = true;
            this.Button_modechange.Click += new System.EventHandler(this.Button_modechange_Click);
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2310, 1145);
            this.Controls.Add(this.Button_modechange);
            this.Controls.Add(this.Button_start);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Title";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_start;
        private System.Windows.Forms.Button Button_modechange;
    }
}

