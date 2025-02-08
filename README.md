
# Dicta Sanctorum
Uma Lembrança diaria de que a santidade é possivel e alcançável


## Estrutura de Pastas

```filetree
Dicta-Sanctorum
└── Dicta-Sanctorum
|   ├── backend
|       ├── Controllers
|       ├── Models
|       ├── Repositories
|       ├── Services
|       ├── Program.cs
|       ├── Startup.cs
|       └── appsettings.json
|   ├── frontend
|       ├── src
|           ├── app
|               ├── components
|               ├── services
|               ├── models
|               └── app.module.ts
|           ├── assets
|           ├── environments
|           ├── index.html
|           ├── main.ts
|           └── styles.scss
|       ├── angular.json
|       ├── package.js
|       ├── tsconfig.app.json
|       ├── tsconfig.json
|       └── tsconfig.spec.json
|   ├── CHANGELOG.md
|   └── README.md

## Funcionalidades
### MVP
- Temas dark e light
- Gera a frase aleatoria de um Santo
- santo do dia
- compartilhamento via link da frase
- Multiplataforma

### Adiçoes Futuras
- compartilhamento via whatsapp
- compartilhamento via instagram
- pode favoritar a frase
- liturgia diária com direcionamento de videos de homilias 
- biografia dos santos 
- login para ver as frases favoritadas 
 




 ## Tecnologias, Padrões e Arquitetura  

### Tecnologias Utilizadas  
#### Backend  
- **Linguagem:** C#  
- **Framework:** ASP.NET Core  
- **Bibliotecas:**  
  - **Serilog:** Para gerenciamento de logs estruturados  
  - **Dapper:** Para mapeamento objeto-relacional (ORM leve)  
- **Arquitetura:** API RESTful  

#### Frontend  
- **Framework:** Angular v17  
- **Bibliotecas:**  
  - **PrimeFaces:** Componentes UI ricos  
  - **Bootstrap:** Para layout e estilização responsiva  

#### Outros  
- **Controle de Versão:** Git  
- **Hospedagem:** AWS (provavelmente, devido ao período gratuito)  

### Padrões e Arquitetura  
- **Arquitetura:**  
  - Onion Architecture (Arquitetura em Camadas baseada em DDD)  
- **Padrões de Projeto:**  
  - Repository Pattern  
  - Result Pattern  
- **Princípios de Desenvolvimento:**  
  - SOLID  
  - DRY (Don't Repeat Yourself)  
  - KISS (Keep It Simple, Stupid)  

### Fluxo de Trabalho e Metodologias  
- **Commits:** Commits Semânticos  
- **Fluxo Git:** GitFlow  
- **Integração e Entrega Contínua:** GitHub Actions  
- **Metodologia de Testes:** TDD (Test-Driven Development)
