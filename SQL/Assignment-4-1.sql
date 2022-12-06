
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




