namespace GamRent
{
    partial class Tenants
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnviewStockout = new Button();
            Panel1 = new Panel();
            rental_comboBox = new ComboBox();
            asset_comboBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            Label1 = new Label();
            Label5 = new Label();
            Label15 = new Label();
            txtCus_lname = new TextBox();
            txtCus_fname = new TextBox();
            Label8 = new Label();
            btnCus_clear = new Button();
            btnCus_Remove = new Button();
            btnCus_save = new Button();
            Panel3 = new Panel();
            dtCus_addedlist = new DataGridView();
            Panel2 = new Panel();
            Label7 = new Label();
            Label6 = new Label();
            dtgCus_itemlist = new DataGridView();
            txtsearch = new TextBox();
            Panel1.SuspendLayout();
            Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtCus_addedlist).BeginInit();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCus_itemlist).BeginInit();
            SuspendLayout();
            // 
            // btnviewStockout
            // 
            btnviewStockout.Anchor = AnchorStyles.None;
            btnviewStockout.BackColor = Color.FromArgb(0, 192, 192);
            btnviewStockout.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnviewStockout.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            btnviewStockout.ForeColor = Color.White;
            btnviewStockout.Location = new Point(394, 417);
            btnviewStockout.Margin = new Padding(5);
            btnviewStockout.Name = "btnviewStockout";
            btnviewStockout.Size = new Size(118, 40);
            btnviewStockout.TabIndex = 28;
            btnviewStockout.Text = "View List";
            btnviewStockout.UseVisualStyleBackColor = false;
            btnviewStockout.Click += btnviewStockout_Click;
            // 
            // Panel1
            // 
            Panel1.BackColor = SystemColors.ActiveBorder;
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(rental_comboBox);
            Panel1.Controls.Add(asset_comboBox);
            Panel1.Controls.Add(label4);
            Panel1.Controls.Add(label3);
            Panel1.Controls.Add(Label1);
            Panel1.Controls.Add(Label5);
            Panel1.Controls.Add(Label15);
            Panel1.Controls.Add(txtCus_lname);
            Panel1.Controls.Add(txtCus_fname);
            Panel1.Dock = DockStyle.Top;
            Panel1.Location = new Point(0, 0);
            Panel1.Margin = new Padding(5);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(963, 153);
            Panel1.TabIndex = 27;
            // 
            // rental_comboBox
            // 
            rental_comboBox.Anchor = AnchorStyles.None;
            rental_comboBox.FormattingEnabled = true;
            rental_comboBox.Location = new Point(554, 31);
            rental_comboBox.Margin = new Padding(2, 3, 2, 3);
            rental_comboBox.Name = "rental_comboBox";
            rental_comboBox.Size = new Size(255, 28);
            rental_comboBox.TabIndex = 12;
            rental_comboBox.SelectedIndexChanged += rental_comboBox_SelectedIndexChanged;
            // 
            // asset_comboBox
            // 
            asset_comboBox.Anchor = AnchorStyles.None;
            asset_comboBox.FormattingEnabled = true;
            asset_comboBox.Location = new Point(142, 37);
            asset_comboBox.Margin = new Padding(2, 3, 2, 3);
            asset_comboBox.Name = "asset_comboBox";
            asset_comboBox.Size = new Size(242, 28);
            asset_comboBox.TabIndex = 11;
            asset_comboBox.SelectedIndexChanged += fill_rentalCombox;
            asset_comboBox.SelectionChangeCommitted += fill_rentalCombox;
            asset_comboBox.TextChanged += fill_rentalCombox;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(415, 39);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 10;
            label4.Text = "Rental Property ::";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 45);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 9;
            label3.Text = "Rental Asset ::";
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.None;
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.Location = new Point(4, 0);
            Label1.Margin = new Padding(5, 0, 5, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(78, 24);
            Label1.TabIndex = 3;
            Label1.Text = "Tenants";
            // 
            // Label5
            // 
            Label5.Anchor = AnchorStyles.None;
            Label5.AutoSize = true;
            Label5.Location = new Point(446, 89);
            Label5.Margin = new Padding(5, 0, 5, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(86, 20);
            Label5.TabIndex = 1;
            Label5.Text = "Last Name ::";
            // 
            // Label15
            // 
            Label15.Anchor = AnchorStyles.None;
            Label15.AutoSize = true;
            Label15.Location = new Point(26, 89);
            Label15.Margin = new Padding(5, 0, 5, 0);
            Label15.Name = "Label15";
            Label15.Size = new Size(88, 20);
            Label15.TabIndex = 1;
            Label15.Text = "First Name ::";
            // 
            // txtCus_lname
            // 
            txtCus_lname.Anchor = AnchorStyles.None;
            txtCus_lname.Location = new Point(553, 83);
            txtCus_lname.Margin = new Padding(5);
            txtCus_lname.Name = "txtCus_lname";
            txtCus_lname.Size = new Size(256, 26);
            txtCus_lname.TabIndex = 0;
            // 
            // txtCus_fname
            // 
            txtCus_fname.Anchor = AnchorStyles.None;
            txtCus_fname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCus_fname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCus_fname.Location = new Point(142, 83);
            txtCus_fname.Margin = new Padding(5);
            txtCus_fname.Name = "txtCus_fname";
            txtCus_fname.Size = new Size(242, 26);
            txtCus_fname.TabIndex = 0;
            // 
            // Label8
            // 
            Label8.Anchor = AnchorStyles.None;
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label8.Location = new Point(496, 2);
            Label8.Margin = new Padding(5, 0, 5, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(168, 24);
            Label8.TabIndex = 26;
            Label8.Text = "List of Added Items";
            // 
            // btnCus_clear
            // 
            btnCus_clear.Anchor = AnchorStyles.None;
            btnCus_clear.BackColor = Color.FromArgb(192, 192, 0);
            btnCus_clear.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 0);
            btnCus_clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 0);
            btnCus_clear.ForeColor = Color.White;
            btnCus_clear.Location = new Point(266, 417);
            btnCus_clear.Margin = new Padding(5);
            btnCus_clear.Name = "btnCus_clear";
            btnCus_clear.Size = new Size(118, 40);
            btnCus_clear.TabIndex = 23;
            btnCus_clear.Text = "Clear";
            btnCus_clear.UseVisualStyleBackColor = false;
            btnCus_clear.Click += btnCus_clear_Click;
            // 
            // btnCus_Remove
            // 
            btnCus_Remove.Anchor = AnchorStyles.None;
            btnCus_Remove.BackColor = Color.FromArgb(192, 0, 0);
            btnCus_Remove.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btnCus_Remove.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnCus_Remove.ForeColor = Color.White;
            btnCus_Remove.Location = new Point(142, 417);
            btnCus_Remove.Margin = new Padding(5);
            btnCus_Remove.Name = "btnCus_Remove";
            btnCus_Remove.Size = new Size(118, 40);
            btnCus_Remove.TabIndex = 24;
            btnCus_Remove.Text = "Remove";
            btnCus_Remove.UseVisualStyleBackColor = false;
            btnCus_Remove.Click += btnCus_Remove_Click;
            // 
            // btnCus_save
            // 
            btnCus_save.Anchor = AnchorStyles.None;
            btnCus_save.BackColor = Color.DarkGreen;
            btnCus_save.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            btnCus_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            btnCus_save.ForeColor = Color.White;
            btnCus_save.Location = new Point(16, 417);
            btnCus_save.Margin = new Padding(5);
            btnCus_save.Name = "btnCus_save";
            btnCus_save.Size = new Size(118, 40);
            btnCus_save.TabIndex = 25;
            btnCus_save.Text = "Save";
            btnCus_save.UseVisualStyleBackColor = false;
            btnCus_save.Click += btnCus_save_Click;
            // 
            // Panel3
            // 
            Panel3.BackColor = SystemColors.ControlLightLight;
            Panel3.BorderStyle = BorderStyle.FixedSingle;
            Panel3.Controls.Add(dtCus_addedlist);
            Panel3.Controls.Add(Label8);
            Panel3.Location = new Point(-2, 480);
            Panel3.Margin = new Padding(5);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(966, 254);
            Panel3.TabIndex = 21;
            // 
            // dtCus_addedlist
            // 
            dtCus_addedlist.AllowUserToAddRows = false;
            dtCus_addedlist.AllowUserToDeleteRows = false;
            dtCus_addedlist.AllowUserToResizeColumns = false;
            dtCus_addedlist.AllowUserToResizeRows = false;
            dtCus_addedlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtCus_addedlist.Location = new Point(-1, 31);
            dtCus_addedlist.Margin = new Padding(5);
            dtCus_addedlist.Name = "dtCus_addedlist";
            dtCus_addedlist.Size = new Size(995, 182);
            dtCus_addedlist.TabIndex = 0;
            dtCus_addedlist.CellContentClick += dtCus_addedlist_CellContentClick;
            dtCus_addedlist.CellEndEdit += dtCus_addedlist_CellEndEdit;
            // 
            // Panel2
            // 
            Panel2.Anchor = AnchorStyles.None;
            Panel2.BackColor = SystemColors.ControlLightLight;
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(Label7);
            Panel2.Controls.Add(Label6);
            Panel2.Controls.Add(dtgCus_itemlist);
            Panel2.Controls.Add(txtsearch);
            Panel2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Panel2.Location = new Point(-2, 157);
            Panel2.Margin = new Padding(5);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(965, 257);
            Panel2.TabIndex = 20;
            // 
            // Label7
            // 
            Label7.Anchor = AnchorStyles.None;
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label7.Location = new Point(7, -220);
            Label7.Margin = new Padding(5, 0, 5, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(130, 24);
            Label7.TabIndex = 3;
            Label7.Text = "List of Tenants";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label6.Location = new Point(474, -211);
            Label6.Margin = new Padding(5, 0, 5, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(60, 20);
            Label6.TabIndex = 4;
            Label6.Text = "Search :";
            // 
            // dtgCus_itemlist
            // 
            dtgCus_itemlist.AllowUserToAddRows = false;
            dtgCus_itemlist.AllowUserToDeleteRows = false;
            dtgCus_itemlist.AllowUserToResizeColumns = false;
            dtgCus_itemlist.AllowUserToResizeRows = false;
            dtgCus_itemlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCus_itemlist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgCus_itemlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCus_itemlist.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgCus_itemlist.Location = new Point(-1, 45);
            dtgCus_itemlist.Margin = new Padding(5);
            dtgCus_itemlist.Name = "dtgCus_itemlist";
            dtgCus_itemlist.RowHeadersVisible = false;
            dtgCus_itemlist.Size = new Size(965, 201);
            dtgCus_itemlist.TabIndex = 0;
            dtgCus_itemlist.CellContentClick += dtgCus_itemlist_CellContentClick;
            dtgCus_itemlist.DoubleClick += dtgCus_itemlist_DoubleClick;
            // 
            // txtsearch
            // 
            txtsearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtsearch.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtsearch.Location = new Point(555, -214);
            txtsearch.Margin = new Padding(5);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(256, 26);
            txtsearch.TabIndex = 3;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // Tenants
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 695);
            Controls.Add(btnviewStockout);
            Controls.Add(Panel1);
            Controls.Add(btnCus_clear);
            Controls.Add(btnCus_Remove);
            Controls.Add(btnCus_save);
            Controls.Add(Panel3);
            Controls.Add(Panel2);
            Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Tenants";
            Text = "Tenants";
            Load += frmTenants_Load;
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtCus_addedlist).EndInit();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCus_itemlist).EndInit();
            ResumeLayout(false);
        }

        #endregion
        #endregion
        internal Button btnviewStockout;
        internal Panel Panel1;
        internal Label Label2;
        internal TextBox txt_cusid;
        internal Label Label1;
        internal Label Label5;
        internal Label Label15;
        internal TextBox txtCus_lname;
        internal TextBox txtCus_fname;
        internal Label Label8;
        internal Button btnCus_clear;
        internal Button btnCus_Remove;
        internal Button btnCus_save;
        internal Panel Panel3;
        internal DataGridView dtCus_addedlist;
        internal Panel Panel2;
        internal Label Label7;
        internal Label Label6;
        internal DataGridView dtgCus_itemlist;
        internal TextBox txtsearch;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private ComboBox rental_comboBox;
        private ComboBox asset_comboBox;
        private Label label4;
        private Label label3;
    }
}