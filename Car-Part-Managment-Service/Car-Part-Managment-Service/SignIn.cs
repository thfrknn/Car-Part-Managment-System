using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Part_Managment_Service
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SıgnIn1_Click(object sender, EventArgs e)
        {
            // Kullanıcı bilgilerini al
            string username = textuname.Text;
            string password = textpass.Text;
            string name = textname.Text;
            string surname = textsurname.Text;
            string phone = textphone.Text;

            // Veritabanı bağlantısı oluştur
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-78855J8\\SQLEXPRESS;Initial Catalog=CarPart;Integrated Security=True;");

            try
            {
                conn.Open();
                // SQL komutunu hazırla
                string query = "INSERT INTO login (username, password, name, surname, phone) VALUES (@username, @password, @name, @surname, @phone)";
                SqlCommand cmd = new SqlCommand(query, conn);
                // Parametreleri ekle
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@phone", phone);

                // Komutu çalıştır ve etkilenen satır sayısını al
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("User registered successfully");
                    this.Close(); // Formu kapat
                    Form1 loginForm = new Form1(); // Yeni giriş formunu oluştur
                    loginForm.Show(); // Yeni giriş formunu göster
                }
                else
                {
                    MessageBox.Show("Registration failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Şu anki formu kapat
            Form1 loginForm = new Form1(); // Yeni giriş formunu oluştur
            loginForm.Show(); // Yeni giriş formunu göster
        }
    }
}
