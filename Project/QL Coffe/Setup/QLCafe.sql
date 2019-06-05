CREATE DATABASE QuanLyCafe
GO

 USE  QuanLyCafe
 GO

 CREATE TABLE UserLog
 (
	ID INT IDENTITY(1,1) PRIMARY KEY,
	UserName NVARCHAR(50) NOT NULL,
	Pass NVARCHAR(50) NOT NULL,
	TypeUser INT NOT NULL
 );
 Go
 
 CREATE TABLE Menu
 (
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(50),
	SL INT,
	Dongia FLOAT,
	ImageM NVARCHAR(100)

 );
 GO
 CREATE TABLE Nhanvien
 (
  ID INT IDENTITY(1,1) PRIMARY KEY,
  Name NVARCHAR(50),
  Phone NVARCHAR(50),
  IDcard NVARCHAR(50),
  ChucVu NVARCHAR(50),
  img NVARCHAR(50)
 );
 
 GO
 CREATE TABLE Ban
 (
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(20),
	Khuvuc NVARCHAR(5),
	STT INT
 );

 
 GO
 
 CREATE TABLE HoaDon
 (
	MAHD INT IDENTITY(1,1) PRIMARY KEY,
	MABAN INT FOREIGN KEY(MABAN) REFERENCES dbo.Ban(ID),
	MANV INT
 );
GO

CREATE TABLE CTHoaDon
(
	MACTHD INT IDENTITY(1,1) PRIMARY KEY,
	MAHD INT FOREIGN KEY(MAHD) REFERENCES dbo.HoaDon(MAHD),
	MASP INT FOREIGN KEY(MASP) REFERENCES dbo.Menu(ID),
	SL INT
);
GO

CREATE TABLE ThongKe
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	IDBAN INT FOREIGN KEY(IDBAN) REFERENCES dbo.Ban(ID),
	NGAY DATETIME,
	TongTien FLOAT
);
GO

CREATE TABLE Kho
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	NAME NVARCHAR(50),
	IDMENU INT,
	SOL INT,
	DONGIA FLOAT
);



GO


SELECT * FROM dbo.UserLog
GO

--
INSERT INTO dbo.UserLog
        ( UserName, Pass, TypeUser )
VALUES  ( N'admin', -- UserName - nvarchar(50)
          N'admin', -- Pass - nvarchar(50)
          0  -- TypeUser - int
          )




--user
GO
CREATE PROC usp_changePass
@us NCHAR(50),
@pass NCHAR(50)
AS
BEGIN
UPDATE dbo.UserLog
SET Pass =@pass
WHERE UserName = @us
END
GO


EXEC dbo.usp_changePass @us = N'', -- nchar(50)
    @pass = N'' -- nchar(50)


--




--Bao cao
GO
CREATE PROC usp_insertBaoCao
@IDBan INT,
@Tongtien FLOAT
AS
BEGIN
INSERT INTO dbo.ThongKe
        (  IDBAN, NGAY, TongTien )
VALUES  (  -- ID - int
          @IDBan, -- IDBAN - int
          GETDATE(), -- NGAY - datetime
          @Tongtien  -- TongTien - float
          )
END
GO


GO
CREATE PROC usp_GetBaoCao
@Start DATETIME,
@End DATETIME
AS
BEGIN
SELECT b.Name AS N'Tên Bàn',tk.NGAY AS N'Ngày', tk.TongTien AS N'Tổng Tiền' FROM dbo.ThongKe tk,dbo.Ban b WHERE tk.NGAY>@Start AND tk.NGAY<@End
END

GO



--Bao Cáo

--Kho
GO
CREATE PROC usp_NhapSP
@ID INT,
@SOL INT,
@DONGIA FLOAT
AS
BEGIN
UPDATE dbo.Kho
SET SOL = SOL+@SOL,DONGIA = @DONGIA
WHERE ID = @ID
END
GO


