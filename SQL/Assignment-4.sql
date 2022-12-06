
--1.	Write a T-SQL Program to find the factorial of a given number.

declare @a int,@fact int
begin 
  set @a=5
  set @fact=1
  while (@a>1)
  begin
  set @fact = @a * @fact
  set @a = @a - 1
  end
print(@fact)
end


--2.	Create a stored procedure to generate multiplication tables up to a given number.

  create or alter procedure multiplication(@a int, @b int)
  as
  declare @c int
  begin 
    while(@b<=10)
    begin
    set @c=@a *@b
	print CAST(@a as varchar(max))+ '*' +CAST(@b as varchar(max))+ '*' +CAST(@c as varchar(max))
    set @b=@b + 1
    end
  end

  execute multiplication 9,1


--3.  Create a trigger to restrict data manipulation on EMP table during General holidays.
--Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc

--Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details

create table holiday
(Holiday_date Date,
 Holiday_name varchar(30))

 insert into holiday values('2023-01-01','NEW YEAR'),
                           ('2023-01-15','PONGAL'),
                           ('2023-01-26','REPUBLIC DAY'),
						   ('2023-08-15','INDEPENDENCE DAY')

select * from holiday
create table EMP
(empno int primary key,
 ename varchar(40) not null ,
 job  varchar (20), 
 mgrid int ,
 hiredate date ,
 sal  float , 
 comm  int,
 deptno  smallint) 

insert into EMP values (7369,'SMITH','CLERK',7902,'17-DEC-80',800,null,20),
(7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30),
(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
(7566,'JONES' ,'MANAGER',7839,'02-APR-81',2975,null,20),
(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30),
(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,null,30),
(7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,null, 10),
(7788,'SCOTT','ANALYST ',7566,'19-APR-87',3000, null, 20),
(7839,'KING','PRESIDENT',null,'17-NOV-81',5000, null, 10),
(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500, 0 ,30),
(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100, null,20),
(7900,'JAMES','CLERK',7698,'03-DEC-81',950, null,  30),
(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,null,20),
(7934 ,'MILLER','CLERK',7782,'23-JAN-82',1300, null,10)

select * from EMP

select ename ,hiredate from EMP e join holiday h on e.hiredate = h.Holiday_date group by  ename ,hiredate 


BEGIN   
DECLARE @Holiday_date date;
SELECT @Holiday_date = '2023-01-01' 
FROM        holiday h     
INNER JOIN EMP e ON e.hiredate = h.Holiday_date   
WHERE    
hiredate =  '2023-01-01';
SELECT @Holiday_date;
IF @Holiday_date  in ('15-aug-2022','26-jan-2022','16-oct-2022','14-nov-2022')  
BEGIN  
PRINT 'Due To holiday';   
END   
ELSE 
BEGIN 
PRINT 'you cannot manupulate';   
END
END




----------------------------1NF--------------------------------------
create table FirstNF(
clientno varchar(4),
cname varchar(20),
Propertyno varchar(4),
Paddress varchar(50),
rentstart date,
rentfinsh date,
rent float,
ownerno varchar(4),
oname varchar(15)
)
select * from FirstNF

insert into FirstNF values('CR76','john kay','PG4','6 lawrence st glasgow','1-jul-00','31-aug-01',350,'CO40','tina murphy'),
                          ('CR76','john kay','PG16','5 novar Dr,Glasgow','1-sep-02','01-sep-02',450,'CO93','tony shaw'),
                          ('CR56','Aline stewart ','PG4','6 lawrence st glasgow','1-jul-99','10-jun-00',350,'CO40','tina murphy'),
                          ('CR56','Aline stewart ','PG36','2 Manor Rd glasgow','10-oct-00','01-dec-01',370,'CO93','tony shaw'),
                          ('CR56','Aline stewart','PG16','5 novar Dr,Glasgow','1-nov-02','01-aug-03',450,'CO93','tony shaw')

--------------------------------2NF------------------------------------
create table Client
(clientno varchar(4),
cname varchar(20))
insert into Client values('CR76','john kay'),
                         ('CR56','Aline stewart ') 
select * from Client

create table Owner
(ownerno varchar(4),
oname varchar(15))
insert into Owner values('CO40','tina murphy'),
                        ('CO93','tony shaw')
select * from Owner

create table Rental
(clientno varchar(4),
Propertyno varchar(4),
rentstart date,
rentfinsh date)
insert into Rental values('CR76','PG4','1-jul-00','31-aug-01'),
                        ('CR76','PG16','1-sep-02','01-sep-02'),
                        ('CR56','PG4','1-jul-99','10-jun-00'),
                        ('CR56','PG36','10-oct-00','01-dec-01'),
                        ('CR56','PG16','1-nov-02','01-aug-03')
select * from   Rental

create table PropertyOwner
(Propertyno varchar(4),
Paddress varchar(50),
rent float,
ownerno varchar(4))
insert into PropertyOwner values('PG4','6 lawrence st glasgow',350,'CO40'),
                                ('PG16','5 novar Dr,Glasgow',450,'CO93'),
								('PG4','6 lawrence st glasgow',350,'CO40'),
								('PG36','2 Manor Rd glasgow',370,'CO93'),
								('PG16','5 novar Dr,Glasgow',450,'CO93')
select * from    PropertyOwner

select c.cname,r.rentstart,r.rentfinsh,p.Paddress,p.rent,o.oname from Client c 
join Rental r on c.clientno=r.clientno 
join PropertyOwner p on r.Propertyno = p.Propertyno 
join Owner o on p.ownerno = o.ownerno


