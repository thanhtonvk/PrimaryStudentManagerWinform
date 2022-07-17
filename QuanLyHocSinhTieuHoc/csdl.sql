use master
go
create database QuanLyHocSinhTieuHoc
go
use QuanLyHocSinhTieuHoc
go
create table GiaoVien(
                         MaGV int identity (10000,1) primary key ,
                         MatKhau varchar(20) not null,
                         HoTen nvarchar(50) not null,
                         NgaySinh nvarchar(30) not null,
                         DiaChi nvarchar(50) not null,
                         SDT char(20)
)
    go
create table Lop(
                    MaLop int identity(1000,1) primary key ,
                    TenLop nvarchar(20),
                    Khoi int,
                    MaGV int
)
    go
create table HocSinh(
                        MaHS int identity (10000,1) primary key ,
                        HoTen nvarchar(50) not null ,
                        NgaySinh nvarchar(50),
                        DiaChi nvarchar(50),
                        SDTLienLac char(20),
                        MaLop int not null
)
    go
create table Diem(
                     MaDiem int identity (1000,1) primary key,
                     MaHS int not null,
                     DiemToan float constraint fk_diemtoan check(DiemToan>=0 and DiemToan<=10),
                     DiemTV float constraint fk_diemtv check(DiemTV >=0 and DiemTV <=10),
                     HocKi int,
                     NamHoc int
)
    go