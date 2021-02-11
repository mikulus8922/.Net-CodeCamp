
namespace A
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.buttonShift = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonNotIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(12, 12);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 38);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelLoggedIn
            // 
            this.labelLoggedIn.AutoSize = true;
            this.labelLoggedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoggedIn.Location = new System.Drawing.Point(8, 95);
            this.labelLoggedIn.Name = "labelLoggedIn";
            this.labelLoggedIn.Size = new System.Drawing.Size(104, 20);
            this.labelLoggedIn.TabIndex = 2;
            this.labelLoggedIn.Text = "zalogowano";
            this.labelLoggedIn.Visible = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 64);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 28);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "A1 Zaloguj";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // timerMain
            // 
            this.timerMain.Interval = 3000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // buttonShift
            // 
            this.buttonShift.Location = new System.Drawing.Point(12, 410);
            this.buttonShift.Name = "buttonShift";
            this.buttonShift.Size = new System.Drawing.Size(100, 28);
            this.buttonShift.TabIndex = 4;
            this.buttonShift.Text = "A2 Start";
            this.buttonShift.UseVisualStyleBackColor = true;
            this.buttonShift.Click += new System.EventHandler(this.buttonShift_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Location = new System.Drawing.Point(326, 388);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(140, 50);
            this.buttonEmployees.TabIndex = 5;
            this.buttonEmployees.Text = "A3 Pracownicy";
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(164, 12);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(601, 335);
            this.dataGridViewMain.TabIndex = 6;
            // 
            // buttonProducts
            // 
            this.buttonProducts.Location = new System.Drawing.Point(618, 388);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(140, 50);
            this.buttonProducts.TabIndex = 7;
            this.buttonProducts.Text = "A5 Produkty";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonNotIn
            // 
            this.buttonNotIn.Location = new System.Drawing.Point(472, 388);
            this.buttonNotIn.Name = "buttonNotIn";
            this.buttonNotIn.Size = new System.Drawing.Size(140, 50);
            this.buttonNotIn.TabIndex = 8;
            this.buttonNotIn.Text = "A4 Bez Przełożonych";
            this.buttonNotIn.UseVisualStyleBackColor = true;
            this.buttonNotIn.Click += new System.EventHandler(this.buttonNotIn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNotIn);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.buttonEmployees);
            this.Controls.Add(this.buttonShift);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelLoggedIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "FormMain";
            this.Text = "A";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLoggedIn;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button buttonShift;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonNotIn;
    }
}

