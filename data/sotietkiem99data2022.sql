USE [master]
GO
/****** Object:  Database [sotietkiem99]    Script Date: 13/5/2022 5:47:22 PM ******/
CREATE DATABASE [sotietkiem99] ON  PRIMARY 
( NAME = N'sotietkiem99', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\sotietkiem99.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'sotietkiem99_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\sotietkiem99_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sotietkiem99].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sotietkiem99] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sotietkiem99] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sotietkiem99] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sotietkiem99] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sotietkiem99] SET ARITHABORT OFF 
GO
ALTER DATABASE [sotietkiem99] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [sotietkiem99] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sotietkiem99] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sotietkiem99] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sotietkiem99] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sotietkiem99] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sotietkiem99] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sotietkiem99] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sotietkiem99] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sotietkiem99] SET  DISABLE_BROKER 
GO
ALTER DATABASE [sotietkiem99] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sotietkiem99] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sotietkiem99] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sotietkiem99] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sotietkiem99] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sotietkiem99] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sotietkiem99] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sotietkiem99] SET RECOVERY FULL 
GO
ALTER DATABASE [sotietkiem99] SET  MULTI_USER 
GO
ALTER DATABASE [sotietkiem99] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sotietkiem99] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'sotietkiem99', N'ON'
GO
USE [sotietkiem99]
GO
/****** Object:  Table [dbo].[chucvu]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chucvu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_chucvu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](max) NULL,
	[ghichu] [nvarchar](max) NULL,
	[ma] [nvarchar](max) NULL,
	[ngaysinh] [nvarchar](50) NULL,
	[thangsinh] [nvarchar](50) NULL,
	[namsinh] [nchar](10) NULL,
	[ngaytao] [nvarchar](max) NULL,
	[dienthoai] [nvarchar](50) NULL,
	[diachi] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[gioitinh] [nvarchar](50) NULL,
	[cmnd] [nvarchar](50) NULL,
 CONSTRAINT [PK_khachhang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[kyhan]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kyhan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](max) NULL,
	[ghichu] [nvarchar](max) NULL,
	[laixuat] [float] NULL,
	[sothang] [int] NULL,
	[ngay] [nvarchar](50) NULL,
	[thang] [nvarchar](50) NULL,
	[nam] [nvarchar](50) NULL,
 CONSTRAINT [PK_kyhan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[matkhau] [nvarchar](50) NULL,
	[tenhienthi] [nvarchar](50) NULL,
	[idchucvu] [int] NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sotietkiem]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sotietkiem](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sothe] [nvarchar](max) NULL,
	[gio] [nvarchar](max) NULL,
	[ngay] [nvarchar](50) NULL,
	[thang] [nvarchar](50) NULL,
	[nam] [nvarchar](50) NULL,
	[tiengui] [float] NULL,
	[laixuat] [float] NULL,
	[thanhtien] [float] NULL,
	[trangthai] [nvarchar](50) NULL,
	[idkyhan] [int] NULL,
	[ngaylay] [nvarchar](max) NULL,
	[thanglay] [nvarchar](50) NULL,
	[namlay] [nvarchar](50) NULL,
	[giolay] [nvarchar](max) NULL,
	[idnhanvientao] [int] NULL,
	[sothanggui] [float] NULL,
	[idkhach] [int] NULL,
 CONSTRAINT [PK_sotietkiem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[chucvu] ON 

INSERT [dbo].[chucvu] ([id], [ten]) VALUES (1, N'Nhân viên')
INSERT [dbo].[chucvu] ([id], [ten]) VALUES (2, N'giám đốc')
INSERT [dbo].[chucvu] ([id], [ten]) VALUES (3, N'bảo vệ')
INSERT [dbo].[chucvu] ([id], [ten]) VALUES (4, N'THỰC TẬP')
SET IDENTITY_INSERT [dbo].[chucvu] OFF
SET IDENTITY_INSERT [dbo].[khachhang] ON 

INSERT [dbo].[khachhang] ([id], [ten], [ghichu], [ma], [ngaysinh], [thangsinh], [namsinh], [ngaytao], [dienthoai], [diachi], [email], [gioitinh], [cmnd]) VALUES (1, N'Nguyễn Văn Khách', N'khách hàng mới', N'kh001', N'12', N'5', N'1999      ', N'13/5/2022 5:35:36 PM', N'0972096906', N'ba đình, hà nội', N'khachmoi@gmail.com', N'NAM', N'098745612345')
INSERT [dbo].[khachhang] ([id], [ten], [ghichu], [ma], [ngaysinh], [thangsinh], [namsinh], [ngaytao], [dienthoai], [diachi], [email], [gioitinh], [cmnd]) VALUES (2, N'Nguyễn Thị Ánh', N'khách hàng mới', N'kh004', N'23', N'4', N'1996      ', N'13/5/2022 5:36:11 PM', N'0965478214', N'lào cai, sơn la', N'khachmoi@gmail.com', N'NỮ', N'0111123654')
SET IDENTITY_INSERT [dbo].[khachhang] OFF
SET IDENTITY_INSERT [dbo].[kyhan] ON 

INSERT [dbo].[kyhan] ([id], [ten], [ghichu], [laixuat], [sothang], [ngay], [thang], [nam]) VALUES (1, N'KHÔNG KỲ HẠN', N'KHÔNG', 0, 0, N'12', N'12', N'2022')
INSERT [dbo].[kyhan] ([id], [ten], [ghichu], [laixuat], [sothang], [ngay], [thang], [nam]) VALUES (2, N'1 THÁNG', N'GỬI 1 THÁNG', 2, 1, N'12', N'12', N'2022')
INSERT [dbo].[kyhan] ([id], [ten], [ghichu], [laixuat], [sothang], [ngay], [thang], [nam]) VALUES (3, N'3 THÁNG', N'GỬI 3 THÁNG', 3, 3, N'12', N'12', N'2022')
INSERT [dbo].[kyhan] ([id], [ten], [ghichu], [laixuat], [sothang], [ngay], [thang], [nam]) VALUES (4, N'6 THÁNG', N'GỬI 6 THÁNG', 6, 6, N'12', N'12', N'2022')
SET IDENTITY_INSERT [dbo].[kyhan] OFF
SET IDENTITY_INSERT [dbo].[nhanvien] ON 

INSERT [dbo].[nhanvien] ([id], [ten], [matkhau], [tenhienthi], [idchucvu]) VALUES (2, N'admin', N'e10adc3949ba59abbe56e057f20f883e', N'Quản trị', 1)
INSERT [dbo].[nhanvien] ([id], [ten], [matkhau], [tenhienthi], [idchucvu]) VALUES (3, N'khach', N'e10adc3949ba59abbe56e057f20f883e', N'khách', 2)
SET IDENTITY_INSERT [dbo].[nhanvien] OFF
SET IDENTITY_INSERT [dbo].[sotietkiem] ON 

INSERT [dbo].[sotietkiem] ([id], [sothe], [gio], [ngay], [thang], [nam], [tiengui], [laixuat], [thanhtien], [trangthai], [idkyhan], [ngaylay], [thanglay], [namlay], [giolay], [idnhanvientao], [sothanggui], [idkhach]) VALUES (1, N'12345698745', N'13/5/2022 5:40:33 PM', N'12', N'5', N'2022', 5000, 6, 180000, N'ĐANG GỬI', 4, N'11', N'11', N'2022', N'13/5/2022 5:40:33 PM', 2, 6, 2)
SET IDENTITY_INSERT [dbo].[sotietkiem] OFF
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_chucvu] FOREIGN KEY([idchucvu])
REFERENCES [dbo].[chucvu] ([id])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_chucvu]
GO
ALTER TABLE [dbo].[sotietkiem]  WITH CHECK ADD  CONSTRAINT [FK_sotietkiem_khachhang] FOREIGN KEY([idkhach])
REFERENCES [dbo].[khachhang] ([id])
GO
ALTER TABLE [dbo].[sotietkiem] CHECK CONSTRAINT [FK_sotietkiem_khachhang]
GO
ALTER TABLE [dbo].[sotietkiem]  WITH CHECK ADD  CONSTRAINT [FK_sotietkiem_kyhan] FOREIGN KEY([idkyhan])
REFERENCES [dbo].[kyhan] ([id])
GO
ALTER TABLE [dbo].[sotietkiem] CHECK CONSTRAINT [FK_sotietkiem_kyhan]
GO
ALTER TABLE [dbo].[sotietkiem]  WITH CHECK ADD  CONSTRAINT [FK_sotietkiem_nhanvien] FOREIGN KEY([idnhanvientao])
REFERENCES [dbo].[nhanvien] ([id])
GO
ALTER TABLE [dbo].[sotietkiem] CHECK CONSTRAINT [FK_sotietkiem_nhanvien]
GO
/****** Object:  StoredProcedure [dbo].[sp_chucvu_DeleteByid]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_chucvu_DeleteByid] @id int AS
BEGIN
	DELETE FROM [chucvu] WHERE id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_chucvu_Insert]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_chucvu_Insert] @ten nvarchar(50) AS
BEGIN
	INSERT INTO [chucvu] ([ten]) VALUES (@ten)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_chucvu_InsertOrUpdate]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_chucvu_InsertOrUpdate] @id int, @ten nvarchar(50) AS
IF EXISTS(SELECT 1 FROM [dbo].[chucvu] WHERE id = @id)
BEGIN
	EXEC sp_chucvu_Update @id, @ten
END
ELSE
BEGIN
	EXEC sp_chucvu_Insert @ten
END

GO
/****** Object:  StoredProcedure [dbo].[sp_chucvu_Paging]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_chucvu_Paging] @page int, @size int, @where nvarchar(max), @orderby nvarchar(max) AS
BEGIN
	DECLARE @SQL nvarchar(max)
   IF @orderby IS NULL OR LEN(@orderby) < 1
	BEGIN
		SET @orderby = 'id'
	END
	SET @SQL = 'WITH tblPagingTemp AS (SELECT ROW_NUMBER() OVER(ORDER BY ' + @orderby + ') AS RowNum, [id], [ten] FROM [chucvu]'
   IF @where IS NOT NULL AND LEN(@where) > 0
	BEGIN
		SET @SQL = @SQL + ' WHERE ' + @where
	END
   SET @SQL = @SQL + ') SELECT * FROM tblPagingTemp WHERE RowNum BETWEEN ' + CAST((@page - 1) * @size + 1 as nvarchar(100)) + ' AND ' + CAST(@size * @page as nvarchar(100))
	EXEC sp_executesql @SQL
END

GO
/****** Object:  StoredProcedure [dbo].[sp_chucvu_Search]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_chucvu_Search] @keyword nvarchar(max) AS
BEGIN
	SET @keyword = '%' + @keyword + '%'
   
	SELECT [id], [ten] FROM [chucvu] WHERE [id] LIKE @keyword OR CAST([ten] AS NVARCHAR(MAX)) LIKE @keyword
END

GO
/****** Object:  StoredProcedure [dbo].[sp_chucvu_SelectAll]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_chucvu_SelectAll] AS
BEGIN
	SELECT [id], [ten] FROM [chucvu]
END

GO
/****** Object:  StoredProcedure [dbo].[sp_chucvu_SelectByDynamic]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_chucvu_SelectByDynamic] @where nvarchar(max), @orderby nvarchar(max) AS
BEGIN
	DECLARE @SQL nvarchar(max)
	SET @SQL = 'SELECT [id], [ten] FROM [chucvu]'
   IF @where IS NOT NULL AND LEN(@where) > 0
	BEGIN
		SET @SQL = @SQL + ' WHERE ' + @where
	END
	IF @orderby IS NOT NULL AND LEN(@orderby) > 0
	BEGIN
		SET @SQL = @SQL + ' ORDER BY ' + @orderby
	END
	EXEC sp_executesql @SQL
END

GO
/****** Object:  StoredProcedure [dbo].[sp_chucvu_SelectByid]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_chucvu_SelectByid] @id int AS
BEGIN
	SELECT [id], [ten] FROM [chucvu] WHERE id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_chucvu_SelectTop]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_chucvu_SelectTop] @top int, @where nvarchar(max), @orderby nvarchar(max) AS
BEGIN
	DECLARE @SQL nvarchar(max)
	SET @SQL = 'SELECT top(' + CAST(@top as nvarchar(100)) + ') [id], [ten] FROM [chucvu]'
   IF @where IS NOT NULL AND LEN(@where) > 0
	BEGIN
		SET @SQL = @SQL + ' WHERE ' + @where
	END
	IF @orderby IS NOT NULL AND LEN(@orderby) > 0
	BEGIN
		SET @SQL = @SQL + ' ORDER BY ' + @orderby
	END
	EXEC sp_executesql @SQL
END

GO
/****** Object:  StoredProcedure [dbo].[sp_chucvu_Update]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_chucvu_Update] @id int, @ten nvarchar(50) AS
BEGIN
	UPDATE [chucvu] SET [ten] = @ten WHERE id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_khachhang_DeleteByid]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_khachhang_DeleteByid] @id int AS
BEGIN
	DELETE FROM [khachhang] WHERE id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_khachhang_Insert]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_khachhang_Insert] @ten nvarchar(max), @ghichu nvarchar(max), @ma nvarchar(max), @ngaysinh nvarchar(50), @thangsinh nvarchar(50), @namsinh nchar(10), @ngaytao nvarchar(max), @dienthoai nvarchar(50), @diachi nvarchar(max), @email nvarchar(max), @gioitinh nvarchar(50), @cmnd nvarchar(50) AS
BEGIN
	INSERT INTO [khachhang] ([ten], [ghichu], [ma], [ngaysinh], [thangsinh], [namsinh], [ngaytao], [dienthoai], [diachi], [email], [gioitinh], [cmnd]) VALUES (@ten, @ghichu, @ma, @ngaysinh, @thangsinh, @namsinh, @ngaytao, @dienthoai, @diachi, @email, @gioitinh, @cmnd)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_khachhang_InsertOrUpdate]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_khachhang_InsertOrUpdate] @id int, @ten nvarchar(max), @ghichu nvarchar(max), @ma nvarchar(max), @ngaysinh nvarchar(50), @thangsinh nvarchar(50), @namsinh nchar(10), @ngaytao nvarchar(max), @dienthoai nvarchar(50), @diachi nvarchar(max), @email nvarchar(max), @gioitinh nvarchar(50), @cmnd nvarchar(50) AS
IF EXISTS(SELECT 1 FROM [dbo].[khachhang] WHERE id = @id)
BEGIN
	EXEC sp_khachhang_Update @id, @ten, @ghichu, @ma, @ngaysinh, @thangsinh, @namsinh, @ngaytao, @dienthoai, @diachi, @email, @gioitinh, @cmnd
END
ELSE
BEGIN
	EXEC sp_khachhang_Insert @ten, @ghichu, @ma, @ngaysinh, @thangsinh, @namsinh, @ngaytao, @dienthoai, @diachi, @email, @gioitinh, @cmnd
END

GO
/****** Object:  StoredProcedure [dbo].[sp_khachhang_Paging]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_khachhang_Paging] @page int, @size int, @where nvarchar(max), @orderby nvarchar(max) AS
BEGIN
	DECLARE @SQL nvarchar(max)
   IF @orderby IS NULL OR LEN(@orderby) < 1
	BEGIN
		SET @orderby = 'id'
	END
	SET @SQL = 'WITH tblPagingTemp AS (SELECT ROW_NUMBER() OVER(ORDER BY ' + @orderby + ') AS RowNum, [id], [ten], [ghichu], [ma], [ngaysinh], [thangsinh], [namsinh], [ngaytao], [dienthoai], [diachi], [email], [gioitinh], [cmnd] FROM [khachhang]'
   IF @where IS NOT NULL AND LEN(@where) > 0
	BEGIN
		SET @SQL = @SQL + ' WHERE ' + @where
	END
   SET @SQL = @SQL + ') SELECT * FROM tblPagingTemp WHERE RowNum BETWEEN ' + CAST((@page - 1) * @size + 1 as nvarchar(100)) + ' AND ' + CAST(@size * @page as nvarchar(100))
	EXEC sp_executesql @SQL
END

GO
/****** Object:  StoredProcedure [dbo].[sp_khachhang_Search]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_khachhang_Search] @keyword nvarchar(max) AS
BEGIN
	SET @keyword = '%' + @keyword + '%'
   
	SELECT [id], [ten], [ghichu], [ma], [ngaysinh], [thangsinh], [namsinh], [ngaytao], [dienthoai], [diachi], [email], [gioitinh], [cmnd] FROM [khachhang] WHERE [id] LIKE @keyword OR CAST([ten] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([ghichu] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([ma] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([ngaysinh] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([thangsinh] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([namsinh] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([ngaytao] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([dienthoai] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([diachi] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([email] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([gioitinh] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([cmnd] AS NVARCHAR(MAX)) LIKE @keyword
END

GO
/****** Object:  StoredProcedure [dbo].[sp_khachhang_SelectAll]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_khachhang_SelectAll] AS
BEGIN
	SELECT [id], [ten], [ghichu], [ma], [ngaysinh], [thangsinh], [namsinh], [ngaytao], [dienthoai], [diachi], [email], [gioitinh], [cmnd] FROM [khachhang]
END

GO
/****** Object:  StoredProcedure [dbo].[sp_khachhang_SelectByDynamic]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_khachhang_SelectByDynamic] @where nvarchar(max), @orderby nvarchar(max) AS
BEGIN
	DECLARE @SQL nvarchar(max)
	SET @SQL = 'SELECT [id], [ten], [ghichu], [ma], [ngaysinh], [thangsinh], [namsinh], [ngaytao], [dienthoai], [diachi], [email], [gioitinh], [cmnd] FROM [khachhang]'
   IF @where IS NOT NULL AND LEN(@where) > 0
	BEGIN
		SET @SQL = @SQL + ' WHERE ' + @where
	END
	IF @orderby IS NOT NULL AND LEN(@orderby) > 0
	BEGIN
		SET @SQL = @SQL + ' ORDER BY ' + @orderby
	END
	EXEC sp_executesql @SQL
END

GO
/****** Object:  StoredProcedure [dbo].[sp_khachhang_SelectByid]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_khachhang_SelectByid] @id int AS
BEGIN
	SELECT [id], [ten], [ghichu], [ma], [ngaysinh], [thangsinh], [namsinh], [ngaytao], [dienthoai], [diachi], [email], [gioitinh], [cmnd] FROM [khachhang] WHERE id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_khachhang_SelectTop]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_khachhang_SelectTop] @top int, @where nvarchar(max), @orderby nvarchar(max) AS
BEGIN
	DECLARE @SQL nvarchar(max)
	SET @SQL = 'SELECT top(' + CAST(@top as nvarchar(100)) + ') [id], [ten], [ghichu], [ma], [ngaysinh], [thangsinh], [namsinh], [ngaytao], [dienthoai], [diachi], [email], [gioitinh], [cmnd] FROM [khachhang]'
   IF @where IS NOT NULL AND LEN(@where) > 0
	BEGIN
		SET @SQL = @SQL + ' WHERE ' + @where
	END
	IF @orderby IS NOT NULL AND LEN(@orderby) > 0
	BEGIN
		SET @SQL = @SQL + ' ORDER BY ' + @orderby
	END
	EXEC sp_executesql @SQL
END

GO
/****** Object:  StoredProcedure [dbo].[sp_khachhang_Update]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_khachhang_Update] @id int, @ten nvarchar(max), @ghichu nvarchar(max), @ma nvarchar(max), @ngaysinh nvarchar(50), @thangsinh nvarchar(50), @namsinh nchar(10), @ngaytao nvarchar(max), @dienthoai nvarchar(50), @diachi nvarchar(max), @email nvarchar(max), @gioitinh nvarchar(50), @cmnd nvarchar(50) AS
BEGIN
	UPDATE [khachhang] SET [ten] = @ten, [ghichu] = @ghichu, [ma] = @ma, [ngaysinh] = @ngaysinh, [thangsinh] = @thangsinh, [namsinh] = @namsinh, [ngaytao] = @ngaytao, [dienthoai] = @dienthoai, [diachi] = @diachi, [email] = @email, [gioitinh] = @gioitinh, [cmnd] = @cmnd WHERE id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_kyhan_DeleteByid]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_kyhan_DeleteByid] @id int AS
BEGIN
	DELETE FROM [kyhan] WHERE id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_kyhan_Insert]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_kyhan_Insert] @ten nvarchar(max), @ghichu nvarchar(max), @laixuat float(53), @sothang int, @ngay nvarchar(50), @thang nvarchar(50), @nam nvarchar(50) AS
BEGIN
	INSERT INTO [kyhan] ([ten], [ghichu], [laixuat], [sothang], [ngay], [thang], [nam]) VALUES (@ten, @ghichu, @laixuat, @sothang, @ngay, @thang, @nam)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_kyhan_InsertOrUpdate]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_kyhan_InsertOrUpdate] @id int, @ten nvarchar(max), @ghichu nvarchar(max), @laixuat float(53), @sothang int, @ngay nvarchar(50), @thang nvarchar(50), @nam nvarchar(50) AS
IF EXISTS(SELECT 1 FROM [dbo].[kyhan] WHERE id = @id)
BEGIN
	EXEC sp_kyhan_Update @id, @ten, @ghichu, @laixuat, @sothang, @ngay, @thang, @nam
END
ELSE
BEGIN
	EXEC sp_kyhan_Insert @ten, @ghichu, @laixuat, @sothang, @ngay, @thang, @nam
END

GO
/****** Object:  StoredProcedure [dbo].[sp_kyhan_Paging]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_kyhan_Paging] @page int, @size int, @where nvarchar(max), @orderby nvarchar(max) AS
BEGIN
	DECLARE @SQL nvarchar(max)
   IF @orderby IS NULL OR LEN(@orderby) < 1
	BEGIN
		SET @orderby = 'id'
	END
	SET @SQL = 'WITH tblPagingTemp AS (SELECT ROW_NUMBER() OVER(ORDER BY ' + @orderby + ') AS RowNum, [id], [ten], [ghichu], [laixuat], [sothang], [ngay], [thang], [nam] FROM [kyhan]'
   IF @where IS NOT NULL AND LEN(@where) > 0
	BEGIN
		SET @SQL = @SQL + ' WHERE ' + @where
	END
   SET @SQL = @SQL + ') SELECT * FROM tblPagingTemp WHERE RowNum BETWEEN ' + CAST((@page - 1) * @size + 1 as nvarchar(100)) + ' AND ' + CAST(@size * @page as nvarchar(100))
	EXEC sp_executesql @SQL
END

GO
/****** Object:  StoredProcedure [dbo].[sp_kyhan_Search]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_kyhan_Search] @keyword nvarchar(max) AS
BEGIN
	SET @keyword = '%' + @keyword + '%'
   
	SELECT [id], [ten], [ghichu], [laixuat], [sothang], [ngay], [thang], [nam] FROM [kyhan] WHERE [id] LIKE @keyword OR CAST([ten] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([ghichu] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([laixuat] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([sothang] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([ngay] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([thang] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([nam] AS NVARCHAR(MAX)) LIKE @keyword
END

GO
/****** Object:  StoredProcedure [dbo].[sp_kyhan_SelectAll]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_kyhan_SelectAll] AS
BEGIN
	SELECT [id], [ten], [ghichu], [laixuat], [sothang], [ngay], [thang], [nam] FROM [kyhan]
END

GO
/****** Object:  StoredProcedure [dbo].[sp_kyhan_SelectByDynamic]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_kyhan_SelectByDynamic] @where nvarchar(max), @orderby nvarchar(max) AS
BEGIN
	DECLARE @SQL nvarchar(max)
	SET @SQL = 'SELECT [id], [ten], [ghichu], [laixuat], [sothang], [ngay], [thang], [nam] FROM [kyhan]'
   IF @where IS NOT NULL AND LEN(@where) > 0
	BEGIN
		SET @SQL = @SQL + ' WHERE ' + @where
	END
	IF @orderby IS NOT NULL AND LEN(@orderby) > 0
	BEGIN
		SET @SQL = @SQL + ' ORDER BY ' + @orderby
	END
	EXEC sp_executesql @SQL
END

GO
/****** Object:  StoredProcedure [dbo].[sp_kyhan_SelectByid]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_kyhan_SelectByid] @id int AS
BEGIN
	SELECT [id], [ten], [ghichu], [laixuat], [sothang], [ngay], [thang], [nam] FROM [kyhan] WHERE id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_kyhan_SelectTop]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_kyhan_SelectTop] @top int, @where nvarchar(max), @orderby nvarchar(max) AS
BEGIN
	DECLARE @SQL nvarchar(max)
	SET @SQL = 'SELECT top(' + CAST(@top as nvarchar(100)) + ') [id], [ten], [ghichu], [laixuat], [sothang], [ngay], [thang], [nam] FROM [kyhan]'
   IF @where IS NOT NULL AND LEN(@where) > 0
	BEGIN
		SET @SQL = @SQL + ' WHERE ' + @where
	END
	IF @orderby IS NOT NULL AND LEN(@orderby) > 0
	BEGIN
		SET @SQL = @SQL + ' ORDER BY ' + @orderby
	END
	EXEC sp_executesql @SQL
END

GO
/****** Object:  StoredProcedure [dbo].[sp_kyhan_Update]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_kyhan_Update] @id int, @ten nvarchar(max), @ghichu nvarchar(max), @laixuat float(53), @sothang int, @ngay nvarchar(50), @thang nvarchar(50), @nam nvarchar(50) AS
BEGIN
	UPDATE [kyhan] SET [ten] = @ten, [ghichu] = @ghichu, [laixuat] = @laixuat, [sothang] = @sothang, [ngay] = @ngay, [thang] = @thang, [nam] = @nam WHERE id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_nhanvien_DeleteByid]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_nhanvien_DeleteByid] @id int AS
BEGIN
	DELETE FROM [nhanvien] WHERE id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_nhanvien_DeleteByidchucvu]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_nhanvien_DeleteByidchucvu] @idchucvu int AS
BEGIN
	DELETE FROM [nhanvien] WHERE idchucvu = @idchucvu
END

GO
/****** Object:  StoredProcedure [dbo].[sp_nhanvien_Insert]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_nhanvien_Insert] @ten nvarchar(50), @matkhau nvarchar(50), @tenhienthi nvarchar(50), @idchucvu int AS
BEGIN
	INSERT INTO [nhanvien] ([ten], [matkhau], [tenhienthi], [idchucvu]) VALUES (@ten, @matkhau, @tenhienthi, @idchucvu)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_nhanvien_InsertOrUpdate]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_nhanvien_InsertOrUpdate] @id int, @ten nvarchar(50), @matkhau nvarchar(50), @tenhienthi nvarchar(50), @idchucvu int AS
IF EXISTS(SELECT 1 FROM [dbo].[nhanvien] WHERE id = @id)
BEGIN
	EXEC sp_nhanvien_Update @id, @ten, @matkhau, @tenhienthi, @idchucvu
END
ELSE
BEGIN
	EXEC sp_nhanvien_Insert @ten, @matkhau, @tenhienthi, @idchucvu
END

GO
/****** Object:  StoredProcedure [dbo].[sp_nhanvien_Paging]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_nhanvien_Paging] @page int, @size int, @where nvarchar(max), @orderby nvarchar(max) AS
BEGIN
	DECLARE @SQL nvarchar(max)
   IF @orderby IS NULL OR LEN(@orderby) < 1
	BEGIN
		SET @orderby = 'id'
	END
	SET @SQL = 'WITH tblPagingTemp AS (SELECT ROW_NUMBER() OVER(ORDER BY ' + @orderby + ') AS RowNum, [id], [ten], [matkhau], [tenhienthi], [idchucvu] FROM [nhanvien]'
   IF @where IS NOT NULL AND LEN(@where) > 0
	BEGIN
		SET @SQL = @SQL + ' WHERE ' + @where
	END
   SET @SQL = @SQL + ') SELECT * FROM tblPagingTemp WHERE RowNum BETWEEN ' + CAST((@page - 1) * @size + 1 as nvarchar(100)) + ' AND ' + CAST(@size * @page as nvarchar(100))
	EXEC sp_executesql @SQL
END

GO
/****** Object:  StoredProcedure [dbo].[sp_nhanvien_Search]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_nhanvien_Search] @keyword nvarchar(max) AS
BEGIN
	SET @keyword = '%' + @keyword + '%'
   
	SELECT [id], [ten], [matkhau], [tenhienthi], [idchucvu] FROM [nhanvien] WHERE [id] LIKE @keyword OR CAST([ten] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([matkhau] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([tenhienthi] AS NVARCHAR(MAX)) LIKE @keyword OR [idchucvu] LIKE @keyword
END

GO
/****** Object:  StoredProcedure [dbo].[sp_nhanvien_SelectAll]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_nhanvien_SelectAll] AS
BEGIN
	SELECT [id], [ten], [matkhau], [tenhienthi], [idchucvu] FROM [nhanvien]
END

GO
/****** Object:  StoredProcedure [dbo].[sp_nhanvien_SelectByDynamic]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_nhanvien_SelectByDynamic] @where nvarchar(max), @orderby nvarchar(max) AS
BEGIN
	DECLARE @SQL nvarchar(max)
	SET @SQL = 'SELECT [id], [ten], [matkhau], [tenhienthi], [idchucvu] FROM [nhanvien]'
   IF @where IS NOT NULL AND LEN(@where) > 0
	BEGIN
		SET @SQL = @SQL + ' WHERE ' + @where
	END
	IF @orderby IS NOT NULL AND LEN(@orderby) > 0
	BEGIN
		SET @SQL = @SQL + ' ORDER BY ' + @orderby
	END
	EXEC sp_executesql @SQL
END

GO
/****** Object:  StoredProcedure [dbo].[sp_nhanvien_SelectByid]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_nhanvien_SelectByid] @id int AS
BEGIN
	SELECT [id], [ten], [matkhau], [tenhienthi], [idchucvu] FROM [nhanvien] WHERE id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_nhanvien_SelectByidchucvu]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_nhanvien_SelectByidchucvu] @idchucvu int AS
BEGIN
	SELECT [id], [ten], [matkhau], [tenhienthi], [idchucvu] FROM [nhanvien] WHERE idchucvu = @idchucvu
END

GO
/****** Object:  StoredProcedure [dbo].[sp_nhanvien_SelectTop]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_nhanvien_SelectTop] @top int, @where nvarchar(max), @orderby nvarchar(max) AS
BEGIN
	DECLARE @SQL nvarchar(max)
	SET @SQL = 'SELECT top(' + CAST(@top as nvarchar(100)) + ') [id], [ten], [matkhau], [tenhienthi], [idchucvu] FROM [nhanvien]'
   IF @where IS NOT NULL AND LEN(@where) > 0
	BEGIN
		SET @SQL = @SQL + ' WHERE ' + @where
	END
	IF @orderby IS NOT NULL AND LEN(@orderby) > 0
	BEGIN
		SET @SQL = @SQL + ' ORDER BY ' + @orderby
	END
	EXEC sp_executesql @SQL
END

GO
/****** Object:  StoredProcedure [dbo].[sp_nhanvien_Update]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_nhanvien_Update] @id int, @ten nvarchar(50), @matkhau nvarchar(50), @tenhienthi nvarchar(50), @idchucvu int AS
BEGIN
	UPDATE [nhanvien] SET [ten] = @ten, [matkhau] = @matkhau, [tenhienthi] = @tenhienthi, [idchucvu] = @idchucvu WHERE id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_SearchAll]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_SearchAll] @keyword NVARCHAR(100) AS
BEGIN
	DECLARE @itemTable NVARCHAR(1000)
	DECLARE @table TABLE([Column] NVARCHAR(MAX), [Table] NVARCHAR(MAX))
	DECLARE ListTable CURSOR FOR SELECT name FROM sys.tables WHERE TYPE ='u'
	OPEN ListTable
	FETCH NEXT FROM ListTable INTO @itemTable
	WHILE @@FETCH_STATUS=0
	BEGIN
		BEGIN TRY
			DECLARE @itemColumn NVARCHAR(100)
			DECLARE ListColumn CURSOR FOR SELECT name FROM sys.columns WHERE object_id=object_id(@itemTable)
			OPEN ListColumn
			FETCH NEXT FROM ListColumn INTO @itemColumn
			WHILE @@FETCH_STATUS=0
			BEGIN
				BEGIN TRY
					DECLARE @sql NVARCHAR(MAX)
					DECLARE @itemValue NVARCHAR(MAX)
					SET @sql = 'SET @itemValue = (SELECT TOP 1 [' + @itemColumn+ '] FROM ' + @itemTable + ' WHERE [' + @itemColumn + '] LIKE N''%'+@keyword+'%'')'
					EXEC dbo.Sp_ExecuteSql @sql, N'@itemValue NVARCHAR(MAX) OUTPUT', @itemValue OUTPUT
					IF @itemValue != ''
					BEGIN
						INSERT INTO @table values (@itemColumn, @itemTable )
					END
					SET @itemValue = ''
				END TRY
				BEGIN CATCH
					PRINT @@error
				END CATCH
				FETCH NEXT FROM ListColumn INTO @itemColumn
			END
			CLOSE ListColumn
			DEALLOCATE ListColumn
		END TRY
		BEGIN CATCH
			PRINT @@error
		END CATCH
		FETCH NEXT FROM ListTable INTO @itemTable
	END
	CLOSE ListTable
	DEALLOCATE ListTable
	SELECT * FROM @table
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sotietkiem_DeleteByid]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sotietkiem_DeleteByid] @id int AS
BEGIN
	DELETE FROM [sotietkiem] WHERE id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sotietkiem_DeleteByidkhach]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sotietkiem_DeleteByidkhach] @idkhach int AS
BEGIN
	DELETE FROM [sotietkiem] WHERE idkhach = @idkhach
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sotietkiem_DeleteByidkyhan]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sotietkiem_DeleteByidkyhan] @idkyhan int AS
BEGIN
	DELETE FROM [sotietkiem] WHERE idkyhan = @idkyhan
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sotietkiem_DeleteByidnhanvientao]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sotietkiem_DeleteByidnhanvientao] @idnhanvientao int AS
BEGIN
	DELETE FROM [sotietkiem] WHERE idnhanvientao = @idnhanvientao
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sotietkiem_Insert]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sotietkiem_Insert] @sothe nvarchar(max), @gio nvarchar(max), @ngay nvarchar(50), @thang nvarchar(50), @nam nvarchar(50), @tiengui float(53), @laixuat float(53), @thanhtien float(53), @trangthai nvarchar(50), @idkyhan int, @ngaylay nvarchar(max), @thanglay nvarchar(50), @namlay nvarchar(50), @giolay nvarchar(max), @idnhanvientao int, @sothanggui float(53), @idkhach int AS
BEGIN
	INSERT INTO [sotietkiem] ([sothe], [gio], [ngay], [thang], [nam], [tiengui], [laixuat], [thanhtien], [trangthai], [idkyhan], [ngaylay], [thanglay], [namlay], [giolay], [idnhanvientao], [sothanggui], [idkhach]) VALUES (@sothe, @gio, @ngay, @thang, @nam, @tiengui, @laixuat, @thanhtien, @trangthai, @idkyhan, @ngaylay, @thanglay, @namlay, @giolay, @idnhanvientao, @sothanggui, @idkhach)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sotietkiem_InsertOrUpdate]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sotietkiem_InsertOrUpdate] @id int, @sothe nvarchar(max), @gio nvarchar(max), @ngay nvarchar(50), @thang nvarchar(50), @nam nvarchar(50), @tiengui float(53), @laixuat float(53), @thanhtien float(53), @trangthai nvarchar(50), @idkyhan int, @ngaylay nvarchar(max), @thanglay nvarchar(50), @namlay nvarchar(50), @giolay nvarchar(max), @idnhanvientao int, @sothanggui float(53), @idkhach int AS
IF EXISTS(SELECT 1 FROM [dbo].[sotietkiem] WHERE id = @id)
BEGIN
	EXEC sp_sotietkiem_Update @id, @sothe, @gio, @ngay, @thang, @nam, @tiengui, @laixuat, @thanhtien, @trangthai, @idkyhan, @ngaylay, @thanglay, @namlay, @giolay, @idnhanvientao, @sothanggui, @idkhach
END
ELSE
BEGIN
	EXEC sp_sotietkiem_Insert @sothe, @gio, @ngay, @thang, @nam, @tiengui, @laixuat, @thanhtien, @trangthai, @idkyhan, @ngaylay, @thanglay, @namlay, @giolay, @idnhanvientao, @sothanggui, @idkhach
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sotietkiem_Paging]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sotietkiem_Paging] @page int, @size int, @where nvarchar(max), @orderby nvarchar(max) AS
BEGIN
	DECLARE @SQL nvarchar(max)
   IF @orderby IS NULL OR LEN(@orderby) < 1
	BEGIN
		SET @orderby = 'id'
	END
	SET @SQL = 'WITH tblPagingTemp AS (SELECT ROW_NUMBER() OVER(ORDER BY ' + @orderby + ') AS RowNum, [id], [sothe], [gio], [ngay], [thang], [nam], [tiengui], [laixuat], [thanhtien], [trangthai], [idkyhan], [ngaylay], [thanglay], [namlay], [giolay], [idnhanvientao], [sothanggui], [idkhach] FROM [sotietkiem]'
   IF @where IS NOT NULL AND LEN(@where) > 0
	BEGIN
		SET @SQL = @SQL + ' WHERE ' + @where
	END
   SET @SQL = @SQL + ') SELECT * FROM tblPagingTemp WHERE RowNum BETWEEN ' + CAST((@page - 1) * @size + 1 as nvarchar(100)) + ' AND ' + CAST(@size * @page as nvarchar(100))
	EXEC sp_executesql @SQL
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sotietkiem_Search]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sotietkiem_Search] @keyword nvarchar(max) AS
BEGIN
	SET @keyword = '%' + @keyword + '%'
   
	SELECT [id], [sothe], [gio], [ngay], [thang], [nam], [tiengui], [laixuat], [thanhtien], [trangthai], [idkyhan], [ngaylay], [thanglay], [namlay], [giolay], [idnhanvientao], [sothanggui], [idkhach] FROM [sotietkiem] WHERE [id] LIKE @keyword OR CAST([sothe] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([gio] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([ngay] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([thang] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([nam] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([tiengui] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([laixuat] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([thanhtien] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([trangthai] AS NVARCHAR(MAX)) LIKE @keyword OR [idkyhan] LIKE @keyword OR CAST([ngaylay] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([thanglay] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([namlay] AS NVARCHAR(MAX)) LIKE @keyword OR CAST([giolay] AS NVARCHAR(MAX)) LIKE @keyword OR [idnhanvientao] LIKE @keyword OR CAST([sothanggui] AS NVARCHAR(MAX)) LIKE @keyword OR [idkhach] LIKE @keyword
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sotietkiem_SelectAll]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sotietkiem_SelectAll] AS
BEGIN
	SELECT [id], [sothe], [gio], [ngay], [thang], [nam], [tiengui], [laixuat], [thanhtien], [trangthai], [idkyhan], [ngaylay], [thanglay], [namlay], [giolay], [idnhanvientao], [sothanggui], [idkhach] FROM [sotietkiem]
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sotietkiem_SelectByDynamic]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sotietkiem_SelectByDynamic] @where nvarchar(max), @orderby nvarchar(max) AS
BEGIN
	DECLARE @SQL nvarchar(max)
	SET @SQL = 'SELECT [id], [sothe], [gio], [ngay], [thang], [nam], [tiengui], [laixuat], [thanhtien], [trangthai], [idkyhan], [ngaylay], [thanglay], [namlay], [giolay], [idnhanvientao], [sothanggui], [idkhach] FROM [sotietkiem]'
   IF @where IS NOT NULL AND LEN(@where) > 0
	BEGIN
		SET @SQL = @SQL + ' WHERE ' + @where
	END
	IF @orderby IS NOT NULL AND LEN(@orderby) > 0
	BEGIN
		SET @SQL = @SQL + ' ORDER BY ' + @orderby
	END
	EXEC sp_executesql @SQL
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sotietkiem_SelectByid]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sotietkiem_SelectByid] @id int AS
BEGIN
	SELECT [id], [sothe], [gio], [ngay], [thang], [nam], [tiengui], [laixuat], [thanhtien], [trangthai], [idkyhan], [ngaylay], [thanglay], [namlay], [giolay], [idnhanvientao], [sothanggui], [idkhach] FROM [sotietkiem] WHERE id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sotietkiem_SelectByidkhach]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sotietkiem_SelectByidkhach] @idkhach int AS
BEGIN
	SELECT [id], [sothe], [gio], [ngay], [thang], [nam], [tiengui], [laixuat], [thanhtien], [trangthai], [idkyhan], [ngaylay], [thanglay], [namlay], [giolay], [idnhanvientao], [sothanggui], [idkhach] FROM [sotietkiem] WHERE idkhach = @idkhach
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sotietkiem_SelectByidkyhan]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sotietkiem_SelectByidkyhan] @idkyhan int AS
BEGIN
	SELECT [id], [sothe], [gio], [ngay], [thang], [nam], [tiengui], [laixuat], [thanhtien], [trangthai], [idkyhan], [ngaylay], [thanglay], [namlay], [giolay], [idnhanvientao], [sothanggui], [idkhach] FROM [sotietkiem] WHERE idkyhan = @idkyhan
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sotietkiem_SelectByidnhanvientao]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sotietkiem_SelectByidnhanvientao] @idnhanvientao int AS
BEGIN
	SELECT [id], [sothe], [gio], [ngay], [thang], [nam], [tiengui], [laixuat], [thanhtien], [trangthai], [idkyhan], [ngaylay], [thanglay], [namlay], [giolay], [idnhanvientao], [sothanggui], [idkhach] FROM [sotietkiem] WHERE idnhanvientao = @idnhanvientao
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sotietkiem_SelectTop]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sotietkiem_SelectTop] @top int, @where nvarchar(max), @orderby nvarchar(max) AS
BEGIN
	DECLARE @SQL nvarchar(max)
	SET @SQL = 'SELECT top(' + CAST(@top as nvarchar(100)) + ') [id], [sothe], [gio], [ngay], [thang], [nam], [tiengui], [laixuat], [thanhtien], [trangthai], [idkyhan], [ngaylay], [thanglay], [namlay], [giolay], [idnhanvientao], [sothanggui], [idkhach] FROM [sotietkiem]'
   IF @where IS NOT NULL AND LEN(@where) > 0
	BEGIN
		SET @SQL = @SQL + ' WHERE ' + @where
	END
	IF @orderby IS NOT NULL AND LEN(@orderby) > 0
	BEGIN
		SET @SQL = @SQL + ' ORDER BY ' + @orderby
	END
	EXEC sp_executesql @SQL
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sotietkiem_Update]    Script Date: 13/5/2022 5:47:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sotietkiem_Update] @id int, @sothe nvarchar(max), @gio nvarchar(max), @ngay nvarchar(50), @thang nvarchar(50), @nam nvarchar(50), @tiengui float(53), @laixuat float(53), @thanhtien float(53), @trangthai nvarchar(50), @idkyhan int, @ngaylay nvarchar(max), @thanglay nvarchar(50), @namlay nvarchar(50), @giolay nvarchar(max), @idnhanvientao int, @sothanggui float(53), @idkhach int AS
BEGIN
	UPDATE [sotietkiem] SET [sothe] = @sothe, [gio] = @gio, [ngay] = @ngay, [thang] = @thang, [nam] = @nam, [tiengui] = @tiengui, [laixuat] = @laixuat, [thanhtien] = @thanhtien, [trangthai] = @trangthai, [idkyhan] = @idkyhan, [ngaylay] = @ngaylay, [thanglay] = @thanglay, [namlay] = @namlay, [giolay] = @giolay, [idnhanvientao] = @idnhanvientao, [sothanggui] = @sothanggui, [idkhach] = @idkhach WHERE id = @id
END

GO
USE [master]
GO
ALTER DATABASE [sotietkiem99] SET  READ_WRITE 
GO
