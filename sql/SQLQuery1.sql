use dbWS
go
create table db_User
(
	Id int identity primary key,
	[Имя] nvarchar(max) not null,
	[Фамилия] nvarchar(max) not null,
	[Группа] nvarchar(max) not null,
	[instgram] varchar(max) not null
);

select * from db_User