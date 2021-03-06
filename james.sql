USE [master]
GO
/****** Object:  Database [James]    Script Date: 2020/10/23 上午 08:36:38 ******/
CREATE DATABASE [James]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'James', FILENAME = N'C:\Users\James\Desktop\MSSQL15.MSSQLSERVER\MSSQL\DATA\James.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'James_log', FILENAME = N'C:\Users\James\Desktop\MSSQL15.MSSQLSERVER\MSSQL\DATA\James_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [James] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [James].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [James] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [James] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [James] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [James] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [James] SET ARITHABORT OFF 
GO
ALTER DATABASE [James] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [James] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [James] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [James] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [James] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [James] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [James] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [James] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [James] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [James] SET  DISABLE_BROKER 
GO
ALTER DATABASE [James] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [James] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [James] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [James] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [James] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [James] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [James] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [James] SET RECOVERY FULL 
GO
ALTER DATABASE [James] SET  MULTI_USER 
GO
ALTER DATABASE [James] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [James] SET DB_CHAINING OFF 
GO
ALTER DATABASE [James] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [James] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [James] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'James', N'ON'
GO
ALTER DATABASE [James] SET QUERY_STORE = OFF
GO
USE [James]
GO
/****** Object:  Table [dbo].[class]    Script Date: 2020/10/23 上午 08:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[class](
	[class_id] [int] IDENTITY(1,1) NOT NULL,
	[class] [nvarchar](50) NULL,
 CONSTRAINT [PK_class] PRIMARY KEY CLUSTERED 
(
	[class_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menu]    Script Date: 2020/10/23 上午 08:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menu](
	[meal_id] [int] IDENTITY(1,1) NOT NULL,
	[restaurant_id] [int] NULL,
	[restaurant] [nvarchar](50) NOT NULL,
	[meal] [int] NULL,
	[price] [int] NULL,
 CONSTRAINT [PK_menu] PRIMARY KEY CLUSTERED 
(
	[meal_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orderdetail]    Script Date: 2020/10/23 上午 08:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderdetail](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[oclass] [nvarchar](50) NULL,
	[orestaurant] [nvarchar](50) NULL,
	[omeal] [nvarchar](50) NULL,
	[oorderer] [nvarchar](50) NULL,
	[oprice] [int] NULL,
	[oquantity] [int] NULL,
	[orderdate] [datetime] NULL,
 CONSTRAINT [PK_orderdetail] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[restaurant]    Script Date: 2020/10/23 上午 08:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[restaurant](
	[restaurant_id] [int] IDENTITY(1,1) NOT NULL,
	[restaurant] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[phone] [int] NULL,
 CONSTRAINT [PK_restaurant] PRIMARY KEY CLUSTERED 
(
	[restaurant_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RMenu]    Script Date: 2020/10/23 上午 08:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RMenu](
	[meal_id] [int] IDENTITY(1,1) NOT NULL,
	[restaurant_id] [int] NULL,
	[restaurant] [nvarchar](50) NULL,
	[meal] [nvarchar](50) NULL,
	[price] [int] NULL,
	[pic] [nvarchar](50) NULL,
 CONSTRAINT [PK_RMenu] PRIMARY KEY CLUSTERED 
(
	[meal_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[s_detail]    Script Date: 2020/10/23 上午 08:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[s_detail](
	[s_id] [int] IDENTITY(1,1) NOT NULL,
	[s_name] [nvarchar](50) NULL,
	[class] [nvarchar](50) NULL,
	[class_id] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[level] [nvarchar](50) NULL,
 CONSTRAINT [PK_s_detail] PRIMARY KEY CLUSTERED 
(
	[s_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tstudent]    Script Date: 2020/10/23 上午 08:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tstudent](
	[s_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[class] [nvarchar](50) NULL,
	[class_id] [int] NULL,
	[password] [nvarchar](50) NULL,
	[grade] [int] NULL,
	[daily] [bit] NULL,
	[admin] [bit] NULL,
	[p] [bit] NULL,
 CONSTRAINT [PK_Tstudent] PRIMARY KEY CLUSTERED 
(
	[s_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[class] ON 

INSERT [dbo].[class] ([class_id], [class]) VALUES (1, N'A')
INSERT [dbo].[class] ([class_id], [class]) VALUES (2, N'B')
INSERT [dbo].[class] ([class_id], [class]) VALUES (3, N'C')
SET IDENTITY_INSERT [dbo].[class] OFF
GO
SET IDENTITY_INSERT [dbo].[orderdetail] ON 

INSERT [dbo].[orderdetail] ([order_id], [oclass], [orestaurant], [omeal], [oorderer], [oprice], [oquantity], [orderdate]) VALUES (16, N'A', N'泰式料理', N'打拋豬肉販', N'fd', 80, 1, NULL)
INSERT [dbo].[orderdetail] ([order_id], [oclass], [orestaurant], [omeal], [oorderer], [oprice], [oquantity], [orderdate]) VALUES (17, N'A', N'泰式料理', N'打拋豬肉販', N'fd', 80, 1, NULL)
INSERT [dbo].[orderdetail] ([order_id], [oclass], [orestaurant], [omeal], [oorderer], [oprice], [oquantity], [orderdate]) VALUES (19, N'A', N'池上便當', N'經典便當', N'ff', 85, 1, NULL)
INSERT [dbo].[orderdetail] ([order_id], [oclass], [orestaurant], [omeal], [oorderer], [oprice], [oquantity], [orderdate]) VALUES (21, N'A', N'日式料理', N'親子丼', N'dd', 100, 1, NULL)
INSERT [dbo].[orderdetail] ([order_id], [oclass], [orestaurant], [omeal], [oorderer], [oprice], [oquantity], [orderdate]) VALUES (22, N'A', N'日式料理', N'親子丼', N'ss', 100, 1, NULL)
INSERT [dbo].[orderdetail] ([order_id], [oclass], [orestaurant], [omeal], [oorderer], [oprice], [oquantity], [orderdate]) VALUES (23, N'A', N'日式料理', N'親子丼', N'ss', 100, 1, NULL)
INSERT [dbo].[orderdetail] ([order_id], [oclass], [orestaurant], [omeal], [oorderer], [oprice], [oquantity], [orderdate]) VALUES (25, N'A', N'日式料理', N'親子丼', N'ss', 100, 1, CAST(N'2020-10-22T23:20:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[orderdetail] OFF
GO
SET IDENTITY_INSERT [dbo].[restaurant] ON 

INSERT [dbo].[restaurant] ([restaurant_id], [restaurant], [address], [phone]) VALUES (1, N'池上便當', NULL, NULL)
INSERT [dbo].[restaurant] ([restaurant_id], [restaurant], [address], [phone]) VALUES (2, N'日式料理', NULL, NULL)
INSERT [dbo].[restaurant] ([restaurant_id], [restaurant], [address], [phone]) VALUES (3, N'泰式料理', NULL, NULL)
SET IDENTITY_INSERT [dbo].[restaurant] OFF
GO
SET IDENTITY_INSERT [dbo].[RMenu] ON 

INSERT [dbo].[RMenu] ([meal_id], [restaurant_id], [restaurant], [meal], [price], [pic]) VALUES (1, 1, N'池上便當', N'經典便當', 85, N'經典便當.png')
INSERT [dbo].[RMenu] ([meal_id], [restaurant_id], [restaurant], [meal], [price], [pic]) VALUES (2, 1, N'池上便當', N'雞腿便當', 90, N'雞腿便當.png')
INSERT [dbo].[RMenu] ([meal_id], [restaurant_id], [restaurant], [meal], [price], [pic]) VALUES (3, 1, N'池上便當', N'排骨便當', 95, N'排骨便當.png')
INSERT [dbo].[RMenu] ([meal_id], [restaurant_id], [restaurant], [meal], [price], [pic]) VALUES (4, 2, N'日式料理', N'親子丼', 100, N'親子丼.jpg')
INSERT [dbo].[RMenu] ([meal_id], [restaurant_id], [restaurant], [meal], [price], [pic]) VALUES (5, 2, N'日式料理', N'生魚片', 110, N'生魚片丼.jpg')
INSERT [dbo].[RMenu] ([meal_id], [restaurant_id], [restaurant], [meal], [price], [pic]) VALUES (6, 2, N'日式料理', N'壽司', 105, N'壽司.jpg')
INSERT [dbo].[RMenu] ([meal_id], [restaurant_id], [restaurant], [meal], [price], [pic]) VALUES (7, 3, N'泰式料理', N'打拋豬肉販', 80, N'打拋豬肉販.jpg')
INSERT [dbo].[RMenu] ([meal_id], [restaurant_id], [restaurant], [meal], [price], [pic]) VALUES (8, 3, N'泰式料理', N'泰式椒麻雞', 90, N'泰市郊麻雞.jpg')
INSERT [dbo].[RMenu] ([meal_id], [restaurant_id], [restaurant], [meal], [price], [pic]) VALUES (9, 3, N'泰式料理', N'泰式河粉', 95, N'泰式河粉.jpg')
SET IDENTITY_INSERT [dbo].[RMenu] OFF
GO
SET IDENTITY_INSERT [dbo].[Tstudent] ON 

INSERT [dbo].[Tstudent] ([s_id], [name], [class], [class_id], [password], [grade], [daily], [admin], [p]) VALUES (66, N'Ariana', N'A', 1, N'ariana', NULL, 1, 1, NULL)
INSERT [dbo].[Tstudent] ([s_id], [name], [class], [class_id], [password], [grade], [daily], [admin], [p]) VALUES (67, N'Keeny', N'A', 1, N'keeny', NULL, 1, 0, NULL)
INSERT [dbo].[Tstudent] ([s_id], [name], [class], [class_id], [password], [grade], [daily], [admin], [p]) VALUES (68, N'Alex', N'A', 1, N'alex', NULL, 0, 0, NULL)
INSERT [dbo].[Tstudent] ([s_id], [name], [class], [class_id], [password], [grade], [daily], [admin], [p]) VALUES (69, N'Zoe', N'B', 1, N'zoe', NULL, 0, 0, NULL)
INSERT [dbo].[Tstudent] ([s_id], [name], [class], [class_id], [password], [grade], [daily], [admin], [p]) VALUES (73, N'James', N'B', 1, N'james', NULL, 0, 0, NULL)
SET IDENTITY_INSERT [dbo].[Tstudent] OFF
GO
USE [master]
GO
ALTER DATABASE [James] SET  READ_WRITE 
GO
