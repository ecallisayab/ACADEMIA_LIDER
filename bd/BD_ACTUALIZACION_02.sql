CREATE TABLE certificados(
codigo varchar(8) primary key,
cod_inscripcion int,
fecha datetime
);

CREATE SEQUENCE seq_certificado as int start with 1 increment by 1 minvalue 1;
 insert into usuarios (nombre_completo,usuario,contrasena,correo) 
 values ('juan mamani mamni','admin',ENCRYPTBYPASSPHRASE('password','123'),'juan@gmail.com');