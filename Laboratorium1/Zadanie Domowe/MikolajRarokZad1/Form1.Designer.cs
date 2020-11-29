
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
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.buttonECTSPerClickUpgrade = new System.Windows.Forms.Button();
            this.buttonECTSPerTickUpgrade = new System.Windows.Forms.Button();
            this.buttonRandomBoostUpgrade = new System.Windows.Forms.Button();
            this.buttonMoneyPerTickUpgrade = new System.Windows.Forms.Button();
            this.buttonMoneyPerClickUpgrade = new System.Windows.Forms.Button();
            this.labelECTSPerClickLvl = new System.Windows.Forms.Label();
            this.labelECTSPerTickLvl = new System.Windows.Forms.Label();
            this.labelRandomBoostLvl = new System.Windows.Forms.Label();
            this.labelMoneyPerTickLvl = new System.Windows.Forms.Label();
            this.labelMoneyPerClickLvl = new System.Windows.Forms.Label();
            this.labelTextECTS = new System.Windows.Forms.Label();
            this.labelTextMoney = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelECTS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonECTS
            // 
            this.buttonECTS.BackColor = System.Drawing.Color.White;
            this.buttonECTS.Location = new System.Drawing.Point(12, 265);
            this.buttonECTS.Name = "buttonECTS";
            this.buttonECTS.Size = new System.Drawing.Size(166, 77);
            this.buttonECTS.TabIndex = 0;
            this.buttonECTS.Text = "Ucz się";
            this.buttonECTS.UseVisualStyleBackColor = false;
            this.buttonECTS.Click += new System.EventHandler(this.buttonECTS_Click);
            // 
            // buttonWork
            // 
            this.buttonWork.BackColor = System.Drawing.Color.White;
            this.buttonWork.Location = new System.Drawing.Point(12, 352);
            this.buttonWork.Name = "buttonWork";
            this.buttonWork.Size = new System.Drawing.Size(166, 77);
            this.buttonWork.TabIndex = 1;
            this.buttonWork.Text = "Pracuj";
            this.buttonWork.UseVisualStyleBackColor = false;
            this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click);
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // buttonECTSPerClickUpgrade
            // 
            this.buttonECTSPerClickUpgrade.BackColor = System.Drawing.Color.White;
            this.buttonECTSPerClickUpgrade.Location = new System.Drawing.Point(625, 12);
            this.buttonECTSPerClickUpgrade.Name = "buttonECTSPerClickUpgrade";
            this.buttonECTSPerClickUpgrade.Size = new System.Drawing.Size(201, 79);
            this.buttonECTSPerClickUpgrade.TabIndex = 3;
            this.buttonECTSPerClickUpgrade.Text = "Moc klikania ECTS";
            this.buttonECTSPerClickUpgrade.UseVisualStyleBackColor = false;
            this.buttonECTSPerClickUpgrade.Click += new System.EventHandler(this.buttonECTSPerClickUpgrade_Click);
            // 
            // buttonECTSPerTickUpgrade
            // 
            this.buttonECTSPerTickUpgrade.BackColor = System.Drawing.Color.White;
            this.buttonECTSPerTickUpgrade.Location = new System.Drawing.Point(625, 95);
            this.buttonECTSPerTickUpgrade.Name = "buttonECTSPerTickUpgrade";
            this.buttonECTSPerTickUpgrade.Size = new System.Drawing.Size(201, 79);
            this.buttonECTSPerTickUpgrade.TabIndex = 4;
            this.buttonECTSPerTickUpgrade.Text = "ECTSy Co tick";
            this.buttonECTSPerTickUpgrade.UseVisualStyleBackColor = false;
            this.buttonECTSPerTickUpgrade.Click += new System.EventHandler(this.buttonECTSPerTickUpgrade_Click);
            // 
            // buttonRandomBoostUpgrade
            // 
            this.buttonRandomBoostUpgrade.BackColor = System.Drawing.Color.White;
            this.buttonRandomBoostUpgrade.Location = new System.Drawing.Point(625, 180);
            this.buttonRandomBoostUpgrade.Name = "buttonRandomBoostUpgrade";
            this.buttonRandomBoostUpgrade.Size = new System.Drawing.Size(201, 79);
            this.buttonRandomBoostUpgrade.TabIndex = 5;
            this.buttonRandomBoostUpgrade.Text = "Zwiększ swoje szanse w wydarzeniach losowych";
            this.buttonRandomBoostUpgrade.UseVisualStyleBackColor = false;
            this.buttonRandomBoostUpgrade.Click += new System.EventHandler(this.buttonRandomBoostUpgrade_Click);
            // 
            // buttonMoneyPerTickUpgrade
            // 
            this.buttonMoneyPerTickUpgrade.BackColor = System.Drawing.Color.White;
            this.buttonMoneyPerTickUpgrade.Location = new System.Drawing.Point(625, 265);
            this.buttonMoneyPerTickUpgrade.Name = "buttonMoneyPerTickUpgrade";
            this.buttonMoneyPerTickUpgrade.Size = new System.Drawing.Size(201, 79);
            this.buttonMoneyPerTickUpgrade.TabIndex = 6;
            this.buttonMoneyPerTickUpgrade.Text = "Pieniądze co tick";
            this.buttonMoneyPerTickUpgrade.UseVisualStyleBackColor = false;
            this.buttonMoneyPerTickUpgrade.Click += new System.EventHandler(this.buttonMoneyPerTickUpgrade_Click);
            // 
            // buttonMoneyPerClickUpgrade
            // 
            this.buttonMoneyPerClickUpgrade.BackColor = System.Drawing.Color.White;
            this.buttonMoneyPerClickUpgrade.Location = new System.Drawing.Point(625, 350);
            this.buttonMoneyPerClickUpgrade.Name = "buttonMoneyPerClickUpgrade";
            this.buttonMoneyPerClickUpgrade.Size = new System.Drawing.Size(201, 79);
            this.buttonMoneyPerClickUpgrade.TabIndex = 7;
            this.buttonMoneyPerClickUpgrade.Text = "Ulepsz koparkę kryptowalut";
            this.buttonMoneyPerClickUpgrade.UseVisualStyleBackColor = false;
            this.buttonMoneyPerClickUpgrade.Click += new System.EventHandler(this.buttonMoneyPerClickUpgrade_Click);
            // 
            // labelECTSPerClickLvl
            // 
            this.labelECTSPerClickLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelECTSPerClickLvl.Location = new System.Drawing.Point(589, 33);
            this.labelECTSPerClickLvl.Name = "labelECTSPerClickLvl";
            this.labelECTSPerClickLvl.Size = new System.Drawing.Size(30, 30);
            this.labelECTSPerClickLvl.TabIndex = 8;
            this.labelECTSPerClickLvl.Text = "0";
            this.labelECTSPerClickLvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelECTSPerTickLvl
            // 
            this.labelECTSPerTickLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelECTSPerTickLvl.Location = new System.Drawing.Point(589, 116);
            this.labelECTSPerTickLvl.Name = "labelECTSPerTickLvl";
            this.labelECTSPerTickLvl.Size = new System.Drawing.Size(30, 30);
            this.labelECTSPerTickLvl.TabIndex = 9;
            this.labelECTSPerTickLvl.Text = "0";
            this.labelECTSPerTickLvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRandomBoostLvl
            // 
            this.labelRandomBoostLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRandomBoostLvl.Location = new System.Drawing.Point(589, 201);
            this.labelRandomBoostLvl.Name = "labelRandomBoostLvl";
            this.labelRandomBoostLvl.Size = new System.Drawing.Size(30, 30);
            this.labelRandomBoostLvl.TabIndex = 10;
            this.labelRandomBoostLvl.Text = "0";
            this.labelRandomBoostLvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMoneyPerTickLvl
            // 
            this.labelMoneyPerTickLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMoneyPerTickLvl.Location = new System.Drawing.Point(589, 286);
            this.labelMoneyPerTickLvl.Name = "labelMoneyPerTickLvl";
            this.labelMoneyPerTickLvl.Size = new System.Drawing.Size(30, 30);
            this.labelMoneyPerTickLvl.TabIndex = 11;
            this.labelMoneyPerTickLvl.Text = "0";
            this.labelMoneyPerTickLvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMoneyPerClickLvl
            // 
            this.labelMoneyPerClickLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMoneyPerClickLvl.Location = new System.Drawing.Point(589, 371);
            this.labelMoneyPerClickLvl.Name = "labelMoneyPerClickLvl";
            this.labelMoneyPerClickLvl.Size = new System.Drawing.Size(30, 30);
            this.labelMoneyPerClickLvl.TabIndex = 12;
            this.labelMoneyPerClickLvl.Text = "0";
            this.labelMoneyPerClickLvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTextECTS
            // 
            this.labelTextECTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.labelTextECTS.Location = new System.Drawing.Point(303, 155);
            this.labelTextECTS.Name = "labelTextECTS";
            this.labelTextECTS.Size = new System.Drawing.Size(182, 55);
            this.labelTextECTS.TabIndex = 13;
            this.labelTextECTS.Text = "Twoje ECTSy";
            this.labelTextECTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTextMoney
            // 
            this.labelTextMoney.BackColor = System.Drawing.Color.Lime;
            this.labelTextMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTextMoney.Location = new System.Drawing.Point(12, 201);
            this.labelTextMoney.Name = "labelTextMoney";
            this.labelTextMoney.Size = new System.Drawing.Size(166, 20);
            this.labelTextMoney.TabIndex = 14;
            this.labelTextMoney.Text = "Pieniądze";
            this.labelTextMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMoney
            // 
            this.labelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMoney.Location = new System.Drawing.Point(12, 228);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(166, 20);
            this.labelMoney.TabIndex = 15;
            this.labelMoney.Text = "0";
            this.labelMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelECTS
            // 
            this.labelECTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelECTS.Location = new System.Drawing.Point(299, 228);
            this.labelECTS.Name = "labelECTS";
            this.labelECTS.Size = new System.Drawing.Size(186, 31);
            this.labelECTS.TabIndex = 16;
            this.labelECTS.Text = "0";
            this.labelECTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MikolajRarokZad1.Properties.Resources.polibuda;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.labelECTS);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelTextMoney);
            this.Controls.Add(this.labelTextECTS);
            this.Controls.Add(this.labelMoneyPerClickLvl);
            this.Controls.Add(this.labelMoneyPerTickLvl);
            this.Controls.Add(this.labelRandomBoostLvl);
            this.Controls.Add(this.labelECTSPerTickLvl);
            this.Controls.Add(this.labelECTSPerClickLvl);
            this.Controls.Add(this.buttonMoneyPerClickUpgrade);
            this.Controls.Add(this.buttonMoneyPerTickUpgrade);
            this.Controls.Add(this.buttonRandomBoostUpgrade);
            this.Controls.Add(this.buttonECTSPerTickUpgrade);
            this.Controls.Add(this.buttonECTSPerClickUpgrade);
            this.Controls.Add(this.buttonWork);
            this.Controls.Add(this.buttonECTS);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECTSclicker";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonECTS;
        private System.Windows.Forms.Button buttonWork;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button buttonECTSPerClickUpgrade;
        private System.Windows.Forms.Button buttonECTSPerTickUpgrade;
        private System.Windows.Forms.Button buttonRandomBoostUpgrade;
        private System.Windows.Forms.Button buttonMoneyPerTickUpgrade;
        private System.Windows.Forms.Button buttonMoneyPerClickUpgrade;
        private System.Windows.Forms.Label labelECTSPerClickLvl;
        private System.Windows.Forms.Label labelECTSPerTickLvl;
        private System.Windows.Forms.Label labelRandomBoostLvl;
        private System.Windows.Forms.Label labelMoneyPerTickLvl;
        private System.Windows.Forms.Label labelMoneyPerClickLvl;
        private System.Windows.Forms.Label labelTextECTS;
        private System.Windows.Forms.Label labelTextMoney;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelECTS;
    }
}

