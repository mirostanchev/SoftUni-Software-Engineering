namespace _04.Telephony
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split().ToList();
            var urls = Console.ReadLine().Split().ToList();

            var phone = new Smartphone(phoneNumbers, urls);
            phone.Call();
            phone.Browse();
        }
    }
}