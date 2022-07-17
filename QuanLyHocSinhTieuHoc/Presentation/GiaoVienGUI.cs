using QuanLyHocSinhTieuHoc.BusinessLogicLayer;
using QuanLyHocSinhTieuHoc.DataTransferObject;
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
    public partial class GiaoVienGUI : Form
    {
        public GiaoVienGUI()
        {
            InitializeComponent();
            Load();
        }
        HocSinhBLL hocSinhBLL = new HocSinhBLL();
        LopBLL lopBLL = new LopBLL();
        private void Load()
        {
            dgvhocsinh.DataSource = hocSinhBLL.GetAll("");
            dgvhocsinh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvhocsinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cblop.DataSource = lopBLL.GetAll("");
            cblop.DisplayMember = "TenLop";
            cblop.ValueMember = "MaLop";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            HocSinhDTO dto = new HocSinhDTO()
            {
                DiaChi = txtdiacchi.Text,
                HoTen = txthoten.Text,
                MaLop = (cblop.SelectedItem as LopDTO).MaLop,
                NgaySinh = dtpngaysinh.Value.ToString("dd/MM/yyyy"),
                SDTLienLac = txtsdt.Text,
            };
            MessageBox.Show(hocSinhBLL.Add(dto));
            Load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HocSinhDTO dto = new HocSinhDTO()
            {
                MaHS = Common.MaHS,
                DiaChi = txtdiacchi.Text,
                HoTen = txthoten.Text,
                MaLop = (cblop.SelectedItem as LopDTO).MaLop,
                NgaySinh = dtpngaysinh.Value.ToString("dd/MM/yyyy"),
                SDTLienLac = txtsdt.Text,
            };
            MessageBox.Show(hocSinhBLL.Update(dto));
            Load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hocSinhBLL.Delete(Common.MaHS));
            Load();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvhocsinh.DataSource = hocSinhBLL.GetAll(txttimkiem.Text);
        }
        private void dgvhocsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dgvhocsinh.Rows)
            {
                Common.MaHS = int.Parse(row.Cells[0].Value.ToString());
                txthoten.Text = row.Cells[1].Value.ToString();
                txtdiacchi.Text = row.Cells[3].Value.ToString();
                txtsdt.Text = row.Cells[4].Value.ToString();
                button5.Text = "Quản lý điểm học sinh: " + txthoten.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QuanLyDiemGUI gui = new QuanLyDiemGUI();
            gui.ShowDialog();
        }
    }
}
