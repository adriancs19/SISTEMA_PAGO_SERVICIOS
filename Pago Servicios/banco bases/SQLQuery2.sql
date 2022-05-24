create database PagoAguaMunicipalidad
go

use PagoAguaMunicipalidad

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