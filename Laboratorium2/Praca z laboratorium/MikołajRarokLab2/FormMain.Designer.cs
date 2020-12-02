
namespace MikołajRarokLab2
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
            this.buttonNew = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxFuel = new System.Windows.Forms.TextBox();
            this.textBoxPlating = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonRandomColor = new System.Windows.Forms.Button();
            this.buttonMilitary = new System.Windows.Forms.Button();
            this.buttonFlying = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.dataGridViewVehicle = new System.Windows.Forms.DataGridView();
            this.buttonFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(12, 12);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(150, 58);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "Nowy obiekt";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 76);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "Nazwa";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(12, 102);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(150, 20);
            this.textBoxSpeed.TabIndex = 2;
            this.textBoxSpeed.Text = "100";
            // 
            // textBoxFuel
            // 
            this.textBoxFuel.Location = new System.Drawing.Point(12, 128);
            this.textBoxFuel.Name = "textBoxFuel";
            this.textBoxFuel.Size = new System.Drawing.Size(150, 20);
            this.textBoxFuel.TabIndex = 3;
            this.textBoxFuel.Text = "50";
            // 
            // textBoxPlating
            // 
            this.textBoxPlating.Location = new System.Drawing.Point(12, 154);
            this.textBoxPlating.Name = "textBoxPlating";
            this.textBoxPlating.Size = new System.Drawing.Size(150, 20);
            this.textBoxPlating.TabIndex = 4;
            this.textBoxPlating.Text = "Poszycie";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(12, 180);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(150, 58);
            this.buttonGo.TabIndex = 5;
            this.buttonGo.Text = "Jedź";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonRandomColor
            // 
            this.buttonRandomColor.Location = new System.Drawing.Point(12, 244);
            this.buttonRandomColor.Name = "buttonRandomColor";
            this.buttonRandomColor.Size = new System.Drawing.Size(150, 58);
            this.buttonRandomColor.TabIndex = 6;
            this.buttonRandomColor.Text = "Wylosuj kolor";
            this.buttonRandomColor.UseVisualStyleBackColor = true;
            this.buttonRandomColor.Click += new System.EventHandler(this.buttonRandomColor_Click);
            // 
            // buttonMilitary
            // 
            this.buttonMilitary.Location = new System.Drawing.Point(12, 308);
            this.buttonMilitary.Name = "buttonMilitary";
            this.buttonMilitary.Size = new System.Drawing.Size(150, 58);
            this.buttonMilitary.TabIndex = 7;
            this.buttonMilitary.Text = "Wojskowy";
            this.buttonMilitary.UseVisualStyleBackColor = true;
            this.buttonMilitary.Click += new System.EventHandler(this.buttonMilitary_Click);
            // 
            // buttonFlying
            // 
            this.buttonFlying.Location = new System.Drawing.Point(12, 372);
            this.buttonFlying.Name = "buttonFlying";
            this.buttonFlying.Size = new System.Drawing.Size(150, 58);
            this.buttonFlying.TabIndex = 8;
            this.buttonFlying.Text = "Latajacy";
            this.buttonFlying.UseVisualStyleBackColor = true;
            this.buttonFlying.Click += new System.EventHandler(this.buttonFlying_Click);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(245, 12);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(150, 58);
            this.buttonList.TabIndex = 9;
            this.buttonList.Text = "Lista obiektów";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // dataGridViewVehicle
            // 
            this.dataGridViewVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicle.Location = new System.Drawing.Point(414, 12);
            this.dataGridViewVehicle.Name = "dataGridViewVehicle";
            this.dataGridViewVehicle.Size = new System.Drawing.Size(284, 287);
            this.dataGridViewVehicle.TabIndex = 10;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(245, 76);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(150, 58);
            this.buttonFind.TabIndex = 11;
            this.buttonFind.Text = "Znajdź na liście";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.dataGridViewVehicle);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonFlying);
            this.Controls.Add(this.buttonMilitary);
            this.Controls.Add(this.buttonRandomColor);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.textBoxPlating);
            this.Controls.Add(this.textBoxFuel);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonNew);
            this.Name = "FormMain";
            this.Text = "Lab2 Obiektowość";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxFuel;
        private System.Windows.Forms.TextBox textBoxPlating;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonRandomColor;
        private System.Windows.Forms.Button buttonMilitary;
        private System.Windows.Forms.Button buttonFlying;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.DataGridView dataGridViewVehicle;
        private System.Windows.Forms.Button buttonFind;
    }
}

