USE [eletronicos_user]
GO

CREATE TABLE [estoque].[eletronicos](
	[CATEGORIA] [varchar](100) NOT NULL primary key,
	[TIPO] [varchar](6) NOT NULL,
	[NOME] [varchar] (24) NOT NULL,
	[QUANTIDADE] [tinyint] NOT NULL,
	[PRECO] [float] NOT NULL,
	[ESTADO] [varchar](100) NOT NULL,
)
