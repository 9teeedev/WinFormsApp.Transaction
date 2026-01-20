
Create Database Company_DB;
Go
Use Company_DB;
Go

Create Table Department(
	dept_id char(3) Not Null,
	dept_name nVarchar (30) Not Null,
	dept_desc nVarchar (200),
	dept_phone Varchar (10),
	dept_mail Varchar (10),
	Constraint PK_Department Primary Key(dept_id)
)
-- insert record
insert into Department values ('001' ,'บุคคล', ' ฝ่ายบุคคล' , '042211040','042211343')
insert into Department values ('002', 'บัญชี', ' ฝ่ายบัญชี', '042211345', ' 042234557');

CREATE PROCEDURE Insert_Department
(
    --ประกาศพารามิเตอร์
    @id     Char(3),
    @name   nVarchar(30),
    @desc   nVarchar(200),
    @phone  Varchar(10),
    @mail    Varchar(10)
)
AS
BEGIN
    Begin Transaction --เริ่มการทำงาน Transaction
    
    --ตรวจสอบข้อมูลซ้ำ ก่อนเพิ่มข้อมูล
    IF exists(Select * From Department Where dept_id = @id)
    begin --กรณีมีรหัสซ้ำ
        Rollback Transaction --ยกเลิกการทำงาน Transaction
        return -1 --ส่งค่ากลับ
    end

    Else --กรณี ไม่มีรหัสซ้ำ
    begin
        --เพิ่มข้อมูลลงในตาราง
        insert into Department(dept_id , dept_name , dept_desc , dept_phone , dept_mail)
        Values(@id , @name , @desc , @phone , @mail)

        if @@ERROR <> 0 --กรณีมี error เกิดขึ้น
        begin
            Rollback Transaction --ยกเลิกการทำงาน Transaction
            return 0 --ส่งค่ากลับ
        end
    end

    --ถ้าไม่มี error เกิดขึ้น ให้การทำงานของ Transaction เสร็จสมบูรณ์
    Commit Transaction
    return 1
END

CREATE PROCEDURE Update_Department
(
    @curr_id    Char(3), --ค่ารหัสแผนกก่อนแก้ไข
    @id         Char(3), --ค่ารหัสแผนกที่จะแก้ไข
    @name       nVarchar(30),
    @desc       nVarchar(200),
    @phone      Varchar(10),
    @mail        Varchar(10)
)
AS
BEGIN
    Begin Transaction --เริ่มการทำงาน Transaction
    --รหัสแผนกเดิมไม่เท่ากับรหัสแผนกที่แก้ไข หมายถึงมีการเปลี่ยนรหัสแผนก
    IF(@curr_id <> @id)
    begin
        --ตรวจสอบว่ารหัสที่จะแก้ไขใหม่ซ้ำหรือไม่
        if exists(Select * From Department Where dept_id = @id)
        begin --กรณีมีรหัสซ้ำ
            Rollback Transaction    --ถ้าซ้ำยกเลิกการทำงาน Transaction
            return -1 --ส่งค่ากลับ
        end
    end

    ELSE --กรณีไม่ได้แก้ไขรหัส
    begin
        --คำสั่งแก้ไขข้อมูล
        Update Department
        Set dept_id     = @id,
            dept_name   = @name,
            dept_desc   = @desc,
            dept_phone  = @phone,
            dept_mail    = @mail
        Where dept_id = @curr_id

        if @@ERROR <> 0  --กรณีมี error เกิดขึ้น
        begin
            Rollback Transaction  --ยกเลิกการทำงาน Transaction
            return 0  --ส่งค่ากลับ
        end
    end
    --ถ้าไม่มี error เกิดขึ้น ให้การทำงานของ Transaction เสร็จสมบูรณ์
    Commit Transaction
    return 1
END
