
namespace ArturJordanWyk
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBuilder = new System.Windows.Forms.Button();
            this.buttonFacade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBuilder
            // 
            this.buttonBuilder.Location = new System.Drawing.Point(13, 13);
            this.buttonBuilder.Name = "buttonBuilder";
            this.buttonBuilder.Size = new System.Drawing.Size(75, 23);
            this.buttonBuilder.TabIndex = 0;
            this.buttonBuilder.Text = "Budowniczy";
            this.buttonBuilder.UseVisualStyleBackColor = true;
            this.buttonBuilder.Click += new System.EventHandler(this.buttonBuilder_Click);
            // 
            // buttonFacade
            // 
            this.buttonFacade.Location = new System.Drawing.Point(13, 42);
            this.buttonFacade.Name = "buttonFacade";
            this.buttonFacade.Size = new System.Drawing.Size(75, 23);
            this.buttonFacade.TabIndex = 1;
            this.buttonFacade.Text = "Fasada";
            this.buttonFacade.UseVisualStyleBackColor = true;
            this.buttonFacade.Click += new System.EventHandler(this.buttonFacade_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 113);
            this.Controls.Add(this.buttonFacade);
            this.Controls.Add(this.buttonBuilder);
            this.Name = "MainForm";
            this.Text = "Okno główne";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBuilder;
        private System.Windows.Forms.Button buttonFacade;
    }
}

