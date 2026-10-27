using System;

namespace Generics_EntityRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository<Product> productRepo = new Repository<Product>();
            productRepo.Add(new Product { Id = 1, Name = "Ноутбук" });
            productRepo.Add(new Product { Id = 2, Name = "Смартфон" });

            Product? foundProduct = productRepo.GetById(1);
            Console.WriteLine($"Repository<Product>.GetById(1): {(foundProduct != null ? foundProduct.Name : "не найден")}");

            Product? missingProduct = productRepo.GetById(99);
            Console.WriteLine($"Repository<Product>.GetById(99): {(missingProduct != null ? missingProduct.Name : "null")}");

            Repository<Customer> customerRepo = new Repository<Customer>();
            customerRepo.Add(new Customer { Id = 10, Email = "test@mail.ru" });

            Customer? foundCustomer = customerRepo.GetById(10);
            Console.WriteLine($"Repository<Customer> с собственным набором данных (Id 10): {(foundCustomer != null ? foundCustomer.Email : "не найден")}");

            Console.WriteLine();
            Console.WriteLine("=== Интерактивный режим работы с репозиторием продуктов ===");

            Repository<Product> userProductRepo = new Repository<Product>();

            while (true)
            {
                try
                {
                    Console.Write("Введите ID продукта (или отрицательное число для выхода): ");
                    string idInput = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(idInput))
                    {
                        continue;
                    }

                    int id = int.Parse(idInput);
                    if (id < 0)
                    {
                        break;
                    }

                    Console.Write("Введите название продукта: ");
                    string name = Console.ReadLine();

                    userProductRepo.Add(new Product { Id = id, Name = name });
                    Console.WriteLine("Продукт успешно добавлен в репозиторий.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введено не число.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("\nВведите ID для поиска продукта в вашем репозитории (или -1 для выхода): ");
                    string searchInput = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(searchInput))
                    {
                        continue;
                    }

                    int searchId = int.Parse(searchInput);
                    if (searchId == -1)
                    {
                        break;
                    }

                    Product? result = userProductRepo.GetById(searchId);
                    if (result != null)
                    {
                        console.WriteLine($"Найден продукт: ID = {result.Id}, Name = {result.Name}");
                    }
                    else
                    {
                        Console.WriteLine("Элемент с таким Id не найден (null).");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введено не число.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
    }
}