--create database Company;

--create table Employees(id int identity(1,1)primary key,first_name varchar(50) not null, 
--last_name varchar(50) not null,job_title varchar(50) not null,country varchar(50) not null,
--created_at date default current_timestamp,)
/*
create table Departments(id int primary key identity(1,1),depname varchar(50) not null,
deplocation varchar(60),employeeid int foreign key REFERENCES Employees(id));
*/

--insert into Departments(depname,deplocation,employeeid)values('IT','Muscat',1),('finance','ibri',2);
select* from Departments;
--insert into Employees(first_name,last_name,job_title,country)values('sheikha','khalifa','full stack developer','oman');

--update Employees set job_title = 'cyber security',first_name='mohammed' where id=2;
select * from Employees;
select first_name from Employees;