USE [master]
GO
/****** Object:  Database [BDProgPractico]    Script Date: 28/06/2019 1:50:55 ******/
CREATE DATABASE [BDProgPractico]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDProgPractico', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BDProgPractico.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDProgPractico_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BDProgPractico_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BDProgPractico] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDProgPractico].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDProgPractico] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDProgPractico] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDProgPractico] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDProgPractico] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDProgPractico] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDProgPractico] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDProgPractico] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDProgPractico] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDProgPractico] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDProgPractico] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDProgPractico] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDProgPractico] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDProgPractico] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDProgPractico] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDProgPractico] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BDProgPractico] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDProgPractico] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDProgPractico] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDProgPractico] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDProgPractico] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDProgPractico] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDProgPractico] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDProgPractico] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BDProgPractico] SET  MULTI_USER 
GO
ALTER DATABASE [BDProgPractico] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDProgPractico] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDProgPractico] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDProgPractico] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDProgPractico] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BDProgPractico] SET QUERY_STORE = OFF
GO
USE [BDProgPractico]
GO
/****** Object:  Table [dbo].[Peliculas]    Script Date: 28/06/2019 1:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Peliculas](
	[ID] [numeric](8, 0) IDENTITY(1,1) NOT NULL,
	[Titulo] [nvarchar](50) NOT NULL,
	[Genero] [nvarchar](50) NOT NULL,
	[Ano] [nvarchar](50) NOT NULL,
	[Pais] [nvarchar](50) NOT NULL,
	[Baja] [bit] NOT NULL,
 CONSTRAINT [PK_Peliculas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PelisVentas]    Script Date: 28/06/2019 1:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PelisVentas](
	[ID] [numeric](8, 0) IDENTITY(1,1) NOT NULL,
	[IDVenta] [numeric](8, 0) NOT NULL,
	[IDPelicula] [numeric](8, 0) NOT NULL,
 CONSTRAINT [PK_PelisVentas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 28/06/2019 1:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[ID] [numeric](8, 0) IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Monto] [numeric](8, 0) NOT NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Peliculas] ON 

INSERT [dbo].[Peliculas] ([ID], [Titulo], [Genero], [Ano], [Pais], [Baja]) VALUES (CAST(1 AS Numeric(8, 0)), N'Harry Potter y el caliz de fuego', N'Magia', N'2005', N'EEUU', 0)
INSERT [dbo].[Peliculas] ([ID], [Titulo], [Genero], [Ano], [Pais], [Baja]) VALUES (CAST(2 AS Numeric(8, 0)), N'Un monstuo viene a verme', N'Terror', N'2016', N'España', 0)
INSERT [dbo].[Peliculas] ([ID], [Titulo], [Genero], [Ano], [Pais], [Baja]) VALUES (CAST(3 AS Numeric(8, 0)), N'Kimi no na wa', N'Drama', N'2016', N'Japón', 0)
INSERT [dbo].[Peliculas] ([ID], [Titulo], [Genero], [Ano], [Pais], [Baja]) VALUES (CAST(4 AS Numeric(8, 0)), N'Un monstuo viene a verme', N'panico', N'2016', N'España', 0)
INSERT [dbo].[Peliculas] ([ID], [Titulo], [Genero], [Ano], [Pais], [Baja]) VALUES (CAST(5 AS Numeric(8, 0)), N'wally', N'kids', N'2006', N'narrnia', 0)
INSERT [dbo].[Peliculas] ([ID], [Titulo], [Genero], [Ano], [Pais], [Baja]) VALUES (CAST(6 AS Numeric(8, 0)), N'Pepito', N'Transexual', N'2017', N'Rusia', 0)
INSERT [dbo].[Peliculas] ([ID], [Titulo], [Genero], [Ano], [Pais], [Baja]) VALUES (CAST(7 AS Numeric(8, 0)), N'Leonardo', N'Quién sabrá', N'2017', N'Uruguay(no somos provincia)', 0)
INSERT [dbo].[Peliculas] ([ID], [Titulo], [Genero], [Ano], [Pais], [Baja]) VALUES (CAST(8 AS Numeric(8, 0)), N'Lo que victor se llevó', N'', N'2019', N'', 0)
INSERT [dbo].[Peliculas] ([ID], [Titulo], [Genero], [Ano], [Pais], [Baja]) VALUES (CAST(9 AS Numeric(8, 0)), N'Pidieron mínimo 10 registros', N'Lo hago', N'2017', N'Uruguay', 0)
INSERT [dbo].[Peliculas] ([ID], [Titulo], [Genero], [Ano], [Pais], [Baja]) VALUES (CAST(10 AS Numeric(8, 0)), N'INSERTADO', N'REALIZADO', N'2018', N'Korea', 0)
INSERT [dbo].[Peliculas] ([ID], [Titulo], [Genero], [Ano], [Pais], [Baja]) VALUES (CAST(11 AS Numeric(8, 0)), N'Uno más de paso', N'Como no uso combobox para ésto meto lo que quiero', N'2019', N'Korea', 0)
INSERT [dbo].[Peliculas] ([ID], [Titulo], [Genero], [Ano], [Pais], [Baja]) VALUES (CAST(12 AS Numeric(8, 0)), N'Otro ya que estamos', N'Registro', N'2019', N'narnia', 0)
SET IDENTITY_INSERT [dbo].[Peliculas] OFF
ALTER TABLE [dbo].[Peliculas] ADD  CONSTRAINT [DF_Peliculas_Baja]  DEFAULT ((0)) FOR [Baja]
GO
ALTER TABLE [dbo].[PelisVentas]  WITH CHECK ADD  CONSTRAINT [FK_PelisVentas_PelisVentas] FOREIGN KEY([ID])
REFERENCES [dbo].[PelisVentas] ([ID])
GO
ALTER TABLE [dbo].[PelisVentas] CHECK CONSTRAINT [FK_PelisVentas_PelisVentas]
GO
/****** Object:  StoredProcedure [dbo].[PRABaja]    Script Date: 28/06/2019 1:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PRABaja]
@ID numeric(8,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Peliculas SET Baja= 1 WHERE ID= @ID;
END
GO
/****** Object:  StoredProcedure [dbo].[PRABuscarPeliculas]    Script Date: 28/06/2019 1:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PRABuscarPeliculas]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ID, Titulo, Genero, Ano, Pais FROM Peliculas where Baja= 0;
END
GO
/****** Object:  StoredProcedure [dbo].[PRAInsertarPelicula]    Script Date: 28/06/2019 1:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PRAInsertarPelicula]
	@Titulo nvarchar(50),
	@Genero nvarchar(50),
	@Ano nvarchar(50),
	@Pais nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO  Peliculas (Titulo, Genero, Ano, Pais) values ( @Titulo, @Genero, @Ano, @Pais);
END
GO
/****** Object:  StoredProcedure [dbo].[PRAModificarPelicula]    Script Date: 28/06/2019 1:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PRAModificarPelicula]
	@ID numeric(8,0),
	@Titulo nvarchar(50),
	@Genero nvarchar(50),
	@Ano nvarchar(50),
	@Pais nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Peliculas SET Titulo = @Titulo, Genero = @Genero, Ano = @Ano, Pais= @Pais WHERE ID= @ID;
END
GO
USE [master]
GO
ALTER DATABASE [BDProgPractico] SET  READ_WRITE 
GO
