namespace ReservationHotel
{
    partial class FormLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            pictureBoxClose = new PictureBox();
            pictureBoxMinimize = new PictureBox();
            toolTip1 = new ToolTip(components);
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            pictureBoxShow = new PictureBox();
            pictureBoxHide = new PictureBox();
            label5 = new Label();
            textBoxPassword = new TextBox();
            label4 = new Label();
            buttonLogIn = new Button();
            textBoxUsername = new TextBox();
            label3 = new Label();
            pictureBoxEmsi = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmsi).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = Properties.Resources.Screenshot_2024_12_15_174054;
            pictureBoxClose.Location = new Point(1885, -2);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(35, 37);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 0;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            pictureBoxClose.MouseHover += pictureBoxClose_MouseHover;
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Image = (Image)resources.GetObject("pictureBoxMinimize.Image");
            pictureBoxMinimize.Location = new Point(1844, -2);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(35, 37);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 1;
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            pictureBoxMinimize.MouseHover += pictureBoxMinimize_MouseHover;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 1004);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 57);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1752, 22);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 1;
            label2.Text = "Tous droits réservés.";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(337, 15);
            label1.TabIndex = 0;
            label1.Text = "© 2025 ÉCOLE MAROCAINE DES SCIENCES DE L'INGÉNIEUR";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(pictureBoxShow);
            groupBox1.Controls.Add(pictureBoxHide);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(buttonLogIn);
            groupBox1.Controls.Add(textBoxUsername);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(771, 366);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(467, 342);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Veuillez vous connecter";
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxShow.Cursor = Cursors.Hand;
            pictureBoxShow.Image = Properties.Resources._6684701;
            pictureBoxShow.Location = new Point(399, 178);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Size = new Size(29, 24);
            pictureBoxShow.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxShow.TabIndex = 8;
            pictureBoxShow.TabStop = false;
            pictureBoxShow.Click += pictureBoxShow_Click;
            pictureBoxShow.MouseHover += pictureBoxShow_MouseHover;
            // 
            // pictureBoxHide
            // 
            pictureBoxHide.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHide.Cursor = Cursors.Hand;
            pictureBoxHide.Image = (Image)resources.GetObject("pictureBoxHide.Image");
            pictureBoxHide.Location = new Point(399, 178);
            pictureBoxHide.Name = "pictureBoxHide";
            pictureBoxHide.Size = new Size(29, 24);
            pictureBoxHide.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHide.TabIndex = 7;
            pictureBoxHide.TabStop = false;
            pictureBoxHide.Click += pictureBoxHide_Click;
            pictureBoxHide.MouseHover += pictureBoxHide_MouseHover;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(171, 248);
            label5.Name = "label5";
            label5.Size = new Size(160, 18);
            label5.TabIndex = 5;
            label5.Text = "Mot de passe oublié?";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Location = new Point(62, 176);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(331, 22);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 146);
            label4.Name = "label4";
            label4.Size = new Size(111, 18);
            label4.TabIndex = 3;
            label4.Text = "Mot de passe :";
            // 
            // buttonLogIn
            // 
            buttonLogIn.Anchor = AnchorStyles.None;
            buttonLogIn.BackColor = Color.FromArgb(40, 167, 69);
            buttonLogIn.FlatAppearance.BorderSize = 0;
            buttonLogIn.FlatStyle = FlatStyle.Flat;
            buttonLogIn.ForeColor = Color.White;
            buttonLogIn.Location = new Point(62, 279);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(371, 38);
            buttonLogIn.TabIndex = 2;
            buttonLogIn.Text = "Connexion";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.None;
            textBoxUsername.Location = new Point(62, 94);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(366, 22);
            textBoxUsername.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 64);
            label3.Name = "label3";
            label3.Size = new Size(136, 18);
            label3.TabIndex = 0;
            label3.Text = "Nom d'utilisateur :";
            // 
            // pictureBoxEmsi
            // 
            pictureBoxEmsi.Anchor = AnchorStyles.None;
            pictureBoxEmsi.BackColor = Color.Transparent;
            pictureBoxEmsi.Image = Properties.Resources.Screenshot_2024_12_15_182026;
            pictureBoxEmsi.Location = new Point(739, 194);
            pictureBoxEmsi.Name = "pictureBoxEmsi";
            pictureBoxEmsi.Size = new Size(527, 156);
            pictureBoxEmsi.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxEmsi.TabIndex = 2;
            pictureBoxEmsi.TabStop = false;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1061);
            Controls.Add(pictureBoxEmsi);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBoxClose);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation_Hotel | Login";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmsi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxMinimize;
        private ToolTip toolTip1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox textBoxPassword;
        private Label label4;
        private Button buttonLogIn;
        private TextBox textBoxUsername;
        private Label label3;
        private Label label5;
        private PictureBox pictureBoxHide;
        private PictureBox pictureBoxShow;
        private PictureBox pictureBoxEmsi;
    }
}
