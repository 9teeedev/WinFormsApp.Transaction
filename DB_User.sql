-- DB_User.sql

CREATE TABLE users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    userID NVARCHAR(50) UNIQUE,
    firstname NVARCHAR(40),
    lastname NVARCHAR(60),
    password NVARCHAR(50),
    position NVARCHAR(30)
);
GO

-- Simple add user procedure
CREATE PROCEDURE SP_AddUser
    @userID   NVARCHAR(50),
    @firstname NVARCHAR(40),
    @lastname  NVARCHAR(60),
    @password  NVARCHAR(50),
    @position  NVARCHAR(30),
    @Result    INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- ตรวจสอบว่ามี userID ซ้ำหรือไม่
    IF EXISTS (SELECT 1 FROM users WHERE userID = @userID)
    BEGIN
        -- ถ้ามี ให้คืนค่า 0
        SET @Result = 0;
    END
    ELSE
    BEGIN
        -- ถ้าไม่มี ให้เพิ่มผู้ใช้ใหม่
        INSERT INTO users (userID, firstname, lastname, password, position)
        VALUES (@userID, @firstname, @lastname, @password, @position);

        -- คืนค่า 1
        SET @Result = 1;
    END
END;
GO

-- ตัวอย่างการเรียกใช้ AddUser
DECLARE @Result INT;
EXEC AddUser
    @userID = 'rewadee.ppsn@gmail.com',
    @firstname = 'Rewadee',
    @lastname = 'Piputsoongnern',
    @password = 'kai5555',
    @position = 'Manager',
    @Result = @Result OUTPUT;
SELECT @Result AS InsertResult;
GO

-- Stored procedure that uses explicit transaction
CREATE PROCEDURE SP_AddNewUser_Transaction
    @userID    NVARCHAR(50),
    @firstname NVARCHAR(100),
    @lastname  NVARCHAR(100),
    @password  NVARCHAR(255),
    @position  NVARCHAR(100),
    @Result    INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Error INT;

    -- เริ่มต้น Transaction
    BEGIN TRANSACTION;

    -- ตรวจสอบว่ามี userID ซ้ำหรือไม่
    IF EXISTS (SELECT 1 FROM users WHERE userID = @userID)
    BEGIN
        -- ถ้ามี userID อยู่แล้ว ให้ยกเลิก Transaction และคืนค่า 0
        SET @Result = 0;
        ROLLBACK TRANSACTION;
        RETURN;
    END

    -- ถ้าไม่มี ให้เพิ่มผู้ใช้ใหม่
    INSERT INTO users (userID, firstname, lastname, password, position)
    VALUES (@userID, @firstname, @lastname, @password, @position);

    -- ตรวจสอบข้อผิดพลาด
    SET @Error = @@ERROR;
    IF @Error = 0
    BEGIN
        -- ถ้าไม่มีข้อผิดพลาด ยืนยัน Transaction และคืนค่า 1
        COMMIT TRANSACTION;
        SET @Result = 1;
    END
    ELSE
    BEGIN
        -- ถ้ามีข้อผิดพลาด ให้ยกเลิก Transaction และคืนค่า 0
        ROLLBACK TRANSACTION;
        SET @Result = 0;
    END
END;
GO

-- ตัวอย่างการเรียกใช้ SP_AddNewUser_Transaction
DECLARE @Result2 INT;
EXEC SP_AddNewUser_Transaction
    @userID = 'kunawut.bo@udru.ac.th',
    @firstname = 'Kunawut',
    @lastname = 'Boonkhwang',
    @password = 'kuna55555',
    @position = 'IT Developer',
    @Result = @Result2 OUTPUT;
SELECT @Result2 AS InsertResult;
GO