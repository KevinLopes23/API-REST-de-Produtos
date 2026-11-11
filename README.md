<div align="center">

# 📦 API REST de Produtos

**CRUD de produtos com ASP.NET Core, Entity Framework Core e PostgreSQL.**

![C#](https://img.shields.io/badge/C%23-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-4169E1?style=for-the-badge&logo=postgresql&logoColor=white)
![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)

</div>

## 💡 Sobre

API para cadastrar, consultar, atualizar e remover produtos (nome, preço e estoque). Os dados ficam no PostgreSQL via Entity Framework Core, com migration inicial incluída, e a documentação interativa fica disponível no Swagger.

## ✨ Funcionalidades

- CRUD completo de produtos
- Persistência em PostgreSQL com EF Core e migrations
- Swagger UI habilitado

## 🛠️ Tecnologias

- C# / ASP.NET Core (.NET 8)
- Entity Framework Core + Npgsql
- PostgreSQL
- Swashbuckle (Swagger)

## 📌 Endpoints

| Método | Rota | Descrição |
|--------|------|-----------|
| `GET` | `/api/produtos` | Lista todos os produtos |
| `GET` | `/api/produtos/{id}` | Busca um produto pelo ID |
| `POST` | `/api/produtos` | Cadastra um produto (`nome`, `preco`, `estoque`) |
| `PUT` | `/api/produtos/{id}` | Atualiza um produto |
| `DELETE` | `/api/produtos/{id}` | Remove um produto |

## 🚀 Como rodar

Requer .NET 8 SDK, PostgreSQL e a ferramenta `dotnet-ef`.

1. Ajuste a connection string `ConnectionStrings:DefaultConnection` em `ProdutosAPI/ProdutosAPI/appsettings.json` (ou use a variável de ambiente `ConnectionStrings__DefaultConnection`).
2. Rode:

```bash
git clone https://github.com/KevinLopes23/API-REST-de-Produtos.git
cd API-REST-de-Produtos/ProdutosAPI/ProdutosAPI
dotnet ef database update
dotnet run
```

O Swagger fica em `http://localhost:5021/swagger`.

## 👤 Autor

Feito por [Kevin Lopes](https://github.com/KevinLopes23)
