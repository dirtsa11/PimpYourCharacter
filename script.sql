USE [master]
GO
/****** Object:  Database [pimp_your_character]    Script Date: 21/04/2017 09:51:14 ******/
CREATE DATABASE [pimp_your_character]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pimp_your_character', FILENAME = N'C:\Users\alexi\pimp_your_character.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'pimp_your_character_log', FILENAME = N'C:\Users\alexi\pimp_your_character_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [pimp_your_character] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pimp_your_character].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pimp_your_character] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [pimp_your_character] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [pimp_your_character] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [pimp_your_character] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [pimp_your_character] SET ARITHABORT OFF 
GO
ALTER DATABASE [pimp_your_character] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [pimp_your_character] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [pimp_your_character] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [pimp_your_character] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [pimp_your_character] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [pimp_your_character] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [pimp_your_character] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [pimp_your_character] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [pimp_your_character] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [pimp_your_character] SET  DISABLE_BROKER 
GO
ALTER DATABASE [pimp_your_character] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [pimp_your_character] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [pimp_your_character] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [pimp_your_character] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [pimp_your_character] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [pimp_your_character] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [pimp_your_character] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [pimp_your_character] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [pimp_your_character] SET  MULTI_USER 
GO
ALTER DATABASE [pimp_your_character] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [pimp_your_character] SET DB_CHAINING OFF 
GO
ALTER DATABASE [pimp_your_character] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [pimp_your_character] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [pimp_your_character] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [pimp_your_character] SET QUERY_STORE = OFF
GO
USE [pimp_your_character]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [pimp_your_character]
GO
/****** Object:  Table [dbo].[accessoire]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[accessoire](
	[id_accessoire] [int] IDENTITY(1,1) NOT NULL,
	[label] [varchar](50) NOT NULL,
	[id_categorie_accessoire] [int] NOT NULL,
 CONSTRAINT [PK__accessoi__66794F8E6288F06E] PRIMARY KEY CLUSTERED 
(
	[id_accessoire] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[arme]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[arme](
	[id_arme] [int] IDENTITY(1,1) NOT NULL,
	[label] [varchar](50) NOT NULL,
	[poids] [int] NOT NULL,
	[id_categorie_arme] [int] NOT NULL,
 CONSTRAINT [PK__arme__8A8C427588FED1E2] PRIMARY KEY CLUSTERED 
(
	[id_arme] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[bouche]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bouche](
	[id_bouche] [int] IDENTITY(1,1) NOT NULL,
	[forme] [varchar](50) NOT NULL,
	[largeur] [int] NOT NULL,
	[hauteur] [int] NOT NULL,
	[profondeur] [int] NOT NULL,
	[id_couleur] [int] NOT NULL,
 CONSTRAINT [PK__bouche__3D9B6AE329A8DA77] PRIMARY KEY CLUSTERED 
(
	[id_bouche] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[bouclier]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bouclier](
	[id_bouclier] [int] IDENTITY(1,1) NOT NULL,
	[label] [varchar](50) NOT NULL,
	[poids] [int] NOT NULL,
 CONSTRAINT [PK__bouclier__8BD00F91F220FF38] PRIMARY KEY CLUSTERED 
(
	[id_bouclier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[bras]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bras](
	[id_bras] [int] IDENTITY(1,1) NOT NULL,
	[longueur] [int] NOT NULL,
	[forme] [varchar](50) NOT NULL,
 CONSTRAINT [PK__bras__DB9D8135D024A94A] PRIMARY KEY CLUSTERED 
(
	[id_bras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[buste]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[buste](
	[id_buste] [int] IDENTITY(1,1) NOT NULL,
	[hauteur] [int] NOT NULL,
	[largeur] [int] NOT NULL,
	[corpulence] [int] NOT NULL,
 CONSTRAINT [PK__buste__3BAEE6E0DBCD8BBB] PRIMARY KEY CLUSTERED 
(
	[id_buste] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[categorie_accessoire]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categorie_accessoire](
	[id_categorie_accessoire] [int] IDENTITY(1,1) NOT NULL,
	[label] [varchar](50) NOT NULL,
 CONSTRAINT [PK__categori__37EB55A67E43EA68] PRIMARY KEY CLUSTERED 
(
	[id_categorie_accessoire] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[categorie_arme]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categorie_arme](
	[id_categorie_arme] [int] IDENTITY(1,1) NOT NULL,
	[categorie_arme] [varchar](50) NOT NULL,
 CONSTRAINT [PK__categori__3FA8A98B0720E0F2] PRIMARY KEY CLUSTERED 
(
	[id_categorie_arme] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[corps]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[corps](
	[id_corps] [int] IDENTITY(1,1) NOT NULL,
	[id_bras] [int] NOT NULL,
	[id_jambe] [int] NOT NULL,
	[id_buste] [int] NOT NULL,
	[id_tete] [int] NOT NULL,
	[taille] [int] NOT NULL,
 CONSTRAINT [PK__corps__7E7796238DFDCE3C] PRIMARY KEY CLUSTERED 
(
	[id_corps] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[couleur]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[couleur](
	[id_couleur] [int] IDENTITY(1,1) NOT NULL,
	[label] [varchar](50) NOT NULL,
 CONSTRAINT [PK__couleur__8CF8971F621307C3] PRIMARY KEY CLUSTERED 
(
	[id_couleur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ethnie]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ethnie](
	[id_ethnie] [int] IDENTITY(1,1) NOT NULL,
	[label] [varchar](50) NOT NULL,
 CONSTRAINT [PK__ethnie__85CFA2582AC3603C] PRIMARY KEY CLUSTERED 
(
	[id_ethnie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[genre]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[genre](
	[id_genre] [int] IDENTITY(1,1) NOT NULL,
	[label] [varchar](50) NOT NULL,
 CONSTRAINT [PK__genre__CB767C69D62A4670] PRIMARY KEY CLUSTERED 
(
	[id_genre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[jambe]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jambe](
	[id_jambe] [int] IDENTITY(1,1) NOT NULL,
	[hauteur] [int] NOT NULL,
	[forme] [varchar](50) NOT NULL,
 CONSTRAINT [PK__jambe__27176089D69E8CF1] PRIMARY KEY CLUSTERED 
(
	[id_jambe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nez]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nez](
	[id_nez] [int] IDENTITY(1,1) NOT NULL,
	[hauteur] [int] NOT NULL,
	[largeur] [int] NOT NULL,
	[profondeur] [int] NOT NULL,
	[forme] [varchar](50) NOT NULL,
 CONSTRAINT [PK__nez__6E4E2EF71ABABC39] PRIMARY KEY CLUSTERED 
(
	[id_nez] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[personnage]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personnage](
	[id_personnage] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](50) NOT NULL,
	[age] [int] NOT NULL,
	[id_ethnie] [int] NOT NULL,
	[id_genre] [int] NOT NULL,
	[id_vbas] [int] NOT NULL,
	[id_vhaut] [int] NOT NULL,
	[id_corps] [int] NOT NULL,
 CONSTRAINT [PK__personna__CE0671E5D411CE5F] PRIMARY KEY CLUSTERED 
(
	[id_personnage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[personnage_accessoire]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personnage_accessoire](
	[id_personnage] [int] NOT NULL,
	[id_accessoire] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_personnage] ASC,
	[id_accessoire] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[personnage_arme]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personnage_arme](
	[id_personnage] [int] NOT NULL,
	[id_arme] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_personnage] ASC,
	[id_arme] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[personnage_bouclier]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personnage_bouclier](
	[id_personnage] [int] NOT NULL,
	[id_bouclier] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_personnage] ASC,
	[id_bouclier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[personnage_tatouage_position]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personnage_tatouage_position](
	[id_personnage] [int] NOT NULL,
	[id_position] [int] NOT NULL,
	[id_tatouage] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_personnage] ASC,
	[id_position] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[personnage_vmain]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personnage_vmain](
	[id_personnage] [int] NOT NULL,
	[id_vmain] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_personnage] ASC,
	[id_vmain] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[personnage_vpied]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personnage_vpied](
	[id_personnage] [int] NOT NULL,
	[id_vpied] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_personnage] ASC,
	[id_vpied] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[personnage_vtete]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personnage_vtete](
	[id_personnage] [int] NOT NULL,
	[id_vtete] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_personnage] ASC,
	[id_vtete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[position]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[position](
	[id_position] [int] IDENTITY(1,1) NOT NULL,
	[label] [varchar](50) NOT NULL,
 CONSTRAINT [PK__position__D652893D49A774D9] PRIMARY KEY CLUSTERED 
(
	[id_position] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tatouage]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tatouage](
	[id_tatouage] [int] IDENTITY(1,1) NOT NULL,
	[label] [varchar](50) NOT NULL,
 CONSTRAINT [PK__tatouage__9961409D687720D9] PRIMARY KEY CLUSTERED 
(
	[id_tatouage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tete]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tete](
	[id_tete] [int] IDENTITY(1,1) NOT NULL,
	[id_nez] [int] NOT NULL,
	[id_bouche] [int] NOT NULL,
	[id_yeux] [int] NOT NULL,
	[hauteur] [int] NOT NULL,
	[largeur] [int] NOT NULL,
	[forme] [varchar](50) NOT NULL,
 CONSTRAINT [PK__tete__C6D321992FE59EEC] PRIMARY KEY CLUSTERED 
(
	[id_tete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[texture]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[texture](
	[id_texture] [int] IDENTITY(1,1) NOT NULL,
	[label] [varchar](50) NOT NULL,
 CONSTRAINT [PK__texture__C786754C5FBAF69E] PRIMARY KEY CLUSTERED 
(
	[id_texture] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vbas]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vbas](
	[id_vbas] [int] IDENTITY(1,1) NOT NULL,
	[label] [varchar](50) NOT NULL,
	[poids] [int] NOT NULL,
	[id_texture] [int] NOT NULL,
	[id_couleur] [int] NOT NULL,
 CONSTRAINT [PK__vbas__501037889DD3A9E7] PRIMARY KEY CLUSTERED 
(
	[id_vbas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vhaut]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vhaut](
	[id_vhaut] [int] IDENTITY(1,1) NOT NULL,
	[label] [varchar](50) NOT NULL,
	[poids] [int] NOT NULL,
	[id_texture] [int] NOT NULL,
	[id_couleur] [int] NOT NULL,
 CONSTRAINT [PK__vhaut__231836E6FE711DE8] PRIMARY KEY CLUSTERED 
(
	[id_vhaut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vmain]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vmain](
	[id_vmain] [int] IDENTITY(1,1) NOT NULL,
	[label] [varchar](50) NOT NULL,
	[poids] [int] NOT NULL,
	[id_texture] [int] NOT NULL,
	[id_couleur] [int] NOT NULL,
 CONSTRAINT [PK__vmain__00B6C18FB9F01C91] PRIMARY KEY CLUSTERED 
(
	[id_vmain] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vpied]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vpied](
	[id_vpied] [int] IDENTITY(1,1) NOT NULL,
	[label] [varchar](50) NOT NULL,
	[poids] [int] NOT NULL,
	[id_texture] [int] NOT NULL,
	[id_couleur] [int] NOT NULL,
 CONSTRAINT [PK__vpied__E2A00DC81CCAF416] PRIMARY KEY CLUSTERED 
(
	[id_vpied] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vtete]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vtete](
	[id_vtete] [int] IDENTITY(1,1) NOT NULL,
	[label] [varchar](50) NOT NULL,
	[poids] [int] NOT NULL,
	[id_texture] [int] NOT NULL,
	[id_couleur] [int] NOT NULL,
 CONSTRAINT [PK__vtete__C2D5F31D8DAE91FE] PRIMARY KEY CLUSTERED 
(
	[id_vtete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[yeux]    Script Date: 21/04/2017 09:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[yeux](
	[id_yeux] [int] IDENTITY(1,1) NOT NULL,
	[forme] [varchar](50) NOT NULL,
	[hauteur] [int] NOT NULL,
	[largeur] [int] NOT NULL,
	[profondeur] [int] NOT NULL,
	[ecartement] [int] NOT NULL,
	[id_couleur] [int] NOT NULL,
 CONSTRAINT [PK__yeux__727E4217F448833F] PRIMARY KEY CLUSTERED 
(
	[id_yeux] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[accessoire] ON 

INSERT [dbo].[accessoire] ([id_accessoire], [label], [id_categorie_accessoire]) VALUES (1, N'Bracelet en argent', 1)
INSERT [dbo].[accessoire] ([id_accessoire], [label], [id_categorie_accessoire]) VALUES (3, N'Gourmette', 1)
SET IDENTITY_INSERT [dbo].[accessoire] OFF
SET IDENTITY_INSERT [dbo].[arme] ON 

INSERT [dbo].[arme] ([id_arme], [label], [poids], [id_categorie_arme]) VALUES (2, N'Colt 1911', 500, 13)
INSERT [dbo].[arme] ([id_arme], [label], [poids], [id_categorie_arme]) VALUES (3, N'Mauser 1914', 400, 13)
SET IDENTITY_INSERT [dbo].[arme] OFF
SET IDENTITY_INSERT [dbo].[bouche] ON 

INSERT [dbo].[bouche] ([id_bouche], [forme], [largeur], [hauteur], [profondeur], [id_couleur]) VALUES (3, N'Lèvres pincées', 5, 3, 2, 3)
INSERT [dbo].[bouche] ([id_bouche], [forme], [largeur], [hauteur], [profondeur], [id_couleur]) VALUES (4, N'Fine', 15, 10, 15, 5)
SET IDENTITY_INSERT [dbo].[bouche] OFF
SET IDENTITY_INSERT [dbo].[bouclier] ON 

INSERT [dbo].[bouclier] ([id_bouclier], [label], [poids]) VALUES (1, N'Bouclier de gladiateur', 500)
INSERT [dbo].[bouclier] ([id_bouclier], [label], [poids]) VALUES (3, N'Bouclier antiémeute', 150)
SET IDENTITY_INSERT [dbo].[bouclier] OFF
SET IDENTITY_INSERT [dbo].[bras] ON 

INSERT [dbo].[bras] ([id_bras], [longueur], [forme]) VALUES (2, 54, N'Musclé')
INSERT [dbo].[bras] ([id_bras], [longueur], [forme]) VALUES (4, 64, N'Fin')
SET IDENTITY_INSERT [dbo].[bras] OFF
SET IDENTITY_INSERT [dbo].[buste] ON 

INSERT [dbo].[buste] ([id_buste], [hauteur], [largeur], [corpulence]) VALUES (2, 54, 645, 320)
INSERT [dbo].[buste] ([id_buste], [hauteur], [largeur], [corpulence]) VALUES (4, 10, 5, 100)
SET IDENTITY_INSERT [dbo].[buste] OFF
SET IDENTITY_INSERT [dbo].[categorie_accessoire] ON 

INSERT [dbo].[categorie_accessoire] ([id_categorie_accessoire], [label]) VALUES (1, N'Bracelets')
INSERT [dbo].[categorie_accessoire] ([id_categorie_accessoire], [label]) VALUES (3, N'Colliers')
SET IDENTITY_INSERT [dbo].[categorie_accessoire] OFF
SET IDENTITY_INSERT [dbo].[categorie_arme] ON 

INSERT [dbo].[categorie_arme] ([id_categorie_arme], [categorie_arme]) VALUES (1, N'arme de mêlée')
INSERT [dbo].[categorie_arme] ([id_categorie_arme], [categorie_arme]) VALUES (2, N'arme lourde')
INSERT [dbo].[categorie_arme] ([id_categorie_arme], [categorie_arme]) VALUES (3, N'arme de contact')
INSERT [dbo].[categorie_arme] ([id_categorie_arme], [categorie_arme]) VALUES (4, N'arc')
INSERT [dbo].[categorie_arme] ([id_categorie_arme], [categorie_arme]) VALUES (5, N'arbalète')
INSERT [dbo].[categorie_arme] ([id_categorie_arme], [categorie_arme]) VALUES (6, N'sarbacane')
INSERT [dbo].[categorie_arme] ([id_categorie_arme], [categorie_arme]) VALUES (7, N'lance')
INSERT [dbo].[categorie_arme] ([id_categorie_arme], [categorie_arme]) VALUES (8, N'fusil')
INSERT [dbo].[categorie_arme] ([id_categorie_arme], [categorie_arme]) VALUES (9, N'bâton de jet')
INSERT [dbo].[categorie_arme] ([id_categorie_arme], [categorie_arme]) VALUES (10, N'sagaie')
INSERT [dbo].[categorie_arme] ([id_categorie_arme], [categorie_arme]) VALUES (11, N'arme de poing')
INSERT [dbo].[categorie_arme] ([id_categorie_arme], [categorie_arme]) VALUES (12, N'arme d''épaule')
INSERT [dbo].[categorie_arme] ([id_categorie_arme], [categorie_arme]) VALUES (13, N'Pistolet')
SET IDENTITY_INSERT [dbo].[categorie_arme] OFF
SET IDENTITY_INSERT [dbo].[corps] ON 

INSERT [dbo].[corps] ([id_corps], [id_bras], [id_jambe], [id_buste], [id_tete], [taille]) VALUES (2, 2, 2, 4, 2, 156)
INSERT [dbo].[corps] ([id_corps], [id_bras], [id_jambe], [id_buste], [id_tete], [taille]) VALUES (3, 4, 3, 4, 3, 180)
SET IDENTITY_INSERT [dbo].[corps] OFF
SET IDENTITY_INSERT [dbo].[couleur] ON 

INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (1, N'Abricot')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (2, N'Acajou')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (3, N'Aigue-marine')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (4, N'Alezan')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (5, N'Amande')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (6, N'Amarante')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (7, N'Ambre')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (8, N'Améthyste')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (9, N'Anthracite')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (10, N'Aquilain')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (11, N'Ardoise')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (12, N'Argent')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (13, N'Aubergine')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (14, N'Auburn')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (15, N'Aurore')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (16, N'Avocat')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (17, N'Azur')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (18, N'Baillet')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (19, N'Basané')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (20, N'Beige')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (21, N'Beurre')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (22, N'Bis')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (23, N'Bisque')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (24, N'Bistre')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (25, N'Bitume')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (26, N'Blanc')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (27, N'Blanc cassé')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (28, N'Blanc lunaire')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (29, N'Blé')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (30, N'Bleu acier')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (31, N'Bleu barbeau')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (32, N'Bleu canard')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (33, N'Bleu céleste')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (34, N'Bleu charrette')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (35, N'Bleu ciel')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (36, N'Bleu de cobalt')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (37, N'Bleu de Prusse')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (38, N'Bleu électrique')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (39, N'Bleu givré')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (40, N'Bleu Klein')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (41, N'Bleu Majorelle')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (42, N'Bleu marine')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (43, N'Bleu nuit')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (44, N'Bleu outremer')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (45, N'Bleu paon')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (46, N'Bleu Persan')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (47, N'Bleu pétrole')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (48, N'Bleu')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (49, N'Bleu roi')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (50, N'Bleu turquin')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (51, N'Blond vénitien')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (52, N'Blond')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (53, N'Bordeaux')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (54, N'Bouton d''or')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (55, N'Brique')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (56, N'Bronze')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (57, N'Brou de noix')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (58, N'Brun')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (59, N'Caca d''oie')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (60, N'Cacao')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (61, N'Cachou')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (62, N'Caeruleum')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (63, N'Café')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (64, N'Café au lait')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (65, N'Cannelle')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (66, N'Capucine')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (67, N'Caramel')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (68, N'Carmin')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (69, N'Carotte')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (70, N'Chamois')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (71, N'Chartreuse')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (72, N'Châtain')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (73, N'Chaudron')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (74, N'Chocolat')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (75, N'Cinabre')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (76, N'Citrouille')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (77, N'Coquille d''oeuf')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (78, N'Corail')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (79, N'Cramoisi')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (80, N'Crème')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (81, N'Cuisse de nymphe')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (82, N'Cuisse de nymphe émue')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (83, N'Cuivre')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (84, N'Cyan')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (85, N'Ecarlate')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (86, N'Ecru')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (87, N'Emeraude')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (88, N'Fauve')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (89, N'Flave')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (90, N'Fraise')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (91, N'Fraise écrasée')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (92, N'Framboise')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (93, N'Fuchsia')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (94, N'Fumée')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (95, N'Garance')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (96, N'Glauque')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (97, N'Glycine')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (98, N'Grège')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (99, N'Grenadine')
GO
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (100, N'Grenat')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (101, N'Gris')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (102, N'Gris acier')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (103, N'Gris de Payne')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (104, N'Gris fer')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (105, N'Gris perle')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (106, N'Groseille')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (107, N'Pastel des teinturiers')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (108, N'Gueules')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (109, N'Héliotrope')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (110, N'Incarnat')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (111, N'Indigo')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (112, N'Indigo (teinture)')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (113, N'Isabelle')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (114, N'Ivoire')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (115, N'Jaune de cobalt')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (116, N'Jaune canari')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (117, N'Jaune chartreuse')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (118, N'Jaune citron')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (119, N'Jaune d''or')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (120, N'Jaune de Mars')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (121, N'Jaune de Naples')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (122, N'Jaune impérial')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (123, N'Jaune mimosa')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (124, N'Kaki')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (125, N'Lapis-lazuli')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (126, N'Lavallière')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (127, N'Lavande')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (128, N'Lie de vin')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (129, N'Lilas')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (130, N'Lime')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (131, N'Lin')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (132, N'Magenta')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (133, N'Maïs')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (134, N'Malachite')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (135, N'Mandarine')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (136, N'Marron')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (137, N'Mastic')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (138, N'Mauve')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (139, N'Menthe')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (140, N'Moutarde')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (141, N'Nacarat')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (142, N'Nankin')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (143, N'Noir')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (144, N'Noir animal')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (145, N'Noir d''aniline')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (146, N'Noir d''ivoire')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (147, N'Noir de carbone')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (148, N'Noir de fumée')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (149, N'Noisette')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (150, N'Ocre')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (151, N'Ocre rouge')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (152, N'Olive')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (153, N'Or')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (154, N'Orange')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (155, N'Orange brûlé')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (156, N'Orchidée')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (157, N'Orpiment')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (158, N'Paille')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (159, N'Parme')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (160, N'Pelure d''oignon')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (161, N'Pervenche')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (162, N'Pistache')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (163, N'Poil de chameau')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (164, N'Coquelicot')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (165, N'Pourpre')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (166, N'Prasin')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (167, N'Prune')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (168, N'Puce')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (169, N'Rose')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (170, N'Rose Mountbatten')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (171, N'Rouge anglais')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (172, N'Rouge cardinal')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (173, N'Rouge cerise')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (174, N'Rouge d''alizarine')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (175, N'Rouge d''Andrinople')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (176, N'Rouge feu')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (177, N'Rouge de Falun')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (178, N'Rouge sang')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (179, N'Rouge tomette')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (180, N'Rouille')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (181, N'Roux')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (182, N'Rubis')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (183, N'Sable')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (184, N'Sable (héraldique)')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (185, N'Safre')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (186, N'Sang de boeuf')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (187, N'Sanguine')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (188, N'Saphir')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (189, N'Sarcelle')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (190, N'Saumon')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (191, N'Sépia')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (192, N'Sinople')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (193, N'Smalt')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (194, N'Smaragdin')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (195, N'Soufre')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (196, N'Souris')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (197, N'Tabac')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (198, N'Taupe')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (199, N'Terre d''ombre')
GO
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (200, N'Terre de Sienne')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (201, N'Terre de Sienne brûlée')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (202, N'Tomate')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (203, N'Topaze')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (204, N'Tourterelle')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (205, N'Turquoise')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (206, N'Vanille')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (207, N'Vermeil')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (208, N'Vermillon')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (209, N'Vert')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (210, N'Vert armée')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (211, N'Vert bouteille')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (212, N'Vert céladon')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (213, N'Vert chartreuse')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (214, N'Vert d''eau')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (215, N'Vert de chrome')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (216, N'Vert-de-gris')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (217, N'Vert de Hooker')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (218, N'Vert de vessie')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (219, N'Vert épinard')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (220, N'Vert gazon')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (221, N'Vert impérial')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (222, N'Vert lichen')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (223, N'Vert mélèze')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (224, N'Vert mousse')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (225, N'Vert perroquet')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (226, N'Vert poireau')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (227, N'Vert pomme')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (228, N'Vert prairie')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (229, N'Vert printemps')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (230, N'Vert sapin')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (231, N'Vert sauge')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (232, N'Vert tilleul')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (233, N'Vert Véronèse')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (234, N'Violet')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (235, N'Violet d''évêque')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (236, N'Violine')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (237, N'Viride')
INSERT [dbo].[couleur] ([id_couleur], [label]) VALUES (238, N'Zinzolin')
SET IDENTITY_INSERT [dbo].[couleur] OFF
SET IDENTITY_INSERT [dbo].[ethnie] ON 

INSERT [dbo].[ethnie] ([id_ethnie], [label]) VALUES (1, N'Amérindien')
INSERT [dbo].[ethnie] ([id_ethnie], [label]) VALUES (2, N'Aborigènes d''Australie')
INSERT [dbo].[ethnie] ([id_ethnie], [label]) VALUES (3, N'Afro-américain')
INSERT [dbo].[ethnie] ([id_ethnie], [label]) VALUES (4, N'Apache')
INSERT [dbo].[ethnie] ([id_ethnie], [label]) VALUES (5, N'Catalan')
INSERT [dbo].[ethnie] ([id_ethnie], [label]) VALUES (6, N'Celte')
INSERT [dbo].[ethnie] ([id_ethnie], [label]) VALUES (7, N'Chinois Han')
INSERT [dbo].[ethnie] ([id_ethnie], [label]) VALUES (8, N'Germain')
INSERT [dbo].[ethnie] ([id_ethnie], [label]) VALUES (9, N'Indiens')
INSERT [dbo].[ethnie] ([id_ethnie], [label]) VALUES (10, N'Enseignant')
SET IDENTITY_INSERT [dbo].[ethnie] OFF
SET IDENTITY_INSERT [dbo].[genre] ON 

INSERT [dbo].[genre] ([id_genre], [label]) VALUES (1, N'Féminin')
INSERT [dbo].[genre] ([id_genre], [label]) VALUES (2, N'Masculin')
INSERT [dbo].[genre] ([id_genre], [label]) VALUES (3, N'Autre')
SET IDENTITY_INSERT [dbo].[genre] OFF
SET IDENTITY_INSERT [dbo].[jambe] ON 

INSERT [dbo].[jambe] ([id_jambe], [hauteur], [forme]) VALUES (2, 80, N'Ronde')
INSERT [dbo].[jambe] ([id_jambe], [hauteur], [forme]) VALUES (3, 75, N'Musclée')
SET IDENTITY_INSERT [dbo].[jambe] OFF
SET IDENTITY_INSERT [dbo].[nez] ON 

INSERT [dbo].[nez] ([id_nez], [hauteur], [largeur], [profondeur], [forme]) VALUES (2, 3, 6, 2, N'Pointu')
INSERT [dbo].[nez] ([id_nez], [hauteur], [largeur], [profondeur], [forme]) VALUES (3, 10, 7, 5, N'Rond')
SET IDENTITY_INSERT [dbo].[nez] OFF
SET IDENTITY_INSERT [dbo].[personnage] ON 

INSERT [dbo].[personnage] ([id_personnage], [nom], [age], [id_ethnie], [id_genre], [id_vbas], [id_vhaut], [id_corps]) VALUES (1, N'Paul', 15, 1, 3, 1, 1, 2)
INSERT [dbo].[personnage] ([id_personnage], [nom], [age], [id_ethnie], [id_genre], [id_vbas], [id_vhaut], [id_corps]) VALUES (2, N'Aymen Sioud', 666, 10, 2, 1, 2, 3)
SET IDENTITY_INSERT [dbo].[personnage] OFF
INSERT [dbo].[personnage_accessoire] ([id_personnage], [id_accessoire]) VALUES (1, 3)
INSERT [dbo].[personnage_accessoire] ([id_personnage], [id_accessoire]) VALUES (2, 3)
INSERT [dbo].[personnage_arme] ([id_personnage], [id_arme]) VALUES (1, 2)
INSERT [dbo].[personnage_arme] ([id_personnage], [id_arme]) VALUES (2, 2)
INSERT [dbo].[personnage_bouclier] ([id_personnage], [id_bouclier]) VALUES (2, 3)
INSERT [dbo].[personnage_vmain] ([id_personnage], [id_vmain]) VALUES (2, 1)
INSERT [dbo].[personnage_vpied] ([id_personnage], [id_vpied]) VALUES (2, 1)
SET IDENTITY_INSERT [dbo].[tete] ON 

INSERT [dbo].[tete] ([id_tete], [id_nez], [id_bouche], [id_yeux], [hauteur], [largeur], [forme]) VALUES (2, 2, 3, 2, 50, 30, N'Carrée')
INSERT [dbo].[tete] ([id_tete], [id_nez], [id_bouche], [id_yeux], [hauteur], [largeur], [forme]) VALUES (3, 2, 3, 2, 16, 15, N'Ovale')
SET IDENTITY_INSERT [dbo].[tete] OFF
SET IDENTITY_INSERT [dbo].[texture] ON 

INSERT [dbo].[texture] ([id_texture], [label]) VALUES (1, N'Polyester')
INSERT [dbo].[texture] ([id_texture], [label]) VALUES (2, N'Jute')
INSERT [dbo].[texture] ([id_texture], [label]) VALUES (3, N'Lin')
INSERT [dbo].[texture] ([id_texture], [label]) VALUES (4, N'Velour')
INSERT [dbo].[texture] ([id_texture], [label]) VALUES (5, N'Acrylique')
INSERT [dbo].[texture] ([id_texture], [label]) VALUES (6, N'Elasthane')
INSERT [dbo].[texture] ([id_texture], [label]) VALUES (7, N'Laine')
INSERT [dbo].[texture] ([id_texture], [label]) VALUES (8, N'Cuir souple')
INSERT [dbo].[texture] ([id_texture], [label]) VALUES (9, N'Soie')
INSERT [dbo].[texture] ([id_texture], [label]) VALUES (10, N'Coton')
INSERT [dbo].[texture] ([id_texture], [label]) VALUES (11, N'Cuir rigide')
INSERT [dbo].[texture] ([id_texture], [label]) VALUES (12, N'Bois')
INSERT [dbo].[texture] ([id_texture], [label]) VALUES (13, N'Bambou')
INSERT [dbo].[texture] ([id_texture], [label]) VALUES (14, N'Acier')
INSERT [dbo].[texture] ([id_texture], [label]) VALUES (15, N'Os')
INSERT [dbo].[texture] ([id_texture], [label]) VALUES (16, N'Métal')
INSERT [dbo].[texture] ([id_texture], [label]) VALUES (18, N'Jean')
SET IDENTITY_INSERT [dbo].[texture] OFF
SET IDENTITY_INSERT [dbo].[vbas] ON 

INSERT [dbo].[vbas] ([id_vbas], [label], [poids], [id_texture], [id_couleur]) VALUES (1, N'Jean', 200, 18, 6)
INSERT [dbo].[vbas] ([id_vbas], [label], [poids], [id_texture], [id_couleur]) VALUES (3, N'Robe', 150, 9, 156)
SET IDENTITY_INSERT [dbo].[vbas] OFF
SET IDENTITY_INSERT [dbo].[vhaut] ON 

INSERT [dbo].[vhaut] ([id_vhaut], [label], [poids], [id_texture], [id_couleur]) VALUES (1, N'T-shirt', 150, 5, 10)
INSERT [dbo].[vhaut] ([id_vhaut], [label], [poids], [id_texture], [id_couleur]) VALUES (2, N'pull bleu ', 20, 5, 43)
SET IDENTITY_INSERT [dbo].[vhaut] OFF
SET IDENTITY_INSERT [dbo].[vmain] ON 

INSERT [dbo].[vmain] ([id_vmain], [label], [poids], [id_texture], [id_couleur]) VALUES (1, N'Gants', 300, 7, 100)
SET IDENTITY_INSERT [dbo].[vmain] OFF
SET IDENTITY_INSERT [dbo].[vpied] ON 

INSERT [dbo].[vpied] ([id_vpied], [label], [poids], [id_texture], [id_couleur]) VALUES (1, N'Bottes', 500, 4, 60)
SET IDENTITY_INSERT [dbo].[vpied] OFF
SET IDENTITY_INSERT [dbo].[vtete] ON 

INSERT [dbo].[vtete] ([id_vtete], [label], [poids], [id_texture], [id_couleur]) VALUES (1, N'Chapeau melon', 150, 9, 70)
SET IDENTITY_INSERT [dbo].[vtete] OFF
SET IDENTITY_INSERT [dbo].[yeux] ON 

INSERT [dbo].[yeux] ([id_yeux], [forme], [hauteur], [largeur], [profondeur], [ecartement], [id_couleur]) VALUES (2, N'En amande', 3, 2, 4, 5, 3)
INSERT [dbo].[yeux] ([id_yeux], [forme], [hauteur], [largeur], [profondeur], [ecartement], [id_couleur]) VALUES (3, N'Ronde', 5, 5, 4, 2, 65)
SET IDENTITY_INSERT [dbo].[yeux] OFF
ALTER TABLE [dbo].[accessoire]  WITH CHECK ADD  CONSTRAINT [FK_accessoire_categorie_accessoire] FOREIGN KEY([id_categorie_accessoire])
REFERENCES [dbo].[categorie_accessoire] ([id_categorie_accessoire])
GO
ALTER TABLE [dbo].[accessoire] CHECK CONSTRAINT [FK_accessoire_categorie_accessoire]
GO
ALTER TABLE [dbo].[arme]  WITH CHECK ADD  CONSTRAINT [FK_arme_categorie_arme] FOREIGN KEY([id_categorie_arme])
REFERENCES [dbo].[categorie_arme] ([id_categorie_arme])
GO
ALTER TABLE [dbo].[arme] CHECK CONSTRAINT [FK_arme_categorie_arme]
GO
ALTER TABLE [dbo].[bouche]  WITH CHECK ADD  CONSTRAINT [FK_bouche_couleur] FOREIGN KEY([id_couleur])
REFERENCES [dbo].[couleur] ([id_couleur])
GO
ALTER TABLE [dbo].[bouche] CHECK CONSTRAINT [FK_bouche_couleur]
GO
ALTER TABLE [dbo].[corps]  WITH CHECK ADD  CONSTRAINT [FK_corps_bras] FOREIGN KEY([id_bras])
REFERENCES [dbo].[bras] ([id_bras])
GO
ALTER TABLE [dbo].[corps] CHECK CONSTRAINT [FK_corps_bras]
GO
ALTER TABLE [dbo].[corps]  WITH CHECK ADD  CONSTRAINT [FK_corps_buste] FOREIGN KEY([id_buste])
REFERENCES [dbo].[buste] ([id_buste])
GO
ALTER TABLE [dbo].[corps] CHECK CONSTRAINT [FK_corps_buste]
GO
ALTER TABLE [dbo].[corps]  WITH CHECK ADD  CONSTRAINT [FK_corps_jambe] FOREIGN KEY([id_jambe])
REFERENCES [dbo].[jambe] ([id_jambe])
GO
ALTER TABLE [dbo].[corps] CHECK CONSTRAINT [FK_corps_jambe]
GO
ALTER TABLE [dbo].[corps]  WITH CHECK ADD  CONSTRAINT [FK_corps_tete] FOREIGN KEY([id_tete])
REFERENCES [dbo].[tete] ([id_tete])
GO
ALTER TABLE [dbo].[corps] CHECK CONSTRAINT [FK_corps_tete]
GO
ALTER TABLE [dbo].[personnage]  WITH CHECK ADD  CONSTRAINT [FK_personnage_corps] FOREIGN KEY([id_corps])
REFERENCES [dbo].[corps] ([id_corps])
GO
ALTER TABLE [dbo].[personnage] CHECK CONSTRAINT [FK_personnage_corps]
GO
ALTER TABLE [dbo].[personnage]  WITH CHECK ADD  CONSTRAINT [FK_personnage_ethnie] FOREIGN KEY([id_ethnie])
REFERENCES [dbo].[ethnie] ([id_ethnie])
GO
ALTER TABLE [dbo].[personnage] CHECK CONSTRAINT [FK_personnage_ethnie]
GO
ALTER TABLE [dbo].[personnage]  WITH CHECK ADD  CONSTRAINT [FK_personnage_genre] FOREIGN KEY([id_genre])
REFERENCES [dbo].[genre] ([id_genre])
GO
ALTER TABLE [dbo].[personnage] CHECK CONSTRAINT [FK_personnage_genre]
GO
ALTER TABLE [dbo].[personnage]  WITH CHECK ADD  CONSTRAINT [FK_personnage_vbas] FOREIGN KEY([id_vbas])
REFERENCES [dbo].[vbas] ([id_vbas])
GO
ALTER TABLE [dbo].[personnage] CHECK CONSTRAINT [FK_personnage_vbas]
GO
ALTER TABLE [dbo].[personnage]  WITH CHECK ADD  CONSTRAINT [FK_personnage_vhaut] FOREIGN KEY([id_vhaut])
REFERENCES [dbo].[vhaut] ([id_vhaut])
GO
ALTER TABLE [dbo].[personnage] CHECK CONSTRAINT [FK_personnage_vhaut]
GO
ALTER TABLE [dbo].[personnage_accessoire]  WITH CHECK ADD  CONSTRAINT [FK_personnage_accessoire_accessoire] FOREIGN KEY([id_accessoire])
REFERENCES [dbo].[accessoire] ([id_accessoire])
GO
ALTER TABLE [dbo].[personnage_accessoire] CHECK CONSTRAINT [FK_personnage_accessoire_accessoire]
GO
ALTER TABLE [dbo].[personnage_accessoire]  WITH CHECK ADD  CONSTRAINT [FK_personnage_accessoire_personnage] FOREIGN KEY([id_personnage])
REFERENCES [dbo].[personnage] ([id_personnage])
GO
ALTER TABLE [dbo].[personnage_accessoire] CHECK CONSTRAINT [FK_personnage_accessoire_personnage]
GO
ALTER TABLE [dbo].[personnage_arme]  WITH CHECK ADD  CONSTRAINT [FK_personnage_arme_arme] FOREIGN KEY([id_arme])
REFERENCES [dbo].[arme] ([id_arme])
GO
ALTER TABLE [dbo].[personnage_arme] CHECK CONSTRAINT [FK_personnage_arme_arme]
GO
ALTER TABLE [dbo].[personnage_arme]  WITH CHECK ADD  CONSTRAINT [FK_personnage_arme_personnage] FOREIGN KEY([id_personnage])
REFERENCES [dbo].[personnage] ([id_personnage])
GO
ALTER TABLE [dbo].[personnage_arme] CHECK CONSTRAINT [FK_personnage_arme_personnage]
GO
ALTER TABLE [dbo].[personnage_bouclier]  WITH CHECK ADD  CONSTRAINT [FK_personnage_bouclier_bouclier] FOREIGN KEY([id_bouclier])
REFERENCES [dbo].[bouclier] ([id_bouclier])
GO
ALTER TABLE [dbo].[personnage_bouclier] CHECK CONSTRAINT [FK_personnage_bouclier_bouclier]
GO
ALTER TABLE [dbo].[personnage_bouclier]  WITH CHECK ADD  CONSTRAINT [FK_personnage_bouclier_personnage] FOREIGN KEY([id_personnage])
REFERENCES [dbo].[personnage] ([id_personnage])
GO
ALTER TABLE [dbo].[personnage_bouclier] CHECK CONSTRAINT [FK_personnage_bouclier_personnage]
GO
ALTER TABLE [dbo].[personnage_tatouage_position]  WITH CHECK ADD  CONSTRAINT [FK_personnage_tatouage_position_personnage] FOREIGN KEY([id_personnage])
REFERENCES [dbo].[personnage] ([id_personnage])
GO
ALTER TABLE [dbo].[personnage_tatouage_position] CHECK CONSTRAINT [FK_personnage_tatouage_position_personnage]
GO
ALTER TABLE [dbo].[personnage_tatouage_position]  WITH CHECK ADD  CONSTRAINT [FK_personnage_tatouage_position_position] FOREIGN KEY([id_position])
REFERENCES [dbo].[position] ([id_position])
GO
ALTER TABLE [dbo].[personnage_tatouage_position] CHECK CONSTRAINT [FK_personnage_tatouage_position_position]
GO
ALTER TABLE [dbo].[personnage_tatouage_position]  WITH CHECK ADD  CONSTRAINT [FK_personnage_tatouage_position_tatouage] FOREIGN KEY([id_tatouage])
REFERENCES [dbo].[tatouage] ([id_tatouage])
GO
ALTER TABLE [dbo].[personnage_tatouage_position] CHECK CONSTRAINT [FK_personnage_tatouage_position_tatouage]
GO
ALTER TABLE [dbo].[personnage_vmain]  WITH CHECK ADD  CONSTRAINT [FK_personnage_vmain_personnage] FOREIGN KEY([id_personnage])
REFERENCES [dbo].[personnage] ([id_personnage])
GO
ALTER TABLE [dbo].[personnage_vmain] CHECK CONSTRAINT [FK_personnage_vmain_personnage]
GO
ALTER TABLE [dbo].[personnage_vmain]  WITH CHECK ADD  CONSTRAINT [FK_personnage_vmain_vmain] FOREIGN KEY([id_vmain])
REFERENCES [dbo].[vmain] ([id_vmain])
GO
ALTER TABLE [dbo].[personnage_vmain] CHECK CONSTRAINT [FK_personnage_vmain_vmain]
GO
ALTER TABLE [dbo].[personnage_vpied]  WITH CHECK ADD  CONSTRAINT [FK_personnage_vpied_personnage] FOREIGN KEY([id_personnage])
REFERENCES [dbo].[personnage] ([id_personnage])
GO
ALTER TABLE [dbo].[personnage_vpied] CHECK CONSTRAINT [FK_personnage_vpied_personnage]
GO
ALTER TABLE [dbo].[personnage_vpied]  WITH CHECK ADD  CONSTRAINT [FK_personnage_vpied_vpied] FOREIGN KEY([id_vpied])
REFERENCES [dbo].[vpied] ([id_vpied])
GO
ALTER TABLE [dbo].[personnage_vpied] CHECK CONSTRAINT [FK_personnage_vpied_vpied]
GO
ALTER TABLE [dbo].[personnage_vtete]  WITH CHECK ADD  CONSTRAINT [FK_personnage_vtete_personnage] FOREIGN KEY([id_personnage])
REFERENCES [dbo].[personnage] ([id_personnage])
GO
ALTER TABLE [dbo].[personnage_vtete] CHECK CONSTRAINT [FK_personnage_vtete_personnage]
GO
ALTER TABLE [dbo].[personnage_vtete]  WITH CHECK ADD  CONSTRAINT [FK_personnage_vtete_vtete] FOREIGN KEY([id_vtete])
REFERENCES [dbo].[vtete] ([id_vtete])
GO
ALTER TABLE [dbo].[personnage_vtete] CHECK CONSTRAINT [FK_personnage_vtete_vtete]
GO
ALTER TABLE [dbo].[tete]  WITH CHECK ADD  CONSTRAINT [FK_tete_bouche] FOREIGN KEY([id_bouche])
REFERENCES [dbo].[bouche] ([id_bouche])
GO
ALTER TABLE [dbo].[tete] CHECK CONSTRAINT [FK_tete_bouche]
GO
ALTER TABLE [dbo].[tete]  WITH CHECK ADD  CONSTRAINT [FK_tete_nez] FOREIGN KEY([id_nez])
REFERENCES [dbo].[nez] ([id_nez])
GO
ALTER TABLE [dbo].[tete] CHECK CONSTRAINT [FK_tete_nez]
GO
ALTER TABLE [dbo].[tete]  WITH CHECK ADD  CONSTRAINT [FK_tete_yeux] FOREIGN KEY([id_yeux])
REFERENCES [dbo].[yeux] ([id_yeux])
GO
ALTER TABLE [dbo].[tete] CHECK CONSTRAINT [FK_tete_yeux]
GO
ALTER TABLE [dbo].[vbas]  WITH CHECK ADD  CONSTRAINT [FK_vbas_couleur] FOREIGN KEY([id_couleur])
REFERENCES [dbo].[couleur] ([id_couleur])
GO
ALTER TABLE [dbo].[vbas] CHECK CONSTRAINT [FK_vbas_couleur]
GO
ALTER TABLE [dbo].[vbas]  WITH CHECK ADD  CONSTRAINT [FK_vbas_texture] FOREIGN KEY([id_texture])
REFERENCES [dbo].[texture] ([id_texture])
GO
ALTER TABLE [dbo].[vbas] CHECK CONSTRAINT [FK_vbas_texture]
GO
ALTER TABLE [dbo].[vhaut]  WITH CHECK ADD  CONSTRAINT [FK_vhaut_couleur] FOREIGN KEY([id_couleur])
REFERENCES [dbo].[couleur] ([id_couleur])
GO
ALTER TABLE [dbo].[vhaut] CHECK CONSTRAINT [FK_vhaut_couleur]
GO
ALTER TABLE [dbo].[vhaut]  WITH CHECK ADD  CONSTRAINT [FK_vhaut_texture] FOREIGN KEY([id_texture])
REFERENCES [dbo].[texture] ([id_texture])
GO
ALTER TABLE [dbo].[vhaut] CHECK CONSTRAINT [FK_vhaut_texture]
GO
ALTER TABLE [dbo].[vmain]  WITH CHECK ADD  CONSTRAINT [FK_vmain_couleur] FOREIGN KEY([id_couleur])
REFERENCES [dbo].[couleur] ([id_couleur])
GO
ALTER TABLE [dbo].[vmain] CHECK CONSTRAINT [FK_vmain_couleur]
GO
ALTER TABLE [dbo].[vmain]  WITH CHECK ADD  CONSTRAINT [FK_vmain_texture] FOREIGN KEY([id_texture])
REFERENCES [dbo].[texture] ([id_texture])
GO
ALTER TABLE [dbo].[vmain] CHECK CONSTRAINT [FK_vmain_texture]
GO
ALTER TABLE [dbo].[vpied]  WITH CHECK ADD  CONSTRAINT [FK_vpied_couleur] FOREIGN KEY([id_couleur])
REFERENCES [dbo].[couleur] ([id_couleur])
GO
ALTER TABLE [dbo].[vpied] CHECK CONSTRAINT [FK_vpied_couleur]
GO
ALTER TABLE [dbo].[vpied]  WITH CHECK ADD  CONSTRAINT [FK_vpied_texture] FOREIGN KEY([id_texture])
REFERENCES [dbo].[texture] ([id_texture])
GO
ALTER TABLE [dbo].[vpied] CHECK CONSTRAINT [FK_vpied_texture]
GO
ALTER TABLE [dbo].[vtete]  WITH CHECK ADD  CONSTRAINT [FK_vtete_couleur] FOREIGN KEY([id_couleur])
REFERENCES [dbo].[couleur] ([id_couleur])
GO
ALTER TABLE [dbo].[vtete] CHECK CONSTRAINT [FK_vtete_couleur]
GO
ALTER TABLE [dbo].[vtete]  WITH CHECK ADD  CONSTRAINT [FK_vtete_texture] FOREIGN KEY([id_texture])
REFERENCES [dbo].[texture] ([id_texture])
GO
ALTER TABLE [dbo].[vtete] CHECK CONSTRAINT [FK_vtete_texture]
GO
ALTER TABLE [dbo].[yeux]  WITH CHECK ADD  CONSTRAINT [FK_yeux_couleur] FOREIGN KEY([id_couleur])
REFERENCES [dbo].[couleur] ([id_couleur])
GO
ALTER TABLE [dbo].[yeux] CHECK CONSTRAINT [FK_yeux_couleur]
GO
USE [master]
GO
ALTER DATABASE [pimp_your_character] SET  READ_WRITE 
GO
