CREATE TABLE [dbo].[Contact](
	[ContactId] [int] IDENTITY(1,1) NOT NULL,
	[Fullname] [nvarchar](200) NOT NULL,
	[Email] [nvarchar](200) NULL,
	[Telephone] [nvarchar](50) NULL,
	[Project] [nvarchar](50) NULL,
	[Title] [nvarchar](1000) NULL,
	[Message] [nvarchar](2000) NULL,
	[CreateDate] [datetime] NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Newsletter](
	[NewsLetterId] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](200) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Newsletter] PRIMARY KEY CLUSTERED 
(
	[NewsLetterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ClientsSay](
	[ClientSayId] [int] IDENTITY(1,1) NOT NULL,
	[Fullname] [nvarchar](100) NULL,
	[Image] [nvarchar](500) NULL,
	[Position] [nvarchar](50) NULL,
	[Contents] [nvarchar](1000) NULL,
	[ContentImage] [nvarchar](500) NULL,
	[Rate] [float] NULL,
	[Language] [nvarchar](5) NULL,
 CONSTRAINT [PK_ClientsSay] PRIMARY KEY CLUSTERED 
(
	[ClientSayId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Chức vụ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClientsSay', @level2type=N'COLUMN',@level2name=N'Position'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'HÌnh ảnh khách hàng đánh giá' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClientsSay', @level2type=N'COLUMN',@level2name=N'ContentImage'
GO

CREATE TABLE [dbo].[CategoryNews](
	[CategoryNewsId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[CategoryCode] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](500) NOT NULL,
	[Decription] [nvarchar](1000) NULL,
	[Contents] [nvarchar](max) NULL,
	[Keywords] [nvarchar](500) NULL,
	[Image] [nvarchar](500) NULL,
	[ThumbImage] [nvarchar](500) NULL,
	[Language] [nvarchar](5) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_CategoryNews] PRIMARY KEY CLUSTERED 
(
	[CategoryNewsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[News](
	[NewsId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](500) NOT NULL,
	[Url] [nvarchar](1000) NULL,
	[Decription] [nvarchar](1000) NOT NULL,
	[Contents] [nvarchar](max) NOT NULL,
	[Keywords] [nvarchar](500) NULL,
	[Tags] [nvarchar](500) NULL,
	[Image] [nvarchar](500) NULL,
	[ThumbImage] [nvarchar](500) NULL,
	[Language] [nvarchar](5) NULL,
	[IsActive] [bit] NOT NULL,
	[Author] [nvarchar](50) NOT NULL,
	[PublicDate] [datetime] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdateDate] [datetime] NULL,
	[CategoryNewsId] [int] NOT NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[NewsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[News]  WITH CHECK ADD  CONSTRAINT [FK_News_CategoryNews] FOREIGN KEY([CategoryNewsId])
REFERENCES [dbo].[CategoryNews] ([CategoryNewsId])
GO

ALTER TABLE [dbo].[News] CHECK CONSTRAINT [FK_News_CategoryNews]
GO

CREATE TABLE [dbo].[Content](
	[ContentId] [int] IDENTITY(1,1) NOT NULL,
	[ContentCode] [nvarchar](50) NOT NULL,
	[ContentName] [nvarchar](500) NOT NULL,
	[ContentDetail] [nvarchar](max) NULL,
	[Language] [nvarchar](5) NOT NULL,
	[Title] [nvarchar](500) NULL,
	[Keyword] [nvarchar](500) NULL,
	[Description] [nvarchar](1000) NULL,
	[Image] [nvarchar](500) NULL,
	[CreateDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Content] PRIMARY KEY CLUSTERED 
(
	[ContentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[SlideShow](
	[SildeId] [int] IDENTITY(1,1) NOT NULL,
	[SlideName] [nvarchar](500) NOT NULL,
	[Image] [nvarchar](1000) NOT NULL,
	[Url] [nvarchar](1000) NULL,
	[Target] [nvarchar](20) NULL,
	[Language] [nvarchar](5) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateFrom] [datetime] NULL,
	[DateTo] [datetime] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_SlideShow] PRIMARY KEY CLUSTERED 
(
	[SildeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CategoryCourse](
	[CategoryCourseId] [int] NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[CategoryCode] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](500) NOT NULL,
	[Decription] [nvarchar](1000) NULL,
	[Keywords] [nvarchar](500) NULL,
	[Image] [nvarchar](500) NULL,
	[ThumbImage] [nvarchar](500) NULL,
	[Language] [nvarchar](5) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_CategoryCourse] PRIMARY KEY CLUSTERED 
(
	[CategoryCourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Course](
	[CourseId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](500) NOT NULL,
	[Url] [nvarchar](1000) NULL,
	[Decription] [nvarchar](1000) NOT NULL,
	[Contents] [nvarchar](max) NULL,
	[Keywords] [nvarchar](500) NULL,
	[Tags] [nvarchar](500) NULL,
	[Image] [nvarchar](500) NULL,
	[ThumbImage] [nvarchar](500) NULL,
	[Language] [nvarchar](5) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Author] [nvarchar](50) NOT NULL,
	[DateStart] [datetime] NOT NULL,
	[DateEnd] [datetime] NOT NULL,
	[IsPrice] [bit] NOT NULL,
	[Price] [float] NULL,
	[PricePromotion] [float] NULL,
	[CategoryCourseId] [int] NOT NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_CategoryCourse] FOREIGN KEY([CategoryCourseId])
REFERENCES [dbo].[CategoryCourse] ([CategoryCourseId])
GO

ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_CategoryCourse]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Khóa học có tiền hay hiện nút tùy tâm' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Course', @level2type=N'COLUMN',@level2name=N'IsPrice'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Hiển thị giá ảo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Course', @level2type=N'COLUMN',@level2name=N'PricePromotion'
GO

CREATE TABLE [dbo].[CourseDetail](
	[CourseDetailId] [int] IDENTITY(1,1) NOT NULL,
	[CourseId] [int] NOT NULL,
	[Fullname] [nvarchar](500) NULL,
	[Address] [nvarchar](1000) NULL,
	[Telephone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[DateRegister] [datetime] NOT NULL,
	[Price] [float] NULL,
 CONSTRAINT [PK_CourseDetail] PRIMARY KEY CLUSTERED 
(
	[CourseDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CourseDetail]  WITH CHECK ADD  CONSTRAINT [FK_CourseDetail_Course] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([CourseId])
GO

ALTER TABLE [dbo].[CourseDetail] CHECK CONSTRAINT [FK_CourseDetail_Course]
GO

CREATE TABLE [dbo].[FAQ](
	[FaqId] [int] IDENTITY(1,1) NOT NULL,
	[Question] [nvarchar](2000) NOT NULL,
	[Answer] [nvarchar](2000) NOT NULL,
	[Language] [nvarchar](5) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_FAQ] PRIMARY KEY CLUSTERED 
(
	[FaqId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleValue] [nvarchar](50) NULL,
	[RoleName] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Account](
	[AccountId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Fullname] [nvarchar](200) NULL,
	[Email] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[IsActive] [bit] NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([RoleId])
GO

ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Role]
GO