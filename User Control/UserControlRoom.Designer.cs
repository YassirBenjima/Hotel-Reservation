namespace ReservationHotel.User_Control
{
    partial class UserControlRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlRoom = new TabControl();
            tabPageAddRoom = new TabPage();
            comboBoxTypeRoom = new ComboBox();
            comboBoxStatusRoom = new ComboBox();
            comboBoxFreeRoom = new ComboBox();
            label10 = new Label();
            textBoxPriceRoom = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBoxCapacityRoom = new TextBox();
            buttonAdd = new Button();
            label4 = new Label();
            label5 = new Label();
            textBoxPhoneRoom = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageSearchRoom = new TabPage();
            dataGridViewRoom = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            textBoxSearchRoomNo = new TextBox();
            label7 = new Label();
            label6 = new Label();
            tabPageUpdateDeleteRoom = new TabPage();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            comboBoxTypeRoom1 = new ComboBox();
            comboBoxStatusRoom1 = new ComboBox();
            comboBoxFreeRoom1 = new ComboBox();
            label11 = new Label();
            textBoxPriceRoom1 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            textBoxCapacityRoom1 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            textBoxPhoneRoom1 = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            tabControlRoom.SuspendLayout();
            tabPageAddRoom.SuspendLayout();
            tabPageSearchRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoom).BeginInit();
            tabPageUpdateDeleteRoom.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRoom
            // 
            tabControlRoom.Alignment = TabAlignment.Bottom;
            tabControlRoom.Anchor = AnchorStyles.None;
            tabControlRoom.Controls.Add(tabPageAddRoom);
            tabControlRoom.Controls.Add(tabPageSearchRoom);
            tabControlRoom.Controls.Add(tabPageUpdateDeleteRoom);
            tabControlRoom.Location = new Point(31, 24);
            tabControlRoom.Name = "tabControlRoom";
            tabControlRoom.SelectedIndex = 0;
            tabControlRoom.Size = new Size(1043, 412);
            tabControlRoom.TabIndex = 0;
            // 
            // tabPageAddRoom
            // 
            tabPageAddRoom.Controls.Add(comboBoxTypeRoom);
            tabPageAddRoom.Controls.Add(comboBoxStatusRoom);
            tabPageAddRoom.Controls.Add(comboBoxFreeRoom);
            tabPageAddRoom.Controls.Add(label10);
            tabPageAddRoom.Controls.Add(textBoxPriceRoom);
            tabPageAddRoom.Controls.Add(label8);
            tabPageAddRoom.Controls.Add(label9);
            tabPageAddRoom.Controls.Add(textBoxCapacityRoom);
            tabPageAddRoom.Controls.Add(buttonAdd);
            tabPageAddRoom.Controls.Add(label4);
            tabPageAddRoom.Controls.Add(label5);
            tabPageAddRoom.Controls.Add(textBoxPhoneRoom);
            tabPageAddRoom.Controls.Add(label3);
            tabPageAddRoom.Controls.Add(label2);
            tabPageAddRoom.Controls.Add(label1);
            tabPageAddRoom.Location = new Point(4, 4);
            tabPageAddRoom.Name = "tabPageAddRoom";
            tabPageAddRoom.Padding = new Padding(3);
            tabPageAddRoom.Size = new Size(1035, 384);
            tabPageAddRoom.TabIndex = 0;
            tabPageAddRoom.Text = "Ajouter une chambre";
            tabPageAddRoom.UseVisualStyleBackColor = true;
            tabPageAddRoom.Leave += tabPageAddRoom_Leave;
            // 
            // comboBoxTypeRoom
            // 
            comboBoxTypeRoom.Anchor = AnchorStyles.None;
            comboBoxTypeRoom.FormattingEnabled = true;
            comboBoxTypeRoom.Items.AddRange(new object[] { "Seule", "Double", "Twin", "Suite", "Deluxe", "Studio" });
            comboBoxTypeRoom.Location = new Point(165, 92);
            comboBoxTypeRoom.Name = "comboBoxTypeRoom";
            comboBoxTypeRoom.Size = new Size(223, 23);
            comboBoxTypeRoom.TabIndex = 46;
            // 
            // comboBoxStatusRoom
            // 
            comboBoxStatusRoom.Anchor = AnchorStyles.None;
            comboBoxStatusRoom.FormattingEnabled = true;
            comboBoxStatusRoom.Items.AddRange(new object[] { "Actif", "Inactif" });
            comboBoxStatusRoom.Location = new Point(616, 295);
            comboBoxStatusRoom.Name = "comboBoxStatusRoom";
            comboBoxStatusRoom.Size = new Size(223, 23);
            comboBoxStatusRoom.TabIndex = 45;
            // 
            // comboBoxFreeRoom
            // 
            comboBoxFreeRoom.Anchor = AnchorStyles.None;
            comboBoxFreeRoom.FormattingEnabled = true;
            comboBoxFreeRoom.Items.AddRange(new object[] { "Oui", "Non" });
            comboBoxFreeRoom.Location = new Point(165, 194);
            comboBoxFreeRoom.Name = "comboBoxFreeRoom";
            comboBoxFreeRoom.Size = new Size(223, 23);
            comboBoxFreeRoom.TabIndex = 44;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label10.Location = new Point(292, 167);
            label10.Name = "label10";
            label10.Size = new Size(0, 16);
            label10.TabIndex = 43;
            // 
            // textBoxPriceRoom
            // 
            textBoxPriceRoom.Anchor = AnchorStyles.None;
            textBoxPriceRoom.Location = new Point(165, 297);
            textBoxPriceRoom.Name = "textBoxPriceRoom";
            textBoxPriceRoom.Size = new Size(223, 21);
            textBoxPriceRoom.TabIndex = 42;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label8.Location = new Point(578, 251);
            label8.Name = "label8";
            label8.Size = new Size(56, 16);
            label8.TabIndex = 40;
            label8.Text = "Statut : ";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label9.Location = new Point(127, 251);
            label9.Name = "label9";
            label9.Size = new Size(45, 16);
            label9.TabIndex = 39;
            label9.Text = "Prix : ";
            // 
            // textBoxCapacityRoom
            // 
            textBoxCapacityRoom.Anchor = AnchorStyles.None;
            textBoxCapacityRoom.Location = new Point(616, 196);
            textBoxCapacityRoom.Name = "textBoxCapacityRoom";
            textBoxCapacityRoom.Size = new Size(223, 21);
            textBoxCapacityRoom.TabIndex = 37;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.None;
            buttonAdd.BackColor = Color.FromArgb(25, 135, 84);
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(388, 334);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(206, 34);
            buttonAdd.TabIndex = 36;
            buttonAdd.Text = "Ajouter";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label4.Location = new Point(578, 150);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 35;
            label4.Text = "Capacité :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label5.Location = new Point(127, 150);
            label5.Name = "label5";
            label5.Size = new Size(48, 16);
            label5.TabIndex = 34;
            label5.Text = "Libre :";
            // 
            // textBoxPhoneRoom
            // 
            textBoxPhoneRoom.Anchor = AnchorStyles.None;
            textBoxPhoneRoom.Location = new Point(616, 83);
            textBoxPhoneRoom.Name = "textBoxPhoneRoom";
            textBoxPhoneRoom.Size = new Size(223, 21);
            textBoxPhoneRoom.TabIndex = 33;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label3.Location = new Point(578, 49);
            label3.Name = "label3";
            label3.Size = new Size(83, 16);
            label3.TabIndex = 32;
            label3.Text = "Téléphone :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label2.Location = new Point(127, 49);
            label2.Name = "label2";
            label2.Size = new Size(45, 16);
            label2.TabIndex = 30;
            label2.Text = "Type :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(25, 135, 84);
            label1.Location = new Point(0, 3);
            label1.Name = "label1";
            label1.Size = new Size(167, 18);
            label1.TabIndex = 29;
            label1.Text = "Ajouter une chambre : ";
            // 
            // tabPageSearchRoom
            // 
            tabPageSearchRoom.Controls.Add(dataGridViewRoom);
            tabPageSearchRoom.Controls.Add(textBoxSearchRoomNo);
            tabPageSearchRoom.Controls.Add(label7);
            tabPageSearchRoom.Controls.Add(label6);
            tabPageSearchRoom.Location = new Point(4, 4);
            tabPageSearchRoom.Name = "tabPageSearchRoom";
            tabPageSearchRoom.Padding = new Padding(3);
            tabPageSearchRoom.Size = new Size(1035, 384);
            tabPageSearchRoom.TabIndex = 1;
            tabPageSearchRoom.Text = "Recherche Chambre";
            tabPageSearchRoom.UseVisualStyleBackColor = true;
            tabPageSearchRoom.Enter += tabPageSearchRoom_Enter;
            tabPageSearchRoom.Leave += tabPageSearchRoom_Leave;
            // 
            // dataGridViewRoom
            // 
            dataGridViewRoom.AllowUserToAddRows = false;
            dataGridViewRoom.AllowUserToDeleteRows = false;
            dataGridViewRoom.Anchor = AnchorStyles.None;
            dataGridViewRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRoom.BackgroundColor = SystemColors.AppWorkspace;
            dataGridViewRoom.BorderStyle = BorderStyle.None;
            dataGridViewRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoom.Columns.AddRange(new DataGridViewColumn[] { Column1, Email, LastName, FirstName, Phone, password, Address });
            dataGridViewRoom.Location = new Point(47, 160);
            dataGridViewRoom.Name = "dataGridViewRoom";
            dataGridViewRoom.ReadOnly = true;
            dataGridViewRoom.RowHeadersWidth = 51;
            dataGridViewRoom.Size = new Size(937, 202);
            dataGridViewRoom.TabIndex = 13;
            dataGridViewRoom.CellClick += dataGridViewRoom_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Room_Number";
            Column1.HeaderText = "Numéro de chambre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Room_Type";
            Email.HeaderText = "Type";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "Room_Capacity";
            LastName.HeaderText = "Capacité";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "Room_Free";
            FirstName.HeaderText = "Libre";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Room_Price";
            Phone.HeaderText = "Prix";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // password
            // 
            password.DataPropertyName = "Room_Phone";
            password.HeaderText = "Téléphone";
            password.Name = "password";
            password.ReadOnly = true;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Address.DataPropertyName = "Room_Status";
            Address.HeaderText = "Statut";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 63;
            // 
            // textBoxSearchRoomNo
            // 
            textBoxSearchRoomNo.Anchor = AnchorStyles.None;
            textBoxSearchRoomNo.Location = new Point(171, 96);
            textBoxSearchRoomNo.Name = "textBoxSearchRoomNo";
            textBoxSearchRoomNo.Size = new Size(223, 21);
            textBoxSearchRoomNo.TabIndex = 12;
            textBoxSearchRoomNo.TextChanged += textBoxSearchRoomNo_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label7.Location = new Point(133, 62);
            label7.Name = "label7";
            label7.Size = new Size(145, 16);
            label7.TabIndex = 11;
            label7.Text = "Numéro de chambre :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(25, 135, 84);
            label6.Location = new Point(3, 3);
            label6.Name = "label6";
            label6.Size = new Size(163, 18);
            label6.TabIndex = 10;
            label6.Text = "Recherche chambre : ";
            // 
            // tabPageUpdateDeleteRoom
            // 
            tabPageUpdateDeleteRoom.Controls.Add(buttonDelete);
            tabPageUpdateDeleteRoom.Controls.Add(buttonUpdate);
            tabPageUpdateDeleteRoom.Controls.Add(comboBoxTypeRoom1);
            tabPageUpdateDeleteRoom.Controls.Add(comboBoxStatusRoom1);
            tabPageUpdateDeleteRoom.Controls.Add(comboBoxFreeRoom1);
            tabPageUpdateDeleteRoom.Controls.Add(label11);
            tabPageUpdateDeleteRoom.Controls.Add(textBoxPriceRoom1);
            tabPageUpdateDeleteRoom.Controls.Add(label12);
            tabPageUpdateDeleteRoom.Controls.Add(label13);
            tabPageUpdateDeleteRoom.Controls.Add(textBoxCapacityRoom1);
            tabPageUpdateDeleteRoom.Controls.Add(label14);
            tabPageUpdateDeleteRoom.Controls.Add(label15);
            tabPageUpdateDeleteRoom.Controls.Add(textBoxPhoneRoom1);
            tabPageUpdateDeleteRoom.Controls.Add(label16);
            tabPageUpdateDeleteRoom.Controls.Add(label17);
            tabPageUpdateDeleteRoom.Controls.Add(label18);
            tabPageUpdateDeleteRoom.Location = new Point(4, 4);
            tabPageUpdateDeleteRoom.Name = "tabPageUpdateDeleteRoom";
            tabPageUpdateDeleteRoom.Padding = new Padding(3);
            tabPageUpdateDeleteRoom.Size = new Size(1035, 384);
            tabPageUpdateDeleteRoom.TabIndex = 2;
            tabPageUpdateDeleteRoom.Text = "Mettre à jour et supprimer une chambre";
            tabPageUpdateDeleteRoom.UseVisualStyleBackColor = true;
            tabPageUpdateDeleteRoom.Leave += tabPageUpdateDeleteRoom_Leave;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.None;
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(540, 335);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(206, 34);
            buttonDelete.TabIndex = 63;
            buttonDelete.Text = "Supprimer";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.None;
            buttonUpdate.BackColor = Color.FromArgb(25, 135, 84);
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(305, 335);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(206, 34);
            buttonUpdate.TabIndex = 62;
            buttonUpdate.Text = "Modifier";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // comboBoxTypeRoom1
            // 
            comboBoxTypeRoom1.Anchor = AnchorStyles.None;
            comboBoxTypeRoom1.FormattingEnabled = true;
            comboBoxTypeRoom1.Items.AddRange(new object[] { "Seule", "Double", "Twin", "Suite", "Deluxe", "Studio" });
            comboBoxTypeRoom1.Location = new Point(165, 92);
            comboBoxTypeRoom1.Name = "comboBoxTypeRoom1";
            comboBoxTypeRoom1.Size = new Size(223, 23);
            comboBoxTypeRoom1.TabIndex = 61;
            // 
            // comboBoxStatusRoom1
            // 
            comboBoxStatusRoom1.Anchor = AnchorStyles.None;
            comboBoxStatusRoom1.FormattingEnabled = true;
            comboBoxStatusRoom1.Items.AddRange(new object[] { "Actif", "Inactif" });
            comboBoxStatusRoom1.Location = new Point(616, 295);
            comboBoxStatusRoom1.Name = "comboBoxStatusRoom1";
            comboBoxStatusRoom1.Size = new Size(223, 23);
            comboBoxStatusRoom1.TabIndex = 60;
            // 
            // comboBoxFreeRoom1
            // 
            comboBoxFreeRoom1.Anchor = AnchorStyles.None;
            comboBoxFreeRoom1.FormattingEnabled = true;
            comboBoxFreeRoom1.Items.AddRange(new object[] { "Oui", "Non" });
            comboBoxFreeRoom1.Location = new Point(165, 194);
            comboBoxFreeRoom1.Name = "comboBoxFreeRoom1";
            comboBoxFreeRoom1.Size = new Size(223, 23);
            comboBoxFreeRoom1.TabIndex = 59;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label11.Location = new Point(292, 167);
            label11.Name = "label11";
            label11.Size = new Size(0, 16);
            label11.TabIndex = 58;
            // 
            // textBoxPriceRoom1
            // 
            textBoxPriceRoom1.Anchor = AnchorStyles.None;
            textBoxPriceRoom1.Location = new Point(165, 297);
            textBoxPriceRoom1.Name = "textBoxPriceRoom1";
            textBoxPriceRoom1.Size = new Size(223, 21);
            textBoxPriceRoom1.TabIndex = 57;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label12.Location = new Point(578, 251);
            label12.Name = "label12";
            label12.Size = new Size(56, 16);
            label12.TabIndex = 56;
            label12.Text = "Statut : ";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label13.Location = new Point(127, 251);
            label13.Name = "label13";
            label13.Size = new Size(45, 16);
            label13.TabIndex = 55;
            label13.Text = "Prix : ";
            // 
            // textBoxCapacityRoom1
            // 
            textBoxCapacityRoom1.Anchor = AnchorStyles.None;
            textBoxCapacityRoom1.Location = new Point(616, 196);
            textBoxCapacityRoom1.Name = "textBoxCapacityRoom1";
            textBoxCapacityRoom1.Size = new Size(223, 21);
            textBoxCapacityRoom1.TabIndex = 54;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label14.Location = new Point(578, 150);
            label14.Name = "label14";
            label14.Size = new Size(71, 16);
            label14.TabIndex = 52;
            label14.Text = "Capacité :";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label15.Location = new Point(127, 150);
            label15.Name = "label15";
            label15.Size = new Size(48, 16);
            label15.TabIndex = 51;
            label15.Text = "Libre :";
            // 
            // textBoxPhoneRoom1
            // 
            textBoxPhoneRoom1.Anchor = AnchorStyles.None;
            textBoxPhoneRoom1.Location = new Point(616, 83);
            textBoxPhoneRoom1.Name = "textBoxPhoneRoom1";
            textBoxPhoneRoom1.Size = new Size(223, 21);
            textBoxPhoneRoom1.TabIndex = 50;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label16.Location = new Point(578, 49);
            label16.Name = "label16";
            label16.Size = new Size(83, 16);
            label16.TabIndex = 49;
            label16.Text = "Téléphone :";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label17.Location = new Point(127, 49);
            label17.Name = "label17";
            label17.Size = new Size(45, 16);
            label17.TabIndex = 48;
            label17.Text = "Type :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(25, 135, 84);
            label18.Location = new Point(0, 3);
            label18.Name = "label18";
            label18.Size = new Size(297, 18);
            label18.TabIndex = 47;
            label18.Text = "Mettre à jour et supprimer une chambre :";
            // 
            // UserControlRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlRoom);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UserControlRoom";
            Size = new Size(1102, 462);
            tabControlRoom.ResumeLayout(false);
            tabPageAddRoom.ResumeLayout(false);
            tabPageAddRoom.PerformLayout();
            tabPageSearchRoom.ResumeLayout(false);
            tabPageSearchRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoom).EndInit();
            tabPageUpdateDeleteRoom.ResumeLayout(false);
            tabPageUpdateDeleteRoom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlRoom;
        private TabPage tabPageAddRoom;
        private TabPage tabPageSearchRoom;
        private TabPage tabPageUpdateDeleteRoom;
        private Label label10;
        private TextBox textBoxPriceRoom;
        private Label label8;
        private Label label9;
        private TextBox textBoxCapacityRoom;
        private Button buttonAdd;
        private Label label4;
        private Label label5;
        private TextBox textBoxPhoneRoom;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxTypeRoom;
        private ComboBox comboBoxStatusRoom;
        private ComboBox comboBoxFreeRoom;
        private DataGridView dataGridViewRoom;
        private TextBox textBoxSearchRoomNo;
        private Label label7;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn Address;
        private ComboBox comboBoxTypeRoom1;
        private ComboBox comboBoxStatusRoom1;
        private ComboBox comboBoxFreeRoom1;
        private Label label11;
        private TextBox textBoxPriceRoom1;
        private Label label12;
        private Label label13;
        private TextBox textBoxCapacityRoom1;
        private Label label14;
        private Label label15;
        private TextBox textBoxPhoneRoom1;
        private Label label16;
        private Label label17;
        private Label label18;
        private Button buttonDelete;
        private Button buttonUpdate;
    }
}
