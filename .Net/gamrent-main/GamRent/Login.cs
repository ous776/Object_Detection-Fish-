using GamRent.Model;
using GamRent.Services;

namespace GamRent
{
    public partial class Login : Form
    {
        //Form1 frm;
        private readonly IDataService<User> _dataService;
        private readonly CrudContextFactory crudContextFactory = new CrudContextFactory();
        public Login()
        {
            InitializeComponent();
            _dataService = new DataService<User>(crudContextFactory);

            //this.frm = frm;
        }
        SQLConfig config = new SQLConfig();
        string sql;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToShortTimeString();
            lbldate.Text = DateTime.Now.ToShortDateString();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Timer1.Start();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
               // Use parameterized query to prevent SQL injection
            sql = "SELECT * FROM user WHERE user_name = @username AND pass = sha1(@password)";

            // Use parameterized query to prevent SQL injection
            var parameters = new Dictionary<string, object>
    {
        { "@username", txtusername.Text },
        { "@password", txtpass.Text }
    };

            var password = Encryption.Encrypt(txtpass.Text); // Assuming this is a hash function
            var user = await _dataService.SearchForAnEntity(e => e.UserName == txtusername.Text && e.Password == password);

            if (user != null)
            {
                // Hide the login form
                this.Hide();

                // Show the main form as a dialog
                using (var mainForm = new Main())
                {
                    mainForm.ShowDialog();
                }

                // Close the login form after the main form is closed
                this.Close();
            }
            else
            {
                MessageBox.Show("Account does not exist! Please contact the administrator.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtpass.Clear();
            txtusername.Clear();
            txtusername.Focus();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
