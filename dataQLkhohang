CREATE DATABASE QuanLyKhoHang
GO
USE QuanLyKhoHang
GO
--Tài Khoản
--Hàng Tồn
--Phiếu Xuất
--Phiếu Nhập
--Danh Mục Nhà Cung Cấp

--Tạo Bảng Tài Khoản
CREATE TABLE TaiKhoan
(
	idLogin NVARCHAR(50) NOT NULL PRIMARY KEY,
	TenHienThi NVARCHAR(50) NOT NULL,
	Pass NVARCHAR(50) NOT NULL,
	LoaiTK INT NOT NULL  -- 1:admin && 0: staff
)
GO
--Tạo Bảng Hàng Tồn
CREATE TABLE HangTon
(
	Idhang CHAR(10),
	Tenhang CHAR(30) NOT NULL,
	Dvt CHAR(5) NOT NULL,
	SoLuong NCHAR(4) NOT NULL,
	Gianhap NCHAR(4) NOT NULL,
	Giaxuat NCHAR(4) NOT NULL,
	CONSTRAINT PK_hangton
	PRIMARY KEY (Idhang)
)
GO
--Tạo Bảng Phiếu Xuất
CREATE TABLE PhieuXuat
(
	Idphieux CHAR(10),
	Idhang CHAR(10),
	Tenhang CHAR(30) NOT NULL,
	Dvt CHAR(5) NOT NULL,
	Luongxuat NCHAR(2) NOT NULL,
	Giaxuat NCHAR(3) NOT NULL,
	ThanhTien NCHAR(6) NOT NULL,
	CONSTRAINT PK_phieuxuat
	PRIMARY KEY (Idphieux, Idhang)
)
GO
--Tạo Bảng Phiếu Nhập
CREATE TABLE PhieuNhap
(
	Idphieun CHAR(10),
	Idhang CHAR(10),
	Idncc CHAR(10),
	Tenhang CHAR(30) NOT NULL,
	Dvt CHAR(5) NOT NULL,
	Luongnhap NCHAR(3) NOT NULL,
	Gianhap NCHAR(3) NOT NULL,
	ThanhTien NCHAR(9) NOT NULL,
	CONSTRAINT PK_phieunhap
	PRIMARY KEY (Idphieun, Idhang)
)
GO
-- Tạo Bảng Danh Mục Nhà Cung Cấp
CREATE TABLE NCC
(
	Idncc CHAR(10),
	Tenncc CHAR(30) NOT NULL,
	Diachi CHAR(50) NOT NULL,
	Sdt CHAR(10) NOT NULL,
	CONSTRAINT PK_NCC
	PRIMARY KEY (Idncc)
)
GO

-- Tạo Khóa Ngoại và Ràng Buộc
ALTER TABLE dbo.PhieuXuat
ADD CONSTRAINT FK_phieux_hangton
FOREIGN KEY (Idhang)
REFERENCES dbo.HangTon(Idhang)

ALTER TABLE dbo.PhieuNhap
ADD CONSTRAINT FK_phieun_hangton
FOREIGN KEY (Idhang)
REFERENCES dbo.HangTon(Idhang)

ALTER TABLE dbo.PhieuNhap
ADD CONSTRAINT FK_phieun_ncc
FOREIGN KEY (Idncc)
REFERENCES dbo.NCC(Idncc)

GO

-- Nhập Data Cho Các Bảng
-- Nhập Data Bảng Tài Khoản
INSERT INTO dbo.TaiKhoan
        ( idLogin, TenHienThi, Pass, LoaiTK )
VALUES  ( N'admin', -- idLogin - nvarchar(50)
          N'Nguyễn Văn Trọng', -- TenHienThi - nvarchar(50)
          N'1', -- Pass - nvarchar(50)
          1  -- LoaiTK - int
          )
INSERT INTO dbo.TaiKhoan
        ( idLogin, TenHienThi, Pass, LoaiTK )
VALUES  ( N'thanhvien', -- idLogin - nvarchar(50)
          N'Ngọc Kiệt', -- TenHienThi - nvarchar(50)
          N'123456', -- Pass - nvarchar(50)
          0  -- LoaiTK - int
          )
          
