/*BASE DE DATOS, INSERTS Y PROCEDIMIENTOS PARA LA TABLA DE PAGO DE SERVICIOS DE TELEFONO EN KOLBI*/

create database Telefonokolbi
go

use Telefonokolbi

create table medidor(
	codigoMedidor varchar (100) not null primary key,
	cedulaDueño varchar (100) not null,
	nombreDueño varchar (100) not null,
	coreoDueño varchar (100) not null,
	numeroTelDueño varchar (100) not null,
	ubucacion varchar (900) not null

)
go

create table facturaCobro(
    codigoMedidor varchar (100) not null primary key,
	montoPago varchar (100) not null,
	fechaVencimiento date ,
	foreign key (codigoMedidor) references medidor (codigoMedidor)
)
go

create table registroFacturacion(
	codigoMedidor varchar (100) not null,
	montoCalcelado varchar (100) not null,
	fechaPago date,
	numerocuentaCacelo varchar (100) not null,
	foreign key (codigoMedidor) references medidor (codigoMedidor)
)
go

use Telefonokolbi
insert medidor values('1414','3051','Adrian Calderón','aj1999cs@gmail.com','86182932','cartago')
insert medidor values('1515','3051','Adrian Calderón','aj1999cs@gmail.com','86182932','cartago')
go
insert facturaCobro values('1414','15000','20201011')
insert facturaCobro values('1515','15000','20201011')
go

create PROCEDURE monto 
    @medidor nvarchar(100) = '' 
AS   
select montoPago,fechaVencimiento from facturaCobro where codigoMedidor  = @medidor
GO 

create PROCEDURE cancelacion 
    @medidor nvarchar(100) = '' 
AS   
delete from facturaCobro where codigoMedidor = @medidor



/*BASE DE DATOS, INSERTS Y PROCEDIMIENTOS PARA LA TABLA DE PAGO DE SERVICIOS DE TELEFONO EN CLARO*/

create database TelefonoClaro
go

use TelefonoClaro

create table medidor(
	codigoMedidor varchar (100) not null primary key,
	cedulaDueño varchar (100) not null,
	nombreDueño varchar (100) not null,
	coreoDueño varchar (100) not null,
	numeroTelDueño varchar (100) not null,
	ubucacion varchar (900) not null

)
go

create table facturaCobro(
    codigoMedidor varchar (100) not null primary key,
	montoPago varchar (100) not null,
	fechaVencimiento date ,
	foreign key (codigoMedidor) references medidor (codigoMedidor)
)
go

create table registroFacturacion(
	codigoMedidor varchar (100) not null,
	montoCalcelado varchar (100) not null,
	fechaPago date,
	numerocuentaCacelo varchar (100) not null,
	foreign key (codigoMedidor) references medidor (codigoMedidor)
)
go

use TelefonoClaro
insert medidor values('1616','3051','Adrian Calderón','aj1999cs@gmail.com','86182932','cartago')
insert medidor values('1717','3051','Adrian Calderón','aj1999cs@gmail.com','86182932','cartago')
go
insert facturaCobro values('1616','15000','20201011')
insert facturaCobro values('1717','15000','20201011')
go

create PROCEDURE monto 
    @medidor nvarchar(100) = '' 
AS   
select montoPago,fechaVencimiento from facturaCobro where codigoMedidor  = @medidor
GO 

create PROCEDURE cancelacion 
    @medidor nvarchar(100) = '' 
AS   
delete from facturaCobro where codigoMedidor = @medidor



/*BASE DE DATOS, INSERTS Y PROCEDIMIENTOS PARA LA TABLA DE PAGO DE SERVICIOS DE TELEFONO EN MOVISTAR*/

create database TelefonoMovistar
go

use TelefonoMovistar

create table medidor(
	codigoMedidor varchar (100) not null primary key,
	cedulaDueño varchar (100) not null,
	nombreDueño varchar (100) not null,
	coreoDueño varchar (100) not null,
	numeroTelDueño varchar (100) not null,
	ubucacion varchar (900) not null

)
go

create table facturaCobro(
    codigoMedidor varchar (100) not null primary key,
	montoPago varchar (100) not null,
	fechaVencimiento date ,
	foreign key (codigoMedidor) references medidor (codigoMedidor)
)
go

create table registroFacturacion(
	codigoMedidor varchar (100) not null,
	montoCalcelado varchar (100) not null,
	fechaPago date,
	numerocuentaCacelo varchar (100) not null,
	foreign key (codigoMedidor) references medidor (codigoMedidor)
)
go

use TelefonoMovistar
insert medidor values('1818','3051','Jose Calderón','jacs4812@gmail.com','86182932','cartago')
insert medidor values('1919','3051','Jose Calderón','jacs4812@gmail.com','86182932','cartago')
go
insert facturaCobro values('1818','15000','20201011')
insert facturaCobro values('1919','15000','20201011')
go

create PROCEDURE monto 
    @medidor nvarchar(100) = '' 
AS   
select montoPago,fechaVencimiento from facturaCobro where codigoMedidor  = @medidor
GO 

create PROCEDURE cancelacion 
    @medidor nvarchar(100) = '' 
AS   
delete from facturaCobro where codigoMedidor = @medidor


use TelefonoKolbi

select * from facturacobro