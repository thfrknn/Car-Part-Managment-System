using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Part_Managment_Service
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-78855J8\\SQLEXPRESS;Initial Catalog=CarPart;Integrated Security=True;");

        private void label1_Click(object sender, EventArgs e)
        {
            // Yapmak istediğiniz işlemleri buraya ekleyin.
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            // Yapmak istediğiniz işlemleri buraya ekleyin.
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = txtuname.Text;
            string userpassword = txtpass.Text;

            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM login WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", userpassword);

                int result = (int)cmd.ExecuteScalar();
                if (result > 0)
                {
                    this.Hide();
                    MainPage ss = new MainPage();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                    txtuname.Clear();
                    txtpass.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signInForm = new SignIn();
            signInForm.Show();
        }

        private void txtuname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Enter tuşuna basıldığında txtpass'a odaklan
                txtpass.Focus();
                // Tuşa basma işlemi burada işlensin
                e.Handled = true;
            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Enter tuşuna basıldığında login butonunu tıkla
                login_Click(sender, e);
                // Tuşa basma işlemi burada işlensin
                e.Handled = true;
            }
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
