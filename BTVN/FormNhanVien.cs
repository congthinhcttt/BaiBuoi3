using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BTVN.Form1;

namespace BTVN
{
    public partial class FormNhanVien : Form
    {
        public NhanVien nhanVienMoi { get; set; }
        private bool isDeleteMode;

        // Constructor cho thêm mới hoặc sửa nhân viên
        public  FormNhanVien(NhanVien nhanVien = null, bool isDelete = false)
        {
            InitializeComponent();

            isDeleteMode = isDelete;

            // Nếu là chế độ xóa, disable các textbox và chỉ hiển thị thông tin
            if (isDeleteMode)
            {
                txtmsnv.Enabled = false;
                txtfullname.Enabled = false;
                txtluongcb.Enabled = false;
                btnDongY.Text = "Xóa";

                if (nhanVien != null)
                {
                    txtmsnv.Text = nhanVien.MaSo;
                    txtfullname.Text = nhanVien.HoTen;
                    txtluongcb.Text = nhanVien.LuongCoBan.ToString();
                }
            }
            else
            {
                // Nếu sửa nhân viên, hiển thị thông tin lên các textbox
                if (nhanVien != null)
                {
                    txtmsnv.Text = nhanVien.MaSo;
                    txtfullname.Text = nhanVien.HoTen;
                    txtluongcb.Text = nhanVien.LuongCoBan.ToString();
                }
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (isDeleteMode)
            {
                // Nếu là xóa, chỉ cần đóng form và trả về DialogResult.OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                try
                {
                    // Lưu dữ liệu vào thuộc tính nhanVienMoi khi sửa hoặc thêm
                    nhanVienMoi = new NhanVien
                    {
                        MaSo = txtmsnv.Text,
                        HoTen = txtfullname.Text,
                        LuongCoBan = decimal.Parse(txtluongcb.Text) // Chuyển đổi từ chuỗi sang số thập phân
                    };

                    // Đặt kết quả là OK để truyền dữ liệu về Form1
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi nhập liệu: " + ex.Message);
                }
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            // Đóng form mà không lưu dữ liệu
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtmsnv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
