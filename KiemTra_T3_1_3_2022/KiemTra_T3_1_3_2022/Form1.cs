namespace KiemTra_T3_1_3_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = tb_username.Text;
            password = tb_matkhau.Text;
            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Thong bao", "Dang nhap thanh cong");
            }
        }
    }
}