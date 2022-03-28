CREATE database JK_Tech_DB

use Jk_Tech_DB

create table Department
(
DepaertmentId int  primary key identity(1001,1),
Name varchar(50)
)

alter table Department add Location varchar(100)
select * from Department

insert into Department values('Admin','Delhi')
insert into Department values('HR','Mumbai')
insert into Department values('IT','Bangalore')

create table Employee
(
EmployeeId int primary key identity,
Name varchar(50),
Gender varchar(10),
Designation varchar(50),
Salary int,
Deptid int ,constraint fk_did foreign key(deptid) references Department(DepaertmentId))

insert into Employee values ('Vishwas','Male','Trainee',25000,1001)

select * from Employee