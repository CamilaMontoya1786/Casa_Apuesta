create database dboCasaApuesta;

use dboCasaApuesta;

create table tblRegistrarse(
strNombre varchar(20)not null,
strApellido varchar(20)not null,
intEdad int not null check (intEdad >=18) ,
intCedula bigint not null,
strCorreo varchar(40)not null,
strUsuario varchar(20) not null,
strContraseña varchar(15) not null,
strConfirmacionContraseña varchar(15) not null,
primary key (intCedula));


create table tblRecargaRetiro(
intCedula bigint not null,
intMonto bigint not null check ( intMonto>10000),
foreign key (intCedula) references  tblRegistrarse(intCedula)
);

create table tblAtencionAlCliente(
intCedula bigint not null,
strAsunto varchar(20) not null,
datFecha date not null,
strMensaje varchar(100) not null,
foreign key (intCedula) references  tblRegistrarse(intCedula)
);

create table tblDeporte(
intDeporte int identity not null,
strNombreDeporte varchar (20) not null,
primary key (intDeporte));

create table tblEquipo(
intDeporte int,
strNombreEquipo varchar(20),
primary key (strNombreEquipo),
foreign key (intDeporte) references tblDeporte);

create table tblPartidos(
strNombreEquipo varchar(20) not null,
strRival varchar(20) not null,
intValorAPagar decimal not null check (intValorAPagar>0),
foreign key (strNombreEquipo) references tblEquipo);

create table tblApuesta(
intCedula bigint not null,
strNombreEquipo varchar(20) not null,
strRival varchar(20) not null,
intValorAPagar decimal not null check (intValorAPagar>0),
intMontoApuesta int not null check (intMontoApuesta >=20000),
foreign key (intCedula) references tblRegistrarse (intCedula),
foreign key (strNombreEquipo) references tblEquipo
);

-------------------------LLENADO DE TABLAS-------------------------------------
---------Tabla registrarse------------------------
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo,strUsuario, strContraseña, strConfirmacionContraseña)
values ('Carolina', 'Romero', 1025887941, 18, 'CarolinaRomero@gmail.com', 'CarolinaRomero18', 'Carolina123', 'Carolina123')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Lina', 'Murillo', 1125887941, 19, 'LinaMurillo@gmail.com', 'LinaMurillo19', 'Lina234', 'Lina234')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Estefania', 'Murillo', 1035887941, 18, 'EstefaniaMurillo@gmail.com', 'EstefaniaMurillo18', 'Estefania456', 'Estefania456')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Carolina', 'Salazar', 1045887941, 20, 'CarolinaSalazar@gmail.com', 'CarolinaSalazar20', 'CarolinaSalazar', 'CarolinaSalazar')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Damaris', 'Zapata', 1055887941, 48, 'DamarisZapata@gmail.com', 'DamarisZapata48', 'Damaris1980', 'Damaris1980')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Julieta', 'Montoya', 1065887941, 18, 'JulietaRomero@gmail.com', 'JulietaRomero18', 'Julieta101', 'Julieta101')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Dulce', 'Garzon', 1075887941, 21, 'DulceGarzon@gmail.com', 'DulceGarzon', 'Garzon12', 'Garzon12')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Celeste', 'Montoya', 1085887941, 22, 'CelesteMontoya@gmail.com', 'CelesteMontoya1', 'Celeste1', 'Celeste1')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Julian', 'Castañeda', 1095887941, 18, 'JulianCastañeda@gmail.com', 'JulianCastañeda14', 'Julian14', 'Julian14')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Sebastian', 'Restrepo', 1021887941, 30, 'SebastianRestrepo123@gmail.com', 'SebastianRestrepo', 'Sebastian123', 'Sebastian123')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Mateo', 'Garzon', 1022887941, 19, 'MateoGarzon@gmail.com', 'MateoGarzon19', 'MateoGarzon', 'MateoGarzon')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Rosa', 'Romero', 1023887941, 20, 'RosaRomero@gmail.com', 'RosaRomero178', 'Rosa178', 'Rosa178')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Michael', 'Jacson', 1024887941, 45, 'MichaelJacson@gmail.com', 'MichaelJacson198', 'Jacson198', 'Jacson198')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Juan', 'Rojas', 1026887941, 22, 'JuanRojas@gmail.com', 'JuanRojas', 'Juancito1', 'Juancito1')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Laura', 'Muñoz', 1027887941, 50, 'LauraMuñoz@gmail.com', 'LauraMuñoz188', 'Laura188', 'Laura188')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Viviana', 'Catañeda', 1028887941, 30, 'ViviaCastañeda@gmail.com', 'ViviaCastañeda130', 'Viviana130', 'Viviana130')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Paula', 'Restrepo', 1029887941, 18, 'PaulaRestrepo@gmail.com', 'PaulaRestrepo100', 'Restrepo100', 'Restrepo100')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Pablo', 'Salazar', 1025817941, 18, 'PabloSalazar@gmail.com', 'PabloSala1002', 'Pablo1002', 'Pablo1002')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Jhay', 'Murillo', 1025827941, 18, 'JhayMurillo@gmail.com', 'JhayMurillo109', 'Jhay109', 'Jhay109')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Luis', 'Perez', 1025847941, 26, 'LuisPerez@gmail.com', 'Luispp', 'Luis999', 'FernandoOrt00')
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Rolando', 'Cruz', 1025847942, 36, 'RolandoCruz@gmail.com', 'Rolando989', 'Rolandito', 'Rolandito')
-----Este dato no lo deja ingresar por restricciones
insert into tblRegistrarse( strNombre, strApellido, intCedula, intEdad, strCorreo, strUsuario, strContraseña, strConfirmacionContraseña)
values ('Fernando', 'Ortega', 1025837941, 15, 'FernandoOrtega@gmail.com', 'FernandoOrt', 'FernandoOrt00', 'FernandoOrt00')

