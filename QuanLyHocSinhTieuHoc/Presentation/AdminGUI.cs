using QuanLyHocSinhTieuHoc.BusinessLogicLayer;
using QuanLyHocSinhTieuHoc.DataTransferObject;
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
    public partial class AdminGUI : Form
    {
        public AdminGUI()
        {
            InitializeComponent();
            Load();
        }
        GiaoVienBLL giaoVienBLL = new GiaoVienBLL();
        LopBLL lopBLL = new LopBLL();
        private void Load()
        {
            dgvgiaovien.DataSource = giaoVienBLL.GetAll("");
            dgvgiaovien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvgiaovien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvlop.DataSource = lopBLL.GetAll("");
            dgvlop.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvlop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbgvcn.DataSource = giaoVienBLL.GetAll("");
            cbgvcn.DisplayMember = "HoTen";
            cbgvcn.ValueMember = "MaGV";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GiaoVienDTO dto = new GiaoVienDTO()
            {
                DiaChi = txtdiachi.Text,
                HoTen = txthoten.Text,
                MatKhau = txtmk.Text,
                NgaySinh = dtpgv.Value.ToString("dd/MM/yyyy"),
                SDT = txtsdt.Text
            };
            MessageBox.Show(giaoVienBLL.Add(dto));
            Load();
        }
        int idGV = -1;
        private void button2_Click(object sender, EventArgs e)
        {
            GiaoVienDTO dto = new GiaoVienDTO()
            {
                MaGV = idGV,
                DiaChi = txtdiachi.Text,
                HoTen = txthoten.Text,
                MatKhau = txtmk.Text,
                NgaySinh = dtpgv.Value.ToString("dd/MM/yyyy"),
                SDT = txtsdt.Text
            };
            MessageBox.Show(giaoVienBLL.Update(dto));
            Load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(giaoVienBLL.Delete(idGV));
            Load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvgiaovien.DataSource = giaoVienBLL.GetAll(txttimkiem.Text);
        }
        private void dgvgiaovien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dgvgiaovien.SelectedRows)
            {
                idGV = int.Parse(row.Cells[0].Value.ToString());
                txtmk.Text = row.Cells[1].Value.ToString();
                txthoten.Text = row.Cells[2].Value.ToString();
              
                txtdiachi.Text = row.Cells[4].Value.ToString();
                txtsdt.Text = row.Cells[5].Value.ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LopDTO dto = new LopDTO()
            {
                Khoi = int.Parse(cbkhoi.SelectedItem.ToString()),
                MaGV = (cbgvcn.SelectedItem as GiaoVienDTO).MaGV,
                TenLop = txttenlop.Text
            };
            MessageBox.Show(lopBLL.Add(dto));
            Load();

        }
        int idLop = -1;
        private void button6_Click(object sender, EventArgs e)
        {
            LopDTO dto = new LopDTO()
            {
                MaLop = idLop,
                Khoi = int.Parse(cbkhoi.SelectedItem.ToString()),
                MaGV = (cbgvcn.SelectedItem as GiaoVienDTO).MaGV,
                TenLop = txttenlop.Text
            };
            MessageBox.Show(lopBLL.Update(dto));
            Load();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lopBLL.Delete(idLop));
            Load();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dgvlop.DataSource = lopBLL.GetAll(txttimkiemlop.Text);
        }

        private void dgvlop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row  in dgvlop.Rows)
            {
                idLop = int.Parse(row.Cells[0].Value.ToString());

            }
        }
    }
}
