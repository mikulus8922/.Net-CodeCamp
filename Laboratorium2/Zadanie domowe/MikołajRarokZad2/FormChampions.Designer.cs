
namespace MikołajRarokZad2
{
    partial class FormChampions
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
            this.buttonGenerateNewChampions = new System.Windows.Forms.Button();
            this.dataGridViewNewChampions = new System.Windows.Forms.DataGridView();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewRoster = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewChampions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoster)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerateNewChampions
            // 
            this.buttonGenerateNewChampions.Location = new System.Drawing.Point(12, 12);
            this.buttonGenerateNewChampions.Name = "buttonGenerateNewChampions";
            this.buttonGenerateNewChampions.Size = new System.Drawing.Size(140, 59);
            this.buttonGenerateNewChampions.TabIndex = 0;
            this.buttonGenerateNewChampions.Text = "Recruit New Hero";
            this.buttonGenerateNewChampions.UseVisualStyleBackColor = true;
            this.buttonGenerateNewChampions.Click += new System.EventHandler(this.buttonGenerateNewChampions_Click);
            // 
            // dataGridViewNewChampions
            // 
            this.dataGridViewNewChampions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNewChampions.Location = new System.Drawing.Point(256, 12);
            this.dataGridViewNewChampions.Name = "dataGridViewNewChampions";
            this.dataGridViewNewChampions.Size = new System.Drawing.Size(532, 192);
            this.dataGridViewNewChampions.TabIndex = 1;
            this.dataGridViewNewChampions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNewChampions_CellContentClick);
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // dataGridViewRoster
            // 
            this.dataGridViewRoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoster.Location = new System.Drawing.Point(256, 210);
            this.dataGridViewRoster.Name = "dataGridViewRoster";
            this.dataGridViewRoster.Size = new System.Drawing.Size(532, 192);
            this.dataGridViewRoster.TabIndex = 2;
            // 
            // FormChampions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 528);
            this.Controls.Add(this.dataGridViewRoster);
            this.Controls.Add(this.dataGridViewNewChampions);
            this.Controls.Add(this.buttonGenerateNewChampions);
            this.Name = "FormChampions";
            this.Text = "Champions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewChampions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateNewChampions;
        private System.Windows.Forms.DataGridView dataGridViewNewChampions;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.DataGridView dataGridViewRoster;
    }
}

