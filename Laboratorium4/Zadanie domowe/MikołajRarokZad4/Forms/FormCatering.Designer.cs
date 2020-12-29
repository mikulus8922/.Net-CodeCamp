
namespace MikołajRarokZad4.Forms
{
    partial class FormCatering
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
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.buttonShowGuests = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(698, 182);
            this.dataGridViewMain.TabIndex = 0;
            // 
            // buttonShowGuests
            // 
            this.buttonShowGuests.Location = new System.Drawing.Point(292, 200);
            this.buttonShowGuests.Name = "buttonShowGuests";
            this.buttonShowGuests.Size = new System.Drawing.Size(142, 58);
            this.buttonShowGuests.TabIndex = 24;
            this.buttonShowGuests.Text = "Wyświetl Gości";
            this.buttonShowGuests.UseVisualStyleBackColor = true;
            this.buttonShowGuests.Click += new System.EventHandler(this.buttonShowGuests_Click);
            // 
            // FormCatering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 270);
            this.Controls.Add(this.buttonShowGuests);
            this.Controls.Add(this.dataGridViewMain);
            this.Name = "FormCatering";
            this.Text = "Zarządzanie kateringiem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button buttonShowGuests;
    }
}