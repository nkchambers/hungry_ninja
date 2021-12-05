using System;
using System.Collections.Generic;

namespace hungry_ninja

{
    class Buffet
    {

        //------------------Define Buffet Class Menu List (Name, Calories, IsSpicy, IsSweet)----------------------
        public List<Food> Menu;


        //-------------Add Costructor to Set Menu to List of 7 or more Food objects------------
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("BBQ Chicken Pizza", 800, false, true),
                new Food("Hot Pepperoni Pizza",920, true, false),
                new Food("Hawaiian Pizza",780, false, true),
                new Food("Sweet & Sour Chicken", 650, false, true),
                new Food("Chicken Caesar Salad", 325, false, false),
                new Food("Philly Cheese Steak", 700, true, false),
                new Food("Spicy Pork Bulgogi", 750, true, false)
            };
        }


        //---------Add Serve Method that Randomly Selects Food Object from Menu List--------------
        public Food Serve()
        {
            Random rand = new Random();
            int i = rand.Next(Menu.Count);

            //Console.WriteLine($"Random Food Object: {Menu[i]}");

            return Menu[i];
        }

    }
}