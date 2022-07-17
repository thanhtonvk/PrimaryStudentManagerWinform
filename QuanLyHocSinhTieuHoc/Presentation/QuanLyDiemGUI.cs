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
    public partial class QuanLyDiemGUI : Form
    {
        public QuanLyDiemGUI()
        {
            InitializeComponent();
            Load();
        }
        DiemBLL diemBLL = new DiemBLL();
        private void Load()
        {
            dgvdiem.DataSource = diemBLL.GetAll("");
            dgvdiem.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvdiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiemDTO dto = new DiemDTO()
            {
                MaHS = Common.MaHS,
                DiemToan = int.Parse(txttoan.Text.Trim()),
                DiemTV = int.Parse(txttv.Text.Trim()),
                HocKi = int.Parse(cbhocki.SelectedItem.ToString()),
                NamHoc = int.Parse(txtnamhoc.Text.Trim())
            };
            MessageBox.Show(diemBLL.Add(dto));
            Load();
        }
        int IdDiem=-1;

        private void button2_Click(object sender, EventArgs e)
        {
            DiemDTO dto = new DiemDTO()
            {
                MaDiem = IdDiem,
                MaHS = Common.MaHS,
                DiemToan = int.Parse(txttoan.Text.Trim()),
                DiemTV = int.Parse(txttv.Text.Trim()),
                HocKi = int.Parse(cbhocki.SelectedItem.ToString()),
                NamHoc = int.Parse(txtnamhoc.Text.Trim())
            };
            MessageBox.Show(diemBLL.Update(dto));
            Load();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(diemBLL.Delete(IdDiem));
            Load();
        }
        //public int MaDiem { get; set; }
        //public int MaHS { get; set; }
        //public string HoTen { get; set; }
        //public float DiemToan { get; set; }
        //public float DiemTV { get; set; }
        //public int HocKi { get; set; }
        //public int NamHoc { get; set; }

        private void dgvdiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dgvdiem.SelectedRows)
            {
                IdDiem = int.Parse(row.Cells[0].Value.ToString());
                txttoan.Text = row.Cells[3].Value.ToString();
                txttv.Text = row.Cells[4].Value.ToString();
                txtnamhoc.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
