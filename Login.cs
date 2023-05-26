namespace NparkieApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Home hm = new();
                hm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Silahkan masukkan detail dengan benar!");
            }
        }
    }
}