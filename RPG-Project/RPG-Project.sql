USE [master]
GO
/****** Object:  Database [RPG-Project]    Script Date: 05/07/2016 10:29:44 ******/
CREATE DATABASE [RPG-Project]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RPG-Project', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\RPG-Project.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RPG-Project_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\RPG-Project_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RPG-Project] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RPG-Project].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RPG-Project] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RPG-Project] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RPG-Project] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RPG-Project] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RPG-Project] SET ARITHABORT OFF 
GO
ALTER DATABASE [RPG-Project] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RPG-Project] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RPG-Project] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RPG-Project] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RPG-Project] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RPG-Project] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RPG-Project] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RPG-Project] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RPG-Project] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RPG-Project] SET  ENABLE_BROKER 
GO
ALTER DATABASE [RPG-Project] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RPG-Project] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RPG-Project] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RPG-Project] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RPG-Project] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RPG-Project] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RPG-Project] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RPG-Project] SET RECOVERY FULL 
GO
ALTER DATABASE [RPG-Project] SET  MULTI_USER 
GO
ALTER DATABASE [RPG-Project] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RPG-Project] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RPG-Project] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RPG-Project] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RPG-Project] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'RPG-Project', N'ON'
GO
ALTER DATABASE [RPG-Project] SET QUERY_STORE = OFF
GO
USE [RPG-Project]
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
USE [RPG-Project]
GO
/****** Object:  Table [dbo].[State]    Script Date: 05/07/2016 10:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[State](
	[id_state] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED 
(
	[id_state] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User1]    Script Date: 05/07/2016 10:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User1](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [varchar](50) NOT NULL,
	[id_character] [int] NULL,
	[password] [varchar](20) NOT NULL,
	[id_state] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[user2]    Script Date: 05/07/2016 10:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[user2] as
select u.id_user as 'ID', u.user_name as 'Usuario', u.password, s.id_state, s.name as 'Estado'
from User1 as u
inner join State as s on u.id_State = s.id_State


GO
/****** Object:  Table [dbo].[Attack]    Script Date: 05/07/2016 10:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attack](
	[id_attack] [int] IDENTITY(1,1) NOT NULL,
	[id_type] [int] NOT NULL,
	[attack_name] [varchar](50) NOT NULL,
	[coste] [int] NOT NULL,
	[daño] [int] NOT NULL,
 CONSTRAINT [PK_Attack] PRIMARY KEY CLUSTERED 
(
	[id_attack] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AttackCharacter]    Script Date: 05/07/2016 10:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttackCharacter](
	[id_character] [int] NOT NULL,
	[id_attack] [int] NOT NULL,
	[id_AC] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_AttackCharacter] PRIMARY KEY CLUSTERED 
(
	[id_AC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Character]    Script Date: 05/07/2016 10:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Character](
	[id_character] [int] IDENTITY(1,1) NOT NULL,
	[character_name] [varchar](50) NOT NULL,
	[id_type] [int] NOT NULL,
	[life] [int] NOT NULL,
	[stamina] [int] NOT NULL,
	[exp] [int] NOT NULL,
	[lvl] [int] NOT NULL,
	[gold] [int] NOT NULL,
 CONSTRAINT [PK_Character] PRIMARY KEY CLUSTERED 
(
	[id_character] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[vAt_Characters]    Script Date: 05/07/2016 10:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vAt_Characters] as
select a.id_attack, a.attack_name, c.id_character
from AttackCharacter as ac 
inner join Character as c on c.id_character = ac.id_character
inner join Attack as a on a.id_attack = ac.id_attack


GO
/****** Object:  Table [dbo].[Type]    Script Date: 05/07/2016 10:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[id_type] [int] IDENTITY(1,1) NOT NULL,
	[type_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[id_type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[vAtaques]    Script Date: 05/07/2016 10:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vAtaques] as
select a.id_attack, a.attack_name as 'Ataques', t.id_type, t.type_name as 'Tipo', a.coste as 'Coste', a.daño as 'Daño'
from Attack as a
inner join Type as t on a.id_type = t.id_type


GO
/****** Object:  Table [dbo].[Block_GM]    Script Date: 05/07/2016 10:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Block_GM](
	[id_block] [int] IDENTITY(1,1) NOT NULL,
	[reason] [varchar](50) NOT NULL,
	[blockDate] [date] NOT NULL,
	[id_gameM] [int] NOT NULL,
 CONSTRAINT [PK_Block_GM] PRIMARY KEY CLUSTERED 
(
	[id_block] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[gameMaster]    Script Date: 05/07/2016 10:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gameMaster](
	[id_gameM] [int] NOT NULL,
	[nameGM] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[GM_code] [varchar](50) NOT NULL,
	[id_state] [int] NULL,
 CONSTRAINT [PK_gameMaster] PRIMARY KEY CLUSTERED 
(
	[id_gameM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[vBlocks_GM]    Script Date: 05/07/2016 10:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vBlocks_GM] as
select b.id_block, b.reason as 'Motivo', b.blockDate as 'Fecha de Bloqueo',
b.id_gameM, g.nameGM as 'Nombre'
from Block_GM as b
inner join gameMaster as g on g.id_gameM = b.id_gameM


GO
/****** Object:  Table [dbo].[Block_User]    Script Date: 05/07/2016 10:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Block_User](
	[id_block] [int] IDENTITY(1,1) NOT NULL,
	[reason] [varchar](50) NOT NULL,
	[blockDate] [date] NOT NULL,
	[id_user] [int] NULL,
 CONSTRAINT [PK_BlocksNBans] PRIMARY KEY CLUSTERED 
(
	[id_block] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[vBlocks_User]    Script Date: 05/07/2016 10:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vBlocks_User] as
select b.id_block, b.reason as 'Motivo', b.blockDate as 'Fecha de Bloqueo',
b.id_user, u.user_name as 'Nombre'
from Block_User as b
inner join User1 as u on u.id_user = b.id_user


GO
/****** Object:  View [dbo].[vChars]    Script Date: 05/07/2016 10:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vChars]
AS
SELECT     c.id_character, c.character_name AS Personaje, c.id_type, t.type_name AS Tipo, c.life AS Vida, c.stamina AS Energia, c.exp AS Experiencia, c.lvl AS Nivel, c.gold AS [Pix-Dolares]
FROM         dbo.Character AS c INNER JOIN
                      dbo.Type AS t ON t.id_type = c.id_type


GO
/****** Object:  View [dbo].[vUser]    Script Date: 05/07/2016 10:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vUser] as
select u.id_user, u.user_name, u.password, u.id_state, s.name, u.id_character, c.character_name, c.id_type, t.type_name, c.lvl
from User1 as u
inner join Character as c on u.id_character = c.id_character
inner join State as s on u.id_state = s.id_state
inner join Type as t on c.id_type = t.id_type


GO
/****** Object:  Table [dbo].[AproxLevel]    Script Date: 05/07/2016 10:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AproxLevel](
	[id_level] [int] IDENTITY(1,1) NOT NULL,
	[char_level] [int] NULL,
	[enemy_level] [int] NULL,
 CONSTRAINT [PK_AproxLevel] PRIMARY KEY CLUSTERED 
(
	[id_level] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Enemy_Attacks]    Script Date: 05/07/2016 10:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enemy_Attacks](
	[id_attack] [int] IDENTITY(1,1) NOT NULL,
	[attack_name] [varchar](50) NOT NULL,
	[daño] [int] NOT NULL,
 CONSTRAINT [PK_NPC_Attacks] PRIMARY KEY CLUSTERED 
(
	[id_attack] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ItemCharacter]    Script Date: 05/07/2016 10:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemCharacter](
	[id_item] [int] NOT NULL,
	[id_character] [int] NOT NULL,
	[id_IC] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Items]    Script Date: 05/07/2016 10:29:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[id_item] [int] IDENTITY(1,1) NOT NULL,
	[item_name] [varchar](50) NOT NULL,
	[id_type] [int] NOT NULL,
	[price] [int] NOT NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[id_item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Logs_GM]    Script Date: 05/07/2016 10:29:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs_GM](
	[id_log] [int] IDENTITY(1,1) NOT NULL,
	[logDate] [date] NOT NULL,
	[id_gameM] [int] NOT NULL,
 CONSTRAINT [PK_Logs_GM] PRIMARY KEY CLUSTERED 
(
	[id_log] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Logs_User]    Script Date: 05/07/2016 10:29:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs_User](
	[id_log] [int] IDENTITY(1,1) NOT NULL,
	[logDate] [date] NOT NULL,
	[id_user] [int] NULL,
 CONSTRAINT [PK_Logs] PRIMARY KEY CLUSTERED 
(
	[id_log] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Monster]    Script Date: 05/07/2016 10:29:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Monster](
	[id_monster] [int] IDENTITY(1,1) NOT NULL,
	[monster_name] [varchar](50) NOT NULL,
	[monster_power] [int] NOT NULL,
	[monster_level] [int] NOT NULL,
 CONSTRAINT [PK_Monster] PRIMARY KEY CLUSTERED 
(
	[id_monster] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MonsterAttack]    Script Date: 05/07/2016 10:29:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonsterAttack](
	[id_monster] [int] NOT NULL,
	[id_attack] [int] NOT NULL,
 CONSTRAINT [PK_MonsterAttack] PRIMARY KEY CLUSTERED 
(
	[id_monster] ASC,
	[id_attack] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NPC]    Script Date: 05/07/2016 10:29:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NPC](
	[id_npc] [int] IDENTITY(1,1) NOT NULL,
	[npc_name] [varchar](50) NOT NULL,
	[npc_power] [int] NOT NULL,
	[npc_level] [int] NOT NULL,
 CONSTRAINT [PK_NPC] PRIMARY KEY CLUSTERED 
(
	[id_npc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NpcAttack]    Script Date: 05/07/2016 10:29:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NpcAttack](
	[id_npc] [int] NOT NULL,
	[id_attack] [int] NOT NULL,
 CONSTRAINT [PK_NpcAttack] PRIMARY KEY CLUSTERED 
(
	[id_npc] ASC,
	[id_attack] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PvP]    Script Date: 05/07/2016 10:29:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PvP](
	[id_pvp] [int] IDENTITY(1,1) NOT NULL,
	[id_char1] [int] NOT NULL,
	[id_char2] [int] NULL,
	[resultado] [varchar](50) NULL,
	[fecha] [date] NULL,
	[OnLine] [int] NULL,
 CONSTRAINT [PK_PvP] PRIMARY KEY CLUSTERED 
(
	[id_pvp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Attack] ON 

INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (1, 1, N'Estocada', 5, 25)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (2, 1, N'Corte', 5, 25)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (3, 1, N'Filo de Piedra', 10, 30)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (4, 1, N'Acero Hirviente', 10, 30)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (5, 1, N'Hoja brillante', 15, 35)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (6, 1, N'Puñalah', 15, 35)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (7, 1, N'Puño de Hierro', 20, 40)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (8, 1, N'Patada Sonica', 20, 40)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (9, 1, N'Gran Quebrantador', 25, 45)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (10, 1, N'Rodillazo.', 25, 30)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (11, 1, N'Filo de Piedra', 30, 30)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (12, 1, N'Duro Contra el Muro', 30, 50)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (13, 1, N'Contra el Pavimento', 35, 55)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (14, 1, N'Atangana', 35, 55)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (15, 1, N'Suplex Aleman', 40, 60)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (16, 1, N'Hard Reset', 40, 60)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (17, 1, N'Mordida', 45, 65)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (18, 1, N'Shoryuken', 45, 65)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (19, 1, N'Saitama Sensei Taskete!', 100, 150)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (20, 1, N'Meteoro Pegaso', 100, 150)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (21, 2, N'Tiro de Suerte', 5, 25)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (22, 2, N'Doble Flecha', 5, 25)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (23, 2, N'Flecha de Fuego', 10, 30)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (24, 2, N'9mm', 10, 30)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (25, 2, N'Disparo Letal', 20, 35)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (26, 2, N'Plomazo', 20, 35)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (27, 2, N'Cañonazo', 25, 40)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (28, 2, N'Escupo', 25, 40)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (29, 2, N'UZI', 30, 45)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (30, 2, N'Angry Bird', 30, 45)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (31, 2, N'Mortero', 35, 50)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (35, 2, N'David y Goliat', 35, 50)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (37, 2, N'Porotera', 40, 55)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (38, 2, N'Ardilla Voladora', 40, 55)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (39, 2, N'Pium Pium', 45, 60)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (40, 2, N'Heavy Machine Gun', 45, 60)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (41, 2, N'Onda Vital', 100, 150)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (43, 2, N'Hadouken', 100, 150)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (44, 3, N'Fueguito', 5, 25)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (45, 3, N'Whoosh', 5, 25)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (46, 3, N'Huehuehuehue lazer', 10, 30)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (47, 3, N'Hechizo de Amorsh', 10, 30)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (48, 3, N'Portal al Vacío', 20, 35)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (49, 3, N'Polvorita', 20, 35)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (50, 3, N'Ahora me ves...', 25, 40)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (51, 3, N'Truco Barato', 25, 40)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (52, 3, N'Houdini', 30, 45)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (53, 3, N'Fuego Infernal', 30, 45)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (54, 3, N'Ira del oceano', 35, 50)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (55, 3, N'Sumidero del espacio', 35, 50)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (56, 3, N'Rasengan', 40, 55)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (57, 3, N'Poderes de Anime', 40, 55)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (59, 3, N'Friend Zone', 45, 60)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (61, 3, N'Fatality de Maguito', 45, 60)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (62, 3, N'Genki Dama', 100, 150)
INSERT [dbo].[Attack] ([id_attack], [id_type], [attack_name], [coste], [daño]) VALUES (64, 3, N'Tu mamá es el Jaime', 100, 150)
SET IDENTITY_INSERT [dbo].[Attack] OFF
SET IDENTITY_INSERT [dbo].[AttackCharacter] ON 

INSERT [dbo].[AttackCharacter] ([id_character], [id_attack], [id_AC]) VALUES (16, 7, 10)
INSERT [dbo].[AttackCharacter] ([id_character], [id_attack], [id_AC]) VALUES (16, 6, 11)
INSERT [dbo].[AttackCharacter] ([id_character], [id_attack], [id_AC]) VALUES (16, 20, 13)
INSERT [dbo].[AttackCharacter] ([id_character], [id_attack], [id_AC]) VALUES (17, 47, 15)
INSERT [dbo].[AttackCharacter] ([id_character], [id_attack], [id_AC]) VALUES (17, 50, 16)
INSERT [dbo].[AttackCharacter] ([id_character], [id_attack], [id_AC]) VALUES (17, 61, 17)
INSERT [dbo].[AttackCharacter] ([id_character], [id_attack], [id_AC]) VALUES (17, 57, 18)
SET IDENTITY_INSERT [dbo].[AttackCharacter] OFF
SET IDENTITY_INSERT [dbo].[Block_GM] ON 

INSERT [dbo].[Block_GM] ([id_block], [reason], [blockDate], [id_gameM]) VALUES (1, N'Contraseña erronea', CAST(N'2016-06-06' AS Date), 2)
SET IDENTITY_INSERT [dbo].[Block_GM] OFF
SET IDENTITY_INSERT [dbo].[Block_User] ON 

INSERT [dbo].[Block_User] ([id_block], [reason], [blockDate], [id_user]) VALUES (2, N'Contraseña erronea', CAST(N'2016-06-12' AS Date), 6)
SET IDENTITY_INSERT [dbo].[Block_User] OFF
SET IDENTITY_INSERT [dbo].[Character] ON 

INSERT [dbo].[Character] ([id_character], [character_name], [id_type], [life], [stamina], [exp], [lvl], [gold]) VALUES (15, N'Akthor', 3, 250, 100, 0, 1, 50)
INSERT [dbo].[Character] ([id_character], [character_name], [id_type], [life], [stamina], [exp], [lvl], [gold]) VALUES (16, N'MarioVerde', 1, 76, 76, 76, 2, 160)
INSERT [dbo].[Character] ([id_character], [character_name], [id_type], [life], [stamina], [exp], [lvl], [gold]) VALUES (17, N'Da lo Mismo', 3, 250, 100, 69, 1, 50)
INSERT [dbo].[Character] ([id_character], [character_name], [id_type], [life], [stamina], [exp], [lvl], [gold]) VALUES (18, N'ManiWeas', 3, 250, 100, 0, 1, 60)
INSERT [dbo].[Character] ([id_character], [character_name], [id_type], [life], [stamina], [exp], [lvl], [gold]) VALUES (19, N'Ivi-Tan', 3, 250, 100, 0, 1, 50)
SET IDENTITY_INSERT [dbo].[Character] OFF
SET IDENTITY_INSERT [dbo].[Enemy_Attacks] ON 

INSERT [dbo].[Enemy_Attacks] ([id_attack], [attack_name], [daño]) VALUES (1, N'Maldad Pequeña', 5)
INSERT [dbo].[Enemy_Attacks] ([id_attack], [attack_name], [daño]) VALUES (2, N'Troyano', 10)
INSERT [dbo].[Enemy_Attacks] ([id_attack], [attack_name], [daño]) VALUES (3, N'Flaitazo', 15)
INSERT [dbo].[Enemy_Attacks] ([id_attack], [attack_name], [daño]) VALUES (4, N'Loh Estokeh', 20)
INSERT [dbo].[Enemy_Attacks] ([id_attack], [attack_name], [daño]) VALUES (5, N'Spam', 25)
INSERT [dbo].[Enemy_Attacks] ([id_attack], [attack_name], [daño]) VALUES (6, N'Maldad Normal', 30)
SET IDENTITY_INSERT [dbo].[Enemy_Attacks] OFF
INSERT [dbo].[gameMaster] ([id_gameM], [nameGM], [password], [GM_code], [id_state]) VALUES (1, N'Mar', N'123', N'20041996', 2)
INSERT [dbo].[gameMaster] ([id_gameM], [nameGM], [password], [GM_code], [id_state]) VALUES (2, N'Cri', N'123', N'21031994', 1)
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([id_item], [item_name], [id_type], [price]) VALUES (1, N'Espada Fea', 1, 50)
INSERT [dbo].[Items] ([id_item], [item_name], [id_type], [price]) VALUES (2, N'Arco Feo', 2, 50)
INSERT [dbo].[Items] ([id_item], [item_name], [id_type], [price]) VALUES (3, N'Báculo Feo', 3, 50)
INSERT [dbo].[Items] ([id_item], [item_name], [id_type], [price]) VALUES (4, N'Espada Corta', 1, 100)
INSERT [dbo].[Items] ([id_item], [item_name], [id_type], [price]) VALUES (5, N'Arco Corto', 2, 100)
INSERT [dbo].[Items] ([id_item], [item_name], [id_type], [price]) VALUES (6, N'Báculo Pequeño', 3, 100)
INSERT [dbo].[Items] ([id_item], [item_name], [id_type], [price]) VALUES (7, N'Espada Normal', 1, 150)
INSERT [dbo].[Items] ([id_item], [item_name], [id_type], [price]) VALUES (8, N'Arco Normal', 2, 150)
INSERT [dbo].[Items] ([id_item], [item_name], [id_type], [price]) VALUES (9, N'Báculo Normal', 3, 150)
INSERT [dbo].[Items] ([id_item], [item_name], [id_type], [price]) VALUES (10, N'Fajin de Vida', 1, 300)
INSERT [dbo].[Items] ([id_item], [item_name], [id_type], [price]) VALUES (11, N'Fajin de Vida', 2, 300)
INSERT [dbo].[Items] ([id_item], [item_name], [id_type], [price]) VALUES (12, N'Fajin de Vida', 3, 300)
SET IDENTITY_INSERT [dbo].[Items] OFF
SET IDENTITY_INSERT [dbo].[Logs_GM] ON 

INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (1, CAST(N'2016-06-07' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (2, CAST(N'2016-06-07' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (3, CAST(N'2016-06-07' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (4, CAST(N'2016-06-07' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (5, CAST(N'2016-06-07' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (6, CAST(N'2016-06-07' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (7, CAST(N'2016-06-07' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (8, CAST(N'2016-06-07' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (9, CAST(N'2016-06-07' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (10, CAST(N'2016-06-07' AS Date), 1)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (11, CAST(N'2016-06-07' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (12, CAST(N'2016-06-07' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (13, CAST(N'2016-06-07' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (14, CAST(N'2016-06-07' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (15, CAST(N'2016-06-07' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (16, CAST(N'2016-06-07' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (17, CAST(N'2016-06-07' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (18, CAST(N'2016-06-07' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (19, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (20, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (21, CAST(N'2016-06-21' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (22, CAST(N'2016-07-03' AS Date), 2)
INSERT [dbo].[Logs_GM] ([id_log], [logDate], [id_gameM]) VALUES (23, CAST(N'2016-07-03' AS Date), 2)
SET IDENTITY_INSERT [dbo].[Logs_GM] OFF
SET IDENTITY_INSERT [dbo].[Logs_User] ON 

INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1, CAST(N'2016-06-07' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2, CAST(N'2016-06-11' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3, CAST(N'2016-06-11' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (4, CAST(N'2016-06-11' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (5, CAST(N'2016-06-11' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (6, CAST(N'2016-06-11' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (7, CAST(N'2016-06-11' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (8, CAST(N'2016-06-11' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (9, CAST(N'2016-06-11' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (10, CAST(N'2016-06-11' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (11, CAST(N'2016-06-11' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (12, CAST(N'2016-06-11' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (13, CAST(N'2016-06-11' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (14, CAST(N'2016-06-11' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (15, CAST(N'2016-06-11' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (16, CAST(N'2016-06-11' AS Date), 7)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (17, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (18, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (19, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (20, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (21, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (22, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (23, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (24, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1020, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1021, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1022, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1023, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1024, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1025, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1026, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1027, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1028, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1029, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1030, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1031, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1032, CAST(N'2016-06-12' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1033, CAST(N'2016-06-13' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1034, CAST(N'2016-06-13' AS Date), 3)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1035, CAST(N'2016-06-13' AS Date), 3)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1036, CAST(N'2016-06-13' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1037, CAST(N'2016-06-13' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1038, CAST(N'2016-06-13' AS Date), 3)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (1039, CAST(N'2016-06-13' AS Date), 3)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2021, CAST(N'2016-06-14' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2022, CAST(N'2016-06-14' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2023, CAST(N'2016-06-14' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2024, CAST(N'2016-06-14' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2025, CAST(N'2016-06-14' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2026, CAST(N'2016-06-14' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2027, CAST(N'2016-06-14' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2028, CAST(N'2016-06-14' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2029, CAST(N'2016-06-14' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2030, CAST(N'2016-06-14' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2031, CAST(N'2016-06-14' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2032, CAST(N'2016-06-14' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2033, CAST(N'2016-06-14' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2034, CAST(N'2016-06-14' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2035, CAST(N'2016-06-14' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2036, CAST(N'2016-06-14' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2037, CAST(N'2016-06-14' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2038, CAST(N'2016-06-14' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2039, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2040, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2041, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2042, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2043, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2044, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2045, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2046, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2047, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2048, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2049, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2050, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2051, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2052, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2053, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2054, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2055, CAST(N'2016-06-16' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2056, CAST(N'2016-06-21' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2057, CAST(N'2016-06-21' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2058, CAST(N'2016-06-21' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2059, CAST(N'2016-06-22' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (2060, CAST(N'2016-06-22' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3059, CAST(N'2016-06-26' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3060, CAST(N'2016-06-26' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3061, CAST(N'2016-06-26' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3062, CAST(N'2016-06-26' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3063, CAST(N'2016-06-26' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3064, CAST(N'2016-06-26' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3065, CAST(N'2016-06-26' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3066, CAST(N'2016-06-26' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3067, CAST(N'2016-06-26' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3068, CAST(N'2016-07-01' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3069, CAST(N'2016-07-03' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3070, CAST(N'2016-07-03' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3071, CAST(N'2016-07-03' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3072, CAST(N'2016-07-03' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3073, CAST(N'2016-07-03' AS Date), 2)
GO
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3074, CAST(N'2016-07-03' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3075, CAST(N'2016-07-03' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3076, CAST(N'2016-07-03' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3077, CAST(N'2016-07-03' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3078, CAST(N'2016-07-04' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3079, CAST(N'2016-07-04' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3080, CAST(N'2016-07-04' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3081, CAST(N'2016-07-04' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3082, CAST(N'2016-07-04' AS Date), 1)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3083, CAST(N'2016-07-04' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3084, CAST(N'2016-07-04' AS Date), 1)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3085, CAST(N'2016-07-04' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3086, CAST(N'2016-07-04' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3087, CAST(N'2016-07-04' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3088, CAST(N'2016-07-04' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3089, CAST(N'2016-07-04' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3090, CAST(N'2016-07-04' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3091, CAST(N'2016-07-04' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3092, CAST(N'2016-07-04' AS Date), 1)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3093, CAST(N'2016-07-04' AS Date), 1)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3094, CAST(N'2016-07-04' AS Date), 1)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3095, CAST(N'2016-07-04' AS Date), 2)
INSERT [dbo].[Logs_User] ([id_log], [logDate], [id_user]) VALUES (3096, CAST(N'2016-07-05' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Logs_User] OFF
SET IDENTITY_INSERT [dbo].[Monster] ON 

INSERT [dbo].[Monster] ([id_monster], [monster_name], [monster_power], [monster_level]) VALUES (1, N'Baboso', 10, 1)
INSERT [dbo].[Monster] ([id_monster], [monster_name], [monster_power], [monster_level]) VALUES (2, N'Niña Bonita', 10, 1)
INSERT [dbo].[Monster] ([id_monster], [monster_name], [monster_power], [monster_level]) VALUES (3, N'Chupa Sangre', 10, 1)
INSERT [dbo].[Monster] ([id_monster], [monster_name], [monster_power], [monster_level]) VALUES (4, N'Bug', 10, 1)
INSERT [dbo].[Monster] ([id_monster], [monster_name], [monster_power], [monster_level]) VALUES (5, N'Pollito Pío', 10, 1)
INSERT [dbo].[Monster] ([id_monster], [monster_name], [monster_power], [monster_level]) VALUES (6, N'Fameñico', 10, 1)
INSERT [dbo].[Monster] ([id_monster], [monster_name], [monster_power], [monster_level]) VALUES (7, N'Gordito', 10, 1)
INSERT [dbo].[Monster] ([id_monster], [monster_name], [monster_power], [monster_level]) VALUES (8, N'Te quiero Amigo', 10, 1)
INSERT [dbo].[Monster] ([id_monster], [monster_name], [monster_power], [monster_level]) VALUES (9, N'Cuarto de Libra', 10, 1)
INSERT [dbo].[Monster] ([id_monster], [monster_name], [monster_power], [monster_level]) VALUES (10, N'Gary', 10, 1)
SET IDENTITY_INSERT [dbo].[Monster] OFF
SET IDENTITY_INSERT [dbo].[NPC] ON 

INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (1, N'Skull', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (2, N'Flora', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (3, N'Big Mac', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (4, N'Bip Bup Bop', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (5, N'Brwaaarp', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (6, N'Burbujas', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (7, N'Te Agilaste', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (8, N'Fueguito Helado', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (9, N'Dino-Chan', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (10, N'Tengo Dinero y Tu No', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (11, N'Domo-Kyun', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (12, N'Dragon', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (13, N'Keroro', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (14, N'Manite', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (15, N'Moquitos', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (16, N'Mordisquitos', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (17, N'No es Charizard', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (18, N'Posiblemente Kirby', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (19, N'Princesa Lady Grumos', 20, 1)
INSERT [dbo].[NPC] ([id_npc], [npc_name], [npc_power], [npc_level]) VALUES (20, N'Vida Laboral', 20, 1)
SET IDENTITY_INSERT [dbo].[NPC] OFF
SET IDENTITY_INSERT [dbo].[PvP] ON 

INSERT [dbo].[PvP] ([id_pvp], [id_char1], [id_char2], [resultado], [fecha], [OnLine]) VALUES (17, 17, NULL, NULL, CAST(N'2016-07-05' AS Date), 0)
SET IDENTITY_INSERT [dbo].[PvP] OFF
SET IDENTITY_INSERT [dbo].[State] ON 

INSERT [dbo].[State] ([id_state], [name]) VALUES (1, N'Activo')
INSERT [dbo].[State] ([id_state], [name]) VALUES (2, N'Bloqueado')
INSERT [dbo].[State] ([id_state], [name]) VALUES (3, N'Baneado')
INSERT [dbo].[State] ([id_state], [name]) VALUES (4, N'Deshabilitado')
SET IDENTITY_INSERT [dbo].[State] OFF
SET IDENTITY_INSERT [dbo].[Type] ON 

INSERT [dbo].[Type] ([id_type], [type_name]) VALUES (1, N'Guerrero')
INSERT [dbo].[Type] ([id_type], [type_name]) VALUES (2, N'Arquero')
INSERT [dbo].[Type] ([id_type], [type_name]) VALUES (3, N'Mago')
SET IDENTITY_INSERT [dbo].[Type] OFF
SET IDENTITY_INSERT [dbo].[User1] ON 

INSERT [dbo].[User1] ([id_user], [user_name], [id_character], [password], [id_state]) VALUES (1, N'marco', 17, N'123', 1)
INSERT [dbo].[User1] ([id_user], [user_name], [id_character], [password], [id_state]) VALUES (2, N'cris', 16, N'123', 1)
INSERT [dbo].[User1] ([id_user], [user_name], [id_character], [password], [id_state]) VALUES (3, N'ivi', 19, N'123', 1)
INSERT [dbo].[User1] ([id_user], [user_name], [id_character], [password], [id_state]) VALUES (6, N'Willi', 15, N'123', 1)
INSERT [dbo].[User1] ([id_user], [user_name], [id_character], [password], [id_state]) VALUES (7, N'Javi', 18, N'123', 1)
INSERT [dbo].[User1] ([id_user], [user_name], [id_character], [password], [id_state]) VALUES (8, N'fr', NULL, N'fff', 1)
SET IDENTITY_INSERT [dbo].[User1] OFF
ALTER TABLE [dbo].[AproxLevel]  WITH CHECK ADD  CONSTRAINT [FK_AproxLevel_Character] FOREIGN KEY([char_level])
REFERENCES [dbo].[Character] ([id_character])
GO
ALTER TABLE [dbo].[AproxLevel] CHECK CONSTRAINT [FK_AproxLevel_Character]
GO
ALTER TABLE [dbo].[AproxLevel]  WITH CHECK ADD  CONSTRAINT [FK_AproxLevel_Monster] FOREIGN KEY([enemy_level])
REFERENCES [dbo].[Monster] ([id_monster])
GO
ALTER TABLE [dbo].[AproxLevel] CHECK CONSTRAINT [FK_AproxLevel_Monster]
GO
ALTER TABLE [dbo].[AproxLevel]  WITH CHECK ADD  CONSTRAINT [FK_AproxLevel_NPC] FOREIGN KEY([enemy_level])
REFERENCES [dbo].[NPC] ([id_npc])
GO
ALTER TABLE [dbo].[AproxLevel] CHECK CONSTRAINT [FK_AproxLevel_NPC]
GO
ALTER TABLE [dbo].[Attack]  WITH CHECK ADD  CONSTRAINT [FK_Attack_Type] FOREIGN KEY([id_type])
REFERENCES [dbo].[Type] ([id_type])
GO
ALTER TABLE [dbo].[Attack] CHECK CONSTRAINT [FK_Attack_Type]
GO
ALTER TABLE [dbo].[AttackCharacter]  WITH CHECK ADD  CONSTRAINT [FK_atackChracter_Attack] FOREIGN KEY([id_attack])
REFERENCES [dbo].[Attack] ([id_attack])
GO
ALTER TABLE [dbo].[AttackCharacter] CHECK CONSTRAINT [FK_atackChracter_Attack]
GO
ALTER TABLE [dbo].[AttackCharacter]  WITH CHECK ADD  CONSTRAINT [FK_atackChracter_Character] FOREIGN KEY([id_character])
REFERENCES [dbo].[Character] ([id_character])
GO
ALTER TABLE [dbo].[AttackCharacter] CHECK CONSTRAINT [FK_atackChracter_Character]
GO
ALTER TABLE [dbo].[Block_GM]  WITH CHECK ADD  CONSTRAINT [FK_Block_GM_gameMaster] FOREIGN KEY([id_gameM])
REFERENCES [dbo].[gameMaster] ([id_gameM])
GO
ALTER TABLE [dbo].[Block_GM] CHECK CONSTRAINT [FK_Block_GM_gameMaster]
GO
ALTER TABLE [dbo].[Block_User]  WITH CHECK ADD  CONSTRAINT [FK_BlocksNBans_User] FOREIGN KEY([id_user])
REFERENCES [dbo].[User1] ([id_user])
GO
ALTER TABLE [dbo].[Block_User] CHECK CONSTRAINT [FK_BlocksNBans_User]
GO
ALTER TABLE [dbo].[Character]  WITH CHECK ADD  CONSTRAINT [FK_Character_Type] FOREIGN KEY([id_type])
REFERENCES [dbo].[Type] ([id_type])
GO
ALTER TABLE [dbo].[Character] CHECK CONSTRAINT [FK_Character_Type]
GO
ALTER TABLE [dbo].[gameMaster]  WITH CHECK ADD  CONSTRAINT [FK_gameMaster_State] FOREIGN KEY([id_state])
REFERENCES [dbo].[State] ([id_state])
GO
ALTER TABLE [dbo].[gameMaster] CHECK CONSTRAINT [FK_gameMaster_State]
GO
ALTER TABLE [dbo].[ItemCharacter]  WITH CHECK ADD  CONSTRAINT [FK_ItemCharacter_Character] FOREIGN KEY([id_character])
REFERENCES [dbo].[Character] ([id_character])
GO
ALTER TABLE [dbo].[ItemCharacter] CHECK CONSTRAINT [FK_ItemCharacter_Character]
GO
ALTER TABLE [dbo].[ItemCharacter]  WITH CHECK ADD  CONSTRAINT [FK_ItemCharacter_Items] FOREIGN KEY([id_item])
REFERENCES [dbo].[Items] ([id_item])
GO
ALTER TABLE [dbo].[ItemCharacter] CHECK CONSTRAINT [FK_ItemCharacter_Items]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Type] FOREIGN KEY([id_type])
REFERENCES [dbo].[Type] ([id_type])
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Type]
GO
ALTER TABLE [dbo].[Logs_GM]  WITH CHECK ADD  CONSTRAINT [FK_Logs_GM_gameMaster] FOREIGN KEY([id_gameM])
REFERENCES [dbo].[gameMaster] ([id_gameM])
GO
ALTER TABLE [dbo].[Logs_GM] CHECK CONSTRAINT [FK_Logs_GM_gameMaster]
GO
ALTER TABLE [dbo].[Logs_User]  WITH CHECK ADD  CONSTRAINT [FK_Logs_User] FOREIGN KEY([id_user])
REFERENCES [dbo].[User1] ([id_user])
GO
ALTER TABLE [dbo].[Logs_User] CHECK CONSTRAINT [FK_Logs_User]
GO
ALTER TABLE [dbo].[MonsterAttack]  WITH CHECK ADD  CONSTRAINT [FK_MonsterAttack_Enemy_Attacks] FOREIGN KEY([id_attack])
REFERENCES [dbo].[Enemy_Attacks] ([id_attack])
GO
ALTER TABLE [dbo].[MonsterAttack] CHECK CONSTRAINT [FK_MonsterAttack_Enemy_Attacks]
GO
ALTER TABLE [dbo].[MonsterAttack]  WITH CHECK ADD  CONSTRAINT [FK_MonsterAttack_Monster] FOREIGN KEY([id_monster])
REFERENCES [dbo].[Monster] ([id_monster])
GO
ALTER TABLE [dbo].[MonsterAttack] CHECK CONSTRAINT [FK_MonsterAttack_Monster]
GO
ALTER TABLE [dbo].[NpcAttack]  WITH CHECK ADD  CONSTRAINT [FK_NpcAttack_Enemy_Attacks] FOREIGN KEY([id_attack])
REFERENCES [dbo].[Enemy_Attacks] ([id_attack])
GO
ALTER TABLE [dbo].[NpcAttack] CHECK CONSTRAINT [FK_NpcAttack_Enemy_Attacks]
GO
ALTER TABLE [dbo].[NpcAttack]  WITH CHECK ADD  CONSTRAINT [FK_NpcAttack_NPC] FOREIGN KEY([id_npc])
REFERENCES [dbo].[NPC] ([id_npc])
GO
ALTER TABLE [dbo].[NpcAttack] CHECK CONSTRAINT [FK_NpcAttack_NPC]
GO
ALTER TABLE [dbo].[PvP]  WITH CHECK ADD  CONSTRAINT [FK_PvP_Character] FOREIGN KEY([id_char1])
REFERENCES [dbo].[Character] ([id_character])
GO
ALTER TABLE [dbo].[PvP] CHECK CONSTRAINT [FK_PvP_Character]
GO
ALTER TABLE [dbo].[PvP]  WITH CHECK ADD  CONSTRAINT [FK_PvP_Character1] FOREIGN KEY([id_char2])
REFERENCES [dbo].[Character] ([id_character])
GO
ALTER TABLE [dbo].[PvP] CHECK CONSTRAINT [FK_PvP_Character1]
GO
ALTER TABLE [dbo].[User1]  WITH CHECK ADD  CONSTRAINT [FK_User_Character] FOREIGN KEY([id_character])
REFERENCES [dbo].[Character] ([id_character])
GO
ALTER TABLE [dbo].[User1] CHECK CONSTRAINT [FK_User_Character]
GO
ALTER TABLE [dbo].[User1]  WITH CHECK ADD  CONSTRAINT [FK_User_State] FOREIGN KEY([id_state])
REFERENCES [dbo].[State] ([id_state])
GO
ALTER TABLE [dbo].[User1] CHECK CONSTRAINT [FK_User_State]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "c"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 216
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 1830
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vChars'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vChars'
GO
USE [master]
GO
ALTER DATABASE [RPG-Project] SET  READ_WRITE 
GO
