# 🚀 Projeto CRUD API - .NET 6 + Entity Framework + SQL Server

API RESTful para gerenciamento de produtos, desenvolvida em ASP.NET Core 6 com Entity Framework e SQL Server.



---

## 🛠️ Tecnologias Utilizadas

- **.NET 6**
- **Entity Framework Core**
- **SQL Server**
- **Swagger** para documentação
- **Repository Pattern**
- **SOLID Principles**
- **Clean Code**

- ## 📸 Endpoints via Swagger

A API conta com documentação automática via Swagger. Abaixo, um exemplo dos endpoints disponíveis:

📬 **Endpoints principais**

- `GET    /api/Produto` — Lista todos os produtos
- `GET    /api/Produto/{id}` — Retorna um produto específico
- `POST   /api/Produto` — Cria um novo produto
- `PUT    /api/Produto/{id}` — Atualiza um produto existente
- `DELETE /api/Produto/{id}` — Remove um produto



<img width="1343" height="502" alt="api produtos" src="https://github.com/user-attachments/assets/a5e5b15f-f821-468a-8098-66607f6b9e3f" />

⚙️ Como rodar o projeto

1. Clone o repositório:
   git clone  https://github.com/Viniradis/projeto-crud-api.git

2. Acesse a pasta do projeto:
   cd projeto-crud-api

3. Configure a string de conexão no arquivo `appsettings.json`:
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=ProdutosDb;Trusted_Connection=True;"
   }

4. Execute as migrações (se necessário):
   dotnet ef database update

5. Rode o projeto:
   dotnet run

6. Acesse a API via Swagger:
   https://localhost:7221/swagger









