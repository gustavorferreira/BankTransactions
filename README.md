﻿<h1 align="center">Sistema de cadastro via API com .NET Core e EF Core | Clean Code and SOLID</h1>

<p align="center">
  <a href="#-tecnologias">Tecnologias</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-projeto">Projeto</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-como-executar">Como executar</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-licença">Licença</a>
</p>

<p align="center">
<a href="https://travis-ci.org/laravel/framework"><img src="https://travis-ci.org/laravel/framework.svg" alt="Build Status"></a>
<a href="https://packagist.org/packages/laravel/framework"><img src="https://img.shields.io/packagist/dt/laravel/framework" alt="Total Downloads"></a>
<a href="https://packagist.org/packages/laravel/framework"><img src="https://img.shields.io/packagist/v/laravel/framework" alt="Latest Stable Version"></a>
<a href="https://packagist.org/packages/laravel/framework"><img src="https://img.shields.io/packagist/l/laravel/framework" alt="License"></a>
</p>

<p align="center">
    <a href="https://laravel.com" target="_blank"><img src="https://user-images.githubusercontent.com/48185499/150372342-47c64427-71a3-4c97-8681-03ba9dd1206d.gif" </a></p>

## ✨ Tecnologias

Esse projeto foi desenvolvido com as seguintes tecnologias:

- [Entity Framework Core, SQL e Tools v6.0.4](https://docs.microsoft.com/pt-br/ef/core/)

## 💻 Projeto

O Web Service feito com Framework Core, MVC, que simula uma Transação Bancária em API.


## 🚀 Como executar

Pré requisitos para executar o projeto:

- Servidor Web
- Banco de dados Microsoft SQL Server

No terminal do NuGet execute os comandos abaixo:
- Crie a migration com o comando `Add-Migration "Initial Create"`
- Crie o banco de dados com `Update-Database"`

- Configure seu banco de dados local em `appsettings.json`
- Inicie o servidor `CTRL + F5`
- Agora você pode acessar [`http://localhost:5117/`](http://localhost:5117/) do seu navegador.
- Campos obrigatórios:
    
            'AccountNumber' => 'required',
            'BeneficiaryName' => 'required',
            'BankName' => 'required|max:11',
            'SwiftCode' => 'required',
            'Amount' => 'required|max:1',
    
## 📄 Licença

Esse projeto está sob a licença MIT.

---

Feito com ♥ by GRF 👋🏻
