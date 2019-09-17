# DWA_Laboratorio5
SQl
-----------
use neptuno

create proc USP_GetCategoria
as
begin
select idcategoria,nombrecategoria,descripcion,estado
from categorias
where estado != 0
end

update categorias set estado = 1

create proc USP_InsCategoria
@idcategoria int,
@nombrecategoria varchar(100),
@descripcion text
as
begin
declare @idcategoria int
set @idcategoria = (select max(IdCategoria)+1 from categorias)
insert into categorias(idcategoria,nombrecategoria,descripcion,estado)
values(@idcategoria,@nombrecategoria,@descripcion,1)
end

alter proc USP_InsCategoria
@idcategoria int,
@nombrecategoria varchar(100),
@descripcion text
as
begin
insert into categorias(idcategoria,nombrecategoria,descripcion,estado)
values(@idcategoria,@nombrecategoria,@descripcion,1)
end



create proc USP_UpdCategoria
@idcategoria int,
@nombrecategoria varchar(100),
@descripcion text
as
begin
update categorias set nombrecategoria=@nombrecategoria, descripcion=@descripcion
where idcategoria =@idcategoria 
end

create proc USP_DelCategoria
@idcategoria int
as
begin
delete from categorias
where idcategoria =@idcategoria 
end

create proc USP_DeleteCategoria
@idcategoria int
as
begin
update categorias set estado = 0
where idcategoria =@idcategoria 
end

alter table categorias
add estado bit 


select * from categorias
select *from productos

create proc USP_GetProducto
as
begin
select idproducto,nombreProducto,idProveedor,idCategoria,cantidadPorUnidad,precioUnidad,unidadesEnExistencia
from productos
end

USP_GetProducto

use neptuno
