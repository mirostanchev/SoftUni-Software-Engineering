﻿public class FoodFactory
{
    public static Food GeFood(string[] tokens)
    {
        var foodType = tokens[0];
        var foodQuantity = int.Parse(tokens[1]);

        if (foodType == "Meat")
        {
            return new Meat(foodQuantity);
        }

        return new Vegetable(foodQuantity);
    }
}