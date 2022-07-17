using System.Collections.Generic;
using System.Data;
using QuanLyHocSinhTieuHoc.DataTransferObject;
using QuanLyHocSinhTieuHoc.Utils;

namespace QuanLyHocSinhTieuHoc.DataAccessLayer
{
    public class GiaoVien
    {
        public List<GiaoVienDTO> GetAll()
        {
            List<GiaoVienDTO> list = new List<GiaoVienDTO>();
            string query = "select * from GiaoVien";
            DataTable dt = DBHelper.Query(query, null);
            foreach (DataRow row in dt.Rows)
            {
                GiaoVienDTO dto = new GiaoVienDTO()
                {
                    DiaChi = row["DiaChi"].ToString(),
                    HoTen = row["HoTen"].ToString(),
                    MaGV = int.Parse(row["MaGV"].ToString()),
                    MatKhau = row["MatKhau"].ToString(),
                    NgaySinh = row["NgaySinh"].ToString(),
                    SDT = row["SDT"].ToString()
                };
                list.Add(dto);
            }

            return list;
        }

        public int Add(GiaoVienDTO dto)
        {
            string query =
                $"insert into GiaoVien(MatKhau, HoTen, NgaySinh, DiaChi, SDT) values('{dto.MatKhau}',N'{dto.HoTen}','{dto.NgaySinh}',N'{dto.DiaChi}','{dto.SDT}')";
            return DBHelper.NonQuery(query, null);
        }

        public int Update(GiaoVienDTO dto)
        {
            string query =
                $"update GiaoVien set MatKhau= '{dto.MatKhau}',HoTen = N'{dto.HoTen}',NgaySinh=N'{dto.NgaySinh}',DiaChi = N'{dto.DiaChi}',SDT = '{dto.SDT}' where MaGV = {dto.MaGV}";
            return DBHelper.NonQuery(query, null);
        }

        public int Delete(int MaGV)
        {
            string query = $"delete from GiaoVien where MaGV = {MaGV}";
            return DBHelper.NonQuery(query,null);
        }
    }
}