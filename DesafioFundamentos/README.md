# 🅿️ Sistema de Estacionamento

Este projeto é uma aplicação de console em C# que simula um sistema básico de estacionamento. O usuário pode cadastrar, remover e listar veículos, com cálculo automático de valor a ser pago conforme o tempo de permanência.

---

## 🚀 Funcionalidades

* ✅ Cadastro de veículos (com validação de placa).
* ✅ Remoção de veículos com cálculo de valor total.
* ✅ Listagem de veículos estacionados.
* ✅ Interface de menu simples via terminal.
* ✅ Validações básicas de entrada (valores e formatos).

---

## 💻 Como usar

1. **Clone o repositório ou abra o projeto em sua IDE.**
2. **Compile e execute o programa.**
3. **Informe os valores iniciais ao iniciar o sistema:**

    * Preço fixo inicial
    * Preço por hora
4. **Use o menu para interagir:**

   ```
   1 - Cadastrar veículo
   2 - Remover veículo
   3 - Listar veículos
   4 - Encerrar
   ```

---

## 📌 Regras do sistema

* A **placa** deve ter entre **1 e 7 caracteres**.
* Para **remover um veículo**, é necessário informar a **placa corretamente** e a **quantidade de horas** (maior que zero).
* O cálculo do valor é feito da seguinte forma:

  ```
  valorTotal = precoInicial + (precoPorHora * horas)
  ```

---

## 📂 Estrutura

* `Program.cs`: Contém o fluxo principal da aplicação e o menu.
* `Estacionamento.cs`: Classe responsável pelas operações de estacionamento.

---

## 🛠️ Tecnologias

* [.NET Console Application](https://learn.microsoft.com/dotnet/core/)
* C# 10+
* Pattern Matching
* Programação Orientada a Objetos

---

## ✍️ Exemplo de uso

```
Digite o preço inicial:
>> 5

Agora digite o preço por hora:
>> 2

Digite a sua opção:
1 - Cadastrar veículo
>> ABC1234

Digite a sua opção:
3 - Listar veículos
>> ABC1234

Digite a sua opção:
2 - Remover veículo
>> ABC1234
>> Quantidade de horas: 3

Veículo removido. Total a pagar: R$ 11,00
```

---

## 📌 Observações

* A aplicação trata entradas inválidas com laços de repetição e validações simples.
* O sistema foi feito para fins de aprendizado e prática de conceitos fundamentais de C#.

