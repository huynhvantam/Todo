USE [Todo]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 5/29/2020 3:56:43 PM ******/
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
/****** Object:  Table [dbo].[Todos]    Script Date: 5/29/2020 3:56:43 PM ******/
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
 CONSTRAINT [PK_Todos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([IDG], [GroupName], [Deleted]) VALUES (2, N'HOME', 0)
INSERT [dbo].[Group] ([IDG], [GroupName], [Deleted]) VALUES (3, N'Company', 0)
INSERT [dbo].[Group] ([IDG], [GroupName], [Deleted]) VALUES (4, N'School', 0)
INSERT [dbo].[Group] ([IDG], [GroupName], [Deleted]) VALUES (5, N'NHÀ', 1)
SET IDENTITY_INSERT [dbo].[Group] OFF
SET IDENTITY_INSERT [dbo].[Todos] ON 

INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (1, N'Đi làm hằng ngày', 1, CAST(N'2020-05-05' AS Date), 0, 0, 2)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (2, N'làm việc nhà 2', 1, CAST(N'2020-10-05' AS Date), 0, 0, 2)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (3, N'làm việc nhà 3', 1, CAST(N'2020-05-05' AS Date), 1, 0, 2)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (4, N'làm việc nhà 4', 0, CAST(N'2020-10-05' AS Date), 0, 0, 2)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (5, N'làm việc nhà 5', 0, CAST(N'2020-05-05' AS Date), 0, 1, 3)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (6, N'làm việc nhà 6', 0, CAST(N'2020-10-05' AS Date), 0, 1, 3)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (7, N'làm việc nhà 7', 0, CAST(N'2020-05-05' AS Date), 0, 1, 3)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (8, N'làm việc nhà 8', 0, CAST(N'2020-10-05' AS Date), 1, 1, 3)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (9, N'làm việc nhà 9', 1, CAST(N'2020-05-05' AS Date), 0, 1, 3)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (10, N'Đi làm hằng ngày 10', 1, CAST(N'2020-10-05' AS Date), 0, 0, 3)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (11, N'làm việc nhà 11', 0, CAST(N'2020-05-05' AS Date), 1, 0, 4)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (12, N'làm việc nhà 12', 0, CAST(N'2020-10-05' AS Date), 0, 0, 4)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (13, N'làm việc nhà 13', 1, CAST(N'2020-05-05' AS Date), 0, 0, 4)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (14, N'làm việc nhà 14', 0, CAST(N'2020-10-05' AS Date), 1, 0, 4)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (15, N'làm việc nhà 15', 0, CAST(N'2020-05-05' AS Date), 1, 0, 4)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (16, N'làm việc nhà 16', 0, CAST(N'2020-10-05' AS Date), 1, 0, 4)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (17, N'làm việc nhà 17', 1, CAST(N'2020-05-05' AS Date), 0, 0, 5)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (18, N'làm việc nhà 18', 0, CAST(N'2020-10-05' AS Date), 0, 0, 5)
INSERT [dbo].[Todos] ([ID], [TaskName], [Important], [DateCreate], [Finish], [Deleted], [GroupIDG]) VALUES (19, N'Đi làm hằng ngày', 1, CAST(N'2020-05-29' AS Date), 0, 1, 3)
SET IDENTITY_INSERT [dbo].[Todos] OFF
ALTER TABLE [dbo].[Todos]  WITH CHECK ADD  CONSTRAINT [FK_Todos_Group] FOREIGN KEY([GroupIDG])
REFERENCES [dbo].[Group] ([IDG])
GO
ALTER TABLE [dbo].[Todos] CHECK CONSTRAINT [FK_Todos_Group]
GO
/****** Object:  StoredProcedure [dbo].[CreateGroup]    Script Date: 5/29/2020 3:56:43 PM ******/
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
/****** Object:  StoredProcedure [dbo].[CreateTodo]    Script Date: 5/29/2020 3:56:43 PM ******/
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
		@Important bit
		
AS
BEGIN

INSERT INTO [dbo].[Todos]
           ([TaskName]
           ,[Important]
           ,[DateCreate]
           ,[Finish]
           ,[Deleted]
           ,[GroupIDG])
     VALUES
           (@Taskname
           ,@Important
           ,GETDATE()
           ,0
           ,0
           ,@GroupIDG)

declare @Id int
set @Id = SCOPE_IDENTITY()
select @Id as ID
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteGroup]    Script Date: 5/29/2020 3:56:43 PM ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteTodo]    Script Date: 5/29/2020 3:56:43 PM ******/
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
/****** Object:  StoredProcedure [dbo].[FinishTodo]    Script Date: 5/29/2020 3:56:43 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetListFinish]    Script Date: 5/29/2020 3:56:43 PM ******/
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

