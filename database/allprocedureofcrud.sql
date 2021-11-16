create table Vegetables(Id int primary key,Name nvarchar(50) not null,Type nvarchar(50) not null,PricePerTon int not null,
FarmerName varchar(50) not null, ProductionState varchar(50) not null)

go

use [VegetableDB]
go

--add vegetable
create proc [dbo].[Vegetables_Add]
	   @Id int,
@Name nvarchar(50),
@Type nvarchar(50),
@PricePerTon int,
@FarmerName varchar(50),
@ProductionState varchar(50)
	 
as
begin
insert into Vegetables(
Id,
Name,
Type,
PricePerTon,
FarmerName,
ProductionState
	   )
    values
	( @Id,@Name,@Type,@PricePerTon,@FarmerName,@ProductionState  )
 
end


go
--viewall
use [VegetableDB]
go

create proc [dbo].[Vegetables_ViewAll]
as
begin
select Id,
Name,
Type,
PricePerTon,
FarmerName,
ProductionState

from Vegetables
end

--getbyid
use [VegetableDB]
go
create proc [dbo].[Vegetables_GetByID]
AS
begin
select Id,
Name,
Type,
PricePerTon,
FarmerName,
ProductionState

from Vegetables
where id = '@id'
end

use [VegetableDB]
go
---update
create proc [dbo].[Vegetables_Update]
@id int,
@Name nvarchar(50),
@Type nvarchar(50),
@PricePerTon int,
@FarmerName varchar(50),
@ProductionState varchar(50)
	 
as 
begin

update Vegetables
		set
Name = @Name,
Type = @Type,
PricePerTon = @PricePerTon,
FarmerName = @FarmerName,
productionState = @productionState
where Id=@Id
	END

	---delete
	use[VegetableDB]
go

create proc [dbo].[Vegetables_Delete]
@Id int
as
	begin
		delete from Vegetables
		where Id = @Id
	END

