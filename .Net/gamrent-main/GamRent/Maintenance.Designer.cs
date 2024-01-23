namespace GamRent
{
    partial class Maintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maintenance));
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            txt_Cost = new TextBox();
            txt_Service = new TextBox();
            txt_RentalNo = new TextBox();
            txt_AssetNo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btn_save = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_new = new Button();
            btn_close = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(txt_Cost);
            panel1.Controls.Add(txt_Service);
            panel1.Controls.Add(txt_RentalNo);
            panel1.Controls.Add(txt_AssetNo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 322);
            panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(123, 205);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(502, 96);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // txt_Cost
            // 
            txt_Cost.Location = new Point(143, 168);
            txt_Cost.Name = "txt_Cost";
            txt_Cost.Size = new Size(482, 31);
            txt_Cost.TabIndex = 8;
            // 
            // txt_Service
            // 
            txt_Service.Location = new Point(105, 105);
            txt_Service.Name = "txt_Service";
            txt_Service.Size = new Size(520, 31);
            txt_Service.TabIndex = 7;
            // 
            // txt_RentalNo
            // 
            txt_RentalNo.Location = new Point(105, 64);
            txt_RentalNo.Name = "txt_RentalNo";
            txt_RentalNo.Size = new Size(520, 31);
            txt_RentalNo.TabIndex = 6;
            // 
            // txt_AssetNo
            // 
            txt_AssetNo.Location = new Point(105, 11);
            txt_AssetNo.Name = "txt_AssetNo";
            txt_AssetNo.Size = new Size(520, 31);
            txt_AssetNo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 236);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 4;
            label5.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 164);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 3;
            label4.Text = "Estimate Cost:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 108);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 2;
            label3.Text = "Servicer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 64);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 1;
            label2.Text = "Rental No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 0;
            label1.Text = "Asset No:";
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 422);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1222, 362);
            dataGridView1.TabIndex = 1;
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.Window;
            btn_save.FlatStyle = FlatStyle.Popup;
            btn_save.Location = new Point(54, 352);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(99, 42);
            btn_save.TabIndex = 2;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(196, 352);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(140, 42);
            btn_update.TabIndex = 3;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(372, 352);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(132, 42);
            btn_delete.TabIndex = 4;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_new
            // 
            btn_new.Location = new Point(540, 352);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(127, 42);
            btn_new.TabIndex = 5;
            btn_new.Text = "New";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(701, 347);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(122, 47);
            btn_close.TabIndex = 6;
            btn_close.Text = "Close";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // frmMaintenance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1222, 784);
            Controls.Add(btn_close);
            Controls.Add(btn_new);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_save);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1238, 0);
            Name = "frmMaintenance";
            Text = "Maintenance List";
            Load += frmMaintenance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btn_save;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_new;
        private Button btn_close;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private RichTextBox richTextBox1;
        private TextBox txt_Cost;
        private TextBox txt_Service;
        private TextBox txt_RentalNo;
        private TextBox txt_AssetNo;
    }
}