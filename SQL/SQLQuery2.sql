CREATE DATABASE QuanLyTruongDaiHoc;

USE QuanLyTruongDaiHoc;
GO
CREATE TABLE GiaoVien 
(
MaGV INT IDENTITY (1,1) PRIMARY KEY,
HoTenGV NVARCHAR(20),
GioiTinh VARCHAR(4),
NgaySinh DATE,
KhoaID INT,
);

CREATE TABLE SinhVien
(
MaSV INT IDENTITY (100,1) PRIMARY KEY,
HoTenSV NVARCHAR(20),
GioiTinh VARCHAR(4),
NgaySinh DATE,
MaGV_MH INT,
KhoaID INT,
NganhID INT,
LopID INT
);

CREATE TABLE Khoa
(
KhoaID INT IDENTITY (1,1) PRIMARY KEY,
TenKhoa NVARCHAR(20),
MaGV INT
);

CREATE TABLE Nganh
(
NganhID INT IDENTITY (1,1) PRIMARY KEY,
TenNganh NVARCHAR(20),
KhoaID INT
);

CREATE TABLE Lop
(
LopID INT IDENTITY (1,1) PRIMARY KEY,
TenLop NVARCHAR(20),
NganhID INT
);

CREATE TABLE MonHoc
(
MonHocID INT IDENTITY (1,1) PRIMARY KEY,
TenMonHoc NVARCHAR(20),
KhoaID INT,
NganhID INT
);

CREATE TABLE GiaoVien_MonHoc
(
MaGV_MH INT IDENTITY (1,1) PRIMARY KEY,
MaGV INT,
MonHocID INT
);
