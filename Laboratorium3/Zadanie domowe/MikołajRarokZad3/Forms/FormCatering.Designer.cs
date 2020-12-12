
namespace MikołajRarokZad3.Forms
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
            this.textBoxGuestLastName = new System.Windows.Forms.TextBox();
            this.textBoxGuestFirstName = new System.Windows.Forms.TextBox();
            this.textBoxGuestId = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(531, 182);
            this.dataGridViewMain.TabIndex = 0;
            // 
            // buttonShowGuests
            // 
            this.buttonShowGuests.Location = new System.Drawing.Point(584, 25);
            this.buttonShowGuests.Name = "buttonShowGuests";
            this.buttonShowGuests.Size = new System.Drawing.Size(112, 42);
            this.buttonShowGuests.TabIndex = 24;
            this.buttonShowGuests.Text = "Wyświetl Gości";
            this.buttonShowGuests.UseVisualStyleBackColor = true;
            this.buttonShowGuests.Click += new System.EventHandler(this.buttonShowGuests_Click);
            // 
            // textBoxGuestLastName
            // 
            this.textBoxGuestLastName.Location = new System.Drawing.Point(584, 143);
            this.textBoxGuestLastName.Name = "textBoxGuestLastName";
            this.textBoxGuestLastName.Size = new System.Drawing.Size(112, 20);
            this.textBoxGuestLastName.TabIndex = 31;
            // 
            // textBoxGuestFirstName
            // 
            this.textBoxGuestFirstName.Location = new System.Drawing.Point(584, 117);
            this.textBoxGuestFirstName.Name = "textBoxGuestFirstName";
            this.textBoxGuestFirstName.Size = new System.Drawing.Size(112, 20);
            this.textBoxGuestFirstName.TabIndex = 30;
            // 
            // textBoxGuestId
            // 
            this.textBoxGuestId.Location = new System.Drawing.Point(584, 91);
            this.textBoxGuestId.Name = "textBoxGuestId";
            this.textBoxGuestId.Size = new System.Drawing.Size(112, 20);
            this.textBoxGuestId.TabIndex = 28;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(584, 169);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(112, 20);
            this.textBoxPhoneNumber.TabIndex = 32;
            // 
            // FormCatering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 225);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxGuestLastName);
            this.Controls.Add(this.textBoxGuestFirstName);
            this.Controls.Add(this.textBoxGuestId);
            this.Controls.Add(this.buttonShowGuests);
            this.Controls.Add(this.dataGridViewMain);
            this.Name = "FormCatering";
            this.Text = "Zarządzanie kateringiem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button buttonShowGuests;
        private System.Windows.Forms.TextBox textBoxGuestLastName;
        private System.Windows.Forms.TextBox textBoxGuestFirstName;
        private System.Windows.Forms.TextBox textBoxGuestId;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
    }
}