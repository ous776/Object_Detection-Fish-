namespace GamRent
{
    partial class Rentals
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
            Button1 = new Button();
            Label6 = new Label();
            lblinc = new Label();
            txtsearch = new TextBox();
            btnnew = new Button();
            Label9 = new Label();
            btnlast = new Button();
            btndelete = new Button();
            btnnext = new Button();
            rentaltype = new ComboBox();
            Label4 = new Label();
            Label3 = new Label();
            txtlocation = new TextBox();
            btnprev = new Button();
            btnupdate = new Button();
            btnfirst = new Button();
            btnsave = new Button();
            txtdescription = new RichTextBox();
            Label2 = new Label();
            lblmax = new Label();
            dtglist = new DataGridView();
            Panel2 = new Panel();
            btnadd = new Button();
            Label1 = new Label();
            Label7 = new Label();
            pnl_stockmaster = new Panel();
            lastPayment_dateTimePicker = new DateTimePicker();
            txt_pendingAmount = new TextBox();
            label13 = new Label();
            txt_amuntPaid = new TextBox();
            label12 = new Label();
            renewal_dateTimePicker = new DateTimePicker();
            label11 = new Label();
            endDate_dateTimePicker = new DateTimePicker();
            label10 = new Label();
            startDatedateTimePicker = new DateTimePicker();
            label8 = new Label();
            asset_comboBox = new ComboBox();
            txt_deposit = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtglist).BeginInit();
            Panel2.SuspendLayout();
            pnl_stockmaster.SuspendLayout();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.BackColor = Color.Transparent;
            Button1.ForeColor = Color.Black;
            Button1.Location = new Point(611, 338);
            Button1.Margin = new Padding(5);
            Button1.Name = "Button1";
            Button1.Size = new Size(142, 47);
            Button1.TabIndex = 44;
            Button1.Text = "Close";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += Button1_Click;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(538, 443);
            Label6.Margin = new Padding(5, 0, 5, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(60, 20);
            Label6.TabIndex = 31;
            Label6.Text = "Search :";
            // 
            // lblinc
            // 
            lblinc.AutoSize = true;
            lblinc.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblinc.Location = new Point(5, 443);
            lblinc.Margin = new Padding(5, 0, 5, 0);
            lblinc.Name = "lblinc";
            lblinc.Size = new Size(13, 16);
            lblinc.TabIndex = 42;
            lblinc.Text = "1";
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(622, 437);
            txtsearch.Margin = new Padding(5);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(349, 26);
            txtsearch.TabIndex = 29;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // btnnew
            // 
            btnnew.BackColor = Color.Transparent;
            btnnew.ForeColor = Color.Black;
            btnnew.Location = new Point(459, 338);
            btnnew.Margin = new Padding(5);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(142, 47);
            btnnew.TabIndex = 33;
            btnnew.Text = "Clear";
            btnnew.UseVisualStyleBackColor = false;
            btnnew.Click += btnnew_Click;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Label9.Location = new Point(28, 443);
            Label9.Margin = new Padding(5, 0, 5, 0);
            Label9.Name = "Label9";
            Label9.Size = new Size(18, 16);
            Label9.TabIndex = 37;
            Label9.Text = "of";
            // 
            // btnlast
            // 
            btnlast.BackColor = Color.Transparent;
            btnlast.ForeColor = Color.Black;
            btnlast.Location = new Point(274, 412);
            btnlast.Margin = new Padding(5);
            btnlast.Name = "btnlast";
            btnlast.Size = new Size(53, 47);
            btnlast.TabIndex = 38;
            btnlast.Text = ">>";
            btnlast.UseVisualStyleBackColor = false;
            btnlast.Click += btnlast_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Transparent;
            btndelete.ForeColor = Color.Black;
            btndelete.Location = new Point(304, 338);
            btndelete.Margin = new Padding(5);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(142, 47);
            btndelete.TabIndex = 34;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btnnext
            // 
            btnnext.BackColor = Color.Transparent;
            btnnext.ForeColor = Color.Black;
            btnnext.Location = new Point(211, 412);
            btnnext.Margin = new Padding(5);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(53, 47);
            btnnext.TabIndex = 39;
            btnnext.Text = ">";
            btnnext.UseVisualStyleBackColor = false;
            btnnext.Click += btnnext_Click;
            // 
            // rentaltype
            // 
            rentaltype.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rentaltype.FormattingEnabled = true;
            rentaltype.Location = new Point(622, 29);
            rentaltype.Margin = new Padding(5);
            rentaltype.Name = "rentaltype";
            rentaltype.Size = new Size(264, 24);
            rentaltype.TabIndex = 2;
            rentaltype.SelectedIndexChanged += cbotype_SelectedIndexChanged;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Label4.Location = new Point(533, 73);
            Label4.Margin = new Padding(5, 0, 5, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(65, 16);
            Label4.TabIndex = 1;
            Label4.Text = "Location ::";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Label3.Location = new Point(533, 32);
            Label3.Margin = new Padding(5, 0, 5, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(45, 16);
            Label3.TabIndex = 1;
            Label3.Text = "Rental:";
            // 
            // txtlocation
            // 
            txtlocation.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtlocation.Location = new Point(622, 69);
            txtlocation.Margin = new Padding(5);
            txtlocation.Name = "txtlocation";
            txtlocation.Size = new Size(264, 22);
            txtlocation.TabIndex = 0;
            // 
            // btnprev
            // 
            btnprev.BackColor = Color.Transparent;
            btnprev.ForeColor = Color.Black;
            btnprev.Location = new Point(148, 412);
            btnprev.Margin = new Padding(5);
            btnprev.Name = "btnprev";
            btnprev.Size = new Size(53, 47);
            btnprev.TabIndex = 40;
            btnprev.Text = "<";
            btnprev.UseVisualStyleBackColor = false;
            btnprev.Click += btnprev_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.Transparent;
            btnupdate.ForeColor = Color.Black;
            btnupdate.Location = new Point(157, 338);
            btnupdate.Margin = new Padding(5);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(137, 47);
            btnupdate.TabIndex = 35;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnfirst
            // 
            btnfirst.BackColor = Color.Transparent;
            btnfirst.ForeColor = Color.Black;
            btnfirst.Location = new Point(85, 412);
            btnfirst.Margin = new Padding(5);
            btnfirst.Name = "btnfirst";
            btnfirst.Size = new Size(53, 47);
            btnfirst.TabIndex = 41;
            btnfirst.Text = "<<";
            btnfirst.UseVisualStyleBackColor = false;
            btnfirst.Click += btnfirst_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.Transparent;
            btnsave.ForeColor = Color.Black;
            btnsave.Location = new Point(6, 338);
            btnsave.Margin = new Padding(5);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(142, 47);
            btnsave.TabIndex = 36;
            btnsave.Text = "Add Rental";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // txtdescription
            // 
            txtdescription.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtdescription.Location = new Point(130, 239);
            txtdescription.Margin = new Padding(5);
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(298, 71);
            txtdescription.TabIndex = 3;
            txtdescription.Text = "";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Label2.Location = new Point(0, 239);
            Label2.Margin = new Padding(5, 0, 5, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(79, 16);
            Label2.TabIndex = 1;
            Label2.Text = "Description ::";
            // 
            // lblmax
            // 
            lblmax.AutoSize = true;
            lblmax.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblmax.Location = new Point(56, 443);
            lblmax.Margin = new Padding(5, 0, 5, 0);
            lblmax.Name = "lblmax";
            lblmax.Size = new Size(13, 16);
            lblmax.TabIndex = 43;
            lblmax.Text = "1";
            // 
            // dtglist
            // 
            dtglist.AllowUserToAddRows = false;
            dtglist.AllowUserToDeleteRows = false;
            dtglist.AllowUserToOrderColumns = true;
            dtglist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtglist.Dock = DockStyle.Bottom;
            dtglist.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtglist.Location = new Point(0, 46);
            dtglist.Margin = new Padding(5, 1, 5, 5);
            dtglist.Name = "dtglist";
            dtglist.RowTemplate.Height = 15;
            dtglist.RowTemplate.Resizable = DataGridViewTriState.True;
            dtglist.Size = new Size(977, 267);
            dtglist.TabIndex = 0;
            dtglist.CellContentClick += dtglist_CellContentClick;
            dtglist.Click += dtglist_Click;
            // 
            // Panel2
            // 
            Panel2.BackColor = SystemColors.Control;
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(dtglist);
            Panel2.Location = new Point(8, 573);
            Panel2.Margin = new Padding(5);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(979, 315);
            Panel2.TabIndex = 32;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(266, 476);
            btnadd.Margin = new Padding(5);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(190, 39);
            btnadd.TabIndex = 2;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Label1.Location = new Point(8, 36);
            Label1.Margin = new Padding(5, 0, 5, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(79, 16);
            Label1.TabIndex = 1;
            Label1.Text = "Asset Name ::";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Label7.Location = new Point(534, 199);
            Label7.Margin = new Padding(5, 0, 5, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(83, 16);
            Label7.TabIndex = 5;
            Label7.Text = "Payment Date:";
            // 
            // pnl_stockmaster
            // 
            pnl_stockmaster.BackColor = Color.White;
            pnl_stockmaster.Controls.Add(lastPayment_dateTimePicker);
            pnl_stockmaster.Controls.Add(txt_pendingAmount);
            pnl_stockmaster.Controls.Add(label13);
            pnl_stockmaster.Controls.Add(txt_amuntPaid);
            pnl_stockmaster.Controls.Add(label12);
            pnl_stockmaster.Controls.Add(renewal_dateTimePicker);
            pnl_stockmaster.Controls.Add(label11);
            pnl_stockmaster.Controls.Add(endDate_dateTimePicker);
            pnl_stockmaster.Controls.Add(label10);
            pnl_stockmaster.Controls.Add(startDatedateTimePicker);
            pnl_stockmaster.Controls.Add(label8);
            pnl_stockmaster.Controls.Add(asset_comboBox);
            pnl_stockmaster.Controls.Add(txt_deposit);
            pnl_stockmaster.Controls.Add(label5);
            pnl_stockmaster.Controls.Add(Label7);
            pnl_stockmaster.Controls.Add(txtdescription);
            pnl_stockmaster.Controls.Add(rentaltype);
            pnl_stockmaster.Controls.Add(Label4);
            pnl_stockmaster.Controls.Add(Label3);
            pnl_stockmaster.Controls.Add(txtlocation);
            pnl_stockmaster.Controls.Add(Label2);
            pnl_stockmaster.Controls.Add(Label1);
            pnl_stockmaster.Dock = DockStyle.Top;
            pnl_stockmaster.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pnl_stockmaster.Location = new Point(0, 0);
            pnl_stockmaster.Margin = new Padding(5);
            pnl_stockmaster.Name = "pnl_stockmaster";
            pnl_stockmaster.Size = new Size(1109, 328);
            pnl_stockmaster.TabIndex = 30;
            // 
            // lastPayment_dateTimePicker
            // 
            lastPayment_dateTimePicker.Location = new Point(624, 195);
            lastPayment_dateTimePicker.Margin = new Padding(2, 3, 2, 3);
            lastPayment_dateTimePicker.Name = "lastPayment_dateTimePicker";
            lastPayment_dateTimePicker.Size = new Size(262, 26);
            lastPayment_dateTimePicker.TabIndex = 19;
            // 
            // txt_pendingAmount
            // 
            txt_pendingAmount.Location = new Point(622, 137);
            txt_pendingAmount.Margin = new Padding(2, 3, 2, 3);
            txt_pendingAmount.Name = "txt_pendingAmount";
            txt_pendingAmount.Size = new Size(264, 26);
            txt_pendingAmount.TabIndex = 18;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(536, 141);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(118, 20);
            label13.TabIndex = 17;
            label13.Text = "Pending Amount:";
            // 
            // txt_amuntPaid
            // 
            txt_amuntPaid.Location = new Point(622, 109);
            txt_amuntPaid.Margin = new Padding(2, 3, 2, 3);
            txt_amuntPaid.Name = "txt_amuntPaid";
            txt_amuntPaid.Size = new Size(264, 26);
            txt_amuntPaid.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(536, 109);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(94, 20);
            label12.TabIndex = 15;
            label12.Text = "Amount Paid:";
            // 
            // renewal_dateTimePicker
            // 
            renewal_dateTimePicker.Location = new Point(157, 189);
            renewal_dateTimePicker.Margin = new Padding(2, 3, 2, 3);
            renewal_dateTimePicker.Name = "renewal_dateTimePicker";
            renewal_dateTimePicker.Size = new Size(271, 26);
            renewal_dateTimePicker.TabIndex = 14;
            renewal_dateTimePicker.ValueChanged += renewal_dateTimePicker_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(2, 194);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(151, 20);
            label11.TabIndex = 13;
            label11.Text = "Contract Renewal Date:";
            // 
            // endDate_dateTimePicker
            // 
            endDate_dateTimePicker.Location = new Point(139, 148);
            endDate_dateTimePicker.Margin = new Padding(2, 3, 2, 3);
            endDate_dateTimePicker.Name = "endDate_dateTimePicker";
            endDate_dateTimePicker.Size = new Size(289, 26);
            endDate_dateTimePicker.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 153);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(121, 20);
            label10.TabIndex = 11;
            label10.Text = "Contract End Date";
            // 
            // startDatedateTimePicker
            // 
            startDatedateTimePicker.Location = new Point(139, 99);
            startDatedateTimePicker.Margin = new Padding(2, 3, 2, 3);
            startDatedateTimePicker.Name = "startDatedateTimePicker";
            startDatedateTimePicker.Size = new Size(289, 26);
            startDatedateTimePicker.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 105);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(129, 20);
            label8.TabIndex = 9;
            label8.Text = "Contract Start Dtae:";
            // 
            // asset_comboBox
            // 
            asset_comboBox.FormattingEnabled = true;
            asset_comboBox.Location = new Point(139, 32);
            asset_comboBox.Margin = new Padding(2, 3, 2, 3);
            asset_comboBox.Name = "asset_comboBox";
            asset_comboBox.Size = new Size(289, 28);
            asset_comboBox.TabIndex = 8;
            // 
            // txt_deposit
            // 
            txt_deposit.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_deposit.Location = new Point(139, 69);
            txt_deposit.Margin = new Padding(5);
            txt_deposit.Name = "txt_deposit";
            txt_deposit.Size = new Size(289, 22);
            txt_deposit.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(9, 71);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 16);
            label5.TabIndex = 7;
            label5.Text = "Advance Deposit";
            // 
            // Rentals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 749);
            Controls.Add(Button1);
            Controls.Add(btnadd);
            Controls.Add(Label6);
            Controls.Add(lblinc);
            Controls.Add(txtsearch);
            Controls.Add(btnnew);
            Controls.Add(Label9);
            Controls.Add(btnlast);
            Controls.Add(btndelete);
            Controls.Add(btnnext);
            Controls.Add(btnprev);
            Controls.Add(btnupdate);
            Controls.Add(btnfirst);
            Controls.Add(btnsave);
            Controls.Add(lblmax);
            Controls.Add(Panel2);
            Controls.Add(pnl_stockmaster);
            Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Rentals";
            Text = "Rentals";
            Load += frmItems_Load;
            ((System.ComponentModel.ISupportInitialize)dtglist).EndInit();
            Panel2.ResumeLayout(false);
            pnl_stockmaster.ResumeLayout(false);
            pnl_stockmaster.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        internal Button Button1;
        internal Label Label6;
        internal Label lblinc;
        internal TextBox txtsearch;
        internal Button btnnew;
        internal Label Label9;
        internal Button btnlast;
        internal Button btndelete;
        internal Button btnnext;
        internal ComboBox rentaltype;
        internal Label Label4;
        internal Label Label3;
        internal TextBox txtlocation;
        internal Button btnprev;
        internal Button btnupdate;
        internal Button btnfirst;
        internal Button btnsave;
        internal RichTextBox txtdescription;
        internal Label Label2;
        internal Label lblmax;
        internal DataGridView dtglist;
        internal Panel Panel2;
        internal Button btnadd;
        internal Label Label1;
        internal Label Label7;
        internal Panel pnl_stockmaster;
        private ComboBox asset_comboBox;
        internal TextBox txt_deposit;
        internal Label label5;
        private DateTimePicker startDatedateTimePicker;
        private Label label8;
        private Label label11;
        private DateTimePicker endDate_dateTimePicker;
        private Label label10;
        private DateTimePicker renewal_dateTimePicker;
        private TextBox txt_amuntPaid;
        private Label label12;
        private TextBox txt_pendingAmount;
        private Label label13;
        private DateTimePicker lastPayment_dateTimePicker;
    }
}