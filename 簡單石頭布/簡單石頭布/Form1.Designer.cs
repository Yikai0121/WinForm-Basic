namespace 簡單石頭布
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblplayer = new System.Windows.Forms.Label();
            this.lobcomputer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblresault = new System.Windows.Forms.Label();
            this.btnstone = new System.Windows.Forms.Button();
            this.btnsoccer = new System.Windows.Forms.Button();
            this.btnpaper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "玩家";
            // 
            // lblplayer
            // 
            this.lblplayer.AutoSize = true;
            this.lblplayer.Location = new System.Drawing.Point(148, 29);
            this.lblplayer.Name = "lblplayer";
            this.lblplayer.Size = new System.Drawing.Size(33, 12);
            this.lblplayer.TabIndex = 1;
            this.lblplayer.Text = "label2";
            // 
            // lobcomputer
            // 
            this.lobcomputer.AutoSize = true;
            this.lobcomputer.Location = new System.Drawing.Point(555, 29);
            this.lobcomputer.Name = "lobcomputer";
            this.lobcomputer.Size = new System.Drawing.Size(29, 12);
            this.lobcomputer.TabIndex = 2;
            this.lobcomputer.Text = "電腦";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "裁判";
            // 
            // lblresault
            // 
            this.lblresault.AutoSize = true;
            this.lblresault.Location = new System.Drawing.Point(442, 228);
            this.lblresault.Name = "lblresault";
            this.lblresault.Size = new System.Drawing.Size(33, 12);
            this.lblresault.TabIndex = 5;
            this.lblresault.Text = "label6";
            // 
            // btnstone
            // 
            this.btnstone.Location = new System.Drawing.Point(170, 320);
            this.btnstone.Name = "btnstone";
            this.btnstone.Size = new System.Drawing.Size(75, 23);
            this.btnstone.TabIndex = 6;
            this.btnstone.Text = "石頭";
            this.btnstone.UseVisualStyleBackColor = true;
            this.btnstone.Click += new System.EventHandler(this.btnstone_Click);
            // 
            // btnsoccer
            // 
            this.btnsoccer.Location = new System.Drawing.Point(344, 320);
            this.btnsoccer.Name = "btnsoccer";
            this.btnsoccer.Size = new System.Drawing.Size(75, 23);
            this.btnsoccer.TabIndex = 7;
            this.btnsoccer.Text = "剪刀";
            this.btnsoccer.UseVisualStyleBackColor = true;
            this.btnsoccer.Click += new System.EventHandler(this.btnsoccer_Click);
            // 
            // btnpaper
            // 
            this.btnpaper.Location = new System.Drawing.Point(509, 320);
            this.btnpaper.Name = "btnpaper";
            this.btnpaper.Size = new System.Drawing.Size(75, 23);
            this.btnpaper.TabIndex = 8;
            this.btnpaper.Text = "布";
            this.btnpaper.UseVisualStyleBackColor = true;
            this.btnpaper.Click += new System.EventHandler(this.btnpaper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpaper);
            this.Controls.Add(this.btnsoccer);
            this.Controls.Add(this.btnstone);
            this.Controls.Add(this.lblresault);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lobcomputer);
            this.Controls.Add(this.lblplayer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblplayer;
        private System.Windows.Forms.Label lobcomputer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblresault;
        private System.Windows.Forms.Button btnstone;
        private System.Windows.Forms.Button btnsoccer;
        private System.Windows.Forms.Button btnpaper;
    }
}

