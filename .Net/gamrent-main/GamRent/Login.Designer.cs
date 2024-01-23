namespace GamRent
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lbldate = new Label();
            lbltime = new Label();
            Label4 = new Label();
            Label3 = new Label();
            Button2 = new Button();
            Label2 = new Label();
            Label1 = new Label();
            txtpass = new TextBox();
            txtusername = new TextBox();
            Button1 = new Button();
            PictureBox1 = new PictureBox();
            Timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbldate
            // 
            lbldate.Anchor = AnchorStyles.None;
            lbldate.AutoSize = true;
            lbldate.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbldate.Location = new Point(618, 422);
            lbldate.Margin = new Padding(5, 0, 5, 0);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(56, 23);
            lbldate.TabIndex = 32;
            lbldate.Text = "Time :";
            lbldate.Click += lbldate_Click;
            // 
            // lbltime
            // 
            lbltime.Anchor = AnchorStyles.None;
            lbltime.AutoSize = true;
            lbltime.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbltime.Location = new Point(618, 367);
            lbltime.Margin = new Padding(5, 0, 5, 0);
            lbltime.Name = "lbltime";
            lbltime.Size = new Size(56, 23);
            lbltime.TabIndex = 31;
            lbltime.Text = "Time :";
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.None;
            Label4.AutoSize = true;
            Label4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label4.Location = new Point(554, 422);
            Label4.Margin = new Padding(5, 0, 5, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(53, 23);
            Label4.TabIndex = 29;
            Label4.Text = "Date :";
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.None;
            Label3.AutoSize = true;
            Label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label3.Location = new Point(551, 367);
            Label3.Margin = new Padding(5, 0, 5, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(56, 23);
            Label3.TabIndex = 30;
            Label3.Text = "Time :";
            // 
            // Button2
            // 
            Button2.Anchor = AnchorStyles.None;
            Button2.BackColor = Color.FromArgb(192, 192, 0);
            Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 128);
            Button2.FlatAppearance.MouseOverBackColor = Color.Olive;
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Button2.ForeColor = Color.White;
            Button2.Location = new Point(618, 274);
            Button2.Margin = new Padding(5);
            Button2.Name = "Button2";
            Button2.Size = new Size(129, 56);
            Button2.TabIndex = 27;
            Button2.Text = "Clear";
            Button2.UseVisualStyleBackColor = false;
            Button2.Click += Button2_Click;
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.None;
            Label2.AutoSize = true;
            Label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label2.Location = new Point(478, 176);
            Label2.Margin = new Padding(5, 0, 5, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(94, 23);
            Label2.TabIndex = 23;
            Label2.Text = "Password :";
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.None;
            Label1.AutoSize = true;
            Label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label1.Location = new Point(478, 92);
            Label1.Margin = new Padding(5, 0, 5, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(96, 23);
            Label1.TabIndex = 24;
            Label1.Text = "Username :";
            // 
            // txtpass
            // 
            txtpass.Anchor = AnchorStyles.None;
            txtpass.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtpass.Location = new Point(478, 213);
            txtpass.Margin = new Padding(5);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(269, 29);
            txtpass.TabIndex = 25;
            txtpass.UseSystemPasswordChar = true;
            txtpass.TextChanged += txtpass_TextChanged;
            // 
            // txtusername
            // 
            txtusername.Anchor = AnchorStyles.None;
            txtusername.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtusername.Location = new Point(478, 129);
            txtusername.Margin = new Padding(5);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(269, 29);
            txtusername.TabIndex = 22;
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.None;
            Button1.BackColor = Color.DarkGreen;
            Button1.FlatAppearance.BorderColor = Color.White;
            Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Button1.ForeColor = Color.White;
            Button1.Location = new Point(478, 274);
            Button1.Margin = new Padding(5);
            Button1.Name = "Button1";
            Button1.Size = new Size(129, 56);
            Button1.TabIndex = 26;
            Button1.Text = "Login";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += Button1_Click;
            // 
            // PictureBox1
            // 
            PictureBox1.Anchor = AnchorStyles.None;
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.InitialImage = (Image)resources.GetObject("PictureBox1.InitialImage");
            PictureBox1.Location = new Point(76, 129);
            PictureBox1.Margin = new Padding(5);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(190, 165);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 33;
            PictureBox1.TabStop = false;
            // 
            // Timer1
            // 
            Timer1.Tick += Timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(PictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 561);
            panel1.TabIndex = 34;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(369, 22);
            label5.Name = "label5";
            label5.Size = new Size(458, 29);
            label5.TabIndex = 35;
            label5.Text = "GARAWOL PROPERTY MANAGEMENT";
            // 
            // Login
            // 
            AcceptButton = Button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 561);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(lbldate);
            Controls.Add(lbltime);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Button2);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(txtpass);
            Controls.Add(txtusername);
            Controls.Add(Button1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Label lbldate;
        internal Label lbltime;
        internal Label Label4;
        internal Label Label3;
        internal Button Button2;
        internal Label Label2;
        internal Label Label1;
        internal TextBox txtpass;
        internal TextBox txtusername;
        internal Button Button1;
        internal PictureBox PictureBox1;
        internal System.Windows.Forms.Timer Timer1;
        private Panel panel1;
        private Label label5;
    }
}