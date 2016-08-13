use master
go
if DB_ID('QUAN_LY_CUA_HANG')is not null
	drop database QUAN_LY_CUA_HANG
go
create database QUAN_LY_CUA_HANG
go
use QUAN_LY_CUA_HANG
go

create table SANPHAM
(		
		maSP varchar(12),
		tenSP NVARCHAR(40),
		soLuong int,
		giaBan float,
		giaNhap float,
		nhaSX NVARCHAR(40)
		constraint pk_SANPHAM
		PRIMARY KEY(maSP)
)

GO

create table NHANVIEN
(		
		maNV char(7),
		hoTen NVARCHAR(40),
		tenDangNhap NVARCHAR(40),
		matKhau NVARCHAR(40),
		loaiNV NVARCHAR(15),
		diaChi NVARCHAR(40),
		dienThoai CHAR(12),
		moTa NVARCHAR(40),

		CONSTRAINT ck_loaiNV
		CHECK (loaiNV in(N'Bán Hàng',N'Quản Lý Kho',N'Admin')),
		CONSTRAINT pk_NHANVIEN
		PRIMARY KEY(maNV)
)

GO

create table HOADON
(		
		maHD char(12),
		maNV char(7),
		ngayLap datetime

		constraint pk_HOADON
		PRIMARY KEY(maHD)
)
GO
create table CT_HOADON
(		
		maHD char(12),
		maSP varchar(12),
		soLuong int

		constraint pk_CTHOADON
		PRIMARY KEY(maHD,maSP)
)


GO

ALTER TABLE HOADON
ADD
CONSTRAINT FK_HOADON_NHANVIEN
FOREIGN KEY (maNV)
REFERENCES NHANVIEN(maNV)

GO

ALTER TABLE CT_HOADON
ADD
CONSTRAINT FK_CT_HOADON_SANPHAM
FOREIGN KEY (maSP)
REFERENCES SANPHAM(maSP),
CONSTRAINT FK_CT_HOADON_HOADON
FOREIGN KEY (maHD)
REFERENCES HOADON(maHD)

GO


INSERT SANPHAM
		VALUES('D123',N'ĐÂU ĂN',5,10000,9000,N'VIỆT NAM'),
				('N523',N'Nươc rửa chén',45,15000,9500,N'VIỆT NAM'),
				('X541',N'Xà phòng',12,5000,4500,N'VIỆT NAM'),
				('S245',N'Sữa chua',12,55000,45500,N'VIỆT NAM')
INSERT NHANVIEN
		VALUES('CH00001',N'NGUYỄN VĂN THANH TÚ',N'TUDOI',N'123',N'Bán Hàng',N'NGUYỄN VĂN CỪ','0123456789',N'VKL'),
			('NK00001',N'NGUYỄN VĂN A',N'1234',N'1234',N'Quản Lý Kho',N'NGUYỄN VĂN CỪ','0123456789',N'VKL')
INSERT HOADON
		VALUES('777','CH00001','3/2/2012'),
			('888','CH00001','9/5/2016'),
			('999','NK00001','2/2/2012')
INSERT CT_HOADON
		VALUES('777','D123',5),
				('777','N523',2),
				('888','S245',1),
				('999','N523',3),
				('999','X541',2),
				('999','S245',2)

				
SELECT * FROM SANPHAM		
SELECT * FROM NHANVIEN
SELECT * FROM HOADON
SELECT * FROM CT_HOADON
SELECT MAX(MAHD) FROM HOADON

INSERT HOADON VALUES('1000','CH00001','11/08/2016')
DELETE from HOADON where maHD='1000'