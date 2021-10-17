create database Hospital
use Hospital
create table Auth(Username nvarchar(20)not null primary key, Password nvarchar(20) not null)


create table Room(room_id nvarchar(10) not null primary key,room_type nvarchar(10) not null)
create table Staff(SID nvarchar(15) not null primary key, Name nvarchar(30) not null, Address nvarchar(20), tell nvarchar(15), gender nvarchar(10) not null, title nvarchar(15), dept nvarchar(15) )
create table Doctor(dr_code nvarchar(15) not null primary key, expert nvarchar(20), SID nvarchar(15) foreign key references Staff(SID))
create table Nurse(nurse_code nvarchar(15) not null primary key, Name nvarchar(30) not null, room_id nvarchar(10) foreign key references Room(room_id), SID nvarchar(15) foreign key references Staff(SID))

create table Patient(pat_id nvarchar(10) not null primary key,Name nvarchar(30) not null,room_id nvarchar(10) foreign key references Room(room_id),dr_code nvarchar(15) foreign key references Doctor(dr_code) , Address nvarchar(20), tell nvarchar(15), gender nvarchar(10) not null, date_admitted nvarchar(12) not null, date_discharged nvarchar(12))
create table Diagnosis(diag_no nvarchar(10) not null primary key, diag_details nvarchar(50), pat_id nvarchar(10) foreign key references Patient(pat_id), medication nvarchar(50), other nvarchar(50))


create table Bill( bill_no nvarchar(10) not null primary key , pat_id nvarchar(10) foreign key references Patient(pat_id) not null, Patient_Name nvarchar(30) not null,dr_name nvarchar(30) not null, date nvarchar(12) not null, amount nvarchar(20) not null )





