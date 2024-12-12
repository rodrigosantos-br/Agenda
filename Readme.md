# Agenda

Uma aplicação simples de agenda onde o usuário pode registrar compromissos com título, data, hora e descrição. O objetivo deste projeto é demonstrar habilidades em desenvolvimento de software e reforçar o aprendizado.

## Funcionalidades

- Adicionar compromissos com:
  - **Título**
  - **Data e Hora**
  - **Descrição**
- Visualizar compromissos registrados.
- Editar compromissos existentes.
- Excluir compromissos.

## Tecnologias Utilizadas

- **Linguagem**: C#
- **Framework**: Windows Forms
- **Banco de Dados**: SQL Server
- **Ambiente de Desenvolvimento**: Visual Studio 2022 Community
- **Runtime Necessário**: .NET Runtime 8.0.11

## Requisitos para Executar o Projeto

1. **.NET Runtime 8.0.11**
   - Faça o download em [dotnet.microsoft.com](https://dotnet.microsoft.com/).
2. SQL Server configurado.

## Instalação e Configuração

1. Clone o repositório:
   ```bash
   git clone https://github.com/rodrigosantos-br/Agenda.git
   ```

2. Abra o projeto no Visual Studio 2022 Community.

3. Configure a string de conexão com o SQL Server no arquivo `App.config` (ou outro arquivo de configuração do projeto):
   ```xml
   <connectionStrings>
       <add name="MinhaConexao" connectionString="Server=SEU_SERVIDOR;Database=Agenda;Trusted_Connection=True;" providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

4. Restaure o banco de dados usando o script SQL fornecido no repositório:
   - Navegue até a pasta `Database`.
   - Execute o arquivo `create_database.sql` no SQL Server para criar e configurar o banco de dados.

5. Compile e execute o projeto.

## Uso

1. Abra o aplicativo.
2. Utilize o formulário para adicionar, editar ou excluir compromissos.
3. Consulte os compromissos na interface principal.