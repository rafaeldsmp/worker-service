USE [master]
GO
CREATE LOGIN [Worker] WITH PASSWORD=N'527!m3uP@ssword', DEFAULT_DATABASE=[eletronicos_datalake], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
USE [eletronicos_datalake]
GO
CREATE USER [Worker] FOR LOGIN [Worker]
GO
USE [eletronicos_datalake]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Worker]
GO
USE [eletronicos_datalake]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Worker]
GO
USE [eletronicos_datalake]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [Worker]
GO
