# CafeApp – Design Patterns în C#

Acest proiect demonstrează 5 design patterns clasice în programare orientată pe obiect, folosind un exemplu simplu: o cafenea care produce băuturi precum ceai și cafea.

Proiectul este scris în C# și organizat modular, cu exemple ușor de înțeles.

---

# 1. Singleton

**Scop:** asigură că o clasă are o singură instanță în toată aplicația.

**Exemplu în proiect:**  
Clasa `DrinkManager` este un logger care se folosește global în aplicație.  
Este accesat prin `DrinkManager.Instance`.

---

# 2. Factory Method

**Scop:** delegă crearea obiectelor către subclase.

**Exemplu în proiect:**  
Clasele `TeaCreator` și `CoffeeCreator` moștenesc `DrinkCreator` și implementează `CreateDrink()`.  
Astfel, putem obține ceai sau cafea fără să folosim `new` direct în codul principal.

---

# 3. Abstract Factory

**Scop:** creează o familie de produse compatibile între ele (ex: ceai + cafea caldă).

**Exemplu în proiect:**  
Interfața `IDrinkFactory` definește metode pentru `CreateTea()` și `CreateCoffee()`.  
Implementările `HotDrinkFactory` și `ColdDrinkFactory` oferă produse concrete (ex: ceai cald, cafea rece).

---

# 4. Prototype

**Scop:** creează o copie a unui obiect existent.

**Exemplu în proiect:**  
Clasa `DrinkRecipe` implementează `Clone()` și permite duplicarea unei rețete de băutură.  
Se creează o copie cu același conținut și un sufix în nume ("(copie)").

---

# 5. Builder

**Scop:** construiește un obiect pas cu pas, controlând fiecare etapă.

**Exemplu în proiect:**  
Clasa `DrinkBuilder` permite adăugarea treptată a ingredientelor.  
Clasa `Director` definește pașii pentru a construi o cafea personalizată.

---

#Cum rulezi proiectul

1. Deschide proiectul în Rider sau Visual Studio.
2. Selectează proiectul `CafeApp`.
3. Rulează `Program.cs`.
4. Vei vedea în consolă cum este folosit fiecare pattern.

---

# Scop educațional

Acest proiect este creat pentru laboratorul de programare orientată pe obiect și este destinat exersării și înțelegerii conceptelor de design patterns într-un mod simplu și practic.
