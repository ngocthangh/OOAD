USE [master]
GO
/****** Object:  Database [QuanLySieuThi]    Script Date: 11/27/2016 10:23:09 AM ******/
CREATE DATABASE [QuanLySieuThi]
GO
USE [QuanLySieuThi]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MaHoaDon] [varchar](20) NOT NULL,
	[MaHangHoa] int NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_CHITIETHOADON] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETKIEMKE]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETKIEMKE](
	[MaPhieuKiemKe] [varchar](20) NOT NULL,
	[MaHangHoa] int NOT NULL,
	[SLTonTrenQuay] [int] NULL,
	[SLTonTrongKho] [int] NULL,
 CONSTRAINT [PK_CHITIETKIEMKE] PRIMARY KEY CLUSTERED 
(
	[MaPhieuKiemKe] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAP](
	[MaPhieuNhap] [varchar](20) NOT NULL,
	[MaHangHoa] int NOT NULL,
	[MaNhaCungCap] [varchar](20) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_CHITIETPHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETPHIEUXUAT]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUXUAT](
	[MaPhieuXuat] [varchar](20) NOT NULL,
	[MaHangHoa] int NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_CHITIETPHIEUXUAT] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaChucVu] [varchar](20) NOT NULL,
	[TenChucVu] [nvarchar](100) NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHUNGLOAI]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHUNGLOAI](
	[MaChungLoai] [int] IDENTITY(1, 1) NOT NULL,
	[TenChungLoai] [nvarchar](100) NULL,
 CONSTRAINT [PK_CHUNGLOAI] PRIMARY KEY CLUSTERED 
(
	[MaChungLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DONVITINH]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DONVITINH](
	[MaDVT] [int] IDENTITY(1, 1) NOT NULL,
	[TenDVT] [nvarchar](100) NULL,
 CONSTRAINT [PK_DONVITINH] PRIMARY KEY CLUSTERED 
(
	[MaDVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MaHangHoa] [int] IDENTITY(1, 1) NOT NULL,
	[TenHangHoa] [nvarchar](100) NULL,
	[GiaMua] [money] NULL,
	[GiaBan] [money] NULL,
	[NgaySanXuat] [date] NULL,
	[HanSuDung] [date] NULL,
	[SoLuongNhap] [int] NULL,
	[SoLuongBan] [int] NULL,
	[NgayNhap] [date] NULL,
	[VAT] [int] NULL,
	[MaLoaiHang] [int] NULL,
	[MaDVT] [int] NULL,
 CONSTRAINT [PK_HANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHoaDon] [varchar](20) NOT NULL,
	[MaNhanVien] [varchar](20) NULL,
	[NgayLap] [date] NULL,
	[MaKhachHang] [varchar](20) NULL,
	[TongTien] [money] NULL,
	[DiemThuong] [int] NULL,
	[MucGiam] [int] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANGTHANTHIET]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANGTHANTHIET](
	[MaKhachHang] [varchar](20) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](500) NULL,
	[NgayCapThe] [date] NULL,
	[DiemThuong] [int] NULL,
 CONSTRAINT [PK_KHACHHANGTHANTHIET] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIHANG]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAIHANG](
	[MaLoaiHang] [int] IDENTITY(1, 1) NOT NULL,
	[TenLoaiHang] [nvarchar](100) NULL,
	[MaChungLoai] [int] NULL,
 CONSTRAINT [PK_LOAIHANG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNhaCungCap] [varchar](20) NOT NULL,
	[TenNhaCungCap] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](500) NULL,
	[DienThoai] [varchar](20) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNhanVien] [varchar](20) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[CMND] [varchar](20) NULL,
	[DiaChi] [nvarchar](500) NULL,
	[DienThoai] [varchar](20) NULL,
	[NgayVaoLam] [date] NULL,
	[MaChucVu] [varchar](20) NULL,
	[TenDangNhap] [varchar](100) NULL,
	[MatKhau] [varchar](50) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUKIEMKE]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUKIEMKE](
	[MaPhieuKiemKe] [varchar](20) NOT NULL,
	[MaNhanVien] [varchar](20) NULL,
	[NgayLap] [date] NULL,
 CONSTRAINT [PK_PHIEUKIEMKE] PRIMARY KEY CLUSTERED 
(
	[MaPhieuKiemKe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPhieuNhap] [varchar](20) NOT NULL,
	[MaNhanVien] [varchar](20) NULL,
	[NgayLap] [date] NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUXUAT]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUXUAT](
	[MaPhieuXuat] [varchar](20) NOT NULL,
	[MaNhanVien] [varchar](20) NULL,
	[NgayLap] [date] NULL,
	[NoiDungXuat] [nvarchar](500) NULL,
 CONSTRAINT [PK_PHIEUXUAT] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THAMSO](
	[ThamSo] [varchar](100) NOT NULL,
	[GiaTri] [float] NULL,
 CONSTRAINT [PK_THAMSO] PRIMARY KEY CLUSTERED 
(
	[ThamSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu]) VALUES (N'CV001', N'Nhân Viên Bán Hàng')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTen], [NgaySinh], [GioiTinh], [CMND], [DiaChi], [DienThoai], [NgayVaoLam], [MaChucVu], [TenDangNhap], [MatKhau]) VALUES (N'NV0001', N'Nguyễn Văn A', CAST(N'1994-03-06' AS Date), N'Nam', N'215356789', N'Dĩ An - Bình Dương', N'0987654321', CAST(N'2000-05-11' AS Date), N'CV001', N'nguyenvana', N'123456')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTen], [NgaySinh], [GioiTinh], [CMND], [DiaChi], [DienThoai], [NgayVaoLam], [MaChucVu], [TenDangNhap], [MatKhau]) VALUES (N'NV0003', N'Huỳnh Ngọc Thắng', CAST(N'1995-08-20' AS Date), N'Nam', N'215352284', N'An Nhơn - Bình Định', N'0972516794', CAST(N'2017-01-23' AS Date), N'CV001', N'ngocthangh', N'12345')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTen], [NgaySinh], [GioiTinh], [CMND], [DiaChi], [DienThoai], [NgayVaoLam], [MaChucVu], [TenDangNhap], [MatKhau]) VALUES (N'NV0004', N'Trần CD', CAST(N'2016-11-16' AS Date), N'Khác', N'2344344334', N'tp Hồ Chí Minh', N'938837371', CAST(N'2016-11-18' AS Date), N'CV001', N'ccccccaa', N'tttttttttt')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayLap], [TongTien]) VALUES (N'PN0001', N'NV0001', CAST(N'2016-03-04' AS Date), 500000.0000)
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HANGHOA] ([MaHangHoa])
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HOADON] ([MaHoaDon])
GO
ALTER TABLE [dbo].[CHITIETKIEMKE]  WITH CHECK ADD FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HANGHOA] ([MaHangHoa])
GO
ALTER TABLE [dbo].[CHITIETKIEMKE]  WITH CHECK ADD FOREIGN KEY([MaPhieuKiemKe])
REFERENCES [dbo].[PHIEUKIEMKE] ([MaPhieuKiemKe])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NHACUNGCAP] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PHIEUNHAP] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HANGHOA] ([MaHangHoa])
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([MaPhieuXuat])
REFERENCES [dbo].[PHIEUXUAT] ([MaPhieuXuat])
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD FOREIGN KEY([MaDVT])
REFERENCES [dbo].[DONVITINH] ([MaDVT])
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD FOREIGN KEY([MaLoaiHang])
REFERENCES [dbo].[LOAIHANG] ([MaLoaiHang])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANGTHANTHIET] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[LOAIHANG]  WITH CHECK ADD FOREIGN KEY([MaChungLoai])
REFERENCES [dbo].[CHUNGLOAI] ([MaChungLoai])
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[CHUCVU] ([MaChucVu])
GO
ALTER TABLE [dbo].[PHIEUKIEMKE]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETHOADON_DEL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHITIETHOADON_DEL]
@MaHoaDon varchar(20) 
AS
DELETE FROM [dbo].[CHITIETHOADON]
 WHERE [MaHoaDon] = @MaHoaDon


GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETHOADON_GETALL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHITIETHOADON_GETALL]
AS
SELECT * FROM [dbo].[CHITIETHOADON]


GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETHOADON_GETBYID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHITIETHOADON_GETBYID]
@MaHoaDon varchar(20) 
AS
SELECT * FROM [dbo].[CHITIETHOADON]
 WHERE [MaHoaDon] = @MaHoaDon


GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETHOADON_INS]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHITIETHOADON_INS]
			@MaHoaDon varchar(20) 
           ,@MaHangHoa int 
           ,@SoLuong int 
AS
INSERT INTO [dbo].[CHITIETHOADON]
           ([MaHoaDon]
		   ,[MaHangHoa]
		   ,[SoLuong])
     VALUES
           (@MaHoaDon
		   ,@MaHangHoa
		   ,@SoLuong)

GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETHOADON_UPD]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHITIETHOADON_UPD]
            @MaHoaDon varchar(20) 
           ,@MaHangHoa int 
           ,@SoLuong int  
AS
UPDATE [dbo].[CHITIETHOADON]
   SET 
       [MaHangHoa] = @MaHangHoa
      ,[SoLuong] = @SoLuong
 WHERE [MaHoaDon] = @MaHoaDon


GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETKIEMKE_DEL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETKIEMKE_DEL]
@MaPhieuKiemKe varchar(20)
AS
DELETE FROM [dbo].[CHITIETKIEMKE]
 WHERE [MaPhieuKiemKe] = @MaPhieuKiemKe
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETKIEMKE_GETALL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETKIEMKE_GETALL]
AS
SELECT * FROM [dbo].[CHITIETKIEMKE]

GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETKIEMKE_GETBYID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETKIEMKE_GETBYID]
@MaPhieuKiemKe varchar(20)
AS
SELECT * FROM [dbo].[CHITIETKIEMKE]
  WHERE [MaPhieuKiemKe] = @MaPhieuKiemKe
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETKIEMKE_INS]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETKIEMKE_INS]
@MaPhieuKiemKe varchar(20)
           ,@MaHangHoa int
		   ,@SLTonTrenQuay int
           ,@SLTonTrongKho int
AS
INSERT INTO [dbo].[CHITIETKIEMKE]
           ([MaPhieuKiemKe]
           ,[MaHangHoa]
		   ,[SLTonTrenQuay]
           ,[SLTonTrongKho])
     VALUES
           (@MaPhieuKiemKe 
           ,@MaHangHoa 
		   ,@SLTonTrenQuay
           ,@SLTonTrongKho)
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETKIEMKE_UPD]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETKIEMKE_UPD]
@MaPhieuKiemKe varchar(20)
           ,@MaHangHoa int
		   ,@SLTonTrenQuay int
           ,@SLTonTrongKho int
AS
UPDATE [dbo].[CHITIETKIEMKE]
   SET SLTonTrongKho = @SLTonTrongKho,
   SLTonTrenQuay = @SLTonTrenQuay
WHERE [MaPhieuKiemKe] = @MaPhieuKiemKe AND [MaHangHoa] = @MaHangHoa
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUNHAP_DEL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETPHIEUNHAP_DEL]
@MaPhieuNhap varchar(20)
AS
DELETE FROM [dbo].[CHITIETPHIEUNHAP]
 WHERE [MaPhieuNhap] = @MaPhieuNhap
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUNHAP_GETALL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETPHIEUNHAP_GETALL]
AS
SELECT * FROM [dbo].[CHITIETPHIEUNHAP]
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUNHAP_GETBYID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETPHIEUNHAP_GETBYID]
@MaPhieuNhap varchar(20)
AS
SELECT * FROM [dbo].[CHITIETPHIEUNHAP]
  WHERE [MaPhieuNhap] = @MaPhieuNhap
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUNHAP_INS]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETPHIEUNHAP_INS]
@MaPhieuNhap varchar(20)
           ,@MaHangHoa int
		   ,@MaNhaCungCap varchar(20)
           ,@SoLuong int
