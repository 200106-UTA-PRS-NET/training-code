------- Triggers
	---- After, Before
		-- Archive table 
		create table ArchiveEmployeeAudit(
		Id int identity not null,
		DateModified date not null default getdate(),
		comment varchar(50) null
		)
		create trigger OnUpdateEmployee
		on Revature.Employee
		for delete
		as
		begin 

			insert into ArchiveEmployeeAudit values(GETDATE(),'deleted the employee')
		end


		select * from Revature.Employee

		select * from ArchiveEmployeeAudit

		update Revature.Employee 
		set age=35 where id=5

--- Stored Procedure - Programming in SQL
		--- They necessarily don't return a value
		--- SP can be created that can return more than 1 value by using out keyword
		--- Operates on Tables and can call a function
		--- Can Manipulate table and its data as well
		-- Predefined SP
		execute sp_help 'Revature.Employee' --- Alt + F1
		exec sp_helptext 'sp_help'

		-- User Defined SP
		alter Procedure sp_GetEmployees with encryption
		As
		Begin
			select Id, Age, (fname+' '+lname) as Name  from Revature.Employee
		End


		create proc sp_GetEmployeeById
	    @id int
		as 
		begin
			select Id, Age, (fname+' '+lname) as Name  from Revature.Employee where Id=@id
		end

		exec sp_GetEmployees

		exec sp_GetEmployeeById 1

		exec sp_helptext sp_getEmployees
--- Functions -> returns a value
	--- Scalar Functions -> returns a single value
	--- Table Valued functions -> Read only
	--- Aggregrate functions -  applies on the columns -> Max, Min, Count, Average, Sum
	--- They cannot make a call to SP