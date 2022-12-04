CREATE DATABASE QuanLyCF
GO

USE QuanLyCF
GO

-- TableCF

CREATE TABLE TableCF(
	id INT IDENTITY PRIMARY KEY,
	"name" NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	"status" NVARCHAR(50) NOT NULL DEFAULT N'Trống' -- TRONG HOAC CO NGUOI
)
GO

 -- Account

 CREATE TABLE Account(
 	userName NVARCHAR(100) PRIMARY KEY,
	displayName NVARCHAR(100) NOT NULL,
	"passWord" NVARCHAR(1000) NOT NULL,
	"type" INT NOT NULL DEFAULT 0 --1: admin, 0:staff
)
GO

ALTER TABLE Account
ADD CONSTRAINT df_PassWord
DEFAULT N'20720532132149213101239102231223249249135100218' FOR passWord;


 -- Catalog
 
CREATE TABLE Category(
	id INT IDENTITY PRIMARY KEY,
	"name" NVARCHAR(100) NOT NULL  DEFAULT N'Chưa đặt tên',
)
GO


 
 -- Food
 CREATE TABLE Beverage(
	id INT IDENTITY PRIMARY KEY,
	"name" NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	CategoryId INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0,
	FOREIGN KEY (CategoryId) REFERENCES Category(id)
)
GO



 -- Bill
 CREATE TABLE Bill(
	id INT IDENTITY PRIMARY KEY,
	checkIn DATE NOT NULL DEFAULT GETDATE(),
	checkOut DATE,
	TableCFId INT NOT NULL,
	"status" INT NOT NULL DEFAULT 0, -- 0:chua tt, 1: da tt
	FOREIGN KEY (TableCFId) REFERENCES TableCF(id),

)
GO

ALTER TABLE Bill
ADD discount INT

ALTER TABLE Bill
ADD totalPrice FLOAT


select * From Bill

 -- BillInfo
 CREATE TABLE BillInfo(
	id INT IDENTITY PRIMARY KEY,
	BillId INT NOT NULL,
	BeverageId INT NOT NULL,
	qty INT NOT NULL DEFAULT 0
	FOREIGN KEY (BillId) REFERENCES Bill(id),
	FOREIGN KEY (BeverageId) REFERENCES Beverage(id)

)
GO

INSERT INTO dbo.Account(userName,displayName,"passWord","type")
VALUES('HuyAdmin','Huy','123',1);
INSERT INTO dbo.Account(userName,displayName,"passWord","type")
VALUES('TranStaff',N'Trân','123',0);
GO

CREATE PROC P_GetAccountByUserName
@userName nvarchar(100)
AS 
BEGIN 
	SELECT * FROM dbo.Account WHERE userName = @userName
END 
GO

CREATE PROC P_Login
@userName NVARCHAR(100),
@passWord NVARCHAR(100)
AS
BEGIN
	SELECT * FROM Account
	WHERE userName = @userName 
	AND passWord = @passWord
END 
GO

--add table
DECLARE @i INT = 11

WHILE @i<=20
BEGIN
	INSERT INTO TableCF(name)
	VALUES(N'Bàn ' +CAST(@i AS nvarchar(10)))
	SET @i+=1
END
GO

SELECT * FROM TableCF

CREATE PROC P_GetTableList
AS
SELECT * FROM TableCF
GO


--add category

INSERT INTO Category(name)
VALUES('Cafe');
INSERT INTO Category(name)
VALUES(N'Sinh Tố');
INSERT INTO Category(name)
VALUES(N'Nước ép');
INSERT INTO Category(name)
VALUES(N'Đá xay');


--add Beverage
INSERT INTO Beverage(name,CategoryId,price)
VALUES(N'Cafe đá', 1, 15000);
INSERT INTO Beverage(name,CategoryId,price)
VALUES(N'Cafe sữa', 1, 20000);
INSERT INTO Beverage(name,CategoryId,price)
VALUES(N'Bạc xỉu', 1,22000);
INSERT INTO Beverage(name,CategoryId,price)
VALUES(N'Sinh tố dừa', 2, 30000);
INSERT INTO Beverage(name,CategoryId,price)
VALUES(N'Sinh tố bơ', 2, 30000);
INSERT INTO Beverage(name,CategoryId,price)
VALUES(N'Sinh tố dâu', 2, 30000);
INSERT INTO Beverage(name,CategoryId,price)
VALUES(N'Nước ép cam', 3, 25000);
INSERT INTO Beverage(name,CategoryId,price)
VALUES(N'Nước ép ổi', 3,25000 );
INSERT INTO Beverage(name,CategoryId,price)
VALUES(N'Nước ép dưa hấu', 3,28000 );
INSERT INTO Beverage(name,CategoryId,price)
VALUES(N'Nước ép cà rốt', 3, 25000);
INSERT INTO Beverage(name,CategoryId,price)
VALUES(N'Orio đá xay', 4,35000);
INSERT INTO Beverage(name,CategoryId,price)
VALUES(N'Match đá xay', 4,35000 );

--add bill
INSERT INTO Bill(checkIn,checkOut,TableCFId,status)
VALUES(GETDATE(), GETDATE(), 2, 1)
INSERT INTO Bill(checkIn,checkOut,TableCFId,status)
VALUES(GETDATE(), NULL, 2, 0);
INSERT INTO Bill(checkIn,checkOut,TableCFId,status)
VALUES(GETDATE(), NULL, 3, 0);
INSERT INTO Bill(checkIn,checkOut,TableCFId,status)
VALUES(GETDATE(), NULL, 4, 0);


