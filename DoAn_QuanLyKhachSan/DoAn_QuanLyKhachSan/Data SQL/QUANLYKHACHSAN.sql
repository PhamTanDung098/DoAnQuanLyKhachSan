CREATE DATABASE [QUANLYKHACHSAN]
GO
USE [QUANLYKHACHSAN]
GO
/****** Object:  Database [QUANLYKHACHSAN]    Script Date: 11/6/2018 3:20:51 AM ******/
CREATE DATABASE [QUANLYKHACHSAN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYKHACHSAN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QUANLYKHACHSAN.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QUANLYKHACHSAN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QUANLYKHACHSAN_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QUANLYKHACHSAN] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYKHACHSAN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYKHACHSAN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYKHACHSAN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYKHACHSAN] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QUANLYKHACHSAN]
GO
/****** Object:  Table [dbo].[BoTri]    Script Date: 11/6/2018 3:20:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoTri](
	[MaVatTu] [nchar](10) NOT NULL,
	[MaLoai] [nchar](10) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_BoTri] PRIMARY KEY CLUSTERED 
(
	[MaVatTu] ASC,
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhSachPhong]    Script Date: 11/6/2018 3:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachPhong](
	[MaPhong] [nchar](10) NOT NULL,
	[TinhTrang] [bit] NULL,
	[MaLoai] [nchar](10) NULL,
 CONSTRAINT [PK_DanhSachPhong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 11/6/2018 3:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaPhong] [nchar](10) NOT NULL,
	[MaDichVu] [nchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[NgaySuDung] [date] NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC,
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/6/2018 3:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [nchar](10) NOT NULL,
	[NgayThanhToan] [date] NULL,
	[TongTien] [int] NULL,
	[MaPhong] [nchar](10) NULL,
	[MaKhachHang] [nchar](10) NULL,
	[ThuNgan] [nchar](10) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 11/6/2018 3:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKhachHang] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[CMND] [nchar](15) NULL,
	[SDT] [nchar](15) NULL,
	[NgayThue] [date] NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiDichVu]    Script Date: 11/6/2018 3:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDichVu](
	[MaDV] [nchar](10) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[DonViTinh] [nchar](10) NULL,
 CONSTRAINT [PK_LoaiDichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 11/6/2018 3:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[MaLoai] [nchar](10) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_LoaiPhong] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: 11/6/2018 3:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[ID] [nchar](10) NOT NULL,
	[Name] [nchar](10) NULL,
	[PassWord] [nchar](10) NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThuePhong]    Script Date: 11/6/2018 3:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuePhong](
	[MaPhong] [nchar](10) NOT NULL,
	[MaKhachHang] [nchar](10) NOT NULL,
	[NgayThue] [date] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ThuePhong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC,
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VatTu]    Script Date: 11/6/2018 3:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VatTu](
	[MaVatTu] [nchar](10) NOT NULL,
	[TenVatTu] [nvarchar](50) NULL,
 CONSTRAINT [PK_VatTu] PRIMARY KEY CLUSTERED 
(
	[MaVatTu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'DEP       ', N'BD1       ', 2)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'DEP       ', N'BD2       ', 4)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'DEP       ', N'VIP1      ', 2)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'DEP       ', N'VIP2      ', 4)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'ML        ', N'VIP1      ', 2)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'ML        ', N'VIP2      ', 1)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'QM        ', N'BD1       ', 1)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'QM        ', N'BD2       ', 2)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'TL        ', N'VIP2      ', 2)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'TV        ', N'BD1       ', 1)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'TV        ', N'BD2       ', 1)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'TV        ', N'VIP1      ', 1)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'TV        ', N'VIP2      ', 1)
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'P101      ', 1, N'BD1       ')
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'P102      ', 1, N'BD1       ')
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'P103      ', 0, N'BD1       ')
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'P104      ', 0, N'BD2       ')
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'P105      ', 0, N'BD2       ')
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'P201      ', 1, N'VIP1      ')
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'P202      ', 0, N'VIP1      ')
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'P203      ', 1, N'VIP1      ')
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'P204      ', 0, N'VIP2      ')
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'P205      ', 0, N'VIP2      ')
INSERT [dbo].[DichVu] ([MaPhong], [MaDichVu], [SoLuong], [NgaySuDung]) VALUES (N'P101      ', N'DV1       ', 1, CAST(N'2018-11-05' AS Date))
INSERT [dbo].[DichVu] ([MaPhong], [MaDichVu], [SoLuong], [NgaySuDung]) VALUES (N'P101      ', N'DV2       ', 6, CAST(N'2018-11-30' AS Date))
INSERT [dbo].[DichVu] ([MaPhong], [MaDichVu], [SoLuong], [NgaySuDung]) VALUES (N'P101      ', N'DV4       ', 3, CAST(N'2018-11-05' AS Date))
INSERT [dbo].[DichVu] ([MaPhong], [MaDichVu], [SoLuong], [NgaySuDung]) VALUES (N'P102      ', N'DV2       ', 5, CAST(N'2018-11-30' AS Date))
INSERT [dbo].[DichVu] ([MaPhong], [MaDichVu], [SoLuong], [NgaySuDung]) VALUES (N'P102      ', N'DV3       ', 6, CAST(N'2018-11-30' AS Date))
INSERT [dbo].[DichVu] ([MaPhong], [MaDichVu], [SoLuong], [NgaySuDung]) VALUES (N'P104      ', N'DV1       ', 1, CAST(N'2018-11-05' AS Date))
INSERT [dbo].[DichVu] ([MaPhong], [MaDichVu], [SoLuong], [NgaySuDung]) VALUES (N'P104      ', N'DV3       ', 1, CAST(N'2018-11-05' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayThanhToan], [TongTien], [MaPhong], [MaKhachHang], [ThuNgan]) VALUES (N'HD1       ', CAST(N'2018-11-05' AS Date), 1050000, N'P102      ', N'KH2       ', N'          ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayThanhToan], [TongTien], [MaPhong], [MaKhachHang], [ThuNgan]) VALUES (N'HD2       ', CAST(N'2018-11-05' AS Date), 320000, N'P101      ', N'KH1       ', N'          ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayThanhToan], [TongTien], [MaPhong], [MaKhachHang], [ThuNgan]) VALUES (N'HD3       ', CAST(N'2018-11-05' AS Date), 170000, N'P104      ', N'KH4       ', N'          ')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTen], [CMND], [SDT], [NgayThue]) VALUES (N'KH1       ', N'Nguyễn Văn A', N'123456789      ', N'123456789      ', CAST(N'2018-11-04' AS Date))
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTen], [CMND], [SDT], [NgayThue]) VALUES (N'KH2       ', N'Lê Văn Tèo', N'123432542      ', N'535236531      ', CAST(N'2018-10-28' AS Date))
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTen], [CMND], [SDT], [NgayThue]) VALUES (N'KH3       ', N'Nguyễn Văn B', N'986245367      ', N'0167251746     ', CAST(N'2018-11-05' AS Date))
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTen], [CMND], [SDT], [NgayThue]) VALUES (N'KH4       ', N'Nguyễn Văn A', N'321421434      ', N'0987674765     ', CAST(N'2018-11-05' AS Date))
INSERT [dbo].[LoaiDichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'DV1       ', N'Cơm gà', 20000, N'phần      ')
INSERT [dbo].[LoaiDichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'DV2       ', N'xông hơi', 50000, N'lượt      ')
INSERT [dbo].[LoaiDichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'DV3       ', N'massage', 150000, N'lượt      ')
INSERT [dbo].[LoaiDichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'DV4       ', N'nước uống', 15000, N'chai      ')
INSERT [dbo].[LoaiDichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'DV5       ', N'Snack', 5000, N'gói       ')
INSERT [dbo].[LoaiDichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'DV6       ', N'Tắm nước nóng', 30000, N'phần      ')
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai], [DonGia], [SoLuong]) VALUES (N'BD1       ', N'Phòng thường đơn', 100000, 2)
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai], [DonGia], [SoLuong]) VALUES (N'BD2       ', N'Phòng thường đôi', 160000, 4)
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai], [DonGia], [SoLuong]) VALUES (N'VIP1      ', N'Phòng VIP đơn', 250000, 2)
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai], [DonGia], [SoLuong]) VALUES (N'VIP2      ', N'Phòng VIP đôi', 300000, 4)
INSERT [dbo].[Login] ([ID], [Name], [PassWord]) VALUES (N'ID01      ', N'admin     ', N'1         ')
INSERT [dbo].[Login] ([ID], [Name], [PassWord]) VALUES (N'ID02      ', N'user      ', N'2         ')
INSERT [dbo].[ThuePhong] ([MaPhong], [MaKhachHang], [NgayThue], [SoLuong]) VALUES (N'P101      ', N'KH3       ', CAST(N'2018-11-05' AS Date), 1)
INSERT [dbo].[ThuePhong] ([MaPhong], [MaKhachHang], [NgayThue], [SoLuong]) VALUES (N'P102      ', N'KH1       ', CAST(N'2018-11-04' AS Date), 2)
INSERT [dbo].[ThuePhong] ([MaPhong], [MaKhachHang], [NgayThue], [SoLuong]) VALUES (N'P201      ', N'KH2       ', CAST(N'2018-11-03' AS Date), 4)
INSERT [dbo].[ThuePhong] ([MaPhong], [MaKhachHang], [NgayThue], [SoLuong]) VALUES (N'P203      ', N'KH4       ', CAST(N'2018-11-02' AS Date), 2)
INSERT [dbo].[VatTu] ([MaVatTu], [TenVatTu]) VALUES (N'DEP       ', N'Tông lào')
INSERT [dbo].[VatTu] ([MaVatTu], [TenVatTu]) VALUES (N'ML        ', N'Máy lạnh')
INSERT [dbo].[VatTu] ([MaVatTu], [TenVatTu]) VALUES (N'QM        ', N'Quạt máy')
INSERT [dbo].[VatTu] ([MaVatTu], [TenVatTu]) VALUES (N'TL        ', N'Tủ lạnh')
INSERT [dbo].[VatTu] ([MaVatTu], [TenVatTu]) VALUES (N'TV        ', N'Ti vi')
ALTER TABLE [dbo].[BoTri]  WITH CHECK ADD  CONSTRAINT [FK_BoTri_LoaiPhong] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiPhong] ([MaLoai])
GO
ALTER TABLE [dbo].[BoTri] CHECK CONSTRAINT [FK_BoTri_LoaiPhong]
GO
ALTER TABLE [dbo].[BoTri]  WITH CHECK ADD  CONSTRAINT [FK_BoTri_VatTu] FOREIGN KEY([MaVatTu])
REFERENCES [dbo].[VatTu] ([MaVatTu])
GO
ALTER TABLE [dbo].[BoTri] CHECK CONSTRAINT [FK_BoTri_VatTu]
GO
ALTER TABLE [dbo].[DanhSachPhong]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachPhong_LoaiPhong] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiPhong] ([MaLoai])
GO
ALTER TABLE [dbo].[DanhSachPhong] CHECK CONSTRAINT [FK_DanhSachPhong_LoaiPhong]
GO
ALTER TABLE [dbo].[DichVu]  WITH CHECK ADD  CONSTRAINT [FK_DichVu_DanhSachPhong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[DanhSachPhong] ([MaPhong])
GO
ALTER TABLE [dbo].[DichVu] CHECK CONSTRAINT [FK_DichVu_DanhSachPhong]
GO
ALTER TABLE [dbo].[DichVu]  WITH CHECK ADD  CONSTRAINT [FK_DichVu_LoaiDichVu] FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[LoaiDichVu] ([MaDV])
GO
ALTER TABLE [dbo].[DichVu] CHECK CONSTRAINT [FK_DichVu_LoaiDichVu]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_DanhSachPhong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[DanhSachPhong] ([MaPhong])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_DanhSachPhong]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KHACHHANG] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KHACHHANG]
GO
ALTER TABLE [dbo].[ThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_ThuePhong_DanhSachPhong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[DanhSachPhong] ([MaPhong])
GO
ALTER TABLE [dbo].[ThuePhong] CHECK CONSTRAINT [FK_ThuePhong_DanhSachPhong]
GO
ALTER TABLE [dbo].[ThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_ThuePhong_KHACHHANG] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[ThuePhong] CHECK CONSTRAINT [FK_ThuePhong_KHACHHANG]
GO
USE [master]
GO
ALTER DATABASE [QUANLYKHACHSAN] SET  READ_WRITE 
GO
