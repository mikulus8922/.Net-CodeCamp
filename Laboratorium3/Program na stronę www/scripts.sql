USE [master]
GO
/****** Object:  Database [Hotel]    Script Date: 13.12.2020 19:32:21 ******/
CREATE DATABASE [Hotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hotel', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hotel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hotel_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hotel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Hotel] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hotel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hotel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hotel] SET RECOVERY FULL 
GO
ALTER DATABASE [Hotel] SET  MULTI_USER 
GO
ALTER DATABASE [Hotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hotel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hotel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hotel] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Hotel', N'ON'
GO
ALTER DATABASE [Hotel] SET QUERY_STORE = OFF
GO
USE [Hotel]
GO
/****** Object:  Table [dbo].[Guests]    Script Date: 13.12.2020 19:32:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guests](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[RoomId] [int] NOT NULL,
 CONSTRAINT [PK_Guests] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GuestsAccess]    Script Date: 13.12.2020 19:32:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuestsAccess](
	[GymAccess] [bit] NOT NULL,
	[SpaAccess] [bit] NOT NULL,
	[PoolAccess] [bit] NOT NULL,
	[GuestId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GuestsBlacklist]    Script Date: 13.12.2020 19:32:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuestsBlacklist](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_GuestsBlacklist] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GuestsBooking]    Script Date: 13.12.2020 19:32:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuestsBooking](
	[BookedIn] [date] NOT NULL,
	[BookedOut] [date] NOT NULL,
	[GuestId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GuestsCatering]    Script Date: 13.12.2020 19:32:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuestsCatering](
	[Breakfast] [bit] NOT NULL,
	[Lunch] [bit] NOT NULL,
	[Dinner] [bit] NOT NULL,
	[GuestId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 13.12.2020 19:32:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NOT NULL,
	[RoomCapacity] [int] NOT NULL,
	[Floor] [int] NOT NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Workers]    Script Date: 13.12.2020 19:32:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[AccountId] [int] NOT NULL,
 CONSTRAINT [PK_Workers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkersLoginData]    Script Date: 13.12.2020 19:32:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkersLoginData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[WorkPosition] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_WorkersLoginData] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Guests] ON 

INSERT [dbo].[Guests] ([Id], [FirstName], [LastName], [PhoneNumber], [RoomId]) VALUES (2, N'Diadumenian', N'Wolff', N'453642768', 2)
INSERT [dbo].[Guests] ([Id], [FirstName], [LastName], [PhoneNumber], [RoomId]) VALUES (3, N'Kamau', N'Vidal', N'586349675', 2)
INSERT [dbo].[Guests] ([Id], [FirstName], [LastName], [PhoneNumber], [RoomId]) VALUES (4, N'Preeti', N'Garnett', N'564876789', 7)
SET IDENTITY_INSERT [dbo].[Guests] OFF
GO
INSERT [dbo].[GuestsAccess] ([GymAccess], [SpaAccess], [PoolAccess], [GuestId]) VALUES (1, 0, 0, 2)
INSERT [dbo].[GuestsAccess] ([GymAccess], [SpaAccess], [PoolAccess], [GuestId]) VALUES (1, 0, 0, 3)
INSERT [dbo].[GuestsAccess] ([GymAccess], [SpaAccess], [PoolAccess], [GuestId]) VALUES (1, 1, 1, 4)
GO
SET IDENTITY_INSERT [dbo].[GuestsBlacklist] ON 

INSERT [dbo].[GuestsBlacklist] ([Id], [FirstName], [LastName], [PhoneNumber]) VALUES (1, N'Jan', N'Kowalski', N'123456789')
INSERT [dbo].[GuestsBlacklist] ([Id], [FirstName], [LastName], [PhoneNumber]) VALUES (9, N'Eskandar', N'Chang', N'987654321')
INSERT [dbo].[GuestsBlacklist] ([Id], [FirstName], [LastName], [PhoneNumber]) VALUES (10, N'Marta', N'Kelly', N'333666999')
SET IDENTITY_INSERT [dbo].[GuestsBlacklist] OFF
GO
INSERT [dbo].[GuestsBooking] ([BookedIn], [BookedOut], [GuestId]) VALUES (CAST(N'2020-12-07' AS Date), CAST(N'2020-12-15' AS Date), 2)
INSERT [dbo].[GuestsBooking] ([BookedIn], [BookedOut], [GuestId]) VALUES (CAST(N'2020-12-07' AS Date), CAST(N'2020-12-15' AS Date), 3)
INSERT [dbo].[GuestsBooking] ([BookedIn], [BookedOut], [GuestId]) VALUES (CAST(N'2020-11-29' AS Date), CAST(N'2020-12-20' AS Date), 4)
GO
INSERT [dbo].[GuestsCatering] ([Breakfast], [Lunch], [Dinner], [GuestId]) VALUES (1, 0, 0, 2)
INSERT [dbo].[GuestsCatering] ([Breakfast], [Lunch], [Dinner], [GuestId]) VALUES (1, 0, 0, 3)
INSERT [dbo].[GuestsCatering] ([Breakfast], [Lunch], [Dinner], [GuestId]) VALUES (1, 1, 1, 4)
GO
SET IDENTITY_INSERT [dbo].[Rooms] ON 

INSERT [dbo].[Rooms] ([Id], [Number], [RoomCapacity], [Floor]) VALUES (2, 11, 2, 1)
INSERT [dbo].[Rooms] ([Id], [Number], [RoomCapacity], [Floor]) VALUES (3, 12, 2, 1)
INSERT [dbo].[Rooms] ([Id], [Number], [RoomCapacity], [Floor]) VALUES (4, 13, 3, 1)
INSERT [dbo].[Rooms] ([Id], [Number], [RoomCapacity], [Floor]) VALUES (5, 14, 3, 1)
INSERT [dbo].[Rooms] ([Id], [Number], [RoomCapacity], [Floor]) VALUES (6, 21, 2, 2)
INSERT [dbo].[Rooms] ([Id], [Number], [RoomCapacity], [Floor]) VALUES (7, 22, 2, 2)
INSERT [dbo].[Rooms] ([Id], [Number], [RoomCapacity], [Floor]) VALUES (8, 23, 4, 2)
INSERT [dbo].[Rooms] ([Id], [Number], [RoomCapacity], [Floor]) VALUES (9, 31, 5, 3)
INSERT [dbo].[Rooms] ([Id], [Number], [RoomCapacity], [Floor]) VALUES (10, 32, 5, 3)
SET IDENTITY_INSERT [dbo].[Rooms] OFF
GO
SET IDENTITY_INSERT [dbo].[Workers] ON 

INSERT [dbo].[Workers] ([Id], [FirstName], [LastName], [AccountId]) VALUES (1, N'Mikołaj', N'Rarok', 1)
INSERT [dbo].[Workers] ([Id], [FirstName], [LastName], [AccountId]) VALUES (2, N'Natalia', N'Stolarz', 2)
INSERT [dbo].[Workers] ([Id], [FirstName], [LastName], [AccountId]) VALUES (3, N'Lech', N'Wawrzykowski', 3)
INSERT [dbo].[Workers] ([Id], [FirstName], [LastName], [AccountId]) VALUES (4, N'Łucjan', N'Sitko', 4)
SET IDENTITY_INSERT [dbo].[Workers] OFF
GO
SET IDENTITY_INSERT [dbo].[WorkersLoginData] ON 

INSERT [dbo].[WorkersLoginData] ([Id], [Login], [Password], [WorkPosition]) VALUES (1, N'admin', N'admin', N'SystemAdmin')
INSERT [dbo].[WorkersLoginData] ([Id], [Login], [Password], [WorkPosition]) VALUES (2, N'reception', N'reception', N'Receptionist')
INSERT [dbo].[WorkersLoginData] ([Id], [Login], [Password], [WorkPosition]) VALUES (3, N'catering', N'catering', N'CateringManager')
INSERT [dbo].[WorkersLoginData] ([Id], [Login], [Password], [WorkPosition]) VALUES (4, N'owner', N'owner', N'Owner')
SET IDENTITY_INSERT [dbo].[WorkersLoginData] OFF
GO
ALTER TABLE [dbo].[Guests]  WITH CHECK ADD  CONSTRAINT [FK_Guests_Rooms] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Rooms] ([Id])
GO
ALTER TABLE [dbo].[Guests] CHECK CONSTRAINT [FK_Guests_Rooms]
GO
ALTER TABLE [dbo].[GuestsAccess]  WITH CHECK ADD  CONSTRAINT [FK_GuestsAccess_Guests] FOREIGN KEY([GuestId])
REFERENCES [dbo].[Guests] ([Id])
GO
ALTER TABLE [dbo].[GuestsAccess] CHECK CONSTRAINT [FK_GuestsAccess_Guests]
GO
ALTER TABLE [dbo].[GuestsBooking]  WITH CHECK ADD  CONSTRAINT [FK_GuestsBooking_Guests] FOREIGN KEY([GuestId])
REFERENCES [dbo].[Guests] ([Id])
GO
ALTER TABLE [dbo].[GuestsBooking] CHECK CONSTRAINT [FK_GuestsBooking_Guests]
GO
ALTER TABLE [dbo].[GuestsCatering]  WITH CHECK ADD  CONSTRAINT [FK_GuestsCatering_Guests] FOREIGN KEY([GuestId])
REFERENCES [dbo].[Guests] ([Id])
GO
ALTER TABLE [dbo].[GuestsCatering] CHECK CONSTRAINT [FK_GuestsCatering_Guests]
GO
ALTER TABLE [dbo].[Workers]  WITH CHECK ADD  CONSTRAINT [FK_Workers_WorkersLoginData] FOREIGN KEY([AccountId])
REFERENCES [dbo].[WorkersLoginData] ([Id])
GO
ALTER TABLE [dbo].[Workers] CHECK CONSTRAINT [FK_Workers_WorkersLoginData]
GO
USE [master]
GO
ALTER DATABASE [Hotel] SET  READ_WRITE 
GO
