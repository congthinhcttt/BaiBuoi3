using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1buoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXuatThongTin_Click(object sender, EventArgs e)
        {

            // Lấy thông tin từ các control
            string hoTen = txtHoTen.Text;
            string gioiTinh = optNam.Checked ? "Nam" : "Nữ";
            string ngaySinh = dtpNgaySinh.Text;
            string soThich = "";

            // Kiểm tra các checkbox
            if (chkTheThao.Checked) soThich += "Thể Thao ";
            if (chkPhim.Checked) soThich += "Phim ";
            if (chkDuLich.Checked) soThich += "Du Lịch ";

            // Xuất thông tin
            string thongTin = $"Họ Tên: {hoTen}\nGiới Tính: {gioiTinh}\nNgày Sinh: {ngaySinh}\nSở Thích: {soThich}";
            MessageBox.Show(thongTin, "Thông Tin Cá Nhân");
        }
    }
}
