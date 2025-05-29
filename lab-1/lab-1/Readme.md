# Система управління складом — Принципи програмування

У цьому файлі описано, як дотримано основних принципів програмування в реалізації лабораторної роботи з використанням мови C#.

## ✅ Продемонстровані принципи

### 1. **Single Responsibility Principle (SOLID - S)**

Кожен клас виконує лише одну відповідальність:

* `Money` — робота з валютою ([classes/Money.cs](https://github.com/OlexanderPavliuk/Kpz_Pavliuk_Ipz-23-2/blob/6b920c371d17aa5808853c1efeac48dab892f37a/lab-1/lab-1/Classes/Money.cs))
* `Product` — опис товару, зміна ціни ([classes/Product.cs](https://github.com/OlexanderPavliuk/Kpz_Pavliuk_Ipz-23-2/blob/6b920c371d17aa5808853c1efeac48dab892f37a/lab-1/lab-1/Classes/Product.cs))
* `WarehouseItem` — облік одиниць товару на складі ([(classes/WarehouseItem.cs](https://github.com/OlexanderPavliuk/Kpz_Pavliuk_Ipz-23-2/blob/6b920c371d17aa5808853c1efeac48dab892f37a/lab-1/lab-1/Classes/WarehouseItem.cs))
* `Reporting` — облік надходжень, відвантажень, інвентаризація ([classes/Reporting.cs](https://github.com/OlexanderPavliuk/Kpz_Pavliuk_Ipz-23-2/blob/6b920c371d17aa5808853c1efeac48dab892f37a/lab-1/lab-1/Classes/Reporting.cs))

### 2. **Open/Closed Principle (SOLID - O)**

Класи, такі як `Product` та `Money`, можна розширити (додавши дочірні класи, методи), не змінюючи існуючий код.

### 3. **Liskov Substitution Principle (SOLID - L)**

Хоча наслідування прямо не використовується, методи `Display()` і `ReducePrice()` можуть бути успішно перевизначені в похідних класах.

### 4. **Interface Segregation Principle (SOLID - I)**

Принцип реалізовано частково через розділення логіки по класах. Якщо додати інтерфейси для `IDisplayable`, `IPriceAdjustable` то можна його повністю дотриматись.

### 5. **Dependency Inversion Principle (SOLID - D)**

Поки що класи залежать від реалізацій, але їх легко можна перевести на залежність від абстракцій, наприклад: `IProduct`, `IItem`, щоб реалізувати цей принцип.

### 6. **DRY (Don't Repeat Yourself)**

Усі повторювані фрагменти логіки винесено в методи: `Display()`, `Decrease()` (див. `Money.cs`, `Product.cs`).

### 7. **KISS (Keep It Simple, Stupid)**

Код простий, з лаконічною структурою, без зайвої складності. Всі класи легко читаються і зрозумілі.

### 8. **YAGNI (You Aren't Gonna Need It)**

Не реалізовано зайвого функціоналу — лише те, що необхідно за завданням (наприклад, не використано складну ієрархію).

### 9. **Composition Over Inheritance**

Композиція використана замість наслідування: `WarehouseItem` включає `Product`, а `Product` включає `Money`.

### 10. **Fail Fast**

Метод `Ship()` одразу повідомляє про помилку, якщо неможливо відвантажити товар (див. `Reporting.cs`).

---

## 🗂 Файли

* `Program.cs` — метод `Main()` для демонстрації функціональності
* `classes/` — окрема папка з усіма класами системи:

  * `Money.cs`
  * `Product.cs`
  * `WarehouseItem.cs`
  * `Reporting.cs`
* `README.md` — опис принципів

## 🔗 Посилання

* [Синтаксис Markdown](https://markdown.guide/basic-syntax/)
* [Посилання на рядки коду](https://docs.github.com/ru/repositories/working-with-files/using-files/linking-to-lines-in-a-file)

---

> *Лабораторна робота: Система управління складом, C#*
