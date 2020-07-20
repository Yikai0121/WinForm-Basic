namespace 愛不愛小練習
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
            this.btnlove = new System.Windows.Forms.Button();
            this.btnunlove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlove
            // 
            this.btnlove.Location = new System.Drawing.Point(194, 126);
            this.btnlove.Name = "btnlove";
            this.btnlove.Size = new System.Drawing.Size(75, 23);
            this.btnlove.TabIndex = 0;
            this.btnlove.Text = "愛";
            this.btnlove.UseVisualStyleBackColor = true;
            this.btnlove.Click += new System.EventHandler(this.btnlove_Click);
            // 
            // btnunlove
            // 
            this.btnunlove.Location = new System.Drawing.Point(545, 126);
            this.btnunlove.Name = "btnunlove";
            this.btnunlove.Size = new System.Drawing.Size(75, 23);
            this.btnunlove.TabIndex = 1;
            this.btnunlove.Text = "不愛";
            this.btnunlove.UseVisualStyleBackColor = true;
            this.btnunlove.Click += new System.EventHandler(this.btnunlove_Click);
            this.btnunlove.MouseEnter += new System.EventHandler(this.btnunlove_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnunlove);
            this.Controls.Add(this.btnlove);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlove;
        private System.Windows.Forms.Button btnunlove;
    }
}

