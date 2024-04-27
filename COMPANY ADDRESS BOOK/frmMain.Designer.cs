namespace COMPANY_ADDRESS_BOOK
{
    partial class frmMain
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel_slide = new Panel();
            btnExit = new Button();
            btnOptions = new Button();
            pnlSubMenuAgency = new Panel();
            btnManageAgency = new Button();
            btnRegisterAgency = new Button();
            btnAgency = new Button();
            pnlContactSubMenu = new Panel();
            btnStatus = new Button();
            btnManageContact = new Button();
            btnRegistrationContact = new Button();
            btnContact = new Button();
            panel_logo = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlMain = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            panel_slide.SuspendLayout();
            pnlSubMenuAgency.SuspendLayout();
            pnlContactSubMenu.SuspendLayout();
            panel_logo.SuspendLayout();
            pnlMain.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_slide
            // 
            panel_slide.BackColor = Color.YellowGreen;
            panel_slide.Controls.Add(btnExit);
            panel_slide.Controls.Add(btnOptions);
            panel_slide.Controls.Add(pnlSubMenuAgency);
            panel_slide.Controls.Add(btnAgency);
            panel_slide.Controls.Add(pnlContactSubMenu);
            panel_slide.Controls.Add(btnContact);
            panel_slide.Controls.Add(panel_logo);
            panel_slide.Dock = DockStyle.Left;
            panel_slide.ForeColor = Color.DeepPink;
            panel_slide.Location = new Point(0, 0);
            panel_slide.Name = "panel_slide";
            panel_slide.Size = new Size(200, 550);
            panel_slide.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.YellowGreen;
            btnExit.Dock = DockStyle.Top;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(0, 490);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 0, 0);
            btnExit.Size = new Size(200, 57);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnOptions
            // 
            btnOptions.BackColor = Color.YellowGreen;
            btnOptions.Dock = DockStyle.Top;
            btnOptions.FlatAppearance.BorderSize = 0;
            btnOptions.FlatStyle = FlatStyle.Flat;
            btnOptions.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOptions.ForeColor = Color.Black;
            btnOptions.Location = new Point(0, 433);
            btnOptions.Name = "btnOptions";
            btnOptions.Padding = new Padding(10, 0, 0, 0);
            btnOptions.Size = new Size(200, 57);
            btnOptions.TabIndex = 4;
            btnOptions.Text = "Options";
            btnOptions.TextAlign = ContentAlignment.MiddleLeft;
            btnOptions.UseVisualStyleBackColor = false;
            // 
            // pnlSubMenuAgency
            // 
            pnlSubMenuAgency.Controls.Add(btnManageAgency);
            pnlSubMenuAgency.Controls.Add(btnRegisterAgency);
            pnlSubMenuAgency.Dock = DockStyle.Top;
            pnlSubMenuAgency.Location = new Point(0, 346);
            pnlSubMenuAgency.Name = "pnlSubMenuAgency";
            pnlSubMenuAgency.Size = new Size(200, 87);
            pnlSubMenuAgency.TabIndex = 3;
            // 
            // btnManageAgency
            // 
            btnManageAgency.BackColor = Color.Lime;
            btnManageAgency.Dock = DockStyle.Top;
            btnManageAgency.FlatAppearance.BorderSize = 0;
            btnManageAgency.FlatStyle = FlatStyle.Flat;
            btnManageAgency.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnManageAgency.ForeColor = Color.Black;
            btnManageAgency.Location = new Point(0, 45);
            btnManageAgency.Name = "btnManageAgency";
            btnManageAgency.Padding = new Padding(35, 0, 0, 0);
            btnManageAgency.Size = new Size(200, 45);
            btnManageAgency.TabIndex = 1;
            btnManageAgency.Text = "Manage Agency";
            btnManageAgency.TextAlign = ContentAlignment.MiddleLeft;
            btnManageAgency.UseVisualStyleBackColor = false;
            // 
            // btnRegisterAgency
            // 
            btnRegisterAgency.BackColor = Color.Lime;
            btnRegisterAgency.Dock = DockStyle.Top;
            btnRegisterAgency.FlatAppearance.BorderSize = 0;
            btnRegisterAgency.FlatStyle = FlatStyle.Flat;
            btnRegisterAgency.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegisterAgency.ForeColor = Color.Black;
            btnRegisterAgency.Location = new Point(0, 0);
            btnRegisterAgency.Name = "btnRegisterAgency";
            btnRegisterAgency.Padding = new Padding(35, 0, 0, 0);
            btnRegisterAgency.Size = new Size(200, 45);
            btnRegisterAgency.TabIndex = 0;
            btnRegisterAgency.Text = "Registration";
            btnRegisterAgency.TextAlign = ContentAlignment.MiddleLeft;
            btnRegisterAgency.UseVisualStyleBackColor = false;
            // 
            // btnAgency
            // 
            btnAgency.BackColor = Color.YellowGreen;
            btnAgency.Dock = DockStyle.Top;
            btnAgency.FlatAppearance.BorderSize = 0;
            btnAgency.FlatStyle = FlatStyle.Flat;
            btnAgency.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgency.ForeColor = Color.Black;
            btnAgency.Location = new Point(0, 291);
            btnAgency.Name = "btnAgency";
            btnAgency.Padding = new Padding(10, 0, 0, 0);
            btnAgency.Size = new Size(200, 55);
            btnAgency.TabIndex = 2;
            btnAgency.Text = "Agency";
            btnAgency.TextAlign = ContentAlignment.MiddleLeft;
            btnAgency.UseVisualStyleBackColor = false;
            btnAgency.Click += btnAgency_Click;
            // 
            // pnlContactSubMenu
            // 
            pnlContactSubMenu.Controls.Add(btnStatus);
            pnlContactSubMenu.Controls.Add(btnManageContact);
            pnlContactSubMenu.Controls.Add(btnRegistrationContact);
            pnlContactSubMenu.Dock = DockStyle.Top;
            pnlContactSubMenu.Location = new Point(0, 155);
            pnlContactSubMenu.Name = "pnlContactSubMenu";
            pnlContactSubMenu.Size = new Size(200, 136);
            pnlContactSubMenu.TabIndex = 1;
            // 
            // btnStatus
            // 
            btnStatus.BackColor = Color.Lime;
            btnStatus.Dock = DockStyle.Top;
            btnStatus.FlatAppearance.BorderSize = 0;
            btnStatus.FlatStyle = FlatStyle.Flat;
            btnStatus.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnStatus.ForeColor = Color.Black;
            btnStatus.Location = new Point(0, 90);
            btnStatus.Name = "btnStatus";
            btnStatus.Padding = new Padding(35, 0, 0, 0);
            btnStatus.Size = new Size(200, 45);
            btnStatus.TabIndex = 2;
            btnStatus.Text = "Status";
            btnStatus.TextAlign = ContentAlignment.MiddleLeft;
            btnStatus.UseVisualStyleBackColor = false;
            // 
            // btnManageContact
            // 
            btnManageContact.BackColor = Color.Lime;
            btnManageContact.Dock = DockStyle.Top;
            btnManageContact.FlatAppearance.BorderSize = 0;
            btnManageContact.FlatStyle = FlatStyle.Flat;
            btnManageContact.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnManageContact.ForeColor = Color.Black;
            btnManageContact.Location = new Point(0, 45);
            btnManageContact.Name = "btnManageContact";
            btnManageContact.Padding = new Padding(35, 0, 0, 0);
            btnManageContact.Size = new Size(200, 45);
            btnManageContact.TabIndex = 1;
            btnManageContact.Text = "Manage Contact";
            btnManageContact.TextAlign = ContentAlignment.MiddleLeft;
            btnManageContact.UseVisualStyleBackColor = false;
            // 
            // btnRegistrationContact
            // 
            btnRegistrationContact.BackColor = Color.Lime;
            btnRegistrationContact.Dock = DockStyle.Top;
            btnRegistrationContact.FlatAppearance.BorderSize = 0;
            btnRegistrationContact.FlatStyle = FlatStyle.Flat;
            btnRegistrationContact.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrationContact.ForeColor = Color.Black;
            btnRegistrationContact.Location = new Point(0, 0);
            btnRegistrationContact.Name = "btnRegistrationContact";
            btnRegistrationContact.Padding = new Padding(35, 0, 0, 0);
            btnRegistrationContact.Size = new Size(200, 45);
            btnRegistrationContact.TabIndex = 0;
            btnRegistrationContact.Text = "Registration";
            btnRegistrationContact.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrationContact.UseVisualStyleBackColor = false;
            btnRegistrationContact.Click += btnRegistrationContact_Click;
            // 
            // btnContact
            // 
            btnContact.BackColor = Color.YellowGreen;
            btnContact.Dock = DockStyle.Top;
            btnContact.FlatAppearance.BorderSize = 0;
            btnContact.FlatStyle = FlatStyle.Flat;
            btnContact.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnContact.ForeColor = Color.Black;
            btnContact.Location = new Point(0, 100);
            btnContact.Name = "btnContact";
            btnContact.Padding = new Padding(10, 0, 0, 0);
            btnContact.Size = new Size(200, 55);
            btnContact.TabIndex = 0;
            btnContact.Text = "Contact";
            btnContact.TextAlign = ContentAlignment.MiddleLeft;
            btnContact.UseVisualStyleBackColor = false;
            btnContact.Click += btnContact_Click;
            // 
            // panel_logo
            // 
            panel_logo.BackColor = Color.YellowGreen;
            panel_logo.Controls.Add(label3);
            panel_logo.Controls.Add(label2);
            panel_logo.Controls.Add(label1);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(200, 100);
            panel_logo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(71, 67);
            label3.Name = "label3";
            label3.Size = new Size(126, 16);
            label3.TabIndex = 2;
            label3.Text = "Aliens Technology";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 51);
            label2.Name = "label2";
            label2.Size = new Size(102, 16);
            label2.TabIndex = 1;
            label2.Text = "Welcome From";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(58, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 42);
            label1.TabIndex = 0;
            label1.Text = "AT";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(panel3);
            pnlMain.Controls.Add(panel2);
            pnlMain.Controls.Add(panel1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(200, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(786, 550);
            pnlMain.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.YellowGreen;
            panel3.Dock = DockStyle.Bottom;
            panel3.Font = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(0, 490);
            panel3.Name = "panel3";
            panel3.Size = new Size(786, 60);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.YellowGreen;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 58);
            panel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(112, 33);
            label8.Name = "label8";
            label8.Size = new Size(46, 17);
            label8.TabIndex = 3;
            label8.Text = "Admin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(112, 16);
            label7.Name = "label7";
            label7.Size = new Size(33, 17);
            label7.TabIndex = 2;
            label7.Text = "User";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 31);
            label6.Name = "label6";
            label6.Size = new Size(37, 17);
            label6.TabIndex = 1;
            label6.Text = "Role:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 15);
            label5.Name = "label5";
            label5.Size = new Size(70, 17);
            label5.TabIndex = 0;
            label5.Text = "Welcome:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 51);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 9);
            label4.Name = "label4";
            label4.Size = new Size(678, 38);
            label4.TabIndex = 0;
            label4.Text = "Aliens Techonology, Improve Your Buisness";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 550);
            Controls.Add(pnlMain);
            Controls.Add(panel_slide);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMain";
            Text = "MAIN";
            Load += frmMain_Load;
            panel_slide.ResumeLayout(false);
            pnlSubMenuAgency.ResumeLayout(false);
            pnlContactSubMenu.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            pnlMain.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel_slide;
        private Button btnContact;
        private Panel panel_logo;
        private Panel pnlContactSubMenu;
        private Button btnStatus;
        private Button btnManageContact;
        private Button btnRegistrationContact;
        private Panel pnlSubMenuAgency;
        private Button btnManageAgency;
        private Button btnRegisterAgency;
        private Button btnAgency;
        private Button btnExit;
        private Button btnOptions;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel pnlMain;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}
