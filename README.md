# Ficha4_ISI – Web API Services

Este projeto foi desenvolvido no âmbito da unidade curricular **Integração de Sistemas de Informação (ISI)** do curso de **Engenharia de Sistemas Informáticos (IPCA)**.

O objetivo da ficha é criar e expor serviços web acessíveis através de endpoints HTTP, substituindo os antigos serviços ASMX (.NET Framework) por uma solução moderna e compatível com macOS, utilizando **ASP.NET Core Web API**.

---

## 🚀 Tecnologias Utilizadas

- **.NET 8/10 – ASP.NET Core Web API**
- **C#**
- **Swagger / OpenAPI 3.0** para documentação automática
- **JetBrains Rider** (IDE)
- **JSON** como formato de troca de dados

---

## 📂 Estrutura do Projeto

Ficha4_ISI/  
 ├── Controllers/  
 │   ├── CalculatorController.cs  
 │   ├── AdvancedCalcController.cs  
 │   ├── PodeEntrarController.cs  
 │   └── UtilsController.cs  
 ├── Program.cs  
 ├── appsettings.json  
 └── Ficha4_ISI.csproj  

---

## 📡 Endpoints Disponíveis

### 🔢 CalculatorController

Operações matemáticas básicas:

- GET `/api/Calculator/Add?a=…&b=…`
- GET `/api/Calculator/Sub?a=…&b=…`
- GET `/api/Calculator/Mul?a=…&b=…`
- GET `/api/Calculator/Div?a=…&b=…`

---

### 🧮 AdvancedCalcController

Funções matemáticas avançadas:

- GET `/api/AdvancedCalc/Pow?a=…&b=…`
- GET `/api/AdvancedCalc/Abs?v=…`
- GET `/api/AdvancedCalc/Factorial?n=…`

---

### ✉️ UtilsController

Funções auxiliares:

- GET `/api/Utils/ValidateEmail?email=…`  
  Valida se a string recebida tem formato de email válido.

---

### 🔐 PodeEntrarController

Validação de acesso com código + email:

- GET `/api/PodeEntrar/Verificar?codigo=…&email=…`  

Códigos válidos: `A1`, `B2`, `C3`.  
O método devolve **true** apenas se o código for válido e o email tiver formato correto.

---

## 📖 Swagger

O projeto gera automaticamente documentação Swagger.

Para executar a API:

1. Na pasta do projeto:

       dotnet run

2. Abrir o browser em:

       http://localhost:5072/swagger

A interface Swagger permite testar todos os endpoints diretamente no browser, ver parâmetros e respostas, e obter o ficheiro OpenAPI em JSON.

---

## 🎯 Objetivo do Projeto

- Implementar serviços web simples organizados em diferentes controladores.
- Expor funcionalidades através de endpoints HTTP (REST).
- Permitir o teste dos serviços via Swagger / OpenAPI.
- Demonstrar uma abordagem moderna a serviços em .NET, compatível com macOS.

---

## 👤 Autor

**Ricardo Guimarães**  
Estudante de Engenharia de Sistemas Informáticos – IPCA  

---

## 📄 Licença

Projeto desenvolvido para fins académicos, sem finalidade comercial.
