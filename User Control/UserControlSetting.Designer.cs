namespace ReservationHotel.User_Control
{
    partial class UserControlSetting
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
            tabControlUser = new TabControl();
            tabPageAddUser = new TabPage();
            buttonAdd = new Button();
            comboBoxStatus = new ComboBox();
            comboBoxRole = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            textBoxPassword = new TextBox();
            label3 = new Label();
            textBoxUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPageSearchUser = new TabPage();
            dataGridViewUser = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            textBoxSearchUsername = new TextBox();
            label7 = new Label();
            label6 = new Label();
            tabPageUpdateAndDeleteUser = new TabPage();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            comboBoxStatus1 = new ComboBox();
            comboBoxRole1 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            textBoxPassword1 = new TextBox();
            label10 = new Label();
            textBoxUsername1 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            tabControlUser.SuspendLayout();
            tabPageAddUser.SuspendLayout();
            tabPageSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            tabPageUpdateAndDeleteUser.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlUser
            // 
            tabControlUser.Alignment = TabAlignment.Bottom;
            tabControlUser.Anchor = AnchorStyles.None;
            tabControlUser.Controls.Add(tabPageAddUser);
            tabControlUser.Controls.Add(tabPageSearchUser);
            tabControlUser.Controls.Add(tabPageUpdateAndDeleteUser);
            tabControlUser.Location = new Point(31, 24);
            tabControlUser.Name = "tabControlUser";
            tabControlUser.SelectedIndex = 0;
            tabControlUser.Size = new Size(1043, 412);
            tabControlUser.TabIndex = 0;
            // 
            // tabPageAddUser
            // 
            tabPageAddUser.Controls.Add(buttonAdd);
            tabPageAddUser.Controls.Add(comboBoxStatus);
            tabPageAddUser.Controls.Add(comboBoxRole);
            tabPageAddUser.Controls.Add(label4);
            tabPageAddUser.Controls.Add(label5);
            tabPageAddUser.Controls.Add(textBoxPassword);
            tabPageAddUser.Controls.Add(label3);
            tabPageAddUser.Controls.Add(textBoxUsername);
            tabPageAddUser.Controls.Add(label2);
            tabPageAddUser.Controls.Add(label1);
            tabPageAddUser.Location = new Point(4, 4);
            tabPageAddUser.Name = "tabPageAddUser";
            tabPageAddUser.Padding = new Padding(3);
            tabPageAddUser.Size = new Size(1035, 384);
            tabPageAddUser.TabIndex = 0;
            tabPageAddUser.Text = "Ajouter un utilisateur";
            tabPageAddUser.UseVisualStyleBackColor = true;
            tabPageAddUser.Leave += tabPageAddUser_Leave;
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
            buttonAdd.Location = new Point(385, 320);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(206, 34);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Ajouter";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Anchor = AnchorStyles.None;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Actif", "Inactif" });
            comboBoxStatus.Location = new Point(619, 216);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(223, 23);
            comboBoxStatus.TabIndex = 10;
            // 
            // comboBoxRole
            // 
            comboBoxRole.Anchor = AnchorStyles.None;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Admin", "Personnel" });
            comboBoxRole.Location = new Point(168, 216);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(223, 23);
            comboBoxRole.TabIndex = 9;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label4.Location = new Point(581, 182);
            label4.Name = "label4";
            label4.Size = new Size(54, 16);
            label4.TabIndex = 7;
            label4.Text = "Status :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label5.Location = new Point(130, 182);
            label5.Name = "label5";
            label5.Size = new Size(44, 16);
            label5.TabIndex = 5;
            label5.Text = "Role :";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Location = new Point(619, 115);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(223, 21);
            textBoxPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label3.Location = new Point(581, 81);
            label3.Name = "label3";
            label3.Size = new Size(76, 16);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.None;
            textBoxUsername.Location = new Point(168, 115);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(223, 21);
            textBoxUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label2.Location = new Point(130, 81);
            label2.Name = "label2";
            label2.Size = new Size(79, 16);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(25, 135, 84);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(168, 18);
            label1.TabIndex = 0;
            label1.Text = "Ajouter un utilisateur : ";
            // 
            // tabPageSearchUser
            // 
            tabPageSearchUser.Controls.Add(dataGridViewUser);
            tabPageSearchUser.Controls.Add(textBoxSearchUsername);
            tabPageSearchUser.Controls.Add(label7);
            tabPageSearchUser.Controls.Add(label6);
            tabPageSearchUser.Location = new Point(4, 4);
            tabPageSearchUser.Name = "tabPageSearchUser";
            tabPageSearchUser.Padding = new Padding(3);
            tabPageSearchUser.Size = new Size(1035, 383);
            tabPageSearchUser.TabIndex = 1;
            tabPageSearchUser.Text = "Rechercher un utilisateur";
            tabPageSearchUser.UseVisualStyleBackColor = true;
            tabPageSearchUser.Enter += tabPageSearchUser_Enter;
            tabPageSearchUser.Leave += tabPageSearchUser_Leave;
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.AllowUserToAddRows = false;
            dataGridViewUser.AllowUserToDeleteRows = false;
            dataGridViewUser.Anchor = AnchorStyles.None;
            dataGridViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUser.BackgroundColor = SystemColors.AppWorkspace;
            dataGridViewUser.BorderStyle = BorderStyle.None;
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewUser.Location = new Point(62, 153);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.ReadOnly = true;
            dataGridViewUser.RowHeadersWidth = 51;
            dataGridViewUser.Size = new Size(937, 202);
            dataGridViewUser.TabIndex = 5;
            dataGridViewUser.CellClick += dataGridViewUser_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id";
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "username";
            Column2.HeaderText = "Username";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "password";
            Column3.HeaderText = "Password";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "role";
            Column4.HeaderText = "Role";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "status";
            Column5.HeaderText = "Status";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // textBoxSearchUsername
            // 
            textBoxSearchUsername.Anchor = AnchorStyles.None;
            textBoxSearchUsername.Location = new Point(174, 84);
            textBoxSearchUsername.Name = "textBoxSearchUsername";
            textBoxSearchUsername.Size = new Size(223, 21);
            textBoxSearchUsername.TabIndex = 4;
            textBoxSearchUsername.TextChanged += textBoxSearchUsername_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label7.Location = new Point(136, 50);
            label7.Name = "label7";
            label7.Size = new Size(79, 16);
            label7.TabIndex = 3;
            label7.Text = "Username :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(25, 135, 84);
            label6.Location = new Point(3, 3);
            label6.Name = "label6";
            label6.Size = new Size(189, 18);
            label6.TabIndex = 0;
            label6.Text = "Rechercher un utilisateur";
            // 
            // tabPageUpdateAndDeleteUser
            // 
            tabPageUpdateAndDeleteUser.Controls.Add(buttonDelete);
            tabPageUpdateAndDeleteUser.Controls.Add(buttonUpdate);
            tabPageUpdateAndDeleteUser.Controls.Add(comboBoxStatus1);
            tabPageUpdateAndDeleteUser.Controls.Add(comboBoxRole1);
            tabPageUpdateAndDeleteUser.Controls.Add(label8);
            tabPageUpdateAndDeleteUser.Controls.Add(label9);
            tabPageUpdateAndDeleteUser.Controls.Add(textBoxPassword1);
            tabPageUpdateAndDeleteUser.Controls.Add(label10);
            tabPageUpdateAndDeleteUser.Controls.Add(textBoxUsername1);
            tabPageUpdateAndDeleteUser.Controls.Add(label11);
            tabPageUpdateAndDeleteUser.Controls.Add(label12);
            tabPageUpdateAndDeleteUser.Location = new Point(4, 4);
            tabPageUpdateAndDeleteUser.Name = "tabPageUpdateAndDeleteUser";
            tabPageUpdateAndDeleteUser.Padding = new Padding(3);
            tabPageUpdateAndDeleteUser.Size = new Size(1035, 383);
            tabPageUpdateAndDeleteUser.TabIndex = 2;
            tabPageUpdateAndDeleteUser.Text = "Mettre à jour et supprimer l'utilisateur";
            tabPageUpdateAndDeleteUser.UseVisualStyleBackColor = true;
            tabPageUpdateAndDeleteUser.Leave += tabPageUpdateAndDeleteUser_Leave;
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
            buttonDelete.Location = new Point(501, 320);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(206, 34);
            buttonDelete.TabIndex = 22;
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
            buttonUpdate.Location = new Point(266, 320);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(206, 34);
            buttonUpdate.TabIndex = 21;
            buttonUpdate.Text = "Modifier";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // comboBoxStatus1
            // 
            comboBoxStatus1.Anchor = AnchorStyles.None;
            comboBoxStatus1.FormattingEnabled = true;
            comboBoxStatus1.Items.AddRange(new object[] { "Actif", "Inactif" });
            comboBoxStatus1.Location = new Point(616, 216);
            comboBoxStatus1.Name = "comboBoxStatus1";
            comboBoxStatus1.Size = new Size(223, 23);
            comboBoxStatus1.TabIndex = 20;
            // 
            // comboBoxRole1
            // 
            comboBoxRole1.Anchor = AnchorStyles.None;
            comboBoxRole1.FormattingEnabled = true;
            comboBoxRole1.Items.AddRange(new object[] { "Admin", "Personnel" });
            comboBoxRole1.Location = new Point(165, 216);
            comboBoxRole1.Name = "comboBoxRole1";
            comboBoxRole1.Size = new Size(223, 23);
            comboBoxRole1.TabIndex = 19;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label8.Location = new Point(578, 182);
            label8.Name = "label8";
            label8.Size = new Size(54, 16);
            label8.TabIndex = 18;
            label8.Text = "Status :";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label9.Location = new Point(127, 182);
            label9.Name = "label9";
            label9.Size = new Size(44, 16);
            label9.TabIndex = 17;
            label9.Text = "Role :";
            // 
            // textBoxPassword1
            // 
            textBoxPassword1.Anchor = AnchorStyles.None;
            textBoxPassword1.Location = new Point(616, 115);
            textBoxPassword1.Name = "textBoxPassword1";
            textBoxPassword1.Size = new Size(223, 21);
            textBoxPassword1.TabIndex = 16;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label10.Location = new Point(578, 81);
            label10.Name = "label10";
            label10.Size = new Size(76, 16);
            label10.TabIndex = 15;
            label10.Text = "Password :";
            // 
            // textBoxUsername1
            // 
            textBoxUsername1.Anchor = AnchorStyles.None;
            textBoxUsername1.Location = new Point(165, 115);
            textBoxUsername1.Name = "textBoxUsername1";
            textBoxUsername1.Size = new Size(223, 21);
            textBoxUsername1.TabIndex = 14;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label11.Location = new Point(127, 81);
            label11.Name = "label11";
            label11.Size = new Size(79, 16);
            label11.TabIndex = 13;
            label11.Text = "Username :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(25, 135, 84);
            label12.Location = new Point(0, 3);
            label12.Name = "label12";
            label12.Size = new Size(288, 18);
            label12.TabIndex = 12;
            label12.Text = "Mettre à jour et supprimer l'utilisateur : ";
            // 
            // UserControlSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlUser);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UserControlSetting";
            Size = new Size(1102, 462);
            tabControlUser.ResumeLayout(false);
            tabPageAddUser.ResumeLayout(false);
            tabPageAddUser.PerformLayout();
            tabPageSearchUser.ResumeLayout(false);
            tabPageSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            tabPageUpdateAndDeleteUser.ResumeLayout(false);
            tabPageUpdateAndDeleteUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlUser;
        private TabPage tabPageAddUser;
        private TabPage tabPageSearchUser;
        private Label label1;
        private TextBox textBoxPassword;
        private Label label3;
        private TextBox textBoxUsername;
        private Label label2;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxStatus;
        private ComboBox comboBoxRole;
        private Button buttonAdd;
        private Label label6;
        private TextBox textBoxSearchUsername;
        private Label label7;
        private DataGridView dataGridViewUser;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TabPage tabPageUpdateAndDeleteUser;
        private Button buttonUpdate;
        private ComboBox comboBoxStatus1;
        private ComboBox comboBoxRole1;
        private Label label8;
        private Label label9;
        private TextBox textBoxPassword1;
        private Label label10;
        private TextBox textBoxUsername1;
        private Label label11;
        private Label label12;
        private Button buttonDelete;
    }
}
