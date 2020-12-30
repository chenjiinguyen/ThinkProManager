USE [THINKPRO]
GO
/****** Object:  Table [dbo].[CHITIETPN]    Script Date: 31/12/2020 00:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPN](
	[ID_PN] [varchar](50) NOT NULL,
	[ID_SP] [varchar](10) NOT NULL,
	[SOLUONGNHAP] [int] NOT NULL,
	[DONGIANHAP] [int] NOT NULL,
 CONSTRAINT [PK_CHITIETPN] PRIMARY KEY CLUSTERED 
(
	[ID_PN] ASC,
	[ID_SP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETHD]    Script Date: 31/12/2020 00:24:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHD](
	[ID_HD] [varchar](100) NOT NULL,
	[ID_SP] [varchar](10) NOT NULL,
	[SOLUONG] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_HD] ASC,
	[ID_SP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANHGIA]    Script Date: 31/12/2020 00:24:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHGIA](
	[ID_DG] [varchar](10) NOT NULL,
	[ID_SP] [varchar](10) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[NGAYGIO] [datetime] NULL,
	[TIEUDE] [nvarchar](100) NULL,
	[NOIDUNG] [ntext] NULL,
	[XEPHANG] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_DG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 31/12/2020 00:24:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[ID_HD] [varchar](100) NOT NULL,
	[ID_USER] [varchar](10) NULL,
	[NGAYLAPHD] [datetime] NULL,
	[GHICHU] [nvarchar](100) NULL,
	[ID_NV] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_HD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAI]    Script Date: 31/12/2020 00:24:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAI](
	[ID_LOAI] [varchar](10) NOT NULL,
	[TENLOAI] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_LOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 31/12/2020 00:24:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[ID_USER] [varchar](10) NOT NULL,
	[ID_VAITRO] [varchar](10) NULL,
	[HOTEN] [nvarchar](50) NULL,
	[DIENTHOAI] [char](11) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[EMAIL] [nvarchar](50) NULL,
	[MATKHAU] [varchar](255) NULL,
	[AVATAR] [varchar](255) NULL,
	[GIOITINH] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_USER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 31/12/2020 00:24:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[ID_NCC] [varchar](10) NOT NULL,
	[TENNCC] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_NCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 31/12/2020 00:24:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[ID_USER] [varchar](10) NOT NULL,
	[HESOLUONG] [int] NOT NULL,
	[TINHTRANG] [bit] NOT NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[ID_USER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 31/12/2020 00:24:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[ID_PN] [varchar](50) NOT NULL,
	[ID_NV] [varchar](10) NULL,
	[ID_NCC] [varchar](10) NULL,
	[NGAYNHAP] [datetime] NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[ID_PN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 31/12/2020 00:24:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[ID_SP] [varchar](10) NOT NULL,
	[ID_BRAND] [varchar](10) NULL,
	[ID_LOAI] [varchar](10) NULL,
	[TENSP] [nvarchar](50) NULL,
	[ANH_SP] [varchar](500) NULL,
	[GIATIEN] [int] NULL,
	[DONVITINH] [nvarchar](20) NULL,
	[SOLUONGTONKHO] [int] NOT NULL ,
	[ID_TINHTRANG] [varchar](10) NULL,
	[THOIHAN_BH] [nvarchar](20) NULL,
	[THONGTIN] [ntext] NULL,
	CHECK (SOLUONGTONKHO >= 0),
	PRIMARY KEY CLUSTERED 
(
	[ID_SP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TINHTRANG]    Script Date: 31/12/2020 00:24:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TINHTRANG](
	[ID_TINHTRANG] [varchar](10) NOT NULL,
	[TENTT] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_TINHTRANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THONGTIN]    Script Date: 31/12/2020 00:24:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONGTIN](
	[ID_SP] [varchar](10) NOT NULL,
	[VIXULY] [ntext] NULL,
	[MANHINH] [ntext] NULL,
	[RAM] [ntext] NULL,
	[CARDDOHOA] [ntext] NULL,
	[LUUTRU] [ntext] NULL,
	[PIN] [ntext] NULL,
	[KETNOI] [ntext] NULL,
	[TRONGLUONG] [ntext] NULL,
	[HEDIEUHANH] [ntext] NULL,
	[MAUSAC] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_SP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THUONGHIEU]    Script Date: 31/12/2020 00:24:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUONGHIEU](
	[ID_BRAND] [varchar](10) NOT NULL,
	[TENTH] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_BRAND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VAITRO]    Script Date: 31/12/2020 00:24:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VAITRO](
	[ID_VAITRO] [varchar](10) NOT NULL,
	[TENVAITRO] [nvarchar](20) NULL,
	[DANGNHAP] [bit] NULL,
	[HOADON] [bit] NULL,
	[NGUOIDUNG] [bit] NULL,
	[SANPHAM] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_VAITRO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LOAI] ([ID_LOAI], [TENLOAI]) VALUES (N'LAP', N'Laptop')
INSERT [dbo].[LOAI] ([ID_LOAI], [TENLOAI]) VALUES (N'PC', N'PC')
INSERT [dbo].[LOAI] ([ID_LOAI], [TENLOAI]) VALUES (N'PK', N'Phụ Kiện')
GO
INSERT [dbo].[NGUOIDUNG] ([ID_USER], [ID_VAITRO], [HOTEN], [DIENTHOAI], [DIACHI], [EMAIL], [MATKHAU], [AVATAR], [GIOITINH]) VALUES (N'ONLINE', N'MG', N'Thanh Toán Online', N'0987654321 ', N'Online', N'online@thinkpro.vn', N'D4727C5F343167F5D2454CDE0CFA3864', N'https://i.imgur.com/yIRoqu8.png', N'Nam')
INSERT [dbo].[NGUOIDUNG] ([ID_USER], [ID_VAITRO], [HOTEN], [DIENTHOAI], [DIACHI], [EMAIL], [MATKHAU], [AVATAR], [GIOITINH]) VALUES (N'USER001', N'MG', N'Nguyễn Duy', N'0966740812 ', N'TP.HCM', N'duyntp2000@gmail.com', N'D4727C5F343167F5D2454CDE0CFA3864', N'https://i.imgur.com/8qKkOpe.jpg', N'Nam')
INSERT [dbo].[NGUOIDUNG] ([ID_USER], [ID_VAITRO], [HOTEN], [DIENTHOAI], [DIACHI], [EMAIL], [MATKHAU], [AVATAR], [GIOITINH]) VALUES (N'USER002', N'MG', N'Như Quỳnh', N'0987654321 ', N'Phú Yên', N'nhuquynhnt0711@gmail.com', N'9E43216B90800525C330C6FE6D3F5398', N'https://i.imgur.com/cLZzJdm.png', N'Nữ')
INSERT [dbo].[NGUOIDUNG] ([ID_USER], [ID_VAITRO], [HOTEN], [DIENTHOAI], [DIACHI], [EMAIL], [MATKHAU], [AVATAR], [GIOITINH]) VALUES (N'USER003', N'NV', N'Nguyễn Thành Long', N'0987654321 ', N'Bình Dương', N'longzip113@gmail.com', N'CAF65F014EE3F80F2C4612BABCF2E780', N'https://i.imgur.com/in0h0AV.png', N'Nam')
GO
INSERT [dbo].[NHACUNGCAP] ([ID_NCC], [TENNCC]) VALUES (N'GEARVN', N'GEARVN')
INSERT [dbo].[NHACUNGCAP] ([ID_NCC], [TENNCC]) VALUES (N'PV', N'Phong Vũ')
INSERT [dbo].[NHACUNGCAP] ([ID_NCC], [TENNCC]) VALUES (N'TGGD', N'Thế Giới Di Động ')
GO
INSERT [dbo].[NHANVIEN] ([ID_USER], [HESOLUONG], [TINHTRANG]) VALUES (N'ONLINE', 0, 1)
INSERT [dbo].[NHANVIEN] ([ID_USER], [HESOLUONG], [TINHTRANG]) VALUES (N'USER001', 75000, 1)
INSERT [dbo].[NHANVIEN] ([ID_USER], [HESOLUONG], [TINHTRANG]) VALUES (N'USER002', 80000, 0)
INSERT [dbo].[NHANVIEN] ([ID_USER], [HESOLUONG], [TINHTRANG]) VALUES (N'USER003', 50000, 1)
GO
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'LAP1', N'AC', N'LAP', N'Laptop Acer Aspire 5 A514 54 39KU', N'https://i.imgur.com/1tCMMcL.png', 13490000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'LAP10', N'HP', N'LAP', N'Laptop HP 15s FQ1107TU 193Q3PA', N'https://i.imgur.com/hjGb4A0.png', 9990000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'LAP11', N'HP', N'LAP', N'Laptop HP ProBook 455 G7 1A1A9PA', N'https://i.imgur.com/hMyBGD6.png', 15690000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'LAP12', N'HP', N'LAP', N'Laptop HP 15s FQ2027TU 2Q5Y3PA', N'https://i.imgur.com/DUkdz5y.png', 20590000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'LAP13', N'LE', N'LAP', N'Laptop Lenovo IdeaPad Gaming 3 15IMH05 81Y4006SVN', N'https://i.imgur.com/UwhbKov.png', 20990000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'LAP14', N'LE', N'LAP', N'Laptop Lenovo IdeaPad Gaming 3 15IMH05 81Y40067VN', N'https://i.imgur.com/93cb9yH.png', 21990000, N'VND', 100, N'NEW', N'12', N'')
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'LAP15', N'AP', N'LAP', N'Apple Macbook Air 2020', N'https://i.imgur.com/GUVuZR8.png', 23490000, N'VND', 100, N'NEW', N'12', N'Apple Macbook Air 2020')
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'LAP16', N'AP', N'LAP', N'Apple Macbook Pro 16 2019', N'https://i.imgur.com/WAh9A03.png', 56490000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'LAP2', N'AC', N'LAP', N'Laptop Acer Aspire 5 A514 53 38GF', N'https://i.imgur.com/wcU1lZ5.png', 15990000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'LAP3', N'AC', N'LAP', N'Laptop Acer Aspire 3 A315 56 37DV', N'https://i.imgur.com/rk4AYhq.png', 16990000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'LAP4', N'AS', N'LAP', N'Laptop Asus D509DA EJ116T', N'https://i.imgur.com/noOBm40.png', 9790000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'LAP5', N'AS', N'LAP', N'Laptop ASUS D409DA EK499T', N'https://i.imgur.com/xXDrqXl.png', 9990000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'LAP6', N'AS', N'LAP', N'Laptop ASUS X509JA EJ427T', N'https://i.imgur.com/wZHTKpd.png', 11190000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'LAP7', N'DE', N'LAP', N'Laptop Dell Inspiron 15 3501 N3501C', N'https://i.imgur.com/vdc7u7X.png', 9790000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'LAP8', N'DE', N'LAP', N'Laptop Dell Vostro 14 5402 V5402A', N'https://i.imgur.com/6dfR9pn.png', 19990000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'LAP9', N'DE', N'LAP', N'Laptop Dell Inspiron 5490 FMKJV11', N'https://i.imgur.com/HFkMPDo.png', 20990000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PC1', N'HP', N'PC', N'HP EliteDesk 800 G4 Mini', N'https://i.imgur.com/dIPizWE.png', 10990000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PC10', N'DE', N'PC', N'Lenovo ThinkCentre M710E SFF', N'https://i.imgur.com/XJJ9YXb.png', 11990000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PC2', N'HP', N'PC', N'HP EliteDesk 800 G4 SFF', N'https://i.imgur.com/wdIEmbi.png', 11990000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PC3', N'HP', N'PC', N'HP EliteDesk 800 G4 Tower', N'https://i.imgur.com/0sthVZi.png', 11990000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PC4', N'HP', N'PC', N'HP EliteDesk 800 G5 SFF', N'https://i.imgur.com/kfv6HAf.png', 12990000, N'VND', 10, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PC5', N'LE', N'PC', N'Lenovo ThinkCentre M720s SFF', N'https://i.imgur.com/NuXPKIk.png', 7900000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PC6', N'LE', N'PC', N'Lenovo ThinkCentre M710E SFF', N'https://i.imgur.com/4okE55k.png', 8990000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PC7', N'LE', N'PC', N'Lenovo ThinkCentre M920s SFF', N'https://i.imgur.com/yS6tHBb.png', 9990000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PC8', N'LE', N'PC', N'Lenovo ThinkCentre M725s SFF', N'https://i.imgur.com/K3ZkRT7.png', 15990000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PC9', N'DE', N'PC', N'Dell Vostro 3471', N'https://i.imgur.com/HwwW3kL.png', 11990000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PK1', N'RZ', N'PK', N'Vỏ case Razer Tomahawk ATX', N'https://i.imgur.com/dlFCqqV.png', 7000000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PK10', N'DE', N'PK', N'Dell UltraSharp U2520D 25" IPS', N'https://i.imgur.com/xP1yQXR.png', 8450000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PK2', N'RZ', N'PK', N'Vỏ case Razer Tomahawk Mini-ITX', N'https://i.imgur.com/eNbUn9A.png', 6490000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PK3', N'LG', N'PK', N'Chuột Logitech G102 LIGHTSYNC', N'https://i.imgur.com/lOelDVE.png', 450000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PK4', N'LG', N'PK', N'Chuột Logitech M185', N'https://i.imgur.com/adljA7Y.png', 230000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PK5', N'LG', N'PK', N'Chuột Logitech MX Anywhere 2S', N'https://i.imgur.com/xT76ejG.png', 1390000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PK6', N'LG', N'PK', N'Chuột logitech M331 Silent', N'https://i.imgur.com/BYJdsB4.png', 319000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PK7', N'LE', N'PK', N'Balo Lenovo Legion Gaming Backpack', N'https://i.imgur.com/idBpyVO.png', 900000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PK8', N'AC', N'PK', N'Balo Acer Predator SUV', N'https://i.imgur.com/zOLDnnl.png', 1700000, N'VND', 100, N'NEW', N'12', NULL)
INSERT [dbo].[SANPHAM] ([ID_SP], [ID_BRAND], [ID_LOAI], [TENSP], [ANH_SP], [GIATIEN], [DONVITINH], [SOLUONGTONKHO], [ID_TINHTRANG], [THOIHAN_BH], [THONGTIN]) VALUES (N'PK9', N'AS', N'PK', N'Balo Asus Gaming TUF 15"-17"', N'https://i.imgur.com/pUCpkdy.png', 890000, N'VND', 100, N'NEW', N'12', NULL)
GO
INSERT [dbo].[TINHTRANG] ([ID_TINHTRANG], [TENTT]) VALUES (N'CU99', N'Máy Cũ 99%')
INSERT [dbo].[TINHTRANG] ([ID_TINHTRANG], [TENTT]) VALUES (N'NEW', N'Máy Mới')
GO
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'LAP1', N'Intel Core i3-1005G1 1.2GHz up to 3.4GHz 4MB', N'15.6" FHD (1920 x 1080) Acer ComfyView LCD, Anti-Glare', N'4GB DDR4 2400MHz Onboard (1x SO-DIMM socket, up to 12GB SDRAM)', N'Intel UHD Graphics', N'256GB SSD M.2 PCIE, 1x slot SATA3 2.5"', N'3 Cell 36.7 Whr', NULL, N'1.7 kg', N'Windows 10 Home', N'Shale Black')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'LAP10', N'Intel® Core™ i3-1005G1(tần số cơ bản 1.2 GHz, upto 3.4Ghz, bộ nhớ đệm 4 MB, 2 lõi)', N'15,6" HD', NULL, N'Intel® HD Graphics 620', N'256 GB PCIe® NVMe™ M.2 SSD', N'3-cell, 41 Wh Li-ion', NULL, N'1,74 kg', N'Windows 10 Home', N'Bạc')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'LAP11', N'AMD Ryzen 5-4500U 2.3GHz up to 4.0GHz 8MB', N'15.6" FHD (1920 x 1080) Diagonal IPS Anti-Glare WLED-Backlit, 45% NTSC, 250nits', N'4GB DDR4 3200MHz (2x SO-DIMM socket, up to 32GB SDRAM)', N'AMD Radeon™ Graphics', N'256GB SSD M.2 PCIE', N'3 Cell 45WHr', NULL, N'2 kg', N'Windows 10 Home', N'Bạc')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'LAP12', N'Intel Core i5-1135G7 2.4GHz up to 4.2GHz 8MB', N'15.6" HD (1366x768) SVA Anti-Glare with 45% NTSC, Micro-Edge WLED-backlit, 220nits', N'8GB DDR4 2666MHz', N'Intel Iris Xe Graphics', N'512GB PCIe® NVMe™ M.2 SSD', N'3 Cell 41Whr', NULL, N'1.65 kg', N'Windows 10 Home', N'Bạc')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'LAP13', N'Intel Core i5-10300H 2.5GHz up to 4.5GHz 8MB', N'15.6" FHD (1920 x 1080) IPS, 250nits, Anti-Glare, 60Hz', N'8GB DDR4 2933MHz (2x SO-DIMM socket, up to 32GB SDRAM)', N'NVIDIA GeForce GTX 1650 4GB GDDR6 + Intel UHD Graphics', N'512GB SSD M.2 2242 PCIe NVMe 3.0x4, x1 slot 2.5" SATA (HDD/SSD)', N'3 Cell 45WHr', NULL, N'2.2 kg', N'Windows 10 Home', N'Đen')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'LAP14', N'Intel Core i7-10750H 2.6GHz up to 5.0GHz 12MB', N'15.6" FHD (1920 x 1080) IPS, 250nits, Anti-Glare, 60Hz', N'8GB DDR4 2933MHz (2x SO-DIMM socket, up to 32GB SDRAM)', N'NVIDIA GeForce GTX 1650 4GB GDDR6 + Intel UHD Graphics', N'512GB SSD M.2 2242 PCIe NVMe 3.0x4, x1 slot 2.5" SATA (HDD/SSD)', N'3 Cell 45WHr', NULL, N'2.2 kg', N'Windows 10 Home', N'Đen, Trắng')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'LAP15', N'Intel Core i5', N'13.3" Retina (2560 x 1600)', N'8GB', N'Intel Iris Plus G4', N'256GB Nvme', N'49.9 Whr', NULL, NULL, N'MacOS', N'Gey')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'LAP16', N'Intel Core i9', N'16" Retina (3720 x 1920)', N'16GB', N'Raedon Pro 5500 4GB', N'SSD 1TB Nvme', N'100 Whr', NULL, NULL, N'MacOS', N'Silver')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'LAP2', N'Intel Core i3-1115G4 3.0GHz up to 4.1GHz 6MB', N'14" FHD (1920 x 1080) IPS, Acer ComfyView LCD', N'4GB DDR4 3200MHz Onboard (1x SO-DIMM socket, up to 20GB SDRAM)', N'Intel® UHD Graphics for 11th Gen Intel® Processors', N'256GB SSD M.2 PCIE, 1x slot SATA3 2.5"', N'3 Cell 48 WHr', NULL, N'1.45 kg', N'Windows 10 Home', N'Pure Silver (Vỏ nhôm)')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'LAP4', N'AMD Ryzen 3-3200U (2.6GHz upto 3.5GHz, 2 nhân 4 luồng, 5MB)', N'15.6" FHD (1920 x 1080) Anti-Glare with 45% NTSC', N'4GB DDR4 2400MHz', N'AMD Radeon™ Vega 3 Graphics', N'HDD 1TB 5400rp', N'2 Cells 32WHrs', NULL, N'1.9 kg', N'Windows 10 Home', N'Bạc')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'LAP5', N'AMD Ryzen 3-3250U 2.6GHz up to 3.5GHz 4MB', N'14" FHD (1920 x 1080) 60Hz, Anti-Glare with 45% NTSC', N'4GB DDR4 2400MHz Onboard (1x SO-DIMM socket, up to 12GB SDRAM)', N'AMD Radeon™ Graphics', N'256GB SSD M.2 PCIE G3X2', N'2 Cells 32WHrs', NULL, N'1.7 kg', N'Windows 10 Home', N'Bạc')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'LAP6', N'Intel Core i3-1005G1 1.2GHz up to 3.4GHz 4MB', N'15.6" FHD (1920 x 1080), Anti-Glare with 45% NTSC', N'4GB DDR4 2400MHz Onboard (1x SO-DIMM socket, up to 12GB SDRAM)', N'Intel UHD Graphics', N'512GB SSD M.2 PCIE G3X2', N'2 Cells 32WHrs', NULL, N'1.8 kg', N'Windows 10 Home', N'Bạc')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'LAP7', N'Intel Core i3-1115G4 (6MB, up to 4.10GHz)', N'15.6 inch FHD (1920 x 1080) Anti-glare 200nits, 45% NTSC Wide- Viewing Angle', N'4GB DDR4 2666MHz', N'Intel UHD Graphics', N'SSD 256GB M.2 PCIe NVMe Solid State Drive', N'3 Cell 42Whr', NULL, N'1.96 kg', N'Windows 10 Home', N'Bạc')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'LAP8', N'Intel Core i5-1135G7 2.4GHz up to 4.2GHz 8MB', N'14'' FHD (1920 x 1080) WLED, Anti-Glare, 45% NTSC, 220 Nits', N'8GB DDR4 3200MHz (2x SO-DIMM socket, up to 32GB SDRAM)', N'NVIDIA GeForce MX330 2GB GDDR5 + Intel Iris Xe Graphics', N'256GB SSD M.2 PCIE', N'3 Cell 40Whr', NULL, N'1.41 kg', N'Windows 10 Home', N'Gray')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'LAP9', N'Intel Core i5-10210U Processor (4 x 1.60 GHz), Max Turbo Frequency : 4.20 GHz', N'14.0” inch FHD (1920x1080) @60Hz Wide Viewing Angle , Anti-Glare', N'4GB onboard DDR4/2666 MHz + [1 x 4GB DDR4/2666 MHz (1 slots)]', N'NVIDIA GeForce MX230 + Intel UHD Graphics', N'512GB SSD PCIe (Combo M.2 2230/2280)', N'3 Cell 51Whr', NULL, N'1.4 kg', N'Windows 10 Home', N'Bạc')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'PC1', N'Intel Core i3-1005G1 1.2GHz up to 3.4GHz 4MB', NULL, N'4GB DDR4 2400MHz Onboard (1x SO-DIMM socket, up to 12GB SDRAM)', N'Intel UHD Graphics', N'256GB SSD M.2 PCIE, 1x slot SATA3 2.5"', N'3 Cell 36.7 Whr', NULL, N'1.7 kg', N'Windows 10 Home', N'Shale Black')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'PC10', N'Intel Core i3-1005G1 1.2GHz up to 3.4GHz 4MB', NULL, N'4GB DDR4 2400MHz Onboard (1x SO-DIMM socket, up to 12GB SDRAM)', N'Intel UHD Graphics', N'256GB SSD M.2 PCIE, 1x slot SATA3 2.5"', N'3 Cell 36.7 Whr', NULL, N'1.7 kg', N'Windows 10 Home', N'Shale Black')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'PC2', N'Intel Core i3-1005G1 1.2GHz up to 3.4GHz 4MB', NULL, N'4GB DDR4 2400MHz Onboard (1x SO-DIMM socket, up to 12GB SDRAM)', N'Intel UHD Graphics', N'256GB SSD M.2 PCIE, 1x slot SATA3 2.5"', N'3 Cell 36.7 Whr', NULL, N'1.7 kg', N'Windows 10 Home', N'Shale Black')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'PC3', N'Intel Core i3-1005G1 1.2GHz up to 3.4GHz 4MB', NULL, N'4GB DDR4 2400MHz Onboard (1x SO-DIMM socket, up to 12GB SDRAM)', N'Intel UHD Graphics', N'256GB SSD M.2 PCIE, 1x slot SATA3 2.5"', N'3 Cell 36.7 Whr', NULL, N'1.7 kg', N'Windows 10 Home', N'Shale Black')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'PC4', N'Intel Core i3-1005G1 1.2GHz up to 3.4GHz 4MB', NULL, N'4GB DDR4 2400MHz Onboard (1x SO-DIMM socket, up to 12GB SDRAM)', N'Intel UHD Graphics', N'256GB SSD M.2 PCIE, 1x slot SATA3 2.5"', N'3 Cell 36.7 Whr', NULL, N'1.7 kg', N'Windows 10 Home', N'Shale Black')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'PC5', N'Intel Core i3-1005G1 1.2GHz up to 3.4GHz 4MB', NULL, N'4GB DDR4 2400MHz Onboard (1x SO-DIMM socket, up to 12GB SDRAM)', N'Intel UHD Graphics', N'256GB SSD M.2 PCIE, 1x slot SATA3 2.5"', N'3 Cell 36.7 Whr', NULL, N'1.7 kg', N'Windows 10 Home', N'Shale Black')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'PC6', N'Intel Core i3-1005G1 1.2GHz up to 3.4GHz 4MB', NULL, N'4GB DDR4 2400MHz Onboard (1x SO-DIMM socket, up to 12GB SDRAM)', N'Intel UHD Graphics', N'256GB SSD M.2 PCIE, 1x slot SATA3 2.5"', N'3 Cell 36.7 Whr', NULL, N'1.7 kg', N'Windows 10 Home', N'Shale Black')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'PC7', N'Intel Core i3-1005G1 1.2GHz up to 3.4GHz 4MB', NULL, N'4GB DDR4 2400MHz Onboard (1x SO-DIMM socket, up to 12GB SDRAM)', N'Intel UHD Graphics', N'256GB SSD M.2 PCIE, 1x slot SATA3 2.5"', N'3 Cell 36.7 Whr', NULL, N'1.7 kg', N'Windows 10 Home', N'Shale Black')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'PC8', N'Intel Core i3-1005G1 1.2GHz up to 3.4GHz 4MB', NULL, N'4GB DDR4 2400MHz Onboard (1x SO-DIMM socket, up to 12GB SDRAM)', N'Intel UHD Graphics', N'256GB SSD M.2 PCIE, 1x slot SATA3 2.5"', N'3 Cell 36.7 Whr', NULL, N'1.7 kg', N'Windows 10 Home', N'Shale Black')
INSERT [dbo].[THONGTIN] ([ID_SP], [VIXULY], [MANHINH], [RAM], [CARDDOHOA], [LUUTRU], [PIN], [KETNOI], [TRONGLUONG], [HEDIEUHANH], [MAUSAC]) VALUES (N'PC9', N'Intel Core i3-1005G1 1.2GHz up to 3.4GHz 4MB', NULL, N'4GB DDR4 2400MHz Onboard (1x SO-DIMM socket, up to 12GB SDRAM)', N'Intel UHD Graphics', N'256GB SSD M.2 PCIE, 1x slot SATA3 2.5"', N'3 Cell 36.7 Whr', NULL, N'1.7 kg', N'Windows 10 Home', N'Shale Black')
GO
INSERT [dbo].[THUONGHIEU] ([ID_BRAND], [TENTH]) VALUES (N'AC', N'Acer')
INSERT [dbo].[THUONGHIEU] ([ID_BRAND], [TENTH]) VALUES (N'AP', N'Apple')
INSERT [dbo].[THUONGHIEU] ([ID_BRAND], [TENTH]) VALUES (N'AS', N'ASUS')
INSERT [dbo].[THUONGHIEU] ([ID_BRAND], [TENTH]) VALUES (N'DE', N'Dell')
INSERT [dbo].[THUONGHIEU] ([ID_BRAND], [TENTH]) VALUES (N'HP', N'HP')
INSERT [dbo].[THUONGHIEU] ([ID_BRAND], [TENTH]) VALUES (N'LE', N'Lenovo')
INSERT [dbo].[THUONGHIEU] ([ID_BRAND], [TENTH]) VALUES (N'LG', N'Logitech')
INSERT [dbo].[THUONGHIEU] ([ID_BRAND], [TENTH]) VALUES (N'MSI', N'MSI')
INSERT [dbo].[THUONGHIEU] ([ID_BRAND], [TENTH]) VALUES (N'RZ', N'Razer')
GO
INSERT [dbo].[VAITRO] ([ID_VAITRO], [TENVAITRO], [DANGNHAP], [HOADON], [NGUOIDUNG], [SANPHAM]) VALUES (N'MG', N'Quản Lý', 1, 1, 1, 1)
INSERT [dbo].[VAITRO] ([ID_VAITRO], [TENVAITRO], [DANGNHAP], [HOADON], [NGUOIDUNG], [SANPHAM]) VALUES (N'NV', N'Nhân Viên', 1, 1, 0, 1)
INSERT [dbo].[VAITRO] ([ID_VAITRO], [TENVAITRO], [DANGNHAP], [HOADON], [NGUOIDUNG], [SANPHAM]) VALUES (N'NVNH', N'Nhân Viên Nhập Kho', 1, 0, 0, 1)
INSERT [dbo].[VAITRO] ([ID_VAITRO], [TENVAITRO], [DANGNHAP], [HOADON], [NGUOIDUNG], [SANPHAM]) VALUES (N'U', N'Người Dùng', 0, 0, 0, 1)
GO
ALTER TABLE [dbo].[CHITIETPN]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPN_PHIEUNHAP] FOREIGN KEY([ID_PN])
REFERENCES [dbo].[PHIEUNHAP] ([ID_PN])
GO
ALTER TABLE [dbo].[CHITIETPN] CHECK CONSTRAINT [FK_CHITIETPN_PHIEUNHAP]
GO
ALTER TABLE [dbo].[CHITIETPN]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPN_SANPHAM] FOREIGN KEY([ID_SP])
REFERENCES [dbo].[SANPHAM] ([ID_SP])
GO
ALTER TABLE [dbo].[CHITIETPN] CHECK CONSTRAINT [FK_CHITIETPN_SANPHAM]
GO
ALTER TABLE [dbo].[CHITIETHD]  WITH CHECK ADD FOREIGN KEY([ID_HD])
REFERENCES [dbo].[HOADON] ([ID_HD])
GO
ALTER TABLE [dbo].[CHITIETHD]  WITH CHECK ADD FOREIGN KEY([ID_SP])
REFERENCES [dbo].[SANPHAM] ([ID_SP])
GO
ALTER TABLE [dbo].[DANHGIA]  WITH CHECK ADD FOREIGN KEY([ID_SP])
REFERENCES [dbo].[SANPHAM] ([ID_SP])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([ID_USER])
REFERENCES [dbo].[NGUOIDUNG] ([ID_USER])
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD FOREIGN KEY([ID_VAITRO])
REFERENCES [dbo].[VAITRO] ([ID_VAITRO])
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_NGUOIDUNG] FOREIGN KEY([ID_USER])
REFERENCES [dbo].[NGUOIDUNG] ([ID_USER])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_NGUOIDUNG]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NGUOIDUNG] FOREIGN KEY([ID_NV])
REFERENCES [dbo].[NHANVIEN] ([ID_USER])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NGUOIDUNG]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP] FOREIGN KEY([ID_NCC])
REFERENCES [dbo].[NHACUNGCAP] ([ID_NCC])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD FOREIGN KEY([ID_BRAND])
REFERENCES [dbo].[THUONGHIEU] ([ID_BRAND])
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD FOREIGN KEY([ID_LOAI])
REFERENCES [dbo].[LOAI] ([ID_LOAI])
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD FOREIGN KEY([ID_TINHTRANG])
REFERENCES [dbo].[TINHTRANG] ([ID_TINHTRANG])
GO
ALTER TABLE [dbo].[THONGTIN]  WITH CHECK ADD  CONSTRAINT [FK_THONGTIN_SANPHAM] FOREIGN KEY([ID_SP])
REFERENCES [dbo].[SANPHAM] ([ID_SP])
GO
ALTER TABLE [dbo].[THONGTIN] CHECK CONSTRAINT [FK_THONGTIN_SANPHAM]
GO
/****** Object:  Trigger [dbo].[TG_DELETE_PHIEUNHAP]    Script Date: 31/12/2020 00:24:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create TRIGGER [dbo].[TG_DELETE_PHIEUNHAP] ON [dbo].[CHITIETPN] FOR DELETE AS 
BEGIN
	UPDATE SANPHAM
	SET SOLUONGTONKHO = SOLUONGTONKHO - (SELECT SOLUONGNHAP FROM deleted WHERE ID_SP = SANPHAM.ID_SP)
   FROM SANPHAM 
   JOIN deleted ON SANPHAM.ID_SP = deleted.ID_SP
END
GO
ALTER TABLE [dbo].[CHITIETPN] ENABLE TRIGGER [TG_DELETE_PHIEUNHAP]
GO
/****** Object:  Trigger [dbo].[TG_INSERT_PHIEUNHAP]    Script Date: 31/12/2020 00:24:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TG_INSERT_PHIEUNHAP] ON [dbo].[CHITIETPN] AFTER INSERT AS 
BEGIN
	UPDATE SANPHAM
	SET SOLUONGTONKHO = SOLUONGTONKHO + (
		SELECT SOLUONGNHAP
		FROM inserted
		WHERE ID_SP = SANPHAM.ID_SP
	)
	FROM SANPHAM
	JOIN inserted ON SANPHAM.ID_SP = inserted.ID_SP
END
GO
ALTER TABLE [dbo].[CHITIETPN] ENABLE TRIGGER [TG_INSERT_PHIEUNHAP]
GO
/****** Object:  Trigger [dbo].[TG_UPDATE_PHIEUNHAP]    Script Date: 31/12/2020 00:24:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TG_UPDATE_PHIEUNHAP] on [dbo].[CHITIETPN] after update AS
BEGIN
   UPDATE SANPHAM SET SOLUONGTONKHO = SOLUONGTONKHO +
	   (SELECT SOLUONGNHAP FROM inserted WHERE ID_SP = SANPHAM.ID_SP) -
	   (SELECT SOLUONGNHAP FROM deleted WHERE ID_SP = SANPHAM.ID_SP)
   FROM SANPHAM 
   JOIN deleted ON SANPHAM.ID_SP = deleted.ID_SP
end
GO
ALTER TABLE [dbo].[CHITIETPN] ENABLE TRIGGER [TG_UPDATE_PHIEUNHAP]
GO
/****** Object:  Trigger [dbo].[TG_DELETE_HOADON]    Script Date: 31/12/2020 00:24:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create TRIGGER [dbo].[TG_DELETE_HOADON] ON [dbo].[CHITIETHD] FOR DELETE AS 
BEGIN
	UPDATE SANPHAM
	SET SOLUONGTONKHO = SOLUONGTONKHO + (SELECT SOLUONG FROM deleted WHERE ID_SP = SANPHAM.ID_SP)
   FROM SANPHAM 
   JOIN deleted ON SANPHAM.ID_SP = deleted.ID_SP
END
GO
ALTER TABLE [dbo].[CHITIETHD] ENABLE TRIGGER [TG_DELETE_HOADON]
GO
/****** Object:  Trigger [dbo].[TG_INSERT_HOADON]    Script Date: 31/12/2020 00:24:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TG_INSERT_HOADON] ON [dbo].[CHITIETHD] AFTER INSERT AS 
BEGIN
	UPDATE SANPHAM
	SET SOLUONGTONKHO = SOLUONGTONKHO - (
		SELECT SOLUONG
		FROM inserted
		WHERE ID_SP = SANPHAM.ID_SP
	)
	FROM SANPHAM
	JOIN inserted ON SANPHAM.ID_SP = inserted.ID_SP
END
GO
ALTER TABLE [dbo].[CHITIETHD] ENABLE TRIGGER [TG_INSERT_HOADON]
GO
/****** Object:  Trigger [dbo].[TG_UPDATE_HOADON]    Script Date: 31/12/2020 00:24:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TG_UPDATE_HOADON] on [dbo].[CHITIETHD] after update AS
BEGIN
   UPDATE SANPHAM SET SOLUONGTONKHO = SOLUONGTONKHO -
	   (SELECT SOLUONG FROM inserted WHERE ID_SP = SANPHAM.ID_SP) +
	   (SELECT SOLUONG FROM deleted WHERE ID_SP = SANPHAM.ID_SP)
   FROM SANPHAM 
   JOIN deleted ON SANPHAM.ID_SP = deleted.ID_SP
end
GO
ALTER TABLE [dbo].[CHITIETHD] ENABLE TRIGGER [TG_UPDATE_HOADON]
GO