select*from tblRegistrarse;

----------Tabla recarga y retiro------------
insert into tblRecargaRetiro (intCedula, intMonto)
values(1025887941,12000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1125887941,19000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1035887941,22000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1045887941,30000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1055887941,35000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1065887941,40000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1075887941,45000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1085887941,46000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1095887941,50000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1021887941,55000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1022887941,70000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1023887941,75000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1024887941,80000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1026887941,88000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1027887941,90000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1028887941,93000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1029887941,91000)---
insert into tblRecargaRetiro (intCedula, intMonto)
values(1025817941,21000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1025827941,17000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1025847942,99000)
insert into tblRecargaRetiro (intCedula, intMonto)
values(1025847941,99000)

--Este no se ingresa por restricción
insert into tblRecargaRetiro (intCedula, intMonto)
values(1025847941,9000)

select* from tblRecargaRetiro
------- Peticiones Quejas Reclamos Sugerencias

---Tabla Atencion al cliente------------
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1025887941,'Peticiones', '2023-05-24','Habilitarme la opción para retirar un monto menor a 10000')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1125887941,'Peticiones', '2023-01-22','Habilitarme la opción para retirar un monto menor a 10000')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1035887941,'Quejas', '2021-05-19','El botón devolverme no funciona')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1045887941,'Quejas', '2021-05-20','El botón devolverme no funciona')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1055887941,'Reclamo', '2020-04-24','No se refleja las recargar nuevas a la cuenta')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1065887941,'Reclamo', '2020-04-25','No se refleja las recargar nuevas a la cuenta')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1075887941,'Peticiones', '2023-02-04','Habilitarme la opción para retirar un monto menor a 10000')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1085887941,'Peticiones', '2022-10-12','Habilitarme la opción para retirar un monto menor a 10000')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1095887941,'Quejas', '2021-09-23','El botón devolverme no funciona')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1021887941,'Quejas', '2020-04-14','El botón devolverme no funciona')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1022887941,'Reclamo', '2023-08-24','No se refleja las recargar nuevas a la cuenta')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1023887941,'Reclamo', '2023-01-24','No se refleja las recargar nuevas a la cuenta')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1024887941,'Sugerencias', '2019-03-13','Permitir las recargas y retiros menores a 10000')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1026887941,'Sugerencias', '2020-04-12','Permitir las recargas y retiros menores a 10000')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1027887941,'Sugerencias', '2021-11-26','Permitir las recargas y retiros menores a 10000')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1028887941,'Sugerencias', '2018-05-13','Que se puedan realizar apuestas desde 10000')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1029887941,'Sugerencias', '2023-06-19','Que se puedan realizar apuestas desde 10000')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1025817941,'Sugerencias', '2023-05-24','Que se puedan realizar apuestas desde 10000')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1025827941,'Reclamos', '2023-05-24','No me permite retirar el dinero de la cuenta')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1025847942,'Reclamos', '2014-05-11','No me permite retirar el dinero de la cuenta')
insert into tblAtencionAlCliente (intCedula,strAsunto,datFecha,strMensaje)
values(1025847941,'Reclamos', '2019-09-09','No me permite retirar el dinero de la cuenta')

select*from tblAtencionAlCliente;