GO
CREATE PROC ThemSPMoi
@IDMENU INT,
@Name NVARCHAR(50),
@SOL INT,
@DONGIA FLOAT
AS
BEGIN
INSERT INTO dbo.Kho
        (  NAME, IDMENU, SOL, DONGIA )
VALUES  (  -- ID - int
         @Name, -- NAME - nvarchar(50)
          @IDMENU, -- IDMENU - int
          @SOL, -- SOL - int
         @DONGIA  -- DONGIA - float
          )
END

GO

CREATE PROC usp_xuat
@IDMENU INT,
@SOL INT
AS
BEGIN
UPDATE dbo.Kho
SET SOL = SOL-@SOL
WHERE IDMENU = @IDMENU
END

GO
CREATE PROC usp_xuatmenu
@IDMENU INT,
@SOL INT
AS
BEGIN
UPDATE dbo.Menu
SET SL = SL-@SOL
WHERE ID = @IDMENU
END







--KHo


















--HOADON




CREATE PROC usp_getHD
@MABAN INT
AS
BEGIN

SELECT * FROM dbo.HoaDon WHERE MABAN = @MABAN

END


GO


CREATE PROC usp_getCTHD
@MABAN INT
AS
BEGIN
DECLARE @MAHD INT
SELECT @MAHD = dbo.HoaDon.MAHD FROM dbo.HoaDon WHERE MABAN = @MABAN
SELECT * FROM dbo.CTHoaDon WHERE MAHD = @MAHD
END
GO

CREATE PROC usp_getCTHDII
@MABAN INT
AS
BEGIN
DECLARE @MAHD INT
SELECT @MAHD = dbo.HoaDon.MAHD FROM dbo.HoaDon WHERE MABAN = @MABAN
SELECT * FROM dbo.CTHoaDon,dbo.Menu  WHERE MAHD = @MAHD AND MASP =ID
END

GO

CREATE PROC usp_updateCTHD
@Maban INT,
@Masp INT,
@Sl INT
AS
BEGIN
DECLARE @MaHD INT
SELECT @MaHD = MAHD FROM dbo.HoaDon WHERE MABAN=@Maban
UPDATE dbo.CTHoaDon
SET SL = @Sl
WHERE MAHD = @MaHD AND MASP = @Masp
END
GO

CREATE PROC usp_ThanhToan
@IDban INT 
AS
BEGIN
DECLARE @IDHD INT
SELECT @IDHD = MAHD FROM dbo.HoaDon WHERE MABAN = @IDban
DELETE dbo.CTHoaDon WHERE MAHD = @IDHD
DELETE dbo.HoaDon WHERE MAHD = @IDHD
END









GO

CREATE PROC usp_InsertHD
@MABAN INT,
@MANV INT
AS
BEGIN
INSERT INTO dbo.HoaDon
        (  MABAN, MANV )
VALUES  (  -- MAHD - int
          @MABAN, -- MABAN - int
          @MANV  -- MANV - int
          )
END
GO


CREATE PROC usp_InsertCTHD
@MAHD INT,
@MASP INT,
@SL INT
AS
BEGIN 
INSERT INTO dbo.CTHoaDon
        (  MAHD, MASP, SL )
VALUES  ( -- MACTHD - int
          @MAHD, -- MAHD - int
          @MASP, -- MASP - int
          @SL  -- SL - int
          )
END
GO
CREATE PROC insertCTHDbyID
@IDBAN INT,
@MASP INT,
@SL INT
AS
BEGIN
DECLARE @MAHD INT
SELECT @MAHD = dbo.HoaDon.MAHD FROM dbo.HoaDon WHERE MABAN = @IDBAN
INSERT INTO dbo.CTHoaDon
        (  MAHD, MASP, SL )
VALUES  ( -- MACTHD - int
          @MAHD, -- MAHD - int
          @MASP, -- MASP - int
          @SL  -- SL - int
          )
