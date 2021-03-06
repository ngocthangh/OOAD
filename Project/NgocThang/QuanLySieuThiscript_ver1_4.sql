USE [master]
GO
/****** Object:  Database [QuanLySieuThi4]    Script Date: 12/6/2016 5:18:59 PM ******/
CREATE DATABASE [QuanLySieuThi]
GO
USE [QuanLySieuThi]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[SoHoaDon] [varchar](20) NOT NULL,
	[MaHangHoa] [varchar](20) NOT NULL,
	[DonGia] [money] NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [PK_CHITIETHOADON_1] PRIMARY KEY CLUSTERED 
(
	[SoHoaDon] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETKIEMKE]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETKIEMKE](
	[SoPhieuKiemKe] [varchar](20) NOT NULL,
	[MaHangHoa] [varchar](20) NOT NULL,
	[SLTonTrenQuay] [int] NULL,
	[SLTonTrongKho] [int] NULL,
 CONSTRAINT [PK_CHITIETKIEMKE] PRIMARY KEY CLUSTERED 
(
	[SoPhieuKiemKe] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAP](
	[SoPhieuNhap] [varchar](20) NOT NULL,
	[MaHangHoa] [varchar](20) NOT NULL,
	[MaNhaCungCap] [int] NOT NULL,
	[DonGiaNhap] [money] NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [PK_CHITIETPHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[SoPhieuNhap] ASC,
	[MaHangHoa] ASC,
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETPHIEUXUAT]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUXUAT](
	[SoPhieuXuat] [varchar](20) NOT NULL,
	[MaHangHoa] [varchar](20) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_CHITIETPHIEUXUAT] PRIMARY KEY CLUSTERED 
(
	[SoPhieuXuat] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaChucVu] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [nvarchar](100) NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHUNGLOAI]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUNGLOAI](
	[MaChungLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenChungLoai] [nvarchar](100) NULL,
 CONSTRAINT [PK_CHUNGLOAI] PRIMARY KEY CLUSTERED 
(
	[MaChungLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DONVITINH]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONVITINH](
	[MaDVT] [int] IDENTITY(1,1) NOT NULL,
	[TenDVT] [nvarchar](100) NULL,
 CONSTRAINT [PK_DONVITINH] PRIMARY KEY CLUSTERED 
(
	[MaDVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MaHangHoa] [varchar](20) NOT NULL,
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
/****** Object:  Table [dbo].[HOADON]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADON](
	[SoHoaDon] [varchar](20) NOT NULL,
	[MaNhanVien] [varchar](20) NULL,
	[NgayLap] [date] NULL,
	[MaKhachHang] [varchar](20) NULL,
	[TongTien] [money] NULL,
	[DiemThuong] [int] NULL,
	[MucGiam] [int] NULL,
 CONSTRAINT [PK_HOADON_1] PRIMARY KEY CLUSTERED 
(
	[SoHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANGTHANTHIET]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  Table [dbo].[LOAIHANG]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIHANG](
	[MaLoaiHang] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiHang] [nvarchar](100) NULL,
	[MaChungLoai] [int] NULL,
 CONSTRAINT [PK_LOAIHANG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNhaCungCap] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/6/2016 5:18:59 PM ******/
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
	[MaChucVu] [int] NULL,
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
/****** Object:  Table [dbo].[PHIEUKIEMKE]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUKIEMKE](
	[SoPhieuKiemKe] [varchar](20) NOT NULL,
	[MaNhanVien] [varchar](20) NULL,
	[NgayLap] [date] NULL,
 CONSTRAINT [PK_PHIEUKIEMKE_1] PRIMARY KEY CLUSTERED 
(
	[SoPhieuKiemKe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[SoPhieuNhap] [varchar](20) NOT NULL,
	[MaNhanVien] [varchar](20) NULL,
	[NgayLap] [date] NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_PHIEUNHAP_1] PRIMARY KEY CLUSTERED 
(
	[SoPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUXUAT]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUXUAT](
	[SoPhieuXuat] [varchar](20) NOT NULL,
	[MaNhanVien] [varchar](20) NULL,
	[NgayLap] [date] NULL,
	[NoiDungXuat] [nvarchar](500) NULL,
 CONSTRAINT [PK_PHIEUXUAT_1] PRIMARY KEY CLUSTERED 
(
	[SoPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 12/6/2016 5:18:59 PM ******/
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
INSERT [dbo].[CHITIETPHIEUNHAP] ([SoPhieuNhap], [MaHangHoa], [MaNhaCungCap], [DonGiaNhap], [SoLuong], [ThanhTien]) VALUES (N'PN0001', N'HH0001', 1, 22000000.0000, 1, 22000000.0000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([SoPhieuNhap], [MaHangHoa], [MaNhaCungCap], [DonGiaNhap], [SoLuong], [ThanhTien]) VALUES (N'PN0001', N'HH0001', 2, 22000000.0000, 2, 44000000.0000)
SET IDENTITY_INSERT [dbo].[CHUCVU] ON 

INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu]) VALUES (1, N'Nhân Viên Bán Hàng')
SET IDENTITY_INSERT [dbo].[CHUCVU] OFF
SET IDENTITY_INSERT [dbo].[CHUNGLOAI] ON 

INSERT [dbo].[CHUNGLOAI] ([MaChungLoai], [TenChungLoai]) VALUES (1, N'Hàng điện tử')
SET IDENTITY_INSERT [dbo].[CHUNGLOAI] OFF
SET IDENTITY_INSERT [dbo].[DONVITINH] ON 

INSERT [dbo].[DONVITINH] ([MaDVT], [TenDVT]) VALUES (1, N'Ký')
INSERT [dbo].[DONVITINH] ([MaDVT], [TenDVT]) VALUES (2, N'Cái')
SET IDENTITY_INSERT [dbo].[DONVITINH] OFF
INSERT [dbo].[HANGHOA] ([MaHangHoa], [TenHangHoa], [GiaMua], [GiaBan], [NgaySanXuat], [HanSuDung], [SoLuongNhap], [SoLuongBan], [NgayNhap], [VAT], [MaLoaiHang], [MaDVT]) VALUES (N'HH0001', N'Samsung Galaxy S8', 22000000.0000, 23000000.0000, CAST(N'2015-01-05' AS Date), CAST(N'2020-03-04' AS Date), 200, 0, CAST(N'2016-02-05' AS Date), 10, 1, 2)
SET IDENTITY_INSERT [dbo].[LOAIHANG] ON 

INSERT [dbo].[LOAIHANG] ([MaLoaiHang], [TenLoaiHang], [MaChungLoai]) VALUES (1, N'Điện thoại', 1)
INSERT [dbo].[LOAIHANG] ([MaLoaiHang], [TenLoaiHang], [MaChungLoai]) VALUES (2, N'Máy tính', 1)
SET IDENTITY_INSERT [dbo].[LOAIHANG] OFF
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] ON 

INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai]) VALUES (1, N'Thế giới di động', N'TP. Hồ Chí Minh', N'0987474837')
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai]) VALUES (2, N'FPT', N'Hà Nội', N'0164338443')
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] OFF
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTen], [NgaySinh], [GioiTinh], [CMND], [DiaChi], [DienThoai], [NgayVaoLam], [MaChucVu], [TenDangNhap], [MatKhau]) VALUES (N'NV0001', N'Nguyễn Văn A', CAST(N'1994-03-06' AS Date), N'Nam', N'215356789', N'Dĩ An - Bình Dương', N'0987654321', CAST(N'2000-05-11' AS Date), 1, N'nguyenvana', N'123456')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTen], [NgaySinh], [GioiTinh], [CMND], [DiaChi], [DienThoai], [NgayVaoLam], [MaChucVu], [TenDangNhap], [MatKhau]) VALUES (N'NV0003', N'Huỳnh Ngọc Thắng', CAST(N'1995-08-20' AS Date), N'Nam', N'215352284', N'An Nhơn - Bình Định', N'0972516794', CAST(N'2017-01-23' AS Date), 1, N'ngocthangh', N'12345')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTen], [NgaySinh], [GioiTinh], [CMND], [DiaChi], [DienThoai], [NgayVaoLam], [MaChucVu], [TenDangNhap], [MatKhau]) VALUES (N'NV0004', N'Trần CD', CAST(N'2016-11-16' AS Date), N'Khác', N'2344344334', N'tp Hồ Chí Minh', N'938837371', CAST(N'2016-11-18' AS Date), 1, N'ccccccaa', N'tttttttttt')
INSERT [dbo].[PHIEUNHAP] ([SoPhieuNhap], [MaNhanVien], [NgayLap], [TongTien]) VALUES (N'PN0001', N'NV0001', CAST(N'2016-12-06' AS Date), 66000000.0000)
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK__CHITIETHO__MaHan__2F10007B] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HANGHOA] ([MaHangHoa])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK__CHITIETHO__MaHan__2F10007B]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD FOREIGN KEY([SoHoaDon])
REFERENCES [dbo].[HOADON] ([SoHoaDon])
GO
ALTER TABLE [dbo].[CHITIETKIEMKE]  WITH CHECK ADD  CONSTRAINT [FK__CHITIETKI__MaHan__30F848ED] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HANGHOA] ([MaHangHoa])
GO
ALTER TABLE [dbo].[CHITIETKIEMKE] CHECK CONSTRAINT [FK__CHITIETKI__MaHan__30F848ED]
GO
ALTER TABLE [dbo].[CHITIETKIEMKE]  WITH CHECK ADD FOREIGN KEY([SoPhieuKiemKe])
REFERENCES [dbo].[PHIEUKIEMKE] ([SoPhieuKiemKe])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK__CHITIETPH__MaHan__44CA3770] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HANGHOA] ([MaHangHoa])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK__CHITIETPH__MaHan__44CA3770]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK__CHITIETPH__MaNha__32E0915F] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NHACUNGCAP] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK__CHITIETPH__MaNha__32E0915F]
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK__CHITIETPH__MaHan__34C8D9D1] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HANGHOA] ([MaHangHoa])
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT] CHECK CONSTRAINT [FK__CHITIETPH__MaHan__34C8D9D1]
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([SoPhieuXuat])
REFERENCES [dbo].[PHIEUXUAT] ([SoPhieuXuat])
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK__HANGHOA__MaDVT__36B12243] FOREIGN KEY([MaDVT])
REFERENCES [dbo].[DONVITINH] ([MaDVT])
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [FK__HANGHOA__MaDVT__36B12243]
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK__HANGHOA__MaLoaiH__37A5467C] FOREIGN KEY([MaLoaiHang])
REFERENCES [dbo].[LOAIHANG] ([MaLoaiHang])
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [FK__HANGHOA__MaLoaiH__37A5467C]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK__HOADON__MaKhachH__38996AB5] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANGTHANTHIET] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK__HOADON__MaKhachH__38996AB5]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK__HOADON__MaNhanVi__398D8EEE] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK__HOADON__MaNhanVi__398D8EEE]
GO
ALTER TABLE [dbo].[LOAIHANG]  WITH CHECK ADD FOREIGN KEY([MaChungLoai])
REFERENCES [dbo].[CHUNGLOAI] ([MaChungLoai])
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK__NHANVIEN__MaChuc__3B75D760] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[CHUCVU] ([MaChucVu])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK__NHANVIEN__MaChuc__3B75D760]
GO
ALTER TABLE [dbo].[PHIEUKIEMKE]  WITH CHECK ADD  CONSTRAINT [FK__PHIEUKIEM__MaNha__3C69FB99] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUKIEMKE] CHECK CONSTRAINT [FK__PHIEUKIEM__MaNha__3C69FB99]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK__PHIEUNHAP__MaNha__3D5E1FD2] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK__PHIEUNHAP__MaNha__3D5E1FD2]
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK__PHIEUXUAT__MaNha__3E52440B] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [FK__PHIEUXUAT__MaNha__3E52440B]
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETHOADON_DEL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETHOADON_DEL]
@SoHoaDon varchar(20) 
AS
DELETE FROM [dbo].[CHITIETHOADON]
 WHERE [SoHoaDon] = @SoHoaDon

GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETHOADON_GETALL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHITIETHOADON_GETALL]
AS
SELECT * FROM [dbo].[CHITIETHOADON]




GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETHOADON_GETBYID]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHITIETHOADON_GETBYID]
@SoHoaDon varchar(20) 
AS
SELECT * FROM [dbo].[CHITIETHOADON]
 WHERE [SoHoaDon] = @SoHoaDon

GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETHOADON_INS]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETHOADON_INS]
			@SoHoaDon varchar(20) 
           ,@MaHangHoa varchar(20) 
           ,@DonGia money
           ,@SoLuong int  
		   ,@ThanhTien money
AS
INSERT INTO [dbo].[CHITIETHOADON]
           ([SoHoaDon]
		   ,[MaHangHoa]
		   ,[DonGia]
		   ,[SoLuong]
		   ,[ThanhTien])
     VALUES
           (@SoHoaDon
		   ,@MaHangHoa
		   ,@DonGia
		   ,@SoLuong
		   ,@ThanhTien)
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETHOADON_UPD]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETHOADON_UPD]
            @SoHoaDon varchar(20) 
           ,@MaHangHoa varchar(20) 
		   ,@DonGia money
           ,@SoLuong int  
		   ,@ThanhTien money
AS
UPDATE [dbo].[CHITIETHOADON]
   SET 
       [MaHangHoa] = @MaHangHoa
      ,[SoLuong] = @SoLuong
	  ,[DonGia] = @DonGia
	  ,[ThanhTien] = @ThanhTien
 WHERE [SoHoaDon] = @SoHoaDon
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETKIEMKE_DEL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETKIEMKE_DEL]
@SoPhieuKiemKe varchar(20)
AS
DELETE FROM [dbo].[CHITIETKIEMKE]
 WHERE [SoPhieuKiemKe] = @SoPhieuKiemKe
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETKIEMKE_GETALL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETKIEMKE_GETALL]
AS
SELECT * FROM [dbo].[CHITIETKIEMKE]



GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETKIEMKE_GETBYID]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETKIEMKE_GETBYID]
@SoPhieuKiemKe varchar(20)
AS
SELECT * FROM [dbo].[CHITIETKIEMKE]
  WHERE [SoPhieuKiemKe] = @SoPhieuKiemKe
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETKIEMKE_INS]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETKIEMKE_INS]
@SoPhieuKiemKe varchar(20)
           ,@MaHangHoa varchar(20)
		   ,@SLTonTrenQuay int
           ,@SLTonTrongKho int
AS
INSERT INTO [dbo].[CHITIETKIEMKE]
           ([SoPhieuKiemKe]
           ,[MaHangHoa]
		   ,[SLTonTrenQuay]
           ,[SLTonTrongKho])
     VALUES
           (@SoPhieuKiemKe 
           ,@MaHangHoa 
		   ,@SLTonTrenQuay
           ,@SLTonTrongKho)

GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETKIEMKE_UPD]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETKIEMKE_UPD]
@SoPhieuKiemKe varchar(20)
           ,@MaHangHoa varchar(20)
		   ,@SLTonTrenQuay int
           ,@SLTonTrongKho int
AS
UPDATE [dbo].[CHITIETKIEMKE]
   SET SLTonTrongKho = @SLTonTrongKho,
   SLTonTrenQuay = @SLTonTrenQuay
