namespace GamRent
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            toolStrip1 = new ToolStrip();
            ts_stocks = new ToolStripButton();
            ts_StockOut = new ToolStripButton();
            ts_Return = new ToolStripButton();
            ts_ManageUsers = new ToolStripButton();
            ts_Report = new ToolStripButton();
            ts_settings = new ToolStripButton();
            ts_maintenance = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Teal;
            toolStrip1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            toolStrip1.ImageScalingSize = new Size(50, 35);
            toolStrip1.Items.AddRange(new ToolStripItem[] { ts_stocks, ts_StockOut, ts_Return, ts_ManageUsers, ts_Report, ts_settings, ts_maintenance, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 18, 0, 18);
            toolStrip1.Size = new Size(969, 101);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // ts_stocks
            // 
            ts_stocks.Image = (Image)resources.GetObject("ts_stocks.Image");
            ts_stocks.ImageTransparentColor = Color.Magenta;
            ts_stocks.Margin = new Padding(10, 1, 0, 2);
            ts_stocks.Name = "ts_stocks";
            ts_stocks.Padding = new Padding(10, 0, 10, 0);
            ts_stocks.Size = new Size(90, 62);
            ts_stocks.Text = "Assets ";
            ts_stocks.TextImageRelation = TextImageRelation.TextAboveImage;
            ts_stocks.Click += ts_assets_Click;
            // 
            // ts_StockOut
            // 
            ts_StockOut.Image = (Image)resources.GetObject("ts_StockOut.Image");
            ts_StockOut.ImageTransparentColor = Color.Magenta;
            ts_StockOut.Margin = new Padding(10, 1, 0, 2);
            ts_StockOut.Name = "ts_StockOut";
            ts_StockOut.Padding = new Padding(10, 0, 10, 0);
            ts_StockOut.Size = new Size(96, 62);
            ts_StockOut.Text = "Tenants";
            ts_StockOut.TextImageRelation = TextImageRelation.TextAboveImage;
            ts_StockOut.Click += ts_Tenants_Click;
            // 
            // ts_Return
            // 
            ts_Return.Image = (Image)resources.GetObject("ts_Return.Image");
            ts_Return.ImageTransparentColor = Color.Magenta;
            ts_Return.Margin = new Padding(10, 1, 0, 2);
            ts_Return.Name = "ts_Return";
            ts_Return.Padding = new Padding(10, 0, 10, 0);
            ts_Return.Size = new Size(91, 62);
            ts_Return.Text = "Rentals";
            ts_Return.TextImageRelation = TextImageRelation.TextAboveImage;
            ts_Return.Click += ts_Return_Click;
            // 
            // ts_ManageUsers
            // 
            ts_ManageUsers.Image = (Image)resources.GetObject("ts_ManageUsers.Image");
            ts_ManageUsers.ImageTransparentColor = Color.Magenta;
            ts_ManageUsers.Margin = new Padding(10, 1, 0, 2);
            ts_ManageUsers.Name = "ts_ManageUsers";
            ts_ManageUsers.Padding = new Padding(10, 0, 10, 0);
            ts_ManageUsers.Size = new Size(78, 62);
            ts_ManageUsers.Text = "Users";
            ts_ManageUsers.TextImageRelation = TextImageRelation.TextAboveImage;
            ts_ManageUsers.Click += ts_ManageUsers_Click;
            // 
            // ts_Report
            // 
            ts_Report.Image = (Image)resources.GetObject("ts_Report.Image");
            ts_Report.ImageTransparentColor = Color.Magenta;
            ts_Report.Margin = new Padding(10, 1, 0, 2);
            ts_Report.Name = "ts_Report";
            ts_Report.Padding = new Padding(10, 0, 10, 0);
            ts_Report.Size = new Size(85, 62);
            ts_Report.Text = "Report";
            ts_Report.TextImageRelation = TextImageRelation.TextAboveImage;
            ts_Report.Click += ts_Report_Click;
            // 
            // ts_settings
            // 
            ts_settings.Image = (Image)resources.GetObject("ts_settings.Image");
            ts_settings.ImageTransparentColor = Color.Magenta;
            ts_settings.Margin = new Padding(10, 1, 0, 2);
            ts_settings.Name = "ts_settings";
            ts_settings.Padding = new Padding(10, 0, 10, 0);
            ts_settings.Size = new Size(96, 62);
            ts_settings.Text = "Settings";
            ts_settings.TextImageRelation = TextImageRelation.TextAboveImage;
            ts_settings.Click += ts_settings_Click;
            // 
            // ts_maintenance
            // 
            ts_maintenance.ImageTransparentColor = Color.Magenta;
            ts_maintenance.Margin = new Padding(10, 1, 0, 2);
            ts_maintenance.Name = "ts_maintenance";
            ts_maintenance.Padding = new Padding(10, 0, 10, 0);
            ts_maintenance.Size = new Size(131, 62);
            ts_maintenance.Text = "Maintenance";
            ts_maintenance.TextImageRelation = TextImageRelation.TextAboveImage;
            ts_maintenance.Click += ts_maintenance_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Margin = new Padding(0, 0, 20, 0);
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Padding = new Padding(10, 0, 10, 0);
            toolStripButton1.Size = new Size(89, 65);
            toolStripButton1.Text = "Logout";
            toolStripButton1.TextImageRelation = TextImageRelation.TextAboveImage;
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 589);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 18, 0);
            statusStrip1.Size = new Size(969, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(969, 611);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MinimumSize = new Size(643, 588);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory System | Main";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton ts_stocks;
        private StatusStrip statusStrip1;
        private ToolStripButton ts_StockOut;
        private ToolStripButton ts_Return;
        private ToolStripButton ts_ManageUsers;
        private ToolStripButton ts_Report;
        private ToolStripButton ts_settings;
        private ToolStripButton ts_maintenance;
        private ToolStripButton toolStripButton1;
    }
}