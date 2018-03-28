Select * from books

create proc AddBooks(
@bn varchar(255))
as
begin
insert into books values(@bn)
end

exec AddBooks 'C#'

create proc ListBooks
as
begin
	select * from books
end

exec ListBooks

create table AdminList(UserName varchar(50), UserPassword varchar(50));

select * from AdminList
insert into AdminList(UserName,UserPassword) values ('library','lib123')