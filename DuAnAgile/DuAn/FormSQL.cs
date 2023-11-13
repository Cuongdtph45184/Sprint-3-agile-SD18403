using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DuAn
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        DB db = new DB();

        private void btnSua_Click(object sender, EventArgs e)
        {
            db.updateData(txtMaSv, txtTenSv, dtpNgaySinh, CboGioiTinh, txtEmail, txtLop, txtDiemIT, txtDiemTiengAnh, txtDiemDuAn, txtDiemTB, lvDanhSach);
            FormSQL_Load(null, null);//load laij du lieu
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            db.saveData(txtMaSv, txtTenSv, dtpNgaySinh, CboGioiTinh, txtEmail, txtLop, txtDiemIT, txtDiemTiengAnh, txtDiemDuAn, txtDiemTB);
            //
            FormSQL_Load(null, null);
        }

        private void FormSQL_Load(object sender, EventArgs e)
        {
            db.ketnoi();
            db.getData(lvDanhSach);
        }

        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.getDataToTextBox(txtMaSv, txtTenSv, dtpNgaySinh, CboGioiTinh, txtEmail, txtLop, txtDiemIT, txtDiemTiengAnh, txtDiemDuAn, txtDiemTB, lvDanhSach);
        }

        private void txtDiemTB_TextChanged(object sender, EventArgs e)
        {
            float diem1 = float.Parse(txtDiemDuAn.Text);
            float diem2 = float.Parse(txtDiemIT.Text);
            float diem3 = float.Parse(txtDiemTiengAnh.Text);

            // Tính điểm trung bình
            float diemTrungBinh = (diem1 + diem2 + diem3) / 3;
            txtDiemTB.Text = diemTrungBinh.ToString();
        }
    }
}
