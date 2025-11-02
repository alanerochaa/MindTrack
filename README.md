
# 🧠 MindTrack

MindTrack é um sistema moderno de **gerenciamento de produtividade, foco e tarefas pessoais**, desenvolvido com **.NET 8 e ASP.NET Core Web API**, aplicando princípios de **Clean Architecture** e **boas práticas de DevOps e Cloud**.

---

## 📋 Índice
1. [Visão Geral](#visão-geral)
2. [Objetivo do Projeto](#objetivo-do-projeto)
3. [Funcionalidades Principais](#funcionalidades-principais)
4. [Arquitetura da Solução](#arquitetura-da-solução)
5. [Tecnologias Utilizadas](#tecnologias-utilizadas)
6. [Instalação e Execução](#instalação-e-execução)
7. [Contribuição](#contribuição)
8. [Autores](#autores)

---

## 🚀 Visão Geral

O **MindTrack** é um projeto que busca **ajudar usuários a manter o foco e gerenciar suas tarefas**, registrando períodos de concentração e apresentando um **dashboard com estatísticas de desempenho**.

Ele foi desenvolvido seguindo boas práticas de arquitetura e separação de responsabilidades, sendo dividido em múltiplas camadas (Domain, Application, Infrastructure e Presentation).

---

## 🎯 Objetivo do Projeto

Oferecer uma ferramenta completa e intuitiva que auxilie estudantes e profissionais a **aumentar sua produtividade** e compreender melhor seus **hábitos de foco e desempenho pessoal**.

---

## ⚙️ Funcionalidades Principais

- 🧾 Criação, listagem e conclusão de tarefas
- ⏱️ Registro de sessões de foco (Pomodoro)
- 💾 Persistência de dados com Entity Framework Core
- 🧱 Estrutura modular em camadas (Clean Architecture)

---

## 🏗️ Arquitetura da Solução

```
src/
 ├── MindTrack.Domain/           → Entidades e contratos
 ├── MindTrack.Application/      → Casos de uso e serviços
 ├── MindTrack.Infrastructure/   → Persistência e banco de dados
 └── MindTrack.Presentation/     → Controllers e endpoints (API REST)
```

A aplicação segue o padrão **Clean Architecture**, garantindo baixo acoplamento e alta manutenibilidade.

---

## 🧰 Tecnologias Utilizadas

- **C# / .NET 8**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **GitHub Actions (CI/CD)**
- **Visual Studio / VS Code**

---

## 🖥️ Instalação e Execução

### Pré-requisitos
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [Git](https://git-scm.com/)

### Passos

```bash
# 1️⃣ Clone o repositório
git clone https://github.com/alanerochaa/MindTrack.git

# 2️⃣ Acesse o diretório do projeto
cd MindTrack/src/MindTrack.Presentation

# 3️⃣ Restaure pacotes
dotnet restore

# 4️⃣ Execute o projeto
dotnet run 

```

A aplicação iniciará em:  
👉 **http://localhost:5206/swagger**

---


## 🤝 Contribuição

Contribuições são bem-vindas!  
Siga as etapas abaixo:

1. Faça um **fork** do projeto  
2. Crie uma **branch** (`feature/nova-funcionalidade`)  
3. Faça suas alterações e **commit**  
4. Envie um **pull request**

---

## 👩‍💻 Autores

| Nome | Função |
|------|--------|
| **Alan Rocha** | Desenvolvedor Backend / Arquiteto de Software |
| **Maria Eduarda Araujo Penas** | Desenvolvedora Backend  |

---


**✨ MindTrack – Foco, Produtividade e Clareza Mental.**

"Mantenha sua mente alinhada com seus objetivos." 🧠💡
