using QuanLyHocSinhTieuHoc.BusinessLogicLayer;
using QuanLyHocSinhTieuHoc.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinhTieuHoc.Presentation
{
    public partial class DangNhapGUI : Form
    {
        public DangNhapGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.Text == "admin" && txtmatkhau.Text == "admin")
            {
                //đăng nhập quản lý giáo viên và quản lý lớp

                AdminGUI gui = new AdminGUI();
                gui.ShowDialog();

            }
            else
            {
                GiaoVienBLL bll = new GiaoVienBLL();
                int id = bll.DangNhap(int.Parse(txttaikhoan.Text), txtmatkhau.Text);
                if (id > 0)
                {
                    Common.MaGV = id;
                    GiaoVienGUI gui = new GiaoVienGUI();
                    gui.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                }
            }

        }
    }
}
