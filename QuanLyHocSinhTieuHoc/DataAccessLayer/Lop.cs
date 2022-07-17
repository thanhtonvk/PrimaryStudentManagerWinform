using System.Collections.Generic;
using System.Data;
using QuanLyHocSinhTieuHoc.DataTransferObject;
using QuanLyHocSinhTieuHoc.Utils;

namespace QuanLyHocSinhTieuHoc.DataAccessLayer
{
    public class Lop
    {
        public List<LopDTO> GetAll()
        {
            string query =
                "select MaLop,TenLop,Khoi,GiaoVien.MaGV,HoTen from GiaoVien,Lop where GiaoVien.MaGV= Lop.MaGV";
            DataTable dt = DBHelper.Query(query, null);
            List<LopDTO> list = new List<LopDTO>();
            foreach (DataRow row in dt.Rows)
            {
                LopDTO dto = new LopDTO()
                {
                    Khoi = int.Parse(row["Khoi"].ToString()),
                    MaLop = int.Parse(row["MaLop"].ToString()),
                    MaGV = int.Parse(row["MaGV"].ToString()),
                    TenGV = row["HoTen"].ToString(),
                    TenLop = row["TenLop"].ToString()
                };
                list.Add(dto);
            }

            return list;
        }

        public int Add(LopDTO dto)
        {
            string query = $"insert into Lop(TenLop, Khoi, MaGV) values(N'{dto.TenLop}',{dto.Khoi},{dto.MaGV})";
            return DBHelper.NonQuery(query, null);
        }

        public int Update(LopDTO dto)
        {
            string query =
                $"update Lop set TenLop = N'{dto.TenLop}',Khoi = {dto.Khoi},MaGV = {dto.MaGV} where MaLop = {dto.MaLop}";
            return DBHelper.NonQuery(query, null);
        }

        public int Delete(int MaLop)
        {
            string query = $"delete from Lop where MaLop ={MaLop}";
            return DBHelper.NonQuery(query, null);
        }
        
    }
}