WHERE [SoPhieuKiemKe] = @SoPhieuKiemKe AND [MaHangHoa] = @MaHangHoa

GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUNHAP_DEL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETPHIEUNHAP_DEL]
@SoPhieuNhap varchar(20)
AS
DELETE FROM [dbo].[CHITIETPHIEUNHAP]
 WHERE [SoPhieuNhap] = @SoPhieuNhap
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUNHAP_GETALL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETPHIEUNHAP_GETALL]
AS
SELECT * FROM [dbo].[CHITIETPHIEUNHAP]


GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUNHAP_GETBYID]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETPHIEUNHAP_GETBYID]
@SoPhieuNhap varchar(20)
AS
SELECT * FROM [dbo].[CHITIETPHIEUNHAP]
  WHERE [SoPhieuNhap] = @SoPhieuNhap
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUNHAP_INS]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETPHIEUNHAP_INS]
@SoPhieuNhap varchar(20)
           ,@MaHangHoa varchar(20)
		   ,@MaNhaCungCap varchar(20)
           ,@DonGiaNhap money
           ,@SoLuong int
		   ,@ThanhTien money
AS
INSERT INTO [dbo].[CHITIETPHIEUNHAP]
           ([SoPhieuNhap]
           ,[MaHangHoa]
		   ,[MaNhaCungCap]
		   ,[DonGiaNhap]
           ,[SoLuong]
		   ,[ThanhTien])
     VALUES
           (@SoPhieuNhap 
           ,@MaHangHoa 
		   ,@MaNhaCungCap
		   ,@DonGiaNhap
           ,@SoLuong
		   ,@ThanhTien)
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUNHAP_UPD]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETPHIEUNHAP_UPD]
@SoPhieuNhap varchar(20)
           ,@MaHangHoa varchar(20)
		   ,@MaNhaCungCap varchar(20)
		   ,@DonGiaNhap money
           ,@SoLuong int
		   ,@ThanhTien money
AS
UPDATE [dbo].[CHITIETPHIEUNHAP]
   SET SoLuong = @SoLuong,
   MaNhaCungCap = @MaNhaCungCap,
   DonGiaNhap = @DonGiaNhap,
   ThanhTien = @ThanhTien
