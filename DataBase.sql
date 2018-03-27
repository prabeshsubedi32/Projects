Select * from books

create proc AddBooks(
@bn varchar(255))
as
begin
insert into books(@bn)
end