AS
INSERT INTO [dbo].[CHITIETPHIEUNHAP]
           ([MaPhieuNhap]
           ,[MaHangHoa]
		   ,[MaNhaCungCap]
           ,[SoLuong])
     VALUES
           (@MaPhieuNhap 
           ,@MaHangHoa 
		   ,@MaNhaCungCap
           ,@SoLuong)
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUNHAP_UPD]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETPHIEUNHAP_UPD]
@MaPhieuNhap varchar(20)
           ,@MaHangHoa int
		   ,@MaNhaCungCap varchar(20)
           ,@SoLuong int
AS
UPDATE [dbo].[CHITIETPHIEUNHAP]
   SET SoLuong = @SoLuong,
   MaNhaCungCap = @MaNhaCungCap
WHERE [MaPhieuNhap] = @MaPhieuNhap AND [MaHangHoa] = @MaHangHoa
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUXUAT_DEL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETPHIEUXUAT_DEL]
@MaPhieuXuat varchar(20)
AS
DELETE FROM [dbo].[CHITIETPHIEUXUAT]
 WHERE [MaPhieuXuat] = @MaPhieuXuat


GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUXUAT_GETALL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHITIETPHIEUXUAT_GETALL]
AS
SELECT * FROM [dbo].[CHITIETPHIEUXUAT]

GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUXUAT_GETBYID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETPHIEUXUAT_GETBYID]
@MaPhieuXuat varchar(20)
AS
SELECT * FROM [dbo].[CHITIETPHIEUXUAT]
  WHERE [MaPhieuXuat] = @MaPhieuXuat
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUXUAT_INS]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETPHIEUXUAT_INS]
@MaPhieuXuat varchar(20)
           ,@MaHangHoa int
           ,@SoLuong int
AS
INSERT INTO [dbo].[CHITIETPHIEUXUAT]
           ([MaPhieuXuat]
           ,[MaHangHoa]
           ,[SoLuong])
     VALUES
           (@MaPhieuXuat 
           ,@MaHangHoa 
           ,@SoLuong)
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUXUAT_UPD]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETPHIEUXUAT_UPD]
@MaPhieuXuat varchar(20)
           ,@MaHangHoa int
           ,@SoLuong int
AS
UPDATE [dbo].[CHITIETPHIEUXUAT]
   SET SoLuong = @SoLuong
