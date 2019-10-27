USE [Travel_DoAn]
GO
/****** Object:  StoredProcedure [dbo].[ADD_ND]    Script Date: 10/27/2019 4:32:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ADD_ND]
@TENDN CHAR(20),@MATKHAU NCHAR(10),@TINHRANG INT,@HO NVARCHAR(30),@TEN NVARCHAR(30),
@LUONG MONEY,
@NAMSINH INT,
@GIOITINH NVARCHAR(3)
AS 
	BEGIN 
		INSERT INTO QL_NguoiDung(TenDangNhap,MatKhau,TinhTrang,Ho,Ten,Luong,NamSinh,GioiTinh) 
		VALUES ( @TENDN, @MATKHAU, @TINHRANG, @HO,@TEN, @LUONG, @NAMSINH,@GIOITINH) 
	END 

GO
/****** Object:  StoredProcedure [dbo].[ADD_USER]    Script Date: 10/27/2019 4:32:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ADD_USER] 
@TENDN NCHAR(20),
@HO NVARCHAR(30),@TEN NVARCHAR(30),@NAMSINH INT,
@LUONG MONEY,
@GIOITINH NVARCHAR(3)
AS 
	BEGIN 
		INSERT INTO QL_NguoiDung(TenDangNhap,Ho,Ten,NamSinh,Luong,GioiTinh) 
		VALUES ( @TENDN,@HO,@TEN,@NAMSINH,@LUONG,@GIOITINH) 
	END 

GO
/****** Object:  StoredProcedure [dbo].[DELATE_USER]    Script Date: 10/27/2019 4:32:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELATE_USER] @TENDN NCHAR(20)
AS
	BEGIN
		DELETE FROM QL_NguoiDung
		WHERE TenDangNhap=@TENDN
	END

GO
/****** Object:  StoredProcedure [dbo].[DELETE_USER]    Script Date: 10/27/2019 4:32:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELETE_USER] @TENDN NCHAR(20)
AS
	BEGIN
		DELETE FROM QL_NguoiDung
		WHERE TenDangNhap=@TENDN
	END

GO
/****** Object:  StoredProcedure [dbo].[INSERT_ND]    Script Date: 10/27/2019 4:32:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERT_ND]
@TENDN CHAR(20),@MATKHAU NCHAR(10),@TINHRANG INT,@HO NVARCHAR(30),@TEN NVARCHAR(30),
@LUONG MONEY,
@NAMSINH INT,
@GIOITINH NVARCHAR(3)
AS 
	BEGIN 
		INSERT INTO QL_NguoiDung(TenDangNhap,MatKhau,TinhTrang,Ho,Ten,Luong,NamSinh,GioiTinh) 
		VALUES ( @TENDN, @MATKHAU, @TINHRANG, @HO,@TEN, @LUONG, @NAMSINH,@GIOITINH) 
	END 

GO
/****** Object:  StoredProcedure [dbo].[SHOW_USER]    Script Date: 10/27/2019 4:32:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SHOW_USER] @TENDN NCHAR(20)
AS
	SELECT *
	FROM QL_NguoiDung
	WHERE TenDangNhap like '`%' + @TENDN + '%`'

GO
/****** Object:  StoredProcedure [dbo].[SHOW_USER1]    Script Date: 10/27/2019 4:32:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SHOW_USER1] 
AS
	SELECT TenDangNhap,Ho,Ten,NamSinh,GioiTinh,TinhTrang,Luong
	FROM QL_NguoiDung
	

GO
/****** Object:  StoredProcedure [dbo].[SUA_ND]    Script Date: 10/27/2019 4:32:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SUA_ND]
@TENDN CHAR(20),@MATKHAU NCHAR(10),@TINHRANG INT,@HO NVARCHAR(30),@TEN NVARCHAR(30),
@LUONG MONEY,
@NAMSINH INT,
@GIOITINH NVARCHAR(3)
AS 
	BEGIN 
		INSERT INTO QL_NguoiDung(TenDangNhap,MatKhau,TinhTrang,Ho,Ten,Luong,NamSinh,GioiTinh) 
		VALUES ( @TENDN, @MATKHAU, @TINHRANG, @HO,@TEN, @LUONG, @NAMSINH,@GIOITINH) 
	END 

GO
/****** Object:  StoredProcedure [dbo].[SUADL_ND]    Script Date: 10/27/2019 4:32:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SUADL_ND] @TENDN NCHAR(20)
AS
	BEGIN
		UPDATE QL_NguoiDung
		SET TenDangNhap='thachnguyen'
		WHERE TenDangNhap='baonguyen'
	END

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_ND]    Script Date: 10/27/2019 4:32:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATE_ND]
@TENDN NCHAR(20),@MATKHAU NCHAR(10),@TINHRANG INT,@HO NVARCHAR(30),@TEN NVARCHAR(30),
@LUONG MONEY,
@NAMSINH INT,
@GIOITINH NVARCHAR(3)
AS 
	BEGIN 
		UPDATE QL_NguoiDung
		SET MatKhau=@MATKHAU,TinhTrang=@TINHRANG,Ho=@HO, Ten=@TEN, Luong=@LUONG, NamSinh=@NAMSINH,GioiTinh=@GIOITINH
		WHERE TenDangNhap=@TENDN 
	END 

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_USER]    Script Date: 10/27/2019 4:32:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATE_USER]  @TENDN NCHAR(20),
@HO NVARCHAR(30),@TEN NVARCHAR(30),@NAMSINH INT,
@LUONG MONEY,
@GIOITINH NVARCHAR(3)
AS 
	BEGIN 
		UPDATE QL_NguoiDung
		SET TenDangNhap=@TENDN,Ho=@HO, Ten=@TEN, NamSinh=@NAMSINH,Luong=@LUONG,GioiTinh=@GIOITINH
		WHERE TenDangNhap=@TENDN 
	END 

GO
/****** Object:  StoredProcedure [dbo].[XEMDL]    Script Date: 10/27/2019 4:32:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XEMDL] @TENDN NCHAR(20)
AS
	SELECT *
	FROM QL_NguoiDung
	WHERE TenDangNhap=@TENDN

GO
/****** Object:  StoredProcedure [dbo].[XOADL]    Script Date: 10/27/2019 4:32:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XOADL] @TENDN NCHAR(20), @MANHOM NCHAR(10)
AS
	BEGIN
		DELETE FROM QL_NguoiDungNhomNguoiDung
		WHERE TenDangNhap=@TENDN
		AND MaNhom=@MANHOM
	END

GO
/****** Object:  StoredProcedure [dbo].[XOAND]    Script Date: 10/27/2019 4:32:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XOAND] @TENDN NCHAR(20)
AS
	BEGIN
		DELETE FROM QL_NguoiDung
		WHERE TenDangNhap=@TENDN
	END

GO
