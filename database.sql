USE [TheFairyNails]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 20/6/2021 5:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[birthday] [datetime] NULL,
	[cellphone] [varchar](20) NULL,
	[point] [int] NULL,
	[sex] [bit] NULL,
	[avatar] [varchar](500) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 20/6/2021 5:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[price] [int] NULL,
	[type] [int] NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceType]    Script Date: 20/6/2021 5:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_ServiceType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 20/6/2021 5:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[cellphone] [nchar](20) NULL,
	[address] [nvarchar](50) NULL,
	[birthday] [date] NULL,
	[avatar] [varchar](500) NULL,
	[sex] [bit] NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Work]    Script Date: 20/6/2021 5:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Work](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NULL,
	[staff_id] [int] NULL,
	[service_id] [int] NULL,
	[status] [int] NULL,
	[time] [datetime] NULL,
 CONSTRAINT [PK_Work] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([id], [name], [birthday], [cellphone], [point], [sex], [avatar]) VALUES (1, N'Van Hoai', CAST(N'2001-08-30T00:00:00.000' AS DateTime), N'(+84) 382 124 399', 0, 1, N'none')
INSERT [dbo].[Customer] ([id], [name], [birthday], [cellphone], [point], [sex], [avatar]) VALUES (2, N'Phan Đức Chinh', CAST(N'2001-09-01T00:00:00.000' AS DateTime), N'(+84) 752 066 112', NULL, 1, NULL)
INSERT [dbo].[Customer] ([id], [name], [birthday], [cellphone], [point], [sex], [avatar]) VALUES (3, N'Tiểu Yến Tử', CAST(N'2001-07-01T00:00:00.000' AS DateTime), N'(+84) 752 522 917', NULL, 0, NULL)
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Service] ON 

INSERT [dbo].[Service] ([id], [name], [price], [type]) VALUES (1, N'Body Wax', 205000, 1)
INSERT [dbo].[Service] ([id], [name], [price], [type]) VALUES (2, N'Beautifu Nails', 150000, 4)
INSERT [dbo].[Service] ([id], [name], [price], [type]) VALUES (3, N'Design Haircut', 279200, 2)
INSERT [dbo].[Service] ([id], [name], [price], [type]) VALUES (5, N'PunchPop', 369000, 3)
INSERT [dbo].[Service] ([id], [name], [price], [type]) VALUES (6, N'Hair Wash', 30000, 2)
SET IDENTITY_INSERT [dbo].[Service] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceType] ON 

INSERT [dbo].[ServiceType] ([id], [name]) VALUES (1, N'Manicure')
INSERT [dbo].[ServiceType] ([id], [name]) VALUES (2, N'Pedicures')
INSERT [dbo].[ServiceType] ([id], [name]) VALUES (3, N'Full set và Fill in')
INSERT [dbo].[ServiceType] ([id], [name]) VALUES (4, N'Eyelashes Extensions')
INSERT [dbo].[ServiceType] ([id], [name]) VALUES (6, N'Nails care')
INSERT [dbo].[ServiceType] ([id], [name]) VALUES (7, N'Waxing')
INSERT [dbo].[ServiceType] ([id], [name]) VALUES (8, N'Facial')
INSERT [dbo].[ServiceType] ([id], [name]) VALUES (9, N'Massage')
INSERT [dbo].[ServiceType] ([id], [name]) VALUES (10, N'Additional Services')
SET IDENTITY_INSERT [dbo].[ServiceType] OFF
GO
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([id], [name], [email], [cellphone], [address], [birthday], [avatar], [sex]) VALUES (1, N'Luis Vuituoi', N'luisvuituoi@gmail.com', N'(+84) 724 844 499   ', N'HCM', CAST(N'1995-08-24' AS Date), N'', 1)
INSERT [dbo].[Staff] ([id], [name], [email], [cellphone], [address], [birthday], [avatar], [sex]) VALUES (3, N'Jordan Babi', N'jordanee@gmail.com', N'0912214450          ', N'jordanee@gmail.com', CAST(N'1999-07-14' AS Date), NULL, 0)
INSERT [dbo].[Staff] ([id], [name], [email], [cellphone], [address], [birthday], [avatar], [sex]) VALUES (4, N'Alexa Siri', N'alexiri@gmail.com', N'0852366905          ', N'London, USA', CAST(N'2003-06-16' AS Date), NULL, 0)
SET IDENTITY_INSERT [dbo].[Staff] OFF
GO
SET IDENTITY_INSERT [dbo].[Work] ON 

INSERT [dbo].[Work] ([id], [customer_id], [staff_id], [service_id], [status], [time]) VALUES (1, 1, 1, 1, 1, CAST(N'2021-06-19T02:16:00.000' AS DateTime))
INSERT [dbo].[Work] ([id], [customer_id], [staff_id], [service_id], [status], [time]) VALUES (2, 1, 1, 3, 2, CAST(N'2021-06-19T02:16:00.000' AS DateTime))
INSERT [dbo].[Work] ([id], [customer_id], [staff_id], [service_id], [status], [time]) VALUES (3, 1, 1, 3, 2, CAST(N'2021-06-20T13:12:12.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Work] OFF
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_Service_ServiceType] FOREIGN KEY([type])
REFERENCES [dbo].[ServiceType] ([id])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_Service_ServiceType]
GO
ALTER TABLE [dbo].[Work]  WITH CHECK ADD  CONSTRAINT [FK_Work_Customer1] FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customer] ([id])
GO
ALTER TABLE [dbo].[Work] CHECK CONSTRAINT [FK_Work_Customer1]
GO
ALTER TABLE [dbo].[Work]  WITH CHECK ADD  CONSTRAINT [FK_Work_Service1] FOREIGN KEY([service_id])
REFERENCES [dbo].[Service] ([id])
GO
ALTER TABLE [dbo].[Work] CHECK CONSTRAINT [FK_Work_Service1]
GO
ALTER TABLE [dbo].[Work]  WITH CHECK ADD  CONSTRAINT [FK_Work_Staff1] FOREIGN KEY([staff_id])
REFERENCES [dbo].[Staff] ([id])
GO
ALTER TABLE [dbo].[Work] CHECK CONSTRAINT [FK_Work_Staff1]
GO
