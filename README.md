# C_Sharp_Generics_EntityRepository

## C#_Generics_EntityRepository

### Задание «Контрольная точка — Репозиторий сущностей»[cite: 16]

Вариант 1. Репозиторий сущностей[cite: 16]
1. Базовый класс Entity со свойством int Id { get; init; }[cite: 16].
2. Обобщённый класс Repository<T> where T : Entity с методами Add(T item) и GetById(int id)[cite: 16].
3. Производные классы Product : Entity (с дополнительным свойством Name) и Customer : Entity (с дополнительным свойством Email)[cite: 16].
4. Создайте Repository<Product> и Repository<Customer>, добавьте в каждый минимум два элемента[cite: 16].
5. Продемонстрируйте GetById для обоих репозиториев, включая случай, когда элемент с таким Id не найден[cite: 16].

Результаты и проверочные ключи:

<img width="1701" height="315" alt="изображение" src="https://github.com/user-attachments/assets/52e38e4b-964e-490e-b06c-2ef95328a1f4" />


Результат работы:

<img width="1620" height="402" alt="изображение" src="https://github.com/user-attachments/assets/2aed1bec-4bb6-4f1d-b011-2b75bcb85ced" />
