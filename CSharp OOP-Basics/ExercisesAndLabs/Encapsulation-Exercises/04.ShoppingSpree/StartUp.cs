namespace _04.ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var people = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var products = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            var persons = new List<Person>();

            foreach (var person in people)
            {
                var tokens = person.Split('=');
                var name = tokens[0];
                var money = decimal.Parse(tokens[1]);

                try
                {
                    var currentPerson = new Person(name, money);
                    persons.Add(currentPerson);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            var productsList = new List<Product>();

            foreach (var product in products)
            {
                var tokens = product.Split('=');
                var name = tokens[0];
                var cost = decimal.Parse(tokens[1]);

                try
                {
                    var currentProduct = new Product(name, cost);
                    productsList.Add(currentProduct);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }

            }

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                var commandArgs = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var searchedPerson = commandArgs[0];
                var searchedProduct = commandArgs[1];

                var person = persons.FirstOrDefault(x => x.Name == searchedPerson);
                var product = productsList.FirstOrDefault(x => x.Name == searchedProduct);

                var isAdded = person.AddProduct(product);

                if (isAdded)
                {
                    Console.WriteLine($"{searchedPerson} bought {searchedProduct}");
                }
                else
                {
                    Console.WriteLine($"{searchedPerson} can\'t afford {searchedProduct}");
                }
            }

            foreach (var person in persons)
            {
                if (person.Products.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(x => $"{x.Name}"))}");
                }
            }
        }
    }
}