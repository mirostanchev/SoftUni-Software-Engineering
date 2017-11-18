namespace _09.CollectionHierarchy
{
    using System;
    using _09.CollectionHierarchy.Collections;

    public class StartUp
    {
        public static void Main()
        {
            var elementsToAdd = Console.ReadLine().Split();
            var countOfRemoveOps = int.Parse(Console.ReadLine());

            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();

            foreach (var element in elementsToAdd)
            {
                Console.Write(addCollection.Add(element) + " ");
            }

            Console.WriteLine();

            foreach (var element in elementsToAdd)
            {
                Console.Write(addRemoveCollection.Add(element) + " ");
            }

            Console.WriteLine();

            foreach (var element in elementsToAdd)
            {
                Console.Write(myList.Add(element) + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < countOfRemoveOps; i++)
            {
                Console.Write(addRemoveCollection.Remove() + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < countOfRemoveOps; i++)
            {
                Console.Write(myList.Remove() + " ");
            }
        }
    }
}