# 📘 LINQ Exam

## 🎯 Goal / Цель / Мақсад

**EN:** This exam evaluates students' knowledge of LINQ in C#
**RU:** Этот экзамен проверяет знания студентов по LINQ в C#
**TJ:** Ин санҷиш донишҳои донишҷӯёнро дар мавзӯи LINQ (C#) месанҷад

---

## 📦 Models / Модели / Моделҳо

```csharp
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public int CityId { get; set; }
}

public class City
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Population { get; set; }

    public int CountryId { get; set; }
}

public class Country
{
    public int Id { get; set; }
    public string Name { get; set; }
}
```

---

## 📋 Rules / Правила / Қоидаҳо

* **EN:** Use only LINQ (Method Syntax). No loops. Write clean and readable code. Each task should be a separate method

* **RU:** Использовать только LINQ (Method Syntax). Циклы запрещены. Код должен быть чистым и читаемым. Каждый task отдельный метод

* **TJ:** Фақат LINQ (Method Syntax) истифода баред. Циклҳо манъ аст. Код бояд тоза ва фаҳмо бошад. Ҳар як task методи алоҳида

---

# 🧪 Tasks

---

### Task 1

* **EN:** Retrieve all people who live in cities with population greater than 3 million
* **RU:** Получить всех людей, живущих в городе с населением более 3 миллионов
* **TJ:** Ҳамаи одамонеро гиред, ки дар шаҳр бо аҳолии зиёда аз 3 миллион зиндагӣ мекунанд

---

### Task 2

* **EN:** Get all cities with above average population in their country
* **RU:** Получить все города с населением выше среднего в стране
* **TJ:** Ҳамаи шаҳрҳоро гиред, ки аҳолии онҳо аз миёнаи кишвар зиёд аст

---

### Task 3

* **EN:** Retrieve cities with the highest population in each country
* **RU:** Получить города с самым высоким населением в каждой стране
* **TJ:** Шаҳрҳоро гиред, ки дар ҳар як кишвар аҳолии аз ҳама зиёд доранд

---

### Task 4

* **EN:** Retrieve all people with their city and country names
* **RU:** Получить всех людей вместе с названиями их города и страны
* **TJ:** Ҳамаи одамонро бо номи шаҳр ва кишвари онҳо гиред

---

### Task 5

* **EN:** Retrieve all cities that have a person named "Alice" (case insensitive)
* **RU:** Получить все города, где есть человек по имени "Alice" (без учета регистра)
* **TJ:** Ҳамаи шаҳрҳоро гиред, ки дар онҳо шахсе бо номи "Alice" вуҷуд дорад (бе фарқияти ҳарфҳои калон ва хурд)

---

### Task 6

* **EN:** Find the oldest person in each city
* **RU:** Найти самого старшего человека в каждом городе
* **TJ:** Дар ҳар як шаҳр пиронсолтарин одамро ёбед

---

### Task 7

* **EN:** Find people living in the most populated city of each country
* **RU:** Найти людей, живущих в самом густонаселенном городе каждой страны
* **TJ:** Одамонеро ёбед, ки дар шаҳри аз ҳама сераҳолии ҳар як кишвар зиндагӣ мекунанд

---

### Task 8

* **EN:** Find people living in cities with name length equal to N
* **RU:** Найти людей, живущих в городах с длиной имени равной N
* **TJ:** Одамонеро ёбед, ки дар шаҳрҳое зиндагӣ мекунанд, ки дарозии номи онҳо ба N баробар аст

---

### Task 9

* **EN:** Find the youngest person in each country
* **RU:** Найти самого молодого человека в каждой стране
* **TJ:** Дар ҳар як кишвар ҷавонтарин одамро ёбед

---

### Task 10

* **EN:** Find the city with the highest number of people in a given age range
* **RU:** Найти город с наибольшим количеством людей в заданном возрастном диапазоне
* **TJ:** Шаҳреро ёбед, ки дар он шумораи одамон дар доираи синни додашуда аз ҳама зиёд аст

---

### Task 11

* **EN:** Retrieve cities that have more than 2 people
* **RU:** Получить города, в которых живет более 2 человек
* **TJ:** Шаҳрҳоро гиред, ки дар онҳо зиёда аз 2 нафар зиндагӣ мекунанд

---

### Task 12

* **EN:** Retrieve countries that have at least one city with population less than 1 million
* **RU:** Получить страны, в которых есть хотя бы один город с населением менее 1 миллиона
* **TJ:** Кишварҳоро гиред, ки дар онҳо ҳадди ақал як шаҳр бо аҳолии камтар аз 1 миллион вуҷуд дорад

---

### Task 13

* **EN:** Retrieve people whose age is above the average age
* **RU:** Получить людей, у которых возраст выше среднего
* **TJ:** Одамонеро гиред, ки синнашон аз миёнаи синни ҳамаи одамон зиёд аст

---

### Task 14

* **EN:** Retrieve cities that have no people
* **RU:** Получить города, в которых нет ни одного человека
* **TJ:** Шаҳрҳоро гиред, ки дар онҳо ягон одам зиндагӣ намекунад

---

### Task 15

* **EN:** Create a method that counts the number of people in each country
* **RU:** Создать метод, который считает количество людей в каждой стране
* **TJ:** Метод созед, ки шумораи одамонро дар ҳар як кишвар ҳисоб мекунад

