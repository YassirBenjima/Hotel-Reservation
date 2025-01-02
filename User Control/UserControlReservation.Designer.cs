namespace ReservationHotel.User_Control
{
    partial class UserControlReservation
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
            tabControlReservation = new TabControl();
            tabPageAddReservation = new TabPage();
            dateTimePickerOut = new DateTimePicker();
            dateTimePickerIn = new DateTimePicker();
            comboBoxTypeRoomReservation = new ComboBox();
            comboBoxRoomNumberReservation = new ComboBox();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxClientIdReservation = new TextBox();
            buttonAdd = new Button();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageSearchReservation = new TabPage();
            buttonImport = new Button();
            buttonExport = new Button();
            dataGridViewReservation = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Départ = new DataGridViewTextBoxColumn();
            textBoxSearchClientId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            tabPageUpdateDeleteReservation = new TabPage();
            buttonCancel = new Button();
            buttonUpdate = new Button();
            dateTimePickerOut1 = new DateTimePicker();
            dateTimePickerIn1 = new DateTimePicker();
            comboBoxTypeRoomReservation1 = new ComboBox();
            comboBoxRoomNumberReservation1 = new ComboBox();
            label3 = new Label();
            label11 = new Label();
            textBoxClientIdReservation1 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            tabControlReservation.SuspendLayout();
            tabPageAddReservation.SuspendLayout();
            tabPageSearchReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservation).BeginInit();
            tabPageUpdateDeleteReservation.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlReservation
            // 
            tabControlReservation.Alignment = TabAlignment.Bottom;
            tabControlReservation.Anchor = AnchorStyles.None;
            tabControlReservation.Controls.Add(tabPageAddReservation);
            tabControlReservation.Controls.Add(tabPageSearchReservation);
            tabControlReservation.Controls.Add(tabPageUpdateDeleteReservation);
            tabControlReservation.Location = new Point(31, 24);
            tabControlReservation.Name = "tabControlReservation";
            tabControlReservation.SelectedIndex = 0;
            tabControlReservation.Size = new Size(1043, 412);
            tabControlReservation.TabIndex = 0;
            // 
            // tabPageAddReservation
            // 
            tabPageAddReservation.Controls.Add(dateTimePickerOut);
            tabPageAddReservation.Controls.Add(dateTimePickerIn);
            tabPageAddReservation.Controls.Add(comboBoxTypeRoomReservation);
            tabPageAddReservation.Controls.Add(comboBoxRoomNumberReservation);
            tabPageAddReservation.Controls.Add(label10);
            tabPageAddReservation.Controls.Add(label8);
            tabPageAddReservation.Controls.Add(label9);
            tabPageAddReservation.Controls.Add(textBoxClientIdReservation);
            tabPageAddReservation.Controls.Add(buttonAdd);
            tabPageAddReservation.Controls.Add(label4);
            tabPageAddReservation.Controls.Add(label5);
            tabPageAddReservation.Controls.Add(label2);
            tabPageAddReservation.Controls.Add(label1);
            tabPageAddReservation.Location = new Point(4, 4);
            tabPageAddReservation.Name = "tabPageAddReservation";
            tabPageAddReservation.Padding = new Padding(3);
            tabPageAddReservation.Size = new Size(1035, 384);
            tabPageAddReservation.TabIndex = 0;
            tabPageAddReservation.Text = "Ajouter une réservation";
            tabPageAddReservation.UseVisualStyleBackColor = true;
            tabPageAddReservation.Leave += tabPageAddReservation_Leave;
            // 
            // dateTimePickerOut
            // 
            dateTimePickerOut.Location = new Point(616, 282);
            dateTimePickerOut.Name = "dateTimePickerOut";
            dateTimePickerOut.Size = new Size(223, 21);
            dateTimePickerOut.TabIndex = 63;
            // 
            // dateTimePickerIn
            // 
            dateTimePickerIn.Location = new Point(165, 282);
            dateTimePickerIn.Name = "dateTimePickerIn";
            dateTimePickerIn.Size = new Size(223, 21);
            dateTimePickerIn.TabIndex = 62;
            // 
            // comboBoxTypeRoomReservation
            // 
            comboBoxTypeRoomReservation.Anchor = AnchorStyles.None;
            comboBoxTypeRoomReservation.FormattingEnabled = true;
            comboBoxTypeRoomReservation.Location = new Point(165, 92);
            comboBoxTypeRoomReservation.Name = "comboBoxTypeRoomReservation";
            comboBoxTypeRoomReservation.Size = new Size(223, 23);
            comboBoxTypeRoomReservation.TabIndex = 61;
            comboBoxTypeRoomReservation.SelectedIndexChanged += comboBoxTypeRoomReservation_SelectedIndexChanged;
            // 
            // comboBoxRoomNumberReservation
            // 
            comboBoxRoomNumberReservation.Anchor = AnchorStyles.None;
            comboBoxRoomNumberReservation.FormattingEnabled = true;
            comboBoxRoomNumberReservation.Location = new Point(616, 93);
            comboBoxRoomNumberReservation.Name = "comboBoxRoomNumberReservation";
            comboBoxRoomNumberReservation.Size = new Size(223, 23);
            comboBoxRoomNumberReservation.TabIndex = 59;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label10.Location = new Point(743, 66);
            label10.Name = "label10";
            label10.Size = new Size(0, 16);
            label10.TabIndex = 58;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label8.Location = new Point(578, 236);
            label8.Name = "label8";
            label8.Size = new Size(57, 16);
            label8.TabIndex = 56;
            label8.Text = "Départ :";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label9.Location = new Point(127, 236);
            label9.Name = "label9";
            label9.Size = new Size(111, 16);
            label9.TabIndex = 55;
            label9.Text = "Enregistrement :";
            // 
            // textBoxClientIdReservation
            // 
            textBoxClientIdReservation.Anchor = AnchorStyles.None;
            textBoxClientIdReservation.Location = new Point(165, 184);
            textBoxClientIdReservation.Name = "textBoxClientIdReservation";
            textBoxClientIdReservation.Size = new Size(223, 21);
            textBoxClientIdReservation.TabIndex = 54;
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
            buttonAdd.TabIndex = 53;
            buttonAdd.Text = "Ajouter";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label4.Location = new Point(127, 138);
            label4.Name = "label4";
            label4.Size = new Size(68, 16);
            label4.TabIndex = 52;
            label4.Text = "Client Id :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label5.Location = new Point(578, 49);
            label5.Name = "label5";
            label5.Size = new Size(145, 16);
            label5.TabIndex = 51;
            label5.Text = "Numéro de chambre :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label2.Location = new Point(127, 49);
            label2.Name = "label2";
            label2.Size = new Size(125, 16);
            label2.TabIndex = 48;
            label2.Text = "Type de chambre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(25, 135, 84);
            label1.Location = new Point(0, 3);
            label1.Name = "label1";
            label1.Size = new Size(188, 18);
            label1.TabIndex = 47;
            label1.Text = "Ajouter une réservation : ";
            // 
            // tabPageSearchReservation
            // 
            tabPageSearchReservation.Controls.Add(buttonImport);
            tabPageSearchReservation.Controls.Add(buttonExport);
            tabPageSearchReservation.Controls.Add(dataGridViewReservation);
            tabPageSearchReservation.Controls.Add(textBoxSearchClientId);
            tabPageSearchReservation.Controls.Add(label7);
            tabPageSearchReservation.Controls.Add(label6);
            tabPageSearchReservation.Location = new Point(4, 4);
            tabPageSearchReservation.Name = "tabPageSearchReservation";
            tabPageSearchReservation.Padding = new Padding(3);
            tabPageSearchReservation.Size = new Size(1035, 384);
            tabPageSearchReservation.TabIndex = 1;
            tabPageSearchReservation.Text = "Recherche réservation";
            tabPageSearchReservation.UseVisualStyleBackColor = true;
            tabPageSearchReservation.Enter += tabPageSearchReservation_Enter;
            tabPageSearchReservation.Leave += tabPageSearchReservation_Leave;
            // 
            // buttonImport
            // 
            buttonImport.Anchor = AnchorStyles.None;
            buttonImport.BackColor = Color.FromArgb(25, 135, 84);
            buttonImport.Cursor = Cursors.Hand;
            buttonImport.FlatAppearance.BorderSize = 0;
            buttonImport.FlatStyle = FlatStyle.Flat;
            buttonImport.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            buttonImport.ForeColor = Color.White;
            buttonImport.Location = new Point(881, 44);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(100, 34);
            buttonImport.TabIndex = 78;
            buttonImport.Text = "Import";
            buttonImport.UseVisualStyleBackColor = false;
            buttonImport.Click += buttonImport_Click;
            // 
            // buttonExport
            // 
            buttonExport.Anchor = AnchorStyles.None;
            buttonExport.BackColor = Color.FromArgb(25, 135, 84);
            buttonExport.Cursor = Cursors.Hand;
            buttonExport.FlatAppearance.BorderSize = 0;
            buttonExport.FlatStyle = FlatStyle.Flat;
            buttonExport.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            buttonExport.ForeColor = Color.White;
            buttonExport.Location = new Point(750, 44);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(100, 34);
            buttonExport.TabIndex = 77;
            buttonExport.Text = "Export";
            buttonExport.UseVisualStyleBackColor = false;
            buttonExport.Click += buttonExport_Click;
            // 
            // dataGridViewReservation
            // 
            dataGridViewReservation.AllowUserToAddRows = false;
            dataGridViewReservation.AllowUserToDeleteRows = false;
            dataGridViewReservation.Anchor = AnchorStyles.None;
            dataGridViewReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReservation.BackgroundColor = SystemColors.AppWorkspace;
            dataGridViewReservation.BorderStyle = BorderStyle.None;
            dataGridViewReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservation.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column6, Column5, Départ });
            dataGridViewReservation.Location = new Point(44, 160);
            dataGridViewReservation.Name = "dataGridViewReservation";
            dataGridViewReservation.ReadOnly = true;
            dataGridViewReservation.RowHeadersWidth = 51;
            dataGridViewReservation.Size = new Size(937, 202);
            dataGridViewReservation.TabIndex = 17;
            dataGridViewReservation.CellClick += dataGridViewReservation_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Reservation_id";
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Reservation_Room_Type";
            Column2.HeaderText = "Type de chambre";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Reservation_Room_Number";
            Column3.HeaderText = "Numéro de chambre";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Reservation_Client_ID";
            Column4.HeaderText = "Identifiant client";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Client_Name";
            Column6.HeaderText = "Nom du client";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Reservation_In";
            Column5.HeaderText = "Enregistrement";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Départ
            // 
            Départ.DataPropertyName = "Reservation_Out";
            Départ.HeaderText = "Départ";
            Départ.Name = "Départ";
            Départ.ReadOnly = true;
            // 
            // textBoxSearchClientId
            // 
            textBoxSearchClientId.Anchor = AnchorStyles.None;
            textBoxSearchClientId.Location = new Point(168, 96);
            textBoxSearchClientId.Name = "textBoxSearchClientId";
            textBoxSearchClientId.Size = new Size(223, 21);
            textBoxSearchClientId.TabIndex = 16;
            textBoxSearchClientId.TextChanged += textBoxSearchClientId_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label7.Location = new Point(130, 62);
            label7.Name = "label7";
            label7.Size = new Size(68, 16);
            label7.TabIndex = 15;
            label7.Text = "Client Id :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(25, 135, 84);
            label6.Location = new Point(0, 3);
            label6.Name = "label6";
            label6.Size = new Size(184, 18);
            label6.TabIndex = 14;
            label6.Text = "Recherche réservation : ";
            // 
            // tabPageUpdateDeleteReservation
            // 
            tabPageUpdateDeleteReservation.Controls.Add(buttonCancel);
            tabPageUpdateDeleteReservation.Controls.Add(buttonUpdate);
            tabPageUpdateDeleteReservation.Controls.Add(dateTimePickerOut1);
            tabPageUpdateDeleteReservation.Controls.Add(dateTimePickerIn1);
            tabPageUpdateDeleteReservation.Controls.Add(comboBoxTypeRoomReservation1);
            tabPageUpdateDeleteReservation.Controls.Add(comboBoxRoomNumberReservation1);
            tabPageUpdateDeleteReservation.Controls.Add(label3);
            tabPageUpdateDeleteReservation.Controls.Add(label11);
            tabPageUpdateDeleteReservation.Controls.Add(textBoxClientIdReservation1);
            tabPageUpdateDeleteReservation.Controls.Add(label12);
            tabPageUpdateDeleteReservation.Controls.Add(label13);
            tabPageUpdateDeleteReservation.Controls.Add(label14);
            tabPageUpdateDeleteReservation.Controls.Add(label15);
            tabPageUpdateDeleteReservation.Location = new Point(4, 4);
            tabPageUpdateDeleteReservation.Name = "tabPageUpdateDeleteReservation";
            tabPageUpdateDeleteReservation.Padding = new Padding(3);
            tabPageUpdateDeleteReservation.Size = new Size(1035, 384);
            tabPageUpdateDeleteReservation.TabIndex = 2;
            tabPageUpdateDeleteReservation.Text = "Mettre à jour et annuler la réservation";
            tabPageUpdateDeleteReservation.UseVisualStyleBackColor = true;
            tabPageUpdateDeleteReservation.Enter += tabPageUpdateDeleteReservation_Enter;
            tabPageUpdateDeleteReservation.Leave += tabPageUpdateDeleteReservation_Leave;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.None;
            buttonCancel.BackColor = Color.Red;
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(532, 331);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(206, 34);
            buttonCancel.TabIndex = 77;
            buttonCancel.Text = "Annuler";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
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
            buttonUpdate.Location = new Point(297, 331);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(206, 34);
            buttonUpdate.TabIndex = 76;
            buttonUpdate.Text = "Modifier";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // dateTimePickerOut1
            // 
            dateTimePickerOut1.Location = new Point(616, 282);
            dateTimePickerOut1.Name = "dateTimePickerOut1";
            dateTimePickerOut1.Size = new Size(223, 21);
            dateTimePickerOut1.TabIndex = 75;
            dateTimePickerOut1.ValueChanged += dateTimePickerOut1_ValueChanged;
            // 
            // dateTimePickerIn1
            // 
            dateTimePickerIn1.Location = new Point(165, 282);
            dateTimePickerIn1.Name = "dateTimePickerIn1";
            dateTimePickerIn1.Size = new Size(223, 21);
            dateTimePickerIn1.TabIndex = 74;
            dateTimePickerIn1.ValueChanged += dateTimePickerIn1_ValueChanged;
            // 
            // comboBoxTypeRoomReservation1
            // 
            comboBoxTypeRoomReservation1.Anchor = AnchorStyles.None;
            comboBoxTypeRoomReservation1.FormattingEnabled = true;
            comboBoxTypeRoomReservation1.Items.AddRange(new object[] { "Seule", "Double", "Twin", "Suite", "Deluxe", "Studio" });
            comboBoxTypeRoomReservation1.Location = new Point(165, 92);
            comboBoxTypeRoomReservation1.Name = "comboBoxTypeRoomReservation1";
            comboBoxTypeRoomReservation1.Size = new Size(223, 23);
            comboBoxTypeRoomReservation1.TabIndex = 73;
            comboBoxTypeRoomReservation1.SelectedIndexChanged += comboBoxTypeRoomReservation1_SelectedIndexChanged;
            // 
            // comboBoxRoomNumberReservation1
            // 
            comboBoxRoomNumberReservation1.Anchor = AnchorStyles.None;
            comboBoxRoomNumberReservation1.FormattingEnabled = true;
            comboBoxRoomNumberReservation1.Items.AddRange(new object[] { "Oui", "Non" });
            comboBoxRoomNumberReservation1.Location = new Point(616, 93);
            comboBoxRoomNumberReservation1.Name = "comboBoxRoomNumberReservation1";
            comboBoxRoomNumberReservation1.Size = new Size(223, 23);
            comboBoxRoomNumberReservation1.TabIndex = 72;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label3.Location = new Point(578, 236);
            label3.Name = "label3";
            label3.Size = new Size(57, 16);
            label3.TabIndex = 71;
            label3.Text = "Départ :";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label11.Location = new Point(127, 236);
            label11.Name = "label11";
            label11.Size = new Size(111, 16);
            label11.TabIndex = 70;
            label11.Text = "Enregistrement :";
            // 
            // textBoxClientIdReservation1
            // 
            textBoxClientIdReservation1.Anchor = AnchorStyles.None;
            textBoxClientIdReservation1.Location = new Point(165, 184);
            textBoxClientIdReservation1.Name = "textBoxClientIdReservation1";
            textBoxClientIdReservation1.Size = new Size(223, 21);
            textBoxClientIdReservation1.TabIndex = 69;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label12.Location = new Point(127, 138);
            label12.Name = "label12";
            label12.Size = new Size(68, 16);
            label12.TabIndex = 67;
            label12.Text = "Client Id :";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label13.Location = new Point(578, 49);
            label13.Name = "label13";
            label13.Size = new Size(145, 16);
            label13.TabIndex = 66;
            label13.Text = "Numéro de chambre :";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label14.Location = new Point(127, 49);
            label14.Name = "label14";
            label14.Size = new Size(125, 16);
            label14.TabIndex = 65;
            label14.Text = "Type de chambre :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(25, 135, 84);
            label15.Location = new Point(0, 3);
            label15.Name = "label15";
            label15.Size = new Size(289, 18);
            label15.TabIndex = 64;
            label15.Text = "Mettre à jour et annuler la réservation : ";
            // 
            // UserControlReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlReservation);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UserControlReservation";
            Size = new Size(1102, 462);
            Load += UserControlReservation_Load;
            tabControlReservation.ResumeLayout(false);
            tabPageAddReservation.ResumeLayout(false);
            tabPageAddReservation.PerformLayout();
            tabPageSearchReservation.ResumeLayout(false);
            tabPageSearchReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservation).EndInit();
            tabPageUpdateDeleteReservation.ResumeLayout(false);
            tabPageUpdateDeleteReservation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlReservation;
        private TabPage tabPageAddReservation;
        private TabPage tabPageSearchReservation;
        private TabPage tabPageUpdateDeleteReservation;
        private ComboBox comboBoxTypeRoomReservation;
        private ComboBox comboBoxRoomNumberReservation;
        private Label label10;
        private Label label8;
        private Label label9;
        private TextBox textBoxClientIdReservation;
        private Button buttonAdd;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerOut;
        private DateTimePicker dateTimePickerIn;
        private DataGridView dataGridViewReservation;
        private TextBox textBoxSearchClientId;
        private Label label7;
        private Label label6;
        private DateTimePicker dateTimePickerOut1;
        private DateTimePicker dateTimePickerIn1;
        private ComboBox comboBoxTypeRoomReservation1;
        private ComboBox comboBoxRoomNumberReservation1;
        private Label label3;
        private Label label11;
        private TextBox textBoxClientIdReservation1;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button buttonCancel;
        private Button buttonUpdate;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Départ;
        private Button buttonImport;
        private Button buttonExport;
    }
}
