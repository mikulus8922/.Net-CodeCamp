
namespace MikolajRarokZad1
{
    partial class FormEventTestownik
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
            this.labelEvent = new System.Windows.Forms.Label();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEvent
            // 
            this.labelEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelEvent.Location = new System.Drawing.Point(12, 9);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(312, 84);
            this.labelEvent.TabIndex = 0;
            this.labelEvent.Text = "tekst wiadomości";
            this.labelEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNo
            // 
            this.buttonNo.Location = new System.Drawing.Point(61, 96);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(97, 51);
            this.buttonNo.TabIndex = 1;
            this.buttonNo.Text = "Nie";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(181, 96);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(97, 51);
            this.buttonYes.TabIndex = 2;
            this.buttonYes.Text = "Tak";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // FormEventTestownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 159);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.labelEvent);
            this.Name = "FormEventTestownik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wydarzenie";
            this.Load += new System.EventHandler(this.FormEvent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonYes;
    }
}