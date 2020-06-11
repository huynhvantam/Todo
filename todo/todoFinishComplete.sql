USE [master]
GO
/****** Object:  Database [Todo]    Script Date: 6/11/2020 3:19:40 PM ******/
CREATE DATABASE [Todo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Todo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Todo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Todo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Todo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Todo] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Todo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Todo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Todo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Todo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Todo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Todo] SET ARITHABORT OFF 
GO
ALTER DATABASE [Todo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Todo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Todo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Todo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Todo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Todo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Todo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Todo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Todo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Todo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Todo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Todo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Todo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Todo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Todo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Todo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Todo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Todo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Todo] SET  MULTI_USER 
GO
ALTER DATABASE [Todo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Todo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Todo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Todo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Todo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Todo] SET QUERY_STORE = OFF
GO
USE [Todo]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 6/11/2020 3:19:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[IDG] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [nvarchar](50) NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[IDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lists]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lists](
	[IDL] [int] IDENTITY(1,1) NOT NULL,
	[ListName] [nvarchar](255) NOT NULL,
	[Deleted] [bit] NOT NULL,
	[Finish] [bit] NOT NULL,
	[TodoID] [int] NULL,
 CONSTRAINT [PK_Lists] PRIMARY KEY CLUSTERED 
(
	[IDL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Todos]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Todos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TaskName] [nvarchar](255) NOT NULL,
	[Important] [bit] NOT NULL,
	[DateCreate] [date] NOT NULL,
	[Finish] [bit] NOT NULL,
	[Deleted] [bit] NOT NULL,
	[GroupIDG] [int] NOT NULL,
	[Progress] [int] NULL,
 CONSTRAINT [PK_Todos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([IDG], [GroupName], [Deleted]) VALUES (1, N'Tác Vụ', 0)
INSERT [dbo].[Group] ([IDG], [GroupName], [Deleted]) VALUES (2, N'Home', 1)
INSERT [dbo].[Group] ([IDG], [GroupName], [Deleted]) VALUES (3, N'Nhà', 1)
INSERT [dbo].[Group] ([IDG], [GroupName], [Deleted]) VALUES (4, N'Công ty', 1)
INSERT [dbo].[Group] ([IDG], [GroupName], [Deleted]) VALUES (5, N'Học tiếng anh', 1)
INSERT [dbo].[Group] ([IDG], [GroupName], [Deleted]) VALUES (6, N'Học tiếng nhật', 1)
INSERT [dbo].[Group] ([IDG], [GroupName], [Deleted]) VALUES (7, N'Gia đình', 0)
INSERT [dbo].[Group] ([IDG], [GroupName], [Deleted]) VALUES (8, N'bạn bè', 0)
SET IDENTITY_INSERT [dbo].[Group] OFF
SET IDENTITY_INSERT [dbo].[Lists] ON 

INSERT [dbo].[Lists] ([IDL], [ListName], [Deleted], [Finish], [TodoID]) VALUES (1, N'aaaaaaaaaa', 0, 0, 10)
INSERT [dbo].[Lists] ([IDL], [ListName], [Deleted], [Finish], [TodoID]) VALUES (2, N'aaaaaaaaaaa', 1, 0, 10)
INSERT [dbo].[Lists] ([IDL], [ListName], [Deleted], [Finish], [TodoID]) VALUES (3, N'aaaaa', 0, 0, 10)
INSERT [dbo].[Lists] ([IDL], [ListName], [Deleted], [Finish], [TodoID]) VALUES (4, N'aaaaaaaaaaaaa', 0, 0, 8)
INSERT [dbo].[Lists] ([IDL], [ListName], [Deleted], [Finish], [TodoID]) VALUES (5, N'777777777', 0, 0, 8)
INSERT [dbo].[Lists] ([IDL], [ListName], [Deleted], [Finish], [TodoID]) VALUES (6, N'aaaaaaaaaaa', 0, 0, 8)
INSERT [dbo].[Lists] ([IDL], [ListName], [Deleted], [Finish], [TodoID]) VALUES (7, N'aaaaaaaaa', 0, 0, 12)
INSERT [dbo].[Lists] ([IDL], [ListName], [Deleted], [Finish], [TodoID]) VALUES (8, N'aaaaaaaa', 0, 0, 12)
INSERT [dbo].[Lists] ([IDL], [ListName], [Deleted], [Finish], [TodoID]) VALUES (9, N'ăn', 0, 0, 18)
INSERT [dbo].[Lists] ([IDL], [ListName], [Deleted], [Finish], [TodoID]) VALUES (10, N'ngủ', 0, 0, 18)
INSERT [dbo].[Lists] ([IDL], [ListName], [Deleted], [Finish], [TodoID]) VALUES (11, N'chơi', 0, 0, 18)
INSERT [dbo].[Lists] ([IDL], [ListName], [Deleted], [Finish], [TodoID]) VALUES (12, N'aaaaaaa', 0, 0, 15)
INSERT [dbo].[Lists] ([IDL], [ListName], [Deleted], [Finish], [TodoID]) VALUES (13, N'aaaaaaaa', 0, 0, 15)
INSERT [dbo].[Lists] ([IDL], [ListName], [Deleted], [Finish], [TodoID]) VALUES (14, N'aaaaaa', 0, 0, 15)
INSERT [dbo].[Lists] ([IDL], [ListName], [Deleted], [Finish], [TodoID]) VALUES (15, N'aaaaaa', 0, 0, 15)
INSERT [dbo].[Lists] ([IDL], [ListName], [Deleted], [Finish], [TodoID]) VALUES (16, N'aaaaaaaaaaa', 0, 0, 19)
INSERT [dbo].[Lists] ([IDL], [ListName], [Deleted], [Finish], [TodoID]) VALUES (17, N'aaaaaaaa', 0, 0, 19)
INSERT [dbo].[Lists] ([IDL], [ListName], [Deleted], [Finish], [TodoID]) VALUES (18, N'aaaaaaaa', 1, 0, 13)
SET IDENTITY_INSERT [dbo].[Lists] OFF
SET IDENTITY_INSERT [dbo].[Todos] ON 

INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (1, N'aaaaaaaaaaa', 0, CAST(N'2020-06-11' AS Date), 0, 0, 1, 0)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (2, N'aaaaaaa', 0, CAST(N'2020-06-11' AS Date), 0, 1, 1, 0)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (3, N'aaaaaaaaaaa', 0, CAST(N'2020-06-11' AS Date), 0, 1, 1, 0)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (4, N'aaaaaa', 0, CAST(N'2020-06-11' AS Date), 0, 0, 1, 0)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (5, N'aaaaaa', 0, CAST(N'2020-06-11' AS Date), 0, 1, 1, 0)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (6, N'aaaaaaaa', 0, CAST(N'2020-06-11' AS Date), 0, 1, 1, 0)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (7, N'aaaaaaa', 1, CAST(N'2020-06-11' AS Date), 0, 0, 6, 0)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (8, N'aaaaaaaaa', 1, CAST(N'2020-06-11' AS Date), 1, 0, 1, 0)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (9, N'aaaaaaaaaaaaaa', 1, CAST(N'2020-06-11' AS Date), 1, 0, 1, 0)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (10, N'aaaaaaaaaa', 1, CAST(N'2020-06-11' AS Date), 1, 0, 1, 0)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (11, N'aaaaaa', 1, CAST(N'2020-06-11' AS Date), 1, 0, 4, 0)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (12, N'aaaaaaa', 0, CAST(N'2020-06-11' AS Date), 0, 0, 1, 0)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (13, N'aaaaa', 0, CAST(N'2020-06-11' AS Date), 0, 0, 1, 0)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (14, N'aaaaaaaa', 0, CAST(N'2020-06-11' AS Date), 1, 0, 1, 0)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (15, N'aaaa', 0, CAST(N'2020-06-11' AS Date), 0, 1, 1, 0)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (16, N'làm việc nhà', 0, CAST(N'2020-06-11' AS Date), 0, 0, 7, 0)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (17, N'làm việc 1', 0, CAST(N'2020-06-11' AS Date), 0, 0, 7, 0)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (18, N'làm việc 2', 0, CAST(N'2020-06-11' AS Date), 0, 0, 7, 0)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG], [Progress]) VALUES (19, N'aaa', 0, CAST(N'2020-06-11' AS Date), 0, 0, 1, 10)
SET IDENTITY_INSERT [dbo].[Todos] OFF
ALTER TABLE [dbo].[Lists]  WITH CHECK ADD  CONSTRAINT [FK_Lists_Todos] FOREIGN KEY([TodoID])
REFERENCES [dbo].[Todos] ([ID])
GO
ALTER TABLE [dbo].[Lists] CHECK CONSTRAINT [FK_Lists_Todos]
GO
ALTER TABLE [dbo].[Todos]  WITH CHECK ADD  CONSTRAINT [FK_Todos_Group] FOREIGN KEY([GroupIDG])
REFERENCES [dbo].[Group] ([IDG])
GO
ALTER TABLE [dbo].[Todos] CHECK CONSTRAINT [FK_Todos_Group]
GO
/****** Object:  StoredProcedure [dbo].[CreateGroup]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv
-- Create date: 29/05/2020
-- Description:	create group
-- =============================================
CREATE PROCEDURE [dbo].[CreateGroup]
	@GroupName nvarchar (50)
AS
BEGIN

INSERT INTO [dbo].[Group]
           ([GroupName]
           ,[Deleted])
     VALUES
           (@GroupName
           ,0)
declare @Id int
set @Id =SCOPE_IDENTITY()
select @Id as IDG

END
GO
/****** Object:  StoredProcedure [dbo].[CreateListTodo]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv
-- Create date: 9/6/2020
-- Description:	Create list Todo
-- =============================================
CREATE PROCEDURE [dbo].[CreateListTodo]
		@TodoID int,
		@ListName nvarchar(255)
AS
BEGIN
	
INSERT INTO [dbo].[Lists]
           ([ListName]
           ,[Deleted]
           ,[Finish]
           ,[TodoID])
     VALUES
           (@ListName
           ,0
           ,0
           ,@TodoID)

declare @Id int
set @Id = SCOPE_IDENTITY()
select @Id as ID
END
GO
/****** Object:  StoredProcedure [dbo].[CreateTodo]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		tamhv	
-- Create date: 28/05/2020
-- Description:	Create Todo
-- =============================================
CREATE PROCEDURE [dbo].[CreateTodo]
		@GroupIDG int,
		@Taskname nvarchar(255),
		@Important bit,
		@Progress int
AS
BEGIN

INSERT INTO [dbo].[Todos]
           ([TaskName]
           ,[Important]
           ,[DateCreate]
           ,[Finish]
           ,[Deleted]
           ,[GroupIDG],
		   [Progress])
     VALUES
           (@Taskname
           ,@Important
           ,GETDATE()
           ,0
           ,0
           ,@GroupIDG,
		   @Progress)

declare @Id int
set @Id = SCOPE_IDENTITY()
select @Id as ID
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteGroup]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv
-- Create date: 29/05/2020
-- Description:	DELETE group
-- =============================================
CREATE PROCEDURE [dbo].[DeleteGroup]
	@Id int
AS
BEGIN

declare @Result bit =0

begin try
UPDATE [dbo].[Group]
   SET [Deleted] = 1
 WHERE IDG = @Id

 set @Result=1
 end try
begin catch
	
end catch
select @Id as Id

END
GO
/****** Object:  StoredProcedure [dbo].[DeleteListTodo]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv
-- Create date: 9/6
-- Description:	Delete List Todo
-- =============================================
CREATE PROCEDURE [dbo].[DeleteListTodo]
	@IDL int
AS
BEGIN

declare @Result bit =0

begin try
UPDATE [dbo].Lists
   SET [Deleted] = 1
 WHERE IDL = @IDL

 set @Result=1
 end try
begin catch
	
end catch
select @IDL as Id

END
GO
/****** Object:  StoredProcedure [dbo].[DeleteTodo]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		tamhv	
-- Create date: 28/05/2020
-- Description:	Update Todo
-- =============================================
CREATE PROCEDURE [dbo].[DeleteTodo]
		@Id int
AS
BEGIN

declare @Result bit =0

begin try
UPDATE [dbo].Todos
   SET [Deleted] = 1
 WHERE ID = @Id

 set @Result=1
 end try
begin catch
	
end catch
select @Id as Id

END
GO
/****** Object:  StoredProcedure [dbo].[FinishCheckbox]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamv
-- Create date: 1/6/2020
-- Description:	Finish checkbox
-- =============================================
CREATE PROCEDURE [dbo].[FinishCheckbox]
 		@Id int
AS
BEGIN

declare @Result bit =0

begin try
	if((select Finish from Todos where ID = @id)=1)
	begin
		update Todos 
		set	Finish = 0
		where ID = @id
	end
	else
		begin
			update Todos
			set Finish = 1
			where ID = @id
		end
 end try
begin catch
	
end catch
select @Id as Id

END
GO
/****** Object:  StoredProcedure [dbo].[FinishListTodo]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv
-- Create date: 9/6
-- Description:	Delete List Todo
-- =============================================
CREATE PROCEDURE [dbo].[FinishListTodo]
	@IDL int
AS
BEGIN

declare @Result bit =0

begin try
	if((select Finish from Lists where IDL = @IDL)=1)
	begin
		update Lists 
		set	Finish = 0
		where IDL = @IDL
	end
	else
		begin
			update Lists
			set Finish = 1
			where IDL = @IDL
		end
 end try
begin catch
	
end catch
select @IDL as IDL

END

--declare @Result bit =0

--begin try
--UPDATE [dbo].Lists
--      SET [Finish] = 1
-- WHERE IDL = @IDL

-- set @Result=1
-- end try
--begin catch
	
--end catch
--select @IDL as Id

--END
GO
/****** Object:  StoredProcedure [dbo].[FinishTodo]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv
-- Create date: 29
-- Description:	Finish Todo
-- =============================================
CREATE PROCEDURE [dbo].[FinishTodo]
		@Id int
AS
BEGIN

declare @Result bit =0

begin try
UPDATE [dbo].Todos
   SET [Finish] = 1
 WHERE ID = @Id

 set @Result=1
 end try
begin catch
	
end catch
select @Id as Id

END

GO
/****** Object:  StoredProcedure [dbo].[GetListFinish]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		tamhv	
-- Create date: 28/05/2020
-- Description:	get list finish
-- =============================================
CREATE PROCEDURE [dbo].[GetListFinish]	
	
AS
BEGIN

SELECT  ROW_NUMBER() OVER (
	ORDER BY ID
   ) STT,
    [DateCreate]
	, [TaskName]
	,[Important],
	[Finish],
	[GroupIDG]
 from Todos as t
join dbo.[Group] as u on t.GroupIDG = u.IDG 
where t.Deleted =0 and u.Deleted=0 and t.Finish=1
order by ID DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[GetListFinishByGroup]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		tamhv	
-- Create date: 28/05/2020
-- Description:	get list finish
-- =============================================
CREATE PROCEDURE [dbo].[GetListFinishByGroup]	
		@GroupIDG int
AS
BEGIN

select 
[ID],
    [DateCreate]
	, [TaskName]
	,[Important],
	[Finish],
	[GroupIDG] 
-- from Todos as t
--join dbo.[Group] as u on t.GroupIDG = u.IDG 
-- where GroupIDG =@GroupIDG and t.Deleted =0 and u.Deleted=0 and t.Finish=1

  FROM [dbo].[Todos]
  where GroupIDG =@GroupIDG and Deleted =0 and Finish =1
  order by ID DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[GetListGroup]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetListGroup]
	
AS
BEGIN


--SELECT [IDG]
--,(SELECT ROW_NUMBER() OVER (ORDER BY IDG) STT FROM dbo.[Group] where Deleted=0)
--      ,[GroupName]
--       , (select count (*) from Todos where GroupIDG=[dbo].[Group].IDG and Finish=0 and Deleted =0)as AllTask
--  FROM [dbo].[Group]
--where Deleted =0
--order by IDG DESC;

--END
SELECT 
   ROW_NUMBER() OVER (
	ORDER BY IDG
   ) STT,
  [IDG],
 [GroupName]
 , (select count (*) from Todos where GroupIDG=[dbo].[Group].IDG and Finish=0 and Deleted =0)as AllTask
FROM 
   dbo.[Group]

where Deleted=0

END
GO
/****** Object:  StoredProcedure [dbo].[GetListGroupByID]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv
-- Create date: 29/05/2020
-- Description:	Get List Group By ID
-- =============================================
CREATE PROCEDURE [dbo].[GetListGroupByID]
	@Id int
AS
BEGIN

if(not exists(select * from [dbo].[Group] where Deleted = 0 and IDG = @Id))
begin
	raiserror('Invalie Department',1,100)
	return
	end
SELECT [IDG]
      ,[GroupName]
     
  FROM [dbo].[Group]
where Deleted =0 and IDG = @Id
order by IDG DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[GetListImportant]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		tamhv	
-- Create date: 28/05/2020
-- Description:	get list Important
-- =============================================
CREATE PROCEDURE [dbo].[GetListImportant]
		--@GroupIDG int
AS
BEGIN

SELECT  ROW_NUMBER() OVER (
	ORDER BY ID
   ) STT,
   ID,
    [DateCreate]
	, [TaskName]
	,[Important],
	[Finish],
	[GroupIDG]
	,[Progress]
		   , (select count (*) from Lists where TodoID=ID  and Deleted =0)as AllList
	   , (select count (*) from Lists where TodoID=ID and Finish=1 and Deleted =0)as AllListFinish
 from Todos as t
join dbo.[Group] as u on t.GroupIDG = u.IDG 
 where t.Deleted =0 and u.Deleted=0 and t.Important=1 and t.Finish=0
 order by ID DESC;
  --FROM [dbo].[Todos]
  --where GroupIDG =@GroupIDG and Deleted =0 and Important =1

END
GO
/****** Object:  StoredProcedure [dbo].[GetListImportantByGroup]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		tamhv	
-- Create date: 28/05/2020
-- Description:	get list Important
-- =============================================
CREATE PROCEDURE [dbo].[GetListImportantByGroup]	
		@GroupIDG int
AS
BEGIN

select 
[ID],
    [DateCreate]
	, [TaskName]
	,[Important],
	[Finish],
	[GroupIDG]
	,[Progress]
-- from Todos as t
--join dbo.[Group] as u on t.GroupIDG = u.IDG 
-- where GroupIDG =@GroupIDG and t.Deleted =0 and u.Deleted=0 and t.Finish=1

  FROM [dbo].[Todos]
  where GroupIDG =@GroupIDG and Deleted =0 and Important =1 and Finish =0
  order by ID DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[GetListTodo]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv
-- Create date: 9/6
-- Description:	Get List Todo

CREATE PROCEDURE [dbo].[GetListTodo]
	@TodoID int
AS
BEGIN


SELECT  ROW_NUMBER() OVER (
	ORDER BY IDL
   ) STT
   ,IDL
      ,[ListName]
     
      ,[Finish]
      ,[TodoID]
  FROM [dbo].[Lists]

  where TodoID =@TodoID and Deleted =0 





END
GO
/****** Object:  StoredProcedure [dbo].[GetListTodoByIDL]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv
-- Create date: 9/6
-- Description:	get list todo by id
-- =============================================
CREATE PROCEDURE [dbo].[GetListTodoByIDL]
		@IDL int
AS
BEGIN

SELECT [IDL]
      ,[ListName]
      ,[Finish]
      ,[TodoID]
  FROM [dbo].[Lists]

  where IDL =@IDL and Deleted =0  

END
GO
/****** Object:  StoredProcedure [dbo].[GetTodoAllGroup]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv	
-- Create date: 2020/05/05
-- Description:	get to do list all group
-- =============================================
CREATE PROCEDURE [dbo].[GetTodoAllGroup]
	
AS
BEGIN

 SELECT  ROW_NUMBER() OVER (
	ORDER BY ID
   ) STT,
   [Id],
    [DateCreate]
	, [TaskName]
	,[Important],
	[Finish],
	[GroupIDG]
	,[Progress]
		   , (select count (*) from Lists where TodoID=ID  and Deleted =0)as AllList
	   , (select count (*) from Lists where TodoID=ID and Finish=1 and Deleted =0)as AllListFinish
	    
 from Todos as t
join dbo.[Group] as u on t.GroupIDG = u.IDG 
where t.Deleted =0 and u.Deleted=0 and t.Finish=0
order by ID DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[GetTodoById]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		tamhv	
-- Create date: 28/05/2020
-- Description:	get list Important
-- =============================================
CREATE PROCEDURE [dbo].[GetTodoById]
		@Id int
AS
BEGIN

select 
    [DateCreate]
	, [TaskName]
	,[Important],
	[Finish],
	[GroupIDG]
	,[Progress]
-- from Todos as t
--join dbo.[Group] as u on t.GroupIDG = u.IDG 
-- where t.Deleted =0 and u.Deleted=0 and t.Important=1 and t.Finish=0

  FROM [dbo].[Todos]
  where ID =@Id and Deleted =0  and Finish=0
  order by ID DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[GetTodoListByGroup]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv
-- Create date: 29/05/2020
-- Description:	GetTodoListByGroup
-- =============================================
CREATE PROCEDURE [dbo].[GetTodoListByGroup]
	@GroupIDG int
AS
BEGIN


SELECT  ROW_NUMBER() OVER (
	ORDER BY ID
   ) STT,

[ID]
--,(SELECT ROW_NUMBER() OVER (ORDER BY GroupName) row_num FROM dbo.[Group])
      ,[TaskName]
      ,[Important]
      ,[DateCreate]
      ,[Finish]
      ,[GroupIDG]
	  ,[Progress]
	   , (select count (*) from Lists where TodoID=Todos.ID  and Deleted =0)as AllList
	   , (select count (*) from Lists where TodoID=Todos.ID and Finish=1 and Deleted =0)as AllListFinish
	  
  FROM [dbo].[Todos]
  where GroupIDG =@GroupIDG and Deleted =0 and Finish =0
  order by ID DESC;

--Select Row_number() over(order by ID) STT, * from Todos
END
GO
/****** Object:  StoredProcedure [dbo].[ImportantCheckbox]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv
-- Create date: 1/06/2020
-- Description:	Important
-- =============================================
CREATE PROCEDURE [dbo].[ImportantCheckbox]
 		@Id int
AS
BEGIN

declare @Result bit =0

begin try
	if((select [Important] from Todos where ID = @id)=1)
	begin
		update Todos 
		set	[Important] = 0
		where ID = @id
	end
	else
		begin
			update Todos
			set [Important] = 1
			where ID = @id
		end
 end try
begin catch
	
end catch
select @Id as Id

END
GO
/****** Object:  StoredProcedure [dbo].[ImportantTodo]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv
-- Create date: 29
-- Description:	Finish Todo
-- =============================================
CREATE PROCEDURE [dbo].[ImportantTodo]
		@Id int,
		@Important bit
AS
BEGIN

UPDATE [dbo].Todos
   SET [Important] = @Important

 WHERE ID  = @Id
 select @Id as ID
 end
GO
/****** Object:  StoredProcedure [dbo].[ProgressEdit]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv
-- Create date: 02/06/2020
-- Description:	Progress EDIT
-- =============================================
CREATE PROCEDURE [dbo].[ProgressEdit]
		@Id int
AS
BEGIN

begin try
	if(((select Progress from Todos where ID = @id)>=0 ) and ((select Progress from Todos where ID = @id)<100 ) )
	begin
		update Todos 
		set	Progress = Progress +10
		where ID = @id
	end
	else 
		begin
			update Todos
			set	Progress = Progress +0
			where ID = @id
		end
 end try
begin catch
	
end catch



END





--UPDATE [dbo].Todos
--   SET [Progress] = @Progress
-- WHERE ID = @Id

--select @Id as Id

--END
GO
/****** Object:  StoredProcedure [dbo].[SearchTask]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv
-- Create date: 3/6/2020
-- Description: search
-- =============================================
CREATE PROCEDURE [dbo].[SearchTask]
	@TaskName nvarchar(50)
AS
BEGIN
	select 
	[Id],
    [DateCreate]
	, [TaskName]
	,[Important],
	[Finish],
	[GroupIDG]
	,[Progress]
	--from Todos
	--where TaskName like CONCAT('%',@TaskName,'%') and Deleted =0 and Finish =0
	--order by ID DESC;


	 from Todos as t
join dbo.[Group] as u on t.GroupIDG = u.IDG 
where TaskName like CONCAT('%',@TaskName,'%') and u.Deleted=0 and Finish =0 and t.Deleted=0
order by ID DESC;

END
GO
/****** Object:  StoredProcedure [dbo].[SearchTaskGroup]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv
-- Create date: 3/6/2020
-- Description:	Serach by Group
-- =============================================
CREATE PROCEDURE [dbo].[SearchTaskGroup]
	@GroupIDG int ,
	@TaskName nvarchar(50)
AS
BEGIN

select [ID],
    [DateCreate]
	, [TaskName]
	,[Important],
	[Finish],
	[GroupIDG]
	,[Progress]
 from Todos as t
join dbo.[Group] as u on t.GroupIDG = u.IDG 
where t.TaskName like CONCAT('%',@TaskName,'%') and u.IDG like @GroupIDG and t.Deleted =0 and t.Finish =0
	order by ID DESC;

	
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateGroup]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv
-- Create date: 29/05/2020
-- Description:	update group
-- =============================================
CREATE PROCEDURE [dbo].[UpdateGroup]
	@Id int,
	@GroupName nvarchar (50)
AS
BEGIN

UPDATE [dbo].[Group]
   SET [GroupName] = @GroupName
 WHERE IDG = @Id

select @Id as Id

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateListTodo]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv
-- Create date: 9/6
-- Description:	Edit List Todo
-- =============================================
CREATE PROCEDURE [dbo].[UpdateListTodo]
		
			@TodoID int,
			@ListName nvarchar(255)
			,@IDL int
			
 as

BEGIN

UPDATE [dbo].[Lists]
   SET [ListName] = @ListName
      ,[TodoID] = @TodoID
     
 WHERE IDL = @IDL
  select @IDL as ID
 end



GO
/****** Object:  StoredProcedure [dbo].[UpdateTodo]    Script Date: 6/11/2020 3:19:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		tamhv	
-- Create date: 28/05/2020
-- Description:	Update Todo
-- =============================================
CREATE PROCEDURE [dbo].[UpdateTodo]
		@GroupIDG int,
		@Taskname nvarchar(255),
		@Important bit,
		@Finish bit,
		@Id int
AS
BEGIN

UPDATE [dbo].[Todos]
   SET [TaskName] = @Taskname
      ,[Important] = @Important
      ,[Finish] = @Finish
      ,[GroupIDG] = @GroupIDG
 WHERE ID  = @Id
 select @Id as ID
 end
GO
USE [master]
GO
ALTER DATABASE [Todo] SET  READ_WRITE 
GO
