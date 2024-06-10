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

- Use a IDE Visual Studio de preferência versão 2022 para poder rodar a aplicação

## Instalação de Dependências

1. Instale o pacote `Newtonsoft.Json`:
   ```sh
   Install-Package Newtonsoft.Json

## Passos:

- Use o comando: " dotnet restore "  para instalar as dependências

- Execute o comando: " dotnet ef database update --project + caminho do projeto "  para criar o banco de dados:
         
- Revise e faça as alterações e adições de pacotes e configurações necessárias.

## Compile o projeto
- dotnet build

## Execute o projeto
- dotnet run

## Observações:

 1. O banco de dados usado foi o LocalDb, se necessário:

 - Abra o arquivo appsettings.json

 - Substitua a string de conexão em DefaultConnection pelo seu próprio banco de dados SQL Server
