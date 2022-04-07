select * from Employee
select * from UserRolesMapping
select * from Users
select * from RoleMaster 

select u.ID,u.UserName ,ur.UserID,rm.ID,RollName from Users u 
join UserRolesMapping ur
on u.ID=ur.UserID 
join RoleMaster rm
on ur.RoleId=rm.Id
where u.ID=1

insert into UserRolesMapping values(6,4,2)