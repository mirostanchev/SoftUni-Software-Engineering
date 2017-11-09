namespace _16.InstructionSet
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var opCode = Console.ReadLine().ToUpper();
            var result = 0L;

            while (opCode != "END")
            {
                var codeArgs = opCode.Split(' ');
                
                switch (codeArgs[0])
                {
                    case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = operandOne + 1;
                        break;
                    }
                    case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = operandOne - 1;
                        break;
                    }
                    case "ADD":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                    case "MLA":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = (long)(operandOne * operandTwo);
                        break;
                    }
                }

                opCode = Console.ReadLine().ToUpper();
                Console.WriteLine(result);
            }
        }
    }
}