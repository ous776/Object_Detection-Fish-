using System.Resources;

namespace GamRent
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public void closeForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

        }


        public void showFrm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void ts_assets_Click(object sender, EventArgs e)
        {
            closeForm();
            Assets assetsForm = new Assets();
            showFrm(new Assets());
        }

        private void ts_Tenants_Click(object sender, EventArgs e)
        {
            closeForm();
            Tenants assetsForm = new Tenants("");
            showFrm(new Tenants(""));
        }

        private void ts_Return_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new Rentals());
        }

        private void ts_ManageUsers_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new Users());
        }

        private void ts_Report_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new Maintenance());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void ts_settings_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new Settings());
        }

        private void SetChildFormProperties(Form childForm)
        {
            childForm.FormBorderStyle = FormBorderStyle.Sizable;
            childForm.Size = this.ClientSize;
            childForm.Dock = DockStyle.Fill;
            //childForm.TopLevel = true;
            //this.Controls.Add(childForm);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                // Adjust child forms when the main form is resized
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Size = this.ClientSize;
                }
            }
        }

        private void ts_maintenance_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new Maintenance());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            closeForm();

            using (var loginForm = new Login())
            {
                loginForm.ShowDialog();
            }
        }
    }
}