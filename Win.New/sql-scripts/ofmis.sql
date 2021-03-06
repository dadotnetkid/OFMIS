USE [master]
GO
/****** Object:  Database [OFMIS]    Script Date: 4/1/2020 8:16:02 AM ******/
CREATE DATABASE [OFMIS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OFMIS', FILENAME = N'C:\Program Files\Microsoft SQL Server\OFMIS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OFMIS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\OFMIS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [OFMIS] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OFMIS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OFMIS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OFMIS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OFMIS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OFMIS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OFMIS] SET ARITHABORT OFF 
GO
ALTER DATABASE [OFMIS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OFMIS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OFMIS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OFMIS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OFMIS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OFMIS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OFMIS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OFMIS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OFMIS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OFMIS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OFMIS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OFMIS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OFMIS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OFMIS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OFMIS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OFMIS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OFMIS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OFMIS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OFMIS] SET  MULTI_USER 
GO
ALTER DATABASE [OFMIS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OFMIS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OFMIS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OFMIS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OFMIS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OFMIS] SET QUERY_STORE = OFF
GO
USE [OFMIS]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [OFMIS]
GO
/****** Object:  Table [dbo].[Actions]    Script Date: 4/1/2020 8:16:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Action] [nvarchar](255) NULL,
 CONSTRAINT [PK_Actions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Allotments]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Allotments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AppropriationId] [int] NULL,
	[AllotmentDate] [datetime2](7) NULL,
	[AllotmentAmount] [money] NULL,
	[Remarks] [nvarchar](max) NULL,
	[DateCreated] [datetime2](7) NULL,
	[CreatedB] [nvarchar](128) NULL,
 CONSTRAINT [PK_Allotments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appropriations]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appropriations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AccountCode] [nvarchar](128) NULL,
	[AccountCodeText] [nvarchar](128) NULL,
	[FundType] [nvarchar](50) NULL,
	[AccountName] [nvarchar](128) NULL,
	[Appropriation] [money] NULL,
	[Year] [int] NULL,
	[DateCreated] [datetime2](7) NULL,
	[Createdby] [nvarchar](128) NULL,
 CONSTRAINT [PK_Appropriations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Category] [nvarchar](128) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DefaultSettings]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DefaultSettings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Year] [int] NULL,
	[PG] [nvarchar](max) NULL,
	[PGPos] [nvarchar](max) NULL,
	[PA] [nvarchar](max) NULL,
	[PAPos] [nvarchar](max) NULL,
	[PBO] [nvarchar](max) NULL,
	[PBOPos] [nvarchar](max) NULL,
	[PT] [nvarchar](max) NULL,
	[PTPos] [nvarchar](max) NULL,
	[PAccountant] [nvarchar](max) NULL,
	[PAccountantPos] [nvarchar](max) NULL,
	[PGSO] [nvarchar](max) NULL,
	[PGSOPosition] [nvarchar](max) NULL,
	[Department] [nvarchar](max) NULL,
	[ChiefOfOffice] [nvarchar](max) NULL,
	[ChiefOfOfficePos] [nvarchar](max) NULL,
	[ResponsibilityCenter] [nvarchar](max) NULL,
	[ResponsibilityCenterCode] [nvarchar](max) NULL,
	[OfficeId] [nvarchar](max) NULL,
 CONSTRAINT [PK_DefaultSettings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](128) NULL,
	[MiddleName] [nvarchar](128) NULL,
	[LastName] [nvarchar](128) NULL,
	[OfficeId] [int] NULL,
	[Position] [nvarchar](128) NULL,
	[OfcAcr] [nvarchar](128) NULL,
	[Status] [nvarchar](128) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FundTypes]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FundTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FundType] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_FundTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Category] [nvarchar](128) NULL,
	[Item] [nvarchar](255) NULL,
	[UOM] [nvarchar](50) NULL,
	[Cost] [money] NULL,
	[DateCreated] [datetime2](7) NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](max) NULL,
	[OldValues] [nvarchar](max) NULL,
	[NewValues] [nvarchar](max) NULL,
	[Action] [nvarchar](max) NULL,
	[DateCreated] [datetime] NULL,
	[CreatedBy] [nvarchar](128) NULL,
 CONSTRAINT [PK_Logs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Obligations]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Obligations](
	[Id] [int] NOT NULL,
	[Date] [datetime2](0) NULL,
	[ControlNo] [nvarchar](100) NULL,
	[BudgetControlNo] [nvarchar](100) NULL,
	[PayeeId] [int] NULL,
	[PayeeOffice] [nvarchar](255) NULL,
	[PayeeAddress] [nvarchar](255) NULL,
	[Chief] [nvarchar](100) NULL,
	[ChiefPosition] [nvarchar](255) NULL,
	[PBOPos] [nvarchar](100) NULL,
	[PBO] [nvarchar](100) NULL,
	[Closed] [bit] NULL,
	[Description] [nvarchar](255) NULL,
	[DVParticular] [nvarchar](max) NULL,
	[DVApprovedBy] [nvarchar](100) NULL,
	[DVApprovedByPosition] [nvarchar](100) NULL,
	[DVNote] [nvarchar](255) NULL,
	[Status] [nvarchar](100) NULL,
	[DateClosed] [datetime2](0) NULL,
	[Earmarked] [bit] NULL,
	[PRNo] [int] NULL,
	[SSMA_TimeStamp] [timestamp] NOT NULL,
	[Amount] [money] NOT NULL,
	[Year] [int] NULL,
 CONSTRAINT [Obligations$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Offices]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Offices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BoxNo] [int] NULL,
	[OffcAcr] [nvarchar](50) NULL,
	[OfficeName] [nvarchar](128) NULL,
	[Chief] [nvarchar](50) NULL,
	[TelNo] [nvarchar](50) NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[DateCreated] [datetime] NULL,
 CONSTRAINT [PK_Offices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDetails]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AppropriationId] [int] NULL,
	[ObligationId] [int] NULL,
	[Particulars] [nvarchar](max) NULL,
	[Amount] [money] NULL,
 CONSTRAINT [PK_ORDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payees]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NULL,
	[Office] [nvarchar](128) NULL,
	[Address] [nvarchar](128) NULL,
	[Note] [nvarchar](128) NULL,
 CONSTRAINT [PK_Payees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PODetails]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PODetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[POId] [int] NOT NULL,
	[ItemNo] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
	[Item] [nvarchar](255) NOT NULL,
	[UOM] [nvarchar](50) NOT NULL,
	[Cost] [money] NOT NULL,
	[TotalAmount] [money] NOT NULL,
 CONSTRAINT [PK_PODetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PQDetails]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PQDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PQId] [int] NULL,
	[ItemNo] [int] NULL,
	[Quantity] [int] NULL,
	[Category] [nvarchar](50) NULL,
	[Item] [nvarchar](255) NULL,
	[UOM] [nvarchar](50) NULL,
	[Cost] [money] NULL,
	[TotalAmount] [money] NULL,
 CONSTRAINT [PK_PQDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRDetails]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PRId] [int] NULL,
	[ItemNo] [int] NULL,
	[Quantity] [int] NULL,
	[Category] [nvarchar](50) NULL,
	[Item] [nvarchar](255) NULL,
	[UOM] [nvarchar](50) NULL,
	[Cost] [money] NULL,
	[TotalAmount] [money] NULL,
	[TableName] [nvarchar](128) NULL,
 CONSTRAINT [PK_PRDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PriceQuotations]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PriceQuotations](
	[Id] [int] NOT NULL,
	[PRId] [int] NULL,
	[Date] [datetime2](7) NULL,
	[ControlNo] [nvarchar](128) NULL,
	[Description] [nvarchar](max) NULL,
	[Purpose] [nvarchar](max) NULL,
	[TotalAmount] [money] NULL,
	[PGSOfficer] [nvarchar](max) NULL,
	[Position] [nvarchar](max) NULL,
 CONSTRAINT [PK_PurchaseQuotations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provinces]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provinces](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[SortOrder] [nchar](10) NULL,
 CONSTRAINT [PK_Provinces] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrders]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrders](
	[Id] [int] NOT NULL,
	[PRId] [int] NULL,
	[Date] [datetime2](7) NULL,
	[ControlNo] [nvarchar](128) NULL,
	[Description] [nvarchar](max) NULL,
	[Purpose] [nvarchar](max) NULL,
	[TotalAmount] [money] NULL,
	[PGSOfficer] [nvarchar](max) NULL,
	[Position] [nvarchar](max) NULL,
	[Supplier] [nvarchar](max) NULL,
	[SupplierAddress] [nvarchar](max) NULL,
	[PONo] [nvarchar](128) NULL,
	[PODate] [datetime2](7) NULL,
	[ModeOfProcurement] [nvarchar](128) NULL,
	[PRNo] [nvarchar](128) NULL,
	[PlaceOfDelivery] [nvarchar](128) NULL,
	[DateOfDelivery] [datetime2](7) NULL,
	[DeliveryTerm] [nvarchar](128) NULL,
	[PaymentTerm] [nvarchar](128) NULL,
 CONSTRAINT [PK_PurchaseOrders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseRequests]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseRequests](
	[Id] [int] NOT NULL,
	[AppropriationId] [int] NULL,
	[Date] [datetime2](7) NULL,
	[ControlNo] [nvarchar](128) NULL,
	[Description] [nvarchar](max) NULL,
	[Purpose] [nvarchar](max) NULL,
	[TotalAmount] [money] NULL,
	[TableName] [nvarchar](128) NULL,
 CONSTRAINT [PK_PurchaseRequests] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReAlignments]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReAlignments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NULL,
	[SourceAppropriationId] [int] NULL,
	[TargetAppropriationId] [int] NULL,
	[Amount] [money] NULL,
	[Remarks] [nvarchar](max) NULL,
	[DateCreated] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](128) NULL,
 CONSTRAINT [PK_ReAlignments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Signatories]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Signatories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Person] [nvarchar](max) NULL,
	[Position] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
	[Year] [int] NULL,
 CONSTRAINT [PK_Signatories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[ContactNumber] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[FaxNumber] [nvarchar](max) NULL,
	[CellNumber] [nvarchar](max) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Towns]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towns](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[ProvinceId] [int] NULL,
	[SortOrder] [int] NULL,
 CONSTRAINT [PK_Towns] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserClaims]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLogins]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_UserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 4/1/2020 8:16:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRolesInActions]    Script Date: 4/1/2020 8:16:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRolesInActions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](128) NULL,
	[Action] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserRolesInActions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 4/1/2020 8:16:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](128) NULL,
	[EmailConfirmed] [bit] NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](25) NULL,
	[PhoneNumberConfirmed] [bit] NULL,
	[TwoFactorEnabled] [bit] NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NULL,
	[AccessFailedCount] [int] NULL,
	[UserName] [nvarchar](50) NULL,
	[LastUpdatedBy] [nvarchar](150) NULL,
	[LastUpdated] [datetime] NULL,
	[CreatedDate] [datetime] NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[MiddleName] [nvarchar](50) NULL,
	[CivilStatus] [nvarchar](12) NULL,
	[Gender] [nvarchar](6) NULL,
	[BirthDate] [datetime] NULL,
	[AddressLine2] [nvarchar](500) NULL,
	[AddressLine1] [nvarchar](500) NULL,
	[TownCity] [int] NULL,
	[Cellular] [nvarchar](25) NULL,
	[Height] [decimal](5, 2) NULL,
	[Weight] [decimal](5, 2) NULL,
	[Religion] [nvarchar](50) NULL,
	[Citizenship] [nvarchar](50) NULL,
	[Languages] [nvarchar](max) NULL,
	[Position] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersInRoles]    Script Date: 4/1/2020 8:16:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersInRoles](
	[UserRoles_Id] [nvarchar](128) NOT NULL,
	[Users_Id] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_UsersInRoles] PRIMARY KEY CLUSTERED 
(
	[UserRoles_Id] ASC,
	[Users_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Years]    Script Date: 4/1/2020 8:16:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Years](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Year] [int] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Year] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Appropriations] ON 

INSERT [dbo].[Appropriations] ([Id], [AccountCode], [AccountCodeText], [FundType], [AccountName], [Appropriation], [Year], [DateCreated], [Createdby]) VALUES (5, N'50101010', N'5-01-01-010', N'PS', N'Salaries and Wages - Regular Pay', 18363360.0000, 2018, NULL, NULL)
INSERT [dbo].[Appropriations] ([Id], [AccountCode], [AccountCodeText], [FundType], [AccountName], [Appropriation], [Year], [DateCreated], [Createdby]) VALUES (7, N'50101020', N'5-01-01-020', N'PS', N'Salaries and Wages - Casual', 381831.9300, 2018, NULL, NULL)
INSERT [dbo].[Appropriations] ([Id], [AccountCode], [AccountCodeText], [FundType], [AccountName], [Appropriation], [Year], [DateCreated], [Createdby]) VALUES (8, N'50102010', N'5-01-02-010', N'PS', N'PERA', 96000.0000, 2018, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Appropriations] OFF
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Category]) VALUES (1, N'Janitorial Supplies')
INSERT [dbo].[Categories] ([Id], [Category]) VALUES (2, N'Office Supplies')
INSERT [dbo].[Categories] ([Id], [Category]) VALUES (3, N'Medical Supplies')
INSERT [dbo].[Categories] ([Id], [Category]) VALUES (4, N'Medicine')
INSERT [dbo].[Categories] ([Id], [Category]) VALUES (5, N'Office Equipment')
INSERT [dbo].[Categories] ([Id], [Category]) VALUES (6, N'Computer Supplies')
INSERT [dbo].[Categories] ([Id], [Category]) VALUES (7, N'Automotive Supplies')
INSERT [dbo].[Categories] ([Id], [Category]) VALUES (8, N'IT Equipment')
INSERT [dbo].[Categories] ([Id], [Category]) VALUES (9, N'Meals and Snacks')
INSERT [dbo].[Categories] ([Id], [Category]) VALUES (10, N'Electrical Supplies')
INSERT [dbo].[Categories] ([Id], [Category]) VALUES (11, N'Office Devices')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[DefaultSettings] ON 

INSERT [dbo].[DefaultSettings] ([Id], [Year], [PG], [PGPos], [PA], [PAPos], [PBO], [PBOPos], [PT], [PTPos], [PAccountant], [PAccountantPos], [PGSO], [PGSOPosition], [Department], [ChiefOfOffice], [ChiefOfOfficePos], [ResponsibilityCenter], [ResponsibilityCenterCode], [OfficeId]) VALUES (3, 2018, N'EMERLEE JANE I. GALANTA', N'Exceutive Assistant I', N'MAYBELLE DUMLAO SEVILLENA', N'Provincial Administrator', N'VIRGINIA N. IGLESIAS', N'Provincial Budget Officer', N'RHODA S. MORENO', N'Provincial Accountant', N'YUNISA D. PATRICIO, CPA', N'Provincial Accountant', N'ATTY. VOLTAIRE B. GARCIA', N'Chairperson, BAC-Goods', N'GOVERNOR''S OFFICE', N'SHERLYN B. FERNANDEZ', N'Activing Chief, PITD, GO', N'PITD', N'1011', N'PITD')
SET IDENTITY_INSERT [dbo].[DefaultSettings] OFF
SET IDENTITY_INSERT [dbo].[FundTypes] ON 

INSERT [dbo].[FundTypes] ([Id], [FundType], [Description]) VALUES (1, N'PS', N'Personal Services')
INSERT [dbo].[FundTypes] ([Id], [FundType], [Description]) VALUES (2, N'MOOE', N'Maintenance and Other Operating Expenses')
INSERT [dbo].[FundTypes] ([Id], [FundType], [Description]) VALUES (3, N'CO', N'Capital Outlay')
SET IDENTITY_INSERT [dbo].[FundTypes] OFF
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (3, N'Office Equipment', N'AIRPOT, electric, with dispenser, 3.8L min.', N'unit', 1284.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (4, N'Office Equipment', N'CALCULATOR, heavy duty, 12 digits capacit, 2-color print', N'unit', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (5, N'Office Equipment', N'CALCUATOR, compact, electronic, 12 digists cap', N'unit', 137.9000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (7, N'Office Equipment', N'CHAIR, monobloc, without armrest, color white with backrest', N'piece', 307.4000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (11, N'Office Equipment', N'MULTIMEDIA PROJECTOR, 4000 min ANSI Lumens', N'unit', 18988.3200, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (12, N'Office Equipment', N'PRINTER, impact dot matrix, 24-pins, 136 colums bi-directional with logic seeking print direction', N'unit', 33768.4200, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (13, N'Office Equipment', N'PRINTER, impact dot matrix, 9 pins, 80 columns bi-directional with logic seeking print direction', N'unit', 8155.4300, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (14, N'Office Equipment', N'BINDING AND PUNCHING MACHINE, 2 hand lever syste, 34cm or 13"(24holes) punching width adjustable', N'unit', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (15, N'Office Equipment', N'ELECTRONIC TIME RECORDER/BUNDY CLOCK, digital, 2 color ribbon, compact size but not large clock face', N'unit', 3411.2000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (16, N'Office Supplies', N'PAPER, copy, for plain paper copier, 216mm x 330mm (8-1/2"X13") Legal', N'ream', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (17, N'Office Supplies', N'PAPER, multicopy, 80gsm, 216mm x 330mm (8-1"x 13") legal, for laser printer', N'ream', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (18, N'Computer Supplies', N'COMPUTER CONTINUOUS FORMS, 1ply 280mm x 241mm (11"x 9-1/2"), plain, white band, 70gsm', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (19, N'Computer Supplies', N'COMPUTER CONTINUOUS FORMS, 1ply, 280mm x 378mm, (11"x 14-7/8"), palin, white bond, 70 gsm', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (20, N'Computer Supplies', N'CONTINUOUS FORMS, carbonless, 2ply, 280m x 241mm (11" x 9-1/2"), plain, white bond, 70 gsm', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (21, N'Computer Supplies', N'CONTINUOUS FORMS, carbonless, 2ply, 280mm x 378mm (11"x14-7/8"), plain, white bond or equivalent, 55gsm', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (22, N'Computer Supplies', N'CONTINUOUS FORMS, carbonless, 2ply, 280mm x 378mm (11"x 9-1/2"), plain, white boand, 55-50-55 gsm', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (23, N'Computer Supplies', N'CONTINUOUS FORMS, carbonless, 3ply, 280mm x 378mm (11"x 14-7/8") plain, white bond or equivalent, 55-50-55 gsm', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (24, N'Computer Supplies', N'COMPUTER CONTINUOUS FORMS, 4ply, 280mm x 241mm (11"x9-1/2"), plain, GSP bond, 55 gsm', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (25, N'Computer Supplies', N'COMPACT DISC RECORDABLE, minimun of 700MB, 1x52x min speed, individually packed in clear or translucent slim', N'piece', 10.4500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (26, N'Computer Supplies', N'COMPACT DISC REWRITABLE, 700MB minimum capacity, 80 minutes recording time', N'piece', 17.9500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (27, N'Computer Supplies', N'DVD RECORDABLE, 16x speed, 4.7GB capacity, 120 minutes recording time', N'piece', 11.5500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (28, N'Computer Supplies', N'DVD REWIRTABLE, 4x speed, 4.7GB capacity, 120 min recording time', N'piece', 21.7500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (31, N'Computer Supplies', N'FLASH DRIVE, 16GB capacity, USB  plug-n-play', N'piece', 283.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (32, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. 54645A(HP45), original,black', N'cart', 1348.2000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (33, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. C6615A(HP15), original, black', N'cart', 1273.3000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (34, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. C1823A (HP23), original, tri chamber colour', N'cart', 1658.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (35, N'Computer Supplies', N'INK CARTRDIGE, Hewlett Packard Part No. C6625A(HP17), original, colored', N'cart', 1385.6500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (36, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. C6578A/D(HP 78), original, colored', N'cart', 1498.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (37, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. C8727A, original, black', N'cart', 823.9000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (38, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. Q8893AA(C8728AA).(HP28), colored', N'cart', 941.6000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (39, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. C6656A(HP 56), original Black, for HP All-in-one-Officejet 6110', N'cart', 898.8000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (40, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. C6656A(HP 57), original, colored for HP All-in-one officejet 6110', N'cart', 1508.7000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (41, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. C9351A (HP 21) black', N'cart', 645.2500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (42, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. C9352A (HP 22), tri-color', N'cart', 743.6500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (43, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. C8765WA (HP 94) original, black', N'cart', 909.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (44, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. C8767WA (HP 96) black', N'cart', 1358.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (45, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard part No. C9363WA (HP 97), tricolor', N'cart', 1524.7500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (46, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. 60(CC640WA), black', N'cart', 663.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (47, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. 60(CC643WA), tricolor', N'cart', 781.9000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (48, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. CB314A(HP 900),black', N'cart', 268.6000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (49, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. CB315A(HP 900), tricolor', N'cart', 363.8000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (50, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. CD887AA(HP 703), black', N'cart', 346.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (51, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. CD888AA(HP 703), tricolor', N'cart', 346.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (52, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. CC660AA(HP 702), black', N'cart', 1032.5500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (53, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. CN692AA(HP 704), black', N'cart', 350.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (54, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. CN693AA(HP 704), tricolor', N'cart', 346.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (55, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. CD972AA (HP920XL), Cyan', N'cart', 654.1300, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (56, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. CD973AA (HP 920XL), Magenta', N'cart', 654.1300, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (57, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. CD974AA(HP 920XL) Yellow', N'cart', 654.1300, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (58, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. CD975AA (HP 920XL), black', N'cart', 1292.0400, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (59, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. CH561WA (HP 61), black', N'cart', 669.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (60, N'Computer Supplies', N'NK CARTRIDGE, Hewlett Packard Part No. CH562WA (HP 61), colored', N'cart', 842.7000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (61, N'Computer Supplies', N'NK CARTRIDGE, Hewlett Packard Part No. CZ107AA, Black', N'cart', 356.3500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (62, N'Computer Supplies', N'NK CARTRIDGE, Hewlett Packard Part No. CZ108AA, Tricolor', N'cart', 371.3000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (63, N'Computer Supplies', N'NK CARTRIDGE, Lexmark Part No. 27, colored, original, for Lexmark X515', N'cart', 1230.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (64, N'Computer Supplies', N'INK CARTRIDGE, Lexmark Part No. 17, black original, for Lexmark X515', N'cart', 1032.5500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (65, N'Computer Supplies', N'INK CARTRIDGE, Epson Part No. C13T038190(TO38), black,', N'cart', 506.1500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (66, N'Computer Supplies', N'INK CARTRIDGE, Epson Part No. C13T039090(TO39), colored', N'cart', 792.9000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (67, N'Computer Supplies', N'INK CARTRIDGE, Epson Part No. C13T105190(73N), black', N'cart', 445.1500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (68, N'Computer Supplies', N'INK CARTRIDGE, Epson Part No. C13T105390(73N), Magenta', N'cart', 445.1500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (69, N'Computer Supplies', N'INK CARTRIDGE, Epson Part No. C13T105490(73N), Yellow', N'cart', 445.1500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (71, N'Computer Supplies', N'INK CARTRIDGE, Epson Part No. C13T664100(T6641), black', N'cart', 259.7000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (72, N'Computer Supplies', N'INK CARTRIDGE, Epson Part No. C13T664100(T6642), Cyan', N'cart', 259.7000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (73, N'Computer Supplies', N'INK CARTRIDGE, Epson Part No. C13T664100(T6643), Magenta', N'cart', 259.7000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (74, N'Computer Supplies', N'INK CARTRIDGE, Epson Part No. C13T664100(T6644), Yellow', N'cart', 259.7000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (75, N'Computer Supplies', N'INK CARTRIDGE, Brother Part No. LC67HYBK, black', N'cart', 1647.8000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (76, N'Computer Supplies', N'INK CARTRIDGE, Brother Part No. LC67HY-C, Cyan', N'cart', 888.1000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (77, N'Computer Supplies', N'INK CARTRIDGE, Brother Part No. LC67HY-M, Magenta', N'cart', 888.1000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (78, N'Computer Supplies', N'INK CARTRIDGE, Brother Part No. LC67HY-Y, yellow', N'cart', 888.1000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (79, N'Computer Supplies', N'INK CARTRIDGE, Brother Part No. LC40BK, Black', N'cart', 663.4000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (80, N'Computer Supplies', N'INK CARTRIDGE, Brother Part No. LC40M, Magenta', N'cart', 374.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (81, N'Computer Supplies', N'INK CARTRIDGE, Brother Part No. LC38B, Black', N'cart', 706.2000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (82, N'Computer Supplies', N'INK CARTRIDGE, Brother Part No. LC38C, Cyan', N'cart', 465.4500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (83, N'Computer Supplies', N'INK CARTRIDGE, Brother Part No. LC38M, Magenta', N'cart', 465.4500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (84, N'Computer Supplies', N'INK CARTRIDGE, Brother Part No. LC38Y, Yellow', N'cart', 465.4500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (85, N'Computer Supplies', N'INK CARTRIDGE, Brother Part No. LC39BK, black', N'cart', 738.3000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (86, N'Computer Supplies', N'INK CARTRIDGE, Brother Part No. LC39Y yellow', N'cart', 481.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (87, N'Computer Supplies', N'INK CARTRIDGE, Brother Part No. LC39C, cyan', N'cart', 481.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (88, N'Computer Supplies', N'INK CARTRIDGE, Brother Part No. LC39M, Magenta', N'cart', 481.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (89, N'Computer Supplies', N'INK CARTRIDGE, Canon Part No. PG-810, black', N'cart', 795.6000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (90, N'Computer Supplies', N'INK CARTRIDGE, Canon Part No. CL-811, colored', N'cart', 1050.2000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (91, N'Computer Supplies', N'INK CARTRIDGE, Canon Part No. PGI-725, black', N'cart', 583.1500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (92, N'Computer Supplies', N'INK CARTRIDGE, Canon Part No. CLI-726, black', N'cart', 551.0500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (93, N'Computer Supplies', N'INK CARTRIDGE, Canon Part No. CLI-726,Cyan', N'cart', 551.0500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (94, N'Computer Supplies', N'INK CARTRIDGE, Canon Part No. CLI-726, Magenta', N'cart', 551.0500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (95, N'Computer Supplies', N'INK CARTRIDGE, Canon Part No. CLI-726, Yellow', N'cart', 551.0500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (96, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. C4092A, original, black', N'cart', 2820.5500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (97, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. C7115A, original', N'cart', 3379.1000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (98, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. Q2612A, original, black', N'cart', 3006.7000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (99, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. Q6511A, original, black', N'cart', 5326.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (100, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. Q5949A, original, black', N'cart', 3632.6500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (101, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. Q7553A, 53A original, black', N'cart', 4052.2600, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (102, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. CB435A, original, black', N'cart', 2915.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (103, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. CB436A, original, black', N'cart', 3067.7000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (104, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. CC364A, original, black', N'cart', 7169.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (105, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. CE255A, original, black', N'cart', 6927.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (106, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. CE505A, black', N'cart', 4161.5200, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (107, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. CE285A, original, black', N'cart', 3010.4000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (108, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. Part No. CE400A, original, black', N'cart', 6785.9500, NULL)
GO
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (109, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. CE401A, original, Cyan', N'cart', 9933.9000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (110, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. CE402A, original, yello', N'cart', 9933.9000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (111, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. CE403A, original, magenta', N'cart', 9933.9000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (112, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. CE278A(HP78), black original', N'cart', 3242.8700, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (113, N'Computer Supplies', N'TONER CARTRIDGE, Brother Part No. TN-2130', N'cart', 1929.2500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (114, N'Computer Supplies', N'TONER CARTRIDGE, Brother Part No. TN-2025', N'cart', 2630.1000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (115, N'Computer Supplies', N'TONER CARTRIDGE, Brother Part No. TN-2150', N'cart', 2942.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (116, N'Computer Supplies', N'TONER CARTRIDGE, Lexmark Part No. E360H11P', N'cart', 9130.3500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (117, N'Computer Supplies', N'RIBBON, RN8750, for Epson LX800/FX80', N'cart', 79.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (118, N'Computer Supplies', N'RIBBON, RN7754, for Epson LQ1000/1050+/1170 printer', N'cart', 133.7500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (119, N'Computer Supplies', N'RIBBON, RN SO 15083/SO 15086, for EPSON LQ 2170/2070 printer', N'cart', 745.8000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (120, N'Computer Supplies', N'RIBBON, for Epson FX-2190 printer, RN SO15327', N'cart', 344.5500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (121, N'Computer Supplies', N'RIBBON CARTRIDGE, for Fujitsu DL3850', N'cart', 462.8000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (122, N'Office Supplies', N'ACETATE, 0.075mm min(gauge#3)', N'roll', 755.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (123, N'Office Supplies', N'AIR FRESHENER, aerosol, 280ml', N'can', 87.8000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (124, N'Office Supplies', N'ALCHOHOL, ethyl, 68%-70%, scented, 500ml, colorless, liquid, fully miscible in water', N'bottle', 38.3500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (125, N'Office Supplies', N'CARBON FILM, plyethylene, black, 210mm x 297mm (A-4), 100 sheets per box', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (126, N'Office Supplies', N'CARBON FILM, plyethylene, black, 216mm x 330mm(8-1/2"x13"), 100 sheet per box', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (127, N'Office Supplies', N'CARBON FILM, polyethylene, black, 210mm x 297mm(A-f), 100 sheets per box', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (128, N'Office Supplies', N'CARBON FILM, polyethylene, black, 216mm x 330mm(8-1/2"x13"), 100 sheets per box', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (129, N'Office Supplies', N'CHALK, molded, white, dustless, 78mm min length, 100 pieces per box', N'box', 26.6500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (130, N'Office Supplies', N'CLIP, bulldog, all metal, 73mm min clamping, 0.47mm min, thickness of metal', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (133, N'Office Supplies', N'CLEARBOOK, A4 size, for 210mm x 297mm(A4 size) documents, refillable, plastic, 302mm(L) x 242mm(W)', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (134, N'Office Supplies', N'CLEARBOOK, legal size, for 216mm x 330mm(legal size) document, refillable, plastic', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (135, N'Office Supplies', N'COLUMNAR PAD, 14 cols, 50gsm, non-blot, lines and columns numbered, size:354mm x 430mm min', N'pad', 44.9500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (136, N'Office Supplies', N'COLUMNAR PAD, 16 columns, 50gsm min, non-blot, lines and colums numbered', N'pad', 44.9500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (137, N'Office Supplies', N'COLUMNAR PAD, 18 cols, 50gsm, non-blot, lines and numbered, size 354mm x 643mm min', N'pad', 67.4500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (138, N'Office Supplies', N'CORRECTION TAPE, disposable, usable length of 6 meters(min), 5mm width,0.02mm(min) thickness', N'bottle', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (139, N'Office Supplies', N'DATA FILE BOX, with closed ends and finger ring, 127mm x 299mm x 400mm(5"x9"x15-3/4")', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (140, N'Office Supplies', N'DATA FOLDER, 76mm x 229mm x381mm(3"x9"x15"), made of chipboard with thickness of 2.5mm(#20)', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (141, N'Office Supplies', N'ENVELOPE, documentary, for legal size document, kraft, 150 gsm, 0.22mm min thickness, 254mm x 381mm', N'piece', 2.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (142, N'Office Supplies', N'ENVELOPE, DOCUMENTARY, for A4 size document', N'box', 687.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (143, N'Office Supplies', N'ENVELOPE, expanding, kraftboard, for legal size doc, 0.22mm min thickness, 250mm x 380mm', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (144, N'Office Supplies', N'ENVELOPE, mailing, white, 70gsm, premium grade bond quality, 105mm x 241mm', N'box', 369.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (145, N'Office Supplies', N'ENVELOPE, mailing, white, with window, glassine/plastic window, PG bond quality, 70gsm', N'box', 430.2500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (146, N'Office Supplies', N'ENVELOPE, pay, kraft, 102mm x191mm(4"x7-1/2"), 500s/box', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (147, N'Office Supplies', N'ENVELOPE, expanding, plastic, 0.50mm thickness min, 260mm x 380mmm min size', N'piece', 32.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (148, N'Office Supplies', N'ERASER, felt, blackboard/whiteboard, 19mm min thickness of felt, 42mm x 122mm min', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (150, N'Office Supplies', N'FILE ORGANIZER, expanding, plastic, legal,assorted color', N'piece', 70.6700, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (151, N'Office Supplies', N'FOLDER, pressboard, 240mm x 370mm, 0.41mm thickness, 300gsm, paper board, color cream', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (152, N'Office Supplies', N'FOLDER, tagboard, for legal size documents, 0.342mm thickness, 250gsm min, made from foldcote, cupstock, carrier board', N'pack', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (153, N'Office Supplies', N'FOLDER, tagboard, for A4 size documents, 0.342mm min thickness, 250gsm min, made from foldcote', N'pack', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (154, N'Office Supplies', N'FOLDER, fancy, for legal size documents', N'bundle', 332.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (155, N'Office Supplies', N'FOLDER, fancy, for A4 size documents', N'bundle', 297.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (156, N'Office Supplies', N'FOLDER, L-type, plastic, for A4', N'pack', 174.5100, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (157, N'Office Supplies', N'FOLDER, L-type, plastic, for legal size documents', N'pack', 218.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (158, N'Office Supplies', N'GLUE, all purpose, 200 grams min.', N'jar', 50.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (159, N'Office Supplies', N'ILLUSTRATION BOARD, double face(black and white), 860gsm, 1.30mm thickness', N'piece', 36.1000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (160, N'Office Supplies', N'INDEX CARD, ruled both sides, 76mm x 127mm (3"x5"), bristol board, non-blot', N'pack', 52.7500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (161, N'Office Supplies', N'INDEX CARD, ruled both sides, 127mm x 203mm (5"x8"), bristol board, non-bleed, non-blot', N'pack', 143.4000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (162, N'Office Supplies', N'INDEX CARD BOX, chipboard, for 76mm x 127mm, thickness: 3.0mm min, outside dimension: 100mm x 110mm x 140mm min', N'box', 37.4500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (163, N'Office Supplies', N'INDEX CARD BOX, chipboard, for 127mm x 203mm, 3.0mm min thickness, 140mm x 150mm x 220mm min outside dimension', N'box', 56.7500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (164, N'Office Supplies', N'INDEX TAB, self-adhesive, transparent', N'box', 54.1000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (165, N'Office Supplies', N'LEAD, for mechanical pencil, 0.5mm, polymer type, 60mm min length, 190MPa min strength', N'tube', 7.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (166, N'Office Supplies', N'LOOSELEAF COVER, made of chipboard, for legal size documents,', N'bundle', 684.1100, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (167, N'Office Supplies', N'MAGAZINE FILE, medium size, made of chipboard, thickness: 3.0mm min, with open end, dimension: 110mm x 200mm x 240mm min', N'piece', 35.3500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (168, N'Office Supplies', N'MAGAZINE FILE, large, made of chipboard, 3.0mm min thickness, with open end', N'piece', 45.1000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (169, N'Office Supplies', N'MANILA PAPER, pale yellow to light brown color, 60gsm, thickness: 0.014mm min', N'sleeve', 25.3500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (170, N'Office Supplies', N'MAP PIN, round head, 9mm min length of pin, 9mm min head diameter, 1.12mm min diameter of pin assorted colors', N'box', 42.8000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (171, N'Office Supplies', N'MARKER, fluorescent, assorted cololrs, 3 colors/set', N'set', 45.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (172, N'Office Supplies', N'MARKING PEN, for whiteboard, black, felt tip, bullet type, non toxic, without unpleasant or offensive odor', N'piece', 12.6500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (173, N'Office Supplies', N'MARKING PEN, for whiteboard, blue, felt tip, bullet type, non toxic, without unpleasant or offensive odor', N'piece', 12.6500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (174, N'Office Supplies', N'MARKING PEN, for whiteboard, red, felt tip, bullet type, non-toxic, without unpleasant or offensive odor', N'piece', 12.6500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (175, N'Office Supplies', N'MARKING PEN, permanent, bullet type, black, felt tip, medium, without unpleasant or offensive odor', N'piece', 12.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (176, N'Office Supplies', N'MARKING PEN, permanent, bullet type, blue, felt tip, medium, without unpleasant or offensive odor', N'piece', 12.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (177, N'Office Supplies', N'MARKING PEN, permanent, bullet type, red, felt tip, medium, without unpleasant or offensive odor', N'piece', 12.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (178, N'Office Supplies', N'NOTEBOOK, stenographer, spiral, 40 leaves', N'piece', 13.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (179, N'Office Supplies', N'NOTE PAD, stick-on, (3" x 3") 100 sheets per pad', N'pad', 43.4400, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (180, N'Office Supplies', N'NOTE PAD, stick-on, (2" x 3"),100 sheets per pad', N'pad', 33.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (181, N'Office Supplies', N'OIL, for general purposes, lubricant, 120 ml per botthle, with no unpleasant odor', N'bottle', 38.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (182, N'Office Supplies', N'PAPER, copy, 70 gsm, 210mm x 297mm, for plain paper copier, 500 sheets per ream', N'ream', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (183, N'Office Supplies', N'PAPER, ruled pad, 216mm x 330mm, bond, 55gsm, 0.07mm min thickness, bond, 27mm min top margin', N'pad', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (185, N'Office Supplies', N'PAPER, thermal, 55gsm, 216mm x 30M-0.3m', N'roll', 49.7600, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (186, N'Office Supplies', N'PAPER, multicopy, 80gsm, 210mm x 297mm(A4), for laser printer, high-speed copier', N'ream', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (187, N'Office Supplies', N'FASTENER, for paper, metal, 70mm between prongs, non-corrosive metal, non sharp edges', N'box', 85.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (188, N'Office Supplies', N'PAPER, parchment, size: 210mm x 297mm, mullti-purpose', N'pack', 103.8800, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (189, N'Office Supplies', N'PAPER CLIP, vinyl/plastic coat, 48mm min length, jumbo, gem-pattern type, 0.95mm min wire diameter', N'box', 15.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (190, N'Office Supplies', N'PAPER CLIP, vinyle/plastic coat, 32mm min length, gem-pattern type, 0.79mm min wire diameter', N'box', 7.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (192, N'Office Supplies', N'PENCIL, mechanical, push-type, for 0.5mm lead, made of metal and plastic', N'piece', 23.5500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (193, N'Office Supplies', N'PUSH Pin, flat head type, 1.12mm min diameter of pin, 9mm min length of pin, assorted colors, 100 pieces per case', N'box', 19.6500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (195, N'Office Supplies', N'104', N'book', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (196, N'Office Supplies', N'RIBBON, for manual typewritter, nylon, black, universal spool 12.7mm-13mm width', N'spool', 16.6000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (197, N'Office Supplies', N'RING BINDER, 80 rings, plastic, 12.7mm x 1.12M (1/2" x 44"), assorted colors, ten pieces per bundle', N'bundle', 54.6000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (198, N'Office Supplies', N'RING BINDER, 80 rings, plastic, 25mm x 1.12M (1"x44"), assorted colors, ten pieces per bundle, 0.55 min thickness', N'bundle', 117.2000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (199, N'Office Supplies', N'RUBBER BAND, 70mm lay flat length (#18)', N'box', 112.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (200, N'Office Supplies', N'RULER, plastic, 450mm (18"), 38mm min width, flexible, transparent/clear, ruler scale', N'piece', 18.0200, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (201, N'Office Supplies', N'SIGN PEN, black, liquid/gel ink, 0.3mm needle tip, with non slip grip', N'piece', 40.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (202, N'Office Supplies', N'SIGN PEN, blue, liquid/gel ink, 0.5mm needle tip, with non slip grip', N'piece', 40.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (203, N'Office Supplies', N'SIGN PEN, red, liquid/ge ink, 0.35mm needle tip, with non slip grip', N'piece', 45.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (205, N'Office Supplies', N'STAMP PAD, felt, 60mm x 100mm', N'piece', 30.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (206, N'Office Supplies', N'STAPLE WIRE, standard, 26/6, 100 staples per strip, 5000 wires per box, made of steel wire coated with zinc', N'box', 20.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (207, N'Office Supplies', N'TAPE, paper, for adding machine, 57mm width, bond, 55gsm, 40m min length, 0.07mm min thickness', N'roll', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (208, N'Office Supplies', N'TAPE, masking, 24mm (1")width, 0.25mm max thickness, usable length of 50m', N'roll', 56.2500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (209, N'Office Supplies', N'TAPE, masking, 48mm (2") width, 0.25mm max thickness, usable length of 50m', N'roll', 108.7500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (210, N'Office Supplies', N'TAPE, transparent, 24mm(1") width, usable length of 50m, 0.043mm min thickness', N'roll', 15.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (211, N'Office Supplies', N'TAPE, transparent, 48mm(2") width, usable length of 50m, 0.043mm min thickness', N'roll', 25.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (212, N'Office Supplies', N'TAPE, packaging, 48mm  50m. Length', N'roll', 33.3700, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (213, N'Office Supplies', N'TIME CARD, for Amano bundy clock, black print, imported, tagboard thickness', N'bundle', 69.4500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (214, N'Office Supplies', N'TOILET TISSUE, 2ply sheets, 150 pulls, 100mm x 114mm, 12 rolls per plastic pack', N'pack', 87.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (215, N'Office Supplies', N'TWINE, plastic, one kilo per roll', N'roll', 60.0000, NULL)
GO
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (216, N'Office Supplies', N'WRAPPING PAPER, kraft, 65gsm,  50 sheets per pack', N'pack', 131.3200, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (217, N'Office Equipment', N'CUTTER BLADE, for heavy duty cutter', N'piece', 12.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (218, N'Office Equipment', N'CUTTER, for general purpose, plastic, molded body, heavy duty, with built-in blade', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (219, N'Office Equipment', N'PUNCHER, paper, heavy duty, with two-hole guide, diameter of hole: approxiamtely 7mm', N'piece', 135.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (220, N'Office Equipment', N'SCISSOR, symmetrical, blade length: 65mm min', N'pair', 16.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (221, N'Office Equipment', N'PENCIL SHARPENER, manual, singel cutter head', N'piece', 206.7000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (222, N'Office Equipment', N'DATING AND STAMPING MACHINE, heavy duty, self-inking stamp, with removable and refillable ink pad', N'piece', 487.9500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (223, N'Office Equipment', N'STAPLER, standard type, minimun loading capacity of 200 staples, one time binding capacity of 2-20 sheets copy pare 70gsm', N'piece', 83.8000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (224, N'Office Equipment', N'STAPLE REMOVER, plier type', N'piece', 24.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (225, N'Office Equipment', N'TAPE DISPENSER, table top, for 24mm width tape', N'piece', 60.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (226, N'Office Equipment', N'WASTEBASKET, non-rigid plastic', N'piece', 30.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (227, N'Janitorial Supplies', N'SOAP, bathroom, 90 gsm as packed, regular size, white/colored, scented', N'piece', 23.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (228, N'Janitorial Supplies', N'BROOM, soft,tamboo', N'piece', 75.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (229, N'Janitorial Supplies', N'BROOM, stick, tingting, standard size, grip measurede 6" from the top, usable length of at least 760mm', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (230, N'Janitorial Supplies', N'CLEANSER(SCOURING)POWDER, 350gms min, in canister', N'canister', 25.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (232, N'Janitorial Supplies', N'DISINFECTANT SPRAY, bleaching solution', N'can', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (234, N'Janitorial Supplies', N'FLOOR WAX, paste type, natural, 2kg/can, kerosene based for wood and cemented surfaces, withouth unpleasant or offensive odor', N'can', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (235, N'Janitorial Supplies', N'FLOOR WAX, paste type, red, 2kg/can, for kerosene based for wood and cemented surfaces', N'can', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (236, N'Janitorial Supplies', N'FLOOR WAX, liquid type, natural, 3.75-5.0L, buffable,, water based for vinyl and marble', N'gallon', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (238, N'Janitorial Supplies', N'FURNITURE CLEANER, aerosol type, 300ml min per can', N'can', 89.1000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (239, N'Janitorial Supplies', N'INSECTICIDE, aerosol type, 600ml net content, muti-insect killer, without unpleasant odor', N'can', 142.1500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (240, N'Janitorial Supplies', N'MOPHANDLE, heavy duty, aluminum, screw type, with metal mophead clipper', N'piece', 148.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (241, N'Janitorial Supplies', N'MOPHEAD, made of rayon, 400 grans min', N'piece', 125.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (242, N'Janitorial Supplies', N'RAGS, all cotton, 32 pieces per kilogram per bundle', N'kilo', 60.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (243, N'Janitorial Supplies', N'SCOURING PAD,  made of synthetic nylon, 140 x 220mm', N'pack', 110.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (244, N'Janitorial Supplies', N'CLEANER, toilet bowl and urinal, 900ml-1000nl cap', N'bottle', 42.8000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (245, N'Janitorial Supplies', N'TOILET DEODORANT CAKE, deodorizer/moth proofer, 50g per piece, assorted scents', N'box', 25.7000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (246, N'Janitorial Supplies', N'TRASHBAG, plastic, black, gusseted type, made from polyethylene plastic, 235mm depth', N'roll', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (247, N'Office Supplies', N'COLUMNAR NOTEBOOK, 24 columns', N'pieces', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (248, N'Office Supplies', N'PAPER, copy, Short (8.5 x 11)', N'reams', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (249, N'Office Supplies', N'FASTENER, for paper, plastic vinyl, 50s', N'boxes', 25.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (250, N'Office Supplies', N'PENTEL PEN, whiteboard, assorted colors', N'pcs', 29.9500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (251, N'Office Supplies', N'SIGN PEN, G-2, 0.5, violet', N'pieces', 53.9500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (252, N'Office Supplies', N'SIGN PEN, my metal, dong-A, violet', N'pieces', 17.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (253, N'Office Supplies', N'BALLPEN, violet, fine point', N'pieces', 21.2500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (254, N'Office Supplies', N'POST-IT, note 3M, assorted colors, 3 x 3', N'packs', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (255, N'Office Supplies', N'POST-IT, note 3M, violet, 1.5 x 2 inch', N'packs', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (257, N'Office Supplies', N'DTR (Amano Bundy Card), 14 pts', N'pieces', 0.9500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (258, N'Janitorial Supplies', N'GARBAGE, plastic, medium, 12", 25m, black', N'packs', 28.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (261, N'Janitorial Supplies', N'WOODEN FURNITURE CLEANER, polisher, 300 grams', N'can', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (262, N'Office Supplies', N'BATTERY, Energizer, AA, packs of 4s', N'packs', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (263, N'Office Supplies', N'BATTERY, Energizer, AA, rechargeable, packs of 4s', N'pieces', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (264, N'Office Supplies', N'BATTERY, Energizer, AAA, rechargeable, packs of 4s', N'packs', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (265, N'Office Supplies', N'BATTERY CHARGER, heavy duty', N'pieces', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (266, N'Office Supplies', N'BOX FOLDER KEEPER, black, with jacket, Class A', N'pieces', 100.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (267, N'Office Supplies', N'BOX FOLDER KEEPER, blue, with jacket. Class A', N'pieces', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (268, N'Office Supplies', N'BOX FOLDER KEEPER, green, with jacket. Class A', N'pieces', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (269, N'Office Supplies', N'BOX FOLDER KEEPER, red, with jacket. Class A', N'pieces', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (270, N'Janitorial Supplies', N'SOAP, bathroom, branded, big', N'pieces', 40.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (272, N'Office Supplies', N'PAPER, copy, s-24 bond paper, Legal (8.5 x 14)', N'reams', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (273, N'Janitorial Supplies', N'DISH WASHING PASTE, 400g (AXION)', N'pieces', 67.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (274, N'Janitorial Supplies', N'GLASS CLEANER, 500ml', N'pieces', 58.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (275, N'Janitorial Supplies', N'BRUSH, toilet bowl', N'pieces', 42.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (276, N'Janitorial Supplies', N'MURIATIC ACID, 1 liter, industrial', N'bottles', 67.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (277, N'Janitorial Supplies', N'SOAP, laundry, branded', N'pieces', 23.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (278, N'Janitorial Supplies', N'SOAP, powder, branded, Jr. size, 200g', N'pieces', 32.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (279, N'Office Supplies', N'BATTERY, Dry Cell, AAA', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (280, N'Office Supplies', N'FOLDER, Pressboard, legal', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (282, N'Office Supplies', N'ALCOHOL, 68%-72% ethanol, scented, 500ml (ethyl)', N'bottle', 48.7400, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (284, N'Office Supplies', N'LOCATOR SLIPS (LS)/ Triplecate', N'booklet', 18.7000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (285, N'Office Supplies', N'Batteries CR 2025 (for Biometric Units)', N'piece', 50.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (286, N'Office Supplies', N'Batteries CR 2032', N'piece', 50.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (287, N'Office Supplies', N'Batteries LR 44 (for Calculators)', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (288, N'Office Supplies', N'Colored Paper', N'ream', 440.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (290, N'Office Supplies', N'Copy Paper s-24 Bond Paper (8x14)', N'ream', 200.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (292, N'Office Supplies', N'Copy Paper s-24 Bond Paper (L)', N'ream', 250.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (293, N'Office Supplies', N'Copy Paper s-24 Bond Paper (S) 8 1/2x11', N'ream', 210.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (295, N'Office Supplies', N'Correction  Tape, Class A', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (296, N'Office Supplies', N'Envelope, Expanding w/ garter', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (299, N'Office Supplies', N'Expanding Folder w/o metal green glossy, long', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (300, N'Office Supplies', N'Expanding Folder, Green, Long, with metal tab', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (301, N'Office Supplies', N'Folder White 14 points long', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (302, N'Office Supplies', N'Folder White-short 14 pts', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (303, N'Office Supplies', N'HP 685 Black', N'piece', 900.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (304, N'Office Supplies', N'HP 685 Colored', N'piece', 1450.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (305, N'Office Supplies', N'HP LaserJet 5949A', N'piece', 4000.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (306, N'Office Supplies', N'HP LaserJet Q2612A', N'piece', 3600.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (307, N'Office Supplies', N'Linen Paper, Long Canon', N'boxes', 600.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (308, N'Office Supplies', N'NOTEBOOKS', N'Piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (309, N'Office Supplies', N'Paper Boards for certificate 120 gsm packs of 10''s', N'packs', 50.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (310, N'Office Supplies', N'Paper Clamp big 1" black (12pcs/box)', N'box', 50.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (311, N'Office Supplies', N'Paper Clamp big 1/2" black (12pcs/box)', N'box', 50.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (312, N'Office Supplies', N'Paper Clamp big 2" (12pcs/box)', N'box', 108.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (313, N'Office Supplies', N'Paper Clip Vinyl big', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (314, N'Office Supplies', N'Paper Clip Vinyl small', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (315, N'Office Supplies', N'Paper Fastener, plastic vinyl 50s', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (316, N'Office Supplies', N'Pen-Ballpen, BLACK, Fine Point', N'piece', 23.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (317, N'Office Supplies', N'Pen-Ballpen Red Fine point', N'piece', 23.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (318, N'Office Supplies', N'Pen-Ballpen, VIOLET, Fine Point', N'piece', 23.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (319, N'Office Supplies', N'PENCIL, lead, w/ eraser, wood case, hardness: HB', N'dozen', 22.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (320, N'Office Supplies', N'RECORD BOOK, 300 pages, Cloth bound, red', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (321, N'Office Supplies', N'RECORD BOOK, 500 pages, Cloth bound, red', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (322, N'Office Supplies', N'Rubber Stamps, Ordinary', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (324, N'Office Supplies', N'Staple Wire #35, Copper staples', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (325, N'Office Supplies', N'Stapler with wire remover', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (326, N'Office Supplies', N'Sticker Paper(A4 Size) Asst colors 10pck', N'pack', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (327, N'Office Supplies', N'Thermal Paper Fax Machine, Standard', N'roll', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (328, N'Office Supplies', N'Token for CSC week celebration', N'piece', 150.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (329, N'Office Supplies', N'Trodat Ink Colour 7011 28ml.', N'piece', 150.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (330, N'Office Supplies', N'Trodat Stamp ("For and in the Absence of the PHRMO")', N'piece', NULL, NULL)
GO
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (331, N'Office Supplies', N'T-Shirts for CSC Week Celebration', N'piece', 250.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (332, N'Office Supplies', N'Toner- GESTETNER MP C2000 LE Copier, Black', N'piece', 3000.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (333, N'Office Supplies', N'Risograph Ink Black', N'rolls', 1500.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (334, N'Office Supplies', N'Risograph CR Master B4 TR', N'roll', 4000.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (335, N'Office Supplies', N'NORTON Anti Virus 3 in 1 Software', N'piece', 4000.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (336, N'Office Supplies', N'USB, 2 Gigabyte', N'piece', 500.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (337, N'Office Supplies', N'Crates', N'piece', 500.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (338, N'Office Supplies', N'Drum for Gestetner Toner', N'piece', 6500.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (340, N'Office Supplies', N'Locator Slips (Booklet of 50s, prenumbered, 2 copies)', N'booklet', 65.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (342, N'Office Supplies', N'Leave Application Review Form, Prenumbered, 2 Copies', N'booklet', 65.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (343, N'Office Supplies', N'Leave Cancellation Form, Prenumbered, 2 Copies', N'booklet', 65.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (344, N'Office Supplies', N'Ajax Cleanser', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (345, N'Janitorial Supplies', N'Dishwashing Pad big (5"x7")', N'pack', 60.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (346, N'Janitorial Supplies', N'Doormat Oval, Cloth, Thick, Regular Cotton', N'piece', 50.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (347, N'Janitorial Supplies', N'Floor Polisher Brush- Floormate Model 12', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (348, N'Janitorial Supplies', N'GARBAGE, plastic, Big', N'pack', 800.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (349, N'Janitorial Supplies', N'Insect Spray, 420g, Class A', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (350, N'IT Equipment', N'Laptop Computer', N'unit', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (351, N'IT Equipment', N'PRINTER, LASER, monochrome, network-ready', N'unit', 740.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (352, N'IT Equipment', N'Airgrid Back Chair with Mesh seats', N'unit', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (353, N'IT Equipment', N'LCD Projector', N'unit', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (354, N'IT Equipment', N'Office Station', N'Unit', 15000.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (355, N'Office Supplies', N'BATTERY, Energizer, AAA, packs of 4s', N'packs', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (357, N'Office Supplies', N'Book Binding - Hard Bound', N'Book', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (361, N'Electrical Supplies', N'TAPE, electrical, 18mm x 16M min', N'roll', 19.0500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (362, N'Office Supplies', N'Photocopier Toner DSm 615', N'toner', 2800.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (363, N'Office Supplies', N'Photocopier Toner MP2501', N'Toner', 2800.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (364, N'Office Supplies', N'CORRECTION TAPE, 6 meters(min), 1 piece in individual plastic', N'pcs', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (365, N'Office Supplies', N'ENVELOPE, EXPANDING, plastic', N'pcs', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (366, N'Office Supplies', N'FILE TAB DIVIDER, bristol board, A4', N'set', 12.7300, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (367, N'Office Supplies', N'FILE TAB DIVIDER, bristol board, legal size', N'set', 16.9800, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (368, N'Office Supplies', N'FOLDER, L-type, A4, 50 pieces pack', N'pack', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (369, N'Office Supplies', N'FOLDER, L-type, Legal size, 50 pieces per pack', N'piece', 8.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (370, N'Office Supplies', N'MARKER, whiteboard, bullet type, black', N'piece', 12.4000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (371, N'Office Supplies', N'MARKER, whiteboard, bullet type, blue', N'piece', 49.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (372, N'Office Supplies', N'MARKER, whiteboard, bullet type, red', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (373, N'Office Supplies', N'MARKER, permanent, bullet type, black', N'piece', 9.8500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (374, N'Office Supplies', N'MARKER, permanent, bullet type, blue', N'piece', 9.8500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (375, N'Office Supplies', N'MARKER, permanent, bullet type, red', N'piece', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (376, N'Office Supplies', N'NOTE PAD, stick-on, (3"x4"), 100 sheets per pad', N'pad', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (377, N'Office Supplies', N'PAD PAPER, Ruled', N'pad', 18.2600, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (378, N'Office Supplies', N'RING BINDER, Plastic 32mm, 10 pieces per bundle', N'bundle', 256.8700, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (379, N'Office Supplies', N'SIGN PEN, black', N'piece', 38.1000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (380, N'Office Equipment', N'SIGN PEN, blue', N'pieces', 38.1000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (381, N'Office Supplies', N'STAPLE WIRE, Heavy duty, 23/13', N'box', 23.8500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (382, N'Office Devices', N'CUTTER KNIFE, or general purpose', N'piece', 30.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (383, N'Office Devices', N'STAPLER, binder type, 1 inch', N'piece', 878.8000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (385, N'Office Equipment', N'MOUSE, optical, USB connection type', N'unit', 146.0700, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (386, N'Office Supplies', N'INK CART, BROTHER LC67B, Black', N'cart', 910.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (387, N'Office Supplies', N'INK CART, BROTHER LC67C, Cyan', N'cart', 546.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (388, N'Office Supplies', N'INK CART, BROTHER LC67M, Magenta', N'cart', 546.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (389, N'Office Supplies', N'INK CART, BROTHER LC67Y, Yellow', N'cart', 546.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (390, NULL, N'3-in-1 coffee', N'pc', 8.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (391, N'Office Supplies', N'ENVELOPE, MAILING, 500 pieces per box, 80 gsm', N'box', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (392, NULL, N'Coffee creamer, 450g', N'pack', 85.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (393, NULL, N'Coffee gold blend (87 cups)', N'bottle', 530.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (394, NULL, N'Coffee 3-in-1 with gano derma', N'box', 380.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (395, NULL, N'Candies, Assorted flavor', N'pack', 35.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (396, NULL, N'Crackers, 600 grms', N'pack', 190.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (397, NULL, N'Cookies, individual wrapped, 10''s', N'pack', 200.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (398, NULL, N'Cookies', N'can', 183.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (399, NULL, N'Green Tea', N'pack', 75.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (400, NULL, N'Bottled Water, distilled 300mg', N'bottle', 11.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (401, NULL, N'Sugar, brown, 1 kl', N'kilo', 60.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (402, NULL, N'Paper cups, 50''s', N'pack', 130.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (403, NULL, N'Stirrer, plastic, 100''s', N'pack', 30.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (405, N'Office Supplies', N'PAPER, MULTICOPY, A4, 80gsm, 210mm x 297mm', N'ream', 183.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (406, N'Office Supplies', N'PAPER, MULTICOPY, LEGAL, 80gsm, 216mm x 330mm (8.5"x 13")', N'ream', 200.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (407, N'Janitorial Supplies', N'Paper  Roll Towel, 2s x 2 ply (2pcs)', N'pack', 60.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (408, N'Janitorial Supplies', N'Diswashing paste 500 grams', N'pc', 70.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (409, N'Computer Supplies', N'DCP-J100LC535XLBK- BLACK', N'PCS', 450.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (410, N'Computer Supplies', N'DCP-J100LC535XLBK-CYAN', N'PCS', 450.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (411, N'Computer Supplies', N'DCP-J100LC535XLBK-MAGENTA', N'PCS', 450.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (412, N'Computer Supplies', N'DCP-J100LC535XLB-YELLOW', N'PCS', 450.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (414, N'Office Supplies', N'Folder Expanding with metal tab green glossy long', N'pcs', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (415, N'Office Supplies', N'Folder Expanding without metal tab', N'pcs', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (416, N'Office Supplies', N'Glue stick', N'pc', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (417, N'Office Supplies', N'PVC Plastic Cover Hard long', N'pc', 25.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (418, N'Office Supplies', N'PVC Plastic cover short', N'pcs', 15.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (419, N'Office Supplies', N'special board (Book Cover)10s', N'pack', 75.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (420, N'Office Supplies', N'Uni-correction pen,rolling ball metal tip', N'pc', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (425, N'Janitorial Supplies', N'diswashing paste  500 grams', N'pc', 80.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (427, N'Office Equipment', N'Paper Shredder, Cutting width: 3mm-4mm (entry level)', N'unit', 5813.1900, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (428, N'Office Supplies', N'ball pen black/blue', N'pc.', 20.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (435, N'Meals and Snacks', N'Choices of the following', NULL, NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (436, N'Meals and Snacks', N'Bilo bilo with rice cake/ bottled water', N'pax', 50.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (437, N'Office Supplies', N'Box Folder Keeper with Cover Big (Navy Blue) Unifiles', N'pcs', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (438, N'Office Supplies', N'Box Folder Keeper with cover Small ( Navy Blue) unifiles', N'pcs', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (440, N'Janitorial Supplies', N'Tissue roll for toilet', N'pack', NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (441, N'Computer Supplies', N'HP Laserjet Ink 125A black', N'toner', 4000.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (444, N'Office Supplies', N'Ball pen red', N'pcs', 47.8000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (449, NULL, N'Coffee powder in pouch 500 gram', N'Pouch', 80.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (450, NULL, N'Cookies in canister', N'Can', 280.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (451, NULL, N'Coffee 3 in 1', N'Pcs.', 8.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (452, N'Electrical Supplies', N'BATTERY, Dry Cell, AA, 1.5volts, alkaline', N'pack', 37.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (453, N'Electrical Supplies', N'BATTERY, Dry Cell, AAA, 1.5volts, alkaline', N'pack', 20.2500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (454, N'Office Equipment', N'BINDING AND PUNCHING MACHINE, binding cap:50mm', N'unit', 10000.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (455, N'Office Supplies', N'Broom, Stick (Ting-Ting), usable length : 760mm min', N'piece', 31.2500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (456, N'Office Supplies', N'CARBON FILM, PE, black, 216mm x 330mm', N'box', 217.0600, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (457, N'Office Supplies', N'Cartolina, Assorted Colors, 79gsm min', N'pack', 85.4000, NULL)
GO
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (458, N'Office Equipment', N'CHAIR, MONOBLOC, BEIGE, with backrest, w/o armrest', N'piece', 270.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (459, N'Office Supplies', N'CLEARBOOK, 20 transparent pockets, for a4 size', N'piece', 40.6000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (460, N'Office Supplies', N'CLEARBOOK, 20 transparent pockets, for LEGAL size', N'piece', 43.2500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (461, N'Office Supplies', N'CLIP, BACKFOLD, all metal, clamping: 19mm (-1mm)', N'box', 9.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (462, N'Office Supplies', N'CLIP, BACKFOLD, all metal, clamping: 25mm (-1mm)', N'box', 16.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (463, N'Office Supplies', N'CLIP, BACKFOLD, all metal, clamping: 32mm (-1mm)', N'box', 21.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (464, N'Office Supplies', N'CLIP, BACKFOLD, all metal, clamping: 50mm (-1mm)', N'box', 50.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (465, N'Office Supplies', N'CONTINUOUS FORMS, 1PLY, 280mm x 241mm', N'box', 695.9000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (466, N'Office Supplies', N'CONTINUOUS FORMS, CARBONLESS, 2 PLY, 280mmx 241mm', N'box', 780.7500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (467, N'Office Supplies', N'CORRECTION TAPE, disposable, usable length:6m min', N'piece', 20.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (468, N'Office Supplies', N'DATA FILE BOX, made of chipboard, with closed ends', N'ea', 80.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (469, N'Office Supplies', N'DATA FOLDER, made of chipboard, taglia lock', N'piece', 70.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (470, N'Office Supplies', N'DETERGENT BAR, 140 grams', N'piece', 9.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (471, N'Office Supplies', N'DETERGENT POWDER, all purpose, one(1) kg', N'pouch', 41.6000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (472, N'Office Supplies', N'DISINFECTANT SPRAY, aerosol type, 400-550 grams', N'can', 125.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (473, N'Office Supplies', N'DUST PAN, non-rigid plastic, w/ detachable handle', N'piece', 27.7500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (474, N'Office Equipment', N'ELECTRIC FAN, INDUSTRIAL, ground type, metal blade', N'unit', 1131.0200, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (475, N'Office Equipment', N'ELECTRIC FAN, ORBIT type, ceiling, metal blade', N'unit', 1397.0700, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (476, N'Office Equipment', N'ELECTRIC FAN, STAND type, plastic blade', N'unit', 1026.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (477, N'Office Equipment', N'ELECTRIC FAN, WALL type, plastic blade', N'unit', 790.4000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (478, N'Office Supplies', N'ENVELOPE, DOCUMENTARY, for legal size document', N'box', 945.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (479, N'Office Supplies', N'ENVELOPE, EXPANDING, KRAFTBOARD, for legal size doc', N'box', 753.2000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (480, N'Office Supplies', N'ERASER, FELT, for blackboard/whiteboard', N'piece', 12.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (481, N'Office Supplies', N'ERASER, PLASTIC/RUBBER, pencil draft/writing', N'piece', 6.2500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (482, N'Office Supplies', N'EXTERNAL HARD DRIVE, 1TB, 2.5" HDD, USB 3.0', N'unit', 2800.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (483, N'Office Supplies', N'FACSIMILE MACHINE, uses thermal power', N'unit', 4802.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (484, N'Janitorial Supplies', N'FLOOR WAX, PASTE TYPE, RED, 2.0kg', N'can', 274.7500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (485, N'Office Supplies', N'FOLDER, PRESSBOARD, size: 240mm x 370mm (-5mm)', N'box', 973.0800, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (486, N'Office Supplies', N'FOLDER, Tagboard, A4, 1 pack, 100pices per pack', N'pack', 255.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (487, N'Office Supplies', N'FOLDER, TAGBOARD, for legal size documents', N'pack', 328.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (488, N'Office Supplies', N'HANDBOOK (RA9184), 8th Edition', N'book', 50.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (489, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. CZ107AA (HP678), Black', N'cart', 350.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (490, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. CZ107AA (HP678), Tri-color', N'cart', 350.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (491, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. CZ122A (HP685A), Black', N'cart', 373.2500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (492, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. CZ122A (HP685A), Cyan', N'cart', 254.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (493, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. CZ122A (HP685A), Magenta', N'cart', 254.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (494, N'Computer Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. CZ122A (HP685A), Yellow', N'cart', 254.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (495, N'Office Supplies', N'INK, for stamp pad, black', N'bottle', 28.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (496, N'Electrical Supplies', N'LIGHT BULB, Light Emmiting Diode (LED), 6 watts', N'piece', 83.7400, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (497, N'Electrical Supplies', N'LINEAR TUBE, LED, 18 WATTS', N'tube', 286.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (498, N'Janitorial Supplies', N'MOP BUCKET', N'unit', 2000.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (499, N'Office Supplies', N'PAPER, MULTI-PURPOSE (COPY), A4, 70gsm, 210mm x 297mm', N'ream', 159.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (500, N'Office Supplies', N'PAPER, MULTI-PURPOSE (COPY), LEGAL, 70gsm, 216mm x 330mm (8-1"x 13")', N'ream', 185.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (501, N'Office Supplies', N'PHILIPPINE NATIONAL FLAG, 100% polyester', N'piece', 326.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (502, N'Computer Supplies', N'RIBBON CART, EPSON C13S015516 (#8750), black', N'piece', 79.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (503, N'Computer Supplies', N'RIBBON CART, EPSON C13S015632, black', N'cart', 77.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (504, N'Computer Supplies', N'INK CARTRIDGE, Brother Part No. TN-332, Black', N'cart', 3475.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (505, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. CE390A, Black', N'cart', 8029.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (506, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. CE505X, Black, High Capacity', N'cart', 7357.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (507, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. CF281A (HP81A), Black Laser Jet', N'cart', 8831.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (508, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. CF283A (HP83A), Laserjet Black', N'cart', 3955.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (509, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. Q2612A', N'cart', 3228.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (510, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. Q5942A, 42A', N'cart', 7280.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (511, N'Computer Supplies', N'TONER CARTRIDGE, SAMSUNG ML-D2850B', N'cart', 5220.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (512, N'Computer Supplies', N'TONER CARTRIDGE, SAMSUNG MLT-D105', N'cart', 2860.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (513, N'Computer Supplies', N'TONER CARTRIDGE, SAMSUNG MLT-D205E, Black', N'cart', 9388.0800, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (514, N'Computer Supplies', N'TONER CARTRIDGE, SAMSUNG MLTD203L', N'cart', 4720.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (515, N'Computer Supplies', N'TONER, KYOCERA MITA KM-1505/1510/1810', N'cart', 4329.8500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (516, N'Janitorial Supplies', N'TRASHBAG, black, 940mmx1016mm, 10pcs per roll/pack', N'roll', 115.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (517, N'Janitorial Supplies', N'TRASHBAG, plastic, transparent 10pcs per roll', N'roll', 142.5700, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (518, N'IT Equipment', N'LAPTOP COMPUTER, midrange, HP Probook 450 G5,', N'unit', 45747.5200, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (519, N'Janitorial Supplies', N'GAS MASK, cloth heavy duty', N'piece', 40.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (520, N'Janitorial Supplies', N'Leather Gloves, Heavy Duty, size: 7', N'piece', 350.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (521, N'Janitorial Supplies', N'Stain Remover/disinfectant 1 liter', N'piece', 40.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (522, N'Janitorial Supplies', N'Table Duster Cloth', N'piece', 13.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (523, N'Computer Supplies', N'RJ45 connector w/ special boot pure copper', N'piece', 35.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (524, N'Computer Supplies', N'Photo Paper, glossy, 240gsm, 50 sheets', N'ream', 600.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (525, N'Computer Supplies', N'UTP CABLE CAT6a pure Copper', N'box', 17235.2500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (526, N'Computer Supplies', N'Switch Box for multiple system unit using 1 keyboard, mouse 4 ports', N'unit', 1537.3500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (527, N'Janitorial Supplies', N'Dishwashing Paste, 400 grams', N'piece', 70.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (528, N'Janitorial Supplies', N'Floor Mop w/ handle (foam Rubber)', N'piece', 200.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (531, N'Office Supplies', N'RECORD BOOK, 300 pages, size: 214mm x 278mm min', N'book', 72.2500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (532, N'Office Supplies', N'RING BINDER, 80 rings, plastic, 32mm x 1.12M', N'bundle', 75.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (533, N'Office Supplies', N'Correction Fluid Clase A', N'piece', 33.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (534, N'Office Supplies', N'PAPER, MULTICOPY, SHORT, 80gsm (8.5"x 11")', N'ream', 165.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (535, N'Office Supplies', N'Staple Wire 21-6mm (for gun tacker)', N'box', 300.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (536, N'Office Supplies', N'POST-IT, note 3M, assorted colors, 2" x 3"', N'piece', 35.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (537, N'Office Supplies', N'POST-IT, note 3M, assorted colors, 3" x 5"', N'piece', 60.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (538, N'Office Supplies', N'Pen-Ballpen, BLUE, Fine Point', N'piece', 20.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (539, N'Office Supplies', N'PENTEL PEN, whiteboard, Black', N'piece', 32.7500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (540, N'Office Supplies', N'Padding Glue, 1 Kg', N'piece', 500.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (541, N'Office Supplies', N'Double adhesive tape, 1" , 25 yards, w/ foam', N'piece', 25.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (542, N'Office Supplies', N'Double adhesive tape, 1" , 50 yards, w/ foam', N'piece', 45.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (543, N'Office Supplies', N'INK CARTRIDGE, Epson Part No. T774 K', N'cart', 260.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (544, N'Computer Supplies', N'TONER CARTRIDGE, Magicolor 1690 MF, C', N'cart', 3999.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (545, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. CE278AC', N'cart', 5000.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (546, N'Computer Supplies', N'TONER CARTRIDGE, Magicolor 1690 MF, K', N'cart', 1999.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (547, N'Computer Supplies', N'TONER CARTRIDGE, Magicolor 1690 MF, M', N'cart', 3999.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (548, N'Computer Supplies', N'TONER CARTRIDGE, Magicolor 1690 MF, Y', N'cart', 3999.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (549, N'Computer Supplies', N'HP LASERJET P1566 CE278AC', N'cart', 3700.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (550, N'Office Supplies', N'BOX FOLDER KEEPER w/ cover (15.5x11.5x1)', N'piece', 200.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (551, N'Office Supplies', N'Canon Laid-long', N'ream', 725.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (552, NULL, N'Coffee Classic, 200g', N'piece', 150.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (553, NULL, N'Coffee Creamy Latte (3-in-1) 12s', N'pack', 75.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (554, NULL, N'Biscuits (assorted flavors)', N'pack', 50.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (555, NULL, N'Disposable Cups Styro for Coffee 8oz - 24s', N'pack', 50.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (556, NULL, N'Disposable Cups Transparent 8oz - 24s', N'pack', 50.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (557, NULL, N'Plastic Bag', N'pack', 45.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (558, N'IT Equipment', N'CCTV Tester', N'set', 10000.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (559, N'Computer Supplies', N'Volume Licensing for Windows OS and Office Prodductivity', N'Software', 1500000.0000, NULL)
GO
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (560, NULL, N'Fiber Cabling, Grounding, Layout of Cabling (Aerial), Civil Works, Manhole and Restoration, Installation ( FOC SM 64core Outdoor Armored, Fiber Panels, SC Connector, Fiber Patch, Outdoor Fiber Optic Enclosure', NULL, NULL, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (565, N'Office Supplies', N'CLIP, BACKFOLD, all metal, clamping: 19mm', N'piece', 2.5000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (566, N'Meals and Snacks', N'Heavy Snacks (AM/PM)
Snacks (any of the following):
Sopas, Pancit, Kakanin, Buko Pie, Halo-Halo, Empanada, Fresh Lumpia', NULL, 50.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (569, N'Electrical Supplies', N'BATTERY, Dry Cell, D, 1.5volts, alkaline', N'pack', 98.0500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (570, N'Office Equipment', N'Calculatore, Compact, electronic, 12 digits cap', N'unit', 137.9000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (571, N'Office Equipment', N'Digital Voice Recorder, memory: 4GB (expandable)', N'unit', 6392.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (572, N'Office Supplies', N'File Organizer, expanding, plastic, 12 pockets', N'piece', 89.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (573, N'Office Equipment', N'Fire Extinguisher, Dry Chemical, 4.5kgs', N'piece', 1250.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (574, N'Office Supplies', N'MARKER, whiteboard, felt tip,bullet type, red', N'piece', 12.4000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (575, N'Office Equipment', N'Paper Trimmer/Cutting, Machine, max paper size: B4', N'unit', 8250.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (576, N'Office Supplies', N'Paper, Pad, Ruled, size: 2016 x 330 (± 2mm)', N'pad', 30.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (577, N'Office Supplies', N'RECORD BOOK, 500 pages, size: 214mm x 278mm min', N'book', 104.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (578, N'Office Supplies', N'WRAPPING PAPER, kraft, 65gsm, (-5%)', N'pack', 134.8100, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (579, N'Office Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. F6V26AA (HP680), tri-color', N'cart', 419.8300, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (580, N'Office Supplies', N'INK CARTRIDGE, Hewlett Packard Part No. F6V27AA (HP680), black', N'cart', 419.8300, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (581, N'Computer Supplies', N'TONER CARTRIDGE, Brother Part No. TN-3320, Black', N'cart', 3635.8000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (582, N'Computer Supplies', N'TONER CARTRIDGE, Brother Part No. TN-3478, Black (for 5100DN)', N'cart', 6485.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (583, N'Computer Supplies', N'TONER CARTRIDGE, Hewlett Packard Part No. CB540A, black', N'cart', 3378.6500, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (584, NULL, N'Butter Cookies', N'Box', 183.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (585, N'Computer Supplies', N'TONER CARTRIDGE, Konika Minolta D1 1610, K', N'cart', 1.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (586, N'Janitorial Supplies', N'Paint Brush 1 inch', N'pc', 40.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (588, N'Janitorial Supplies', N'Paint Brush 2 inch', N'pc', 120.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (589, N'IT Equipment', N'Glue Gun, 15mm, 120w', N'unit', 600.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (590, N'Computer Supplies', N'LCD cleaner', N'pc', 160.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (591, N'Janitorial Supplies', N'Plastic Woven Sack (Sako), 50kg', N'piece', 25.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (592, N'Office Equipment', N'Tape Measure (Metros), Metric & Imperial, 50m', N'piece', 700.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (593, N'Office Supplies', N'Battery,  9V, Alkaline, PP3, Snap Contact', N'piece', 210.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (594, N'Office Supplies', N'Thumbtacks, 24pcs', N'box', 20.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (595, N'Office Equipment', N'Paper Shredder Straight Cut, Waste container 13 liters', N'unit', 4000.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (596, N'Office Supplies', N'STAPLER, binder type, 1/2', N'box', 2.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (597, N'Office Supplies', N'Cable Tie Nylon 4" x 2.5mm 50PCS', N'pack', 200.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (598, N'Office Supplies', N'Packaging Plastic Coated Wire, 50m', N'roll', 600.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (599, N'Office Supplies', N'Foldable Umbrella, Popy compact & ligh tweight', N'piece', 250.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (600, N'Office Supplies', N'Post-it, Page Markers, Assorted Bright Colors, 1/2 in x 2 in, 50 pcs', N'pack', 50.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (601, N'Office Supplies', N'Cleaning Solution, for printhead', N'bottle', 300.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (602, N'Office Supplies', N'Thermal Paste', N'piece', 300.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (603, N'Office Supplies', N'Tape Measure (Metros), Digital, Metric & Imperial, 50m', N'piece', 1500.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (604, N'Office Equipment', N'Visitor Chair, Black, w/ Armrest', N'piece', 1000.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (605, N'IT Equipment', N'Gigabit POE, 4 Ports, 24V, 100watts', N'unit', 6000.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (606, N'Office Supplies', N'AIR FRESHENER, aerosol, 320ml', N'can', 206.0000, NULL)
INSERT [dbo].[Items] ([Id], [Category], [Item], [UOM], [Cost], [DateCreated]) VALUES (607, N'Office Supplies', N'ALCOHOL, 75% ethanol, scented, 500ml (ethyl)', N'bottle', 79.0000, NULL)
SET IDENTITY_INSERT [dbo].[Items] OFF
SET IDENTITY_INSERT [dbo].[Logs] ON 

INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (1, N'Obligations', N'Id=2<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0002<br/>BudgetControlNo=<br/>PayeeID=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-24T21:10:24.737' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (2, N'Obligations', N'Id=2<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0002<br/>BudgetControlNo=<br/>PayeeID=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-24T21:10:34.427' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (3, N'Obligations', N'Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeID=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-24T21:11:06.303' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (4, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-24T21:51:14.887' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (5, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-24T21:55:12.370' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (6, N'Obligations', N'Payees=<br/>Id=4<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0004<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-24T22:04:38.213' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (7, N'Obligations', N'Payees=<br/>Id=4<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0004<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-24T22:05:40.470' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (8, N'Obligations', N'Payees=<br/>Id=6<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0006<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T13:28:47.837' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (9, N'Payees', N'Id=5<br/>Name=<br/>Office=<br/>Address=<br/>Note=<br/>', NULL, N'Delete', CAST(N'2020-03-25T13:29:31.283' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (10, N'Payees', N'Id=7<br/>Name=<br/>Office=<br/>Address=<br/>Note=<br/>', NULL, N'Delete', CAST(N'2020-03-25T13:29:46.790' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (11, N'Payees', N'Id=9<br/>Name=<br/>Office=<br/>Address=<br/>Note=<br/>', NULL, N'Delete', CAST(N'2020-03-25T13:30:03.133' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (12, N'Obligations', N'Payees=<br/>Id=6<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0006<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T13:33:06.460' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (13, N'Payees', N'Id=0<br/>Name=<br/>Office=<br/>Address=<br/>Note=<br/>', NULL, N'Delete', CAST(N'2020-03-25T13:37:20.520' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (14, N'Payees', N'Id=12<br/>Name=<br/>Office=<br/>Address=<br/>Note=<br/>', NULL, N'Delete', CAST(N'2020-03-25T13:38:57.470' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (15, N'Payees', N'Id=13<br/>Name=<br/>Office=<br/>Address=<br/>Note=<br/>', NULL, N'Delete', CAST(N'2020-03-25T13:39:07.143' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (16, N'Obligations', N'Payees=<br/>Id=8<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0008<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T14:34:34.843' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (17, N'Obligations', N'Payees=<br/>Id=8<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0008<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T14:35:00.597' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (18, N'Appropriations', N'Allotment=0<br/>ReAligment=0<br/>AppropriationBalance=0<br/>AllotmentBalanceIncEM=0<br/>AllotmentBalanceExcEM=0<br/>ObligationsOffice=0<br/>Id=2<br/>AccountCode=<br/>AccountCodeText=<br/>FundType=<br/>AccountName=<br/>Appropriation=<br/>Year=<br/>DateCreated=<br/>Createdby=<br/>', NULL, N'Delete', CAST(N'2020-03-25T20:53:05.903' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (19, N'Appropriations', N'Allotment=0<br/>ReAligment=0<br/>AppropriationBalance=0<br/>AllotmentBalanceIncEM=0<br/>AllotmentBalanceExcEM=0<br/>ObligationsOffice=0<br/>Id=4<br/>AccountCode=<br/>AccountCodeText=<br/>FundType=<br/>AccountName=<br/>Appropriation=<br/>Year=<br/>DateCreated=<br/>Createdby=<br/>', NULL, N'Delete', CAST(N'2020-03-25T20:54:28.123' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (20, N'Allotments', N'Appropriations=<br/>Id=1<br/>AppropriationId=<br/>AllotmentDate=<br/>AllotmentAmount=<br/>Remarks=<br/>DateCreated=<br/>CreatedB=<br/>', NULL, N'Delete', CAST(N'2020-03-25T21:44:50.343' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (21, N'Allotments', N'Appropriations=<br/>Id=2<br/>AppropriationId=<br/>AllotmentDate=<br/>AllotmentAmount=<br/>Remarks=<br/>DateCreated=<br/>CreatedB=<br/>', NULL, N'Delete', CAST(N'2020-03-25T21:45:30.150' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (22, N'Allotments', N'Appropriations=<br/>Id=3<br/>AppropriationId=<br/>AllotmentDate=3/25/2020 12:00:00 AM<br/>AllotmentAmount=5000.0000<br/>Remarks=asdf<br/>DateCreated=3/25/2020 9:45:56 PM<br/>CreatedB=<br/>', NULL, N'Delete', CAST(N'2020-03-25T21:59:22.437' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (23, N'Allotments', N'Appropriations=<br/>Id=4<br/>AppropriationId=<br/>AllotmentDate=3/26/2020 12:00:00 AM<br/>AllotmentAmount=10000.0000<br/>Remarks=asdfsadf<br/>DateCreated=3/25/2020 9:49:14 PM<br/>CreatedB=<br/>', NULL, N'Delete', CAST(N'2020-03-25T21:59:24.637' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (24, N'Allotments', N'Appropriations=<br/>Id=4<br/>AppropriationId=<br/>AllotmentDate=3/26/2020 12:00:00 AM<br/>AllotmentAmount=10000.0000<br/>Remarks=asdfsadf<br/>DateCreated=3/25/2020 9:49:14 PM<br/>CreatedB=<br/>', NULL, N'Delete', CAST(N'2020-03-25T21:59:25.787' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (25, N'Allotments', N'Appropriations=<br/>Id=3<br/>AppropriationId=<br/>AllotmentDate=3/25/2020 12:00:00 AM<br/>AllotmentAmount=5000.0000<br/>Remarks=asdf<br/>DateCreated=3/25/2020 9:45:56 PM<br/>CreatedB=<br/>', NULL, N'Delete', CAST(N'2020-03-25T21:59:47.787' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (26, N'Allotments', N'Appropriations=<br/>Id=5<br/>AppropriationId=<br/>AllotmentDate=<br/>AllotmentAmount=<br/>Remarks=<br/>DateCreated=<br/>CreatedB=<br/>', NULL, N'Delete', CAST(N'2020-03-25T22:03:00.863' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (27, N'Allotments', N'Appropriations=<br/>Id=6<br/>AppropriationId=<br/>AllotmentDate=<br/>AllotmentAmount=<br/>Remarks=<br/>DateCreated=<br/>CreatedB=<br/>', NULL, N'Delete', CAST(N'2020-03-25T22:05:53.037' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (28, N'Allotments', N'Appropriations=<br/>Id=4<br/>AppropriationId=<br/>AllotmentDate=3/27/2020 12:00:00 AM<br/>AllotmentAmount=10000.0000<br/>Remarks=asdfsadfdddddfdxgfsdgsdfgdg435345<br/>DateCreated=3/25/2020 10:02:02 PM<br/>CreatedB=<br/>', NULL, N'Delete', CAST(N'2020-03-25T22:06:01.227' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (29, N'Allotments', N'Appropriations=<br/>Id=7<br/>AppropriationId=<br/>AllotmentDate=3/25/2020 12:00:00 AM<br/>AllotmentAmount=4000.0000<br/>Remarks=asdfsadf<br/>DateCreated=3/25/2020 10:07:23 PM<br/>CreatedB=<br/>', NULL, N'Delete', CAST(N'2020-03-25T22:07:38.103' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (30, N'Allotments', N'Appropriations=<br/>Id=8<br/>AppropriationId=<br/>AllotmentDate=<br/>AllotmentAmount=<br/>Remarks=<br/>DateCreated=<br/>CreatedB=<br/>', NULL, N'Delete', CAST(N'2020-03-25T22:07:43.950' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (31, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T22:26:57.283' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (32, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T22:27:01.027' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (33, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T22:27:19.090' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (34, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T22:54:31.423' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (35, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T22:56:07.623' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (36, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T22:56:25.220' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (37, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T22:58:23.647' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (38, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:02:54.967' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (39, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:26:53.627' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (40, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:28:31.453' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (41, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:29:22.590' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (42, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:30:32.443' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (43, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:31:44.277' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (44, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:35:05.830' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (45, N'Obligations', N'Payees=<br/>Id=2<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0002<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:37:23.707' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (46, N'Obligations', N'Payees=<br/>Id=2<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0002<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:37:28.373' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (47, N'Obligations', N'Payees=<br/>Id=3<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0003<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:38:35.110' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (48, N'Obligations', N'Payees=<br/>Id=3<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0003<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:38:46.857' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (49, N'ORDetails', N'Appropriations=<br/>Obligations=<br/>Id=10<br/>AppropriationId=5<br/>ObligationId=5<br/>Particulars=asd<br/>Amount=5000.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:44:44.057' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (50, N'Obligations', N'Payees=<br/>Id=5<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0005<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:45:20.607' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (51, N'Obligations', N'Payees=<br/>Id=1<br/>Date=3/25/2020 11:36:40 PM<br/>ControlNo=<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=21.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:56:59.617' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (52, N'Obligations', N'Payees=<br/>Id=2<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0002<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:57:02.033' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (53, N'Obligations', N'Payees=<br/>Id=3<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0003<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:57:02.920' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (54, N'Obligations', N'Payees=<br/>Id=4<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0004<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:57:03.590' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (55, N'ORDetails', N'Appropriations=<br/>Obligations=<br/>Id=11<br/>AppropriationId=5<br/>ObligationId=1<br/>Particulars=1111<br/>Amount=5000.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:57:26.993' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (56, N'Obligations', N'Payees=<br/>Id=2<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0002<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:59:07.287' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (57, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:59:09.547' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (58, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-25T23:59:25.997' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (59, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-26T00:00:46.197' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (60, N'Obligations', N'Payees=<br/>Id=1<br/>Date=3/26/2020 12:01:05 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-26T00:12:14.813' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (61, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-26T00:13:33.060' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (62, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-26T00:18:34.923' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (63, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-26T00:20:00.310' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (64, N'Obligations', N'Payees=<br/>Id=1<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0001<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>', NULL, N'Delete', CAST(N'2020-03-26T00:27:06.020' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (65, N'Obligations', N'Payees=<br/>Id=2<br/>Date=1/1/0001 12:00:00 AM<br/>ControlNo=2020-03-0002<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>TotalAmount=0<br/>', NULL, N'Delete', CAST(N'2020-03-26T01:52:09.617' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (66, N'Allotments', N'Appropriations=<br/>Id=9<br/>AppropriationId=<br/>AllotmentDate=<br/>AllotmentAmount=<br/>Remarks=<br/>DateCreated=<br/>CreatedB=<br/>', NULL, N'Delete', CAST(N'2020-03-26T12:54:02.957' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (67, N'ReAlignments', N'SourceAppropriations=<br/>TargetAppropriations=<br/>Id=1<br/>Date=<br/>SourceAppropriationId=<br/>TargetAppropriationId=<br/>Amount=<br/>Remarks=<br/>DateCreated=3/26/2020 2:47:57 PM<br/>CreatedBy=<br/>', NULL, N'Delete', CAST(N'2020-03-26T14:48:03.683' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (68, N'ReAlignments', N'SourceAppropriations=<br/>TargetAppropriations=<br/>Id=2<br/>Date=3/26/2020 2:50:07 PM<br/>SourceAppropriationId=<br/>TargetAppropriationId=<br/>Amount=<br/>Remarks=<br/>DateCreated=3/26/2020 2:50:07 PM<br/>CreatedBy=<br/>', NULL, N'Delete', CAST(N'2020-03-26T14:50:11.470' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (69, N'ReAlignments', N'SourceAppropriations=<br/>TargetAppropriations=<br/>Id=4<br/>Date=3/26/2020 3:00:26 PM<br/>SourceAppropriationId=<br/>TargetAppropriationId=<br/>Amount=<br/>Remarks=<br/>DateCreated=3/26/2020 3:00:26 PM<br/>CreatedBy=<br/>', NULL, N'Delete', CAST(N'2020-03-26T15:00:45.537' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (70, N'ReAlignments', N'SourceAppropriations=<br/>TargetAppropriations=<br/>Id=5<br/>Date=3/26/2020 3:00:58 PM<br/>SourceAppropriationId=<br/>TargetAppropriationId=<br/>Amount=<br/>Remarks=<br/>DateCreated=3/26/2020 3:00:58 PM<br/>CreatedBy=<br/>', NULL, N'Delete', CAST(N'2020-03-26T15:01:24.023' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (71, N'ReAlignments', N'SourceAppropriations=<br/>TargetAppropriations=<br/>Id=8<br/>Date=3/26/2020 3:04:31 PM<br/>SourceAppropriationId=<br/>TargetAppropriationId=<br/>Amount=<br/>Remarks=<br/>DateCreated=3/26/2020 3:04:31 PM<br/>CreatedBy=<br/>', NULL, N'Delete', CAST(N'2020-03-26T15:04:42.647' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (72, N'ReAlignments', N'SourceAppropriations=<br/>TargetAppropriations=<br/>Id=9<br/>Date=3/26/2020 3:07:36 PM<br/>SourceAppropriationId=<br/>TargetAppropriationId=<br/>Amount=<br/>Remarks=<br/>DateCreated=3/26/2020 3:07:36 PM<br/>CreatedBy=<br/>', NULL, N'Delete', CAST(N'2020-03-26T15:07:43.683' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (73, N'ReAlignments', N'SourceAppropriations=<br/>TargetAppropriations=<br/>Id=10<br/>Date=3/26/2020 3:07:44 PM<br/>SourceAppropriationId=<br/>TargetAppropriationId=<br/>Amount=<br/>Remarks=<br/>DateCreated=3/26/2020 3:07:44 PM<br/>CreatedBy=<br/>', NULL, N'Delete', CAST(N'2020-03-26T15:07:46.833' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (74, N'ReAlignments', N'SourceAppropriations=<br/>TargetAppropriations=<br/>Id=13<br/>Date=3/26/2020 7:35:07 PM<br/>SourceAppropriationId=<br/>TargetAppropriationId=<br/>Amount=<br/>Remarks=<br/>DateCreated=3/26/2020 7:35:07 PM<br/>CreatedBy=<br/>', NULL, N'Delete', CAST(N'2020-03-26T19:35:09.447' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (75, N'Obligations', N'Payees=<br/>Id=2<br/>Date=<br/>ControlNo=2020-03-0002<br/>BudgetControlNo=<br/>PayeeId=<br/>PayeeOffice=<br/>PayeeAddress=<br/>Chief=<br/>ChiefPosition=<br/>PBOPos=<br/>PBO=<br/>Closed=<br/>Description=<br/>DVParticular=<br/>DVApprovedBy=<br/>DVApprovedByPosition=<br/>DVNote=<br/>Status=<br/>DateClosed=<br/>Earmarked=<br/>PRNo=<br/>SSMA_TimeStamp=System.Byte[]<br/>Amount=0.0000<br/>Year=2018<br/>TotalAmount=0<br/>', NULL, N'Delete', CAST(N'2020-03-27T23:11:50.447' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (76, N'PurchaseRequests', N'Id=2<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-2<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T14:59:10.183' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (77, N'PurchaseRequests', N'Id=3<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-2<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T14:59:39.677' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (78, N'PurchaseRequests', N'Id=5<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-5<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:00:15.733' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (79, N'PurchaseRequests', N'Id=6<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-5<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:05:06.870' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (80, N'PurchaseRequests', N'Id=0<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-1<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:09:14.800' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (81, N'PurchaseRequests', N'Id=1<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-1<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:09:16.120' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (82, N'PurchaseRequests', N'Id=5<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-0005<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:12:19.113' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (83, N'PurchaseRequests', N'Id=4<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-2<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:12:23.240' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (84, N'PurchaseRequests', N'Id=1<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-0001<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:12:43.763' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (85, N'PurchaseRequests', N'Id=1<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-0001<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:13:06.430' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (86, N'PurchaseRequests', N'Id=1<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-0001<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:14:28.107' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (87, N'PurchaseRequests', N'Id=1<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-0001<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:15:38.000' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (88, N'PurchaseRequests', N'Id=1<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-0001<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:15:50.470' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (89, N'PurchaseRequests', N'Id=1<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-0001<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:17:01.387' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (90, N'PurchaseRequests', N'Id=1<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-0001<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:22:49.903' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (91, N'PurchaseRequests', N'Id=2<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-0002<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:22:52.010' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (92, N'PurchaseRequests', N'Id=1<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-0001<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:23:16.700' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (93, N'PurchaseRequests', N'Id=1<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-0001<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:34:54.570' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (94, N'PurchaseRequests', N'Id=1<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-0001<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:52:40.387' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (95, N'PurchaseRequests', N'Id=2<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-0002<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:58:29.277' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (96, N'PurchaseRequests', N'Id=1<br/>AppropriationId=<br/>Date=<br/>ControlNo=2020-03-0001<br/>Description=<br/>Purpose=<br/>', NULL, N'Delete', CAST(N'2020-03-30T15:58:32.240' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (97, N'PRDetails', N'PurchaseRequests=<br/>Id=16<br/>PRId=<br/>ItemNo=<br/>Quantity=<br/>Category=Office Equipment<br/>Item=AIRPOT, electric, with dispenser, 3.8L min.<br/>UOM=unit<br/>Cost=1284.0000<br/>TotalAmount=<br/>', NULL, N'Delete', CAST(N'2020-03-30T17:25:28.297' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (98, N'PRDetails', N'PurchaseRequests=<br/>Id=17<br/>PRId=<br/>ItemNo=<br/>Quantity=<br/>Category=Office Equipment<br/>Item=CALCULATOR, heavy duty, 12 digits capacit, 2-color print<br/>UOM=unit<br/>Cost=<br/>TotalAmount=<br/>', NULL, N'Delete', CAST(N'2020-03-30T17:26:34.540' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (99, N'PRDetails', N'PurchaseRequests=<br/>Id=18<br/>PRId=<br/>ItemNo=<br/>Quantity=<br/>Category=Office Equipment<br/>Item=CALCUATOR, compact, electronic, 12 digists cap<br/>UOM=unit<br/>Cost=137.9000<br/>TotalAmount=<br/>', NULL, N'Delete', CAST(N'2020-03-30T17:27:29.137' AS DateTime), NULL)
GO
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (100, N'PRDetails', N'PurchaseRequests=<br/>Id=19<br/>PRId=<br/>ItemNo=<br/>Quantity=<br/>Category=Office Equipment<br/>Item=AIRPOT, electric, with dispenser, 3.8L min.<br/>UOM=unit<br/>Cost=1284.0000<br/>TotalAmount=<br/>', NULL, N'Delete', CAST(N'2020-03-30T17:28:23.763' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (101, N'PRDetails', N'PurchaseRequests=<br/>Id=20<br/>PRId=<br/>ItemNo=<br/>Quantity=<br/>Category=Office Equipment<br/>Item=CALCULATOR, heavy duty, 12 digits capacit, 2-color print<br/>UOM=unit<br/>Cost=<br/>TotalAmount=<br/>', NULL, N'Delete', CAST(N'2020-03-30T17:28:26.140' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (102, N'PRDetails', N'PurchaseRequests=<br/>Id=23<br/>PRId=<br/>ItemNo=<br/>Quantity=<br/>Category=Office Equipment<br/>Item=CALCUATOR, compact, electronic, 12 digists cap<br/>UOM=unit<br/>Cost=137.9000<br/>TotalAmount=<br/>', NULL, N'Delete', CAST(N'2020-03-30T17:29:49.050' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (1076, N'PriceQuotations', N'PurchaseRequests=<br/>Id=2<br/>PRId=<br/>Date=<br/>ControlNo=2020-03-0002<br/>Description=<br/>Purpose=<br/>TotalAmount=<br/>PGSOfficer=<br/>Position=<br/>', NULL, N'Delete', CAST(N'2020-03-31T16:07:10.033' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (1077, N'PriceQuotations', N'PurchaseRequests=<br/>Id=1<br/>PRId=<br/>Date=3/31/2020 4:08:37 PM<br/>ControlNo=2020-03-0001<br/>Description=ssss<br/>Purpose=<br/>TotalAmount=<br/>PGSOfficer=ATTY. VOLTAIRE B. GARCIA<br/>Position=Chairperson, BAC-Goods<br/>', NULL, N'Delete', CAST(N'2020-03-31T16:09:03.250' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (1078, N'PQDetails', N'PriceQuotations=<br/>Id=2<br/>PQId=<br/>ItemNo=-1<br/>Quantity=2<br/>Category=Office Equipment<br/>Item=CALCULATOR, heavy duty, 12 digits capacit, 2-color print<br/>UOM=unit<br/>Cost=500.0000<br/>TotalAmount=1000.0000<br/>', NULL, N'Delete', CAST(N'2020-03-31T17:12:43.413' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (1079, N'PQDetails', N'PriceQuotations=<br/>Id=2<br/>PQId=<br/>ItemNo=-1<br/>Quantity=2<br/>Category=Office Equipment<br/>Item=CALCULATOR, heavy duty, 12 digits capacit, 2-color print<br/>UOM=unit<br/>Cost=500.0000<br/>TotalAmount=1000.0000<br/>', NULL, N'Delete', CAST(N'2020-03-31T17:12:53.350' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (1080, N'PQDetails', N'PriceQuotations=<br/>Id=2<br/>PQId=<br/>ItemNo=-1<br/>Quantity=2<br/>Category=Office Equipment<br/>Item=CALCULATOR, heavy duty, 12 digits capacit, 2-color print<br/>UOM=unit<br/>Cost=500.0000<br/>TotalAmount=1000.0000<br/>', NULL, N'Delete', CAST(N'2020-03-31T17:13:14.147' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (1081, N'PQDetails', N'PriceQuotations=<br/>Id=1<br/>PQId=<br/>ItemNo=<br/>Quantity=1<br/>Category=Office Equipment<br/>Item=AIRPOT, electric, with dispenser, 3.8L min.<br/>UOM=unit<br/>Cost=1284.0000<br/>TotalAmount=1284.0000<br/>', NULL, N'Delete', CAST(N'2020-03-31T17:13:20.903' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (1082, N'Users', N'FullName= <br/>UserRole=<br/>Password=<br/>Id=b9735bb1-de85-4cd8-af09-f6cba8be5349<br/>Email=<br/>EmailConfirmed=<br/>PasswordHash=<br/>SecurityStamp=15882b97-0ba8-4fb5-8b0a-e80435201db2<br/>PhoneNumber=<br/>PhoneNumberConfirmed=<br/>TwoFactorEnabled=<br/>LockoutEndDateUtc=<br/>LockoutEnabled=<br/>AccessFailedCount=<br/>UserName=<br/>LastUpdatedBy=<br/>LastUpdated=<br/>CreatedDate=<br/>FirstName=<br/>LastName=<br/>MiddleName=<br/>CivilStatus=<br/>Gender=<br/>BirthDate=<br/>AddressLine2=<br/>AddressLine1=<br/>TownCity=<br/>Cellular=<br/>Height=<br/>Weight=<br/>Religion=<br/>Citizenship=<br/>Languages=<br/>Position=<br/>', NULL, N'Delete', CAST(N'2020-03-31T23:52:12.500' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (1083, N'Users', N'FullName= <br/>UserRole=<br/>Password=<br/>Id=bd18fa18-abe1-42a3-8191-3ebe06742618<br/>Email=<br/>EmailConfirmed=<br/>PasswordHash=<br/>SecurityStamp=abe2dcae-f33a-48cb-bf38-705287365169<br/>PhoneNumber=<br/>PhoneNumberConfirmed=<br/>TwoFactorEnabled=<br/>LockoutEndDateUtc=<br/>LockoutEnabled=<br/>AccessFailedCount=<br/>UserName=<br/>LastUpdatedBy=<br/>LastUpdated=<br/>CreatedDate=<br/>FirstName=<br/>LastName=<br/>MiddleName=<br/>CivilStatus=<br/>Gender=<br/>BirthDate=<br/>AddressLine2=<br/>AddressLine1=<br/>TownCity=<br/>Cellular=<br/>Height=<br/>Weight=<br/>Religion=<br/>Citizenship=<br/>Languages=<br/>Position=<br/>', NULL, N'Delete', CAST(N'2020-03-31T23:52:17.567' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (1084, N'Users', N'FullName= <br/>UserRole=<br/>Password=<br/>Id=e701ebb6-8c5e-4465-9330-d31ee6a78d96<br/>Email=<br/>EmailConfirmed=<br/>PasswordHash=<br/>SecurityStamp=451c0469-723e-437b-b0a4-b06469718a46<br/>PhoneNumber=<br/>PhoneNumberConfirmed=<br/>TwoFactorEnabled=<br/>LockoutEndDateUtc=<br/>LockoutEnabled=<br/>AccessFailedCount=<br/>UserName=<br/>LastUpdatedBy=<br/>LastUpdated=<br/>CreatedDate=<br/>FirstName=<br/>LastName=<br/>MiddleName=<br/>CivilStatus=<br/>Gender=<br/>BirthDate=<br/>AddressLine2=<br/>AddressLine1=<br/>TownCity=<br/>Cellular=<br/>Height=<br/>Weight=<br/>Religion=<br/>Citizenship=<br/>Languages=<br/>Position=<br/>', NULL, N'Delete', CAST(N'2020-04-01T00:01:32.923' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (1085, N'Users', N'FullName= <br/>UserRole=<br/>Password=<br/>Id=efe67698-5022-447d-a3b5-dfb066cfec00<br/>Email=<br/>EmailConfirmed=<br/>PasswordHash=<br/>SecurityStamp=fc8fe7dc-f0cd-4b4c-98dd-b68c2b7bee57<br/>PhoneNumber=<br/>PhoneNumberConfirmed=<br/>TwoFactorEnabled=<br/>LockoutEndDateUtc=<br/>LockoutEnabled=<br/>AccessFailedCount=<br/>UserName=<br/>LastUpdatedBy=<br/>LastUpdated=<br/>CreatedDate=<br/>FirstName=<br/>LastName=<br/>MiddleName=<br/>CivilStatus=<br/>Gender=<br/>BirthDate=<br/>AddressLine2=<br/>AddressLine1=<br/>TownCity=<br/>Cellular=<br/>Height=<br/>Weight=<br/>Religion=<br/>Citizenship=<br/>Languages=<br/>Position=<br/>', NULL, N'Delete', CAST(N'2020-04-01T00:01:41.587' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (1086, N'Users', N'FullName= <br/>UserRole=<br/>Password=<br/>Id=1efed8c6-fa5d-4335-a625-d335fc66aafa<br/>Email=<br/>EmailConfirmed=<br/>PasswordHash=<br/>SecurityStamp=6dbc9a2d-ffd9-457d-a934-ca688d48eb87<br/>PhoneNumber=<br/>PhoneNumberConfirmed=<br/>TwoFactorEnabled=<br/>LockoutEndDateUtc=<br/>LockoutEnabled=<br/>AccessFailedCount=<br/>UserName=<br/>LastUpdatedBy=<br/>LastUpdated=<br/>CreatedDate=<br/>FirstName=<br/>LastName=<br/>MiddleName=<br/>CivilStatus=<br/>Gender=<br/>BirthDate=<br/>AddressLine2=<br/>AddressLine1=<br/>TownCity=<br/>Cellular=<br/>Height=<br/>Weight=<br/>Religion=<br/>Citizenship=<br/>Languages=<br/>Position=<br/>', NULL, N'Delete', CAST(N'2020-04-01T00:01:57.840' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (1087, N'Users', N'FullName= <br/>UserRole=<br/>Password=<br/>Id=a3fde44d-69ce-4f92-9dd8-e7793ff55e0f<br/>Email=<br/>EmailConfirmed=<br/>PasswordHash=<br/>SecurityStamp=c6f5d334-ecfd-469d-8641-dc65edc650ee<br/>PhoneNumber=<br/>PhoneNumberConfirmed=<br/>TwoFactorEnabled=<br/>LockoutEndDateUtc=<br/>LockoutEnabled=<br/>AccessFailedCount=<br/>UserName=<br/>LastUpdatedBy=<br/>LastUpdated=<br/>CreatedDate=<br/>FirstName=<br/>LastName=<br/>MiddleName=<br/>CivilStatus=<br/>Gender=<br/>BirthDate=<br/>AddressLine2=<br/>AddressLine1=<br/>TownCity=<br/>Cellular=<br/>Height=<br/>Weight=<br/>Religion=<br/>Citizenship=<br/>Languages=<br/>Position=<br/>', NULL, N'Delete', CAST(N'2020-04-01T00:02:54.133' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (1088, N'Users', N'FullName= <br/>UserRole=<br/>Password=<br/>Id=f1120b1f-d908-4e61-ad59-92129500aa30<br/>Email=<br/>EmailConfirmed=<br/>PasswordHash=<br/>SecurityStamp=4fb443a8-8140-44c2-92f9-33cad7955f97<br/>PhoneNumber=<br/>PhoneNumberConfirmed=<br/>TwoFactorEnabled=<br/>LockoutEndDateUtc=<br/>LockoutEnabled=<br/>AccessFailedCount=<br/>UserName=<br/>LastUpdatedBy=<br/>LastUpdated=<br/>CreatedDate=<br/>FirstName=<br/>LastName=<br/>MiddleName=<br/>CivilStatus=<br/>Gender=<br/>BirthDate=<br/>AddressLine2=<br/>AddressLine1=<br/>TownCity=<br/>Cellular=<br/>Height=<br/>Weight=<br/>Religion=<br/>Citizenship=<br/>Languages=<br/>Position=<br/>', NULL, N'Delete', CAST(N'2020-04-01T00:02:55.563' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (1089, N'Users', N'FullName= <br/>UserRole=<br/>Password=<br/>Id=e754b7dd-03be-454c-8a94-6caf21253b29<br/>Email=<br/>EmailConfirmed=<br/>PasswordHash=<br/>SecurityStamp=d459acf5-50ee-4220-a197-25d4ff687fff<br/>PhoneNumber=<br/>PhoneNumberConfirmed=<br/>TwoFactorEnabled=<br/>LockoutEndDateUtc=<br/>LockoutEnabled=<br/>AccessFailedCount=<br/>UserName=<br/>LastUpdatedBy=<br/>LastUpdated=<br/>CreatedDate=<br/>FirstName=<br/>LastName=<br/>MiddleName=<br/>CivilStatus=<br/>Gender=<br/>BirthDate=<br/>AddressLine2=<br/>AddressLine1=<br/>TownCity=<br/>Cellular=<br/>Height=<br/>Weight=<br/>Religion=<br/>Citizenship=<br/>Languages=<br/>Position=<br/>', NULL, N'Delete', CAST(N'2020-04-01T00:02:56.530' AS DateTime), NULL)
INSERT [dbo].[Logs] ([Id], [TableName], [OldValues], [NewValues], [Action], [DateCreated], [CreatedBy]) VALUES (1090, N'Users', N'FullName= <br/>UserRole=<br/>Password=<br/>Id=d48d243b-e2d0-472c-9005-e15593b67399<br/>Email=<br/>EmailConfirmed=<br/>PasswordHash=<br/>SecurityStamp=9aa40e0e-79cb-449a-8c00-c4910721aebd<br/>PhoneNumber=<br/>PhoneNumberConfirmed=<br/>TwoFactorEnabled=<br/>LockoutEndDateUtc=<br/>LockoutEnabled=<br/>AccessFailedCount=<br/>UserName=<br/>LastUpdatedBy=<br/>LastUpdated=<br/>CreatedDate=<br/>FirstName=<br/>LastName=<br/>MiddleName=<br/>CivilStatus=<br/>Gender=<br/>BirthDate=<br/>AddressLine2=<br/>AddressLine1=<br/>TownCity=<br/>Cellular=<br/>Height=<br/>Weight=<br/>Religion=<br/>Citizenship=<br/>Languages=<br/>Position=<br/>', NULL, N'Delete', CAST(N'2020-04-01T00:03:22.387' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Logs] OFF
INSERT [dbo].[Obligations] ([Id], [Date], [ControlNo], [BudgetControlNo], [PayeeId], [PayeeOffice], [PayeeAddress], [Chief], [ChiefPosition], [PBOPos], [PBO], [Closed], [Description], [DVParticular], [DVApprovedBy], [DVApprovedByPosition], [DVNote], [Status], [DateClosed], [Earmarked], [PRNo], [Amount], [Year]) VALUES (1, CAST(N'2020-03-26T01:57:49.0000000' AS DateTime2), N'2020-03-0001', NULL, 14, N'GO-PITD', N'Bayombong', N'SHERLYN B. FERNANDEZ', N'Activing Chief, PITD, GO', N'Provincial Budget Officer', N'dss', 1, N'sdf3sfasdf', N'sssasdf', N'CARLOS M. PADILLA', N'GOVERNOR', N'GOOD', N'Closed', CAST(N'2020-03-26T12:28:02.0000000' AS DateTime2), 0, NULL, 64000.0000, 2018)
SET IDENTITY_INSERT [dbo].[ORDetails] ON 

INSERT [dbo].[ORDetails] ([Id], [AppropriationId], [ObligationId], [Particulars], [Amount]) VALUES (1, 5, 1, N'wewe', 50000.0000)
INSERT [dbo].[ORDetails] ([Id], [AppropriationId], [ObligationId], [Particulars], [Amount]) VALUES (2, 7, 1, N'222', 6000.0000)
INSERT [dbo].[ORDetails] ([Id], [AppropriationId], [ObligationId], [Particulars], [Amount]) VALUES (3, 8, 1, N'ewqe', 8000.0000)
SET IDENTITY_INSERT [dbo].[ORDetails] OFF
SET IDENTITY_INSERT [dbo].[Payees] ON 

INSERT [dbo].[Payees] ([Id], [Name], [Office], [Address], [Note]) VALUES (1, N'MARITESS S. GALIWAN ET. AL.', N'GO-PITD', N'Bayombong, Nueva Vizcaya', N'')
INSERT [dbo].[Payees] ([Id], [Name], [Office], [Address], [Note]) VALUES (14, N'JIMMY L. CALATA', N'GO-PITD', N'Bayombong', N'')
SET IDENTITY_INSERT [dbo].[Payees] OFF
SET IDENTITY_INSERT [dbo].[PQDetails] ON 

INSERT [dbo].[PQDetails] ([Id], [PQId], [ItemNo], [Quantity], [Category], [Item], [UOM], [Cost], [TotalAmount]) VALUES (3, 1, NULL, 1, N'Office Equipment', N'AIRPOT, electric, with dispenser, 3.8L min.', N'unit', 1284.0000, 1284.0000)
INSERT [dbo].[PQDetails] ([Id], [PQId], [ItemNo], [Quantity], [Category], [Item], [UOM], [Cost], [TotalAmount]) VALUES (4, 1, NULL, 3, N'Office Equipment', N'CALCULATOR, heavy duty, 12 digits capacit, 2-color print', N'unit', 500.0000, 1500.0000)
SET IDENTITY_INSERT [dbo].[PQDetails] OFF
SET IDENTITY_INSERT [dbo].[PRDetails] ON 

INSERT [dbo].[PRDetails] ([Id], [PRId], [ItemNo], [Quantity], [Category], [Item], [UOM], [Cost], [TotalAmount], [TableName]) VALUES (21, 1, NULL, 1, N'Office Equipment', N'AIRPOT, electric, with dispenser, 3.8L min.', N'unit', 1284.0000, 1284.0000, NULL)
INSERT [dbo].[PRDetails] ([Id], [PRId], [ItemNo], [Quantity], [Category], [Item], [UOM], [Cost], [TotalAmount], [TableName]) VALUES (22, 1, NULL, NULL, N'Office Equipment', N'CALCULATOR, heavy duty, 12 digits capacit, 2-color print', N'unit', 500.0000, NULL, NULL)
SET IDENTITY_INSERT [dbo].[PRDetails] OFF
INSERT [dbo].[PriceQuotations] ([Id], [PRId], [Date], [ControlNo], [Description], [Purpose], [TotalAmount], [PGSOfficer], [Position]) VALUES (1, 1, CAST(N'2020-03-31T16:09:04.4843352' AS DateTime2), N'2020-03-0001', N'123456234', NULL, NULL, N'ATTY. VOLTAIRE B. GARCIA', N'Chairperson, BAC-Goods')
INSERT [dbo].[PurchaseRequests] ([Id], [AppropriationId], [Date], [ControlNo], [Description], [Purpose], [TotalAmount], [TableName]) VALUES (1, 5, CAST(N'2020-03-30T16:04:25.5113119' AS DateTime2), N'2020-03-0001', N' Salaries and Wages - Regular Pay', N'', 1284.0000, NULL)
INSERT [dbo].[PurchaseRequests] ([Id], [AppropriationId], [Date], [ControlNo], [Description], [Purpose], [TotalAmount], [TableName]) VALUES (2, NULL, CAST(N'2020-03-30T16:06:06.5012690' AS DateTime2), N'2020-03-0002', N'', N'', NULL, NULL)
SET IDENTITY_INSERT [dbo].[ReAlignments] ON 

INSERT [dbo].[ReAlignments] ([Id], [Date], [SourceAppropriationId], [TargetAppropriationId], [Amount], [Remarks], [DateCreated], [CreatedBy]) VALUES (15, CAST(N'2020-03-26T19:37:14.5542209' AS DateTime2), 5, 7, 12333.0000, N'12', CAST(N'2020-03-26T19:37:14.5542209' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[ReAlignments] OFF
SET IDENTITY_INSERT [dbo].[Signatories] ON 

INSERT [dbo].[Signatories] ([Id], [Person], [Position], [Note], [Year]) VALUES (1, N'CARLOS M. PADILLA', N'GOVERNOR', N'GOOD', 2020)
SET IDENTITY_INSERT [dbo].[Signatories] OFF
INSERT [dbo].[UserRoles] ([Id], [Name], [Description]) VALUES (N'71a4b974-6e59-4626-8a7d-94d380fd276e', N'User', N'User')
INSERT [dbo].[UserRoles] ([Id], [Name], [Description]) VALUES (N'b723a45d-32d2-4447-86d8-ece8fb5dc617', N'Administratror', N'Administrator')
INSERT [dbo].[Users] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [LastUpdatedBy], [LastUpdated], [CreatedDate], [FirstName], [LastName], [MiddleName], [CivilStatus], [Gender], [BirthDate], [AddressLine2], [AddressLine1], [TownCity], [Cellular], [Height], [Weight], [Religion], [Citizenship], [Languages], [Position]) VALUES (N'662f2d15-0de1-44b2-a0c1-3c35c53c18ce', NULL, NULL, N'LKT0wqsRGlORQwTAZqdO7Q==', N'f2663f6a-f6ee-4ada-b384-2a9324812ae9', NULL, NULL, NULL, NULL, NULL, NULL, N'ss', NULL, NULL, NULL, N'ss', N'ss', N'ss', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Years] ON 

INSERT [dbo].[Years] ([Id], [Year], [IsActive]) VALUES (5, 2020, 0)
INSERT [dbo].[Years] ([Id], [Year], [IsActive]) VALUES (6, 2018, 1)
SET IDENTITY_INSERT [dbo].[Years] OFF
/****** Object:  Index [IX_FK_Employees_Offices]    Script Date: 4/1/2020 8:16:04 AM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Employees_Offices] ON [dbo].[Employees]
(
	[OfficeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_Logs_Users]    Script Date: 4/1/2020 8:16:04 AM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Logs_Users] ON [dbo].[Logs]
(
	[CreatedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Towns_Towns]    Script Date: 4/1/2020 8:16:04 AM ******/
