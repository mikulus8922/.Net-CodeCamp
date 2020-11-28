
namespace MikolajRarokZad1
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
            this.buttonECTS = new System.Windows.Forms.Button();
            this.buttonWork = new System.Windows.Forms.Button();
            this.buttonCasino = new System.Windows.Forms.Button();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.buttonECTSPerClickUpgrade = new System.Windows.Forms.Button();
            this.buttonECTSPerTickUpgrade = new System.Windows.Forms.Button();
            this.buttonRandomBoostUpgrade = new System.Windows.Forms.Button();
            this.buttonMoneyPerTickUpgrade = new System.Windows.Forms.Button();
            this.buttonMoneyPerClickUpgrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonECTS
            // 
            this.buttonECTS.Location = new System.Drawing.Point(335, 352);
            this.buttonECTS.Name = "buttonECTS";
            this.buttonECTS.Size = new System.Drawing.Size(166, 77);
            this.buttonECTS.TabIndex = 0;
            this.buttonECTS.Text = "Ucz się";
            this.buttonECTS.UseVisualStyleBackColor = true;
            this.buttonECTS.Click += new System.EventHandler(this.buttonECTS_Click);
            // 
            // buttonWork
            // 
            this.buttonWork.Location = new System.Drawing.Point(12, 352);
            this.buttonWork.Name = "buttonWork";
            this.buttonWork.Size = new System.Drawing.Size(141, 77);
            this.buttonWork.TabIndex = 1;
            this.buttonWork.Text = "Pracuj";
            this.buttonWork.UseVisualStyleBackColor = true;
            this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click);
            // 
            // buttonCasino
            // 
            this.buttonCasino.Location = new System.Drawing.Point(12, 269);
            this.buttonCasino.Name = "buttonCasino";
            this.buttonCasino.Size = new System.Drawing.Size(141, 77);
            this.buttonCasino.TabIndex = 2;
            this.buttonCasino.Text = "Idź do kasyna";
            this.buttonCasino.UseVisualStyleBackColor = true;
            this.buttonCasino.Click += new System.EventHandler(this.buttonCasino_Click);
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // buttonECTSPerClickUpgrade
            // 
            this.buttonECTSPerClickUpgrade.Location = new System.Drawing.Point(652, 12);
            this.buttonECTSPerClickUpgrade.Name = "buttonECTSPerClickUpgrade";
            this.buttonECTSPerClickUpgrade.Size = new System.Drawing.Size(174, 79);
            this.buttonECTSPerClickUpgrade.TabIndex = 3;
            this.buttonECTSPerClickUpgrade.Text = "Moc klikania ECTS";
            this.buttonECTSPerClickUpgrade.UseVisualStyleBackColor = true;
            this.buttonECTSPerClickUpgrade.Click += new System.EventHandler(this.buttonECTSPerClickUpgrade_Click);
            // 
            // buttonECTSPerTickUpgrade
            // 
            this.buttonECTSPerTickUpgrade.Location = new System.Drawing.Point(652, 95);
            this.buttonECTSPerTickUpgrade.Name = "buttonECTSPerTickUpgrade";
            this.buttonECTSPerTickUpgrade.Size = new System.Drawing.Size(174, 79);
            this.buttonECTSPerTickUpgrade.TabIndex = 4;
            this.buttonECTSPerTickUpgrade.Text = "ECTSy Co tick";
            this.buttonECTSPerTickUpgrade.UseVisualStyleBackColor = true;
            this.buttonECTSPerTickUpgrade.Click += new System.EventHandler(this.buttonECTSPerTickUpgrade_Click);
            // 
            // buttonRandomBoostUpgrade
            // 
            this.buttonRandomBoostUpgrade.Location = new System.Drawing.Point(652, 180);
            this.buttonRandomBoostUpgrade.Name = "buttonRandomBoostUpgrade";
            this.buttonRandomBoostUpgrade.Size = new System.Drawing.Size(174, 79);
            this.buttonRandomBoostUpgrade.TabIndex = 5;
            this.buttonRandomBoostUpgrade.Text = "Zwiększ swoje szanse w wydarzeniach losowych";
            this.buttonRandomBoostUpgrade.UseVisualStyleBackColor = true;
            this.buttonRandomBoostUpgrade.Click += new System.EventHandler(this.buttonRandomBoostUpgrade_Click);
            // 
            // buttonMoneyPerTickUpgrade
            // 
            this.buttonMoneyPerTickUpgrade.Location = new System.Drawing.Point(652, 265);
            this.buttonMoneyPerTickUpgrade.Name = "buttonMoneyPerTickUpgrade";
            this.buttonMoneyPerTickUpgrade.Size = new System.Drawing.Size(174, 79);
            this.buttonMoneyPerTickUpgrade.TabIndex = 6;
            this.buttonMoneyPerTickUpgrade.Text = "Pieniądze co tick";
            this.buttonMoneyPerTickUpgrade.UseVisualStyleBackColor = true;
            this.buttonMoneyPerTickUpgrade.Click += new System.EventHandler(this.buttonMoneyPerTickUpgrade_Click);
            // 
            // buttonMoneyPerClickUpgrade
            // 
            this.buttonMoneyPerClickUpgrade.Location = new System.Drawing.Point(652, 350);
            this.buttonMoneyPerClickUpgrade.Name = "buttonMoneyPerClickUpgrade";
            this.buttonMoneyPerClickUpgrade.Size = new System.Drawing.Size(174, 79);
            this.buttonMoneyPerClickUpgrade.TabIndex = 7;
            this.buttonMoneyPerClickUpgrade.Text = "Moc zarabiania pieniedzy";
            this.buttonMoneyPerClickUpgrade.UseVisualStyleBackColor = true;
            this.buttonMoneyPerClickUpgrade.Click += new System.EventHandler(this.buttonMoneyPerClickUpgrade_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.buttonMoneyPerClickUpgrade);
            this.Controls.Add(this.buttonMoneyPerTickUpgrade);
            this.Controls.Add(this.buttonRandomBoostUpgrade);
            this.Controls.Add(this.buttonECTSPerTickUpgrade);
            this.Controls.Add(this.buttonECTSPerClickUpgrade);
            this.Controls.Add(this.buttonCasino);
            this.Controls.Add(this.buttonWork);
            this.Controls.Add(this.buttonECTS);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormMain";
            this.Text = "ECTSclicker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonECTS;
        private System.Windows.Forms.Button buttonWork;
        private System.Windows.Forms.Button buttonCasino;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button buttonECTSPerClickUpgrade;
        private System.Windows.Forms.Button buttonECTSPerTickUpgrade;
        private System.Windows.Forms.Button buttonRandomBoostUpgrade;
        private System.Windows.Forms.Button buttonMoneyPerTickUpgrade;
        private System.Windows.Forms.Button buttonMoneyPerClickUpgrade;
    }
}

