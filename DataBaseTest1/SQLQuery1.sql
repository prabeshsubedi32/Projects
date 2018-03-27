CREATE DATABASE SM;

create table userInfo(
ID int, UsernameName varchar(50), PasswordName varchar(50)

)

insert into userInfo(ID, UsernameName, PasswordName)
values(1,'prabeshsubedi32', 'name1');

insert into userInfo(ID, UsernameName, PasswordName)
values(1,'subeprab', 'name2');

select * from userInfo;