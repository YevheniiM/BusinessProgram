USE [master]
GO
/****** Object:  Database [main_database]    Script Date: 28/04/2019 12:28:22 ******/
CREATE DATABASE [main_database] ON  PRIMARY 
( NAME = N'main_database_old', FILENAME = N'D:\Study\Programing\dotNet\BusinessProg\BusinessProg\bin\Debug\DataBase\main_database_old.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'main_database_old_log', FILENAME = N'D:\Study\Programing\dotNet\BusinessProg\BusinessProg\bin\Debug\DataBase\main_database_old_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [main_database].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [main_database] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [main_database] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [main_database] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [main_database] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [main_database] SET ARITHABORT OFF 
GO
ALTER DATABASE [main_database] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [main_database] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [main_database] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [main_database] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [main_database] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [main_database] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [main_database] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [main_database] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [main_database] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [main_database] SET  DISABLE_BROKER 
GO
ALTER DATABASE [main_database] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [main_database] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [main_database] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [main_database] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [main_database] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [main_database] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [main_database] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [main_database] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [main_database] SET  MULTI_USER 
GO
ALTER DATABASE [main_database] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [main_database] SET DB_CHAINING OFF 
GO
USE [main_database]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 28/04/2019 12:28:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Category_Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Category_Name] [nvarchar](255) NULL,
	[Parent_Id] [bigint] NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Category_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 28/04/2019 12:28:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](100) NULL,
	[Discount] [decimal](18, 0) NULL,
	[ExtraData] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 28/04/2019 12:28:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Product_Key] [bigint] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Product_Name] [nvarchar](256) NULL,
	[Category_ID] [bigint] NULL,
	[Products_Bought] [bigint] NULL,
	[Products_Sold] [bigint] NULL,
	[Provider_ID] [bigint] NULL,
	[Price] [decimal](18, 4) NULL,
PRIMARY KEY CLUSTERED 
(
	[Product_Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProviderOffers]    Script Date: 28/04/2019 12:28:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProviderOffers](
	[Purchase_Key] [bigint] IDENTITY(1,1) NOT NULL,
	[Date] [varchar](100) NULL,
	[Provider_Id] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Purchase_Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProviderOffers_Products]    Script Date: 28/04/2019 12:28:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProviderOffers_Products](
	[Purchase_Product_Key] [bigint] IDENTITY(1,1) NOT NULL,
	[Product_Key] [bigint] NULL,
	[Count] [bigint] NULL,
	[Price] [decimal](18, 0) NULL,
	[Purchase_Key] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Purchase_Product_Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Providers]    Script Date: 28/04/2019 12:28:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Providers](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Phone] [nvarchar](50) NULL,
	[ExtraData] [nvarchar](max) NULL,
 CONSTRAINT [PK_Providers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale_Products]    Script Date: 28/04/2019 12:28:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale_Products](
	[Sale_Product_Key] [bigint] IDENTITY(1,1) NOT NULL,
	[Product_Key] [bigint] NULL,
	[Count] [bigint] NULL,
	[Price] [decimal](18, 0) NULL,
	[Sale_Key] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Sale_Product_Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 28/04/2019 12:28:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[Sale_Key] [bigint] IDENTITY(1,1) NOT NULL,
	[Date_of_Sale] [varchar](100) NULL,
	[Client_Id] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Sale_Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 28/04/2019 12:28:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](100) NULL,
	[Password] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (1, N'Косметика', 0)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (2, N'Солодка Мрія', 0)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (3, N'Пастила', 0)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (4, N'Пасика', 0)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (5, N'Набори косметики', 1)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (6, N'Уход за телом', 1)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (7, N'Уход за руками', 1)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (8, N'Уход за ногами', 1)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (9, N'Уход за лицом', 1)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (10, N'Уход за волосами', 1)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (11, N'Гели для душа', 1)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (12, N'Редкое мыло', 1)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (13, N'Твердое мыло', 1)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (14, N'Наборы сладостей', 2)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (15, N'Конфеты (фасовка)', 2)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (16, N'Конфеты', 2)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (17, N'Зефир в шоколаде (фасовка)', 2)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (18, N'Зефир в шоколаде (2,8кг)', 2)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (19, N'Зефир (1кг)', 2)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (20, N'Зефир (фасовка)', 2)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (21, N'Зефир (2,8кг)', 2)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (22, N'Мармелад (фасовка)', 2)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (23, N'Мармелад', 2)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (24, N'Пастила батончики', 3)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (25, N'Пастила креманка (170г)', 3)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (26, N'Мед', 4)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (27, N'Свечи', 4)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (28, N'Продукты пчеловодства', 4)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (29, N'Настойки', 4)
