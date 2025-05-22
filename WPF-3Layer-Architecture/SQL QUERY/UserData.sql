create database uservalue

use uservalue 

create table uservalues(userid numeric(10,0) identity(1,1) , name nvarchar(50) , age numeric(3) )

select* from uservalues