WHERE [SoPhieuNhap] = @SoPhieuNhap AND [MaHangHoa] = @MaHangHoa
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUXUAT_DEL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETPHIEUXUAT_DEL]
@SoPhieuXuat varchar(20)
AS
DELETE FROM [dbo].[CHITIETPHIEUXUAT]
 WHERE [SoPhieuXuat] = @SoPhieuXuat
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUXUAT_GETALL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHITIETPHIEUXUAT_GETALL]
AS
SELECT * FROM [dbo].[CHITIETPHIEUXUAT]



GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUXUAT_GETBYID]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETPHIEUXUAT_GETBYID]
@SoPhieuXuat varchar(20)
AS
SELECT * FROM [dbo].[CHITIETPHIEUXUAT]
  WHERE [SoPhieuXuat] = @SoPhieuXuat
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUXUAT_INS]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETPHIEUXUAT_INS]
@SoPhieuXuat varchar(20)
           ,@MaHangHoa varchar(20)
           ,@SoLuong int
AS
INSERT INTO [dbo].[CHITIETPHIEUXUAT]
           ([SoPhieuXuat]
           ,[MaHangHoa]
           ,[SoLuong])
     VALUES
           (@SoPhieuXuat 
           ,@MaHangHoa 
           ,@SoLuong)
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETPHIEUXUAT_UPD]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETPHIEUXUAT_UPD]
@SoPhieuXuat varchar(20)
           ,@MaHangHoa varchar(20)
           ,@SoLuong int
AS
UPDATE [dbo].[CHITIETPHIEUXUAT]
   SET SoLuong = @SoLuong
