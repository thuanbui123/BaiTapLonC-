use quanLyKho
go

create table nhaCungCap 
(
	id varchar(20) primary key not null,
	tenNhaCungCap nvarchar(max) not null,
	diaChi nvarchar(max) not null,
	soDienThoai varchar(20) not null
)
go

create table loaiHang
(
	id varchar(20) primary key not null,
	tenLoai nvarchar(max) not null,
	dienGiai nvarchar(max)
)
go

create table hangHoa
(
	id varchar(20) primary key not null,
	tenHangHoa nvarchar(max) not null,
	donViTinh nvarchar(50) not null,
	idLoaiHang varchar(20) not null,
	xuatXu nvarchar(50) not null,

	foreign key (idLoaiHang) references loaiHang(id),
)
go

create table phieuNhap
(
	soPhieuNhap varchar(20) primary key not null,
	idNhaCungCap varchar(20) not null,
	ngayLap_Nhap date,

	foreign key (idNhaCungCap) references nhaCungCap(id),
)
go

create table chiTietPhieuNhap
(
	idNhap int identity(1, 1) primary key not null,
	idSoPhieuNhap varchar(20) not null,
	idHangHoa varchar(20) not null,
	soLuongNhap int not null,
	donGiaNhap decimal(15,2) not null,

	foreign key (idSoPhieuNhap) references phieuNhap(soPhieuNhap),
	foreign key (idHangHoa) references hangHoa(id),
)
go

create table kho
(
	id varchar(20) primary key not null,
	idHangHoa varchar(20) not null,
	soLuong int not null,

	foreign key (idHangHoa) references hangHoa(id)
)
go

create table khachHang
(
	id varchar(20) primary key not null,
	tenKhachHang nvarchar(max) not null,
	diaChi nvarchar(max) not null,
	soDienThoai varchar(20) not null
)
go

create table phieuXuat
(
	soPhieuXuat varchar(20) primary key not null,
	idKhachHang varchar(20) not null,
	ngayLap_Xuat date not null,

	foreign key (idKhachHang) references khachHang(id)
)

create table chiTietPhieuXuat
(
	idXuat int identity(1, 1) primary key not null,
	idKho varchar(20) not null,
	idPhieuXuat varchar(20) not null,
	soLuongXuat int not null,
	donGiaXuat decimal(15,2) not null,

	foreign key (idKho) references Kho (id),
	foreign key (idPhieuXuat) references phieuXuat(soPhieuXuat)
)
go 

create table taiKhoan 
(
	id int identity(1,1) primary key not null,
	tenDangNhap nvarchar(100) not null,
	matKhau nvarchar(max) not null,
	tenNguoiDung nvarchar(max) not null
)
go


CREATE PROC USP_ThongKe
@tuNgay Date, @denNgay Date
AS
BEGIN
	Select hh.id, hh.tenHangHoa, hh.donViTinh, ctpx.soLuongXuat, ctpx.donGiaXuat, px.soPhieuXuat, kh.tenKhachHang from hangHoa as hh, chiTietPhieuXuat as ctpx, kho as k, phieuXuat as px, khachHang as kh
	Where (k.idHangHoa = hh.id and ctpx.idKho = k.id and px.soPhieuXuat = ctpx.idPhieuXuat) and px.idKhachHang = kh.id and (px.ngayLap_Xuat >= @tuNgay and px.ngayLap_Xuat <= @denNgay)
END
GO




CREATE PROC USP_login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	  Select * from taiKhoan where [tenDangNhap] = @userName COLLATE SQL_Latin1_General_CP1_CS_AS and [matKhau] = @passWord 
END
GO

exec USP_login @userName = N'Duy', @passWord = 123