﻿CREATE DATABASE QLXEMAY
GO
USE QLXEMAY
GO

CREATE TABLE NHACC
(
	MANCC CHAR(5) NOT NULL PRIMARY KEY,
	TENNCC NVARCHAR(50),
	DIACHI NVARCHAR(50),
	SDT CHAR(11)
)
GO

CREATE TABLE DSXE
(
	MAXE CHAR(5) NOT NULL PRIMARY KEY,
	TENXE NVARCHAR(50),
	LOAIXE NVARCHAR(20),
	MAUXE NVARCHAR(20),
	NAMSANXUAT INT,
	GIATIEN FLOAT,
	MANCC CHAR(5),
	CONSTRAINT FK_MANCC_DSXE FOREIGN KEY (MANCC) REFERENCES NHACC(MANCC)
)
GO

CREATE TABLE KHO
(
	MAXE CHAR(5),
	NGAYNHAP DATE,
	SOLUONG INT,
	TINHTRANGXE NVARCHAR(20),
	CONSTRAINT FK_MAXE_KHO FOREIGN KEY (MAXE) REFERENCES DSXE(MAXE)
)
GO

CREATE TABLE NHANVIEN
(
	MANV CHAR(5) NOT NULL PRIMARY KEY,
	TENNV NVARCHAR(50),
	GIOITINH NVARCHAR(5),
	DIACHI NVARCHAR(50),
	CMND CHAR(14),
	SDT CHAR(11),
	CHUCVU NVARCHAR(20),
	NGAYSINH CHAR(15)
)
GO

CREATE TABLE KHACHHANG
(
	MAKH CHAR(5) NOT NULL PRIMARY KEY,
	TENKH NVARCHAR(50),
	DIACHI NVARCHAR(50),
	GIOITINH NVARCHAR(5),
	SDT CHAR(11),
	GHICHU NVARCHAR(100)
)
GO

CREATE TABLE HOADON
(
	MAHD CHAR(5) NOT NULL,
	MAKH CHAR(5) NOT NULL,
	MANV CHAR(5) NOT NULL,
	MAXE CHAR(5) NOT NULL,
	SOLUONG INT,
	GIATIEN int,
	THUEGTGT float,
	TONGTIEN int,
	CONSTRAINT PK_HOADON PRIMARY KEY(MAHD),
	CONSTRAINT FK_MANV_HOADON FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV),
	CONSTRAINT FK_MAKH_HOADON FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
	CONSTRAINT FK_MAXE_HOADON FOREIGN KEY (MAXE) REFERENCES DSXE(MAXE)
)
GO
CREATE TABLE CHITIETHOADON
(
	MAHD CHAR(5),
	TENKH NVARCHAR(30),
	NGAYNHAP char(10),
	GIATIEN Char(20),
	CONSTRAINT PK_CHITIETHOADON PRIMARY KEY (MAHD)
)
GO

SET DATEFORMAT DMY
INSERT INTO NHACC VALUES ('CC001','YAMAHA',N'12/10 NGUYỄN THỊ MINH KHAI','0779871234'),
('CC002','HONDA',N'12/15/22 LÝ THÁI TỔ','0779871234'),
('CC003','VINFAST',N'120 NGUYỄN THÁI SƠN','0779871234')
GO

INSERT INTO DSXE VALUES ('X001','WAVE RSX FI 110',N'XE SỐ',N'MÀU ĐEN',2019,21000000,'CC001'),
('X002','JANUS',N'XE TAY GA',N'MÀU XÁM',2017,28000000,'CC002'),
('X003','SIRIUS',N'XE SỐ',N'MÀU ĐEN',2019,18800000,'CC002'),
('X004','EVO200',N'XE ĐIỆN',N'MÀU TRẮNG',2021,22000000,'CC003'),
('X005','VISION',N'XE TAY GA',N'MÀU ĐỎ',2019,30710000,'CC001')
GO

INSERT INTO KHO VALUES ('X001','12/10/2020',10,N'MỚI'),
('X002','12/01/2018',15,N'MỚI'),
('X003','21/02/2020',5,N'MỚI'),
('X004','25/03/2022',30,N'MỚI'),
('X005','03/11/2020',15,N'MỚI')
GO

INSERT INTO NHANVIEN VALUES ('NV001',N'CAO VĂN HÀ',N'NAM',N'HỒ CHÍ MINH','213654879345','0256899155',N'TƯ VẤN','13/02/1990'),
('NV002',N'NGUYỄN VĂN HÀ',N'NAM',N'ĐỒNG NAI','567234987123','0770987443',N'KẾ TOÁN','20/08/1992'),
('NV003',N'CAO THỊ LAN',N'NỮ',N'TIỀN GIANG','023156984245','0981234568',N'TƯ VẤN','30/09/1988'),
('NV004',N'TRẦN VĂN AN',N'NAM',N'BẾN TRE','789552664999','0985664545',N'QUẢN LÍ','01/01/1977'),
('NV005',N'NGUYỄN THÙY TRANG',N'NỮ',N'HỒ CHÍ MINH','899666521466','0984226331',N'KÊ TOÁN','15/10/1995')
GO

INSERT INTO KHACHHANG(MAKH,TENKH,DIACHI,GIOITINH,SDT) VALUES ('KH001',N'TRẦN MINH TUẤN',N'03 QUANG TRUNG',N'NAM','0987659876')
INSERT INTO KHACHHANG(MAKH,TENKH,DIACHI,GIOITINH,SDT) VALUES('KH002',N'TRẦN VĂN KIỆT',N'112 PHAN VĂN TRỊ',N'NAM','0981237654')
INSERT INTO KHACHHANG(MAKH,TENKH,DIACHI,GIOITINH,SDT) VALUES('KH003',N'BÙI VĂN CÔNG',N'15 TRƯỜNG CHINH',N'NAM','0984321987')
INSERT INTO KHACHHANG(MAKH,TENKH,DIACHI,GIOITINH,SDT) VALUES('KH004',N'NGUYỄN THÁI BÌNH',N'09 LÊ HỒNG PHONG',N'NAM','0985678123')
INSERT INTO KHACHHANG(MAKH,TENKH,DIACHI,GIOITINH,SDT) VALUES('KH005',N'LÊ THỊ HÀ',N'114/16 NGUYỄN KIỆM',N'NỮ','0770982345')
GO

INSERT INTO HOADON VALUES ('HD001','KH005','NV004','X002',1,28000000,0.1,30800000),
('HD002','KH005','NV004','X003',1,18800000,0.1,20680000),
('HD003','KH002','NV003','X003',1,18800000,0.1,20680000),
('HD004','KH001','NV003','X001',1,21000000,0.1,23100000),
('HD005','KH003','NV001','X005',1,30710000,0.1,33781000)
GO