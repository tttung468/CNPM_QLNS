
CREATE DATABASE QUAN_LY_NHA_SACH
GO
USE QUAN_LY_NHA_SACH
GO

CREATE TABLE PhieuThu
(
	MaPhieuThu int identity,
	NgayThuTien date,
	SoTienThu money,
	PRIMARY KEY(MaPhieuThu)
)
GO

CREATE TABLE KhachHang
(
	MaKhachHang int identity,
	HoTen varchar(255),
	DiaChi varchar(255),
	DienThoai varchar(10) UNIQUE,
	SoTienNoDau money DEFAULT 0,
	SoTienNoCuoi money DEFAULT 0,
	PRIMARY KEY(MaKhachHang)
)
GO

CREATE TABLE HoaDon
(
	MaHoaDon int identity,
	NgayLapHD date,
	MaPhieuThu int,
	MaKhachHang int,
	PRIMARY KEY(MaHoaDon)
)
GO

CREATE TABLE TheLoai
(
	MaTheLoai int identity,
	TenTheLoai varchar(255) UNIQUE,
	PRIMARY KEY(MaTheLoai)
)
GO

CREATE TABLE Sach
(
	MaSach int identity,
	TenSach varchar(255),
	MaTheLoai int,
	TacGia varchar(255),
	SoLuongTonDau int,
	SoLuongTonCuoi int,
	DonGia money,
	PRIMARY KEY(MaSach)
)
GO

CREATE TABLE ChiTietHoaDon
(
	MaHoaDon int,
	MaSach int,
	SoLuongMua int
	PRIMARY KEY(MaHoaDon,MaSach)
)
GO

CREATE TABLE PhieuNhap
(
	MaPhieuNhap int identity,
	NgayNhap date,
	PRIMARY KEY(MaPhieuNhap)
)
GO

CREATE TABLE ChiTietPhieuNhap
(
	MaPhieuNhap int,
	MaSach int,
	SoLuongNhap int
	PRIMARY KEY(MaPhieuNhap,MaSach)
)
GO

CREATE TABLE QuyDinh
(
	MaQuyDinh int identity,
	TenQuyDinh varchar(255),
	GiaTri int,
	PRIMARY KEY(MaQuyDinh)
)
GO

/*Tao khoa ngoai cho bang Sach*/
ALTER TABLE Sach ADD CONSTRAINT FK_Sach_TheLoai FOREIGN KEY(MaTheLoai) REFERENCES TheLoai(MaTheLoai)

/*Tao khoa ngoai cho bang HoaDon*/
ALTER TABLE HoaDon ADD CONSTRAINT FK_HoaDon_PhieuThu FOREIGN KEY(MaPhieuThu) REFERENCES PhieuThu(MaPhieuThu)
ALTER TABLE HoaDon ADD CONSTRAINT FK_HoaDon_KhachHang FOREIGN KEY(MaKhachHang) REFERENCES KhachHang(MaKhachHang)
 
/*Tao khoa ngoai cho bang ChiTietHoaDon*/
ALTER TABLE ChiTietHoaDon ADD CONSTRAINT FK_ChiTietHoaDon_HoaDon FOREIGN KEY(MaHoaDon) REFERENCES HoaDon(MaHoaDon)
ALTER TABLE ChiTietHoaDon ADD CONSTRAINT FK_ChiTietHoaDon_Sach FOREIGN KEY(MaSach) REFERENCES Sach(MaSach)

