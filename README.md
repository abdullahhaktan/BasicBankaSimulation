# BasicBankaSimulation

[TR]

**Temel Bankacılık İşlemleri Simülasyon Uygulaması**

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/) 
[![OOP](https://img.shields.io/badge/Concept-OOP-orange.svg)]() 
[![Platform](https://img.shields.io/badge/Platform-Console%20%7C%20Desktop%20App-informational.svg)]() 
[![MSSQL](https://img.shields.io/badge/Database-MSSQL-green.svg)](https://learn.microsoft.com/en-us/sql/sql-server/)
[![GitHub repo size](https://img.shields.io/github/repo-size/abdullahhaktan/BasicBankaSimulation)](https://github.com/abdullahhaktan/BasicBankaSimulation)


---

## 💻 Proje Hakkında

Bu proje, temel bankacılık süreçlerini ve işlemlerini simüle etmek için geliştirilmiş bir uygulamadır. Ana amaç, **Nesne Yönelimli Programlama (OOP)** prensiplerini kullanarak **Hesap** ve **Müşteri** gibi sınıfları modellemek ve bu sınıflar aracılığıyla **para yatırma, para çekme ve bakiye sorgulama** gibi işlemleri gerçekleştirmektir.

Proje, hem temel programlama mantığını pekiştirmek hem de gerçek dünya senaryolarını kod ile nasıl modellediğimizi göstermek için idealdir.

---

## ✨ Temel Özellikler ve OOP Uygulaması

### Bankacılık İşlevleri
* **Hesap Oluşturma:** Yeni müşteri ve hesap kaydı.
* **Para Yatırma (Deposit):** Hesaba para ekleme işlemi.
* **Para Çekme (Withdrawal):** Yeterli bakiye kontrolü yapılarak hesaptan para çekme.
* **Bakiye Görüntüleme:** Mevcut hesap bakiyesini sorgulama.

### Nesne Yönelimli Uygulama (OOP)
* **Sınıflar (Classes):** **`Account`** (Hesap) ve **`Customer`** (Müşteri) gibi nesnelerin tanımlanması.
* **Kapsülleme (Encapsulation):** Bakiye gibi hassas verilerin, **`private`** alanlar ve **`public`** metotlar (yatırma/çekme) aracılığıyla korunması.
* **Metotlar (Methods):** Her bir bankacılık işleminin (örneğin `Deposit()`, `Withdraw()`) ayrı bir metot olarak tanımlanması.

### Kullanılan Teknolojiler
* **C#:** Programlama dili.
* **.NET (Console):** Uygulama altyapısı (genellikle hızlı prototipleme için Konsol uygulaması).

---

## 🚀 Nasıl Çalıştırılır?

Bu proje, C# dilinde yazılmış basit bir Konsol veya Masaüstü uygulamasıdır.

1.  **Projeyi Klonlama:**
    ```bash
    git clone [https://github.com/abdullahhaktan/BasicBankaSimulation](https://github.com/abdullahhaktan/BasicBankaSimulation)
    cd BasicBankaSimulation
    ```

2.  **Projeyi Açma:**
    * **Visual Studio** ile `.sln` (Solution) dosyasını açın.

3.  **Çözümü Başlatma:**
    * Projeyi derleyin ve Konsol Uygulamasını **F5** tuşu ile çalıştırın. Uygulama, etkileşimli menüler aracılığıyla bankacılık işlemlerini simüle etmeye başlayacaktır.

---
---

[EN]

# BasicBankaSimulation

**Basic Banking Operations Simulation Application**

---

## 💻 About the Project

This project is an application developed to simulate fundamental banking processes and transactions. The main goal is to practice **Object-Oriented Programming (OOP)** principles by modeling classes like **`Account`** and **`Customer`** and performing operations such as **deposit, withdrawal, and balance inquiry** through these classes.

The project is ideal for both reinforcing core programming logic and demonstrating how to model real-world scenarios with code.

---

## ✨ Core Features and OOP Implementation

### Banking Functionality
* **Account Creation:** Registration of new customers and accounts.
* **Deposit:** Operation to add money to an account.
* **Withdrawal:** Drawing money from an account, with checking for sufficient balance.
* **Balance Inquiry:** Querying the current account balance.

### Object-Oriented Implementation (OOP)
* **Classes:** Defining objects like **`Account`** and **`Customer`**.
* **Encapsulation:** Protecting sensitive data like the balance using **`private`** fields and managing access through **`public`** methods (deposit/withdrawal).
* **Methods:** Defining each banking operation (e.g., `Deposit()`, `Withdraw()`) as a separate method.

### Technologies Used
* **C#:** The programming language.
* **.NET (Console):** The application framework (often a Console application for quick prototyping).

---

## 🚀 How to Run

This project is a simple Console or Desktop application written in C#.

1.  **Cloning the Project:**
    ```bash
    git clone [https://github.com/abdullahhaktan/BasicBankaSimulation](https://github.com/abdullahhaktan/BasicBankaSimulation)
    cd BasicBankaSimulation
    ```

2.  **Opening the Project:**
    * Open the **`.sln`** (Solution) file with **Visual Studio**.

3.  **Starting the Solution:**
    * Build the project and run the Console Application by pressing **F5**. The application will start simulating banking transactions via interactive menus.

---
---

<img width="539" height="413" alt="Ekran görüntüsü 2025-10-03 145115" src="https://github.com/user-attachments/assets/17fefce1-e2fe-45b8-a434-b27a9e55be47" />