END
GO
CREATE PROC usp_deleteCTHD
@IDBan INT,
@IDSP INT
AS
BEGIN
DECLARE @IDHD INT
SELECT @IDHD = MAHD FROM dbo.HoaDon WHERE MABAN = @IDBan
DELETE dbo.CTHoaDon WHERE MAHD = @IDHD AND MASP = @IDSP
END


GO
CREATE PROC usp_deleteHD
@Maban INT
AS
BEGIN
DELETE dbo.HoaDon WHERE MABAN = @Maban
END
GO


CREATE PROC usp_getHDTT
@Idban INT
AS
BEGIN
DECLARE @IDHD INT
SELECT @IDHD = MAHD FROM dbo.HoaDon WHERE MABAN = @Idban
SELECT mn.Name AS N'Tên Sản Phẩm' , hd.SL AS N'Số Lượng' , mn.Dongia AS N'Đơn Giá'    FROM dbo.CTHoaDon hd,dbo.Menu mn WHERE MAHD = @IDHD AND mn.ID= hd.MASP
END






GO


	

--HOADON







 --Menu
 CREATE PROC usp_insertMenu
 @Name NVARCHAR(50),
 @Sl INT,
 @Dongia FLOAT,
 @Img NVARCHAR(50)
 AS
 BEGIN
 INSERT dbo.Menu
         ( Name, SL, Dongia, ImageM )
 VALUES  ( @Name, -- Name - nvarchar(50)
           @Sl, -- SL - int
           @Dongia, -- Dongia - float
           @Img  -- ImageM - nvarchar(100)
           )

 END
 GO
 CREATE PROC usp_updateMenu
 @ID INT,
 @Dongia FLOAT
 AS
 BEGIN
 UPDATE dbo.Menu
 SET Dongia = @Dongia
 WHERE ID = @ID
 END
 GO
 
 CREATE PROC usp_deleteMenu
 @ID INT
 AS
 BEGIN
 DELETE dbo.Menu WHERE ID = @ID
 END
 GO
 

 
 
 
 GO
 CREATE PROC usp_updateSLmenu
 @ID INT,
 @SL INT
 AS
 BEGIN 
 UPDATE dbo.Menu
 SET SL = SL+ @SL
 WHERE ID = @ID
 END
 GO
 EXEC dbo.usp_updateSLmenu @ID = 0, -- int
     @SL = 0 -- int
 


 --Menu


 GO
 




--Ban
GO

CREATE PROC usp_insertBan
@Name NVARCHAR(20),
@Khuvuc NVARCHAR(5),
@Stt INT
AS
BEGIN
INSERT INTO dbo.Ban
        ( Name, Khuvuc, STT )
VALUES  (      -- ID - int
          @Name, -- Name - nvarchar(20)
          @Khuvuc, -- Khuvuc - nvarchar(5)
          @Stt  -- STT - int
          )
END
GO

CREATE PROC usp_deleteban
@ID INT
AS
BEGIN
DELETE dbo.Ban WHERE ID = @ID
END

GO
CREATE PROC usp_updatestt
@ID INT,
@Stt INT
AS
BEGIN
UPDATE dbo.Ban
SET STT = @Stt
WHERE ID = @ID
END
GO




