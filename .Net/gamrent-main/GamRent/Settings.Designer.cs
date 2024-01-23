namespace GamRent
{
    partial class Settings
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dtgtypelist = new DataGridView();
            txtunit = new TextBox();
            btnusave = new Button();
            btncdel = new Button();
            btntypeupdate = new Button();
            btntypeLoad = new Button();
            txtCategory = new TextBox();
            Label1 = new Label();
            btnuupdate = new Button();
            btnuload = new Button();
            dtgulist = new DataGridView();
            btnTypesave = new Button();
            GroupBox2 = new GroupBox();
            btnunit = new Button();
            Label2 = new Label();
            GroupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtgtypelist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgulist).BeginInit();
            GroupBox2.SuspendLayout();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgtypelist
            // 
            dtgtypelist.AllowUserToAddRows = false;
            dtgtypelist.AllowUserToDeleteRows = false;
            dtgtypelist.AllowUserToResizeColumns = false;
            dtgtypelist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dtgtypelist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgtypelist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgtypelist.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgtypelist.Location = new Point(7, 62);
            dtgtypelist.Margin = new Padding(4, 4, 4, 4);
            dtgtypelist.Name = "dtgtypelist";
            dtgtypelist.RowHeadersVisible = false;
            dtgtypelist.Size = new Size(324, 360);
            dtgtypelist.TabIndex = 3;
            dtgtypelist.Click += dtgtypelist_Click;
            // 
            // txtunit
            // 
            txtunit.Location = new Point(84, 32);
            txtunit.Margin = new Padding(4, 4, 4, 4);
            txtunit.Name = "txtunit";
            txtunit.Size = new Size(247, 20);
            txtunit.TabIndex = 2;
            // 
            // btnusave
            // 
            btnusave.BackColor = Color.White;
            btnusave.ForeColor = Color.Black;
            btnusave.Location = new Point(338, 36);
            btnusave.Margin = new Padding(4, 4, 4, 4);
            btnusave.Name = "btnusave";
            btnusave.Size = new Size(88, 26);
            btnusave.TabIndex = 0;
            btnusave.Text = "Save";
            btnusave.UseVisualStyleBackColor = false;
            btnusave.Click += btnusaverent_Click;
            // 
            // btncdel
            // 
            btncdel.BackColor = Color.White;
            btncdel.ForeColor = Color.Black;
            btncdel.Location = new Point(338, 103);
            btncdel.Margin = new Padding(4, 4, 4, 4);
            btncdel.Name = "btncdel";
            btncdel.Size = new Size(88, 26);
            btncdel.TabIndex = 6;
            btncdel.Text = "Delete";
            btncdel.UseVisualStyleBackColor = false;
            btncdel.Click += btncdel_Click;
            // 
            // btntypeupdate
            // 
            btntypeupdate.BackColor = Color.White;
            btntypeupdate.ForeColor = Color.Black;
            btntypeupdate.Location = new Point(338, 69);
            btntypeupdate.Margin = new Padding(4, 4, 4, 4);
            btntypeupdate.Name = "btntypeupdate";
            btntypeupdate.Size = new Size(88, 26);
            btntypeupdate.TabIndex = 5;
            btntypeupdate.Text = "Update";
            btntypeupdate.UseVisualStyleBackColor = false;
            btntypeupdate.Click += btntypeupdate_Click;
            // 
            // btntypeLoad
            // 
            btntypeLoad.BackColor = Color.White;
            btntypeLoad.ForeColor = Color.Black;
            btntypeLoad.Location = new Point(338, 140);
            btntypeLoad.Margin = new Padding(4, 4, 4, 4);
            btntypeLoad.Name = "btntypeLoad";
            btntypeLoad.Size = new Size(88, 26);
            btntypeLoad.TabIndex = 4;
            btntypeLoad.Text = "Load";
            btntypeLoad.UseVisualStyleBackColor = false;
            btntypeLoad.Click += btntypeLoad_Click;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(84, 32);
            txtCategory.Margin = new Padding(4, 4, 4, 4);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(247, 20);
            txtCategory.TabIndex = 2;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label1.ForeColor = Color.Black;
            Label1.Location = new Point(7, 36);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(65, 13);
            Label1.TabIndex = 1;
            Label1.Text = "Category :";
            // 
            // btnuupdate
            // 
            btnuupdate.BackColor = Color.White;
            btnuupdate.ForeColor = Color.Black;
            btnuupdate.Location = new Point(338, 69);
            btnuupdate.Margin = new Padding(4, 4, 4, 4);
            btnuupdate.Name = "btnuupdate";
            btnuupdate.Size = new Size(88, 26);
            btnuupdate.TabIndex = 5;
            btnuupdate.Text = "Update";
            btnuupdate.UseVisualStyleBackColor = false;
            btnuupdate.Click += rentcategorybtnuupdate_Click;
            // 
            // btnuload
            // 
            btnuload.BackColor = Color.White;
            btnuload.ForeColor = Color.Black;
            btnuload.Location = new Point(338, 135);
            btnuload.Margin = new Padding(4, 4, 4, 4);
            btnuload.Name = "btnuload";
            btnuload.Size = new Size(88, 26);
            btnuload.TabIndex = 4;
            btnuload.Text = "Load";
            btnuload.UseVisualStyleBackColor = false;
            btnuload.Click += rentbtnuload_Click;
            // 
            // dtgulist
            // 
            dtgulist.AllowUserToAddRows = false;
            dtgulist.AllowUserToDeleteRows = false;
            dtgulist.AllowUserToResizeColumns = false;
            dtgulist.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dtgulist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dtgulist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgulist.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgulist.Location = new Point(7, 62);
            dtgulist.Margin = new Padding(4, 4, 4, 4);
            dtgulist.Name = "dtgulist";
            dtgulist.RowHeadersVisible = false;
            dtgulist.Size = new Size(324, 360);
            dtgulist.TabIndex = 3;
            dtgulist.CellContentClick += dtgulist_CellContentClick;
            dtgulist.Click += rentdtgulist_Click;
            // 
            // btnTypesave
            // 
            btnTypesave.BackColor = Color.White;
            btnTypesave.ForeColor = Color.Black;
            btnTypesave.Location = new Point(338, 36);
            btnTypesave.Margin = new Padding(4, 4, 4, 4);
            btnTypesave.Name = "btnTypesave";
            btnTypesave.Size = new Size(88, 26);
            btnTypesave.TabIndex = 0;
            btnTypesave.Text = "Save";
            btnTypesave.UseVisualStyleBackColor = false;
            btnTypesave.Click += btnTypesave_Click;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(btnunit);
            GroupBox2.Controls.Add(btnuupdate);
            GroupBox2.Controls.Add(btnuload);
            GroupBox2.Controls.Add(dtgulist);
            GroupBox2.Controls.Add(txtunit);
            GroupBox2.Controls.Add(Label2);
            GroupBox2.Controls.Add(btnusave);
            GroupBox2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            GroupBox2.ForeColor = Color.Black;
            GroupBox2.Location = new Point(457, 10);
            GroupBox2.Margin = new Padding(4, 4, 4, 4);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Padding = new Padding(4, 4, 4, 4);
            GroupBox2.Size = new Size(436, 429);
            GroupBox2.TabIndex = 14;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Add New Rental Type";
            // 
            // btnunit
            // 
            btnunit.BackColor = Color.White;
            btnunit.ForeColor = Color.Black;
            btnunit.Location = new Point(338, 101);
            btnunit.Margin = new Padding(4, 4, 4, 4);
            btnunit.Name = "btnunit";
            btnunit.Size = new Size(88, 26);
            btnunit.TabIndex = 7;
            btnunit.Text = "Delete";
            btnunit.UseVisualStyleBackColor = false;
            btnunit.Click += rentbtnunit_Click;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label2.ForeColor = Color.Black;
            Label2.Location = new Point(7, 36);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(47, 13);
            Label2.TabIndex = 1;
            Label2.Text = "Type: :";
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(btncdel);
            GroupBox1.Controls.Add(btntypeupdate);
            GroupBox1.Controls.Add(btntypeLoad);
            GroupBox1.Controls.Add(dtgtypelist);
            GroupBox1.Controls.Add(txtCategory);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Controls.Add(btnTypesave);
            GroupBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            GroupBox1.ForeColor = Color.Black;
            GroupBox1.Location = new Point(14, 10);
            GroupBox1.Margin = new Padding(4, 4, 4, 4);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Padding = new Padding(4, 4, 4, 4);
            GroupBox1.Size = new Size(436, 429);
            GroupBox1.TabIndex = 13;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Add new Category";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 449);
            Controls.Add(GroupBox2);
            Controls.Add(GroupBox1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Settings";
            Text = "Maintenance";
            Load += frmSettings_Load;
            ((System.ComponentModel.ISupportInitialize)dtgtypelist).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgulist).EndInit();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        internal DataGridView dtgtypelist;
        internal TextBox txtunit;
        internal Button btnusave;
        internal Button btncdel;
        internal Button btntypeupdate;
        internal Button btntypeLoad;
        internal TextBox txtCategory;
        internal Label Label1;
        internal Button btnuupdate;
        internal Button btnuload;
        internal DataGridView dtgulist;
        internal Button btnTypesave;
        internal GroupBox GroupBox2;
        internal Button btnunit;
        internal Label Label2;
        internal GroupBox GroupBox1;
    }
}