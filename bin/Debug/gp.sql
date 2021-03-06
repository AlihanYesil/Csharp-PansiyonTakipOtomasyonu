USE [GP]
GO
/****** Object:  Table [dbo].[MusteriBilgileri]    Script Date: 18.05.2022 17:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriBilgileri](
	[MusteriId] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](max) NULL,
	[Tc_no] [nvarchar](50) NULL,
	[Tel_no] [nvarchar](50) NULL,
	[Oda_no] [nvarchar](50) NULL,
	[Ucret] [int] NULL,
	[Giris_tarih] [date] NULL,
	[Cikis_tarih] [date] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oda100]    Script Date: 18.05.2022 17:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oda100](
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oda101]    Script Date: 18.05.2022 17:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oda101](
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oda102]    Script Date: 18.05.2022 17:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oda102](
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oda103]    Script Date: 18.05.2022 17:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oda103](
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oda104]    Script Date: 18.05.2022 17:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oda104](
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oda105]    Script Date: 18.05.2022 17:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oda105](
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oda106]    Script Date: 18.05.2022 17:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oda106](
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oda107]    Script Date: 18.05.2022 17:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oda107](
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oda108]    Script Date: 18.05.2022 17:01:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oda108](
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL
) ON [PRIMARY]
GO
