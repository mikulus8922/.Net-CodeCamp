
namespace MikołajRarokZad3.Forms
{
    partial class FormAdmin
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
            this.textBoxWorkerWorkPosition = new System.Windows.Forms.TextBox();
            this.textBoxWorkerLastName = new System.Windows.Forms.TextBox();
            this.textBoxWorkerFirstName = new System.Windows.Forms.TextBox();
            this.textBoxWorkerId = new System.Windows.Forms.TextBox();
            this.buttonEditWorker = new System.Windows.Forms.Button();
            this.buttonRemoveWorker = new System.Windows.Forms.Button();
            this.buttonAddWorker = new System.Windows.Forms.Button();
            this.buttonShowWorkers = new System.Windows.Forms.Button();
            this.buttonEditGuest = new System.Windows.Forms.Button();
            this.buttonRemoveGuest = new System.Windows.Forms.Button();
            this.buttonAddGuest = new System.Windows.Forms.Button();
            this.buttonShowGuests = new System.Windows.Forms.Button();
            this.textBoxGuestLastName = new System.Windows.Forms.TextBox();
            this.textBoxGuestFirstName = new System.Windows.Forms.TextBox();
            this.textBoxGuestRoomNumber = new System.Windows.Forms.TextBox();
            this.textBoxGuestId = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelRoomFloor = new System.Windows.Forms.Label();
            this.labelRoomCapacity = new System.Windows.Forms.Label();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.labelRoomId = new System.Windows.Forms.Label();
            this.labelBlacklistPhoneNumber = new System.Windows.Forms.Label();
            this.labelBlacklistLastName = new System.Windows.Forms.Label();
            this.labelBlacklistFirstName = new System.Windows.Forms.Label();
            this.labelBlacklistId = new System.Windows.Forms.Label();
            this.labelGuestPhoneNumber = new System.Windows.Forms.Label();
            this.labelGuestLastName = new System.Windows.Forms.Label();
            this.labelGuestFirstName = new System.Windows.Forms.Label();
            this.labelGuestRoomNumber = new System.Windows.Forms.Label();
            this.labelGuestId = new System.Windows.Forms.Label();
            this.labelWorkerId = new System.Windows.Forms.Label();
            this.labelWorkerFirsName = new System.Windows.Forms.Label();
            this.labelWorkerLastName = new System.Windows.Forms.Label();
            this.labelWorkerPosition = new System.Windows.Forms.Label();
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
            this.buttonShowRooms.Location = new System.Drawing.Point(16, 286);
            this.buttonShowRooms.Name = "buttonShowRooms";
            this.buttonShowRooms.Size = new System.Drawing.Size(112, 42);
            this.buttonShowRooms.TabIndex = 1;
            this.buttonShowRooms.Text = "Wyświetl Pokoje";
            this.buttonShowRooms.UseVisualStyleBackColor = true;
            this.buttonShowRooms.Click += new System.EventHandler(this.buttonShowRooms_Click);
            // 
            // buttonEditRoom
            // 
            this.buttonEditRoom.Location = new System.Drawing.Point(16, 334);
            this.buttonEditRoom.Name = "buttonEditRoom";
            this.buttonEditRoom.Size = new System.Drawing.Size(112, 42);
            this.buttonEditRoom.TabIndex = 2;
            this.buttonEditRoom.Text = "Edytuj rozmiar pokoju";
            this.buttonEditRoom.UseVisualStyleBackColor = true;
            this.buttonEditRoom.Click += new System.EventHandler(this.buttonEditRoom_Click);
            // 
            // textBoxRoomId
            // 
            this.textBoxRoomId.Location = new System.Drawing.Point(148, 255);
            this.textBoxRoomId.Name = "textBoxRoomId";
            this.textBoxRoomId.Size = new System.Drawing.Size(108, 20);
            this.textBoxRoomId.TabIndex = 3;
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(148, 301);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(108, 20);
            this.textBoxRoomNumber.TabIndex = 4;
            // 
            // textBoxRoomFloor
            // 
            this.textBoxRoomFloor.Location = new System.Drawing.Point(148, 393);
            this.textBoxRoomFloor.Name = "textBoxRoomFloor";
            this.textBoxRoomFloor.Size = new System.Drawing.Size(108, 20);
            this.textBoxRoomFloor.TabIndex = 7;
            // 
            // textBoxRoomCapacity
            // 
            this.textBoxRoomCapacity.Location = new System.Drawing.Point(148, 347);
            this.textBoxRoomCapacity.Name = "textBoxRoomCapacity";
            this.textBoxRoomCapacity.Size = new System.Drawing.Size(108, 20);
            this.textBoxRoomCapacity.TabIndex = 6;
            // 
            // buttonShowBlacklist
            // 
            this.buttonShowBlacklist.Location = new System.Drawing.Point(281, 227);
            this.buttonShowBlacklist.Name = "buttonShowBlacklist";
            this.buttonShowBlacklist.Size = new System.Drawing.Size(112, 42);
            this.buttonShowBlacklist.TabIndex = 8;
            this.buttonShowBlacklist.Text = "Wyświetl Blacklistę";
            this.buttonShowBlacklist.UseVisualStyleBackColor = true;
            this.buttonShowBlacklist.Click += new System.EventHandler(this.buttonShowBlacklist_Click);
            // 
            // buttonAddToBlacklist
            // 
            this.buttonAddToBlacklist.Location = new System.Drawing.Point(281, 275);
            this.buttonAddToBlacklist.Name = "buttonAddToBlacklist";
            this.buttonAddToBlacklist.Size = new System.Drawing.Size(112, 42);
            this.buttonAddToBlacklist.TabIndex = 9;
            this.buttonAddToBlacklist.Text = "Dodaj do blacklisty";
            this.buttonAddToBlacklist.UseVisualStyleBackColor = true;
            this.buttonAddToBlacklist.Click += new System.EventHandler(this.buttonAddToBlacklist_Click);
            // 
            // buttonRemoveFromBlacklist
            // 
            this.buttonRemoveFromBlacklist.Location = new System.Drawing.Point(281, 323);
            this.buttonRemoveFromBlacklist.Name = "buttonRemoveFromBlacklist";
            this.buttonRemoveFromBlacklist.Size = new System.Drawing.Size(112, 42);
            this.buttonRemoveFromBlacklist.TabIndex = 10;
            this.buttonRemoveFromBlacklist.Text = "Usuń z blacklisty";
            this.buttonRemoveFromBlacklist.UseVisualStyleBackColor = true;
            this.buttonRemoveFromBlacklist.Click += new System.EventHandler(this.buttonRemoveFromBlacklist_Click);
            // 
            // buttonEditBlacklist
            // 
            this.buttonEditBlacklist.Location = new System.Drawing.Point(281, 371);
            this.buttonEditBlacklist.Name = "buttonEditBlacklist";
            this.buttonEditBlacklist.Size = new System.Drawing.Size(112, 42);
            this.buttonEditBlacklist.TabIndex = 11;
            this.buttonEditBlacklist.Text = "Edytuj osobę z blacklisty";
            this.buttonEditBlacklist.UseVisualStyleBackColor = true;
            this.buttonEditBlacklist.Click += new System.EventHandler(this.buttonEditBlacklist_Click);
            // 
            // textBoxBlacklistPhoneNumber
            // 
            this.textBoxBlacklistPhoneNumber.Location = new System.Drawing.Point(413, 393);
            this.textBoxBlacklistPhoneNumber.Name = "textBoxBlacklistPhoneNumber";
            this.textBoxBlacklistPhoneNumber.Size = new System.Drawing.Size(108, 20);
            this.textBoxBlacklistPhoneNumber.TabIndex = 15;
            // 
            // textBoxBlacklistLastName
            // 
            this.textBoxBlacklistLastName.Location = new System.Drawing.Point(413, 347);
            this.textBoxBlacklistLastName.Name = "textBoxBlacklistLastName";
            this.textBoxBlacklistLastName.Size = new System.Drawing.Size(108, 20);
            this.textBoxBlacklistLastName.TabIndex = 14;
            // 
            // textBoxBlacklistFirstName
            // 
            this.textBoxBlacklistFirstName.Location = new System.Drawing.Point(413, 301);
            this.textBoxBlacklistFirstName.Name = "textBoxBlacklistFirstName";
            this.textBoxBlacklistFirstName.Size = new System.Drawing.Size(108, 20);
            this.textBoxBlacklistFirstName.TabIndex = 13;
            // 
            // textBoxBlacklistId
            // 
            this.textBoxBlacklistId.Location = new System.Drawing.Point(413, 255);
            this.textBoxBlacklistId.Name = "textBoxBlacklistId";
            this.textBoxBlacklistId.Size = new System.Drawing.Size(108, 20);
            this.textBoxBlacklistId.TabIndex = 12;
            // 
            // textBoxWorkerWorkPosition
            // 
            this.textBoxWorkerWorkPosition.Location = new System.Drawing.Point(366, 485);
            this.textBoxWorkerWorkPosition.Name = "textBoxWorkerWorkPosition";
            this.textBoxWorkerWorkPosition.Size = new System.Drawing.Size(112, 20);
            this.textBoxWorkerWorkPosition.TabIndex = 23;
            // 
            // textBoxWorkerLastName
            // 
            this.textBoxWorkerLastName.Location = new System.Drawing.Point(248, 485);
            this.textBoxWorkerLastName.Name = "textBoxWorkerLastName";
            this.textBoxWorkerLastName.Size = new System.Drawing.Size(112, 20);
            this.textBoxWorkerLastName.TabIndex = 22;
            // 
            // textBoxWorkerFirstName
            // 
            this.textBoxWorkerFirstName.Location = new System.Drawing.Point(130, 485);
            this.textBoxWorkerFirstName.Name = "textBoxWorkerFirstName";
            this.textBoxWorkerFirstName.Size = new System.Drawing.Size(112, 20);
            this.textBoxWorkerFirstName.TabIndex = 21;
            // 
            // textBoxWorkerId
            // 
            this.textBoxWorkerId.Location = new System.Drawing.Point(12, 485);
            this.textBoxWorkerId.Name = "textBoxWorkerId";
            this.textBoxWorkerId.Size = new System.Drawing.Size(112, 20);
            this.textBoxWorkerId.TabIndex = 20;
            // 
            // buttonEditWorker
            // 
            this.buttonEditWorker.Location = new System.Drawing.Point(366, 518);
            this.buttonEditWorker.Name = "buttonEditWorker";
            this.buttonEditWorker.Size = new System.Drawing.Size(112, 42);
            this.buttonEditWorker.TabIndex = 19;
            this.buttonEditWorker.Text = "Edytuj pracownika";
            this.buttonEditWorker.UseVisualStyleBackColor = true;
            this.buttonEditWorker.Click += new System.EventHandler(this.buttonEditWorker_Click);
            // 
            // buttonRemoveWorker
            // 
            this.buttonRemoveWorker.Location = new System.Drawing.Point(248, 518);
            this.buttonRemoveWorker.Name = "buttonRemoveWorker";
            this.buttonRemoveWorker.Size = new System.Drawing.Size(112, 42);
            this.buttonRemoveWorker.TabIndex = 18;
            this.buttonRemoveWorker.Text = "Usuń pracownika";
            this.buttonRemoveWorker.UseVisualStyleBackColor = true;
            this.buttonRemoveWorker.Click += new System.EventHandler(this.buttonRemoveWorker_Click);
            // 
            // buttonAddWorker
            // 
            this.buttonAddWorker.Location = new System.Drawing.Point(130, 518);
            this.buttonAddWorker.Name = "buttonAddWorker";
            this.buttonAddWorker.Size = new System.Drawing.Size(112, 42);
            this.buttonAddWorker.TabIndex = 17;
            this.buttonAddWorker.Text = "Dodaj pracownika";
            this.buttonAddWorker.UseVisualStyleBackColor = true;
            this.buttonAddWorker.Click += new System.EventHandler(this.buttonAddWorker_Click);
            // 
            // buttonShowWorkers
            // 
            this.buttonShowWorkers.Location = new System.Drawing.Point(12, 518);
            this.buttonShowWorkers.Name = "buttonShowWorkers";
            this.buttonShowWorkers.Size = new System.Drawing.Size(112, 42);
            this.buttonShowWorkers.TabIndex = 16;
            this.buttonShowWorkers.Text = "Wyświetl Pracowników";
            this.buttonShowWorkers.UseVisualStyleBackColor = true;
            this.buttonShowWorkers.Click += new System.EventHandler(this.buttonShowWorkers_Click);
            // 
            // buttonEditGuest
            // 
            this.buttonEditGuest.Location = new System.Drawing.Point(542, 371);
            this.buttonEditGuest.Name = "buttonEditGuest";
            this.buttonEditGuest.Size = new System.Drawing.Size(112, 42);
            this.buttonEditGuest.TabIndex = 27;
            this.buttonEditGuest.Text = "Edytuj gościa (not working)";
            this.buttonEditGuest.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveGuest
            // 
            this.buttonRemoveGuest.Location = new System.Drawing.Point(542, 323);
            this.buttonRemoveGuest.Name = "buttonRemoveGuest";
            this.buttonRemoveGuest.Size = new System.Drawing.Size(112, 42);
            this.buttonRemoveGuest.TabIndex = 26;
            this.buttonRemoveGuest.Text = "Usuń gościa (not working)";
            this.buttonRemoveGuest.UseVisualStyleBackColor = true;
            // 
            // buttonAddGuest
            // 
            this.buttonAddGuest.Location = new System.Drawing.Point(542, 275);
            this.buttonAddGuest.Name = "buttonAddGuest";
            this.buttonAddGuest.Size = new System.Drawing.Size(112, 42);
            this.buttonAddGuest.TabIndex = 25;
            this.buttonAddGuest.Text = "Dodaj gościa (not working)";
            this.buttonAddGuest.UseVisualStyleBackColor = true;
            // 
            // buttonShowGuests
            // 
            this.buttonShowGuests.Location = new System.Drawing.Point(542, 227);
            this.buttonShowGuests.Name = "buttonShowGuests";
            this.buttonShowGuests.Size = new System.Drawing.Size(112, 42);
            this.buttonShowGuests.TabIndex = 24;
            this.buttonShowGuests.Text = "Wyświetl Gości";
            this.buttonShowGuests.UseVisualStyleBackColor = true;
            this.buttonShowGuests.Click += new System.EventHandler(this.buttonShowGuests_Click);
            // 
            // textBoxGuestLastName
            // 
            this.textBoxGuestLastName.Location = new System.Drawing.Point(672, 393);
            this.textBoxGuestLastName.Name = "textBoxGuestLastName";
            this.textBoxGuestLastName.Size = new System.Drawing.Size(116, 20);
            this.textBoxGuestLastName.TabIndex = 31;
            // 
            // textBoxGuestFirstName
            // 
            this.textBoxGuestFirstName.Location = new System.Drawing.Point(672, 347);
            this.textBoxGuestFirstName.Name = "textBoxGuestFirstName";
            this.textBoxGuestFirstName.Size = new System.Drawing.Size(116, 20);
            this.textBoxGuestFirstName.TabIndex = 30;
            // 
            // textBoxGuestRoomNumber
            // 
            this.textBoxGuestRoomNumber.Location = new System.Drawing.Point(672, 301);
            this.textBoxGuestRoomNumber.Name = "textBoxGuestRoomNumber";
            this.textBoxGuestRoomNumber.Size = new System.Drawing.Size(116, 20);
            this.textBoxGuestRoomNumber.TabIndex = 29;
            // 
            // textBoxGuestId
            // 
            this.textBoxGuestId.Location = new System.Drawing.Point(672, 255);
            this.textBoxGuestId.Name = "textBoxGuestId";
            this.textBoxGuestId.Size = new System.Drawing.Size(116, 20);
            this.textBoxGuestId.TabIndex = 28;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(672, 439);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(116, 20);
            this.textBoxPhoneNumber.TabIndex = 32;
            // 
            // labelRoomFloor
            // 
            this.labelRoomFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRoomFloor.Location = new System.Drawing.Point(148, 370);
            this.labelRoomFloor.Name = "labelRoomFloor";
            this.labelRoomFloor.Size = new System.Drawing.Size(108, 20);
            this.labelRoomFloor.TabIndex = 49;
            this.labelRoomFloor.Text = "Piętro";
            this.labelRoomFloor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRoomCapacity
            // 
            this.labelRoomCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRoomCapacity.Location = new System.Drawing.Point(148, 324);
            this.labelRoomCapacity.Name = "labelRoomCapacity";
            this.labelRoomCapacity.Size = new System.Drawing.Size(108, 20);
            this.labelRoomCapacity.TabIndex = 48;
            this.labelRoomCapacity.Text = "Rozmiar pokoju";
            this.labelRoomCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRoomNumber.Location = new System.Drawing.Point(148, 278);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(108, 20);
            this.labelRoomNumber.TabIndex = 47;
            this.labelRoomNumber.Text = "Numer pokoju";
            this.labelRoomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRoomId
            // 
            this.labelRoomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRoomId.Location = new System.Drawing.Point(148, 232);
            this.labelRoomId.Name = "labelRoomId";
            this.labelRoomId.Size = new System.Drawing.Size(108, 20);
            this.labelRoomId.TabIndex = 46;
            this.labelRoomId.Text = "Id pokoju";
            this.labelRoomId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBlacklistPhoneNumber
            // 
            this.labelBlacklistPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBlacklistPhoneNumber.Location = new System.Drawing.Point(413, 370);
            this.labelBlacklistPhoneNumber.Name = "labelBlacklistPhoneNumber";
            this.labelBlacklistPhoneNumber.Size = new System.Drawing.Size(108, 20);
            this.labelBlacklistPhoneNumber.TabIndex = 53;
            this.labelBlacklistPhoneNumber.Text = "Numer telefonu";
            this.labelBlacklistPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBlacklistLastName
            // 
            this.labelBlacklistLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBlacklistLastName.Location = new System.Drawing.Point(413, 324);
            this.labelBlacklistLastName.Name = "labelBlacklistLastName";
            this.labelBlacklistLastName.Size = new System.Drawing.Size(108, 20);
            this.labelBlacklistLastName.TabIndex = 52;
            this.labelBlacklistLastName.Text = "Nazwisko osoby";
            this.labelBlacklistLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBlacklistFirstName
            // 
            this.labelBlacklistFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBlacklistFirstName.Location = new System.Drawing.Point(413, 278);
            this.labelBlacklistFirstName.Name = "labelBlacklistFirstName";
            this.labelBlacklistFirstName.Size = new System.Drawing.Size(108, 20);
            this.labelBlacklistFirstName.TabIndex = 51;
            this.labelBlacklistFirstName.Text = "Imię osoby";
            this.labelBlacklistFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBlacklistId
            // 
            this.labelBlacklistId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBlacklistId.Location = new System.Drawing.Point(413, 232);
            this.labelBlacklistId.Name = "labelBlacklistId";
            this.labelBlacklistId.Size = new System.Drawing.Size(108, 20);
            this.labelBlacklistId.TabIndex = 50;
            this.labelBlacklistId.Text = "Id osoby";
            this.labelBlacklistId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGuestPhoneNumber
            // 
            this.labelGuestPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGuestPhoneNumber.Location = new System.Drawing.Point(672, 416);
            this.labelGuestPhoneNumber.Name = "labelGuestPhoneNumber";
            this.labelGuestPhoneNumber.Size = new System.Drawing.Size(116, 20);
            this.labelGuestPhoneNumber.TabIndex = 58;
            this.labelGuestPhoneNumber.Text = "Numer telefonu";
            this.labelGuestPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGuestLastName
            // 
            this.labelGuestLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGuestLastName.Location = new System.Drawing.Point(672, 370);
            this.labelGuestLastName.Name = "labelGuestLastName";
            this.labelGuestLastName.Size = new System.Drawing.Size(116, 20);
            this.labelGuestLastName.TabIndex = 57;
            this.labelGuestLastName.Text = "Nazwisko gościa";
            this.labelGuestLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGuestFirstName
            // 
            this.labelGuestFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGuestFirstName.Location = new System.Drawing.Point(672, 324);
            this.labelGuestFirstName.Name = "labelGuestFirstName";
            this.labelGuestFirstName.Size = new System.Drawing.Size(116, 20);
            this.labelGuestFirstName.TabIndex = 56;
            this.labelGuestFirstName.Text = "Imię gościa";
            this.labelGuestFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGuestRoomNumber
            // 
            this.labelGuestRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGuestRoomNumber.Location = new System.Drawing.Point(672, 278);
            this.labelGuestRoomNumber.Name = "labelGuestRoomNumber";
            this.labelGuestRoomNumber.Size = new System.Drawing.Size(116, 20);
            this.labelGuestRoomNumber.TabIndex = 55;
            this.labelGuestRoomNumber.Text = "Nr pokoju gościa";
            this.labelGuestRoomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGuestId
            // 
            this.labelGuestId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGuestId.Location = new System.Drawing.Point(672, 232);
            this.labelGuestId.Name = "labelGuestId";
            this.labelGuestId.Size = new System.Drawing.Size(116, 20);
            this.labelGuestId.TabIndex = 54;
            this.labelGuestId.Text = "Id gościa";
            this.labelGuestId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWorkerId
            // 
            this.labelWorkerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWorkerId.Location = new System.Drawing.Point(12, 440);
            this.labelWorkerId.Name = "labelWorkerId";
            this.labelWorkerId.Size = new System.Drawing.Size(112, 34);
            this.labelWorkerId.TabIndex = 59;
            this.labelWorkerId.Text = "Id pracownika";
            this.labelWorkerId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWorkerFirsName
            // 
            this.labelWorkerFirsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWorkerFirsName.Location = new System.Drawing.Point(130, 440);
            this.labelWorkerFirsName.Name = "labelWorkerFirsName";
            this.labelWorkerFirsName.Size = new System.Drawing.Size(112, 34);
            this.labelWorkerFirsName.TabIndex = 60;
            this.labelWorkerFirsName.Text = "Imię pracownika";
            this.labelWorkerFirsName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWorkerLastName
            // 
            this.labelWorkerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWorkerLastName.Location = new System.Drawing.Point(248, 440);
            this.labelWorkerLastName.Name = "labelWorkerLastName";
            this.labelWorkerLastName.Size = new System.Drawing.Size(112, 34);
            this.labelWorkerLastName.TabIndex = 61;
            this.labelWorkerLastName.Text = "Nazwisko pracownika";
            this.labelWorkerLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWorkerPosition
            // 
            this.labelWorkerPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWorkerPosition.Location = new System.Drawing.Point(366, 440);
            this.labelWorkerPosition.Name = "labelWorkerPosition";
            this.labelWorkerPosition.Size = new System.Drawing.Size(112, 34);
            this.labelWorkerPosition.TabIndex = 62;
            this.labelWorkerPosition.Text = "Stanowisko pracownika";
            this.labelWorkerPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.labelWorkerPosition);
            this.Controls.Add(this.labelWorkerLastName);
            this.Controls.Add(this.labelWorkerFirsName);
            this.Controls.Add(this.labelWorkerId);
            this.Controls.Add(this.labelGuestPhoneNumber);
            this.Controls.Add(this.labelGuestLastName);
            this.Controls.Add(this.labelGuestFirstName);
            this.Controls.Add(this.labelGuestRoomNumber);
            this.Controls.Add(this.labelGuestId);
            this.Controls.Add(this.labelBlacklistPhoneNumber);
            this.Controls.Add(this.labelBlacklistLastName);
            this.Controls.Add(this.labelBlacklistFirstName);
            this.Controls.Add(this.labelBlacklistId);
            this.Controls.Add(this.labelRoomFloor);
            this.Controls.Add(this.labelRoomCapacity);
            this.Controls.Add(this.labelRoomNumber);
            this.Controls.Add(this.labelRoomId);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxGuestLastName);
            this.Controls.Add(this.textBoxGuestFirstName);
            this.Controls.Add(this.textBoxGuestRoomNumber);
            this.Controls.Add(this.textBoxGuestId);
            this.Controls.Add(this.buttonEditGuest);
            this.Controls.Add(this.buttonRemoveGuest);
            this.Controls.Add(this.buttonAddGuest);
            this.Controls.Add(this.buttonShowGuests);
            this.Controls.Add(this.textBoxWorkerWorkPosition);
            this.Controls.Add(this.textBoxWorkerLastName);
            this.Controls.Add(this.textBoxWorkerFirstName);
            this.Controls.Add(this.textBoxWorkerId);
            this.Controls.Add(this.buttonEditWorker);
            this.Controls.Add(this.buttonRemoveWorker);
            this.Controls.Add(this.buttonAddWorker);
            this.Controls.Add(this.buttonShowWorkers);
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
            this.Name = "FormAdmin";
            this.Text = "Administrator";
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
        private System.Windows.Forms.TextBox textBoxWorkerWorkPosition;
        private System.Windows.Forms.TextBox textBoxWorkerLastName;
        private System.Windows.Forms.TextBox textBoxWorkerFirstName;
        private System.Windows.Forms.TextBox textBoxWorkerId;
        private System.Windows.Forms.Button buttonEditWorker;
        private System.Windows.Forms.Button buttonRemoveWorker;
        private System.Windows.Forms.Button buttonAddWorker;
        private System.Windows.Forms.Button buttonShowWorkers;
        private System.Windows.Forms.Button buttonEditGuest;
        private System.Windows.Forms.Button buttonRemoveGuest;
        private System.Windows.Forms.Button buttonAddGuest;
        private System.Windows.Forms.Button buttonShowGuests;
        private System.Windows.Forms.TextBox textBoxGuestLastName;
        private System.Windows.Forms.TextBox textBoxGuestFirstName;
        private System.Windows.Forms.TextBox textBoxGuestRoomNumber;
        private System.Windows.Forms.TextBox textBoxGuestId;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelRoomFloor;
        private System.Windows.Forms.Label labelRoomCapacity;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label labelRoomId;
        private System.Windows.Forms.Label labelBlacklistPhoneNumber;
        private System.Windows.Forms.Label labelBlacklistLastName;
        private System.Windows.Forms.Label labelBlacklistFirstName;
        private System.Windows.Forms.Label labelBlacklistId;
        private System.Windows.Forms.Label labelGuestPhoneNumber;
        private System.Windows.Forms.Label labelGuestLastName;
        private System.Windows.Forms.Label labelGuestFirstName;
        private System.Windows.Forms.Label labelGuestRoomNumber;
        private System.Windows.Forms.Label labelGuestId;
        private System.Windows.Forms.Label labelWorkerId;
        private System.Windows.Forms.Label labelWorkerFirsName;
        private System.Windows.Forms.Label labelWorkerLastName;
        private System.Windows.Forms.Label labelWorkerPosition;
    }
}