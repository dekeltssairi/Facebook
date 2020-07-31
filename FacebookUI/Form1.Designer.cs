namespace FacebookUI
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
            this.f_LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // f_LoginButton
            // 
            this.f_LoginButton.Location = new System.Drawing.Point(341, 44);
            this.f_LoginButton.Name = "f_LoginButton";
            this.f_LoginButton.Size = new System.Drawing.Size(75, 23);
            this.f_LoginButton.TabIndex = 0;
            this.f_LoginButton.Text = "Login";
            this.f_LoginButton.UseVisualStyleBackColor = true;
            this.f_LoginButton.Click += new System.EventHandler(this.f_LoginButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.f_LoginButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button f_LoginButton;
    }
}