--Ban

 --Nhan Vien

 GO

 CREATE PROC usp_insertNV
 @Name NVARCHAR(50),
 @Phone NVARCHAR(50),
 @IDcard NVARCHAR(50),
 @Chucvu NVARCHAR(50),
 @img NVARCHAR(50)
  AS
  BEGIN
  INSERT INTO dbo.Nhanvien
          (  Name, Phone, IDcard, ChucVu, img )
  VALUES  (  -- ID - int
            @Name, -- Name - nvarchar(50)
            @Phone, -- Phone - nvarchar(50)
            @IDcard, -- IDcard - nvarchar(50)
            @Chucvu, -- ChucVu - nvarchar(50)
            @img  -- img - nvarchar(50)
            )

  END
  GO
  CREATE PROC usp_updateNV
  @ID INT,
  @Name NVARCHAR(50),
  @Phone NVARCHAR(50),
  @IDcard NVARCHAR(50),
  @Chucvu NVARCHAR(50)
  AS
  BEGIN
  UPDATE dbo.Nhanvien
  SET Name = @Name,Phone = @Phone,IDcard = @IDcard,ChucVu = @Chucvu
  WHERE ID = @ID
  END
  GO
  CREATE PROC usp_deleteNV
  @ID INT
  AS
  BEGIN
  DELETE dbo.Nhanvien WHERE ID = @ID
  END

 

  

 --Nhan vien




 --insert Data


 EXEC dbo.usp_insertMenu @Name = N'Dừa Xiêm', -- nvarchar(50)
     @Sl = 100, -- int
     @Dongia = 10000.0, -- float
     @Img = N'no' -- nvarchar(50)
	 
 EXEC dbo.usp_insertMenu @Name = N'Nước C2', -- nvarchar(50)
     @Sl = 100, -- int
     @Dongia = 12000.0, -- float
     @Img = N'no' -- nvarchar(50)
	 
 EXEC dbo.usp_insertMenu @Name = N'Cafe Đá', -- nvarchar(50)
     @Sl = 100, -- int
     @Dongia = 10000.0, -- float
     @Img = N'no' -- nvarchar(50)
	 
 EXEC dbo.usp_insertMenu @Name = N'Cafe Sữa', -- nvarchar(50)
     @Sl = 100, -- int
     @Dongia = 12000.0, -- float
     @Img = N'no' -- nvarchar(50)
	 
 EXEC dbo.usp_insertMenu @Name = N'Trà Chanh', -- nvarchar(50)
     @Sl = 50, -- int
     @Dongia = 15000.0, -- float
     @Img = N'no' -- nvarchar(50)
	 
 EXEC dbo.usp_insertMenu @Name = N'Nước Không Độ', -- nvarchar(50)
     @Sl = 100, -- int
     @Dongia = 10000.0, -- float
     @Img = N'no' -- nvarchar(50)
	 
 EXEC dbo.usp_insertMenu @Name = N'Dr.Thanh', -- nvarchar(50)
     @Sl = 100, -- int
     @Dongia = 10000.0, -- float
     @Img = N'no' -- nvarchar(50)
 


 



 GO
 EXEC dbo.ThemSPMoi @IDMENU = 1, -- int
     @Name = N'Dừa Xiêm', -- nvarchar(50)
     @SOL = 100, -- int
     @DONGIA = 10000.0 -- float

GO

     
 EXEC dbo.ThemSPMoi @IDMENU = 2, -- int
     @Name = N'Nước C2', -- nvarchar(50)
     @SOL = 100, -- int
     @DONGIA = 12000.0 -- float
GO

EXEC dbo.ThemSPMoi @IDMENU = 3, -- int
     @Name = N'Cafe Đá', -- nvarchar(50)
     @SOL = 100, -- int
     @DONGIA = 10000.0 -- float

GO
EXEC dbo.ThemSPMoi @IDMENU = 4, -- int
     @Name = N'Cafe sữa', -- nvarchar(50)
     @SOL = 100, -- int
     @DONGIA = 12000.0 -- float

GO

 EXEC dbo.ThemSPMoi @IDMENU = 5, -- int
     @Name = N'Trà Chanh', -- nvarchar(50)
     @SOL = 50, -- int
     @DONGIA = 15000.0 -- float
GO

EXEC dbo.ThemSPMoi @IDMENU = 6, -- int
     @Name = N'Không Độ', -- nvarchar(50)
     @SOL = 100, -- in
     @DONGIA = 10000.0 -- float

GO

EXEC dbo.ThemSPMoi @IDMENU = 7, -- int
     @Name = N'Dr.Thanh', -- nvarchar(50)
     @SOL = 100, -- in
     @DONGIA = 10000.0 -- float




	 Select @@version


 





 --