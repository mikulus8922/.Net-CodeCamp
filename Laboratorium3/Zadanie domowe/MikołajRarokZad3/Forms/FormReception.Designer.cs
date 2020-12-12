
namespace MikołajRarokZad3.Forms
{
    partial class FormReception
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
            this.buttonShowRooms = new System.Windows.Forms.Button();
            this.buttonEditRoom = new System.Windows.Forms.Button();
            this.textBoxRoomId = new System.Windows.Forms.TextBox();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.textBoxRoomFloor = new System.Windows.Forms.TextBox();
            this.textBoxRoomCapacity = new System.Windows.Forms.TextBox();
            this.buttonShowBlacklist = new System.Windows.Forms.Button();
            this.buttonAddToBlacklist = new System.Windows.Forms.Button();
            this.buttonRemoveFromBlacklist = new System.Windows.Forms.Button();
            this.buttonEditBlacklist = new System.Windows.Forms.Button();
            this.textBoxBlacklistPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxBlacklistLastName = new System.Windows.Forms.TextBox();
            this.textBoxBlacklistFirstName = new System.Windows.Forms.TextBox();
            this.textBoxBlacklistId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(776, 209);
            this.dataGridViewMain.TabIndex = 0;
            // 
            // buttonShowRooms
            // 
            this.buttonShowRooms.Location = new System.Drawing.Point(12, 227);
            this.buttonShowRooms.Name = "buttonShowRooms";
            this.buttonShowRooms.Size = new System.Drawing.Size(112, 42);
            this.buttonShowRooms.TabIndex = 1;
            this.buttonShowRooms.Text = "Wyświetl Pokoje";
            this.buttonShowRooms.UseVisualStyleBackColor = true;
            this.buttonShowRooms.Click += new System.EventHandler(this.buttonShowRooms_Click);
            // 
            // buttonEditRoom
            // 
            this.buttonEditRoom.Location = new System.Drawing.Point(12, 275);
            this.buttonEditRoom.Name = "buttonEditRoom";
            this.buttonEditRoom.Size = new System.Drawing.Size(112, 42);
            this.buttonEditRoom.TabIndex = 2;
            this.buttonEditRoom.Text = "Edytuj rozmiar pokoju";
            this.buttonEditRoom.UseVisualStyleBackColor = true;
            this.buttonEditRoom.Click += new System.EventHandler(this.buttonEditRoom_Click);
            // 
            // textBoxRoomId
            // 
            this.textBoxRoomId.Location = new System.Drawing.Point(148, 232);
            this.textBoxRoomId.Name = "textBoxRoomId";
            this.textBoxRoomId.Size = new System.Drawing.Size(100, 20);
            this.textBoxRoomId.TabIndex = 3;
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(148, 258);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxRoomNumber.TabIndex = 4;
            // 
            // textBoxRoomFloor
            // 
            this.textBoxRoomFloor.Location = new System.Drawing.Point(148, 310);
            this.textBoxRoomFloor.Name = "textBoxRoomFloor";
            this.textBoxRoomFloor.Size = new System.Drawing.Size(100, 20);
            this.textBoxRoomFloor.TabIndex = 7;
            // 
            // textBoxRoomCapacity
            // 
            this.textBoxRoomCapacity.Location = new System.Drawing.Point(148, 284);
            this.textBoxRoomCapacity.Name = "textBoxRoomCapacity";
            this.textBoxRoomCapacity.Size = new System.Drawing.Size(100, 20);
            this.textBoxRoomCapacity.TabIndex = 6;
            // 
            // buttonShowBlacklist
            // 
            this.buttonShowBlacklist.Location = new System.Drawing.Point(285, 227);
            this.buttonShowBlacklist.Name = "buttonShowBlacklist";
            this.buttonShowBlacklist.Size = new System.Drawing.Size(112, 42);
            this.buttonShowBlacklist.TabIndex = 8;
            this.buttonShowBlacklist.Text = "Wyświetl Blacklistę";
            this.buttonShowBlacklist.UseVisualStyleBackColor = true;
            this.buttonShowBlacklist.Click += new System.EventHandler(this.buttonShowBlacklist_Click);
            // 
            // buttonAddToBlacklist
            // 
            this.buttonAddToBlacklist.Location = new System.Drawing.Point(285, 275);
            this.buttonAddToBlacklist.Name = "buttonAddToBlacklist";
            this.buttonAddToBlacklist.Size = new System.Drawing.Size(112, 42);
            this.buttonAddToBlacklist.TabIndex = 9;
            this.buttonAddToBlacklist.Text = "Dodaj do blacklisty";
            this.buttonAddToBlacklist.UseVisualStyleBackColor = true;
            this.buttonAddToBlacklist.Click += new System.EventHandler(this.buttonAddToBlacklist_Click);
            // 
            // buttonRemoveFromBlacklist
            // 
            this.buttonRemoveFromBlacklist.Location = new System.Drawing.Point(285, 323);
            this.buttonRemoveFromBlacklist.Name = "buttonRemoveFromBlacklist";
            this.buttonRemoveFromBlacklist.Size = new System.Drawing.Size(112, 42);
            this.buttonRemoveFromBlacklist.TabIndex = 10;
            this.buttonRemoveFromBlacklist.Text = "Usuń z blacklisty";
            this.buttonRemoveFromBlacklist.UseVisualStyleBackColor = true;
            this.buttonRemoveFromBlacklist.Click += new System.EventHandler(this.buttonRemoveFromBlacklist_Click);
            // 
            // buttonEditBlacklist
            // 
            this.buttonEditBlacklist.Location = new System.Drawing.Point(285, 371);
            this.buttonEditBlacklist.Name = "buttonEditBlacklist";
            this.buttonEditBlacklist.Size = new System.Drawing.Size(112, 42);
            this.buttonEditBlacklist.TabIndex = 11;
            this.buttonEditBlacklist.Text = "Edytuj osobę z blacklisty";
            this.buttonEditBlacklist.UseVisualStyleBackColor = true;
            this.buttonEditBlacklist.Click += new System.EventHandler(this.buttonEditBlacklist_Click);
            // 
            // textBoxBlacklistPhoneNumber
            // 
            this.textBoxBlacklistPhoneNumber.Location = new System.Drawing.Point(413, 310);
            this.textBoxBlacklistPhoneNumber.Name = "textBoxBlacklistPhoneNumber";
            this.textBoxBlacklistPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxBlacklistPhoneNumber.TabIndex = 15;
            // 
            // textBoxBlacklistLastName
            // 
            this.textBoxBlacklistLastName.Location = new System.Drawing.Point(413, 284);
            this.textBoxBlacklistLastName.Name = "textBoxBlacklistLastName";
            this.textBoxBlacklistLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxBlacklistLastName.TabIndex = 14;
            // 
            // textBoxBlacklistFirstName
            // 
            this.textBoxBlacklistFirstName.Location = new System.Drawing.Point(413, 258);
            this.textBoxBlacklistFirstName.Name = "textBoxBlacklistFirstName";
            this.textBoxBlacklistFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxBlacklistFirstName.TabIndex = 13;
            // 
            // textBoxBlacklistId
            // 
            this.textBoxBlacklistId.Location = new System.Drawing.Point(413, 232);
            this.textBoxBlacklistId.Name = "textBoxBlacklistId";
            this.textBoxBlacklistId.Size = new System.Drawing.Size(100, 20);
            this.textBoxBlacklistId.TabIndex = 12;
            // 
            // FormReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxBlacklistPhoneNumber);
            this.Controls.Add(this.textBoxBlacklistLastName);
            this.Controls.Add(this.textBoxBlacklistFirstName);
            this.Controls.Add(this.textBoxBlacklistId);
            this.Controls.Add(this.buttonEditBlacklist);
            this.Controls.Add(this.buttonRemoveFromBlacklist);
            this.Controls.Add(this.buttonAddToBlacklist);
            this.Controls.Add(this.buttonShowBlacklist);
            this.Controls.Add(this.textBoxRoomFloor);
            this.Controls.Add(this.textBoxRoomCapacity);
            this.Controls.Add(this.textBoxRoomNumber);
            this.Controls.Add(this.textBoxRoomId);
            this.Controls.Add(this.buttonEditRoom);
            this.Controls.Add(this.buttonShowRooms);
            this.Controls.Add(this.dataGridViewMain);
            this.Name = "FormReception";
            this.Text = "Recepcja";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button buttonShowRooms;
        private System.Windows.Forms.Button buttonEditRoom;
        private System.Windows.Forms.TextBox textBoxRoomId;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.TextBox textBoxRoomFloor;
        private System.Windows.Forms.TextBox textBoxRoomCapacity;
        private System.Windows.Forms.Button buttonShowBlacklist;
        private System.Windows.Forms.Button buttonAddToBlacklist;
        private System.Windows.Forms.Button buttonRemoveFromBlacklist;
        private System.Windows.Forms.Button buttonEditBlacklist;
        private System.Windows.Forms.TextBox textBoxBlacklistPhoneNumber;
        private System.Windows.Forms.TextBox textBoxBlacklistLastName;
        private System.Windows.Forms.TextBox textBoxBlacklistFirstName;
        private System.Windows.Forms.TextBox textBoxBlacklistId;
    }
}