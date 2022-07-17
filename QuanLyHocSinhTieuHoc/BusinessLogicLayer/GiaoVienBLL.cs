using System.Collections.Generic;
using System.Linq;
using QuanLyHocSinhTieuHoc.DataAccessLayer;
using QuanLyHocSinhTieuHoc.DataTransferObject;

namespace QuanLyHocSinhTieuHoc.BusinessLogicLayer
{
    public class GiaoVienBLL
    {
        private GiaoVien dal = new GiaoVien(); 
        public List<GiaoVienDTO> GetAll(string tuKhoa)
        {
            if (string.IsNullOrEmpty(tuKhoa)) return dal.GetAll();
            return dal.GetAll()
                .Where(x => x.HoTen.Contains(tuKhoa) || x.DiaChi.Contains(tuKhoa) || x.SDT.Contains(tuKhoa)).ToList();
        }

        public string Add(GiaoVienDTO dto)
        {
            if (dal.Add(dto) > 0) return "Thành công";
            return "Thất bại";
        }

        public string Update(GiaoVienDTO dto)
        {
            if (dal.Update(dto) > 0) return "Thành công";
            return "Thất bại";
        }

        public string Delete(int MaGV)
        {
            if (dal.Delete(MaGV) > 0) return "Thành công";
            return "Thất bại";
        }
        public int DangNhap(int maGV,string matKhau)
        {
            GiaoVienDTO dto = GetAll("").FirstOrDefault(x => x.MaGV == maGV && x.MatKhau == matKhau);
            if (dto == null) return 0;
            return dto.MaGV;
        }
    }
}