using System.Collections.Generic;
using System.Data;
using System.Linq;
using QuanLyHocSinhTieuHoc.DataAccessLayer;
using QuanLyHocSinhTieuHoc.DataTransferObject;
using QuanLyHocSinhTieuHoc.Utils;

namespace QuanLyHocSinhTieuHoc.BusinessLogicLayer
{
    public class LopBLL
    {
        private Lop dal = new Lop();
        public List<LopDTO> GetAll(string tuKhoa)
        {
            if (string.IsNullOrEmpty(tuKhoa)) return dal.GetAll();
            return dal.GetAll().Where(x =>
                x.TenLop.Contains(tuKhoa) || x.MaLop.ToString().Contains(tuKhoa) || x.TenGV.Contains(tuKhoa)).ToList();
        }

        public string Add(LopDTO dto)
        {
            if (dal.Add(dto) > 0) return "Thành  công";
            return "Thất bại";
        }

        public string Update(LopDTO dto)
        {
            if (dal.Update(dto) > 0) return "Thành công";
            return "Thất bại";
        }

        public string Delete(int MaLop)
        {
            if (dal.Delete(MaLop) > 0) return "Thành công";
            return "Thất bại";
        }
    }
}