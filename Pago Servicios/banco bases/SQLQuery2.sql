create database PagoAguaMunicipalidad
go

use PagoAguaMunicipalidad

create table medidor(
	codigoMedidor varchar (100) not null primary key,
	cedulaDue�o varchar (100) not null,
	nombreDue�o varchar (100) not null,
	coreoDue�o varchar (100) not null,
	numeroTelDue�o varchar (100) not null,
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