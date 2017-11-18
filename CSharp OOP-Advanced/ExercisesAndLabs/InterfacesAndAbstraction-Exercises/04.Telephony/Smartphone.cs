namespace _04.Telephony
{
    using System;
    using System.Collections.Generic;

    public class Smartphone : IBrowseable, ICallable
    {
        private IList<string> phoneNumbers;
        private IList<string> urls;

        public Smartphone(IList<string> phoneNumbers, IList<string> urls)
        {
            this.phoneNumbers = phoneNumbers;
            this.urls = urls;
        }

        public void Browse()
        {
            foreach (var url in this.urls)
            {
                if (this.IsUrlValid(url))
                {
                    Console.WriteLine($"Browsing: {url}!");
                }
                else
                {
                    Console.WriteLine("Invalid URL!");
                }
            }
        }

        public void Call()
        {
            foreach (var phoneNumber in this.phoneNumbers)
            {
                if (this.IsPhoneNumberValid(phoneNumber))
                {
                    Console.WriteLine($"Calling... {phoneNumber}");
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }

        private bool IsPhoneNumberValid(string phoneNumber)
        {
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (!char.IsDigit(phoneNumber[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsUrlValid(string url)
        {
            for (int i = 0; i < url.Length; i++)
            {
                if (char.IsDigit(url[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}