# 🚀 Projeto CRUD API - .NET 6 + Entity Framework + SQL Server (com opção de banco em memória)

API RESTful para gerenciamento de produtos, desenvolvida em **ASP.NET Core 6** utilizando **Entity Framework Core**. O projeto foi inicialmente implementado em **SQL Server**, mas também contando com uma versão alternativa utilizando **banco de dados em memória**, conforme solicitado no desafio técnico.

Essa abordagem permite flexibilidade tanto para ambientes de produção quanto para testes rápidos e demonstrações, mantendo a mesma estrutura de código e funcionalidades.

---

## 🛠️ Tecnologias Utilizadas

- **.NET 6**
- **Entity Framework Core**
- **SQL Server**
- **InMemoryDatabase**
- **Swagger** para documentação automática
- **Repository Pattern**
- **SOLID Principles**
- **Clean Code**

---

## 📸 Endpoints via Swagger

A API conta com documentação automática via Swagger. Abaixo, um exemplo dos endpoints disponíveis:

📬 **Endpoints principais**

- `GET    /api/Produto` — Lista todos os produtos  
- `GET    /api/Produto/{id}` — Retorna um produto específico  
- `POST   /api/Produto` — Cria um novo produto  
- `PUT    /api/Produto/{id}` — Atualiza um produto existente  
- `DELETE /api/Produto/{id}` — Remove um produto  

<img width="1343" height="502" alt="api produtos" src="https://github.com/user-attachments/assets/a5e5b15f-f821-468a-8098-66607f6b9e3f" />

🗄️ Tabela de Produtos no SQL Server
A imagem abaixo apresenta a tabela utilizada, implementada com SQL Server. Ela representa a estrutura principal de dados da aplicação, contendo os campos essenciais para o gerenciamento de produtos via API RESTful. Também será disponibilizada uma versão alternativa utilizando banco de dados em memória, conforme solicitado no desafio técnico.

<img width="453" height="135" alt="tabel sql " src="https://github.com/user-attachments/assets/5fadb104-5d0e-4317-9640-94b830682777" />


---

## ⚙️ Observações

- A versão atual utiliza **SQL Server** como banco de dados principal.
- Uma versão com **banco em memória** será disponibilizada para facilitar testes e execução sem dependências externas.
- Ambas as versões compartilham a mesma estrutura de código e endpoints.




