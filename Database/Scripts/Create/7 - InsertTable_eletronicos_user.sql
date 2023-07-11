USE [eletronicos_user]
GO

INSERT INTO [estoque].[eletronicos]
           ([CODIGO]
           ,[CATEGORIA]
           ,[MARCA]
           ,[NOME]
           ,[QUANTIDADE]
           ,[PRECO]
           ,[ESTADO])
     VALUES
           (01, 'Celular', 'Samsung', 'galaxy S22', 12, 5.231, 'Novo'),
		   (02, 'Celular', 'Samsung', 'galaxy A14', 12, 5.231, 'Novo'),
           (03, 'Celular', 'Samsung', 'galaxy S23', 12, 5.231, 'usado'),
           (04, 'Celular', 'Samsung', 'galaxy A54', 12, 5.231, 'Novo'),
           (05, 'Celular', 'Motorola', 'Motorola One vision', 12, 5.231, 'Novo'),
		   (06, 'Celular', 'Motorola', 'Moto G5', 12, 5.231, 'Novo'),
           (07, 'Celular', 'Motorola', 'Motorola Edge', 12, 5.231, 'usado'),
           (08, 'Tablet', 'Samsung', 'Galaxy Tab S6 Lite', 12, 5.231, 'Novo'),
		   (09, 'Tablet', 'Samsung', 'Galaxy Tab S8 Ultra 5G', 12, 500, 'usado'),
		   (10, 'Tablet', 'Xixaomiro', 'Xixaomiro 8.1', 12, 500, 'usado'),
		   (11, 'Tablet', 'Xixaomiro', 'Xixaomiro 10.1 Android 13', 12, 500, 'novo');		   
GO


