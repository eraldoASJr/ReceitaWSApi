# ReceitaWS API

## Descrição
A ReceitaWS API é uma aplicação web que permite aos usuários consultar informações de empresas com base no seu CNPJ usando a API do ReceitaWS.

## Pré-requisitos
- [.NET SDK 3.1 ou superior](https://dotnet.microsoft.com/download) (Utilizada a ultima versão 8.0)
- [SQL Server (ou SQL Express)](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) ou outro banco de dados suportado pelo Entity Framework Core

## Instalação
1. Clone o repositório
   ```sh
   git clone https://github.com/seu-usuario/receitaws-api.git

##Observações:

1. O banco de dados usado foi o LocalDb, se necessário:
# Abra o arquivo appsettings.json
# Substitua a string de conexão em DefaultConnection pelo seu próprio banco de dados SQL Server
# Execute o comando para criar o banco de dados:
# dotnet ef database update.


## Compile o projeto
- dotnet build

## Execute o projeto
- dotnet run
