
namespace Lab4
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
            this.btnRefill = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.RichTxtInfo = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRefill
            // 
            this.btnRefill.Location = new System.Drawing.Point(50, 446);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(194, 60);
            this.btnRefill.TabIndex = 0;
            this.btnRefill.Text = "Перезаполнить";
            this.btnRefill.UseVisualStyleBackColor = true;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(270, 446);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(194, 60);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Взять";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // RichTxtInfo
            // 
            this.RichTxtInfo.Location = new System.Drawing.Point(50, 154);
            this.RichTxtInfo.Multiline = true;
            this.RichTxtInfo.Name = "RichTxtInfo";
            this.RichTxtInfo.Size = new System.Drawing.Size(414, 266);
            this.RichTxtInfo.TabIndex = 2;
            // 
            // txtInfo
            // 
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Location = new System.Drawing.Point(50, 21);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(414, 98);
            this.txtInfo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 538);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.RichTxtInfo);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnRefill);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox RichTxtInfo;
        private System.Windows.Forms.TextBox txtInfo;
    }
}

