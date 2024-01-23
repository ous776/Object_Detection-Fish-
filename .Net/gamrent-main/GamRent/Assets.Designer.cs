namespace GamRent
{
    partial class Assets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assets));
            txtqty = new TextBox();
            Label6 = new Label();
            lblinc = new Label();
            txtsearch = new TextBox();
            btnnew = new Button();
            Label9 = new Label();
            btnlast = new Button();
            btndelete = new Button();
            btnnext = new Button();
            cbotype = new ComboBox();
            txtname = new TextBox();
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
            Label1 = new Label();
            Label7 = new Label();
            pnl_stockmaster = new Panel();
            txt_AssetNo = new TextBox();
            label5 = new Label();
            dtglist = new DataGridView();
            Panel2 = new Panel();
            btn_add = new Button();
            pnl_stockmaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtglist).BeginInit();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtqty
            // 
            txtqty.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtqty.Location = new Point(623, 158);
            txtqty.Margin = new Padding(5);
            txtqty.Name = "txtqty";
            txtqty.Size = new Size(253, 26);
            txtqty.TabIndex = 4;
            // 
            // Label6
            // 
            Label6.Anchor = AnchorStyles.None;
            Label6.AutoSize = true;
            Label6.Location = new Point(598, 378);
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
            lblinc.Location = new Point(25, 367);
            lblinc.Margin = new Padding(5, 0, 5, 0);
            lblinc.Name = "lblinc";
            lblinc.Size = new Size(13, 16);
            lblinc.TabIndex = 42;
            lblinc.Text = "1";
            // 
            // txtsearch
            // 
            txtsearch.Anchor = AnchorStyles.None;
            txtsearch.Location = new Point(679, 372);
            txtsearch.Margin = new Padding(5);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(212, 26);
            txtsearch.TabIndex = 29;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // btnnew
            // 
            btnnew.BackColor = Color.FromArgb(192, 192, 0);
            btnnew.FlatAppearance.MouseDownBackColor = Color.Olive;
            btnnew.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 0);
            btnnew.ForeColor = Color.White;
            btnnew.Location = new Point(749, 270);
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
            Label9.Location = new Point(48, 367);
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
            btnlast.Location = new Point(295, 351);
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
            btndelete.BackColor = Color.FromArgb(192, 0, 0);
            btndelete.FlatAppearance.MouseDownBackColor = Color.Red;
            btndelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btndelete.ForeColor = Color.White;
            btndelete.Location = new Point(579, 270);
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
            btnnext.Location = new Point(232, 351);
            btnnext.Margin = new Padding(5);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(53, 47);
            btnnext.TabIndex = 39;
            btnnext.Text = ">";
            btnnext.UseVisualStyleBackColor = false;
            btnnext.Click += btnnext_Click;
            // 
            // cbotype
            // 
            cbotype.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbotype.FormattingEnabled = true;
            cbotype.Location = new Point(623, 26);
            cbotype.Margin = new Padding(5);
            cbotype.Name = "cbotype";
            cbotype.Size = new Size(253, 28);
            cbotype.TabIndex = 2;
            cbotype.SelectedIndexChanged += cbotype_SelectedIndexChanged;
            // 
            // txtname
            // 
            txtname.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtname.Location = new Point(144, 89);
            txtname.Margin = new Padding(5);
            txtname.Name = "txtname";
            txtname.Size = new Size(297, 26);
            txtname.TabIndex = 0;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label4.Location = new Point(517, 98);
            Label4.Margin = new Padding(5, 0, 5, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(75, 20);
            Label4.TabIndex = 1;
            Label4.Text = "Location ::";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label3.Location = new Point(541, 34);
            Label3.Margin = new Padding(5, 0, 5, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(51, 20);
            Label3.TabIndex = 1;
            Label3.Text = "Type ::";
            // 
            // txtlocation
            // 
            txtlocation.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtlocation.Location = new Point(623, 92);
            txtlocation.Margin = new Padding(5);
            txtlocation.Name = "txtlocation";
            txtlocation.Size = new Size(253, 26);
            txtlocation.TabIndex = 0;
            txtlocation.TextChanged += txtlocation_TextChanged;
            // 
            // btnprev
            // 
            btnprev.BackColor = Color.Transparent;
            btnprev.ForeColor = Color.Black;
            btnprev.Location = new Point(169, 351);
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
            btnupdate.BackColor = Color.FromArgb(0, 192, 192);
            btnupdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 192);
            btnupdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            btnupdate.ForeColor = Color.White;
            btnupdate.Location = new Point(418, 270);
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
            btnfirst.Location = new Point(107, 351);
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
            btnsave.BackColor = Color.DarkGreen;
            btnsave.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnsave.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(254, 270);
            btnsave.Margin = new Padding(5);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(142, 47);
            btnsave.TabIndex = 36;
            btnsave.Text = "Add Asset";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // txtdescription
            // 
            txtdescription.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtdescription.Location = new Point(144, 155);
            txtdescription.Margin = new Padding(5);
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(298, 93);
            txtdescription.TabIndex = 3;
            txtdescription.Text = "";
            txtdescription.TextChanged += txtdescription_TextChanged;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label2.Location = new Point(23, 155);
            Label2.Margin = new Padding(5, 0, 5, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(92, 20);
            Label2.TabIndex = 1;
            Label2.Text = "Description ::";
            // 
            // lblmax
            // 
            lblmax.AutoSize = true;
            lblmax.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblmax.Location = new Point(76, 367);
            lblmax.Margin = new Padding(5, 0, 5, 0);
            lblmax.Name = "lblmax";
            lblmax.Size = new Size(13, 16);
            lblmax.TabIndex = 43;
            lblmax.Text = "1";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label1.Location = new Point(21, 95);
            Label1.Margin = new Padding(5, 0, 5, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(94, 20);
            Label1.TabIndex = 1;
            Label1.Text = "Asset Name ::";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label7.Location = new Point(476, 164);
            Label7.Margin = new Padding(5, 0, 5, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(116, 20);
            Label7.TabIndex = 5;
            Label7.Text = "Rental Quantity ::";
            // 
            // pnl_stockmaster
            // 
            pnl_stockmaster.BackColor = Color.Gray;
            pnl_stockmaster.Controls.Add(txt_AssetNo);
            pnl_stockmaster.Controls.Add(label5);
            pnl_stockmaster.Controls.Add(Label7);
            pnl_stockmaster.Controls.Add(txtqty);
            pnl_stockmaster.Controls.Add(txtdescription);
            pnl_stockmaster.Controls.Add(cbotype);
            pnl_stockmaster.Controls.Add(txtname);
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
            pnl_stockmaster.Size = new Size(1000, 260);
            pnl_stockmaster.TabIndex = 30;
            // 
            // txt_AssetNo
            // 
            txt_AssetNo.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_AssetNo.Location = new Point(144, 26);
            txt_AssetNo.Margin = new Padding(5);
            txt_AssetNo.Name = "txt_AssetNo";
            txt_AssetNo.ReadOnly = true;
            txt_AssetNo.Size = new Size(297, 26);
            txt_AssetNo.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(39, 34);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 7;
            label5.Text = "Asset No ::";
            // 
            // dtglist
            // 
            dtglist.AllowUserToAddRows = false;
            dtglist.AllowUserToDeleteRows = false;
            dtglist.AllowUserToOrderColumns = true;
            dtglist.BackgroundColor = Color.Gray;
            dtglist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtglist.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtglist.Location = new Point(-1, -1);
            dtglist.Margin = new Padding(5, 1, 5, 5);
            dtglist.Name = "dtglist";
            dtglist.RowTemplate.Height = 15;
            dtglist.RowTemplate.Resizable = DataGridViewTriState.True;
            dtglist.Size = new Size(1082, 334);
            dtglist.TabIndex = 0;
            dtglist.CellContentClick += dtglist_CellContentClick;
            dtglist.Click += dtglist_Click;
            // 
            // Panel2
            // 
            Panel2.BackColor = SystemColors.ActiveBorder;
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(dtglist);
            Panel2.Dock = DockStyle.Bottom;
            Panel2.Location = new Point(0, 420);
            Panel2.Margin = new Padding(5);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1000, 329);
            Panel2.TabIndex = 32;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(504, 377);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(21, 23);
            btn_add.TabIndex = 44;
            btn_add.Text = "button1";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Visible = false;
            btn_add.Click += btn_add_Click;
            // 
            // Assets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1000, 749);
            Controls.Add(btn_add);
            Controls.Add(btnnew);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btnsave);
            Controls.Add(Label6);
            Controls.Add(lblinc);
            Controls.Add(txtsearch);
            Controls.Add(Label9);
            Controls.Add(btnlast);
            Controls.Add(btnnext);
            Controls.Add(btnprev);
            Controls.Add(btnfirst);
            Controls.Add(lblmax);
            Controls.Add(Panel2);
            Controls.Add(pnl_stockmaster);
            Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MinimumSize = new Size(603, 588);
            Name = "Assets";
            Text = "Asset Master";
            Load += frmItems_Load;
            pnl_stockmaster.ResumeLayout(false);
            pnl_stockmaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtglist).EndInit();
            Panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        internal TextBox txtqty;
        internal Label Label6;
        internal Label lblinc;
        internal TextBox txtsearch;
        internal Button btnnew;
        internal Label Label9;
        internal Button btnlast;
        internal Button btndelete;
        internal Button btnnext;
        internal ComboBox cbotype;
        internal TextBox txtname;
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
        internal Label Label1;
        internal Label Label7;
        internal Panel pnl_stockmaster;
        internal TextBox txt_AssetNo;
        internal Label label5;
        private Panel panel1;
        private Panel panel3;
        internal DataGridView dtglist;
        internal Panel Panel2;
        private Button btn_add;
    }
}