--add bill info

INSERT INTO BillInfo(BillId, BeverageId, qty)
VALUES(1, 2, 2);
INSERT INTO BillInfo(BillId, BeverageId, qty)
VALUES(1, 1, 1);
INSERT INTO BillInfo(BillId, BeverageId, qty)
VALUES(1, 3, 3);

INSERT INTO BillInfo(BillId, BeverageId, qty)
VALUES(2, 5, 2);
INSERT INTO BillInfo(BillId, BeverageId, qty)
VALUES(2, 7, 1);

INSERT INTO BillInfo(BillId, BeverageId, qty)
VALUES(3, 4, 1);
INSERT INTO BillInfo(BillId, BeverageId, qty)
VALUES(3, 8, 3);

INSERT INTO BillInfo(BillId, BeverageId, qty)
VALUES(4, 11, 2);

GO


CREATE PROC p_InsertBill
@idTable INT
AS
BEGIN 
	INSERT INTO Bill(checkIn,checkOut,TableCFId,status,discount)
	VALUES(GETDATE(), Null, @idTable, 0,0)

END
GO

CREATE PROC P_InsertBillInfo
@BillId INT, @BeverageId INT, @qty INT
AS
BEGIN 
	DECLARE @isExitsBillInfo INT
	DECLARE @bQTY INT

	SELECT @isExitsBillInfo = id, @bQTY = qty 
	FROM BillInfo
	WHERE Billid = @BillId AND BeverageId= @BeverageId
	IF(@isExitsBillInfo> 0)
		BEGIN
		DECLARE @newQTY INT = @bQTY + @qty
			IF(@newQTY >0)
				BEGIN
					UPDATE BillInfo SET qty = @newQTY
					WHERE BillId = @BillId AND BeverageId = @BeverageId
				END
			ELSE
				BEGIN 
					DELETE BillInfo 
					WHERE BillId = @BillId AND BeverageId = @BeverageId
				END

		END
	ELSE
		BEGIN
			INSERT INTO BillInfo(BillId, BeverageId, qty)
			VALUES(@BillId, @BeverageId, @qty);
		END
END
GO

CREATE TRIGGER TR_UpdateBillInfo
ON BillInfo FOR INSERT, UPDATE

AS
BEGIN 
	DECLARE @idBill INT
	SELECT @idBill = BillId FROM inserted
	DECLARE @idTable INT 
	SELECT @idTable = TableCFId FROM Bill
	WHERE id= @idBill AND status = 0

	UPDATE  TableCF SET status = N'Có người' WHERE id = @idTable;
END
GO

CREATE TRIGGER TR_UpdateBill
ON Bill FOR UPDATE

AS
BEGIN
	DECLARE @idBill INT 
	DECLARE @idTable INT 
	

	SELECT @idBill = id FROM inserted
	SELECT @idTable = TableCFId FROM Bill
	WHERE id = @idBill 
	DECLARE @count INT =1
	SELECT @count = COUNT(*) FROM Bill WHERE TableCFId = @idTable AND status =0
	IF(@count = 0)
			UPDATE TableCF SET status =N'Trống' WHERE id = @idTable
END
GO



CREATE PROC P_GetListBillByDate
@checkIn DATE, @checkOut DATE
AS
BEGIN
SELECT t.name AS [Bàn], b.totalPrice AS[Tổng tiền], b.checkIn AS [Ngày vào], b.checkOut AS [Ngày ra], b.discount AS [Giảm giá]
FROM Bill b, TableCF t
WHERE b.TableCFId = t.id 
AND 
checkIn >=@checkIn AND checkOut <= @checkOut
AND b.status = 1
END
GO

CREATE PROC P_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100),@passWord NVARCHAR(100), @newPass NVARCHAR(100)
AS
BEGIN 
	DECLARE @rightPass INT =0
	SELECT @rightPass= COUNT(*) FROM Account WHERE userName = @userName AND passWord = @passWord

	IF(@rightPass = 1)
		BEGIN
			IF(@newPass is NULL OR @newPass ='')
				BEGIN 
					UPDATE Account SET displayName = @displayName WHERE userName = @userName
				END
			ELSE	
				BEGIN 
					UPDATE Account SET displayName = @displayName, passWord =@newPass WHERE userName = @userName
				END
				
		END


END
GO


CREATE TRIGGER TR_DeleteBillInfo
ON BillInfo FOR DELETE
AS
BEGIN 
		DECLARE @idBillInfo INT
		DECLARE @idBill INT

		SELECT @idBillInfo = id, @idBill = deleted.BillId FROM deleted

		DECLARE @idTable INT
		SELECT @idTable = TableCFId FROM Bill WHERE id = @idBill 
		
		DECLARE @count INT = 0
		SELECT @count = COUNT(*) FROM BillInfo bi, Bill b WHERE b.id = bi.BillId AND b.id = @idBill AND b.status = 0

		IF(@count = 0)
			UPDATE TableCF SET status =N'Trống' WHERE id = @idTable
END
GO




CREATE PROC P_GetLisAccount
AS
BEGIN
SELECT userName [Tài khoản],displayName [Tên hiển thị],type [Loại] FROM Account
END
GO

CREATE PROC P_GetListBeverage
AS
BEGIN
	SELECT b.id [Mã],b.name [Tên món],c.name [Danh mục], b.price [Giá] FROM Beverage b,Category c
	WHERE b.CategoryId = c.id
END
GO

SELECT * FROM Account