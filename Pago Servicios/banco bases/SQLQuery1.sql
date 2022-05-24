create database PagoElectricidadMunicipalidad
go

use ElectricidadMunicipalidad

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

insert medidor values('4812','3051','jose','jacs4812@gmail.com','861829','cartago')
insert medidor values('5212','3051','jose','jacs4812@gmail.com','861829','cartago')

insert facturaCobro values('4812','15000','20201011')
insert facturaCobro values('5215','15000','20201011')
go

select * from facturaCobro

create PROCEDURE monto 
    @medidor nvarchar(100) = '' 
AS   
select montoPago,fechaVencimiento from facturaCobro where codigoMedidor  = @medidor
GO 

create PROCEDURE cancelacion 
    @medidor nvarchar(100) = '' 
AS   
delete from facturaCobro where codigoMedidor = @medidor