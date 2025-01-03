namespace ReservationHotel
{
    partial class FormDashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            panel1 = new Panel();
            labelUsername = new Label();
            panelSlide = new Panel();
            buttonSetting = new Button();
            buttonReservation = new Button();
            buttonRoom = new Button();
            buttonClient = new Button();
            buttonDashboard = new Button();
            labelDateTime = new Label();
            linkLabelLogOut = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            userControlSetting1 = new User_Control.UserControlSetting();
            userControlClient1 = new User_Control.UserControlClient();
            userControlRoom1 = new User_Control.UserControlRoom();
            userControlReservation1 = new User_Control.UserControlReservation();
            userControlDashoard1 = new User_Control.UserControlDashoard();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 135, 84);
            panel1.Controls.Add(labelUsername);
            panel1.Controls.Add(panelSlide);
            panel1.Controls.Add(buttonSetting);
            panel1.Controls.Add(buttonReservation);
            panel1.Controls.Add(buttonRoom);
            panel1.Controls.Add(buttonClient);
            panel1.Controls.Add(buttonDashboard);
            panel1.Controls.Add(labelDateTime);
            panel1.Controls.Add(linkLabelLogOut);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1680, 94);
            panel1.TabIndex = 0;
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(1496, 30);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(22, 22);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "?";
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.White;
            panelSlide.Location = new Point(337, 31);
            panelSlide.Margin = new Padding(3, 2, 3, 2);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(9, 32);
            panelSlide.TabIndex = 0;
            // 
            // buttonSetting
            // 
            buttonSetting.FlatAppearance.BorderSize = 0;
            buttonSetting.FlatStyle = FlatStyle.Flat;
            buttonSetting.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSetting.ForeColor = Color.White;
            buttonSetting.Location = new Point(971, 32);
            buttonSetting.Margin = new Padding(3, 2, 3, 2);
            buttonSetting.Name = "buttonSetting";
            buttonSetting.Size = new Size(114, 29);
            buttonSetting.TabIndex = 5;
            buttonSetting.Text = "Paramètre";
            buttonSetting.UseVisualStyleBackColor = true;
            buttonSetting.Click += buttonSetting_Click;
            // 
            // buttonReservation
            // 
            buttonReservation.FlatAppearance.BorderSize = 0;
            buttonReservation.FlatStyle = FlatStyle.Flat;
            buttonReservation.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReservation.ForeColor = Color.White;
            buttonReservation.Location = new Point(822, 32);
            buttonReservation.Margin = new Padding(3, 2, 3, 2);
            buttonReservation.Name = "buttonReservation";
            buttonReservation.Size = new Size(130, 29);
            buttonReservation.TabIndex = 4;
            buttonReservation.Text = "Réservation";
            buttonReservation.UseVisualStyleBackColor = true;
            buttonReservation.Click += buttonReservation_Click;
            // 
            // buttonRoom
            // 
            buttonRoom.FlatAppearance.BorderSize = 0;
            buttonRoom.FlatStyle = FlatStyle.Flat;
            buttonRoom.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRoom.ForeColor = Color.White;
            buttonRoom.Location = new Point(668, 32);
            buttonRoom.Margin = new Padding(3, 2, 3, 2);
            buttonRoom.Name = "buttonRoom";
            buttonRoom.Size = new Size(114, 29);
            buttonRoom.TabIndex = 3;
            buttonRoom.Text = "Chambre";
            buttonRoom.UseVisualStyleBackColor = true;
            buttonRoom.Click += buttonRoom_Click;
            // 
            // buttonClient
            // 
            buttonClient.FlatAppearance.BorderSize = 0;
            buttonClient.FlatStyle = FlatStyle.Flat;
            buttonClient.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClient.ForeColor = Color.White;
            buttonClient.Location = new Point(522, 32);
            buttonClient.Margin = new Padding(3, 2, 3, 2);
            buttonClient.Name = "buttonClient";
            buttonClient.Size = new Size(114, 29);
            buttonClient.TabIndex = 2;
            buttonClient.Text = "Client";
            buttonClient.UseVisualStyleBackColor = true;
            buttonClient.Click += buttonClient_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Location = new Point(337, 32);
            buttonDashboard.Margin = new Padding(3, 2, 3, 2);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(164, 29);
            buttonDashboard.TabIndex = 1;
            buttonDashboard.Text = "Tableau de bord";
            buttonDashboard.UseVisualStyleBackColor = true;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDateTime.ForeColor = Color.White;
            labelDateTime.Location = new Point(21, 72);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(16, 16);
            labelDateTime.TabIndex = 0;
            labelDateTime.Text = "?";
            // 
            // linkLabelLogOut
            // 
            linkLabelLogOut.ActiveLinkColor = Color.White;
            linkLabelLogOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkLabelLogOut.AutoSize = true;
            linkLabelLogOut.DisabledLinkColor = Color.White;
            linkLabelLogOut.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelLogOut.ForeColor = Color.White;
            linkLabelLogOut.LinkColor = Color.White;
            linkLabelLogOut.Location = new Point(1600, 58);
            linkLabelLogOut.Name = "linkLabelLogOut";
            linkLabelLogOut.Size = new Size(65, 18);
            linkLabelLogOut.TabIndex = 0;
            linkLabelLogOut.TabStop = true;
            linkLabelLogOut.Text = "Log Out";
            linkLabelLogOut.VisitedLinkColor = Color.White;
            linkLabelLogOut.LinkClicked += linkLabelLogOut_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1600, 3);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 768);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1680, 42);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1517, 14);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 2;
            label2.Text = "Tous droits réservés.";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(337, 15);
            label1.TabIndex = 1;
            label1.Text = "© 2025 ÉCOLE MAROCAINE DES SCIENCES DE L'INGÉNIEUR";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // userControlSetting1
            // 
            userControlSetting1.BackColor = Color.White;
            userControlSetting1.Dock = DockStyle.Fill;
            userControlSetting1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlSetting1.Location = new Point(0, 94);
            userControlSetting1.Name = "userControlSetting1";
            userControlSetting1.Size = new Size(1680, 674);
            userControlSetting1.TabIndex = 1;
            userControlSetting1.Visible = false;
            // 
            // userControlClient1
            // 
            userControlClient1.BackColor = Color.White;
            userControlClient1.Dock = DockStyle.Fill;
            userControlClient1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlClient1.Location = new Point(0, 94);
            userControlClient1.Name = "userControlClient1";
            userControlClient1.Size = new Size(1680, 674);
            userControlClient1.TabIndex = 0;
            userControlClient1.Visible = false;
            // 
            // userControlRoom1
            // 
            userControlRoom1.BackColor = Color.White;
            userControlRoom1.Dock = DockStyle.Fill;
            userControlRoom1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlRoom1.Location = new Point(0, 94);
            userControlRoom1.Name = "userControlRoom1";
            userControlRoom1.Size = new Size(1680, 674);
            userControlRoom1.TabIndex = 0;
            userControlRoom1.Visible = false;
            // 
            // userControlReservation1
            // 
            userControlReservation1.Anchor = AnchorStyles.None;
            userControlReservation1.BackColor = Color.White;
            userControlReservation1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlReservation1.Location = new Point(273, 186);
            userControlReservation1.Name = "userControlReservation1";
            userControlReservation1.Size = new Size(1221, 582);
            userControlReservation1.TabIndex = 0;
            userControlReservation1.Visible = false;
            // 
            // userControlDashoard1
            // 
            userControlDashoard1.Anchor = AnchorStyles.None;
            userControlDashoard1.BackColor = Color.White;
            userControlDashoard1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlDashoard1.Location = new Point(273, 186);
            userControlDashoard1.Name = "userControlDashoard1";
            userControlDashoard1.Size = new Size(1102, 462);
            userControlDashoard1.TabIndex = 2;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1680, 810);
            Controls.Add(userControlDashoard1);
            Controls.Add(userControlReservation1);
            Controls.Add(userControlRoom1);
            Controls.Add(userControlClient1);
            Controls.Add(userControlSetting1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation_Hotel | Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += FormDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private LinkLabel linkLabelLogOut;
        private Label labelDateTime;
        private Label label3;
        private Label labelUsername;
        private Button buttonDashboard;
        private Button buttonSetting;
        private Button buttonReservation;
        private Button buttonRoom;
        private Button buttonClient;
        private Panel panelSlide;
        private System.Windows.Forms.Timer timer1;
        private User_Control.UserControlSetting userControlSetting1;
        private User_Control.UserControlClient userControlClient1;
        private User_Control.UserControlRoom userControlRoom1;
        private User_Control.UserControlReservation userControlReservation1;
        private User_Control.UserControlDashoard userControlDashoard1;
    }
}