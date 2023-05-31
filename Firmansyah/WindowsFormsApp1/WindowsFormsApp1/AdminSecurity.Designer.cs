
namespace WindowsFormsApp1
{
    partial class AdminSecurity
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
            this.txtKeyString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTextString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEncrpyt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKeyString
            // 
            this.txtKeyString.Location = new System.Drawing.Point(145, 37);
            this.txtKeyString.Name = "txtKeyString";
            this.txtKeyString.Size = new System.Drawing.Size(165, 20);
            this.txtKeyString.TabIndex = 3;
            this.txtKeyString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyString_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key String";
            // 
            // txtTextString
            // 
            this.txtTextString.Location = new System.Drawing.Point(145, 63);
            this.txtTextString.Name = "txtTextString";
            this.txtTextString.Size = new System.Drawing.Size(305, 20);
            this.txtTextString.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text String";
            // 
            // txtEncrpyt
            // 
            this.txtEncrpyt.Location = new System.Drawing.Point(145, 89);
            this.txtEncrpyt.Multiline = true;
            this.txtEncrpyt.Name = "txtEncrpyt";
            this.txtEncrpyt.Size = new System.Drawing.Size(305, 60);
            this.txtEncrpyt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Encrpyt String";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(145, 170);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 8;
            this.btnEncrypt.Text = "Encrpyt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(375, 170);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // AdminSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 215);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtEncrpyt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTextString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKeyString);
            this.Controls.Add(this.label1);
            this.Name = "AdminSecurity";
            this.Text = "AdminSecurity";
            this.Load += new System.EventHandler(this.AdminSecurity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeyString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTextString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEncrpyt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
    }
}