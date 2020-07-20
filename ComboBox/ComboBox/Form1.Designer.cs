namespace ComboBox
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
            this.cboyear = new System.Windows.Forms.ComboBox();
            this.cbomon = new System.Windows.Forms.ComboBox();
            this.cbodays = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboyear
            // 
            this.cboyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboyear.FormattingEnabled = true;
            this.cboyear.Location = new System.Drawing.Point(60, 54);
            this.cboyear.Name = "cboyear";
            this.cboyear.Size = new System.Drawing.Size(121, 20);
            this.cboyear.TabIndex = 0;
            this.cboyear.SelectedIndexChanged += new System.EventHandler(this.cboyear_SelectedIndexChanged);
            // 
            // cbomon
            // 
            this.cbomon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomon.FormattingEnabled = true;
            this.cbomon.Location = new System.Drawing.Point(311, 54);
            this.cbomon.Name = "cbomon";
            this.cbomon.Size = new System.Drawing.Size(121, 20);
            this.cbomon.TabIndex = 1;
            this.cbomon.SelectedIndexChanged += new System.EventHandler(this.cbomon_SelectedIndexChanged);
            // 
            // cbodays
            // 
            this.cbodays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodays.FormattingEnabled = true;
            this.cbodays.Location = new System.Drawing.Point(580, 54);
            this.cbodays.Name = "cbodays";
            this.cbodays.Size = new System.Drawing.Size(121, 20);
            this.cbodays.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbodays);
            this.Controls.Add(this.cbomon);
            this.Controls.Add(this.cboyear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboyear;
        private System.Windows.Forms.ComboBox cbomon;
        private System.Windows.Forms.ComboBox cbodays;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

