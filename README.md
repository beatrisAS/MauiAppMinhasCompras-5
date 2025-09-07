# 🛒 Aplicativo Minhas Compras (.NET MAUI)

![.NET 9](https://img.shields.io/badge/.NET-9.0-blueviolet)
![MAUI](https://img.shields.io/badge/Mobile-MAUI-ff69b4)
![Status](https://img.shields.io/badge/Status-Concluído-brightgreen)
![License](https://img.shields.io/badge/Licença-MIT-blue)

**Repositório do aplicativo de controle de compras** desenvolvido para a **Agenda 6** da disciplina *Desenvolvimento de Sistemas III* do curso Técnico em Desenvolvimento de Sistemas.

Aplicativo para **cadastro e visualização de produtos**, permitindo registrar nome, quantidade, preço, com listagem organizada, seleção de categoria e design moderno.

✔ **Interface intuitiva e responsiva**

✔ **Cadastro rápido de produtos**

✔ **Lista dinâmica com visual limpo e polido**

✔ **Compatível com Android, iOS e Windows**

✔ **Relatório inteligente de gastos por categoria**

---

## 📝 Descrição do Projeto

Sistema de controle simples para gerenciar uma lista de compras com as seguintes funcionalidades:

* **Cadastro de produtos** (nome, quantidade, preço e categoria)
* **Listagem com visual moderno**
* **Armazenamento local utilizando SQLite**

---

## ✨ Recursos Implementados

✅ **Entrada de dados com Entry** para nome, quantidade e preço e categoria

✅ **Lista de produtos utilizando CollectionView**

✅ **Layout moderno com Frames, cores e sombras**

✅ **Design responsivo e adaptado para dispositivos móveis**

✅ **Persistência de dados com banco SQLite**

✅ **ListView com ContextActions** para editar e remover itens 

✅ **Confirmação de exclusão com DisplayAlert**  

✅ **Evento ItemSelected** para navegar para tela de edição  

✅ **Refresh automático (Pull to Refresh)**  

✅ **Filtros por categoria utilizando Picker**

✅ **Relatório de gastos por categoria, exibindo o total gasto em cada tipo de produto**

---

## 🛠 Tecnologias Utilizadas

* **Front-end**: XAML (MAUI)
* **Back-end**: C# (lógica e persistência de dados)
* **Banco de dados**: SQLite
* **Plataforma**: .NET MAUI (Multi-platform App UI)

---

## 📂 Estrutura do Projeto

```
MauiAppMinhasCompras/  
├── Helpers/  
│   ├── SQLiteDatabaseHelper.cs  # Classe para manipulação do banco SQLite  
├── Models/  
│   ├── Produto.cs               # Modelo de dados do produto  
├── MainPage.xaml                 # Tela principal com cadastro e lista  
├── App.xaml                      # Configurações globais e recursos  
└── README.md                     # Esta documentação  
```

---

## 🚀 Como Executar

1. **Pré-requisitos**:

   * .NET 9.0 SDK instalado
   * Visual Studio 2022 ou superior (com suporte ao MAUI)

2. **Clone o repositório**:

   ```bash
   git clone https://github.com/seuusuario/MauiAppMinhasCompras.git
   ```

3. **Restaure os pacotes e execute o projeto**:

   ```bash
   dotnet build
   dotnet run --project MauiAppMinhasCompras
   ```

4. **Teste no emulador Android, iOS ou Windows**

---

## 🎥 Demonstração do App

Assista ao vídeo demonstrando o funcionamento do aplicativo no YouTube:

<a href="https://youtu.be/UqvdKK3-APE" target="_blank">Clique aqui para ver o vídeo!</a>

---

## 📌 Informações Acadêmicas

| Item           | Detalhe                                   |
| -------------- | ----------------------------------------- |
| **Disciplina** | Desenvolvimento de Sistemas III            |
| **Curso**      | Técnico em Desenvolvimento de Sistemas    |
| **Objetivo**   | Sistema de cadastro e listagem de compras |

---

> 💡 **Dica**: personalize as cores e estilos no arquivo `Styles.xaml` para deixar o app com a identidade visual da sua preferência.