---------Tabla deporte----------------------
insert into tblDeporte(strNombreDeporte)
values ('Futbol')
insert into tblDeporte(strNombreDeporte)
values ('Baloncesto')
insert into tblDeporte(strNombreDeporte)
values ('Boxeo')

select*from tblDeporte

-------------Tabla equipos---------------------------
insert into tblEquipo (intDeporte,strNombreEquipo)
values (1, 'Nacional')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (1, 'Cali')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (1, 'Millonarios')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (1, 'Pereira')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (1, 'Medellin')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (1, 'Real Madrid')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (1, 'Barcelona')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (1, 'Manchester City')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (1, 'Juventus')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (2, 'Lakers')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (2, 'Boston Celtics')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (2, 'Nets')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (2, 'Chicago Bulls')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (2, 'Spurs')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (3, 'Alvares')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (3, 'Manny Pacquiao')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (3, 'Josh Taylor')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (3, 'Muhammad Ali')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (3, 'Floyd Mayweather')
insert into tblEquipo (intDeporte,strNombreEquipo)
values (3, 'Willie Pep')

select*from tblEquipo

-----------------Tabla partidos---------------------------------
--Futbol
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Nacional', 'Cali', 2)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Nacional', 'Medellin', 3)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Nacional', 'Millonarios', 4)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Cali', 'Nacional', 2)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Medellin', 'Nacional', 3)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Millonarios', 'Nacional', 4)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Pereira', 'Medellin', 3)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Real Madrid', 'Barcelona', 4)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Barcelona', 'Real Madrid', 4)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Manchester City', 'Real Madrid', 2)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Real Madrid', 'Manchesther City', 2)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Juventus', 'Barcelona', 2)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Barcelona', 'Juventus', 2)
--Baloncesto
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Boston Celtics', 'Lakers', 2)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Lakers', 'Boston Celtics', 2)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Nets', 'Chicago Bulls', 3)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Chicago Bulls', 'Nets', 3)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Spurs', 'Chicago Bulls', 2)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Chicago Bulls', 'Spurs', 2)
--Boxeo
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Alvares', 'Manny Pacquiao', 4)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Manny Pacquiao', 'Alvares', 4)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Josh Taylor', 'Muhammad Ali', 3)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Muhammad Ali', 'Josh Taylor', 3)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Floyd Mayweather', 'Willie Pep', 3)
insert into tblPartidos(strNombreEquipo,strRival, intValorAPagar)
values ('Willie Pep', 'Floyd Mayweather', 3)

select*from tblPartidos

-----Tabla de apuestas 
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1022887941,'Nacional', 'Cali', 2, 50000)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1125887941, 'Nacional', 'Medellin', 3, 25000)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1035887941,'Nacional', 'Millonarios', 4, 30000)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1045887941,'Cali', 'Nacional', 2, 80000)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1055887941,'Medellin', 'Nacional', 3, 90000)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1065887941,'Millonarios', 'Nacional', 4, 30000)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1075887941,'Pereira', 'Medellin', 3, 40000)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1085887941,'Real Madrid', 'Barcelona', 4, 45000)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1095887941,'Barcelona', 'Real Madrid', 4, 50000)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1021887941,'Manchester City', 'Real Madrid', 2, 55000)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1022887941,'Real Madrid', 'Manchesther City', 2, 60000)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1023887941,'Juventus', 'Barcelona', 2,65000)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1024887941,'Barcelona', 'Juventus', 2, 70000)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1026887941,'Boston Celtics', 'Lakers', 2,75000)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1027887941,'Lakers', 'Boston Celtics', 2,89000)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1028887941,'Nets', 'Chicago Bulls', 3, 48000)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1029887941,'Chicago Bulls', 'Nets', 3, 39000)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1025817941,'Spurs', 'Chicago Bulls', 2, 28000)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1025827941,'Chicago Bulls', 'Spurs', 2, 29500)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)
values(1025847942,'Manny Pacquiao', 'Alvares', 4, 22500)
insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)---- No se registra por la restriccion al ser menor a 20000
values(1025847941,'Manny Pacquiao', 'Alvares', 4, 22000)

insert into tblApuesta (intCedula, strNombreEquipo, strRival, intValorAPagar, intMontoApuesta)---- No se registra por la restriccion al ser menor a 20000
values(1025847941,'Manny Pacquiao', 'Alvares', 4, 14000) 

select*from tblApuesta

select * from tblApuesta
where intCedula= 1025847941

select * from tblRecargaRetiro
where intCedula= 1025847941--------Aquí se daña ejemplo (solo debería aparecer 1)


 