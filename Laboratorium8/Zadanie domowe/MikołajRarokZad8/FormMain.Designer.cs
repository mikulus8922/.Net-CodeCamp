
namespace MikołajRarokZad8
{
    partial class FormBurger
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
            this.buttonStandardBurger = new System.Windows.Forms.Button();
            this.labelBurgerInfo = new System.Windows.Forms.Label();
            this.buttonFries = new System.Windows.Forms.Button();
            this.buttonNachos = new System.Windows.Forms.Button();
            this.buttonPepsi = new System.Windows.Forms.Button();
            this.buttonLemonade = new System.Windows.Forms.Button();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.buttonBBQBurger = new System.Windows.Forms.Button();
            this.buttonChickenBurger = new System.Windows.Forms.Button();
            this.labelExtras = new System.Windows.Forms.Label();
            this.labelDrinks = new System.Windows.Forms.Label();
            this.buttonNextBurger = new System.Windows.Forms.Button();
            this.buttonFinalize = new System.Windows.Forms.Button();
            this.labelBurgers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStandardBurger
            // 
            this.buttonStandardBurger.Location = new System.Drawing.Point(12, 44);
            this.buttonStandardBurger.Name = "buttonStandardBurger";
            this.buttonStandardBurger.Size = new System.Drawing.Size(153, 60);
            this.buttonStandardBurger.TabIndex = 0;
            this.buttonStandardBurger.Text = "Standard - {cena}";
            this.buttonStandardBurger.UseVisualStyleBackColor = true;
            this.buttonStandardBurger.Click += new System.EventHandler(this.buttonStandardBurger_Click);
            // 
            // labelBurgerInfo
            // 
            this.labelBurgerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBurgerInfo.Location = new System.Drawing.Point(371, 14);
            this.labelBurgerInfo.Name = "labelBurgerInfo";
            this.labelBurgerInfo.Size = new System.Drawing.Size(264, 304);
            this.labelBurgerInfo.TabIndex = 1;
            this.labelBurgerInfo.Text = "Burger - {Cena}\r\n   Dodatki:\r\ndodatek 1\r\ndodatek 2";
            // 
            // buttonFries
            // 
            this.buttonFries.Enabled = false;
            this.buttonFries.Location = new System.Drawing.Point(219, 63);
            this.buttonFries.Name = "buttonFries";
            this.buttonFries.Size = new System.Drawing.Size(134, 60);
            this.buttonFries.TabIndex = 2;
            this.buttonFries.Text = "Frytki";
            this.buttonFries.UseVisualStyleBackColor = true;
            this.buttonFries.Click += new System.EventHandler(this.buttonFries_Click);
            // 
            // buttonNachos
            // 
            this.buttonNachos.Enabled = false;
            this.buttonNachos.Location = new System.Drawing.Point(219, 129);
            this.buttonNachos.Name = "buttonNachos";
            this.buttonNachos.Size = new System.Drawing.Size(134, 60);
            this.buttonNachos.TabIndex = 3;
            this.buttonNachos.Text = "Nachosy";
            this.buttonNachos.UseVisualStyleBackColor = true;
            this.buttonNachos.Click += new System.EventHandler(this.buttonNachos_Click);
            // 
            // buttonPepsi
            // 
            this.buttonPepsi.Enabled = false;
            this.buttonPepsi.Location = new System.Drawing.Point(231, 268);
            this.buttonPepsi.Name = "buttonPepsi";
            this.buttonPepsi.Size = new System.Drawing.Size(134, 60);
            this.buttonPepsi.TabIndex = 4;
            this.buttonPepsi.Text = "Pepsi";
            this.buttonPepsi.UseVisualStyleBackColor = true;
            this.buttonPepsi.Click += new System.EventHandler(this.buttonPepsi_Click);
            // 
            // buttonLemonade
            // 
            this.buttonLemonade.Enabled = false;
            this.buttonLemonade.Location = new System.Drawing.Point(231, 334);
            this.buttonLemonade.Name = "buttonLemonade";
            this.buttonLemonade.Size = new System.Drawing.Size(134, 60);
            this.buttonLemonade.TabIndex = 5;
            this.buttonLemonade.Text = "Lemoniada";
            this.buttonLemonade.UseVisualStyleBackColor = true;
            this.buttonLemonade.Click += new System.EventHandler(this.buttonLemonade_Click);
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTotalPrice.Location = new System.Drawing.Point(372, 367);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(263, 27);
            this.labelTotalPrice.TabIndex = 6;
            this.labelTotalPrice.Text = "Razem - {cena}";
            // 
            // buttonBBQBurger
            // 
            this.buttonBBQBurger.Location = new System.Drawing.Point(12, 110);
            this.buttonBBQBurger.Name = "buttonBBQBurger";
            this.buttonBBQBurger.Size = new System.Drawing.Size(153, 60);
            this.buttonBBQBurger.TabIndex = 7;
            this.buttonBBQBurger.Text = "BBQ - {cena}";
            this.buttonBBQBurger.UseVisualStyleBackColor = true;
            this.buttonBBQBurger.Click += new System.EventHandler(this.buttonBBQBurger_Click);
            // 
            // buttonChickenBurger
            // 
            this.buttonChickenBurger.Location = new System.Drawing.Point(12, 176);
            this.buttonChickenBurger.Name = "buttonChickenBurger";
            this.buttonChickenBurger.Size = new System.Drawing.Size(153, 60);
            this.buttonChickenBurger.TabIndex = 8;
            this.buttonChickenBurger.Text = "Kurczakburger - {cena}";
            this.buttonChickenBurger.UseVisualStyleBackColor = true;
            this.buttonChickenBurger.Click += new System.EventHandler(this.buttonChickenBurger_Click);
            // 
            // labelExtras
            // 
            this.labelExtras.AutoSize = true;
            this.labelExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExtras.Location = new System.Drawing.Point(215, 29);
            this.labelExtras.Name = "labelExtras";
            this.labelExtras.Size = new System.Drawing.Size(71, 20);
            this.labelExtras.TabIndex = 9;
            this.labelExtras.Text = "Dodatki";
            // 
            // labelDrinks
            // 
            this.labelDrinks.AutoSize = true;
            this.labelDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDrinks.Location = new System.Drawing.Point(227, 236);
            this.labelDrinks.Name = "labelDrinks";
            this.labelDrinks.Size = new System.Drawing.Size(65, 20);
            this.labelDrinks.TabIndex = 10;
            this.labelDrinks.Text = "Napoje";
            // 
            // buttonNextBurger
            // 
            this.buttonNextBurger.Enabled = false;
            this.buttonNextBurger.Location = new System.Drawing.Point(12, 268);
            this.buttonNextBurger.Name = "buttonNextBurger";
            this.buttonNextBurger.Size = new System.Drawing.Size(153, 60);
            this.buttonNextBurger.TabIndex = 11;
            this.buttonNextBurger.Text = "Następny Burger";
            this.buttonNextBurger.UseVisualStyleBackColor = true;
            this.buttonNextBurger.Click += new System.EventHandler(this.buttonNextBurger_Click);
            // 
            // buttonFinalize
            // 
            this.buttonFinalize.Location = new System.Drawing.Point(12, 334);
            this.buttonFinalize.Name = "buttonFinalize";
            this.buttonFinalize.Size = new System.Drawing.Size(153, 60);
            this.buttonFinalize.TabIndex = 12;
            this.buttonFinalize.Text = "Finalizuj Zamówienie";
            this.buttonFinalize.UseVisualStyleBackColor = true;
            this.buttonFinalize.Click += new System.EventHandler(this.buttonFinalize_Click);
            // 
            // labelBurgers
            // 
            this.labelBurgers.AutoSize = true;
            this.labelBurgers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBurgers.Location = new System.Drawing.Point(8, 9);
            this.labelBurgers.Name = "labelBurgers";
            this.labelBurgers.Size = new System.Drawing.Size(71, 20);
            this.labelBurgers.TabIndex = 13;
            this.labelBurgers.Text = "Burgery";
            // 
            // FormBurger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 426);
            this.Controls.Add(this.labelBurgers);
            this.Controls.Add(this.buttonFinalize);
            this.Controls.Add(this.buttonNextBurger);
            this.Controls.Add(this.labelDrinks);
            this.Controls.Add(this.labelExtras);
            this.Controls.Add(this.buttonChickenBurger);
            this.Controls.Add(this.buttonBBQBurger);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.buttonLemonade);
            this.Controls.Add(this.buttonPepsi);
            this.Controls.Add(this.buttonNachos);
            this.Controls.Add(this.buttonFries);
            this.Controls.Add(this.labelBurgerInfo);
            this.Controls.Add(this.buttonStandardBurger);
            this.Name = "FormBurger";
            this.Text = "Wybierz burgera";
            this.Load += new System.EventHandler(this.FormBurger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStandardBurger;
        private System.Windows.Forms.Label labelBurgerInfo;
        private System.Windows.Forms.Button buttonFries;
        private System.Windows.Forms.Button buttonNachos;
        private System.Windows.Forms.Button buttonPepsi;
        private System.Windows.Forms.Button buttonLemonade;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Button buttonBBQBurger;
        private System.Windows.Forms.Button buttonChickenBurger;
        private System.Windows.Forms.Label labelExtras;
        private System.Windows.Forms.Label labelDrinks;
        private System.Windows.Forms.Button buttonNextBurger;
        private System.Windows.Forms.Button buttonFinalize;
        private System.Windows.Forms.Label labelBurgers;
    }
}

