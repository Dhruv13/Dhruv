create table Role(
RoleId int identity primary key,
RoleName varchar(50) not null,
);


create table Login (
LoginId int identity primary key,
UserMail varchar(100) not null,
UserPass varchar(max) not null,
DateLastLogin Datetime ,
DateCreated datetime,
IsActive bit,
IsDeleted bit,
)
/*
To Add New Column in Existing Table with Foreign Key
For Example
alter table Login Add RoleId int Foreign Key (RoleId) References Role(RoleId)
alter table Login add RoleId int Foreign Key(RoleId) references Role(RoleId)

*/