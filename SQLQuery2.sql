create table Sample(id int, name varchar(200))
insert into Sample values(1,'Arpit')
insert into Sample values(2,'Abhi')
insert into Sample values(3,'Ayush')
insert into Sample values(4,'shivam')
select * from Sample
truncate table Sample
select * from Sample
create table Employee(id int, FirstName varchar(200), LastName varchar(200),Salary int, DepartmentId int )
insert into Employee values(1,'Arpit','Bhadoria',18000,1)
insert into Employee values(2,'Ayush','Bhadoria',18000,2)
insert into Employee values(3,'Abhi','Bhadoria',18000,3)
insert into Employee values(4,'Kapil','Bhadoria',18000,4)
create table department(id int,DepartmentName varchar(200)) 
insert into department values(1,'Admin')
insert into department values(2,'Support')
insert into department values(3,'cs')
insert into department values(4,'IT')
select e.id,e.FirstName,e.LastName,e.Salary,d.DepartmentName from Employee e inner join department d on d.id=e.DepartmentId
select e.id,e.FirstName,e.LastName,e.Salary,d.DepartmentName from Employee e full outer join department d on d.id=e.DepartmentId 
select * from department where DepartmentName like '%n'

select * from department order by DepartmentName desc

create function GetFullName(@id int)
RETURNS varchar(200) as
BEGIN
return(select CONCAT(FIRSTNAME,'',LASTNAME) FullName from Employee where id =@id);
END

select dbo.GetFullName(id) as FULLNAME from Employee

select MAX(Salary) from Employee
select MIN(Salary) from Employee
select AVG(Salary) from Employee
select Count(*) from Employee

select CONCAT(FIRSTNAME,'',LASTNAME) FullName from Employee where Salary=(select Max(salary) from Employee)
select FirstName from Employee group by FirstName
select FirstName from Employee group by FirstName having count(*)>1

select * from Employee where id between 1 and 3