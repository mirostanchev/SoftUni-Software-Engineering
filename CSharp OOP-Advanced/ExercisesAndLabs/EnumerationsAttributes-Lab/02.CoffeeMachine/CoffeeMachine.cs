namespace _02.CoffeeMachine
{
    using System;
    using System.Collections.Generic;

    public class CoffeeMachine
    {
        private int allMoney;
        private readonly IList<CoffeeType> coffeesSold;

        public CoffeeMachine()
        {
            this.coffeesSold = new List<CoffeeType>();
            this.allMoney = 0;
        }

        public void BuyCoffee(string size, string type)
        {
            var coffeePrice = (CoffeePrice)Enum.Parse(typeof(CoffeePrice), size);
            var intCoffePrice = (int)coffeePrice;
            var coffeeType = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);

            if (this.allMoney >= intCoffePrice)
            {
                this.coffeesSold.Add(coffeeType);
                this.allMoney = 0;
            }
        }

        public void InsertCoin(string coin)
        {
            var coinType = (Coin)Enum.Parse(typeof(Coin), coin);
            this.allMoney += (int)coinType;
        }

        public IEnumerable<CoffeeType> CoffeesSold
        {
            get { return this.coffeesSold; }
        }
    }
}