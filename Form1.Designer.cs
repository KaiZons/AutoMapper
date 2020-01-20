namespace AutoMapperDemo
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
            this.m_testBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_testBtn
            // 
            this.m_testBtn.Location = new System.Drawing.Point(328, 166);
            this.m_testBtn.Name = "m_testBtn";
            this.m_testBtn.Size = new System.Drawing.Size(75, 23);
            this.m_testBtn.TabIndex = 0;
            this.m_testBtn.Text = "测试";
            this.m_testBtn.UseVisualStyleBackColor = true;
            this.m_testBtn.Click += new System.EventHandler(this.OnTestBtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.m_testBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_testBtn;
    }
}

