using System.Collections.Generic;
using System.Linq;
using QuanLyHocSinhTieuHoc.DataAccessLayer;
using QuanLyHocSinhTieuHoc.DataTransferObject;
using QuanLyHocSinhTieuHoc.Utils;

namespace QuanLyHocSinhTieuHoc.BusinessLogicLayer
{
    public class HocSinhBLL
    {
        private HocSinh dal = new HocSinh();
        public List<HocSinhDTO> GetAll(string tuKhoa)
        {
            if (string.IsNullOrEmpty(tuKhoa)) return dal.GetAll(Common.MaGV);
            return dal.GetAll(Common.MaGV).Where(x =>
                x.HoTen.Contains(tuKhoa) || x.MaHS.ToString().Contains(tuKhoa) || x.DiaChi.Contains(tuKhoa)).ToList();
        }

        public string Add(HocSinhDTO dto)
        {
            if (dal.Add(dto) > 0) return "Thành  công";
            return "Thất bại";
        }

        public string Update(HocSinhDTO dto)
        {
            if (dal.Update(dto) > 0) return "Thành công";
            return "Thất bại";
        }

        public string Delete(int MaHocSinh)
        {
            if (dal.Delete(MaHocSinh) > 0) return "Thành công";
            return "Thất bại";
        }
    }
}