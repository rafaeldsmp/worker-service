USE [eletronicos_user]
GO

CREATE TABLE [estoque].[eletronicos](
	[CODIGO] [tinyint] NOT NULL primary key, 
	[CATEGORIA] [varchar](100) NOT NULL,
	[MARCA] [varchar](100) NOT NULL,
	[NOME] [varchar] (100) NOT NULL,
	[QUANTIDADE] [tinyint] NOT NULL,
	[PRECO] [MONEY] NOT NULL,
	[ESTADO] [varchar](100) NOT NULL,
)