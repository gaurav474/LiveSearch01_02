create table EmpData(
   EmpId int primary key identity,
   EmpName varchar(40) not null,
   EmpEmail varchar(100) not null,
   EmpContact varchar(10) not null
)