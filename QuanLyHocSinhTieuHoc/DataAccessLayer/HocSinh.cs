using System.Collections.Generic;
using System.Data;
using QuanLyHocSinhTieuHoc.DataTransferObject;
using QuanLyHocSinhTieuHoc.Utils;

namespace QuanLyHocSinhTieuHoc.DataAccessLayer
{
    public class HocSinh
    {
        public List<HocSinhDTO> GetAll(int MaGV)
        {
            string query =
                "select HocSinh.MaHS, HoTen, NgaySinh, DiaChi, SDTLienLac,Lop.MaLop,Lop.TenLop from HocSinh,Lop where HocSinh.MaLop=Lop.MaLop and Lop.MaGV = "+MaGV;
            DataTable dt = DBHelper.Query(query, null);
            List<HocSinhDTO> list = new List<HocSinhDTO>();
            foreach (DataRow row in dt.Rows)
            {
                HocSinhDTO dto = new HocSinhDTO()
                {
                    DiaChi = row["DiaChi"].ToString(),
                    HoTen = row["HoTen"].ToString(),
                    MaHS = int.Parse(row["MaHS"].ToString()),
                    MaLop = int.Parse(row["MaLop"].ToString()),
                    NgaySinh = row["NgaySinh"].ToString(),
                    SDTLienLac = row["SDTLienLac"].ToString(),
                    TenLop = row["TenLop"].ToString()
                };
                list.Add(dto);
            }

            return list;
        }

        public int Add(HocSinhDTO dto)
        {
            string query =
                $"insert into HocSinh(HoTen, NgaySinh, DiaChi, SDTLienLac, MaLop) values (N'{dto.HoTen}','{dto.NgaySinh}',N'{dto.DiaChi}','{dto.SDTLienLac}',{dto.MaLop})";
            return DBHelper.NonQuery(query, null);
        }

        public int Update(HocSinhDTO dto)
        {
            string query =
                $"update HocSinh set HoTen= N'{dto.HoTen}',NgaySinh = '{dto.NgaySinh}',DiaChi = N'{dto.DiaChi}',SDTLienLac = '{dto.SDTLienLac}',MaLop = {dto.MaLop}";
            return DBHelper.NonQuery(query, null);
        }

        public int Delete(int MaHS)
        {
            string query = $"delete from HocSinh where MaHS = {MaHS}";
            return DBHelper.NonQuery(query, null);
        }
    }
}