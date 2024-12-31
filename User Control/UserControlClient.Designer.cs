namespace ReservationHotel.User_Control
{
    partial class UserControlClient
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
            tabControlClient = new TabControl();
            tabPageAddClient = new TabPage();
            label10 = new Label();
            textBoxPhone = new TextBox();
            textBoxAdresse = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            buttonAdd = new Button();
            label4 = new Label();
            label5 = new Label();
            textBoxPasswordClient = new TextBox();
            label3 = new Label();
            textBoxEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPageSearchClient = new TabPage();
            dataGridViewClient = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            textBoxSearchEmail = new TextBox();
            label7 = new Label();
            label6 = new Label();
            tabPage1 = new TabPage();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            label11 = new Label();
            textBoxPhone1 = new TextBox();
            textBoxAdresse1 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            textBoxFirstName1 = new TextBox();
            textBoxLastName1 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            textBoxPasswordClient1 = new TextBox();
            label16 = new Label();
            textBoxEmail1 = new TextBox();
            label17 = new Label();
            label18 = new Label();
            tabControlClient.SuspendLayout();
            tabPageAddClient.SuspendLayout();
            tabPageSearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).BeginInit();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlClient
            // 
            tabControlClient.Alignment = TabAlignment.Bottom;
            tabControlClient.Anchor = AnchorStyles.None;
            tabControlClient.Controls.Add(tabPageAddClient);
            tabControlClient.Controls.Add(tabPageSearchClient);
            tabControlClient.Controls.Add(tabPage1);
            tabControlClient.Location = new Point(31, 24);
            tabControlClient.Name = "tabControlClient";
            tabControlClient.SelectedIndex = 0;
            tabControlClient.Size = new Size(1043, 412);
            tabControlClient.TabIndex = 0;
            // 
            // tabPageAddClient
            // 
            tabPageAddClient.Controls.Add(label10);
            tabPageAddClient.Controls.Add(textBoxPhone);
            tabPageAddClient.Controls.Add(textBoxAdresse);
            tabPageAddClient.Controls.Add(label8);
            tabPageAddClient.Controls.Add(label9);
            tabPageAddClient.Controls.Add(textBoxFirstName);
            tabPageAddClient.Controls.Add(textBoxLastName);
            tabPageAddClient.Controls.Add(buttonAdd);
            tabPageAddClient.Controls.Add(label4);
            tabPageAddClient.Controls.Add(label5);
            tabPageAddClient.Controls.Add(textBoxPasswordClient);
            tabPageAddClient.Controls.Add(label3);
            tabPageAddClient.Controls.Add(textBoxEmail);
            tabPageAddClient.Controls.Add(label2);
            tabPageAddClient.Controls.Add(label1);
            tabPageAddClient.Location = new Point(4, 4);
            tabPageAddClient.Name = "tabPageAddClient";
            tabPageAddClient.Padding = new Padding(3);
            tabPageAddClient.Size = new Size(1035, 384);
            tabPageAddClient.TabIndex = 0;
            tabPageAddClient.Text = "Ajouter un client";
            tabPageAddClient.UseVisualStyleBackColor = true;
            tabPageAddClient.Leave += tabPageAddClient_Leave;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label10.Location = new Point(292, 164);
            label10.Name = "label10";
            label10.Size = new Size(0, 16);
            label10.TabIndex = 28;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.None;
            textBoxPhone.Location = new Point(165, 294);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(223, 21);
            textBoxPhone.TabIndex = 27;
            // 
            // textBoxAdresse
            // 
            textBoxAdresse.Anchor = AnchorStyles.None;
            textBoxAdresse.Location = new Point(616, 294);
            textBoxAdresse.Name = "textBoxAdresse";
            textBoxAdresse.Size = new Size(223, 21);
            textBoxAdresse.TabIndex = 26;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label8.Location = new Point(578, 248);
            label8.Name = "label8";
            label8.Size = new Size(65, 16);
            label8.TabIndex = 25;
            label8.Text = "Adresse :";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label9.Location = new Point(127, 248);
            label9.Name = "label9";
            label9.Size = new Size(83, 16);
            label9.TabIndex = 24;
            label9.Text = "Téléphone :";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Anchor = AnchorStyles.None;
            textBoxFirstName.Location = new Point(165, 193);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(223, 21);
            textBoxFirstName.TabIndex = 23;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = AnchorStyles.None;
            textBoxLastName.Location = new Point(616, 193);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(223, 21);
            textBoxLastName.TabIndex = 22;
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
            buttonAdd.Location = new Point(388, 331);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(206, 34);
            buttonAdd.TabIndex = 21;
            buttonAdd.Text = "Ajouter";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label4.Location = new Point(578, 147);
            label4.Name = "label4";
            label4.Size = new Size(44, 16);
            label4.TabIndex = 18;
            label4.Text = "Nom :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label5.Location = new Point(127, 147);
            label5.Name = "label5";
            label5.Size = new Size(65, 16);
            label5.TabIndex = 17;
            label5.Text = "Prénom :";
            // 
            // textBoxPasswordClient
            // 
            textBoxPasswordClient.Anchor = AnchorStyles.None;
            textBoxPasswordClient.Location = new Point(616, 80);
            textBoxPasswordClient.Name = "textBoxPasswordClient";
            textBoxPasswordClient.Size = new Size(223, 21);
            textBoxPasswordClient.TabIndex = 16;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label3.Location = new Point(578, 46);
            label3.Name = "label3";
            label3.Size = new Size(76, 16);
            label3.TabIndex = 15;
            label3.Text = "Password :";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.None;
            textBoxEmail.Location = new Point(165, 80);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(223, 21);
            textBoxEmail.TabIndex = 14;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label2.Location = new Point(127, 46);
            label2.Name = "label2";
            label2.Size = new Size(51, 16);
            label2.TabIndex = 13;
            label2.Text = "Email :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(25, 135, 84);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 18);
            label1.TabIndex = 12;
            label1.Text = "Ajouter un client";
            // 
            // tabPageSearchClient
            // 
            tabPageSearchClient.Controls.Add(dataGridViewClient);
            tabPageSearchClient.Controls.Add(textBoxSearchEmail);
            tabPageSearchClient.Controls.Add(label7);
            tabPageSearchClient.Controls.Add(label6);
            tabPageSearchClient.Location = new Point(4, 4);
            tabPageSearchClient.Name = "tabPageSearchClient";
            tabPageSearchClient.Padding = new Padding(3);
            tabPageSearchClient.Size = new Size(1035, 384);
            tabPageSearchClient.TabIndex = 1;
            tabPageSearchClient.Text = "Rechercher un client";
            tabPageSearchClient.UseVisualStyleBackColor = true;
            tabPageSearchClient.Enter += tabPageSearchClient_Enter;
            tabPageSearchClient.Leave += tabPageSearchClient_Leave;
            // 
            // dataGridViewClient
            // 
            dataGridViewClient.AllowUserToAddRows = false;
            dataGridViewClient.AllowUserToDeleteRows = false;
            dataGridViewClient.Anchor = AnchorStyles.None;
            dataGridViewClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClient.BackgroundColor = SystemColors.AppWorkspace;
            dataGridViewClient.BorderStyle = BorderStyle.None;
            dataGridViewClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClient.Columns.AddRange(new DataGridViewColumn[] { Column1, Email, password, FirstName, LastName, Phone, Address });
            dataGridViewClient.Location = new Point(47, 160);
            dataGridViewClient.Name = "dataGridViewClient";
            dataGridViewClient.ReadOnly = true;
            dataGridViewClient.RowHeadersWidth = 51;
            dataGridViewClient.Size = new Size(937, 202);
            dataGridViewClient.TabIndex = 9;
            dataGridViewClient.CellClick += dataGridViewClient_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id_client";
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 64;
            // 
            // password
            // 
            password.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            password.DataPropertyName = "Password";
            password.HeaderText = "Mot de passe";
            password.Name = "password";
            password.ReadOnly = true;
            password.Width = 106;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "Prénom ";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "Nom";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Téléphone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Adresse";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 78;
            // 
            // textBoxSearchEmail
            // 
            textBoxSearchEmail.Anchor = AnchorStyles.None;
            textBoxSearchEmail.Location = new Point(171, 96);
            textBoxSearchEmail.Name = "textBoxSearchEmail";
            textBoxSearchEmail.Size = new Size(223, 21);
            textBoxSearchEmail.TabIndex = 8;
            textBoxSearchEmail.TextChanged += textBoxSearchEmail_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label7.Location = new Point(133, 62);
            label7.Name = "label7";
            label7.Size = new Size(51, 16);
            label7.TabIndex = 7;
            label7.Text = "Email :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(25, 135, 84);
            label6.Location = new Point(3, 3);
            label6.Name = "label6";
            label6.Size = new Size(157, 18);
            label6.TabIndex = 6;
            label6.Text = "Rechercher un client";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonDelete);
            tabPage1.Controls.Add(buttonUpdate);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(textBoxPhone1);
            tabPage1.Controls.Add(textBoxAdresse1);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(textBoxFirstName1);
            tabPage1.Controls.Add(textBoxLastName1);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(textBoxPasswordClient1);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(textBoxEmail1);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(label18);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1035, 384);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Mettre à jour et supprimer un client";
            tabPage1.UseVisualStyleBackColor = true;
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
            buttonDelete.Location = new Point(542, 335);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(206, 34);
            buttonDelete.TabIndex = 45;
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
            buttonUpdate.Location = new Point(307, 335);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(206, 34);
            buttonUpdate.TabIndex = 44;
            buttonUpdate.Text = "Modifier";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label11.Location = new Point(295, 167);
            label11.Name = "label11";
            label11.Size = new Size(0, 16);
            label11.TabIndex = 43;
            // 
            // textBoxPhone1
            // 
            textBoxPhone1.Anchor = AnchorStyles.None;
            textBoxPhone1.Location = new Point(168, 297);
            textBoxPhone1.Name = "textBoxPhone1";
            textBoxPhone1.Size = new Size(223, 21);
            textBoxPhone1.TabIndex = 42;
            // 
            // textBoxAdresse1
            // 
            textBoxAdresse1.Anchor = AnchorStyles.None;
            textBoxAdresse1.Location = new Point(619, 297);
            textBoxAdresse1.Name = "textBoxAdresse1";
            textBoxAdresse1.Size = new Size(223, 21);
            textBoxAdresse1.TabIndex = 41;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label12.Location = new Point(581, 251);
            label12.Name = "label12";
            label12.Size = new Size(65, 16);
            label12.TabIndex = 40;
            label12.Text = "Adresse :";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label13.Location = new Point(130, 251);
            label13.Name = "label13";
            label13.Size = new Size(83, 16);
            label13.TabIndex = 39;
            label13.Text = "Téléphone :";
            // 
            // textBoxFirstName1
            // 
            textBoxFirstName1.Anchor = AnchorStyles.None;
            textBoxFirstName1.Location = new Point(168, 196);
            textBoxFirstName1.Name = "textBoxFirstName1";
            textBoxFirstName1.Size = new Size(223, 21);
            textBoxFirstName1.TabIndex = 38;
            // 
            // textBoxLastName1
            // 
            textBoxLastName1.Anchor = AnchorStyles.None;
            textBoxLastName1.Location = new Point(619, 196);
            textBoxLastName1.Name = "textBoxLastName1";
            textBoxLastName1.Size = new Size(223, 21);
            textBoxLastName1.TabIndex = 37;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label14.Location = new Point(581, 150);
            label14.Name = "label14";
            label14.Size = new Size(44, 16);
            label14.TabIndex = 35;
            label14.Text = "Nom :";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label15.Location = new Point(130, 150);
            label15.Name = "label15";
            label15.Size = new Size(65, 16);
            label15.TabIndex = 34;
            label15.Text = "Prénom :";
            // 
            // textBoxPasswordClient1
            // 
            textBoxPasswordClient1.Anchor = AnchorStyles.None;
            textBoxPasswordClient1.Location = new Point(619, 83);
            textBoxPasswordClient1.Name = "textBoxPasswordClient1";
            textBoxPasswordClient1.Size = new Size(223, 21);
            textBoxPasswordClient1.TabIndex = 33;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label16.Location = new Point(581, 49);
            label16.Name = "label16";
            label16.Size = new Size(76, 16);
            label16.TabIndex = 32;
            label16.Text = "Password :";
            // 
            // textBoxEmail1
            // 
            textBoxEmail1.Anchor = AnchorStyles.None;
            textBoxEmail1.Location = new Point(168, 83);
            textBoxEmail1.Name = "textBoxEmail1";
            textBoxEmail1.Size = new Size(223, 21);
            textBoxEmail1.TabIndex = 31;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label17.Location = new Point(130, 49);
            label17.Name = "label17";
            label17.Size = new Size(51, 16);
            label17.TabIndex = 30;
            label17.Text = "Email :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(25, 135, 84);
            label18.Location = new Point(3, 3);
            label18.Name = "label18";
            label18.Size = new Size(258, 18);
            label18.TabIndex = 29;
            label18.Text = "Mettre à jour et supprimer un client";
            // 
            // UserControlClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlClient);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UserControlClient";
            Size = new Size(1102, 462);
            tabControlClient.ResumeLayout(false);
            tabPageAddClient.ResumeLayout(false);
            tabPageAddClient.PerformLayout();
            tabPageSearchClient.ResumeLayout(false);
            tabPageSearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlClient;
        private TabPage tabPageAddClient;
        private TabPage tabPageSearchClient;
        private Button buttonAdd;
        private Label label4;
        private Label label5;
        private TextBox textBoxPasswordClient;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label2;
        private Label label1;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TabPage tabPage1;
        private DataGridView dataGridViewClient;
        private TextBox textBoxSearchEmail;
        private Label label7;
        private Label label6;
        private TextBox textBoxPhone;
        private TextBox textBoxAdresse;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBoxPhone1;
        private TextBox textBoxAdresse1;
        private Label label12;
        private Label label13;
        private TextBox textBoxFirstName1;
        private TextBox textBoxLastName1;
        private Label label14;
        private Label label15;
        private TextBox textBoxPasswordClient1;
        private Label label16;
        private TextBox textBoxEmail1;
        private Label label17;
        private Label label18;
        private Button buttonDelete;
        private Button buttonUpdate;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Address;
    }
}
