using System.Text.RegularExpressions;

namespace DuAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void lkbDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKys = new DangKy();
            dangKys.ShowDialog();
        }

        public bool CheckCount(string message) // check m?t kh?u và tài kho?n
        {
            return Regex.IsMatch(message, @"^[A-Za-z0-9]{8,24}$");
        }
        private void btnDangnhap_Click_1(object sender, EventArgs e)
        {
            string username = txtname.Text; string password = txtpassword.Text;

            if (username.Trim() == "")
            {
                MessageBox.Show("Vui lòng nh?p tên tài kho?n", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (password.Length < 8)
            {
                MessageBox.Show("M?t kh?u ph?i t? 8-24 ký t? ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("??ng nh?p thành công", "thông báo", MessageBoxButtons.OK);
                FormSQL sql = new FormSQL();
                sql.ShowDialog();
            }
        }
    }
}