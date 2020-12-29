
namespace MikołajRarokZad4.Forms
{
    partial class FormLogin
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPrompt = new System.Windows.Forms.Label();
            this.buttonTryToLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(28, 75);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(103, 20);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.Text = "admin";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(157, 75);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(103, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "admin";
            // 
            // labelLogin
            // 
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelLogin.Location = new System.Drawing.Point(25, 49);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(103, 23);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Login";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelPassword.Location = new System.Drawing.Point(154, 49);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(103, 23);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Hasło";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrompt
            // 
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPrompt.Location = new System.Drawing.Point(96, 9);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(86, 20);
            this.labelPrompt.TabIndex = 4;
            this.labelPrompt.Text = "Logowanie";
            // 
            // buttonTryToLogIn
            // 
            this.buttonTryToLogIn.Location = new System.Drawing.Point(100, 115);
            this.buttonTryToLogIn.Name = "buttonTryToLogIn";
            this.buttonTryToLogIn.Size = new System.Drawing.Size(86, 25);
            this.buttonTryToLogIn.TabIndex = 5;
            this.buttonTryToLogIn.Text = "Zaloguj";
            this.buttonTryToLogIn.UseVisualStyleBackColor = true;
            this.buttonTryToLogIn.Click += new System.EventHandler(this.buttonTryToLogIn_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 162);
            this.Controls.Add(this.buttonTryToLogIn);
            this.Controls.Add(this.labelPrompt);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "FormLogin";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.Button buttonTryToLogIn;
    }
}