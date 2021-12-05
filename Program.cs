using System;

namespace hungry_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate emtpy food object
            //Food testFood = new Food();
            //Console.WriteLine(testFood);


            //Instantiate Food object with all 4 params
            //Food BBQchickenPizza = new Food("BBQ Chicken Pizza", 1200, false, true);
            //Console.WriteLine(BBQchickenPizza);


            //Instantiate Buffet & Serve Random Food Object
            //Food randFood1 = new Buffet().Serve();
            //Console.WriteLine(randFood1);


            //Instantiate a Buffet and Ninja object
            Buffet buffet1 = new Buffet();
            Ninja naruto = new Ninja();
            
            //Have Ninja eat until full
            /* while(!naruto.IsFull)
            {
                naruto.Eat(buffet1.Serve());
            }*/

            naruto.Eat(buffet1.Serve());
            naruto.Eat(buffet1.Serve());
            naruto.Eat(buffet1.Serve());
            

            
            
        }
    }
}
