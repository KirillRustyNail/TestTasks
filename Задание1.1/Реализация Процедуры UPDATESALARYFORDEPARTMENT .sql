SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UPDATESALARYFORDEPARTMENT]
	@ID int = 0,
	@PERCENT float = 0
AS
BEGIN

	SET NOCOUNT ON;

	--Создание временной таблицы
	CREATE TABLE TEMPEMPLOYEE
	(
		ID_Employee int,	
		DEPARTMENT_ID	int,
		CHIEF_ID	int,
		NAME	varchar(100),
		NEW_SALARY int,
		OLD_SALARY int,
	);

    -- Вставка данных в временную таблицу
    INSERT INTO TEMPEMPLOYEE (ID_Employee, DEPARTMENT_ID, CHIEF_ID, NAME , NEW_SALARY , OLD_SALARY)
    SELECT 
        ID_Employee,
		DEPARTMENT_ID,
		CHIEF_ID,
		NAME,
		Salary AS NewSalary,
		Salary as OLD_SALARY
    FROM 
        EMPLOYEE
    WHERE 
        DEPARTMENT_ID = @ID;

	--Обновление зарплат сотрудников
	Update TEMPEMPLOYEE set NEW_SALARY = NEW_SALARY * (1 + @PERCENT / 100) from TEMPEMPLOYEE where ID_Employee != CHIEF_ID;

	--Зарплата начальника 
	DECLARE @CHIEF_Salary int
	Select @CHIEF_Salary=OLD_SALARY From TEMPEMPLOYEE where ID_Employee = CHIEF_ID;

	-- Наибольшая зарплата сотрудников
	DECLARE @MAX_New_Salary int
	Select @MAX_New_Salary=MAX(NEW_SALARY) From TEMPEMPLOYEE where ID_Employee != CHIEF_ID;

	--Обновление зарплаты начальника
	IF @CHIEF_Salary< @MAX_New_Salary
		Update TEMPEMPLOYEE set NEW_SALARY = @MAX_New_Salary from TEMPEMPLOYEE where ID_Employee = CHIEF_ID;
		
	--Обновление зарплат сотрудников
	UPDATE EMPLOYEE
	SET SALARY = TEMPEMPLOYEE.NEW_SALARY
	FROM EMPLOYEE
	INNER JOIN TEMPEMPLOYEE ON EMPLOYEE.ID_Employee = TEMPEMPLOYEE.ID_Employee;
    
	Select * From TEMPEMPLOYEE;

	--Удаление временной таблицы
	drop table TEMPEMPLOYEE;

END
GO
