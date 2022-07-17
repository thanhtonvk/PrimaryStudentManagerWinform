using System.Collections.Generic;
using System.Data;
using QuanLyHocSinhTieuHoc.DataTransferObject;
using QuanLyHocSinhTieuHoc.Utils;

namespace QuanLyHocSinhTieuHoc.DataAccessLayer
{
    public class Diem
    {
        public List<DiemDTO> GetAll(int MaHS)
        {
            string query =
                "select MaDiem, HocSinh.MaHS,HoTen, DiemToan, DiemTV, HocKi, NamHoc from Diem,HocSinh where Diem.MaHS = HocSinh.MaHS and HocSinh.MaHS = "+MaHS;
            List<DiemDTO> list = new List<DiemDTO>();
            DataTable dt = DBHelper.Query(query, null);
            foreach (DataRow row in dt.Rows)
            {
                DiemDTO dto = new DiemDTO()
                {
                    DiemToan = float.Parse(row["DiemToan"].ToString()),
                    DiemTV = float.Parse(row["DiemTV"].ToString()),
                    HocKi = int.Parse(row["HocKi"].ToString()),
                    HoTen = row["HoTen"].ToString(),
                    MaDiem = int.Parse(row["MaDiem"].ToString()),
                    MaHS = int.Parse(row["MaHS"].ToString()),
                    NamHoc = int.Parse(row["NamHoc"].ToString())
                };
                list.Add(dto);
            }

            return list;
        }
        public int Add(DiemDTO dto)
        {
            string query =
                $"insert into Diem(MaHS, DiemToan, DiemTV, HocKi, NamHoc) values ({dto.MaHS},{dto.DiemToan},{dto.DiemTV},{dto.HocKi},{dto.NamHoc})";
            return DBHelper.NonQuery(query, null);
        }

        public int Update(DiemDTO dto)
        {
            string query =
                $"update Diem set MaHS = {dto.MaHS},DiemToan ={dto.DiemToan},DiemTV = {dto.DiemTV},HocKi = {dto.HocKi},NamHoc= {dto.NamHoc} where MaDiem = {dto.MaDiem}";
            return DBHelper.NonQuery(query, null);
        }

        public int Delete(int MaDiem)
        {
            string query = $"delete from Diem where MaDiem = {MaDiem}";
            return DBHelper.NonQuery(query, null);
        }
    }
}