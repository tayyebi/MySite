
/****** Object:  Table [dbo].[Admin]    Script Date: 2/23/2017 5:52:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](300) NOT NULL,
	[Fullname] [nvarchar](500) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Group]    Script Date: 2/23/2017 5:52:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[Id] [uniqueidentifier] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Post]    Script Date: 2/23/2017 5:52:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Abstract] [nvarchar](3000) NULL,
	[Body] [nvarchar](max) NOT NULL,
	[AdminUsername] [nvarchar](50) NULL,
	[GroupId] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Group] ADD  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Post] ADD  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[Post]  WITH CHECK ADD  CONSTRAINT [FK_Post_ToAdmin] FOREIGN KEY([AdminUsername])
REFERENCES [dbo].[Admin] ([Username])
GO
ALTER TABLE [dbo].[Post] CHECK CONSTRAINT [FK_Post_ToAdmin]
GO
ALTER TABLE [dbo].[Post]  WITH CHECK ADD  CONSTRAINT [FK_Post_ToGroup] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[Post] CHECK CONSTRAINT [FK_Post_ToGroup]
GO
/****** Object:  StoredProcedure [dbo].[AdminDeleteCommand]    Script Date: 2/23/2017 5:52:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdminDeleteCommand]
(
	@Original_Username nvarchar(50)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [Admin] WHERE (([Username] = @Original_Username))
GO
/****** Object:  StoredProcedure [dbo].[AdminInsertCommand]    Script Date: 2/23/2017 5:52:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdminInsertCommand]
(
	@Username nvarchar(50),
	@Password nvarchar(300),
	@Fullname nvarchar(500)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Admin] ([Username], [Password], [Fullname]) VALUES (@Username, @Password, @Fullname);
	
SELECT Username, Password, Fullname FROM Admin WHERE (Username = @Username)
GO
/****** Object:  StoredProcedure [dbo].[AdminSelectCommand]    Script Date: 2/23/2017 5:52:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdminSelectCommand]
AS
	SET NOCOUNT ON;
SELECT        Admin.*
FROM            Admin
GO
/****** Object:  StoredProcedure [dbo].[AdminUpdateCommand]    Script Date: 2/23/2017 5:52:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdminUpdateCommand]
(
	@Username nvarchar(50),
	@Password nvarchar(300),
	@Fullname nvarchar(500),
	@Original_Username nvarchar(50)
)
AS
	SET NOCOUNT OFF;
UPDATE [Admin] SET [Username] = @Username, [Password] = @Password, [Fullname] = @Fullname WHERE (([Username] = @Original_Username));
	
SELECT Username, Password, Fullname FROM Admin WHERE (Username = @Username)
GO
/****** Object:  StoredProcedure [dbo].[GroupDeleteCommand]    Script Date: 2/23/2017 5:52:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GroupDeleteCommand]
(
	@Original_Id uniqueidentifier
)
AS
	SET NOCOUNT OFF;
DELETE FROM [Group] WHERE (([Id] = @Original_Id))
GO
/****** Object:  StoredProcedure [dbo].[GroupInsertCommand]    Script Date: 2/23/2017 5:52:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GroupInsertCommand]
(
	@Id uniqueidentifier,
	@Title nvarchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Group] ([Id], [Title]) VALUES (@Id, @Title);
	
SELECT Id, Title FROM [Group] WHERE (Id = @Id)
GO
/****** Object:  StoredProcedure [dbo].[GroupSelectCommand]    Script Date: 2/23/2017 5:52:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GroupSelectCommand]
AS
	SET NOCOUNT ON;
SELECT        [Group].*
FROM            [Group]
GO
/****** Object:  StoredProcedure [dbo].[GroupUpdateCommand]    Script Date: 2/23/2017 5:52:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GroupUpdateCommand]
(
	@Id uniqueidentifier,
	@Title nvarchar(50),
	@Original_Id uniqueidentifier
)
AS
	SET NOCOUNT OFF;
UPDATE [Group] SET [Id] = @Id, [Title] = @Title WHERE (([Id] = @Original_Id));
	
SELECT Id, Title FROM [Group] WHERE (Id = @Id)
GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 2/23/2017 5:52:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Login]
	@Username nvarchar(50),
	@Password nvarchar(300)
AS
	declare @UsersCount tinyint
	SELECT @UsersCount = Count(*) from [Admin] where
	Username=@Username and [Password]=@Password
	if @UsersCount = 1
		select 'Success' as Response
	else
		select 'Failed' as Response
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[PostDeleteCommand]    Script Date: 2/23/2017 5:52:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PostDeleteCommand]
(
	@Original_Id int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [Post] WHERE (([Id] = @Original_Id))
GO
/****** Object:  StoredProcedure [dbo].[PostInsertCommand]    Script Date: 2/23/2017 5:52:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PostInsertCommand]
(
	@Title nvarchar(100),
	@Date datetime,
	@Abstract nvarchar(3000),
	@Body nvarchar(MAX),
	@AdminUsername nvarchar(50),
	@GroupId uniqueidentifier
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Post] ([Title], [Date], [Abstract], [Body], [AdminUsername], [GroupId]) VALUES (@Title, @Date, @Abstract, @Body, @AdminUsername, @GroupId);
	
SELECT Id, Title, Date, Abstract, Body, AdminUsername, GroupId FROM Post WHERE (Id = SCOPE_IDENTITY())
GO
/****** Object:  StoredProcedure [dbo].[PostSelectCommand]    Script Date: 2/23/2017 5:52:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PostSelectCommand]
AS
	SET NOCOUNT ON;
SELECT        Post.*
FROM            Post
GO
/****** Object:  StoredProcedure [dbo].[PostUpdateCommand]    Script Date: 2/23/2017 5:52:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PostUpdateCommand]
(
	@Title nvarchar(100),
	@Date datetime,
	@Abstract nvarchar(3000),
	@Body nvarchar(MAX),
	@AdminUsername nvarchar(50),
	@GroupId uniqueidentifier,
	@Original_Id int,
	@Id int
)
AS
	SET NOCOUNT OFF;
UPDATE [Post] SET [Title] = @Title, [Date] = @Date, [Abstract] = @Abstract, [Body] = @Body, [AdminUsername] = @AdminUsername, [GroupId] = @GroupId WHERE (([Id] = @Original_Id));
	
SELECT Id, Title, Date, Abstract, Body, AdminUsername, GroupId FROM Post WHERE (Id = @Id)
GO