INSERT [dbo].[Categories] ([Category_Id], [Category_Name], [Parent_Id]) VALUES (30, N'Перга', 4)
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([Id], [Name], [PhoneNumber], [Discount], [ExtraData]) VALUES (1, N'Вася', NULL, CAST(15 AS Decimal(18, 0)), NULL)
INSERT [dbo].[Clients] ([Id], [Name], [PhoneNumber], [Discount], [ExtraData]) VALUES (2, N'Петя', NULL, CAST(20 AS Decimal(18, 0)), NULL)
SET IDENTITY_INSERT [dbo].[Clients] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (1, N'4820150750022', N'Мило туалетне натуральне ручної роботи ЯКА   "Алоє та бджолиний віск"(75гр.)', 13, 1016, 456, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (2, N'4820150750039', N'Мило туалетне натуральне ручної роботи ЯКА  "Апельсин - ваніль"(75гр.)', 13, 85, 1, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (3, N'4820150750664', N'Мило туалетне натуральне ручної роботи ЯКА   "Безсмертник " (75гр.)', 13, 11, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (4, N'4820150750046', N'Мило туалетне натуральне ручної роботи ЯКА  "Блакитна глина" (75гр.)', 13, 10, 1, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (5, N'4820150750671', N'Мило туалетне натуральне ручної роботи ЯКА    "Вереск  " (75гр.)', 13, 11, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (6, N'4,8201507515e+012', N'Мило туалетне натуральне ручної роботи ЯКА "Гуцульський травяний збір" (75гр.)', 13, 10, 5, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (7, N'4820150750107', N'Мило туалетне натуральне ручної роботи ЯКА  "День і ніч" (75гр.)', 13, 11, 1, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (8, N'4820150750114', N'Мило туалетне натуральне ручної роботи ЯКА  "Дігтярне" (75гр.)', 13, 15, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (9, N'4820150750138', N'Мило туалетне натуральне ручної роботи ЯКА  "Для сауниз ялівцем" (75гр.)', 13, 10, 0, 1, CAST(123.1232 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (10, N'4,8201507515e+012', N'Мило туалетне натуральне ручної роботи ЯКА  "Зілля Старого Мольфара" (75гр.)', 13, 10, 0, 1, CAST(123.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (11, N'4820150750183', N'Мило туалетне натуральне ручної роботи ЯКА  "З трьох трав" (75гр.)', 13, 10, 1, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (12, N'4820150750206', N'Мило туалетне натуральне ручної роботи ЯКА  "Кавове" (75гр.)', 13, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (13, N'4820150750213', N'Мило туалетне натуральне ручної роботи ЯКА  "Какао-пшеничні висівки" (75гр.)', 13, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (14, N'4820150750220', N'Мило туалетне натуральне ручної роботи ЯКА  "Камфорне" (75гр.)', 13, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (15, N'4,8201507515e+012', N'Мило туалетне натуральне ручної роботи ЯКА  "Карпатське класичне" (75гр.)', 13, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (16, N'4,8201507515e+012', N'Мило туалетне натуральне ручної роботи ЯКА "Карпатська лазня" (75гр.)', 13, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (17, N'4,8201507515e+012', N'Мило туалетне натуральне ручної роботи ЯКА "Карпатський гірський мед" (75гр.)', 13, 10, 15, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (18, N'4820150750237', N'Мило туалетне натуральне ручної роботи  ЯКА "Лаванда" (75гр.)', 13, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (19, N'4820150750275', N'Мило туалетне натуральне ручної роботи ЯКА  "Лікарський збір" (75гр.)', 13, 10, 2, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (20, N'4820150750299', N'Мило туалетне натуральне ручної роботи ЯКА  "Медове з лимоном" (75гр)', 13, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (21, N'4820150750688', N'Мило туалетне натуральне ручної роботи ЯКА  "Оливка" (75гр.)', 13, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (22, N'4820150750695', N'Мило туалетне натуральне ручної роботи ЯКА   "Розмарин"  (75гр.)', 13, 10, 1, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (23, N'4820150750336', N'Мило туалетне натуральне ручної роботи ЯКА   "Ромашка та календула" (75гр.)', 13, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (24, N'4820150750343', N'Мило туалет. натураль. ручної роботи ЯКА "Сірчано - дігтярне" (75гр.)', 13, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (25, N'4820150750350', N'Мило туалетне натуральне ручної роботи ЯКА  "Спокуса" (75гр.)', 13, 10, 1, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (26, N'4820150750367', N'Мило туалетне натуральне ручної роботи ЯКА  "Троянда" (75гр.)', 13, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (27, N'4820150750374', N'Мило туалетне натуральне ручної роботи ЯКА "Чистотіл з воском" (75гр.)', 13, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (28, N'4820150750381', N'Мило туалетне натуральне ручної роботи ЯКА " Чистюля" (75гр.)', 13, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (29, N'29516056', N'Мочалка з натуральним  милом ЯКА', 13, 10, 10, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (30, N'4820150750404', N'Мило  натуральне рідке ЯКА  "Дітярне" (100мл.)', 12, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (31, N'4820150750428', N'Мило  натуральне рідке ЯКА "Кедровий горіх" (150мл.)', 12, 11, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (32, N'4820150750442', N'Мило  натуральне рідке ЯКА "Морські мінерали"  (150мл.)', 12, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (33, N'4820150750459', N'Мило  натуральне рідке ЯКА "Подорожник"  (150мл.)', 12, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (34, N'4820150750466', N'Мило  натуральне рідке ЯКА "Цитрусове"  (150мл.)', 12, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (35, N'4,8201507515e+012', N'Мило  натуральне рідке ЯКА  "Живокіст"  (250мл.)', 12, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (36, N'4820150751234', N'Мило рідке  для обличчя (для сухої шкіри з екстрактом Календула) (250мл.)', 12, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (37, N'4820150751135', N'Мило натуральне  рідке "Дігтярне  ялівець" (250мл.)', 12, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (38, N'4820150751159', N'Мило натуральне  рідке "Ромашкове" проти сухості рук (250мл.)', 12, 10, 1, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (39, N'4820150751142', N'Мило натуральне  рідке "Череда" проти тріщин та ран (250мл.)', 12, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (40, N'4820150750626', N'Мило натуральне рідке  ЯКА "Безсмертник"   (275мл.)', 12, 11, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (41, N'4820150750633', N'Мило натуральне рідке  ЯКА "Вереск  "   (275мл.)', 12, 11, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (42, N'4820150750640', N'Мило натуральне рідке  ЯКА "Оливка"  (275мл.)', 12, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (43, N'4820150750657', N'Мило натуральне рідке  ЯКА  "Розмарин " (275мл.)', 12, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (44, N'4820150751210', N'Гель для вмивання  для інфікованої шкіри  (250мл.)', 12, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (45, N'4820150750527', N'Гель для душу   ЯКА   "Вербена"  (200мл.)', 11, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (46, N'4820150750497', N'Крем -гель душу ЯКА   "Суниця лісова"  (200мл.)', 11, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (47, N'4820150750503', N'Гель для душу   ЯКА   "Хвоя - розмарин" (200мл.)', 11, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (48, N'4820150750565', N'Крем -гель для душу   ЯКА   "Клюква - лимон" (200мл.)', 11, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (49, N'4820150750558', N'Гель для душу натуральний  ЯКА   "Липовий   мед" (200мл.)', 11, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (50, N'4820150750541', N'Гель для душу   ЯКА   "Морські водорості" (200мл.)', 11, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (51, N'4820150750534', N'Крем гель для душу ЯКА   "Оливковий" (200мл.)', 11, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (52, N'4820150750619', N'Гель для душу  ЯКА  "Безсмертник" (350мл.)', 11, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (53, N'4820150750602', N'Гель для душу  ЯКА  "Вереск" (350мл.)', 11, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (54, N'4820150750596', N'Гель для душу  ЯКА  "Оливка" (350мл.)', 11, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (55, N'4820150750589', N'Гель для душу  ЯКА  "Розмарин" (350мл.)', 11, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (56, N'4820150750947', N'Гель для  тіла та шампунь для волосся  ЯКА (330мл)', 11, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (57, N'4820150750572', N'Піна для ванни  ЯКА  "Липа "   (350мл.)', 11, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (58, N'4820150750961', N'Шампунь проти лупи  для чоловіків ЯКА  (270мл.)', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (59, N'4820150750725', N'Шампунь - кондиціонер для збільшення обєму   "З вівсом"  (350мл.)', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (60, N'4820150750749', N'Шампунь  укріплення волося "З льоном"  (350мл.)', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (61, N'4820150750718', N'Шампунь - бальзам для відновлення волосся  "З  пшеницею" (350мл.)', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (62, N'4820150750732', N'Шампунь  - бальзам для щоденного використання  "З  чебрецем" (350мл.)', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (63, N'4820150751029', N'Шампунь-бальзам  для відновлення волосся "ДІГТЯРНИЙ"(500мл.)', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (64, N'4820150751036', N'Шампунь-бальзам  ДЛЯ СУХОГО ВОЛОССЯ  (500мл.)', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (65, N'4820150751043', N'Шампунь-бальзам  ДЛЯ ЩОДЕННОГО ВИКОРИСТАННЯ  (500мл.)', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (66, N'4820150751012', N'Шампунь  ДЛЯ УКРІПЛЕННЯ ВОЛОССЯ  (500мл.)', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (67, N'4820150751005', N'Шампунь  ПРОТИ ЛУПИ   (500мл.)', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (68, N'4820150751241', N'Кондиціонер   ДЛЯ СУХОГО ТА ФАРБОВАНОГО ВОЛОССЯ   (250мл.)', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (69, N'4820150751098', N'Кондиціонер  ДЛЯ ЩОДЕННОГО ВИКОРИСТАННЯ (250мл.)', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (70, N'4,8201507518e+012', N'Шампунь для укріплення волосся з Алое Вера (300 мл) ', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (71, N'4,8201507516e+012', N'Шампунь-бальзам з кератином для захисту волосся  (300 мл) ', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (72, N'4,8201507519e+012', N'Шампунь-бальзам проти ламкості волосся з олією обліпихи  (300 мл) ', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (73, N'4,8201507518e+012', N'Шампунь-бальзам для фарбованого волосся (300 мл) ', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (74, N'4,8201507518e+012', N'Мус для укріплення волосся з лікарськими травами (200 мл) ', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (75, N'4,8201507516e+012', N'Маска для волосся гідро-баланс з морським колагеном та гряззю мертвого моря (200 мл) ', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (76, N'4,820150752e+012', N'Маска для відновлення волосся з кератином (200 мл) Аптекарська серія', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (77, N'4,820150752e+012', N'Бальзам для волосся відновлюючий з кератином та олією обліпихи (200 мл) ', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (78, N'4,8201507519e+012', N'Олія для відновлення (посічених) кінчиків волосся (15 мл) ', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (79, N'4,8201507519e+012', N'Спрей для волосся «Миттєве відновлення» з олією обліпихи та кератином (100 мл) ', 10, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (80, N'4,8201507516e+012', N'Піна  для вмивання для чутливої шкіри (150мл.)', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (81, N'4820150751067', N'Молочко для зняття макіяжу (100мл)', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (82, N'4820150751203', N'Гідро-гель для обличчя  з ефектом міні-ліфтінгу (100мл.)', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (83, N'4820150750930', N'Гідро -  гель після  гоління  ЯКА (160мл.)', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (84, N'4820150750954', N'Бальзам після гоління  ЯКА  (160мл.)', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (85, N'4820150750923', N'Гель для гоління  ЯКА  ( (220мл.)', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (86, N'4820150751180', N'Вершки для обличчя  для ідеального живлення (60мл.)', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (87, N'4820150751197', N'Флюїд для обличчя  для ідеального зволоження   (60мл.)', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (88, N'4,8201507511e+012', N'Крем для обличчя для  чоловіків  ЯКА  (220мл.)', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (89, N'4,8201507516e+012', N'Двофазний тонік  "Алоє Вєра"  (60мл.)', 9, 10, 20, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (90, N'4,8201507516e+012', N'Двофазний тонік "Ромашковий"  (60мл.)', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (91, N'4820150751074', N'Тонік для обличчя для нормальної та жирної шкіри (60мл.)', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (92, N'4820150751081', N'Тонік для обличчя для сухої та схильної до алергії шкіри (60мл.)', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (93, N'4820150751166', N'Скраб для обличчя  "Морквяний" (100мл.)', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (94, N'4820150751173', N'Скраб для обличчя проти чорних цяток   (100мл.)', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (95, N'4,8201507516e+012', N'Сироватка для догляду за обличчям з червоною ікрою (15 мл) ', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (96, N'4,8201507516e+012', N'Крем-гель для шкіри навколо очей з червоною ікрою (15 мл) ', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (97, N'4,8201507521e+012', N'Гідроліпідна маска для обличчя з червоною ікрою (30 мл) ', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (98, N' 4820150751807', N'Сироватка для обличчя з біозолотом (15 мл) ', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (99, N' 4820150752088', N'Нічний крем для обличчя з біозолотом  «Відновлюючий» (30 мл) ', 9, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
GO
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (100, N'4820150751128', N'Гідро - гель  "Травяний гель для рук" (100мл.)', 7, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (101, N'4820150751104', N'Вершки для глибокого  живлення та краси рук (60мл)', 7, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (102, N'4820150751111', N'Крем для дуже сухої шкіри рук (60мл)', 7, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (103, N'4820150751258', N'Крем для  рук Ніічний догляд (під рукавички)  (60мл)', 7, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (104, N' 4820150751869', N'Крем-гель для рук «Зволоження та догляд» (60 мл) ', 7, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (105, N'4,820150752e+012', N'Олія для нігтів та кутикул (6 мл) Аптекарська серія', 7, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (106, N'4,8201507519e+012', N'Пом’якшуючий крем антиреспірант для ніг (200 мл) ', 8, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (107, N'4,820150752e+012', N'Пом’якшуючий крем  для ніг (100 мл) Аптекарська серія', 8, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (108, N'4,820150752e+012', N'Крем для ніг проти тріщин з живокостом (100 мл) Аптекарська серія', 8, 11, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (109, N'4820150750794', N'М''який крем "Грейпфрут"  (275мл.)', 6, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (110, N'4820150750817', N'М''який крем "Кавовий"  (275мл.)', 6, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (111, N'4820150750800', N'М''який крем "Шавлія"  (275мл.', 6, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (112, N'4,8201507516e+012', N'Молочко для тіла" "Грейпфрут" (200мл.)', 6, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (113, N'4,8201507516e+012', N'Молочко для тіла "Кавове" (200мл.)', 6, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (114, N'4,8201507516e+012', N'Молочко для тіла "Шавлія"  (200мл.)', 6, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (115, N'4820150750893', N'Масло  для тіла "Лимон та м''ята"  (150мл.)', 6, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (116, N'4820150750909', N'Масло  для тіла" Мигдаль - апельсин"   (150мл.)', 6, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (117, N'4820150750916', N'Масло  для тіла "Троянда"   (150мл.)', 6, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (118, N'4820150750824', N'Спрей  зволожуючий "Троянда"  (100мл.)', 6, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (119, N'4820150750831', N'Спрей охолоджуючий "Зелений  чай"   (100мл.)', 6, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (120, N'4820150750985', N'Скраб для тіла" "Грейпфрут" (300мл.)', 6, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (121, N'4820150750992', N'Скраб  для тіла "Кавовий"  (300мл.)', 6, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (122, N'4820150750978', N'Скраб для тіла "Шавлія"  (300мл.)', 6, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (123, N' 4820150751852', N'Йогурт для догляду за шкірою шиї та зоною декольте (100 мл) ', 6, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (124, N'4,8201507519e+012', N'Скраб для тіла трав’яний (300 мл) ', 6, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (125, N'4,8201507517e+012', N'Обгортування для тіла з морськими водоростями та з гряззю мертвого моря (300 мл) ', 6, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (126, N'4,8201507519e+012', N'Цитрусовий мус для зволоження тіла (300 мл) ', 6, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (127, N'4,8201507518e+012', N'Емульсія для тіла з екстрактом кави та олією кориці (100 мл) ', 6, 11, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (128, N'0', N'НАБІР № 1 (до складу входять: гель для душу 350мл - 1шт, рідке мило 275мл - 1шт, шампунь 350мл - 1шт)', 5, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (129, N'0', N'НАБІР № 2 (до складу входять: мило тверде 75гр. - 2шт, масло для тіла 150мл - 1 шт, скраб для тіла 300мл. - 1шт., спрей для тіла 100мл - 1шт)', 5, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (130, N'0', N'НАБІР № 3 (до складу входять: мило тверде 75гр. - 2шт, масло для тіла 150мл - 1 шт, рідке мило 275мл - 1шт, м''який крем 275мл - 1шт, молочко для тіла 350мл - 1шт)', 5, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (131, N'0', N'НАБІР № 4 (до складу входять: мило тверде 75гр. - 1шт, гель для душу  350мл - 1шт)', 5, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (132, N'0', N'НАБІР № 5 (до складу входять:  мило тверде 75гр. - 1шт, гель для душу  350мл - 1шт, рідке мило 275мл - 1шт)', 5, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (133, N'0', N'НАБІР № 6 (до складу входять: мило тверде 75гр. - 1шт, рідке мило 275мл - 1шт, масло для тіла 150мл - 1шт)', 5, 10, 0, 1, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (134, N'2001', N'Натуральный мармелад "Восточный с курагой" в шоколаде', 23, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (135, N'2002', N'Натуральный фруктовый мармелад Клюква', 23, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (136, N'2003', N'Натуральный фруктовый мармелад Черничный', 23, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (137, N'2004', N'Натуральный мармелад "Восточный с черносливом" в шоколаде ', 23, 16, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (138, N'2005', N'Натуральный фруктовый мармелад Цитрусовый с лимоном ', 23, 15, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (139, N'2006', N'Натуральный фруктовый мармелад Цитрусовый с мандариномм ', 23, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (140, N'2007', N'Натуральный фруктовый мармелад Цитрусовый с лаймом ', 23, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (141, N'2008', N'Натуральный фруктовый мармелад Цитрусовый с грейпфрутом ', 23, 11, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (142, N'2009', N'Натуральный фруктовый мармелад Цитрусовый с апельсином ', 23, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (143, N'2010', N'Натуральный фруктовый мармелад Имбирный ', 23, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (144, N'2011', N'Натуральный фруктовый мармелад Вишня', 23, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (145, N'0', N'Натуральный фруктовый мармелад ', 23, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (146, N'2013', N'Натуральный мармелад "Восточный с курагой" в шоколаде (Фасовка)', 22, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (147, N'2014', N'Натуральный фруктовый мармелад Клюква (Фасовка)', 22, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (148, N'2015', N'Натуральный фруктовый мармелад Черничный (Фасовка)', 22, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (149, N'2016', N'Натуральный мармелад "Восточный с черносливом" в шоколаде (Фасовка)', 22, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (150, N'2017', N'Натуральный фруктовый мармелад Цитрусовый с лимоном (Фасовка)', 22, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (151, N'2018', N'Натуральный фруктовый мармелад Цитрусовый с мандарином (Фасовка)', 22, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (152, N'2019', N'Натуральный фруктовый мармелад Цитрусовый с лаймом (Фасовка)', 22, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (153, N'2020', N'Натуральный фруктовый мармелад Цитрусовый с грейпфрутом (Фасовка)', 22, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (154, N'2021', N'Натуральный фруктовый мармелад Цитрусовый с апельсином (Фасовка)', 22, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (155, N'2022', N'Натуральный фруктовый мармелад Имбирный (Фасовка)', 22, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (156, N'2023', N'Натуральный фруктовый мармелад Вишня  (Фасовка)', 22, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (157, N'2051', N'Натуральный Зефир Абрикосовый', 21, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (158, N'2052', N'Натуральный Зефир Ванильный', 21, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (159, N'2053', N'Натуральный Зефир Крем-Брюле', 21, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (160, N'2054', N'Натуральный Зефир Амур', 21, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (161, N'2055', N'Натуральный Зефир Бело-Розовый', 21, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (162, N'2056', N'Натуральный Зефир Вишня', 21, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (163, N'0', N'Натуральный Зефир Абрикосовый', 20, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (164, N'0', N'Натуральный Зефир Ванильный', 20, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (165, N'0', N'Натуральный Зефир Крем-Брюле', 20, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (166, N'0', N'Натуральный Зефир Амур', 20, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (167, N'0', N'Натуральный Зефир Бело-Розовый', 20, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (168, N'0', N'Натуральный Зефир Вишня', 20, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (169, N'0', N'зефир 1кг ', 20, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (170, N'2086', N'Натуральный Зефир Абрикосовый (1кг.)', 19, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (171, N'2087', N'Натуральный Зефир Ванильный (1кг.)', 19, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (172, N'2088', N'Натуральный Зефир Крем-Брюле (1кг.)', 19, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (173, N'2089', N'Натуральный Зефир Амур (1кг.)', 19, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (174, N'2090', N'Натуральный Зефир Бело-Розовый (1кг.)', 19, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (175, N'2091', N'Натуральный Зефир Вишня (1кг.)', 19, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (176, N'2071', N'Натуральный Зефир Пингвин  (1кг.)', 19, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (177, N'2072', N'Натуральный Зефир Чорная жемчужина  (1кг.)', 19, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (178, N'2060', N'Натуральный Зефир Арабески', 19, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (179, N'2061', N'Натуральный Зефир Пингвин', 18, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (180, N'2062', N'Натуральный Зефир Чорная жемчужина', 18, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (181, N'2063', N'Зефир "Детская забава"', 18, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (182, N'2064', N'Натуральный Зефир "Волшебная Лакомка"', 18, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (183, N'2061', N'Натуральный Зефир Пингвин', 17, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (184, N'2062', N'Натуральный Зефир Чорная жемчужина', 17, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (185, N'2063', N'Зефир "Детская забава"', 17, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (186, N'2064', N'Натуральный Зефир "Волшебная Лакомка"', 17, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (187, N'2100', N'Конфеты Птичье молоко', 16, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (188, N'2101', N'Конфеты Сливочно черничные', 16, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (189, N'2102', N'Конфеты До-ре-ми', 16, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (190, N'2103', N'Суфле лимонное', 16, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (191, N'0', N'Суфле журавлина', 16, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (192, N'0', N'Подарочный набор натуральных сладостей ТМ Солодка Мрия №1 "Сладкое Трио"', 15, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (193, N'0', N'Подарочный набор натуральных сладостей ТМ Солодка Мрия №3 "Сундучек радости"', 15, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (194, N'0', N'Набор №2 "Сладкий шах"', 15, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (195, N'0', N'Набор №5 "Великолепная пятерка" ', 15, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (196, N'0', N'Набор №4 "Птичье молоко и черника" ', 15, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (197, N'0', N'Набор №1 натурального фруктового мармелада ', 15, 10, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (198, N'0', N'Печенье  (в ассортименте)', 15, 11, 0, 2, CAST(100.0000 AS Decimal(18, 4)))
INSERT [dbo].[Products] ([Product_Key], [Code], [Product_Name], [Category_ID], [Products_Bought], [Products_Sold], [Provider_ID], [Price]) VALUES (231, N'23213213', N'Тест', NULL, 10, 0, NULL, CAST(100.0000 AS Decimal(18, 4)))
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[ProviderOffers] ON 

INSERT [dbo].[ProviderOffers] ([Purchase_Key], [Date], [Provider_Id]) VALUES (11, N'01.01.2000', 1)
INSERT [dbo].[ProviderOffers] ([Purchase_Key], [Date], [Provider_Id]) VALUES (12, N'12.01.2000', 1)
INSERT [dbo].[ProviderOffers] ([Purchase_Key], [Date], [Provider_Id]) VALUES (13, N'25.02.2017 19:11:02', 1)
INSERT [dbo].[ProviderOffers] ([Purchase_Key], [Date], [Provider_Id]) VALUES (14, N'25.02.2017 19:17:25', 1)
INSERT [dbo].[ProviderOffers] ([Purchase_Key], [Date], [Provider_Id]) VALUES (15, N'26.02.2017 0:54:41', 2)
INSERT [dbo].[ProviderOffers] ([Purchase_Key], [Date], [Provider_Id]) VALUES (16, N'10/11/2018 17:39:12', 2)
INSERT [dbo].[ProviderOffers] ([Purchase_Key], [Date], [Provider_Id]) VALUES (17, N'21/03/2019 18:47:21', 1)
INSERT [dbo].[ProviderOffers] ([Purchase_Key], [Date], [Provider_Id]) VALUES (18, N'15/03/2019 19:17:52', 1)
SET IDENTITY_INSERT [dbo].[ProviderOffers] OFF
SET IDENTITY_INSERT [dbo].[ProviderOffers_Products] ON 

INSERT [dbo].[ProviderOffers_Products] ([Purchase_Product_Key], [Product_Key], [Count], [Price], [Purchase_Key]) VALUES (1, 1, 2, CAST(100 AS Decimal(18, 0)), 12)
INSERT [dbo].[ProviderOffers_Products] ([Purchase_Product_Key], [Product_Key], [Count], [Price], [Purchase_Key]) VALUES (2, 1, 1000, CAST(100 AS Decimal(18, 0)), 13)
INSERT [dbo].[ProviderOffers_Products] ([Purchase_Product_Key], [Product_Key], [Count], [Price], [Purchase_Key]) VALUES (3, 1, 5, CAST(100 AS Decimal(18, 0)), 14)
INSERT [dbo].[ProviderOffers_Products] ([Purchase_Product_Key], [Product_Key], [Count], [Price], [Purchase_Key]) VALUES (4, 7, 1, CAST(100 AS Decimal(18, 0)), 14)
INSERT [dbo].[ProviderOffers_Products] ([Purchase_Product_Key], [Product_Key], [Count], [Price], [Purchase_Key]) VALUES (5, 31, 1, CAST(100 AS Decimal(18, 0)), 14)
INSERT [dbo].[ProviderOffers_Products] ([Purchase_Product_Key], [Product_Key], [Count], [Price], [Purchase_Key]) VALUES (6, 40, 1, CAST(100 AS Decimal(18, 0)), 14)
INSERT [dbo].[ProviderOffers_Products] ([Purchase_Product_Key], [Product_Key], [Count], [Price], [Purchase_Key]) VALUES (7, 127, 1, CAST(100 AS Decimal(18, 0)), 14)
INSERT [dbo].[ProviderOffers_Products] ([Purchase_Product_Key], [Product_Key], [Count], [Price], [Purchase_Key]) VALUES (8, 108, 1, CAST(100 AS Decimal(18, 0)), 14)
INSERT [dbo].[ProviderOffers_Products] ([Purchase_Product_Key], [Product_Key], [Count], [Price], [Purchase_Key]) VALUES (9, 141, 1, CAST(100 AS Decimal(18, 0)), 15)
INSERT [dbo].[ProviderOffers_Products] ([Purchase_Product_Key], [Product_Key], [Count], [Price], [Purchase_Key]) VALUES (10, 198, 1, CAST(100 AS Decimal(18, 0)), 16)
INSERT [dbo].[ProviderOffers_Products] ([Purchase_Product_Key], [Product_Key], [Count], [Price], [Purchase_Key]) VALUES (11, 5, 1, CAST(100 AS Decimal(18, 0)), 17)
INSERT [dbo].[ProviderOffers_Products] ([Purchase_Product_Key], [Product_Key], [Count], [Price], [Purchase_Key]) VALUES (12, 41, 1, CAST(100 AS Decimal(18, 0)), 18)
INSERT [dbo].[ProviderOffers_Products] ([Purchase_Product_Key], [Product_Key], [Count], [Price], [Purchase_Key]) VALUES (13, 137, 6, CAST(100 AS Decimal(18, 0)), 18)
SET IDENTITY_INSERT [dbo].[ProviderOffers_Products] OFF
SET IDENTITY_INSERT [dbo].[Providers] ON 

INSERT [dbo].[Providers] ([Id], [Name], [Phone], [ExtraData]) VALUES (1, N'Яка', NULL, NULL)
INSERT [dbo].[Providers] ([Id], [Name], [Phone], [ExtraData]) VALUES (2, N'Дима Потапенко', NULL, NULL)
INSERT [dbo].[Providers] ([Id], [Name], [Phone], [ExtraData]) VALUES (3, N'Трачук', NULL, NULL)
INSERT [dbo].[Providers] ([Id], [Name], [Phone], [ExtraData]) VALUES (4, N'Меком', NULL, NULL)
INSERT [dbo].[Providers] ([Id], [Name], [Phone], [ExtraData]) VALUES (5, N'Медок', NULL, NULL)
INSERT [dbo].[Providers] ([Id], [Name], [Phone], [ExtraData]) VALUES (6, N'Медова соната', NULL, NULL)
INSERT [dbo].[Providers] ([Id], [Name], [Phone], [ExtraData]) VALUES (7, N'Мед Бесарабии', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Providers] OFF
SET IDENTITY_INSERT [dbo].[Sale_Products] ON 

INSERT [dbo].[Sale_Products] ([Sale_Product_Key], [Product_Key], [Count], [Price], [Sale_Key]) VALUES (1, 2, 1, CAST(80 AS Decimal(18, 0)), 7)
INSERT [dbo].[Sale_Products] ([Sale_Product_Key], [Product_Key], [Count], [Price], [Sale_Key]) VALUES (2, 22, 1, CAST(80 AS Decimal(18, 0)), 8)
INSERT [dbo].[Sale_Products] ([Sale_Product_Key], [Product_Key], [Count], [Price], [Sale_Key]) VALUES (3, 25, 1, CAST(80 AS Decimal(18, 0)), 8)
INSERT [dbo].[Sale_Products] ([Sale_Product_Key], [Product_Key], [Count], [Price], [Sale_Key]) VALUES (4, 19, 1, CAST(85 AS Decimal(18, 0)), 9)
INSERT [dbo].[Sale_Products] ([Sale_Product_Key], [Product_Key], [Count], [Price], [Sale_Key]) VALUES (10005, 11, 1, CAST(85 AS Decimal(18, 0)), 10010)
SET IDENTITY_INSERT [dbo].[Sale_Products] OFF
SET IDENTITY_INSERT [dbo].[Sales] ON 

INSERT [dbo].[Sales] ([Sale_Key], [Date_of_Sale], [Client_Id]) VALUES (1, N'Jan  1 2000 12:00AM', 1)
INSERT [dbo].[Sales] ([Sale_Key], [Date_of_Sale], [Client_Id]) VALUES (6, N'26.02.2017 1:30:25', 1)
INSERT [dbo].[Sales] ([Sale_Key], [Date_of_Sale], [Client_Id]) VALUES (7, N'26.02.2017 1:31:44', 2)
INSERT [dbo].[Sales] ([Sale_Key], [Date_of_Sale], [Client_Id]) VALUES (8, N'26.02.2017 1:31:52', 2)
INSERT [dbo].[Sales] ([Sale_Key], [Date_of_Sale], [Client_Id]) VALUES (9, N'10/11/2018 17:34:23', 1)
INSERT [dbo].[Sales] ([Sale_Key], [Date_of_Sale], [Client_Id]) VALUES (10009, N'10/11/2018 17:39:42', 1)
INSERT [dbo].[Sales] ([Sale_Key], [Date_of_Sale], [Client_Id]) VALUES (10010, N'09/03/2019 19:18:39', 1)
SET IDENTITY_INSERT [dbo].[Sales] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Login], [Password]) VALUES (1, N'admin', N'admin')
INSERT [dbo].[Users] ([Id], [Login], [Password]) VALUES (2, N'user', N'user')
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_ToCategories] FOREIGN KEY([Category_ID])
REFERENCES [dbo].[Categories] ([Category_Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_ToCategories]
GO
ALTER TABLE [dbo].[ProviderOffers]  WITH NOCHECK ADD  CONSTRAINT [FK_ProviderOffers_ToTable] FOREIGN KEY([Provider_Id])
REFERENCES [dbo].[Providers] ([Id])
GO
ALTER TABLE [dbo].[ProviderOffers] CHECK CONSTRAINT [FK_ProviderOffers_ToTable]
GO
ALTER TABLE [dbo].[ProviderOffers_Products]  WITH CHECK ADD  CONSTRAINT [FK_ProviderOffers_Products_ToTable] FOREIGN KEY([Product_Key])
REFERENCES [dbo].[Products] ([Product_Key])
GO
ALTER TABLE [dbo].[ProviderOffers_Products] CHECK CONSTRAINT [FK_ProviderOffers_Products_ToTable]
GO
ALTER TABLE [dbo].[ProviderOffers_Products]  WITH CHECK ADD  CONSTRAINT [FK_ProviderOffers_Products_ToTable_1] FOREIGN KEY([Purchase_Key])
REFERENCES [dbo].[ProviderOffers] ([Purchase_Key])
GO
ALTER TABLE [dbo].[ProviderOffers_Products] CHECK CONSTRAINT [FK_ProviderOffers_Products_ToTable_1]
GO
ALTER TABLE [dbo].[Sale_Products]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Products_ToTable] FOREIGN KEY([Product_Key])
REFERENCES [dbo].[Products] ([Product_Key])
GO
ALTER TABLE [dbo].[Sale_Products] CHECK CONSTRAINT [FK_Sale_Products_ToTable]
GO
ALTER TABLE [dbo].[Sale_Products]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Products_ToTable_1] FOREIGN KEY([Sale_Key])
REFERENCES [dbo].[Sales] ([Sale_Key])
GO
ALTER TABLE [dbo].[Sale_Products] CHECK CONSTRAINT [FK_Sale_Products_ToTable_1]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_ToTable] FOREIGN KEY([Client_Id])
REFERENCES [dbo].[Clients] ([Id])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_ToTable]
GO
USE [master]
GO
ALTER DATABASE [main_database] SET  READ_WRITE 
GO
