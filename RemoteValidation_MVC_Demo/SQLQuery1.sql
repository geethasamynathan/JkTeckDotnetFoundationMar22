create database RemoteValidationDB
use remotevalidationDb

create table Users
(
UserID int primary key identity,
FullName varchar(50),
Username varchar(50),
Password varchar(50)
)

