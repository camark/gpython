use product;

drop table 'Department' if exists;
drop table 'FileType' if exists;
drop table 'IntoLib' if exists;
drop table 'OutLib' if exists;
drop table 'PumpClass' if exists;
drop table 'PumpType' if exists;
drop table '_users' if exists;
drop table 'ProductVer' if exists;

CREATE TABLE Department (
	Department_id integer auto increament primary key
	DepartmentName varchar(50)
)ENGINE=InnoDB DEFAULT CHARSET=gb2312;

CREATE TABLE FileType (
	id integer auto increament primary,
	DrawType varchar(50) 
)ENGINE=InnoDB DEFAULT CHARSET=gb2312;

CREATE TABLE IntoLib (
	id integer auto increament primary key;
	UserName varchar (50) ,
	InputTime datetime NULL ,
	PumpType varchar (50) ,
	PumpName varchar (50) ,
	DrawType varchar (50) ,
	FileName varchar (255) 
)ENGINE=InnoDB DEFAULT CHARSET=gb2312;


CREATE TABLE OutLib (
	ID integer auto_increament primary key ,
	UserName varchar(50) ,
	PumpType varchar(50) ,
	OutTime datetime,
	PumpName varchar(50) ,
	DrawType varchar(50) 
)ENGINE=InnoDB DEFAULT CHARSET=gb2312;


CREATE TABLE PumpClass (
	ID integer auto_increament primary key ,
	pumpname varchar(50) ,
	pumptype varchar(50) 
)ENGINE=InnoDB DEFAULT CHARSET=gb2312;


CREATE TABLE PumpType (
	ID integer auto_increament primary key ,
	Name varchar (255) 
)ENGINE=InnoDB DEFAULT CHARSET=gb2312;


CREATE TABLE _Users (
	User_ID integer auto_increament primary key ,
	UserID varchar (30) ,
	Name varchar (20),
	Sex char (1),
	PassWord varchar (10) ,
	Department_ID int,
	IsOnLine bit 
)ENGINE=InnoDB DEFAULT CHARSET=gb2312;


CREATE TABLE ProductVer (
	Version_ID integer auto_increament primary key ,
	Version varchar(50) 
)ENGINE=InnoDB DEFAULT CHARSET=gb2312;