WHERE [SoPhieuXuat] = @SoPhieuXuat AND [MaHangHoa] = @MaHangHoa
GO
/****** Object:  StoredProcedure [dbo].[SP_CHUCVU_AUTOGENERATEID]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CHUCVU_DEL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHUCVU_DEL]
@MaChucVu int
AS
DELETE FROM [dbo].[CHUCVU]
 WHERE [MaChucVu] = @MaChucVu

GO
/****** Object:  StoredProcedure [dbo].[SP_CHUCVU_GETALL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHUCVU_GETALL]
AS
SELECT * FROM [dbo].[CHUCVU]




GO
/****** Object:  StoredProcedure [dbo].[SP_CHUCVU_GETBYID]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHUCVU_GETBYID]
@MaChucVu int
AS
SELECT * FROM [dbo].[CHUCVU]
 WHERE [MaChucVu] = @MaChucVu

GO
/****** Object:  StoredProcedure [dbo].[SP_CHUCVU_INS]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHUCVU_INS]
			
           @TenChucVu nvarchar(100) 
AS
INSERT INTO [dbo].[CHUCVU]
           (
           [TenChucVu])
     VALUES
           (
           @TenChucVu)

GO
/****** Object:  StoredProcedure [dbo].[SP_CHUCVU_UPD]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHUCVU_UPD]
			@MaChucVu int 
           ,@TenChucVu nvarchar(100) 
AS
UPDATE [dbo].[CHUCVU]
   SET 
      [TenChucVu] = @TenChucVu
 WHERE [MaChucVu] = @MaChucVu


GO
/****** Object:  StoredProcedure [dbo].[SP_CHUNGLOAI_AUTOGENERATEID]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CHUNGLOAI_DEL]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CHUNGLOAI_GETALL]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CHUNGLOAI_GETBYID]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CHUNGLOAI_INS]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CHUNGLOAI_UPD]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_DONVITINH_AUTOGENERATEID]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_DONVITINH_DEL]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_DONVITINH_GETALL]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_DONVITINH_GETBYID]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_DONVITINH_INS]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_DONVITINH_UPD]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_HANGHOA_AUTOGENERATEID]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_HANGHOA_DEL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_HANGHOA_DEL]
	@MaHangHoa varchar(20)
AS
BEGIN
	DELETE FROM HANGHOA
	WHERE MaHangHoa = @MaHangHoa
END


GO
/****** Object:  StoredProcedure [dbo].[SP_HANGHOA_GETALL]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_HANGHOA_GETBYID]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_HANGHOA_GETBYID]
	@MaHangHoa varchar(20)
AS
BEGIN
	SELECT * FROM HANGHOA WHERE MaHangHoa = @MaHangHoa
END


GO
/****** Object:  StoredProcedure [dbo].[SP_HANGHOA_INS]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_HANGHOA_INS]
	@MaHangHoa varchar(20),
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
/****** Object:  StoredProcedure [dbo].[SP_HANGHOA_SEARCH]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_HANGHOA_SEARCH]
	@key nvarchar(50)
AS
declare @searchkey nvarchar(55);
set @searchkey = '%' + @key + '%';
	SELECT * from HANGHOA HH 
	INNER JOIN LOAIHANG LH ON HH.MaLoaiHang = LH.MaLoaiHang
	INNER JOIN DONVITINH DVT ON HH.MaDVT = DVT.MaDVT
	WHERE MaHangHoa like @key or TenHangHoa like @searchkey or GiaMua like @searchkey
		or GiaBan like @searchkey or SoLuongNhap like @key or SoLuongBan like @key or VAT like @key
		or TenLoaiHang like @searchkey or TenDVT like @searchkey


GO
/****** Object:  StoredProcedure [dbo].[SP_HANGHOA_UPD]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_HANGHOA_UPD]
	@MaHangHoa varchar(20),
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
		VAT = @VAT,
		MaDVT = @MaDVT,
		MaLoaiHang = @MaLoaiHang
	WHERE MaHangHoa = @MaHangHoa 
END

GO
/****** Object:  StoredProcedure [dbo].[SP_HOADON_AUTOGENERATEID]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_HOADON_AUTOGENERATEID]
AS
BEGIN
DECLARE @ma_next varchar(15)
DECLARE @max int
SELECT @max=COUNT(SoHoaDon) + 1 FROM HOADON
SET @ma_next='HD' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
WHILE(exists(SELECT SoHoaDon FROM HOADON WHERE SoHoaDon=@ma_next))
BEGIN
	SET @max=@max+1
	SET @ma_next='HD' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
END
SELECT 'SoHoaDon' = @ma_next
END
GO
/****** Object:  StoredProcedure [dbo].[SP_HOADON_DEL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_HOADON_DEL]
@SoHoaDon varchar(20)
AS
DELETE FROM [dbo].[HOADON]
 WHERE [SoHoaDon] = @SoHoaDon
GO
/****** Object:  StoredProcedure [dbo].[SP_HOADON_GETALL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_HOADON_GETALL]
AS
SELECT * FROM [dbo].[HOADON]




GO
/****** Object:  StoredProcedure [dbo].[SP_HOADON_GETBYID]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_HOADON_GETBYID]
@SoHoaDon varchar(20)
AS
SELECT * FROM [dbo].[HOADON]
 WHERE [SoHoaDon] = @SoHoaDon
GO
/****** Object:  StoredProcedure [dbo].[SP_HOADON_INS]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_HOADON_INS]
            @SoHoaDon varchar(20) 
           ,@MaNhanVien varchar(20)  
           ,@NgayLap date 
           ,@MaKhachHang varchar(20) 
           ,@TongTien money 
           ,@DiemThuong int 
           ,@MucGiam int 
AS
INSERT INTO [dbo].[HOADON]
           ([SoHoaDon]
           ,[MaNhanVien]
           ,[NgayLap]
           ,[MaKhachHang]
           ,[TongTien]
           ,[DiemThuong]
           ,[MucGiam])
     VALUES
           (@SoHoaDon  
           ,@MaNhanVien 
           ,@NgayLap
           ,@MaKhachHang 
           ,@TongTien 
           ,@DiemThuong 
           ,@MucGiam)


GO
/****** Object:  StoredProcedure [dbo].[SP_HOADON_UPD]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_HOADON_UPD]
			@SoHoaDon varchar(20) 
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
 WHERE [SoHoaDon] = @SoHoaDon
GO
/****** Object:  StoredProcedure [dbo].[SP_KHACHHANGTHANTHIET_AUTOGENERATEID]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_KHACHHANGTHANTHIET_DEL]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_KHACHHANGTHANTHIET_GETALL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_KHACHHANGTHANTHIET_GETALL]
AS
SELECT * FROM [dbo].[KHACHHANGTHANTHIET]




GO
/****** Object:  StoredProcedure [dbo].[SP_KHACHHANGTHANTHIET_GETBYID]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_KHACHHANGTHANTHIET_INS]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_KHACHHANGTHANTHIET_UPD]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_LOAIHANG_AUTOGENERATEID]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_LOAIHANG_DEL]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_LOAIHANG_GETALL]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_LOAIHANG_GETBYID]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_LOAIHANG_INS]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_LOAIHANG_UPD]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_NHACUNGCAP_AUTOGENERATEID]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_NHACUNGCAP_DEL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_NHACUNGCAP_DEL]
	@MaNhaCungCap int
AS
BEGIN
	DELETE FROM NHACUNGCAP
	WHERE MaNhaCungCap = @MaNhaCungCap
END


GO
/****** Object:  StoredProcedure [dbo].[SP_NHACUNGCAP_GETALL]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_NHACUNGCAP_GETBYID]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_NHACUNGCAP_GETBYID]
	@MaNhaCungCap int
AS
BEGIN
	SELECT * FROM NHACUNGCAP
	WHERE MaNhaCungCap = @MaNhaCungCap
END


GO
/****** Object:  StoredProcedure [dbo].[SP_NHACUNGCAP_INS]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_NHACUNGCAP_INS]
	
	@TenNhaCungCap nvarchar(100),
	@DiaChi nvarchar(100),
	@DienThoai varchar(20)
AS
BEGIN
	INSERT INTO NHACUNGCAP(
		
		TenNhaCungCap,
		DiaChi,
		DienThoai)
	VALUES(
		
		@TenNhaCungCap,
		@DiaChi,
		@DienThoai)
END


GO
/****** Object:  StoredProcedure [dbo].[SP_NHACUNGCAP_UPD]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_NHACUNGCAP_UPD]
	@MaNhaCungCap int,
	@TenNhaCungCap nvarchar(100),
	@DiaChi nvarchar(500),
	@DienThoai varchar(20)
AS
BEGIN
	UPDATE NHACUNGCAP
	SET
		TenNhaCungCap = @TenNhaCungCap,
		DiaChi = @DiaChi,
		DienThoai = @DienThoai
	WHERE MaNhaCungCap = @MaNhaCungCap
END

GO
/****** Object:  StoredProcedure [dbo].[SP_NHANVIEN_AUTOGENERATEID]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_NHANVIEN_DEL]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_NHANVIEN_GETALL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_NHANVIEN_GETALL]
AS
SELECT * FROM NHANVIEN NV INNER JOIN CHUCVU CV ON NV.MaChucVu = CV.MaChucVu


GO
/****** Object:  StoredProcedure [dbo].[SP_NHANVIEN_GETBYID]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_NHANVIEN_INS]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_NHANVIEN_SEARCH]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_NHANVIEN_UPD]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_PHIEUKIEMKE_AUTOGENERATEID]    Script Date: 12/6/2016 5:18:59 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_PHIEUKIEMKE_DEL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_PHIEUKIEMKE_DEL]
@SoPhieuKiemKe varchar(20) 
AS
DELETE FROM [dbo].[PHIEUKIEMKE]
 WHERE [SoPhieuKiemKe] = @SoPhieuKiemKe




GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUKIEMKE_GETALL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_PHIEUKIEMKE_GETALL]
AS
SELECT * FROM [dbo].[PHIEUKIEMKE]




GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUKIEMKE_GETBYID]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUKIEMKE_GETBYID]
@SoPhieuKiemKe varchar(20) 
AS
SELECT * FROM [dbo].[PHIEUKIEMKE]
 WHERE [SoPhieuKiemKe] = @SoPhieuKiemKe

GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUKIEMKE_INS]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUKIEMKE_INS]
            @SoPhieuKiemKe varchar(20) 
           ,@MaNhanVien varchar(20) 
           ,@NgayLap date 
AS
INSERT INTO [dbo].[PHIEUKIEMKE]
           ([SoPhieuKiemKe]
           ,[MaNhanVien]
           ,[NgayLap])          
     VALUES
           (@SoPhieuKiemKe
           ,@MaNhanVien
           ,@NgayLap)

GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUKIEMKE_UPD]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_PHIEUKIEMKE_UPD]
            @SoPhieuKiemKe varchar(20) 
           ,@MaNhanVien varchar(20) 
           ,@NgayLap date 
AS
UPDATE [dbo].[PHIEUKIEMKE]
   SET 
      [MaNhanVien] = @MaNhanVien
      ,[NgayLap] = @NgayLap
 WHERE [SoPhieuKiemKe] = @SoPhieuKiemKe
GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUNHAP_AUTOGENERATEID]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUNHAP_AUTOGENERATEID]
AS
BEGIN
DECLARE @ma_next varchar(15)
DECLARE @max int
SELECT @max=COUNT(SoPhieuNhap) + 1 FROM PHIEUNHAP
SET @ma_next='PN' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
WHILE(exists(SELECT SoPhieuNhap FROM PHIEUNHAP WHERE SoPhieuNhap=@ma_next))
BEGIN
	SET @max=@max+1
	SET @ma_next='PN' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
END
SELECT 'SoPhieuNhap' = @ma_next
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUNHAP_DEL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUNHAP_DEL]
@SoPhieuNhap varchar(20)
AS
DELETE FROM [dbo].[PHIEUNHAP]
 WHERE [SoPhieuNhap] = @SoPhieuNhap
GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUNHAP_GETALL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_PHIEUNHAP_GETALL]
AS
SELECT * FROM [dbo].[PHIEUNHAP]




GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUNHAP_GETBYID]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUNHAP_GETBYID]
@SoPhieuNhap varchar(20)
AS
SELECT * FROM [dbo].[PHIEUNHAP]
  WHERE [SoPhieuNhap] = @SoPhieuNhap
GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUNHAP_INS]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUNHAP_INS]
@SoPhieuNhap varchar(20)
           ,@MaNhanVien varchar(20)
           ,@NgayLap date
           ,@TongTien money
AS
INSERT INTO [dbo].[PHIEUNHAP]
           ([SoPhieuNhap]
           ,[MaNhanVien]
           ,[NgayLap]
           ,[TongTien])
     VALUES
           (@SoPhieuNhap 
           ,@MaNhanVien 
           ,@NgayLap 
           ,@TongTien)
GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUNHAP_UPD]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUNHAP_UPD]
@SoPhieuNhap varchar(20)
           ,@MaNhanVien varchar(20)
           ,@NgayLap date
           ,@TongTien money
AS
UPDATE [dbo].[PHIEUNHAP]
   SET [MaNhanVien] = @MaNhanVien
      ,[NgayLap] = @NgayLap
      ,[TongTien] = @TongTien
WHERE [SoPhieuNhap] = @SoPhieuNhap

GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUXUAT_AUTOGENERATEID]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUXUAT_AUTOGENERATEID]
AS
BEGIN
DECLARE @ma_next varchar(15)
DECLARE @max int
SELECT @max=COUNT(SoPhieuXuat) + 1 FROM PHIEUXUAT
SET @ma_next='PX' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
WHILE(exists(SELECT SoPhieuXuat FROM PHIEUXUAT WHERE SoPhieuXuat=@ma_next))
BEGIN
	SET @max=@max+1
	SET @ma_next='PX' + RIGHT('0000' + CAST(@max AS VARCHAR(15)), 4)
END
SELECT 'SoPhieuXuat' = @ma_next
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUXUAT_DEL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUXUAT_DEL]
@SoPhieuXuat varchar(20)
AS
DELETE FROM [dbo].[PHIEUXUAT]
 WHERE [SoPhieuXuat] = @SoPhieuXuat
GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUXUAT_GETALL]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUXUAT_GETALL]
AS
SELECT * FROM [dbo].[PHIEUXUAT]


GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUXUAT_GETBYID]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUXUAT_GETBYID]
@SoPhieuXuat varchar(20)
AS
SELECT * FROM [dbo].[PHIEUXUAT]
  WHERE [SoPhieuXuat] = @SoPhieuXuat
GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUXUAT_INS]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUXUAT_INS]
@SoPhieuXuat varchar(20)
           ,@MaNhanVien varchar(20)
           ,@NgayLap date
           ,@NoiDungXuat nvarchar(500)
AS
INSERT INTO [dbo].[PHIEUXUAT]
           ([SoPhieuXuat]
           ,[MaNhanVien]
           ,[NgayLap]
           ,[NoiDungXuat])
     VALUES
           (@SoPhieuXuat 
           ,@MaNhanVien 
           ,@NgayLap 
           ,@NoiDungXuat)

GO
/****** Object:  StoredProcedure [dbo].[SP_PHIEUXUAT_UPD]    Script Date: 12/6/2016 5:18:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PHIEUXUAT_UPD]
@SoPhieuXuat varchar(20)
           ,@MaNhanVien varchar(20)
           ,@NgayLap date
           ,@NoiDungXuat nvarchar(500)
AS
UPDATE [dbo].[PHIEUXUAT]
   SET [MaNhanVien] = @MaNhanVien
      ,[NgayLap] = @NgayLap
      ,[NoiDungXuat] = @NoiDungXuat
WHERE [SoPhieuXuat] = @SoPhieuXuat

GO
USE [master]
GO
ALTER DATABASE [QuanLySieuThi4] SET  READ_WRITE 
GO
