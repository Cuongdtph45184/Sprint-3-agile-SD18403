using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn
{
    public partial class DangKy : Form
    {
        string path = "account.txt"; //Biến này để lưu 
        public DangKy()
        {
            InitializeComponent();
        }
        private void btndangky_Click(object sender, EventArgs e)
        {
            bool check = true; // tạo 1 biến check để validate dữ liệu
            foreach (Control item in this.Controls)
            {
                if (item is TextBox && item.Text == "") // nếu controls là textbox rỗng
                {
                    MessageBox.Show("Hãy điền đủ thông tin");
                    check = false;
                    break;
                }
            }
            DialogResult result = MessageBox.Show("Do you want to save ?", "", MessageBoxButtons.YesNoCancel);
            if (check && result == DialogResult.Yes)
            {
                string name = txtten.Text;
                string email = txtemail.Text;
                string phone = txtphone.Text;
                string taikhoan = txttaikhoan.Text;
                string matkau = txtmatkhau.Text;
                string xacmk = txtxacnhanmk.Text;

                account ac = new account(name, email, phone, taikhoan, matkau, xacmk);
                string accountFile = ac.CreateAccount();
                File.AppendAllText(path, accountFile);

                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    { c.Text = ""; }
                }
            }
        }
    }
}