select 
    [DateCreate]
	, [TaskName]
	,[Important],
	[Finish],
	[GroupIDG]
 from Todos as t
join dbo.[Group] as u on t.GroupIDG = u.IDG 
where t.Deleted =0 and u.Deleted=0 and t.Finish=1
END
GO
/****** Object:  StoredProcedure [dbo].[GetListFinishByGroup]    Script Date: 5/29/2020 3:56:43 PM ******/
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
END
GO
/****** Object:  StoredProcedure [dbo].[GetListGroup]    Script Date: 5/29/2020 3:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tamhv
-- Create date: 29/05/2020
-- Description:	Get List group
-- =============================================
CREATE PROCEDURE [dbo].[GetListGroup]
	
AS
BEGIN


SELECT [IDG]
      ,[GroupName]
     
  FROM [dbo].[Group]
where Deleted =0

END
GO
/****** Object:  StoredProcedure [dbo].[GetListGroupByID]    Script Date: 5/29/2020 3:56:43 PM ******/
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

END
GO
/****** Object:  StoredProcedure [dbo].[GetListImportant]    Script Date: 5/29/2020 3:56:43 PM ******/
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

select 
    [DateCreate]
	, [TaskName]
	,[Important],
	[Finish],
	[GroupIDG]
 from Todos as t
join dbo.[Group] as u on t.GroupIDG = u.IDG 
 where t.Deleted =0 and u.Deleted=0 and t.Important=1 and t.Finish=0

  --FROM [dbo].[Todos]
  --where GroupIDG =@GroupIDG and Deleted =0 and Important =1
END
GO
/****** Object:  StoredProcedure [dbo].[GetListImportantByGroup]    Script Date: 5/29/2020 3:56:43 PM ******/
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
    [DateCreate]
	, [TaskName]
	,[Important],
	[Finish],
	[GroupIDG]
-- from Todos as t
--join dbo.[Group] as u on t.GroupIDG = u.IDG 
-- where GroupIDG =@GroupIDG and t.Deleted =0 and u.Deleted=0 and t.Finish=1

  FROM [dbo].[Todos]
  where GroupIDG =@GroupIDG and Deleted =0 and Important =1 and Finish =0
END
GO
/****** Object:  StoredProcedure [dbo].[GetTodoAllGroup]    Script Date: 5/29/2020 3:56:43 PM ******/
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

select [Id],
    [DateCreate]
	, [TaskName]
	,[Important],
	[Finish],
	[GroupIDG]
 from Todos as t
join dbo.[Group] as u on t.GroupIDG = u.IDG 
where t.Deleted =0 and u.Deleted=0 and t.Finish=0
END
GO
/****** Object:  StoredProcedure [dbo].[GetTodoById]    Script Date: 5/29/2020 3:56:43 PM ******/
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
-- from Todos as t
--join dbo.[Group] as u on t.GroupIDG = u.IDG 
-- where t.Deleted =0 and u.Deleted=0 and t.Important=1 and t.Finish=0

  FROM [dbo].[Todos]
  where ID =@Id and Deleted =0  and Finish=0
END
GO
/****** Object:  StoredProcedure [dbo].[GetTodoListByGroup]    Script Date: 5/29/2020 3:56:43 PM ******/
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


SELECT [ID]
      ,[TaskName]
      ,[Important]
      ,[DateCreate]
      ,[Finish]
      ,[GroupIDG]
  FROM [dbo].[Todos]
  where GroupIDG =@GroupIDG and Deleted =0 and Finish =0

END
GO
/****** Object:  StoredProcedure [dbo].[ImportantTodo]    Script Date: 5/29/2020 3:56:43 PM ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateGroup]    Script Date: 5/29/2020 3:56:43 PM ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateTodo]    Script Date: 5/29/2020 3:56:43 PM ******/
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
		
		@Id int
AS
BEGIN

UPDATE [dbo].[Todos]
   SET [TaskName] = @Taskname
      ,[Important] = @Important
      
      ,[GroupIDG] = @GroupIDG
 WHERE ID  = @Id
 select @Id as ID
 end
GO
