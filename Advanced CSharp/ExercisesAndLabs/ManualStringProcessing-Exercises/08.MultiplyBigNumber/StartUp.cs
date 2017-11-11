namespace _08.MultiplyBigNumber
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var firstNumber = new Stack<char>(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            if (secondNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var result = new StringBuilder();
            var residue = 0;

            while (firstNumber.Count > 0)
            {
                var sum = (int)char.GetNumericValue(firstNumber.Pop()) * secondNumber + residue;

                residue = sum / 10;
                result.Insert(0, sum % 10);
            }

            result.Insert(0, residue);
            Console.WriteLine(result.ToString().TrimStart('0'));
        }
    }
}