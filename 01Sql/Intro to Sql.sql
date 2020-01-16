-- Comments in Sql 

-- Different Types of Queries in SQL
	-- SQL queries are case insensitive insert or INSERt or InseRT is the same, name ='Fred' === nme ='FrEd'
	-- DDL - Data Definition Language 
		-- Make changes to Database Objects (Tables, Views, Function, Stored Procedures, Triggers)
		-- CREATE, ALTER, DROP (dropping a DBO like table deletes the physical copy of the dbo like schema of the table will also be deleted)
	-- DML - Data Manipulation Language
		-- DQL - Data Query Language --> to read data -> SELECT
		-- INSERT - to add Data into the DB
		-- UPDATE - to modify existing Data in the DB
		-- DELETE - to delete existing data or table in DB (delete a record or number or records or all the records from the table but preserving the schema of the table ad indexes )
		-- TRUNCATE - delete all records along with Indexes
	-- DCL - Data Control Language, used by Admins of the DB to grant or revoke access to the users
		-- GRANT USER
		-- REVOKE USER

-- datatypes in SQL
	-- Strings - char[n]-> characters of size n, varchar(n)->variable of size n but doesn't acquire size n, nchar[]
			declare @empname char(10); 
			set @empname = 'Fred';
			select @empname as 'Employee Name', LEN(@empname) as 'Length', COUNT(@empname) as 'Number of fields in the column', UPPER(@empname) as 'Name in Upper Case';
			declare @empnames varchar(10) ;
			declare @empnameunicode nchar(10) ;-- store character in unicode format
           -- some more string manipulation functions Lower, stuff, concat,ltrim, rtrim, trim
	-- Number - tinyint, int, decimal, float, money
	-- DateTIme - to get current date and time in different formats 
			-- DateTime
			-- DateTime2
			declare @currentdate datetime;
			set @currentdate = GETDATE();
			select DATEPART(MM, @currentdate) as 'Month in Numbers', DATENAME(mm,@currentdate) as 'Month in words'
			-- date functions - datediff etc......

---  Begining with creation and manipulation with data base
create database EmployeeDb;
go;-- this ensure the that sql will execute the statement/query above and then jump to nect statement/ query after
use EmployeeDb;
go;
create schema Revature; --- Schema can be an extra layer for all your DB objects
go;
create table Revature.Employee(
-- name of the col, datatype, constraints (Identity will give auto generated value(seed, incremental))
Id int Identity(1,1),-- primary key,
fname varchar not null, -- not null is constrainmt which enforces to have a value 
lname varchar not null,
mname varchar,
age int check (age>=16 and age<=70), -- check constraint will enforce if the value added is valid as per the condition,
startdate datetime default(getdate()),
salary money default(5000),
ssn char(9) unique,
Primary key (Id)
)
-- Constraints are enforced before adding/updating a value
	-- not null
	-- unique
	-- null
	-- primary
	-- foreign
	-- check
	-- default

alter table Revature.Employee 
		 add deptid int default(1)

alter table Revature.Employee
	drop column fname, lname, mname

alter table Revature.Employee
	add fname varchar(max) not null, -- not null is constrainmt which enforces to have a value 
	lname varchar(max) not null,
	mname varchar(max)


--drop table Revature.Employee

insert into Revature.Employee(fname,lname,mname) values('Carol','Baxtor','L')

select * from Revature.Employee

delete Revature.Employee
truncate table Revature.Employee

insert into Revature.Employee(fname,lname,mname) values('Carol','Baxtor','L')
update Revature.Employee set age=40,ssn=123456789 
	where Id=1

insert into Revature.Employee(fname,lname,age,salary,ssn,deptid) values('Fred','Belotte',34,14000,'987654312',1)
update Revature.Employee set mname='J' where id =5
select * from Revature.Employee

create table Revature.Department(
Id int Primary key,
name varchar(max) not null,
phone char(10) not null
)
insert into Revature.Department values(1,'Development','9876543210'),(2,'Retention','7896541230')
alter table Revature.Employee
	add constraint FK_Dept_Employee_Id foreign key(deptId) references Revature.Department(Id)