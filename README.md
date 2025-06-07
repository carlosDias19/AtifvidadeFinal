# AtividadeAula - Documentação de Arquitetura e Boas Práticas

Este projeto segue princípios modernos de desenvolvimento de software, incluindo Clean Code, Design Patterns, Qualidade de Software, Clean Architecture, APIs RESTful e práticas para integração com LLMs (Modelos de Linguagem).

---

## 1. Clean Code

- **Nomenclatura clara:** Classes, métodos e variáveis usam nomes descritivos e autoexplicativos.
  - Exemplo: `PontoTuristicoApplication`, `GetPontoTuristicoById`, `BuscarPorNomeOuDescricao`.
- **Métodos curtos e coesos:** Cada método executa uma única responsabilidade.
- **Remoção de código morto:** O código é mantido limpo, sem comentários desnecessários ou código não utilizado.
- **Exemplo:**  
  - `DomainService/Service/PontoTuristicoService.cs`  
  - `ConsoleApp1/Application/PontoTuristicoApplication.cs`

---

## 2. Design Patterns

- **Repository Pattern:**  
  - Implementado em `DDD.Infra.SQLServer/Repositories/EstadoRepositorySqlServer.cs` e `PontoTuristicoSqlServer.cs` para abstrair o acesso a dados.
- **Service Layer:**  
  - Camada de serviços em `DomainService/Service` centraliza regras de negócio.
- **Dependency Injection:**  
  - Configurada em `DDD.Application.Api/Program.cs` usando `AddScoped` para injeção de dependências.
- **Interface Segregation:**  
  - Interfaces como `IEstadoRepository`, `IPontoTuristicoService` garantem baixo acoplamento.

---

## 3. Qualidade de Software

- **Testes Unitários:**  
  - Recomenda-se criar testes em um projeto separado, por exemplo, `AtividadeAula.Tests`, utilizando xUnit e Moq.
- **Validações e tratamento de erros:**  
  - Exemplo: `PontoTuristicoService.DeletePontoTuristico` lança exceção se o registro não existir.
- **SOLID:**  
  - Classes e métodos seguem princípios de responsabilidade única e baixo acoplamento.

---

## 4. Clean Architecture

- **Separação de camadas:**  
  - `Domain`: Entidades e regras de negócio.
  - `Application`: Orquestração de casos de uso.
  - `Infra`: Implementação de persistência.
  - `Api`: Exposição de endpoints REST.
- **Interfaces entre camadas:**  
  - Exemplo: `IEstadoRepository`, `IPontoTuristicoApplication`.
- **Injeção de dependências:**  
  - Configurada em `Program.cs`.

---

## 5. APIs

- **Controllers RESTful:**  
  - `DDD.Application.Api/Controllers/EstadoController.cs`
  - `DDD.Application.Api/Controllers/PontoTuristicoController.cs`
- **Swagger:**  
  - Documentação automática configurada em `Program.cs`.
- **DTOs (Sugestão):**  
  - Para maior segurança, recomenda-se criar DTOs para entrada/saída de dados.

---

## 6. LLMs (Modelos de Linguagem)

- **Documentação clara:**  
  - Métodos e classes bem documentados facilitam integração e entendimento por IAs.
- **Padronização:**  
  - Seguir padrões de código e nomenclatura facilita o uso de ferramentas de IA para geração de código, revisão e automação.

---


---

## Como Executar

1. Delete a pasta de migrations. 
2. Execute as migrações: Add-Migration Inicial
                         Update-Database
