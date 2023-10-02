CREATE DATABASE HABLEMOS;

USE HABLEMOS;

CREATE TABLE ROLES(
id_perfil int primary key auto_increment,
modulo varchar(255) not null
);

insert into roles(modulo) values('administrador'),('gestor'),('mostrador');

CREATE TABLE USUARIOS(
cedula varchar(10) primary key not null,
nombre varchar (50) not null,
pass varchar(100) not null,
email varchar(100) not null,
rol int not null,
fecha_reg TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
estado char not null default 'A',
foreign key (rol) references ROLES(id_perfil));

CREATE TABLE logs_session(
id int primary key not null,
id_usuario varchar(10) not null,
fecha_sesion TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
foreign key (id_usuario) references USUARIOS(cedula));
