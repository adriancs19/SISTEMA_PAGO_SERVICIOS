/*BASE DE DATOS, INSERTS Y PROCEDIMIENTOS PARA LA TABLA DE PAGO DE SERVICIOS DE AGUA EN LA MUNICIPALIDAD*/

create database AguaMunicipalidad
go

use AguaMunicipalidad

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


use AguaMunicipalidad
insert medidor values('4812','3051','Jose Calderón','jacs4812@gmail.com','86182932','cartago')
insert medidor values('5215','3051','Jose Calderón','jacs4812@gmail.com','86182932','cartago')
go
insert facturaCobro values('4812','15000','20201011')
insert facturaCobro values('5215','15000','20201011')
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



/*BASE DE DATOS, INSERTS Y PROCEDIMIENTOS PARA LA TABLA DE PAGO DE SERVICIOS DE AGUA EN EL AyA*/

create database AguaAyA
go

use AguaAyA

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

use AguaAyA
insert medidor values('1010','3051','Adrian Calderón','aj1999cs@gmail.com','86182932','cartago')
insert medidor values('1111','3051','Adrian Calderón','aj1999cs@gmail.com','86182932','cartago')
go
insert facturaCobro values('1010','15000','20201011')
insert facturaCobro values('1111','15000','20201011')
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



/*BASE DE DATOS, INSERTS Y PROCEDIMIENTOS PARA LA TABLA DE PAGO DE SERVICIOS DE AGUA EN LA ASADA*/

create database AguaAsada
go

use AguaAsada

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

use AguaAsada
insert medidor values('1212','3051','Jose Calderón','jacs4812@gmail.com','86182932','cartago')
insert medidor values('1313','3051','Jose Calderón','jacs4812@gmail.com','86182932','cartago')
go
insert facturaCobro values('1212','15000','20201011')
insert facturaCobro values('1313','15000','20201011')
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


use AguaAsada
select * from facturaCobro