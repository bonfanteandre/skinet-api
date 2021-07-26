 Cria um novo arquivo de solução
```
$ dotnet new sln <nome da solution>
```

Cria um novo projeto web
```
$ dotnet new webapi -o <nome da pasta do projeto>
```

Adiciona um projeto a solução
```
$ dotnet sln add <pasta do projeto/ arquivo .csproj>
```

Lista os projetos da solução
```
$ dotnet sln list
```

Executa um projeto
```
$ dotnet run
```

Executa um projeto (hot reload)
```
$ dotnet watch run
```

Confiar no certificado da aplicação
```
$ dotnet dev-certs https -t
```

Instala linha de comando do EF
```
$ dotnet tool install --global dotnet-ef
```

Gerar uma migration
```
$ dotnet ef migrations add <nome da migration> -o <pasta>
```

Executar as migrations
```
$ dotnet ef database update
```

Remover uma migration
```
$ dotnet ef database drop <nome da migration>
```

Criar um projeto de biblioteca de classes
```
$ dotnet new classlib -o <nome do projeto>
```

Adicionar uma referência a um projeto
```
$ dotnet add reference <pasta do projeto/ arquivo .csproj>
```

Restaura referências e pacotes da solução
```
$ dotnet restore
```

```
$ 
```