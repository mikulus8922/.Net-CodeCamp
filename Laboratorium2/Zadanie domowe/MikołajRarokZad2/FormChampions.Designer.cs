
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
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.buttonSelectHero = new System.Windows.Forms.Button();
            this.buttonDeleteSelectedChampions = new System.Windows.Forms.Button();
            this.labelChampionClassAbility = new System.Windows.Forms.Label();
            this.labelClassAbilityName = new System.Windows.Forms.Label();
            this.labelChampionTypeAbility = new System.Windows.Forms.Label();
            this.labelTypeAbilityName = new System.Windows.Forms.Label();
            this.labelChampionInteligence = new System.Windows.Forms.Label();
            this.labelInteligenceName = new System.Windows.Forms.Label();
            this.labelChampionDexterity = new System.Windows.Forms.Label();
            this.labelDexterityName = new System.Windows.Forms.Label();
            this.labelChampionDamage = new System.Windows.Forms.Label();
            this.labelDamageName = new System.Windows.Forms.Label();
            this.labelChampionDefence = new System.Windows.Forms.Label();
            this.labelDefenceName = new System.Windows.Forms.Label();
            this.labelChampionHealth = new System.Windows.Forms.Label();
            this.labelHealthName = new System.Windows.Forms.Label();
            this.labelChampionClass = new System.Windows.Forms.Label();
            this.dataGridViewRoster = new System.Windows.Forms.DataGridView();
            this.labelChampionAccuracy = new System.Windows.Forms.Label();
            this.labelAccuracyName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoster)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerateNewChampions
            // 
            this.buttonGenerateNewChampions.Location = new System.Drawing.Point(12, 404);
            this.buttonGenerateNewChampions.Name = "buttonGenerateNewChampions";
            this.buttonGenerateNewChampions.Size = new System.Drawing.Size(140, 59);
            this.buttonGenerateNewChampions.TabIndex = 0;
            this.buttonGenerateNewChampions.Text = "Recruit New Hero";
            this.buttonGenerateNewChampions.UseVisualStyleBackColor = true;
            this.buttonGenerateNewChampions.Click += new System.EventHandler(this.buttonGenerateNewChampions_Click);
            // 
            // buttonSelectHero
            // 
            this.buttonSelectHero.Location = new System.Drawing.Point(158, 404);
            this.buttonSelectHero.Name = "buttonSelectHero";
            this.buttonSelectHero.Size = new System.Drawing.Size(140, 59);
            this.buttonSelectHero.TabIndex = 3;
            this.buttonSelectHero.Text = "Select hero";
            this.buttonSelectHero.UseVisualStyleBackColor = true;
            this.buttonSelectHero.Click += new System.EventHandler(this.buttonSelectHero_Click);
            // 
            // buttonDeleteSelectedChampions
            // 
            this.buttonDeleteSelectedChampions.Location = new System.Drawing.Point(12, 337);
            this.buttonDeleteSelectedChampions.Name = "buttonDeleteSelectedChampions";
            this.buttonDeleteSelectedChampions.Size = new System.Drawing.Size(140, 59);
            this.buttonDeleteSelectedChampions.TabIndex = 5;
            this.buttonDeleteSelectedChampions.Text = "Fire Selected Champion";
            this.buttonDeleteSelectedChampions.UseVisualStyleBackColor = true;
            this.buttonDeleteSelectedChampions.Click += new System.EventHandler(this.buttonDeleteSelectedChampions_Click);
            // 
            // labelChampionClassAbility
            // 
            this.labelChampionClassAbility.Location = new System.Drawing.Point(882, 381);
            this.labelChampionClassAbility.Name = "labelChampionClassAbility";
            this.labelChampionClassAbility.Size = new System.Drawing.Size(75, 30);
            this.labelChampionClassAbility.TabIndex = 58;
            this.labelChampionClassAbility.Text = "\"Power of class ability\"";
            this.labelChampionClassAbility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClassAbilityName
            // 
            this.labelClassAbilityName.Location = new System.Drawing.Point(797, 381);
            this.labelClassAbilityName.Name = "labelClassAbilityName";
            this.labelClassAbilityName.Size = new System.Drawing.Size(75, 30);
            this.labelClassAbilityName.TabIndex = 57;
            this.labelClassAbilityName.Text = "Class Ability";
            this.labelClassAbilityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChampionTypeAbility
            // 
            this.labelChampionTypeAbility.Location = new System.Drawing.Point(882, 351);
            this.labelChampionTypeAbility.Name = "labelChampionTypeAbility";
            this.labelChampionTypeAbility.Size = new System.Drawing.Size(75, 30);
            this.labelChampionTypeAbility.TabIndex = 56;
            this.labelChampionTypeAbility.Text = "\"Power of type ability\"";
            this.labelChampionTypeAbility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTypeAbilityName
            // 
            this.labelTypeAbilityName.Location = new System.Drawing.Point(797, 351);
            this.labelTypeAbilityName.Name = "labelTypeAbilityName";
            this.labelTypeAbilityName.Size = new System.Drawing.Size(75, 30);
            this.labelTypeAbilityName.TabIndex = 55;
            this.labelTypeAbilityName.Text = "Type Ability";
            this.labelTypeAbilityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChampionInteligence
            // 
            this.labelChampionInteligence.Location = new System.Drawing.Point(716, 411);
            this.labelChampionInteligence.Name = "labelChampionInteligence";
            this.labelChampionInteligence.Size = new System.Drawing.Size(75, 30);
            this.labelChampionInteligence.TabIndex = 54;
            this.labelChampionInteligence.Text = "\"Amount of inteligence\"";
            this.labelChampionInteligence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInteligenceName
            // 
            this.labelInteligenceName.Location = new System.Drawing.Point(631, 411);
            this.labelInteligenceName.Name = "labelInteligenceName";
            this.labelInteligenceName.Size = new System.Drawing.Size(75, 30);
            this.labelInteligenceName.TabIndex = 53;
            this.labelInteligenceName.Text = "Inteligence";
            this.labelInteligenceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChampionDexterity
            // 
            this.labelChampionDexterity.Location = new System.Drawing.Point(716, 381);
            this.labelChampionDexterity.Name = "labelChampionDexterity";
            this.labelChampionDexterity.Size = new System.Drawing.Size(75, 30);
            this.labelChampionDexterity.TabIndex = 52;
            this.labelChampionDexterity.Text = "\"Amount of dexterity\"";
            this.labelChampionDexterity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDexterityName
            // 
            this.labelDexterityName.Location = new System.Drawing.Point(631, 381);
            this.labelDexterityName.Name = "labelDexterityName";
            this.labelDexterityName.Size = new System.Drawing.Size(75, 30);
            this.labelDexterityName.TabIndex = 51;
            this.labelDexterityName.Text = "Dexterity";
            this.labelDexterityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChampionDamage
            // 
            this.labelChampionDamage.Location = new System.Drawing.Point(550, 411);
            this.labelChampionDamage.Name = "labelChampionDamage";
            this.labelChampionDamage.Size = new System.Drawing.Size(75, 30);
            this.labelChampionDamage.TabIndex = 50;
            this.labelChampionDamage.Text = "\"Amount of damage\"";
            this.labelChampionDamage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDamageName
            // 
            this.labelDamageName.Location = new System.Drawing.Point(465, 411);
            this.labelDamageName.Name = "labelDamageName";
            this.labelDamageName.Size = new System.Drawing.Size(75, 30);
            this.labelDamageName.TabIndex = 49;
            this.labelDamageName.Text = "Damage";
            this.labelDamageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChampionDefence
            // 
            this.labelChampionDefence.Location = new System.Drawing.Point(550, 381);
            this.labelChampionDefence.Name = "labelChampionDefence";
            this.labelChampionDefence.Size = new System.Drawing.Size(75, 30);
            this.labelChampionDefence.TabIndex = 48;
            this.labelChampionDefence.Text = "\"Amount of defence\"";
            this.labelChampionDefence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDefenceName
            // 
            this.labelDefenceName.Location = new System.Drawing.Point(465, 381);
            this.labelDefenceName.Name = "labelDefenceName";
            this.labelDefenceName.Size = new System.Drawing.Size(75, 30);
            this.labelDefenceName.TabIndex = 47;
            this.labelDefenceName.Text = "Defence";
            this.labelDefenceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChampionHealth
            // 
            this.labelChampionHealth.Location = new System.Drawing.Point(550, 351);
            this.labelChampionHealth.Name = "labelChampionHealth";
            this.labelChampionHealth.Size = new System.Drawing.Size(75, 30);
            this.labelChampionHealth.TabIndex = 46;
            this.labelChampionHealth.Text = "\"Amount of health\"";
            this.labelChampionHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHealthName
            // 
            this.labelHealthName.Location = new System.Drawing.Point(465, 351);
            this.labelHealthName.Name = "labelHealthName";
            this.labelHealthName.Size = new System.Drawing.Size(75, 30);
            this.labelHealthName.TabIndex = 45;
            this.labelHealthName.Text = "Health";
            this.labelHealthName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChampionClass
            // 
            this.labelChampionClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelChampionClass.Location = new System.Drawing.Point(631, 283);
            this.labelChampionClass.Name = "labelChampionClass";
            this.labelChampionClass.Size = new System.Drawing.Size(160, 45);
            this.labelChampionClass.TabIndex = 44;
            this.labelChampionClass.Text = "Selected Champion Class";
            this.labelChampionClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewRoster
            // 
            this.dataGridViewRoster.AllowUserToAddRows = false;
            this.dataGridViewRoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoster.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRoster.Name = "dataGridViewRoster";
            this.dataGridViewRoster.ReadOnly = true;
            this.dataGridViewRoster.Size = new System.Drawing.Size(943, 249);
            this.dataGridViewRoster.TabIndex = 59;
            // 
            // labelChampionAccuracy
            // 
            this.labelChampionAccuracy.Location = new System.Drawing.Point(716, 351);
            this.labelChampionAccuracy.Name = "labelChampionAccuracy";
            this.labelChampionAccuracy.Size = new System.Drawing.Size(75, 30);
            this.labelChampionAccuracy.TabIndex = 63;
            this.labelChampionAccuracy.Text = "\"Amount of accuracy\"";
            this.labelChampionAccuracy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAccuracyName
            // 
            this.labelAccuracyName.Location = new System.Drawing.Point(631, 351);
            this.labelAccuracyName.Name = "labelAccuracyName";
            this.labelAccuracyName.Size = new System.Drawing.Size(75, 30);
            this.labelAccuracyName.TabIndex = 62;
            this.labelAccuracyName.Text = "Accuracy";
            this.labelAccuracyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormChampions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 475);
            this.Controls.Add(this.labelChampionAccuracy);
            this.Controls.Add(this.labelAccuracyName);
            this.Controls.Add(this.dataGridViewRoster);
            this.Controls.Add(this.labelChampionClassAbility);
            this.Controls.Add(this.labelClassAbilityName);
            this.Controls.Add(this.labelChampionTypeAbility);
            this.Controls.Add(this.labelTypeAbilityName);
            this.Controls.Add(this.labelChampionInteligence);
            this.Controls.Add(this.labelInteligenceName);
            this.Controls.Add(this.labelChampionDexterity);
            this.Controls.Add(this.labelDexterityName);
            this.Controls.Add(this.labelChampionDamage);
            this.Controls.Add(this.labelDamageName);
            this.Controls.Add(this.labelChampionDefence);
            this.Controls.Add(this.labelDefenceName);
            this.Controls.Add(this.labelChampionHealth);
            this.Controls.Add(this.labelHealthName);
            this.Controls.Add(this.labelChampionClass);
            this.Controls.Add(this.buttonDeleteSelectedChampions);
            this.Controls.Add(this.buttonSelectHero);
            this.Controls.Add(this.buttonGenerateNewChampions);
            this.Name = "FormChampions";
            this.Text = "Champions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateNewChampions;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button buttonSelectHero;
        private System.Windows.Forms.Button buttonDeleteSelectedChampions;
        private System.Windows.Forms.Label labelChampionClassAbility;
        private System.Windows.Forms.Label labelClassAbilityName;
        private System.Windows.Forms.Label labelChampionTypeAbility;
        private System.Windows.Forms.Label labelTypeAbilityName;
        private System.Windows.Forms.Label labelChampionInteligence;
        private System.Windows.Forms.Label labelInteligenceName;
        private System.Windows.Forms.Label labelChampionDexterity;
        private System.Windows.Forms.Label labelDexterityName;
        private System.Windows.Forms.Label labelChampionDamage;
        private System.Windows.Forms.Label labelDamageName;
        private System.Windows.Forms.Label labelChampionDefence;
        private System.Windows.Forms.Label labelDefenceName;
        private System.Windows.Forms.Label labelChampionHealth;
        private System.Windows.Forms.Label labelHealthName;
        private System.Windows.Forms.Label labelChampionClass;
        private System.Windows.Forms.DataGridView dataGridViewRoster;
        private System.Windows.Forms.Label labelChampionAccuracy;
        private System.Windows.Forms.Label labelAccuracyName;
    }
}

