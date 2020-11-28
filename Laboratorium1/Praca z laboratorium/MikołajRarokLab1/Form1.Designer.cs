
namespace MikołajRarokLab1
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
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonChangeOtherButton2 = new System.Windows.Forms.Button();
            this.buttonChangeOtherButton1 = new System.Windows.Forms.Button();
            this.textBoxCounter = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonTextboxColorChange = new System.Windows.Forms.Button();
            this.textBoxMultipy1 = new System.Windows.Forms.TextBox();
            this.MultiplyTwoTextboxes = new System.Windows.Forms.Button();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonNewWindow = new System.Windows.Forms.Button();
            this.textBoxMultiply2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(12, 19);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(113, 62);
            this.buttonColor.TabIndex = 0;
            this.buttonColor.Text = "Zmień Kolor Przycisku i Tła";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonChangeOtherButton2
            // 
            this.buttonChangeOtherButton2.Location = new System.Drawing.Point(12, 367);
            this.buttonChangeOtherButton2.Name = "buttonChangeOtherButton2";
            this.buttonChangeOtherButton2.Size = new System.Drawing.Size(113, 67);
            this.buttonChangeOtherButton2.TabIndex = 1;
            this.buttonChangeOtherButton2.Text = "Zmień kolor przycisku powyżej";
            this.buttonChangeOtherButton2.UseVisualStyleBackColor = true;
            this.buttonChangeOtherButton2.Click += new System.EventHandler(this.buttonChangeOtherButton2_Click);
            // 
            // buttonChangeOtherButton1
            // 
            this.buttonChangeOtherButton1.Location = new System.Drawing.Point(12, 288);
            this.buttonChangeOtherButton1.Name = "buttonChangeOtherButton1";
            this.buttonChangeOtherButton1.Size = new System.Drawing.Size(113, 67);
            this.buttonChangeOtherButton1.TabIndex = 2;
            this.buttonChangeOtherButton1.Text = "Zmien kolor przycisku poniżej";
            this.buttonChangeOtherButton1.UseVisualStyleBackColor = true;
            this.buttonChangeOtherButton1.Click += new System.EventHandler(this.buttonChangeOtherButton1_Click);
            // 
            // textBoxCounter
            // 
            this.textBoxCounter.Location = new System.Drawing.Point(433, 41);
            this.textBoxCounter.Name = "textBoxCounter";
            this.textBoxCounter.Size = new System.Drawing.Size(113, 20);
            this.textBoxCounter.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(433, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(113, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Dodaj do licznika";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonTextboxColorChange
            // 
            this.buttonTextboxColorChange.Location = new System.Drawing.Point(433, 67);
            this.buttonTextboxColorChange.Name = "buttonTextboxColorChange";
            this.buttonTextboxColorChange.Size = new System.Drawing.Size(113, 70);
            this.buttonTextboxColorChange.TabIndex = 5;
            this.buttonTextboxColorChange.Text = "Przycisk zmieniajacy kolor na podstawie wartości licznika";
            this.buttonTextboxColorChange.UseVisualStyleBackColor = true;
            this.buttonTextboxColorChange.Click += new System.EventHandler(this.buttonTextboxColorChange_Click);
            // 
            // textBoxMultipy1
            // 
            this.textBoxMultipy1.Location = new System.Drawing.Point(433, 187);
            this.textBoxMultipy1.Name = "textBoxMultipy1";
            this.textBoxMultipy1.Size = new System.Drawing.Size(113, 20);
            this.textBoxMultipy1.TabIndex = 6;
            // 
            // MultiplyTwoTextboxes
            // 
            this.MultiplyTwoTextboxes.Location = new System.Drawing.Point(433, 213);
            this.MultiplyTwoTextboxes.Name = "MultiplyTwoTextboxes";
            this.MultiplyTwoTextboxes.Size = new System.Drawing.Size(113, 58);
            this.MultiplyTwoTextboxes.TabIndex = 7;
            this.MultiplyTwoTextboxes.Text = "Pomnóż liczbę powyżej z liczbą poniżej";
            this.MultiplyTwoTextboxes.UseVisualStyleBackColor = true;
            this.MultiplyTwoTextboxes.Click += new System.EventHandler(this.MultiplyTwoTextboxes_Click);
            // 
            // timerCounter
            // 
            this.timerCounter.Tick += new System.EventHandler(this.timerCounter_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(433, 367);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(113, 67);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Uruchom Timer";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonNewWindow
            // 
            this.buttonNewWindow.Location = new System.Drawing.Point(223, 385);
            this.buttonNewWindow.Name = "buttonNewWindow";
            this.buttonNewWindow.Size = new System.Drawing.Size(113, 49);
            this.buttonNewWindow.TabIndex = 9;
            this.buttonNewWindow.Text = "Nowe Okno";
            this.buttonNewWindow.UseVisualStyleBackColor = true;
            this.buttonNewWindow.Click += new System.EventHandler(this.buttonNewWindow_Click);
            // 
            // textBoxMultiply2
            // 
            this.textBoxMultiply2.Location = new System.Drawing.Point(433, 277);
            this.textBoxMultiply2.Name = "textBoxMultiply2";
            this.textBoxMultiply2.Size = new System.Drawing.Size(113, 20);
            this.textBoxMultiply2.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 446);
            this.Controls.Add(this.textBoxMultiply2);
            this.Controls.Add(this.buttonNewWindow);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.MultiplyTwoTextboxes);
            this.Controls.Add(this.textBoxMultipy1);
            this.Controls.Add(this.buttonTextboxColorChange);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxCounter);
            this.Controls.Add(this.buttonChangeOtherButton1);
            this.Controls.Add(this.buttonChangeOtherButton2);
            this.Controls.Add(this.buttonColor);
            this.Name = "FormMain";
            this.Text = "Program Laboratorium 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonChangeOtherButton2;
        private System.Windows.Forms.Button buttonChangeOtherButton1;
        private System.Windows.Forms.TextBox textBoxCounter;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonTextboxColorChange;
        private System.Windows.Forms.TextBox textBoxMultipy1;
        private System.Windows.Forms.Button MultiplyTwoTextboxes;
        private System.Windows.Forms.Timer timerCounter;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonNewWindow;
        private System.Windows.Forms.TextBox textBoxMultiply2;
    }
}

