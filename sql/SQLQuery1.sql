use dbWS
go
create table db_User
(
	Id int identity primary key,
	[���] nvarchar(max) not null,
	[�������] nvarchar(max) not null,
	[������] nvarchar(max) not null,
	[instgram] varchar(max) not null
);

select * from db_User