SELECT * FROM dbo.TaiKhoan

GO
SELECT * FROM dbo.TaiKhoan WHERE idLogin = N'admin' AND Pass = N'1'
GO

-- Nhập Data bảng Phiếu Xuất

-- Nhập Data bảng Hàng Tồn
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('001', 'Sam Sung A5','VND','01',N'1000',N'2000')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('002', 'Sam Sung A5','VND','01',N'1000',N'2000')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('003', 'Sam Sung A5','VND','01',N'5000',N'6000')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('004', 'Sam Sung A5','VND','01',N'4000',N'7000')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('005', 'Sam Sung A5','VND','01',N'2000',N'4000')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('006', 'Sam Sung A5','VND','01',N'2000',N'5000')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('007', 'Sam Sung A5','VND','01',N'5000',N'8000')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('008', 'Sam Sung A5','VND','01',N'5000',N'6000')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('009', 'Sam Sung A5','VND','01',N'3000',N'6000')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('010', 'Galaxy S8','VND','01',N'8000',N'9000')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('011', 'LG G3','VND','01',N'400',N'600')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('012', 'Sony XA','VND','01',N'5',N'6')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('013', 'Xiaomi RedMi 4','VND','01',N'50',N'60')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('014', 'OPPO F1s','VND','01',N'500',N'600')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('015', 'LG G5','VND','01',N'500',N'600')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('016', 'Sony Z5','VND','01',N'500',N'600')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('017', 'Sony Z2','VND','01',N'500',N'600')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('018', 'Sam Sung A9','VND','01',N'500',N'600')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('019', 'Sam Sung A7','VND','01',N'546',N'678')
INSERT INTO HangTon (Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat)
VALUES('020', 'Iphone 6','VND','01',N'500',N'600')

GO
-- Nhập Data Bảng NCC
INSERT INTO NCC (Idncc, Tenncc, Diachi, Sdt)
VALUES ('001','Sam Sung','Ha Noi','1234922723')
INSERT INTO NCC (Idncc, Tenncc, Diachi, Sdt)
VALUES ('002','LG','Ha Noi','1234922723')
INSERT INTO NCC (Idncc, Tenncc, Diachi, Sdt)
VALUES ('003','Sony','Ha Noi','1234922723')
INSERT INTO NCC (Idncc, Tenncc, Diachi, Sdt)
VALUES ('004','Oppo','Ha Noi','1234922723')
INSERT INTO NCC (Idncc, Tenncc, Diachi, Sdt)
VALUES ('005','Apple','Ha Noi','1234922723')
GO
-- Nhập data Bảng Phiếu Xuất
INSERT INTO PhieuXuat (Idphieux, Idhang, Tenhang, Dvt, Luongxuat, Giaxuat, ThanhTien)
VALUES('001','001','Sam Sung A5','VND','01','200','2000')
INSERT INTO PhieuXuat (Idphieux, Idhang, Tenhang, Dvt, Luongxuat, Giaxuat, ThanhTien)
VALUES('002','002','LG G5','VND','01','300','3000')
INSERT INTO PhieuXuat (Idphieux, Idhang, Tenhang, Dvt, Luongxuat, Giaxuat, ThanhTien)
VALUES('003','003','Sony Z3','VND','01','400','4000')

GO

-- Nhập Data Bảng Phiếu Nhập
INSERT INTO PhieuNhap (Idphieun, Idhang, Idncc, Tenhang, Dvt, Luongnhap, Gianhap, ThanhTien)
VALUES('001','001','001','Sam Sung A5','VND','01','100','1000')
INSERT INTO PhieuNhap (Idphieun, Idhang, Idncc, Tenhang, Dvt, Luongnhap, Gianhap, ThanhTien)
VALUES('002','002','002','LG G5','VND','01','200','2000')
INSERT INTO PhieuNhap (Idphieun, Idhang, Idncc, Tenhang, Dvt, Luongnhap, Gianhap, ThanhTien)
VALUES('003','003','003','Sony Z3','VND','01','300','3000')

GO
select * from HangTon