/*Tao khoa ngoai cho bang ChiTietPhieuNhap*/
ALTER TABLE ChiTietPhieuNhap ADD CONSTRAINT FK_ChiTietPhieuNhap_PhieuNhap FOREIGN KEY(MaPhieuNhap) REFERENCES PhieuNhap(MaPhieuNhap)
ALTER TABLE ChiTietPhieuNhap ADD CONSTRAINT FK_ChiTietPhieuNhap_Sach FOREIGN KEY(MaSach) REFERENCES Sach(MaSach)




 /*Nhap du lieu cho bang Phieu Thu*/
 INSERT INTO PhieuThu (NgayThuTien, SoTienThu)
 VALUES('2020-07-14', 15000)
 INSERT INTO PhieuThu (NgayThuTien, SoTienThu)
 VALUES('2020-07-14', 20000)
 INSERT INTO PhieuThu (NgayThuTien, SoTienThu)
 VALUES('2020-07-14', 24000)
 INSERT INTO PhieuThu (NgayThuTien, SoTienThu)
 VALUES('2020-07-15', 25000)
 INSERT INTO PhieuThu (NgayThuTien, SoTienThu)
 VALUES('2020-07-15', 30000)
  INSERT INTO PhieuThu (NgayThuTien, SoTienThu)
 VALUES('2020-07-15', 14000)
  INSERT INTO PhieuThu (NgayThuTien, SoTienThu)
 VALUES('2020-07-16', 30000)
 INSERT INTO PhieuThu (NgayThuTien, SoTienThu)
 VALUES('2020-07-16', 50000)
 INSERT INTO PhieuThu (NgayThuTien, SoTienThu)
 VALUES('2020-07-16', 100000)
 INSERT INTO PhieuThu (NgayThuTien, SoTienThu)
 VALUES('2020-07-16', 25000)

 /*Nhap du lieu cho bang KhachHang*/
 INSERT INTO KhachHang(HoTen,DiaChi,DienThoai,SoTienNoDau,SoTienNoCuoi)
 VALUES('Nguyen Chi Cuong', '142 Pham Van Dong quan Thu Duc', '0321562141',0,0)
 INSERT INTO KhachHang(HoTen,DiaChi,DienThoai,SoTienNoDau,SoTienNoCuoi)
 VALUES('Huynh Nhat Duong', '242 Pham Van Dong quan Thu Duc', '0321232581',0,0)
 INSERT INTO KhachHang(HoTen,DiaChi,DienThoai,SoTienNoDau,SoTienNoCuoi)
 VALUES('Thai Thanh Tung', '512 Dien Bien Phu quan Binh Thanh', '0329562163',0,0)
 INSERT INTO KhachHang(HoTen,DiaChi,DienThoai,SoTienNoDau,SoTienNoCuoi)
 VALUES('Tran Dinh Sang', '238 Nguyen Van Cu quan 5', '0321563145',0,0)
 INSERT INTO KhachHang(HoTen,DiaChi,DienThoai,SoTienNoDau,SoTienNoCuoi)
 VALUES('Nguyen Van An', '512 Vo Thi Sau quan 1', '0321564159',0,0)
 INSERT INTO KhachHang(HoTen,DiaChi,DienThoai,SoTienNoDau,SoTienNoCuoi)
 VALUES('Le Thi Anh', '123 Vo Van Tan quan 3', '0321124638',2000,2000)
 INSERT INTO KhachHang(HoTen,DiaChi,DienThoai,SoTienNoDau,SoTienNoCuoi)
 VALUES('Cao Van Vu', '421 Nguyen Tat Thanh quan 4', '0324156284',50000,50000)
 INSERT INTO KhachHang(HoTen,DiaChi,DienThoai,SoTienNoDau,SoTienNoCuoi)
 VALUES('Nguyen Thi Nguyet', '132 Nguyen Van Cu quan 5', '0356482103',5000,5000)
 INSERT INTO KhachHang(HoTen,DiaChi,DienThoai,SoTienNoDau,SoTienNoCuoi)
 VALUES('Doan Van An', '422 Thanh Thai quan 10 ','0378412035',3000,3000)
 INSERT INTO KhachHang(HoTen,DiaChi,DienThoai,SoTienNoDau,SoTienNoCuoi)
 VALUES('Tran Minh Quan', '132 Pham Ngoc Thach quan 3', '0354301579',30000,30000)

   /*Nhap du lieu cho bang TheLoai*/
 INSERT INTO TheLoai(TenTheLoai)
 VALUES('Hai huoc')
  INSERT INTO TheLoai(TenTheLoai)
 VALUES('Trinh tham')
  INSERT INTO TheLoai(TenTheLoai)
 VALUES('Tieu thuyet')
  INSERT INTO TheLoai(TenTheLoai)
 VALUES('Vo thuat')
  INSERT INTO TheLoai(TenTheLoai)
 VALUES('Sach tu luc')
  INSERT INTO TheLoai(TenTheLoai)
 VALUES('Tam ly - ky nang song')
  INSERT INTO TheLoai(TenTheLoai)
 VALUES('Giao trinh')
  INSERT INTO TheLoai(TenTheLoai)
 VALUES('Van hoc nghe thuat')
  INSERT INTO TheLoai(TenTheLoai)
 VALUES('Khoa hoc cong nghe')
  INSERT INTO TheLoai(TenTheLoai)
 VALUES('Van hoa xa hoi')

  /*Nhap du lieu cho bang Sach*/
 INSERT INTO Sach(TenSach,MaTheLoai, TacGia, SoLuongTonDau,SoLuongTonCuoi, DonGia)
 VALUES('Doraemon', 1, 'Fujio',24,24, 18000)
 INSERT INTO Sach(TenSach,MaTheLoai, TacGia, SoLuongTonDau,SoLuongTonCuoi, DonGia)
 VALUES('Conam', 2, 'Goshu',38,38, 24000)
 INSERT INTO Sach(TenSach,MaTheLoai, TacGia, SoLuongTonDau,SoLuongTonCuoi, DonGia)
 VALUES('One Piece', 3, 'Oda',42,42, 20000)
 INSERT INTO Sach(TenSach,MaTheLoai, TacGia, SoLuongTonDau,SoLuongTonCuoi, DonGia)
 VALUES('Dragon ball', 4, 'Toriyama',14,14, 25000)
 INSERT INTO Sach(TenSach,MaTheLoai, TacGia, SoLuongTonDau,SoLuongTonCuoi, DonGia)
 VALUES('Naruto', 3, 'Kishimoto',20,20, 19000)
 INSERT INTO Sach(TenSach,MaTheLoai, TacGia, SoLuongTonDau,SoLuongTonCuoi, DonGia)
 VALUES('Dac nhan tam', 5, 'Dale Carnegie',24,24, 56000)
 INSERT INTO Sach(TenSach,MaTheLoai, TacGia, SoLuongTonDau,SoLuongTonCuoi, DonGia)
 VALUES('Tuoi tre dang gia bao nhieu', 6, 'Rosie Nguyen',15,15, 40000)
 INSERT INTO Sach(TenSach,MaTheLoai, TacGia, SoLuongTonDau,SoLuongTonCuoi, DonGia)
 VALUES('Trang Quynh', 1, 'Kim Khanh',28,28, 50000)
 INSERT INTO Sach(TenSach,MaTheLoai, TacGia, SoLuongTonDau,SoLuongTonCuoi, DonGia)
 VALUES('Than dong dat Viet', 1, 'Le Linh',30,30, 30000)
 INSERT INTO Sach(TenSach,MaTheLoai, TacGia, SoLuongTonDau,SoLuongTonCuoi, DonGia)
 VALUES('Tokyo Ghoul', 3, 'Sui Ishida',5,5, 20000)

  /*Nhap du lieu cho bang PhieuNhap*/
 INSERT INTO PhieuNhap(NgayNhap)
 VALUES('2020-05-20')
  INSERT INTO PhieuNhap(NgayNhap)
 VALUES('2020-05-21')
  INSERT INTO PhieuNhap(NgayNhap)
 VALUES('2020-05-22')
  INSERT INTO PhieuNhap(NgayNhap)
 VALUES('2020-05-23')
  INSERT INTO PhieuNhap(NgayNhap)
 VALUES('2020-05-24')
  INSERT INTO PhieuNhap(NgayNhap)
 VALUES('2020-05-25')
  INSERT INTO PhieuNhap(NgayNhap)
 VALUES('2020-05-26')
  INSERT INTO PhieuNhap(NgayNhap)
 VALUES('2020-05-27')
  INSERT INTO PhieuNhap(NgayNhap)
 VALUES('2020-05-28')
  INSERT INTO PhieuNhap(NgayNhap)
 VALUES('2020-05-29')

 /*Nhap du lieu cho bang HoaDon*/
 INSERT INTO HoaDon(NgayLapHD, MaPhieuThu, MaKhachHang)
 VALUES('2020-07-15', 2, 6)
  INSERT INTO HoaDon(NgayLapHD, MaPhieuThu, MaKhachHang)
 VALUES('2020-07-16', 5, 2)
  INSERT INTO HoaDon(NgayLapHD, MaPhieuThu, MaKhachHang)
 VALUES('2020-07-17', 6, 3)
  INSERT INTO HoaDon(NgayLapHD, MaPhieuThu, MaKhachHang)
 VALUES('2020-07-18', 4, 4)
  INSERT INTO HoaDon(NgayLapHD, MaPhieuThu, MaKhachHang)
 VALUES('2020-07-19', 3, 7)
 INSERT INTO HoaDon(NgayLapHD, MaPhieuThu, MaKhachHang)
 VALUES('2020-07-20', 9, 4)
  INSERT INTO HoaDon(NgayLapHD, MaPhieuThu, MaKhachHang)
 VALUES('2020-07-21', 7, 3)
  INSERT INTO HoaDon(NgayLapHD, MaPhieuThu, MaKhachHang)
 VALUES('2020-07-22', 10, 8)
  INSERT INTO HoaDon(NgayLapHD, MaPhieuThu, MaKhachHang)
 VALUES('2020-07-23', 1, 6)
  INSERT INTO HoaDon(NgayLapHD, MaPhieuThu, MaKhachHang)
 VALUES('2020-07-24', 4, 9)

  /*Nhap du lieu cho bang ChiTietHoaDon*/
 INSERT INTO ChiTietHoaDon(MaHoaDon, MaSach, SoLuongMua)
 VALUES(1, 5, 5)
  INSERT INTO ChiTietHoaDon(MaHoaDon, MaSach, SoLuongMua)
 VALUES(2, 3, 20)
  INSERT INTO ChiTietHoaDon(MaHoaDon, MaSach, SoLuongMua)
 VALUES(3, 4, 6)
  INSERT INTO ChiTietHoaDon(MaHoaDon, MaSach, SoLuongMua)
 VALUES(4, 5, 7)
  INSERT INTO ChiTietHoaDon(MaHoaDon, MaSach, SoLuongMua)
 VALUES(5, 1, 5)
