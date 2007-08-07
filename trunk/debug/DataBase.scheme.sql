if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Department]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Department]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FileType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[FileType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[IntoLib]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[IntoLib]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[OutLib]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[OutLib]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PumpClass]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PumpClass]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PumpType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PumpType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[_Users]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[_Users]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ProductVer]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ProductVer]
GO

CREATE TABLE [dbo].[Department] (
	[Department_id] [int] IDENTITY (1, 1) NOT NULL ,
	[DepartmentName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[FileType] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[DrawType] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[IntoLib] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[UserName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[InputTime] [datetime] NULL ,
	[PumpType] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[PumpName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[DrawType] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[FileName] [nvarchar] (255) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[OutLib] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[UserName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[PumpType] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[OutTime] [datetime] NULL ,
	[PumpName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[DrawType] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PumpClass] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[泵名称] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[泵类型] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PumpType] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Name] [nvarchar] (255) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[_Users] (
	[User_ID] [int] IDENTITY (1, 1) NOT NULL ,
	[UserID] [nvarchar] (30) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[Name] [nvarchar] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[Sex] [char] (1) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[PassWord] [nvarchar] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[Department_ID] [int] NULL ,
	[IsOnLine] [bit] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ProductVer] (
	[Version_ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Version] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[_Users] WITH NOCHECK ADD 
	CONSTRAINT [DF__Users_Department_ID] DEFAULT (0) FOR [Department_ID]
GO

