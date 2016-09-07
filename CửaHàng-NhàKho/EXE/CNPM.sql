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
		tenSP NVARCHAR(40) NOT NULL,
		soLuong INT NOT NULL,
		giaBan FLOAT NOT NULL,
		giaNhap FLOAT NOT NULL,
		nhaSX NVARCHAR(40),
		tinhTrang int NOT NULL
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
		loaiNV NVARCHAR(15) NOT NULL,
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
		ngayLap datetime,
		tongTien float

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
		VALUES('D123',N'ĐÂU ĂN',5,10000,9000,N'VIỆT NAM',1),
				('N523',N'Nươc rửa chén',45,15000,9500,N'VIỆT NAM',1),
				('X541',N'Xà phòng',12,5000,4500,N'VIỆT NAM',1),
				('S245',N'Sữa chua',12,55000,45500,N'VIỆT NAM',1)
INSERT NHANVIEN
		VALUES('CH00001',N'NGUYỄN VĂN THANH TÚ',N'TUDOI',N'123',N'Bán Hàng',N'NGUYỄN VĂN CỪ','0123456789',N'VKL'),
			('NK00001',N'NGUYỄN VĂN A',N'1234',N'1234',N'Quản Lý Kho',N'NGUYỄN VĂN CỪ','0123456789',N'VKL')
INSERT HOADON
		VALUES('145','CH00001','3/2/2012',30000),
			('200','CH00001','9/5/2016',30000),
			('222','NK00001','2/2/2012',30000)
INSERT CT_HOADON
		VALUES('145','D123',5),
				('200','N523',2),
				('222','S245',1),
				('222','N523',3),
				('200','X541',2),
				('200','S245',2)
	go
	------------------------------------------------------------
IF OBJECTPROPERTY(object_id('dbo.themSP'), N'IsProcedure') = 1
	DROP PROCEDURE [dbo].[themSP]
	go		
create procedure themSP(@masp varchar(12),
	@tensp nvarchar(40), 
	@soluong int, 
	@giaban float,
	@gianhap float, 
	@nhasx nvarchar(40), 
	@tinhtrang int)
	as
	begin
	INSERT SANPHAM
		VALUES(@masp,@tensp,@soluong,@giaban,@gianhap,@nhasx,@tinhtrang)
	end
	go
	------------------------------------------------------------
IF OBJECTPROPERTY(object_id('dbo.themHD'), N'IsProcedure') = 1
	DROP PROCEDURE [dbo].[themHD]
	go
create procedure themHD(
	@mahd char(12), 
	@manv char(7),
	@ngaylap datetime,
	@tongtien float)
	as
	begin
	INSERT HOADON
		VALUES(@mahd,@manv,@ngaylap,@tongtien)
	end
	go

	-------------------------------------------------------
IF OBJECTPROPERTY(object_id('dbo.themCTHD'), N'IsProcedure') = 1
	DROP PROCEDURE [dbo].[themCTHD]
	go
create procedure themCTHD(
	@mahd char(12), 
	@masp varchar(12),
	@soluong int)
	as
	begin
	INSERT CT_HOADON
		VALUES(@mahd,@masp,@soluong)
	update SANPHAM set soLuong-=@soluong  where maSP=@masp

	end
	go

IF OBJECTPROPERTY(object_id('dbo.cnsp'), N'IsProcedure') = 1
	DROP PROCEDURE [dbo].[cnsp]
	go
create procedure cnsp(
	@masp varchar(12),
	@tensp nvarchar(40), 
	@soluong int,
	@giaban float,
	@gianhap float
	)
	as
	begin

	update SANPHAM set soLuong=@soluong, tenSP=@tensp, giaBan=@giaban, giaNhap=@gianhap where maSP=@masp

	end
	go


SELECT * FROM SANPHAM		
SELECT * FROM NHANVIEN
SELECT * FROM HOADON
SELECT * FROM CT_HOADON
SELECT MAX(MAHD) FROM HOADON

INSERT HOADON VALUES('1000','CH00001','11/08/2016',30000)
UPDATE SANPHAM SET tinhtrang=1 WHERE MASP='S245'
SELECT MAX(MAHD) as prevMAHD FROM HOADON

SELECT * FROM SANPHAM WHERE maSP='D5124'
update SANPHAM set soLuong+=5 where maSP='D123'
select * from SANPHAM

