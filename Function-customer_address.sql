create function dbo.ufnCustomerAddress(@customer_id int)
returns varchar(100)
as 
begin 
declare @address varchar(100)
select @address = customer_address from customer
where customer_id= @customer_id
return @address
end



