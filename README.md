
# Registro de Alunos

Neste projeto foi desenvolvido uma aplicação com o intuito de gerenciar todos os registros de estudantes de uma rede de ensino.

Utilizando Vuejs para o Front-end, juntamente com vuetify, e a linguagem C#, utilizando Entity Framework para construção da API e para persistencia dos dados foi utilizado PostgreSQL.

Sendo um sistema CRUD podemos ler, adicionar, editar e excluir dados do nosso Database.
Com as rotas:
 - GET `/api/Students`
 - POST `/api/Students`
 - PUT `/api/Students/${id}`
 - DELETE `/api/Students/${id}`
## Stack utilizada

**Front-end:** Vuejs, Vuetify.

**Back-end:** C#, .NET 6.0,Entity framework.



## Rodando localmente

Para utilizar o projeto localmente basta seguir estes passos:

#### Clone o projeto

```bash
  git clone git@github.com:doug-0/registro-alunos.git
```

#### Atenção
- Ceritfique-se de ter o [Node](https://nodejs.org/pt-br/), [Dotnet](https://dotnet.microsoft.com/en-us/) e [PostgreSQL](https://www.postgresql.org/) instalados e rodando na sua máquina.


## Back-end

```bash
  cd registro-alunos/backend
```

#### Para criar o Database com as migrations

```bash
  dotnet ef database update
```

 - O banco será criado e populado com alguns dados já existentes nos seeders.


#### Para iniciar a API

```bash
  dotnet run
```

- A API será exposta nas portas `https://localhost:7145` e `http://localhost:5157`
- Com o Back-end em execução e acessando `https://localhost:7145/swagger`, você terá acesso à todos os endpoints existentes nesta API.


## Front-end

```bash
  cd registro-alunos/frontend
```

#### Instale as dependências


```bash
  npm install
```

#### Inicie o frontend como o comando

```bash
   npm run serve
```
- O Front-end será exposto na porta ```http://localhost:8080/```



