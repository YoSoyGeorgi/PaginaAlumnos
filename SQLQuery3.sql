CREATE procedure Registrar_factura
@RFC varchar(50),
@Razon_social varchar(50),
@Nombre varchar(50),
@Direccion varchar(50),
@CP varchar(50),
@Ciudad varchar(50),
@Estado varchar(50),
@Telefono varchar(50),
@Correo varchar(50),
@Concepto varchar(50),
@Imgen image,
@Id_cliente int
as
begin
insert into facturas values(@RFC, @Razon_social, @Nombre, @Direccion, @CP, @Ciudad, @Estado, @Telefono, @Correo, @Concepto, @Imgen);
set @Id_cliente=(select Id from Usuarios where Id=@Id_cliente);
end