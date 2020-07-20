namespace MDI設計
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.顯示子窗體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.橫向排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.縱向排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顯示子窗體ToolStripMenuItem,
            this.橫向排列ToolStripMenuItem,
            this.縱向排列ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 顯示子窗體ToolStripMenuItem
            // 
            this.顯示子窗體ToolStripMenuItem.Name = "顯示子窗體ToolStripMenuItem";
            this.顯示子窗體ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.顯示子窗體ToolStripMenuItem.Text = "顯示子窗體";
            this.顯示子窗體ToolStripMenuItem.Click += new System.EventHandler(this.顯示子窗體ToolStripMenuItem_Click);
            // 
            // 橫向排列ToolStripMenuItem
            // 
            this.橫向排列ToolStripMenuItem.Name = "橫向排列ToolStripMenuItem";
            this.橫向排列ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.橫向排列ToolStripMenuItem.Text = "橫向排列";
            this.橫向排列ToolStripMenuItem.Click += new System.EventHandler(this.橫向排列ToolStripMenuItem_Click);
            // 
            // 縱向排列ToolStripMenuItem
            // 
            this.縱向排列ToolStripMenuItem.Name = "縱向排列ToolStripMenuItem";
            this.縱向排列ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.縱向排列ToolStripMenuItem.Text = "縱向排列";
            this.縱向排列ToolStripMenuItem.Click += new System.EventHandler(this.縱向排列ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 顯示子窗體ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 橫向排列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 縱向排列ToolStripMenuItem;
    }
}