WHERE [MaPhieuXuat] = @MaPhieuXuat AND [MaHangHoa] = @MaHangHoa
GO
/****** Object:  StoredProcedure [dbo].[SP_CHUCVU_AUTOGENERATEID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHUCVU_AUTOGENERATEID]
AS
BEGIN
DECLARE @ma_next varchar(15)
DECLARE @max int
SELECT @max=COUNT(MaChucVu) + 1 FROM CHUCVU
SET @ma_next='CV' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
WHILE(exists(SELECT MaChucVu FROM CHUCVU WHERE MaChucVu=@ma_next))
BEGIN
	SET @max=@max+1
	SET @ma_next='CV' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
END
SELECT 'MaChucVu' = @ma_next
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CHUCVU_DEL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHUCVU_DEL]
@MaChucVu varchar(20) 
AS
DELETE FROM [dbo].[CHUCVU]
 WHERE [MaChucVu] = @MaChucVu


GO
/****** Object:  StoredProcedure [dbo].[SP_CHUCVU_GETALL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHUCVU_GETALL]
AS
SELECT * FROM [dbo].[CHUCVU]


GO
/****** Object:  StoredProcedure [dbo].[SP_CHUCVU_GETBYID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHUCVU_GETBYID]
@MaChucVu varchar(20) 
AS
SELECT * FROM [dbo].[CHUCVU]
 WHERE [MaChucVu] = @MaChucVu


GO
/****** Object:  StoredProcedure [dbo].[SP_CHUCVU_INS]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHUCVU_INS]
			@MaChucVu varchar(20) 
           ,@TenChucVu nvarchar(100) 
AS
INSERT INTO [dbo].[CHUCVU]
           ([MaChucVu]
           ,[TenChucVu])
     VALUES
           (@MaChucVu
           ,@TenChucVu)


GO
/****** Object:  StoredProcedure [dbo].[SP_CHUCVU_UPD]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHUCVU_UPD]
			@MaChucVu varchar(20) 
           ,@TenChucVu nvarchar(100) 
AS
UPDATE [dbo].[CHUCVU]
   SET 
      [TenChucVu] = @TenChucVu
 WHERE [MaChucVu] = @MaChucVu


GO
/****** Object:  StoredProcedure [dbo].[SP_CHUNGLOAI_AUTOGENERATEID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHUNGLOAI_AUTOGENERATEID]
AS
BEGIN
	DECLARE @Ma_Next varchar(15)
	DECLARE @Max int
	SELECT @Max = COUNT(MaChungLoai) +1
	FROM CHUNGLOAI
	SET @Ma_Next = 'CL' + RIGHT('0000' + CAST(@Max AS varchar(15)),4)
	WHILE (EXISTS(SELECT MaChungLoai FROM CHUNGLOAI WHERE MaChungLoai = @Ma_Next))
	BEGIN
		SET @Max = @Max +1
		SET @Ma_Next = 'CL' + RIGHT('0000' + CAST(@Max AS varchar(15)),4)
	END
	SELECT 'MaChungLoai' = @Ma_Next
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CHUNGLOAI_DEL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHUNGLOAI_DEL]
	@MaChungLoai int
AS
BEGIN
	DELETE FROM CHUNGLOAI
	WHERE MaChungLoai = @MaChungLoai
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CHUNGLOAI_GETALL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHUNGLOAI_GETALL]
AS
BEGIN
	SELECT * FROM CHUNGLOAI
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CHUNGLOAI_GETBYID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHUNGLOAI_GETBYID]
	@MaChungLoai int
AS
BEGIN
	SELECt * FROM CHUNGLOAI
	WHERE MaChungLoai = @MaChungLoai
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CHUNGLOAI_INS]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHUNGLOAI_INS]
	@TenChungLoai nvarchar(100)
AS
BEGIN
	INSERT INTO CHUNGLOAI(
		TenChungLoai)
	VALUES(
		@TenChungLoai)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CHUNGLOAI_UPD]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHUNGLOAI_UPD]
	@MaChungLoai int,
	@TenChungLoai nvarchar(100)
AS
BEGIN
	UPDATE CHUNGLOAI
	SET
		TenChungLoai = @TenChungLoai
	WHERE
		MaChungLoai = @MaChungLoai
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DONVITINH_AUTOGENERATEID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DONVITINH_AUTOGENERATEID]
AS
BEGIN
	DECLARE @Ma_Next varchar(15)
	DECLARE @Max int
	SELECT @Max = COUNT(MaDVT) +1
	FROM DONVITINH
	SET @Ma_Next = 'DVT' + RIGHT('0000' + CAST(@Max AS varchar(15)),4)
	WHILE (EXISTS(SELECT MaDVT FROM DONVITINH WHERE MaDVT = @Ma_Next))
	BEGIN
		SET @Max = @Max +1
		SET @Ma_Next = 'DVT' + RIGHT('0000' + CAST(@Max AS varchar(15)),4)
	END
	SELECT 'DonViTinh' = @Ma_Next
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DONVITINH_DEL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DONVITINH_DEL]
	@MaDVT int
AS
BEGIN
	DELETE FROM DONVITINH
	WHERE MaDVT = @MaDVT
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DONVITINH_GETALL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DONVITINH_GETALL]
AS
BEGIN
	SELECT * FROM DONVITINH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DONVITINH_GETBYID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DONVITINH_GETBYID]
	@MaDVT int
AS
BEGIN
	SELECT * FROM DONVITINH
	WHERE MaDVT = @MaDVT
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DONVITINH_INS]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DONVITINH_INS]
	@TenDVT nvarchar(100)
AS
BEGIN
	INSERT INTO DONVITINH(
		TenDVT)
	VALUES(
		@TenDVT)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DONVITINH_UPD]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DONVITINH_UPD]
	@MaDVT int,
	@TenDVT nvarchar(100)
AS
BEGIN
	UPDATE DONVITINH
	SET
		TenDVT = @TenDVT
	WHERE MaDVT =@MaDVT
END
GO
/****** Object:  StoredProcedure [dbo].[SP_HANGHOA_AUTOGENERATEID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_HANGHOA_AUTOGENERATEID]
AS
BEGIN
	DECLARE @Ma_Next varchar(15)
	DECLARE @Max int
	SELECT @Max = COUNT(MaHangHoa) +1
	FROM HANGHOA
	SET @Ma_Next = 'HH' + RIGHT('0000' + CAST(@Max AS varchar(15)),4)
	WHILE (EXISTS(SELECT MaHangHoa FROM HANGHOA WHERE MaHangHoa = @Ma_Next))
	BEGIN
		SET @Max = @Max +1
		SET @Ma_Next = 'HH' + RIGHT('0000' + CAST(@Max AS varchar(15)),4)
	END
	SELECT 'MaHangHoa' = @Ma_Next
END
GO
/****** Object:  StoredProcedure [dbo].[SP_HANGHOA_DEL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_HANGHOA_DEL]
	@MaHangHoa int
AS
BEGIN
	DELETE FROM HANGHOA
	WHERE MaHangHoa = @MaHangHoa
END
GO
/****** Object:  StoredProcedure [dbo].[SP_HANGHOA_GETALL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_HANGHOA_GETALL]
AS
BEGIN
	SELECT * FROM HANGHOA
END
GO
/****** Object:  StoredProcedure [dbo].[SP_HANGHOA_GETBYID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_HANGHOA_GETBYID]
	@MaHangHoa int
AS
BEGIN
	SELECT * FROM HANGHOA WHERE MaHangHoa = @MaHangHoa
END
GO
/****** Object:  StoredProcedure [dbo].[SP_HANGHOA_INS]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_HANGHOA_INS]
	@MaHangHoa int,
	@TenHangHoa nvarchar(100),
	@GiaMua money,
	@GiaBan money,
	@NgaySanXuat date,
	@HanSuDung date,
	@SoLuongNhap int,
	@SoLuongBan int,
	@NgayNhap date,
	@VAT int,
	@MaLoaiHang int,
	@MaDVT int
AS
BEGIN
	INSERT INTO HANGHOA(
		MaHangHoa,
		TenHangHoa,
		GiaMua,
		GiaBan,
		NgaySanXuat,
		HanSuDung,
		SoLuongNhap,
		SoLuongBan,
		NgayNhap,
		VAT,
		MaLoaiHang,
		MaDVT)
	VALUES(
		@MaHangHoa,
		@TenHangHoa,
		@GiaMua,
		@GiaBan,
		@NgaySanXuat,
		@HanSuDung,
		@SoLuongNhap,
		@SoLuongBan,
		@NgayNhap,
		@VAT,
		@MaLoaiHang,
		@MaDVT)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_HANGHOA_UPD]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_HANGHOA_UPD]
	@MaHangHoa int,
	@TenHangHoa nvarchar(100),
	@GiaMua money,
	@GiaBan money,
	@NgaySanXuat date,
	@HanSuDung date,
	@SoLuongNhap int,
	@SoLuongBan int,
	@NgayNhap date,
	@VAT int,
	@MaLoaiHang int,
	@MaDVT int
AS
BEGIN
	UPDATE HANGHOA
	SET
		TenHangHoa = @TenHangHoa,
		GiaMua = @GiaMua,
		GiaBan = @GiaBan,
		NgaySanXuat = @NgaySanXuat,
		HanSuDung = @HanSuDung,
		SoLuongNhap = @SoLuongNhap,
		SoLuongBan = @SoLuongBan,
		NgayNhap = @NgayNhap,
		VAT = @VAT
	WHERE MaHangHoa = @MaHangHoa AND MaLoaiHang = @MaLoaiHang AND MaDVT = @MaDVT
END
GO
/****** Object:  StoredProcedure [dbo].[SP_HOADON_AUTOGENERATEID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_HOADON_AUTOGENERATEID]
AS
BEGIN
DECLARE @ma_next varchar(15)
DECLARE @max int
SELECT @max=COUNT(MaHoaDon) + 1 FROM HOADON
SET @ma_next='HD' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
WHILE(exists(SELECT MaHoaDon FROM HOADON WHERE MaHoaDon=@ma_next))
BEGIN
	SET @max=@max+1
	SET @ma_next='HD' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
END
SELECT 'MaHoaDon' = @ma_next
END
GO
/****** Object:  StoredProcedure [dbo].[SP_HOADON_DEL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_HOADON_DEL]
@MaHoaDon varchar(20) 
AS
DELETE FROM [dbo].[HOADON]
 WHERE [MaHoaDon] = @MaHoaDon


GO
/****** Object:  StoredProcedure [dbo].[SP_HOADON_GETALL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_HOADON_GETALL]
AS
SELECT * FROM [dbo].[HOADON]


GO
/****** Object:  StoredProcedure [dbo].[SP_HOADON_GETBYID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_HOADON_GETBYID]
@MaHoaDon varchar(20) 
AS
SELECT * FROM [dbo].[HOADON]
 WHERE [MaHoaDon] = @MaHoaDon


GO
/****** Object:  StoredProcedure [dbo].[SP_HOADON_INS]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_HOADON_INS]
            @MaHoaDon varchar(20) 
           ,@MaNhanVien varchar(20)  
           ,@NgayLap date 
           ,@MaKhachHang varchar(20) 
           ,@TongTien money 
           ,@DiemThuong int 
           ,@MucGiam int 
AS
INSERT INTO [dbo].[HOADON]
           ([MaHoaDon]
           ,[MaNhanVien]
           ,[NgayLap]
           ,[MaKhachHang]
           ,[TongTien]
           ,[DiemThuong]
           ,[MucGiam])
     VALUES
           (@MaHoaDon  
           ,@MaNhanVien 
           ,@NgayLap
           ,@MaKhachHang 
           ,@TongTien 
           ,@DiemThuong 
           ,@MucGiam)




GO
/****** Object:  StoredProcedure [dbo].[SP_HOADON_UPD]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_HOADON_UPD]
			@MaHoaDon varchar(20) 
           ,@MaNhanVien varchar(20)  
           ,@NgayLap date 
           ,@MaKhachHang varchar(20) 
           ,@TongTien money 
           ,@DiemThuong int 
           ,@MucGiam int
AS
UPDATE [dbo].[HOADON]
   SET 
        [MaNhanVien]=@MaNhanVien
       ,[NgayLap]=@NgayLap
       ,[MaKhachHang]=@MaKhachHang
       ,[TongTien]=@TongTien
       ,[DiemThuong]=@DiemThuong
       ,[MucGiam]=@MucGiam
 WHERE [MaHoaDon] = @MaHoaDon


GO
/****** Object:  StoredProcedure [dbo].[SP_KHACHHANGTHANTHIET_AUTOGENERATEID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_KHACHHANGTHANTHIET_AUTOGENERATEID]
AS
BEGIN
DECLARE @ma_next varchar(15)
DECLARE @max int
SELECT @max=COUNT(MaKhachHang) + 1 FROM KHACHHANGTHANTHIET
SET @ma_next='KH' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
WHILE(exists(SELECT MaKhachHang FROM KHACHHANGTHANTHIET WHERE MaKhachHang=@ma_next))
BEGIN
	SET @max=@max+1
	SET @ma_next='KH' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
END
SELECT 'MaKhachHang' = @ma_next
END
GO
/****** Object:  StoredProcedure [dbo].[SP_KHACHHANGTHANTHIET_DEL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_KHACHHANGTHANTHIET_DEL]
@MaKhachHang varchar(20) 
AS
DELETE FROM [dbo].[KHACHHANGTHANTHIET]
 WHERE [MaKhachHang] = @MaKhachHang


GO
/****** Object:  StoredProcedure [dbo].[SP_KHACHHANGTHANTHIET_GETALL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_KHACHHANGTHANTHIET_GETALL]
AS
SELECT * FROM [dbo].[KHACHHANGTHANTHIET]


GO
/****** Object:  StoredProcedure [dbo].[SP_KHACHHANGTHANTHIET_GETBYID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_KHACHHANGTHANTHIET_GETBYID]
@MaKhachHang varchar(20) 
AS
SELECT * FROM [dbo].[KHACHHANGTHANTHIET]
 WHERE [MaKhachHang] = @MaKhachHang


GO
/****** Object:  StoredProcedure [dbo].[SP_KHACHHANGTHANTHIET_INS]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_KHACHHANGTHANTHIET_INS]
			@MaKhachHang varchar(20) 
           ,@HoTen nvarchar(100) 
		   ,@DiaChi nvarchar(500)
           ,@NgayCapThe date 
		   ,@DiemThuong int
AS
INSERT INTO [dbo].[KHACHHANGTHANTHIET]
           ([MaKhachHang]
           ,[HoTen]
           ,[DiaChi]
           ,[NgayCapThe]
           ,[DiemThuong])
     VALUES
           (@MaKhachHang  
           ,@HoTen  
		   ,@DiaChi 
           ,@NgayCapThe 
		   ,@DiemThuong)




GO
/****** Object:  StoredProcedure [dbo].[SP_KHACHHANGTHANTHIET_UPD]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_KHACHHANGTHANTHIET_UPD]
            @MaKhachHang varchar(20) 
           ,@HoTen nvarchar(100) 
		   ,@DiaChi nvarchar(500)
           ,@NgayCapThe date 
		   ,@DiemThuong int
AS
UPDATE [dbo].[KHACHHANGTHANTHIET]
   SET 
       [HoTen] = @HoTen
      ,[DiaChi] = @DiaChi
      ,[NgayCapThe] = @NgayCapThe
      ,[DiemThuong] = @DiemThuong
 WHERE [MaKhachHang] = @MaKhachHang


GO
/****** Object:  StoredProcedure [dbo].[SP_LOAIHANG_AUTOGENERATEID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LOAIHANG_AUTOGENERATEID]
AS
BEGIN
	DECLARE @Ma_Next varchar(15)
	DECLARE @Max int
	SELECT @Max = COUNT(MaLoaiHang) + 1 
	FROM LOAIHANG
	SET @Ma_Next = 'LH' + RIGHT('0000' + CAST(@Max AS varchar(15)),4)
	WHILE (EXISTS(SELECT MaLoaiHang FROM LOAIHANG WHERE MaLoaiHang = @Ma_Next))
	BEGIN
		SET @Max = @Max +1
		SET @Ma_Next = 'LH' + RIGHT('0000' + CAST(@Max AS varchar(15)),4)
	END
	SELECT 'MaLoaiHang' = @Ma_Next
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LOAIHANG_DEL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LOAIHANG_DEL]
	@MaLoaiHang int
AS
BEGIN
	DELETE FROM LOAIHANG
	WHERE MaLoaiHang = @MaLoaiHang
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LOAIHANG_GETALL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LOAIHANG_GETALL]
AS
BEGIN
	SELECT * FROM LOAIHANG
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LOAIHANG_GETBYID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LOAIHANG_GETBYID]
	@MaLoaiHang int
AS
BEGIN
	SELECT * 
	FROM LOAIHANG
	WHERE MaLoaiHang = @MaLoaiHang
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LOAIHANG_INS]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LOAIHANG_INS]
	@TenLoaiHang nvarchar(100),
	@MaChungLoai int
AS
BEGIN
	INSERT INTO LOAIHANG(
		TenLoaiHang,
		MaChungLoai)
	VALUES(
		@TenLoaiHang,
		@MaChungLoai)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LOAIHANG_UPD]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LOAIHANG_UPD]
	@MaLoaiHang int,
	@TenLoaiHang nvarchar(100),
	@MaChungLoai int
AS
BEGIN
	UPDATE LOAIHANG
	SET 
		TenLoaiHang = @TenLoaiHang,
		MaChungLoai = @MaChungLoai
	WHERE
		MaLoaiHang = @MaLoaiHang
END
GO
/****** Object:  StoredProcedure [dbo].[SP_NHACUNGCAP_AUTOGENERATEID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_NHACUNGCAP_AUTOGENERATEID]
AS
BEGIN
	DECLARE @Ma_Next varchar(15)
	DECLARE @Max int
	SELECT @Max = COUNT(MaNhaCungCap) +1
	FROM NHACUNGCAP
	SET @Ma_Next = 'NCC' + RIGHT('0000' + CAST(@Max AS varchar(15)),4)
	WHILE (EXISTS(SELECT MaNhaCungCap FROM NHACUNGCAP WHERE MaNhaCungCap = @Ma_Next))
	BEGIN
		SET @Max = @Max +1
		SET @Ma_Next = 'NCC' + RIGHT('0000' + CAST(@Max AS varchar(15)),4)
	END
	SELECT 'MaNhaCungCap' = @Ma_Next
END
GO
/****** Object:  StoredProcedure [dbo].[SP_NHACUNGCAP_DEL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_NHACUNGCAP_DEL]
	@MaNhaCungCap varchar(20)
AS
BEGIN
	DELETE FROM NHACUNGCAP
	WHERE MaNhaCungCap = @MaNhaCungCap
END
GO
/****** Object:  StoredProcedure [dbo].[SP_NHACUNGCAP_GETALL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_NHACUNGCAP_GETALL]
AS
BEGIN
	SELECT * FROM NHACUNGCAP
END
GO
/****** Object:  StoredProcedure [dbo].[SP_NHACUNGCAP_GETBYID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_NHACUNGCAP_GETBYID]
	@MaNhaCungCap varchar(20)
AS
BEGIN
	SELECT * FROM NHACUNGCAP
	WHERE MaNhaCungCap = @MaNhaCungCap
END
GO
/****** Object:  StoredProcedure [dbo].[SP_NHACUNGCAP_INS]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_NHACUNGCAP_INS]
	@MaNhaCungCap varchar(20),
	@TenNhaCungCap nvarchar(100),
	@DiaChi nvarchar(100),
	@DienThoai varchar(20)
AS
BEGIN
	INSERT INTO NHACUNGCAP(
		MaNhaCungCap,
		TenNhaCungCap,
		DiaChi,
		DienThoai)
	VALUES(
		@MaNhaCungCap,
		@TenNhaCungCap,
		@DiaChi,
		@DienThoai)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_NHACUNGCAP_UPD]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_NHACUNGCAP_UPD]
	@MaNhaCungCap varchar(20),
	@TenNhaCungCap nvarchar(100),
	@DiaChi nvarchar(500),
	@DienThoai varchar(20)
AS
BEGIN
	UPDATE NHACUNGCAP
	SET
		MaNhaCungCap = @MaNhaCungCap,
		TenNhaCungCap = @TenNhaCungCap,
		DiaChi = @DiaChi,
		DienThoai = @DienThoai
	WHERE MaNhaCungCap = @MaNhaCungCap
END
GO
/****** Object:  StoredProcedure [dbo].[SP_NHANVIEN_AUTOGENERATEID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_NHANVIEN_AUTOGENERATEID]
AS
BEGIN
DECLARE @ma_next varchar(15)
DECLARE @max int
SELECT @max=COUNT(MaNhanVien) + 1 FROM NHANVIEN
SET @ma_next='NV' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
WHILE(exists(SELECT MaNhanVien FROM NHANVIEN WHERE MaNhanVien=@ma_next))
BEGIN
	SET @max=@max+1
	SET @ma_next='NV' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
END
SELECT 'MaNhanVien' = @ma_next
END
GO
/****** Object:  StoredProcedure [dbo].[SP_NHANVIEN_DEL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_NHANVIEN_DEL]
@MaNhanVien varchar(20) 
AS
DELETE FROM [dbo].[NHANVIEN]
 WHERE [MaNhanVien] = @MaNhanVien


GO
/****** Object:  StoredProcedure [dbo].[SP_NHANVIEN_GETALL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_NHANVIEN_GETALL]
AS
SELECT * FROM NHANVIEN NV INNER JOIN CHUCVU CV ON NV.MaChucVu = CV.MaChucVu
GO
/****** Object:  StoredProcedure [dbo].[SP_NHANVIEN_GETBYID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_NHANVIEN_GETBYID]
@MaNhanVien varchar(20) 
AS
SELECT * FROM NHANVIEN NV INNER JOIN CHUCVU CV ON NV.MaChucVu = CV.MaChucVu
 WHERE [MaNhanVien] = @MaNhanVien
GO
/****** Object:  StoredProcedure [dbo].[SP_NHANVIEN_INS]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_NHANVIEN_INS]
@MaNhanVien varchar(20) 
           ,@HoTen nvarchar(100) 
           ,@NgaySinh date 
           ,@GioiTinh nvarchar(5) 
           ,@CMND varchar(20) 
           ,@DiaChi nvarchar(500) 
           ,@DienThoai varchar(20) 
           ,@NgayVaoLam date 
           ,@MaChucVu varchar(20) 
           ,@TenDangNhap varchar(100) 
           ,@MatKhau varchar(50) 
AS
INSERT INTO [dbo].[NHANVIEN]
           ([MaNhanVien]
           ,[HoTen]
           ,[NgaySinh]
           ,[GioiTinh]
           ,[CMND]
           ,[DiaChi]
           ,[DienThoai]
           ,[NgayVaoLam]
           ,[MaChucVu]
           ,[TenDangNhap]
           ,[MatKhau])
     VALUES
           (@MaNhanVien
           ,@HoTen 
           ,@NgaySinh 
           ,@GioiTinh 
           ,@CMND  
           ,@DiaChi
           ,@DienThoai 
           ,@NgayVaoLam 
           ,@MaChucVu 
           ,@TenDangNhap 
           ,@MatKhau)




GO
/****** Object:  StoredProcedure [dbo].[SP_NHANVIEN_SEARCH]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_NHANVIEN_SEARCH]
	@key nvarchar(50)
AS
declare @searchkey nvarchar(55);
set @searchkey = '%' + @key + '%';
	SELECT * from NHANVIEN NV INNER JOIN CHUCVU CV ON NV.MaChucVu = CV.MaChucVu
	WHERE MaNhanVien like @key or HoTen like @searchkey or NgaySinh like @key
		or GioiTinh like @key or CMND like @searchkey or DiaChi like @searchkey or DienThoai like @searchkey
		or TenChucVu like @searchkey or NgayVaoLam like @searchkey or TenDangNhap like @searchkey
GO
/****** Object:  StoredProcedure [dbo].[SP_NHANVIEN_UPD]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_NHANVIEN_UPD]
@MaNhanVien varchar(20) 
           ,@HoTen nvarchar(100) 
           ,@NgaySinh date 
           ,@GioiTinh nvarchar(5) 
           ,@CMND varchar(20) 
           ,@DiaChi nvarchar(500) 
           ,@DienThoai varchar(20) 
           ,@NgayVaoLam date 
           ,@MaChucVu varchar(20) 
           ,@TenDangNhap varchar(100) 
           ,@MatKhau varchar(50) 
AS
UPDATE [dbo].[NHANVIEN]
   SET 
      [HoTen] = @HoTen
      ,[NgaySinh] = @NgaySinh
      ,[GioiTinh] = @GioiTinh
      ,[CMND] = @CMND
      ,[DiaChi] = @DiaChi
      ,[DienThoai] = @DienThoai
      ,[NgayVaoLam] = @NgayVaoLam
      ,[MaChucVu] = @MaChucVu
      ,[TenDangNhap] = @TenDangNhap
      ,[MatKhau] = @MatKhau
 WHERE [MaNhanVien] = @MaNhanVien


GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUKIEMKE_AUTOGENERATEID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_PHIEUKIEMKE_AUTOGENERATEID]
AS
BEGIN
DECLARE @ma_next varchar(15)
DECLARE @max int
SELECT @max=COUNT(MaPhieuKiemKe) + 1 FROM PHIEUKIEMKE
SET @ma_next='PKK' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
WHILE(exists(SELECT MaPhieuKiemKe FROM PHIEUKIEMKE WHERE MaPhieuKiemKe=@ma_next))
BEGIN
	SET @max=@max+1
	SET @ma_next='PKK' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
END
SELECT 'MaPhieuKiemKe' = @ma_next
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUKIEMKE_DEL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_PHIEUKIEMKE_DEL]
@MaPhieuKiemKe varchar(20) 
AS
DELETE FROM [dbo].[PHIEUKIEMKE]
 WHERE [MaPhieuKiemKe] = @MaPhieuKiemKe


GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUKIEMKE_GETALL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_PHIEUKIEMKE_GETALL]
AS
SELECT * FROM [dbo].[PHIEUKIEMKE]


GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUKIEMKE_GETBYID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_PHIEUKIEMKE_GETBYID]
@MaPhieuKiemKe varchar(20) 
AS
SELECT * FROM [dbo].[PHIEUKIEMKE]
 WHERE [MaPhieuKiemKe] = @MaPhieuKiemKe


GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUKIEMKE_INS]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUKIEMKE_INS]
            @MaPhieuKiemKe varchar(20) 
           ,@MaNhanVien varchar(20) 
           ,@NgayLap date 
AS
INSERT INTO [dbo].[PHIEUKIEMKE]
           ([MaPhieuKiemKe]
           ,[MaNhanVien]
           ,[NgayLap])          
     VALUES
           (@MaPhieuKiemKe
           ,@MaNhanVien
           ,@NgayLap)

GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUKIEMKE_UPD]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_PHIEUKIEMKE_UPD]
            @MaPhieuKiemKe varchar(20) 
           ,@MaNhanVien varchar(20) 
           ,@NgayLap date 
AS
UPDATE [dbo].[PHIEUKIEMKE]
   SET 
      [MaNhanVien] = @MaNhanVien
      ,[NgayLap] = @NgayLap
 WHERE [MaPhieuKiemKe] = @MaPhieuKiemKe


GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUNHAP_AUTOGENERATEID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_PHIEUNHAP_AUTOGENERATEID]
AS
BEGIN
DECLARE @ma_next varchar(15)
DECLARE @max int
SELECT @max=COUNT(MaPhieuNhap) + 1 FROM PHIEUNHAP
SET @ma_next='PN' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
WHILE(exists(SELECT MaPhieuNhap FROM PHIEUNHAP WHERE MaPhieuNhap=@ma_next))
BEGIN
	SET @max=@max+1
	SET @ma_next='PN' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
END
SELECT 'MaPhieuNhap' = @ma_next
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUNHAP_DEL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_PHIEUNHAP_DEL]
@MaPhieuNhap varchar(20)
AS
DELETE FROM [dbo].[PHIEUNHAP]
 WHERE [MaPhieuNhap] = @MaPhieuNhap


GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUNHAP_GETALL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_PHIEUNHAP_GETALL]
AS
SELECT * FROM [dbo].[PHIEUNHAP]


GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUNHAP_GETBYID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_PHIEUNHAP_GETBYID]
@MaPhieuNhap varchar(20)
AS
SELECT * FROM [dbo].[PHIEUNHAP]
  WHERE [MaPhieuNhap] = @MaPhieuNhap


GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUNHAP_INS]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUNHAP_INS]
@MaPhieuNhap varchar(20)
           ,@MaNhanVien varchar(20)
           ,@NgayLap date
           ,@TongTien money
AS
INSERT INTO [dbo].[PHIEUNHAP]
           ([MaPhieuNhap]
           ,[MaNhanVien]
           ,[NgayLap]
           ,[TongTien])
     VALUES
           (@MaPhieuNhap 
           ,@MaNhanVien 
           ,@NgayLap 
           ,@TongTien)




GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUNHAP_UPD]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_PHIEUNHAP_UPD]
@MaPhieuNhap varchar(20)
           ,@MaNhanVien varchar(20)
           ,@NgayLap date
           ,@TongTien money
AS
UPDATE [dbo].[PHIEUNHAP]
   SET [MaNhanVien] = @MaNhanVien
      ,[NgayLap] = @NgayLap
      ,[TongTien] = @TongTien
WHERE [MaPhieuNhap] = @MaPhieuNhap

GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUXUAT_AUTOGENERATEID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUXUAT_AUTOGENERATEID]
AS
BEGIN
DECLARE @ma_next varchar(15)
DECLARE @max int
SELECT @max=COUNT(MaPhieuXuat) + 1 FROM PHIEUXUAT
SET @ma_next='PX' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
WHILE(exists(SELECT MaPhieuXuat FROM PHIEUXUAT WHERE MaPhieuXuat=@ma_next))
BEGIN
	SET @max=@max+1
	SET @ma_next='PX' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
END
SELECT 'MaPhieuXuat' = @ma_next
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUXUAT_DEL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUXUAT_DEL]
@MaPhieuXuat varchar(20)
AS
DELETE FROM [dbo].[PHIEUXUAT]
 WHERE [MaPhieuXuat] = @MaPhieuXuat
GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUXUAT_GETALL]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUXUAT_GETALL]
AS
SELECT * FROM [dbo].[PHIEUXUAT]
GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUXUAT_GETBYID]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUXUAT_GETBYID]
@MaPhieuXuat varchar(20)
AS
SELECT * FROM [dbo].[PHIEUXUAT]
  WHERE [MaPhieuXuat] = @MaPhieuXuat
GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUXUAT_INS]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUXUAT_INS]
@MaPhieuXuat varchar(20)
           ,@MaNhanVien varchar(20)
           ,@NgayLap date
           ,@NoiDungXuat nvarchar(500)
AS
INSERT INTO [dbo].[PHIEUXUAT]
           ([MaPhieuXuat]
           ,[MaNhanVien]
           ,[NgayLap]
           ,[NoiDungXuat])
     VALUES
           (@MaPhieuXuat 
           ,@MaNhanVien 
           ,@NgayLap 
           ,@NoiDungXuat)
GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUXUAT_UPD]    Script Date: 11/27/2016 10:23:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUXUAT_UPD]
@MaPhieuXuat varchar(20)
           ,@MaNhanVien varchar(20)
           ,@NgayLap date
           ,@NoiDungXuat nvarchar(500)
AS
UPDATE [dbo].[PHIEUXUAT]
   SET [MaNhanVien] = @MaNhanVien
      ,[NgayLap] = @NgayLap
      ,[NoiDungXuat] = @NoiDungXuat
WHERE [MaPhieuXuat] = @MaPhieuXuat
GO
USE [master]
GO
ALTER DATABASE [QuanLySieuThi] SET  READ_WRITE 
GO


