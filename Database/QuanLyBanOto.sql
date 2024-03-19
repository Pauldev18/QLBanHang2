create database [QuanLyBanOto]
go
USE [QuanLyBanOto]
GO
/****** Object:  Table [dbo].[TblChiTietHDBan]    Script Date: 5/30/2022 2:42:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblChiTietHDBan](
	[Mahdban] [nvarchar](50) NOT NULL,
	[Masanpham] [nvarchar](50) NOT NULL,
	[Soluong] [float] NULL,
	[Dongia] [float] NULL,
	[Giamgia] [float] NULL,
	[Thanhtien] [float] NULL,
 CONSTRAINT [PK_TblChiTietHDBan] PRIMARY KEY CLUSTERED 
(
	[Mahdban] ASC,
	[Masanpham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblHoaDonBan]    Script Date: 5/30/2022 2:42:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblHoaDonBan](
	[Mahdban] [nvarchar](50) NOT NULL,
	[Manhanvien] [nvarchar](50) NULL,
	[Ngayban] [datetime] NULL,
	[Makhachhang] [nvarchar](50) NULL,
	[Tongtien] [float] NULL,
 CONSTRAINT [PK_TblHoaDonBan] PRIMARY KEY CLUSTERED 
(
	[Mahdban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKhachHang]    Script Date: 5/30/2022 2:42:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKhachHang](
	[Makhachhang] [nvarchar](50) NOT NULL,
	[Tenkhachhang] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Dienthoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_TblKhachHang] PRIMARY KEY CLUSTERED 
(
	[Makhachhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblLoaiSanPham]    Script Date: 5/30/2022 2:42:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblLoaiSanPham](
	[Maloaisp] [nvarchar](50) NOT NULL,
	[Tenloaisp] [nvarchar](50) NULL,
 CONSTRAINT [PK_TblLoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[Maloaisp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblLogin]    Script Date: 5/30/2022 2:42:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblLogin](
	[Id] [nvarchar](50) NOT NULL,
	[TenDangNhap] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[Quyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_TblLogin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblNhanVien]    Script Date: 5/30/2022 2:42:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblNhanVien](
	[Manhanvien] [nvarchar](50) NOT NULL,
	[Tennhanvien] [nvarchar](50) NULL,
	[Gioitinh] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Dienthoai] [nvarchar](15) NULL,
	[Ngaysinh] [datetime] NULL,
 CONSTRAINT [PK_TblNhanVien] PRIMARY KEY CLUSTERED 
(
	[Manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblSanPham]    Script Date: 5/30/2022 2:42:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSanPham](
	[Masanpham] [nvarchar](50) NOT NULL,
	[Tensanpham] [nvarchar](50) NULL,
	[Maloaisp] [nvarchar](50) NULL,
	[Soluong] [float] NULL,
	[Dongianhap] [float] NULL,
	[Dongiaban] [float] NULL,
	[Anh] [nvarchar](50) NULL,
	[Ghichu] [nvarchar](100) NULL,
 CONSTRAINT [PK_TblSanPham] PRIMARY KEY CLUSTERED 
(
	[Masanpham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
GO
INSERT [dbo].[TblLogin] ([Id], [TenDangNhap], [MatKhau], [Quyen]) VALUES (N'TK001', N'admin', N'111', N'Admin')
INSERT [dbo].[TblLogin] ([Id], [TenDangNhap], [MatKhau], [Quyen]) VALUES (N'TK002', N'nhanvien', N'123', N'Nhân Viên')
INSERT [dbo].[TblLogin] ([Id], [TenDangNhap], [MatKhau], [Quyen]) VALUES (N'TK003', N'nhanvien1', N'1234', N'Nhân Viên')
GO

ALTER TABLE [dbo].[TblChiTietHDBan]  WITH CHECK ADD  CONSTRAINT [FK_TblChiTietHDBan_TblHoaDonBan] FOREIGN KEY([Mahdban])
REFERENCES [dbo].[TblHoaDonBan] ([Mahdban])
GO
ALTER TABLE [dbo].[TblChiTietHDBan] CHECK CONSTRAINT [FK_TblChiTietHDBan_TblHoaDonBan]
GO
ALTER TABLE [dbo].[TblChiTietHDBan]  WITH CHECK ADD  CONSTRAINT [FK_TblChiTietHDBan_TblSanPham] FOREIGN KEY([Masanpham])
REFERENCES [dbo].[TblSanPham] ([Masanpham])
GO
ALTER TABLE [dbo].[TblChiTietHDBan] CHECK CONSTRAINT [FK_TblChiTietHDBan_TblSanPham]
GO
ALTER TABLE [dbo].[TblHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_TblHoaDonBan_TblKhachHang] FOREIGN KEY([Makhachhang])
REFERENCES [dbo].[TblKhachHang] ([Makhachhang])
GO
ALTER TABLE [dbo].[TblHoaDonBan] CHECK CONSTRAINT [FK_TblHoaDonBan_TblKhachHang]
GO
ALTER TABLE [dbo].[TblHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_TblHoaDonBan_TblNhanVien] FOREIGN KEY([Manhanvien])
REFERENCES [dbo].[TblNhanVien] ([Manhanvien])
GO
ALTER TABLE [dbo].[TblHoaDonBan] CHECK CONSTRAINT [FK_TblHoaDonBan_TblNhanVien]
GO
ALTER TABLE [dbo].[TblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_TblSanPham_TblLoaiSanPham] FOREIGN KEY([Maloaisp])
REFERENCES [dbo].[TblLoaiSanPham] ([Maloaisp])
GO
ALTER TABLE [dbo].[TblSanPham] CHECK CONSTRAINT [FK_TblSanPham_TblLoaiSanPham]
GO
