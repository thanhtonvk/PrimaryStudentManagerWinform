using System.Collections.Generic;
using System.Linq;
using QuanLyHocSinhTieuHoc.DataAccessLayer;
using QuanLyHocSinhTieuHoc.DataTransferObject;
using QuanLyHocSinhTieuHoc.Utils;

namespace QuanLyHocSinhTieuHoc.BusinessLogicLayer
{
    public class DiemBLL
    {
        private Diem dal = new Diem();
        public List<DiemDTO> GetAll(string tuKhoa)
        {
            if (string.IsNullOrEmpty(tuKhoa)) return dal.GetAll(Common.MaHS);
            return dal.GetAll(Common.MaHS).Where(x =>
                x.HoTen.Contains(tuKhoa) || x.MaDiem.ToString().Contains(tuKhoa) || x.NamHoc.ToString().Contains(tuKhoa)).ToList();
        }

        public string Add(DiemDTO dto)
        {
            if (dal.Add(dto) > 0) return "Thành  công";
            return "Thất bại";
        }

        public string Update(DiemDTO dto)
        {
            if (dal.Update(dto) > 0) return "Thành công";
            return "Thất bại";
        }

        public string Delete(int MaDiem)
        {
            if (dal.Delete(MaDiem) > 0) return "Thành công";
            return "Thất bại";
        }
    }
}