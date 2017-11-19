namespace _01.ListyIterator
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var createCmd = Console.ReadLine().Split().ToList();
            ListyIterator<string> listIterator = null;

            if (createCmd.Count > 1)
            {
                var elements = createCmd.Skip(1).ToList();
                listIterator = new ListyIterator<string>(elements);
            }
            else
            {
                listIterator = new ListyIterator<string>();
            }

            var cmd = Console.ReadLine();

            while (cmd != "END")
            {
                switch (cmd)
                {
                    case "HasNext":
                        Console.WriteLine(listIterator.HasNext());
                        break;

                    case "Move":
                        Console.WriteLine(listIterator.Move());
                        break;

                    case "Print":
                        listIterator.Print();
                        break;
                }

                cmd = Console.ReadLine();
            }
        }
    }
}