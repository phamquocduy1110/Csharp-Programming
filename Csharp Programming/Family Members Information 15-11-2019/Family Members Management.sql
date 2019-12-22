CREATE DATABASE FamilyMembersManagement
GO
Use FamilyMembersManagement
GO

create table member(
	id int primary key identity(1,1),
	fullname nvarchar(50),
	gender bit not null,
	birthday date null,
	[status] bit null,
	hometown nvarchar(max),
	living nvarchar(max),
	occupation nvarchar(max),
	Father_id int references member(id),
	Mother_id int references member(id),
	spouse_id int references member(id),
	)