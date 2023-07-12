# Projeto WorkSample
> Processamento de serviço em segundo plano cronometradas para serem executadas semanalmente.

## Pré-requisitos
- Microsoft SQL Server 2019 +
- Visual Studio com suporte a .NET Core 6 +

## Definições:
 - DDD: Worker, Application, Domain e Infrastructure
 - DI: Autofac
 - ORM: Dapper, SqlClient
 - Log: NLog

## Instalação
1. Execute os scripts de produção no SQL Server na seguinte ordem:
   - 1 - Database_eletronicos_user.sql
   - 2 - Database_eletronicos_datalake.sql
   - 3 - Login.sql
   - 4 - Tabela_eletronicos_datalake.sql
   - 5 - Tabela_eletronicos_user.sql
2. Para fins didáticos, serão inseridos dados na tabela `estoque.eletronicos` do database `eletronicos_user`.
   - 1 - InsertTable_eletronicos_user.sql

## Funcionamento
 - O serviço irá ler semanalmente a tabela `estoque.eletronicos` da base de dados `eletronicos_user` e inserir os dados na tabela `estoque.eletronicos` na base de dados `eletronicos_datalake`. 
 - Antes de inserir novos dados, os dados antigos serão excluídos.

## Autor
> Rafael Pino
