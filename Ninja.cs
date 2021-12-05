
using System;
using System.Collections.Generic;


namespace hungry_ninja
{
    class Ninja
    {

        //--------------Define Ninja Class Fields (Calorie Intake, Food History)-------------------
        private int calorieIntake;
        public List<Food> FoodHistory;


        //-----Add a contstructor > set calorie intake to 0 and create empty list of food objects-----
        public Ninja() 
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }


        //----Add public "getter" property called "IsFull" that returns boolean if Ninja's calorieIntake > 1200----
        public bool IsFull
        {
            get {return calorieIntake >= 1200;}  
        }


        //----------------add Eat method----------------
        public bool Eat(Food item) 
        {
            if(!IsFull) 
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"Ninja is eating {item.Name} which is Spicy: {item.IsSpicy}/Sweet: {item.IsSweet}. YUM!");
            }
            else
            {
                Console.WriteLine("NINJA IS FULL!");
            }

            return IsFull;
        }
    }
}