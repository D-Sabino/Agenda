
# Agenda C#

Este projeto é um sistema de agenda desenvolvido em C#. O objetivo é permitir que os usuários gerenciem contatos.

### 📌 Status do Projeto
- Concluído
- Funcionalidades implementadas e testadas

### 📅 Funcionalidades
- Gerenciamento de contatos (Adicionar, Editar, Remover)
- Busca de contatos por nome
- Armazenamento local em banco de dados
- Interface gráfica simples e funcional

### 🔧 Tecnologias utilizadas
- C#
- .NET Framework
- PostgreSQL (para armazenamento de dados)


## Como Rodar

1. **Clone o repositório:**

   ```bash
   git clone https://github.com/D-Sabino/Agenda.git
   ```

2. **Abra o projeto no Visual Studio:**

   Após clonar o repositório, abra o arquivo `.sln` no Visual Studio para carregar o projeto.

3. **Configure a string de conexão no arquivo `DadosConexao.cs`:**

   Abra o arquivo `DadosConexao.cs` e altere a string de conexão com as informações do seu banco de dados PostgreSQL:

   ```csharp
   public static class DadosConexao
   {
       public static string StringDeConexao = "Host=localhost;Port=5432;Username=seu_usuario;Password=sua_senha;Database=agenda_contatos;";
   }
   ```

4. **Compile e execute o projeto:**

   No Visual Studio, clique em **Iniciar** (ou pressione `F5`) para compilar e rodar a aplicação.

5. **Use a aplicação para gerenciar seus contatos.**

   Após a aplicação ser carregada, você pode interagir com ela através da interface gráfica, realizando operações de cadastro, alteração e exclusão de contatos.


### 📢 Informações adicionais
Este projeto foi concluído e está pronto para ser utilizado. Novas funcionalidades podem ser implementadas conforme necessário, mas atualmente está estável e funcional.

