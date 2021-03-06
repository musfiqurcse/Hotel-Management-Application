USE [master]
GO
/****** Object:  Database [HotelScheduleManagementApp]    Script Date: 6/17/2015 5:18:28 PM ******/
CREATE DATABASE [HotelScheduleManagementApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HotelScheduleManagementApp', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\HotelScheduleManagementApp.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HotelScheduleManagementApp_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\HotelScheduleManagementApp_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HotelScheduleManagementApp] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HotelScheduleManagementApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HotelScheduleManagementApp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET ARITHABORT OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET  MULTI_USER 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HotelScheduleManagementApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HotelScheduleManagementApp] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [HotelScheduleManagementApp]
GO
/****** Object:  Table [dbo].[Catagory_tbl]    Script Date: 6/17/2015 5:18:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Catagory_tbl](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_SelectCatagory_tbl] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RoomInformation_tbl]    Script Date: 6/17/2015 5:18:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RoomInformation_tbl](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoomNo] [varchar](50) NOT NULL,
	[CatagoryID] [int] NOT NULL,
	[Description] [varchar](500) NOT NULL,
 CONSTRAINT [PK_RoomInformation_tbl] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ScheduleRoom_tbl]    Script Date: 6/17/2015 5:18:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ScheduleRoom_tbl](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [varchar](50) NOT NULL,
	[BookedBy] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[RoomID] [varchar](500) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Catagory_tbl] ON 

INSERT [dbo].[Catagory_tbl] ([ID], [Name]) VALUES (1, N'AC')
INSERT [dbo].[Catagory_tbl] ([ID], [Name]) VALUES (2, N'NON-AC')
SET IDENTITY_INSERT [dbo].[Catagory_tbl] OFF
SET IDENTITY_INSERT [dbo].[RoomInformation_tbl] ON 

INSERT [dbo].[RoomInformation_tbl] ([ID], [RoomNo], [CatagoryID], [Description]) VALUES (1, N'101-A', 1, N'F')
INSERT [dbo].[RoomInformation_tbl] ([ID], [RoomNo], [CatagoryID], [Description]) VALUES (2, N'102-3', 2, N'Not well Decorated')
INSERT [dbo].[RoomInformation_tbl] ([ID], [RoomNo], [CatagoryID], [Description]) VALUES (3, N'103-A', 1, N'Not Decorated')
INSERT [dbo].[RoomInformation_tbl] ([ID], [RoomNo], [CatagoryID], [Description]) VALUES (4, N'103-B', 2, N'Good ')
INSERT [dbo].[RoomInformation_tbl] ([ID], [RoomNo], [CatagoryID], [Description]) VALUES (5, N'302-P', 1, N'Well')
INSERT [dbo].[RoomInformation_tbl] ([ID], [RoomNo], [CatagoryID], [Description]) VALUES (6, N'505-A', 1, N'Fine')
INSERT [dbo].[RoomInformation_tbl] ([ID], [RoomNo], [CatagoryID], [Description]) VALUES (7, N'123-P', 2, N'Full Decorated')
SET IDENTITY_INSERT [dbo].[RoomInformation_tbl] OFF
SET IDENTITY_INSERT [dbo].[ScheduleRoom_tbl] ON 

INSERT [dbo].[ScheduleRoom_tbl] ([ID], [Date], [BookedBy], [Address], [RoomID]) VALUES (1, N'5/31/2015 12:00:00 AM', N'Fully decorated with Gaming System', N'Dhaka', N'1')
INSERT [dbo].[ScheduleRoom_tbl] ([ID], [Date], [BookedBy], [Address], [RoomID]) VALUES (2, N'6/2/2015 12:00:00 AM', N'Not Decorated', N'Nara', N'2')
INSERT [dbo].[ScheduleRoom_tbl] ([ID], [Date], [BookedBy], [Address], [RoomID]) VALUES (3, N'1/1/0001 12:00:00 AM', N'Booked', N'Finished', N'1')
INSERT [dbo].[ScheduleRoom_tbl] ([ID], [Date], [BookedBy], [Address], [RoomID]) VALUES (4, N'6/9/2015 12:00:00 AM', N'Booked', N'Dhaka', N'7')
SET IDENTITY_INSERT [dbo].[ScheduleRoom_tbl] OFF
USE [master]
GO
ALTER DATABASE [HotelScheduleManagementApp] SET  READ_WRITE 
GO
