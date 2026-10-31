# API de Gerenciamento de Tarefas (.NET)

Projeto desenvolvido como parte do desafio de projeto da Digital Innovation One (DIO), focado na construção de um sistema de agendamento e gestão de tarefas utilizando C#, .NET e Entity Framework Core.

## Tecnologias Utilizadas

* .NET 10
* Entity Framework Core (ORM)
* SQL Server (Banco de dados relacional)
* Microsoft.AspNetCore.OpenApi

## Estrutura do Projeto

A arquitetura do projeto foi organizada em camadas para garantir a separação de responsabilidades:
* Models/: Contém as classes de entidade (ex: Tarefa.cs) e os enums de status.
* Context/: Contém o contexto do banco de dados (OrganizadorContext.cs) e a fábrica de design para migrations.
* Controllers/: Contém os controladores da API com as regras de negócio para gerenciar as tarefas (TarefaController.cs).

## Como Executar o Projeto Localmente

Siga os passos abaixo para configurar e rodar a API na sua máquina:

1. Pré-requisitos:
   * Ter o .NET SDK instalado.
   * Ter o SQL Server em execução (LocalDB ou instância local).

2. Clonar o repositório:
   ```bash
   git clone [https://github.com/UalaceAraujo/TrilhaApiDesafio.git](https://github.com/UalaceAraujo/TrilhaApiDesafio.git)
   cd TrilhaApiDesafio