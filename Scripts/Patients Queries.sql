--esto es un comentario
/*
create database MedicDb 
go
use MedicDb
go

 create table Patients
 (
 Id int  identity (1000,1) primary key,  --not null
 Record varchar (10), 
 Name  varchar (30) not null,  --Nvarchar, varchar,  text, ntext  --string
 Lastname varchar (50) not null,
 Address varchar (250) , --null,
 IsDead bit,   -- boolean, bool
 Sex char(1),  -- nchar, char, 
 CreationDate datetime , -- date, datetime
 IngresedHour  datetime,  --time, datetime
 Balance decimal(12,4), -- numeric, decimal, money, float 99999999,9999
 --never use image
 BloodType varchar(4)
 )
 go


create table PatientVisits 
(
Id int identity (1,1) primary key, 
VisitDate datetime , 
Reason varchar(250), 
Synthoms varchar (500), 
--PatientName varchar (50)
PatientId int not null, 
foreign key (PatientId) references Patients(Id)
)
go





create table BloodType 
(
Id int identity (1,1) primary key, 
Name varchar(15)
)
go
*/

alter table Patients add  BloodTypeId int null;
alter table Patients drop column BloodType;


ALTER TABLE Patients ADD CONSTRAINT
FK_Patients_BloodType FOREIGN KEY ( BloodTypeId ) REFERENCES BloodType ( Id ) 
	
GO

--CRUD, Create, Read, Update, Delete
--create 
insert into BloodType (Name) values ('Desconocido');
insert into BloodType (Name) values ('AB+');

insert into Patients ( Lastname, Name, Address, Sex, BloodTypeId, IsDead, Balance) 
values ('Pedro pe', 'PEdro', '', 'M', 1, 'false', 155551.54)
go
insert into Patients ( Lastname, Name, Address, Sex, BloodTypeId, IsDead, Balance) 
values ('Almonte', 'Rafa', '', 'M', 1, 1, 9999.54)

insert into Patients ( Lastname, Name, Address, Sex, BloodTypeId, IsDead, Balance, record) 
values ('Pedro pe', 'PEdro', '', 'M', 1, 'false', 155551.54, '000154')
go
insert into Patients ( Lastname, Name, Address, Sex, BloodTypeId, IsDead, Balance, record) 
values ('Almonte', 'Rafa', '', 'M', 1, 1, 9999.54, '000155')
go

--read
/* disyuncion y
v y v = v 
v y f = f
f y v = f
f y f = f

conjuncion
v o v = v
v o f = v
f o v = v
f o f = f
*/

select [from]  from Patients

select * from Patients where (id >= 1000  and record is not null) or balance = '155551.5400'

select id  ContactId, Lastname, BloodTypeId, 
Name, Address,
Sex
from Patients where (id >= 1000  and record is not null) or balance = '155551.5400'


select id  ContactId, Lastname, BloodTypeId, 
[Name], Address,
Sex
from Patients p where  p.Lastname like '%OCx%'
go



select count(*) RegQuantity
from Patients where (id >= 1000  and record is not null) or balance = '155551.5400'

--dont try this at home 
select id  ContactId, Lastname, BloodTypeId, (select [name] from BloodType where id = BloodTypeId     ) as BloodTypeName,
[Name], Address,
Sex
from Patients where (id >= 1000  and record is not null) or balance = '155551.5400'
go
--neither this
select p.id  ContactId, p.Lastname, p.BloodTypeId,  b.[name]   as BloodTypeName,
p.[Name], p.Address, p.Sex
from Patients p , BloodType b
where
p.BloodTypeId = b.Id  
and  (p.id >= 1000  and record is not null) or balance = '155551.5400'

select p.id  ContactId, p.Lastname, p.BloodTypeId,  b.[name]   as BloodTypeName,
p.[Name], p.Address, p.Sex
from Patients p  
left join BloodType b on b.Id = p.BloodTypeId
where 
   (p.id >= 1000  and record is not null) or balance = '155551.5400'

   --update
   update Patients set 
   name='Altagracia' , Sex='F'
   where id= 1003
   go

    update Patients set 
   bloodtypeId= 1  
   where bloodtypeId is null

   begin transaction 
   go
       update Patients set 
   lastname = 'PPPPPP'  
   where id = 1003

   --select * from Patients

   rollback
   commit
   --delete 
   delete from Patients  where id = 1005
