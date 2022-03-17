using System;
using static System.Console;
using animalfactory;
using animalfood;
 
namespace cw_console
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            Zoo world = new Zoo(america);
            Carnivore carnivore = new ArcticFox();
            WriteLine(carnivore.name);
            Food[] foods = new Food[10]
                {new Meat(1), new Fish(1), new Eggs(1), 
                    new Vegetables(1), new Fruits(1), new Crops(1), 
                        new Sweets(1), new Bread(1), new Hay(1), new Porridge(1)};
            for(int i = 0; i < 10; i++)
            {
                carnivore.ImplementFood(foods[i]);
                if(carnivore.GetFood() != null)
                    WriteLine(carnivore.GetFood().GiveFood(carnivore));
            }
        }
    }
    class Zoo
    {
        private Herbivore[] _herbivore;
        private Carnivore[] _carnivore;
        public Zoo(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivores();
            _herbivore = factory.CreateHerbivores();
        }
    }
    public class User
    {
        public Food[] food;

    }
}