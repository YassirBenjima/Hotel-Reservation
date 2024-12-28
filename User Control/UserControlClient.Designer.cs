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
            tabPage2 = new TabPage();
            buttonAdd = new Button();
            label4 = new Label();
            label5 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            textBoxFirstName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxAddress = new TextBox();
            textBoxPhone = new TextBox();
            tabControlClient.SuspendLayout();
            tabPageAddClient.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlClient
            // 
            tabControlClient.Alignment = TabAlignment.Bottom;
            tabControlClient.Anchor = AnchorStyles.None;
            tabControlClient.Controls.Add(tabPageAddClient);
            tabControlClient.Controls.Add(tabPage2);
            tabControlClient.Location = new Point(31, 24);
            tabControlClient.Name = "tabControlClient";
            tabControlClient.SelectedIndex = 0;
            tabControlClient.Size = new Size(1035, 383);
            tabControlClient.TabIndex = 0;
            // 
            // tabPageAddClient
            // 
            tabPageAddClient.Controls.Add(textBoxPhone);
            tabPageAddClient.Controls.Add(textBoxAddress);
            tabPageAddClient.Controls.Add(buttonAdd);
            tabPageAddClient.Controls.Add(label4);
            tabPageAddClient.Controls.Add(label5);
            tabPageAddClient.Controls.Add(textBoxName);
            tabPageAddClient.Controls.Add(label3);
            tabPageAddClient.Controls.Add(textBoxFirstName);
            tabPageAddClient.Controls.Add(label2);
            tabPageAddClient.Controls.Add(label1);
            tabPageAddClient.Location = new Point(4, 4);
            tabPageAddClient.Name = "tabPageAddClient";
            tabPageAddClient.Padding = new Padding(3);
            tabPageAddClient.Size = new Size(1027, 355);
            tabPageAddClient.TabIndex = 0;
            tabPageAddClient.Text = "Ajouter un client";
            tabPageAddClient.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1027, 355);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
            buttonAdd.Location = new Point(382, 316);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(206, 34);
            buttonAdd.TabIndex = 21;
            buttonAdd.Text = "Ajouter";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label4.Location = new Point(578, 178);
            label4.Name = "label4";
            label4.Size = new Size(65, 16);
            label4.TabIndex = 18;
            label4.Text = "Adresse :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label5.Location = new Point(127, 178);
            label5.Name = "label5";
            label5.Size = new Size(83, 16);
            label5.TabIndex = 17;
            label5.Text = "Téléphone :";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.Location = new Point(616, 111);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(223, 21);
            textBoxName.TabIndex = 16;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label3.Location = new Point(578, 77);
            label3.Name = "label3";
            label3.Size = new Size(44, 16);
            label3.TabIndex = 15;
            label3.Text = "Nom :";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Anchor = AnchorStyles.None;
            textBoxFirstName.Location = new Point(165, 111);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(223, 21);
            textBoxFirstName.TabIndex = 14;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label2.Location = new Point(127, 77);
            label2.Name = "label2";
            label2.Size = new Size(65, 16);
            label2.TabIndex = 13;
            label2.Text = "Prénom :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(25, 135, 84);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 18);
            label1.TabIndex = 12;
            label1.Text = "Ajouter un client :";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.None;
            textBoxAddress.Location = new Point(616, 224);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(223, 21);
            textBoxAddress.TabIndex = 22;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.None;
            textBoxPhone.Location = new Point(165, 224);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(223, 21);
            textBoxPhone.TabIndex = 23;
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
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlClient;
        private TabPage tabPageAddClient;
        private TabPage tabPage2;
        private Button buttonAdd;
        private Label label4;
        private Label label5;
        private TextBox textBoxName;
        private Label label3;
        private TextBox textBoxFirstName;
        private Label label2;
        private Label label1;
        private TextBox textBoxPhone;
        private TextBox textBoxAddress;
    }
}
