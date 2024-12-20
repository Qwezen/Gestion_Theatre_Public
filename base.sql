USE [BD_Theatre]
GO
/****** Object:  Table [dbo].[auteur]    Script Date: 07/11/2024 09:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[auteur](
	[id_auteur] [int] IDENTITY(1,1) NOT NULL,
	[nom_auteur] [varchar](50) NOT NULL,
	[prenom_auteur] [varchar](50) NOT NULL,
 CONSTRAINT [auteur_PK] PRIMARY KEY CLUSTERED 
(
	[id_auteur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[client]    Script Date: 07/11/2024 09:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[id_client] [int] IDENTITY(1,1) NOT NULL,
	[nom_client] [varchar](50) NOT NULL,
	[prenom_client] [varchar](50) NOT NULL,
	[mail_client] [varchar](50) NOT NULL,
	[tel_client] [varchar](25) NOT NULL,
 CONSTRAINT [client_PK] PRIMARY KEY CLUSTERED 
(
	[id_client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comedien]    Script Date: 07/11/2024 09:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comedien](
	[id_comedien] [int] IDENTITY(1,1) NOT NULL,
	[nom_comedien] [varchar](50) NOT NULL,
	[prenom_comedien] [varchar](50) NOT NULL,
	[age_comedien] [int] NOT NULL,
	[nationnalite_comedien] [varchar](50) NOT NULL,
	[id_compagnie] [int] NOT NULL,
 CONSTRAINT [comedien_PK] PRIMARY KEY CLUSTERED 
(
	[id_comedien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[compagnie]    Script Date: 07/11/2024 09:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compagnie](
	[id_compagnie] [int] IDENTITY(1,1) NOT NULL,
	[nom_compagnie] [varchar](50) NOT NULL,
	[provenance_compagnie] [varchar](50) NOT NULL,
	[directeur_artistique_compagnie] [varchar](50) NOT NULL,
 CONSTRAINT [compagnie_PK] PRIMARY KEY CLUSTERED 
(
	[id_compagnie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[piece]    Script Date: 07/11/2024 09:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[piece](
	[id_piece] [int] IDENTITY(1,1) NOT NULL,
	[nom_piece] [varchar](50) NOT NULL,
	[description_piece] [varchar](255) NOT NULL,
	[duree_piece] [int] NOT NULL,
	[tarif_piece] [float] NOT NULL,
	[id_theme] [int] NOT NULL,
	[id_tpublic] [int] NOT NULL,
	[id_auteur] [int] NOT NULL,
	[id_compagnie] [int] NOT NULL,
 CONSTRAINT [piece_PK] PRIMARY KEY CLUSTERED 
(
	[id_piece] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[representation]    Script Date: 07/11/2024 09:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[representation](
	[id_representation] [int] IDENTITY(1,1) NOT NULL,
	[date_representation] [datetime] NOT NULL,
	[nb_place_representation] [int] NOT NULL,
	[id_piece] [int] NOT NULL,
	[id_tarif] [int] NOT NULL,
 CONSTRAINT [representation_PK] PRIMARY KEY CLUSTERED 
(
	[id_representation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reserve]    Script Date: 07/11/2024 09:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reserve](
	[id_representation] [int] NOT NULL,
	[id_client] [int] NOT NULL,
	[nb_place_reserve] [int] NOT NULL,
 CONSTRAINT [reserve_PK] PRIMARY KEY CLUSTERED 
(
	[id_representation] ASC,
	[id_client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tarif]    Script Date: 07/11/2024 09:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tarif](
	[id_tarif] [int] IDENTITY(1,1) NOT NULL,
	[libel_tarif] [varchar](50) NOT NULL,
	[variation_tarif] [int] NOT NULL,
 CONSTRAINT [tarif_PK] PRIMARY KEY CLUSTERED 
(
	[id_tarif] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[theme]    Script Date: 07/11/2024 09:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[theme](
	[id_theme] [int] IDENTITY(1,1) NOT NULL,
	[type_theme] [varchar](50) NOT NULL,
 CONSTRAINT [theme_PK] PRIMARY KEY CLUSTERED 
(
	[id_theme] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tpublic]    Script Date: 07/11/2024 09:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tpublic](
	[id_tpublic] [int] IDENTITY(1,1) NOT NULL,
	[type_tpublic] [varchar](50) NOT NULL,
 CONSTRAINT [public_PK] PRIMARY KEY CLUSTERED 
(
	[id_tpublic] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[utilisateur]    Script Date: 07/11/2024 09:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[utilisateur](
	[id_utilisateur] [int] IDENTITY(1,1) NOT NULL,
	[identifiant_utilisateur] [varchar](50) NOT NULL,
	[mdp_utilisateur] [varchar](50) NOT NULL,
 CONSTRAINT [utilisateur_PK] PRIMARY KEY CLUSTERED 
(
	[id_utilisateur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[comedien]  WITH CHECK ADD  CONSTRAINT [comedien_compagnie_FK] FOREIGN KEY([id_compagnie])
REFERENCES [dbo].[compagnie] ([id_compagnie])
GO
ALTER TABLE [dbo].[comedien] CHECK CONSTRAINT [comedien_compagnie_FK]
GO
ALTER TABLE [dbo].[piece]  WITH CHECK ADD  CONSTRAINT [piece_auteur1_FK] FOREIGN KEY([id_auteur])
REFERENCES [dbo].[auteur] ([id_auteur])
GO
ALTER TABLE [dbo].[piece] CHECK CONSTRAINT [piece_auteur1_FK]
GO
ALTER TABLE [dbo].[piece]  WITH CHECK ADD  CONSTRAINT [piece_compagnie2_FK] FOREIGN KEY([id_compagnie])
REFERENCES [dbo].[compagnie] ([id_compagnie])
GO
ALTER TABLE [dbo].[piece] CHECK CONSTRAINT [piece_compagnie2_FK]
GO
ALTER TABLE [dbo].[piece]  WITH CHECK ADD  CONSTRAINT [piece_theme_FK] FOREIGN KEY([id_theme])
REFERENCES [dbo].[theme] ([id_theme])
GO
ALTER TABLE [dbo].[piece] CHECK CONSTRAINT [piece_theme_FK]
GO
ALTER TABLE [dbo].[piece]  WITH CHECK ADD  CONSTRAINT [piece_tpublic0_FK] FOREIGN KEY([id_tpublic])
REFERENCES [dbo].[tpublic] ([id_tpublic])
GO
ALTER TABLE [dbo].[piece] CHECK CONSTRAINT [piece_tpublic0_FK]
GO
ALTER TABLE [dbo].[representation]  WITH CHECK ADD  CONSTRAINT [representation_piece_FK] FOREIGN KEY([id_piece])
REFERENCES [dbo].[piece] ([id_piece])
GO
ALTER TABLE [dbo].[representation] CHECK CONSTRAINT [representation_piece_FK]
GO
ALTER TABLE [dbo].[representation]  WITH CHECK ADD  CONSTRAINT [representation_tarif0_FK] FOREIGN KEY([id_tarif])
REFERENCES [dbo].[tarif] ([id_tarif])
GO
ALTER TABLE [dbo].[representation] CHECK CONSTRAINT [representation_tarif0_FK]
GO
ALTER TABLE [dbo].[reserve]  WITH CHECK ADD  CONSTRAINT [reserve_client0_FK] FOREIGN KEY([id_client])
REFERENCES [dbo].[client] ([id_client])
GO
ALTER TABLE [dbo].[reserve] CHECK CONSTRAINT [reserve_client0_FK]
GO
ALTER TABLE [dbo].[reserve]  WITH CHECK ADD  CONSTRAINT [reserve_representation_FK] FOREIGN KEY([id_representation])
REFERENCES [dbo].[representation] ([id_representation])
GO
ALTER TABLE [dbo].[reserve] CHECK CONSTRAINT [reserve_representation_FK]
GO
