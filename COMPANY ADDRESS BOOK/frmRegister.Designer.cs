namespace COMPANY_ADDRESS_BOOK
{
    partial class frmRegister
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
            pnlRegisterName = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cmbAgency = new ComboBox();
            txtEmail = new TextBox();
            label5 = new Label();
            txtPhoneNumber = new TextBox();
            label6 = new Label();
            txxIntern = new TextBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            pnlRegisterName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlRegisterName
            // 
            pnlRegisterName.BackColor = Color.YellowGreen;
            pnlRegisterName.Controls.Add(label1);
            pnlRegisterName.Dock = DockStyle.Top;
            pnlRegisterName.Location = new Point(0, 0);
            pnlRegisterName.Name = "pnlRegisterName";
            pnlRegisterName.Size = new Size(800, 59);
            pnlRegisterName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(270, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 44);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 213);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(22, 323);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(115, 324);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(337, 324);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(242, 327);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 4;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(480, 327);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 6;
            label4.Text = "Agency:";
            // 
            // cmbAgency
            // 
            cmbAgency.FormattingEnabled = true;
            cmbAgency.Location = new Point(557, 328);
            cmbAgency.Name = "cmbAgency";
            cmbAgency.Size = new Size(121, 23);
            cmbAgency.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(78, 376);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(22, 377);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 8;
            label5.Text = "Email:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(337, 377);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(209, 377);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 10;
            label6.Text = "Phone Number:";
            // 
            // txxIntern
            // 
            txxIntern.Location = new Point(542, 377);
            txxIntern.Name = "txxIntern";
            txxIntern.Size = new Size(105, 23);
            txxIntern.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(480, 377);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 12;
            label7.Text = "Intern:";
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(668, 418);
            button1.Name = "button1";
            button1.Size = new Size(120, 35);
            button1.TabIndex = 14;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(527, 418);
            button2.Name = "button2";
            button2.Size = new Size(120, 35);
            button2.TabIndex = 15;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 465);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txxIntern);
            Controls.Add(label7);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(cmbAgency);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(pnlRegisterName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegister";
            Text = "Register";
            Load += this.frmRegister_Load;
            pnlRegisterName.ResumeLayout(false);
            pnlRegisterName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlRegisterName;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label3;
        private Label label4;
        private ComboBox cmbAgency;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtPhoneNumber;
        private Label label6;
        private TextBox txxIntern;
        private Label label7;
        private Button button1;
        private Button button2;
    }
}