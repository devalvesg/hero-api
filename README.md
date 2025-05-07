
# Hero API

Este foi um projeto desenvolvido em C# com Frontend em Angular.
A ideia era desenvolver uma API para cadastro de super heróis respeitando algumas das regras de negócios solicitadas como:

- Deve ser gerado automaticamente um ID para o super-herói.
 -Não deve permitir criar dois super-heróis com o mesmo nome de herói, isso daria uma boaconfusão.
- Definir superpoderes padrões no banco
- A API deve ser capaz de retornar a lista de todos os super-heróis cadastrados previamente.
- Além disso, caso seja chamado o método de listagem, e não existir nenhum super-herói cadastrado, deve-se retornar o HTTP Code correto, com mensagem de tratamento.

Entendi que .NET Core era a plataforma base e, como era um CRUD simples, optei por uma API REST em ASP.NET Core, pois é a forma mais comum e adequada para esse tipo de aplicação.

## Funcionalidades
- Cadastro de um novo super-herói
- Listagem dos super-heróis
- Consulta de um super-herói por Id (Id por parametro e tratar as exceptions para quando não existir)
- Atualização de informações do super-herói por Id (Id por parametro e tratar as exceptions para quando não existir)
- Exclusão de um super-herói por Id (Id por parametro e tratar as exceptions para quando não existir)
- Criar middlaware de exceptions (Optional)
- Disponibilização da documentação da API utilizando o Swagger

## Tecnologias Utilizadas
- C#
- Angular
- Docker

## Como Executar o Projeto Backend
1. Clone este repositório:
   ```bash
   git clone https://github.com/devalvesg/hero-api
   ```
2. Acesse a pasta do projeto:
   ```bash
   cd backend/API
   ```
3. Rodar o Docker Compose:
   ```bash
   docker-compose up
   ```
4. Acesse a pasta do projeto:
   ```bash
   cd backend/Infrastructure
   ```
5. Rodar as Migrations:
   ```bash
   update-database
   ```
6. Execute o projeto:
   ```bash
   dotnet run
   ```

   ## Como Executar o Projeto Frontend
1. Clone este repositório:
   ```bash
   git clone https://github.com/devalvesg/hero-api
   ```
2. Acesse a pasta do projeto:
   ```bash
   cd frontend/hero-frontend
   ```
3. Baixar dependências:
   ```bash
   npm install
   ```
4. Execute o projeto
   ```bash
   npm run start
   ```

## Estrutura do Projeto
```
lib/
├── backend         # Todo o codigo-fonte do Backend
├── frontend/hero-frontend  # Todo o codigo-fonte do Frontend
└── readme
```

## Declarações do Autor
Acredito ser um desafio facil de resolver, mas me faltou tempo, priorizei meu foco no backend para desenvolver uma solução organizada, estruturada e padronizada. Utilizei Clean Architeture, Middlewares, Respostas padronizadas entre outras boas práticas de código.
Poderia ter dividido melhor meu tempo e usar no desenvolvimento do frontend para finalizar o que foi pedido.

Lição aprendida: Dividir melhor minha tarefas e estimativas mais reais, sempre contar com imprevistos, pois podem acontecer.
