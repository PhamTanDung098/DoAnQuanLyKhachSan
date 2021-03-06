USE [QUANLYKHACHSAN]
GO
/****** Object:  Table [dbo].[BoTri]    Script Date: 8/5/2019 9:20:55 AM ******/
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
/****** Object:  Table [dbo].[DanhSachPhong]    Script Date: 8/5/2019 9:20:55 AM ******/
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
/****** Object:  Table [dbo].[DichVu]    Script Date: 8/5/2019 9:20:55 AM ******/
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
/****** Object:  Table [dbo].[HoaDon]    Script Date: 8/5/2019 9:20:55 AM ******/
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
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 8/5/2019 9:20:55 AM ******/
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
/****** Object:  Table [dbo].[LoaiDichVu]    Script Date: 8/5/2019 9:20:55 AM ******/
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
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 8/5/2019 9:20:56 AM ******/
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
/****** Object:  Table [dbo].[Login]    Script Date: 8/5/2019 9:20:56 AM ******/
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
/****** Object:  Table [dbo].[ThuePhong]    Script Date: 8/5/2019 9:20:56 AM ******/
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
/****** Object:  Table [dbo].[VatTu]    Script Date: 8/5/2019 9:20:56 AM ******/
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
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'MLL       ', N'VIP1      ', 2)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'QM        ', N'BD1       ', 1)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'QM        ', N'BD2       ', 2)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'TL        ', N'VIP2      ', 2)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'TV        ', N'BD1       ', 1)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'TV        ', N'BD2       ', 1)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'TV        ', N'VIP1      ', 1)
INSERT [dbo].[BoTri] ([MaVatTu], [MaLoai], [SoLuong]) VALUES (N'TV        ', N'VIP2      ', 1)
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'P102      ', 0, N'BD1       ')
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'P103      ', 0, N'BD1       ')
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'P104      ', 0, N'BD2       ')
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'P105      ', 0, N'BD2       ')
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'P201      ', 0, N'VIP1      ')
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'P202      ', 0, N'VIP1      ')
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'P203      ', 0, N'VIP1      ')
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'P204      ', 1, N'VIP2      ')
INSERT [dbo].[DanhSachPhong] ([MaPhong], [TinhTrang], [MaLoai]) VALUES (N'TG01      ', 0, N'DC2       ')
INSERT [dbo].[DichVu] ([MaPhong], [MaDichVu], [SoLuong], [NgaySuDung]) VALUES (N'P102      ', N'DV02      ', 10, CAST(0xFB3F0B00 AS Date))
INSERT [dbo].[DichVu] ([MaPhong], [MaDichVu], [SoLuong], [NgaySuDung]) VALUES (N'P102      ', N'DV1       ', 9, CAST(0xFB3F0B00 AS Date))
INSERT [dbo].[DichVu] ([MaPhong], [MaDichVu], [SoLuong], [NgaySuDung]) VALUES (N'P102      ', N'DV3       ', 7, CAST(0xFB3F0B00 AS Date))
INSERT [dbo].[DichVu] ([MaPhong], [MaDichVu], [SoLuong], [NgaySuDung]) VALUES (N'P203      ', N'DV1       ', 7, CAST(0xFB3F0B00 AS Date))
INSERT [dbo].[DichVu] ([MaPhong], [MaDichVu], [SoLuong], [NgaySuDung]) VALUES (N'P203      ', N'DV2       ', 2, CAST(0xFB3F0B00 AS Date))
INSERT [dbo].[DichVu] ([MaPhong], [MaDichVu], [SoLuong], [NgaySuDung]) VALUES (N'P204      ', N'DV3       ', 2, CAST(0xF93F0B00 AS Date))
INSERT [dbo].[DichVu] ([MaPhong], [MaDichVu], [SoLuong], [NgaySuDung]) VALUES (N'TG01      ', N'DV02      ', 11, CAST(0xFB3F0B00 AS Date))
INSERT [dbo].[DichVu] ([MaPhong], [MaDichVu], [SoLuong], [NgaySuDung]) VALUES (N'TG01      ', N'DV7       ', 2, CAST(0xFB3F0B00 AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayThanhToan], [TongTien], [MaPhong], [MaKhachHang], [ThuNgan]) VALUES (N'HD14      ', CAST(0xFB3F0B00 AS Date), 3230000, N'P102      ', N'KH7       ', N'          ')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTen], [CMND], [SDT], [NgayThue]) VALUES (N'KH1       ', N'Phạm Tấn Dũng', N'362504076      ', N'0353497477     ', CAST(0xF93F0B00 AS Date))
INSERT [dbo].[LoaiDichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'DV02      ', N'Massage Thái', 200000, N'Lượt      ')
INSERT [dbo].[LoaiDichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'DV1       ', N'Cơm gà', 20000, N'phần      ')
INSERT [dbo].[LoaiDichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'DV2       ', N'xông hơi', 50000, N'lượt      ')
INSERT [dbo].[LoaiDichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'DV3       ', N'Xoa bóp', 150000, N'lượt      ')
INSERT [dbo].[LoaiDichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'DV4       ', N'nước uống', 15000, N'chai      ')
INSERT [dbo].[LoaiDichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'DV5       ', N'Snack', 5000, N'gói       ')
INSERT [dbo].[LoaiDichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'DV6       ', N'Tắm nước nóng', 30000, N'phần      ')
INSERT [dbo].[LoaiDichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'DV7       ', N'Cơm sườn', 20000, N'Phần      ')
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai], [DonGia], [SoLuong]) VALUES (N'BD1       ', N'Phòng thường đơn', 100000, 2)
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai], [DonGia], [SoLuong]) VALUES (N'BD2       ', N'Phòng thường đôi', 160000, 4)
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai], [DonGia], [SoLuong]) VALUES (N'DC2       ', N'Phòng thương gia', 100000, 2)
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai], [DonGia], [SoLuong]) VALUES (N'VIP1      ', N'Phòng VIP đơn', 250000, 2)
INSERT [dbo].[LoaiPhong] ([MaLoai], [TenLoai], [DonGia], [SoLuong]) VALUES (N'VIP2      ', N'Phòng VIP đôi', 300000, 4)
INSERT [dbo].[Login] ([ID], [Name], [PassWord]) VALUES (N'ID01      ', N'admin     ', N'admin     ')
INSERT [dbo].[Login] ([ID], [Name], [PassWord]) VALUES (N'ID02      ', N'user      ', N'2         ')
INSERT [dbo].[ThuePhong] ([MaPhong], [MaKhachHang], [NgayThue], [SoLuong]) VALUES (N'P204      ', N'KH1       ', CAST(0xF93F0B00 AS Date), 2)
INSERT [dbo].[VatTu] ([MaVatTu], [TenVatTu]) VALUES (N'DEP       ', N'Tông lào')
INSERT [dbo].[VatTu] ([MaVatTu], [TenVatTu]) VALUES (N'DEPPP     ', N'Dép lào')
INSERT [dbo].[VatTu] ([MaVatTu], [TenVatTu]) VALUES (N'ML        ', N'Máy lạnh')
INSERT [dbo].[VatTu] ([MaVatTu], [TenVatTu]) VALUES (N'MLL       ', N'MLLLL')
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