INSERT INTO ChiTietHoaDon(MaHoaDon, MaSach, SoLuongMua)
 VALUES(6, 2, 1)
  INSERT INTO ChiTietHoaDon(MaHoaDon, MaSach, SoLuongMua)
 VALUES(7, 8, 4)
  INSERT INTO ChiTietHoaDon(MaHoaDon, MaSach, SoLuongMua)
 VALUES(8, 4, 4)
  INSERT INTO ChiTietHoaDon(MaHoaDon, MaSach, SoLuongMua)
 VALUES(9, 5, 2)
  INSERT INTO ChiTietHoaDon(MaHoaDon, MaSach, SoLuongMua)
 VALUES(10, 9, 4)
  
  /*Nhap du lieu cho bang ChiTietPhieuNhap*/
 INSERT INTO ChiTietPhieuNhap(MaSach, MaPhieuNhap,SoLuongNhap)
 VALUES(2, 1, 3)
   INSERT INTO ChiTietPhieuNhap(MaSach, MaPhieuNhap,SoLuongNhap)
 VALUES(5, 2, 5)
   INSERT INTO ChiTietPhieuNhap(MaSach, MaPhieuNhap,SoLuongNhap)
 VALUES(3, 3, 14)
  INSERT INTO ChiTietPhieuNhap(MaSach, MaPhieuNhap,SoLuongNhap)
 VALUES(6, 4, 12)
  INSERT INTO ChiTietPhieuNhap(MaSach, MaPhieuNhap,SoLuongNhap)
 VALUES(4, 5, 9)
  INSERT INTO ChiTietPhieuNhap(MaSach, MaPhieuNhap,SoLuongNhap)
 VALUES(5, 6, 10)
   INSERT INTO ChiTietPhieuNhap(MaSach, MaPhieuNhap,SoLuongNhap)
 VALUES(7, 7, 19)
   INSERT INTO ChiTietPhieuNhap(MaSach, MaPhieuNhap,SoLuongNhap)
 VALUES(10, 8, 14)
  INSERT INTO ChiTietPhieuNhap(MaSach, MaPhieuNhap,SoLuongNhap)
 VALUES(8, 9, 21)
  INSERT INTO ChiTietPhieuNhap(MaSach, MaPhieuNhap,SoLuongNhap)
 VALUES(4, 10, 14)

   /*Nhap du lieu cho bang QuyDinh*/
 INSERT INTO QuyDinh(TenQuyDinh,GiaTri)
 VALUES('QG_1.1', 150)
 INSERT INTO QuyDinh(TenQuyDinh,GiaTri)
 VALUES('QD_1.2', 300)
 INSERT INTO QuyDinh(TenQuyDinh,GiaTri)
 VALUES('QD_2.1', 20000)
 INSERT INTO QuyDinh(TenQuyDinh,GiaTri)
 VALUES('QD_2.2', 20)
  INSERT INTO QuyDinh(TenQuyDinh,GiaTri)
 VALUES('QD_4.1', 1)