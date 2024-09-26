using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Test_Project_v1._0
{
    public partial class Login : Form
    {
        Connection conn = new Connection();
        MySqlCommand commandDatabase;
        MySqlDataReader myReader;
        String iquery;


        public Login()
        {
            InitializeComponent();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(usernameTxt.Text) || string.IsNullOrEmpty(passwordTxt.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            else
            {
                Connection.dataSource();
                conn.connOpen();
                iquery = "SELECT * FROM login_table WHERE username = '" + usernameTxt.Text + "' AND password = '" + passwordTxt.Text + "';";
                commandDatabase = new MySqlCommand(iquery, Connection.conn);
                myReader = commandDatabase.ExecuteReader();

                if (myReader.Read())
                {
                    this.Hide();
                    dashboardTab frm2 = new dashboardTab();
                    frm2.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Incorrect Login Information! Try again.");
                }
                conn.connClose();
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordTxt.PasswordChar = showPass.Checked ? '\0' : '*';
        }
    }
}