CREATE NONCLUSTERED INDEX [IX_FK_Towns_Towns] ON [dbo].[Towns]
(
	[ProvinceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_UserClaims_Users]    Script Date: 4/1/2020 8:16:04 AM ******/
CREATE NONCLUSTERED INDEX [IX_FK_UserClaims_Users] ON [dbo].[UserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_UserLogins_Users]    Script Date: 4/1/2020 8:16:04 AM ******/
CREATE NONCLUSTERED INDEX [IX_FK_UserLogins_Users] ON [dbo].[UserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_UserRolesInActions_UserRoles]    Script Date: 4/1/2020 8:16:04 AM ******/
CREATE NONCLUSTERED INDEX [IX_FK_UserRolesInActions_UserRoles] ON [dbo].[UserRolesInActions]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_UsersInRoles_Users]    Script Date: 4/1/2020 8:16:04 AM ******/
CREATE NONCLUSTERED INDEX [IX_FK_UsersInRoles_Users] ON [dbo].[UsersInRoles]
(
	[Users_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Allotments]  WITH CHECK ADD  CONSTRAINT [FK_Allotments_Appropriations] FOREIGN KEY([AppropriationId])
REFERENCES [dbo].[Appropriations] ([Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Allotments] CHECK CONSTRAINT [FK_Allotments_Appropriations]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Offices] FOREIGN KEY([OfficeId])
REFERENCES [dbo].[Offices] ([Id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Offices]
GO
ALTER TABLE [dbo].[Logs]  WITH CHECK ADD  CONSTRAINT [FK_Logs_Users] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Logs] CHECK CONSTRAINT [FK_Logs_Users]
GO
ALTER TABLE [dbo].[Obligations]  WITH CHECK ADD  CONSTRAINT [FK_Obligations_Payees] FOREIGN KEY([PayeeId])
REFERENCES [dbo].[Payees] ([Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Obligations] CHECK CONSTRAINT [FK_Obligations_Payees]
GO
ALTER TABLE [dbo].[ORDetails]  WITH CHECK ADD  CONSTRAINT [FK_ORDetails_Appropriations] FOREIGN KEY([AppropriationId])
REFERENCES [dbo].[Appropriations] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ORDetails] CHECK CONSTRAINT [FK_ORDetails_Appropriations]
GO
ALTER TABLE [dbo].[ORDetails]  WITH CHECK ADD  CONSTRAINT [FK_ORDetails_Obligations] FOREIGN KEY([ObligationId])
REFERENCES [dbo].[Obligations] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ORDetails] CHECK CONSTRAINT [FK_ORDetails_Obligations]
GO
ALTER TABLE [dbo].[PODetails]  WITH CHECK ADD  CONSTRAINT [FK_PODetails_PurchaseOrders] FOREIGN KEY([POId])
REFERENCES [dbo].[PurchaseOrders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PODetails] CHECK CONSTRAINT [FK_PODetails_PurchaseOrders]
GO
ALTER TABLE [dbo].[PQDetails]  WITH CHECK ADD  CONSTRAINT [FK_PQDetails_PurchaseQuotations] FOREIGN KEY([PQId])
REFERENCES [dbo].[PriceQuotations] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PQDetails] CHECK CONSTRAINT [FK_PQDetails_PurchaseQuotations]
GO
ALTER TABLE [dbo].[PRDetails]  WITH CHECK ADD  CONSTRAINT [FK_PRDetails_PurchaseRequests] FOREIGN KEY([PRId])
REFERENCES [dbo].[PurchaseRequests] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PRDetails] CHECK CONSTRAINT [FK_PRDetails_PurchaseRequests]
GO
ALTER TABLE [dbo].[PriceQuotations]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseQuotations_PurchaseRequests] FOREIGN KEY([PRId])
REFERENCES [dbo].[PurchaseRequests] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PriceQuotations] CHECK CONSTRAINT [FK_PurchaseQuotations_PurchaseRequests]
GO
ALTER TABLE [dbo].[PurchaseOrders]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrders_PurchaseRequests] FOREIGN KEY([PRId])
REFERENCES [dbo].[PurchaseRequests] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PurchaseOrders] CHECK CONSTRAINT [FK_PurchaseOrders_PurchaseRequests]
GO
ALTER TABLE [dbo].[PurchaseRequests]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseRequests_Appropriations] FOREIGN KEY([AppropriationId])
REFERENCES [dbo].[Appropriations] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PurchaseRequests] CHECK CONSTRAINT [FK_PurchaseRequests_Appropriations]
GO
ALTER TABLE [dbo].[ReAlignments]  WITH NOCHECK ADD  CONSTRAINT [FK_ReAlignments_Appropriations] FOREIGN KEY([SourceAppropriationId])
REFERENCES [dbo].[Appropriations] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ReAlignments] NOCHECK CONSTRAINT [FK_ReAlignments_Appropriations]
GO
ALTER TABLE [dbo].[ReAlignments]  WITH NOCHECK ADD  CONSTRAINT [FK_ReAlignments_TargetSource] FOREIGN KEY([TargetAppropriationId])
REFERENCES [dbo].[Appropriations] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[ReAlignments] NOCHECK CONSTRAINT [FK_ReAlignments_TargetSource]
GO
ALTER TABLE [dbo].[Towns]  WITH CHECK ADD  CONSTRAINT [FK_Towns_Towns] FOREIGN KEY([ProvinceId])
REFERENCES [dbo].[Provinces] ([Id])
GO
ALTER TABLE [dbo].[Towns] CHECK CONSTRAINT [FK_Towns_Towns]
GO
ALTER TABLE [dbo].[UserClaims]  WITH CHECK ADD  CONSTRAINT [FK_UserClaims_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UserClaims] CHECK CONSTRAINT [FK_UserClaims_Users]
GO
ALTER TABLE [dbo].[UserLogins]  WITH CHECK ADD  CONSTRAINT [FK_UserLogins_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UserLogins] CHECK CONSTRAINT [FK_UserLogins_Users]
GO
ALTER TABLE [dbo].[UserRolesInActions]  WITH CHECK ADD  CONSTRAINT [FK_UserRolesInActions_UserRoles] FOREIGN KEY([RoleId])
REFERENCES [dbo].[UserRoles] ([Id])
GO
ALTER TABLE [dbo].[UserRolesInActions] CHECK CONSTRAINT [FK_UserRolesInActions_UserRoles]
GO
ALTER TABLE [dbo].[UsersInRoles]  WITH CHECK ADD  CONSTRAINT [FK_UsersInRoles_UserRoles] FOREIGN KEY([UserRoles_Id])
REFERENCES [dbo].[UserRoles] ([Id])
GO
ALTER TABLE [dbo].[UsersInRoles] CHECK CONSTRAINT [FK_UsersInRoles_UserRoles]
GO
ALTER TABLE [dbo].[UsersInRoles]  WITH CHECK ADD  CONSTRAINT [FK_UsersInRoles_Users] FOREIGN KEY([Users_Id])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UsersInRoles] CHECK CONSTRAINT [FK_UsersInRoles_Users]
GO
USE [master]
GO
ALTER DATABASE [OFMIS] SET  READ_WRITE 
GO
