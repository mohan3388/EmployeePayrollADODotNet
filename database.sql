
drop table employee_payroll;

create table employee_payroll
(
EmployeeId int primary key identity,
EmployeeName varchar(255),
PhoneNumber varchar(255),
Address varchar(255),
Department varchar(255),
Gender varchar(255),
BasicPay int,
Deductions int,
TaxablePay int,
Tax int,
NetPay int,
StartDate date,
City varchar(255),
Country varchar(255)
);

drop procedure SpAddNewEmployee

create procedure spSelectEmployeeData
(
@EmployeeId int,
@EmployeeName varchar(255),
@PhoneNumber varchar(255),
@Address varchar(255),
@Department varchar(255),
@Gender varchar(255),
@BasicPay int,
@Deductions int,
@TaxablePay int,
@Tax int,
@NetPay int,
@StartDate date,
@City varchar(255),
@Country varchar(255)
)
as
begin
select * from employee_payroll;
end

select*from employee_payroll

---UC---

create procedure SpAddNewEmployee
(
@EmployeeName varchar(255),
@PhoneNumber varchar(255),
@Address varchar(255),
@Department varchar(255),
@Gender varchar(255),
@BasicPay int,
@Deductions int,
@TaxablePay int,
@Tax int,
@NetPay int,
@StartDate date,
@City varchar(255),
@Country varchar(255)
)
as
begin
INSERT INTO employee_payroll(EmployeeName, PhoneNumber, Address, Department, Gender, BasicPay, Deductions, TaxablePay, Tax, NetPay,StartDate, City, Country) values(@EmployeeName, @PhoneNumber, @Address, @Department, @Gender, @BasicPay, @Deductions, @TaxablePay, @Tax, @NetPay,@StartDate, @City, @Country) 
end

create procedure spUpdateEmployeeSlaray
(
@id int,
@month varchar(255),
@salary int,
@empid int
)
as
begin
update Salary
set EmployeeSalary=@salary
where SalaryId=@id and Month=@month and EmployeeId=@empid

select e.EmployeeID,e.EmployeeName,s.JobDescription,s.EmployeeSalary,s.Month,s.SalaryId
from employee_payroll e inner join Salary s on e.EmployeeID=s.EmployeeId
where s.SalaryId=@id

end