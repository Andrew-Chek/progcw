using static System.Console;
using animalfactory;
using animalfood;

namespace cw_console
{
    public class ZooDepartment
    {
        protected Herbivore[] _herbivore;
        protected Carnivore[] _carnivore;
        protected string depName;
        protected Dictionary<int, Animal> animals
            = new Dictionary<int, Animal>();
        public ZooDepartment(ContinentFactory factory, string depName)
        {
            _carnivore = factory.CreateCarnivores();
            _herbivore = factory.CreateHerbivores();
            animals = factory.CreateAllAnimals();
            this.depName = depName;
        }
        public void RunZooDepartment(User user)
        {
            WriteLine();
            while (true)
            {
                WriteLine("We have such offers for you: feed animals(feed), know fact about animal(fact), exit");
                WriteLine($"What do you want? Department: {this.depName}");
                string answer = ReadLine();
                if (answer == "feed")
                {
                    FeedAnimal(user);
                    WriteLine();
                }
                else if (answer == "fact")
                {
                    KnowAnimal(user);
                    WriteLine();
                }
                else if (answer == "exit")
                {
                    break;
                }
                else
                {
                    WriteLine($"Unknown command `{answer}`, try some from the list");
                }
            }
        }
        public void FeedAnimal(User user)
        {
            while (true)
            {
                WriteLine($"Enter the number of animal, you want to feed: (from 0 to {animals.Count() - 1})");
                ShowAnimals();
                string answer = ReadLine();
                int num = 0;
                if (int.TryParse(answer, out num) && int.Parse(answer) >= 0 && int.Parse(answer) < animals.Count())
                {
                    Animal animal = animals[int.Parse(answer)];
                    Food food = ChooseFood(user);
                    animal.ImplementFood(food);
                    if (animal.GetFood() != null)
                        WriteLine(animal.GetFood().GiveFood(animal));
                    break;
                }
                else
                {
                    WriteLine("Your input wasn't correct, please try again");
                }
            }
        }
        public void KnowAnimal(User user)
        {
            while (true)
            {
                WriteLine($"Enter the number of animal, you want to know better: (from 0 to {animals.Count() - 1})");
                ShowAnimals();
                string answer = ReadLine();
                int num = 0;
                if (int.TryParse(answer, out num) && int.Parse(answer) >= 0 && int.Parse(answer) < animals.Count())
                {
                    Animal animal = animals[int.Parse(answer)];
                    WriteLine($"Interesting fact about {animal.name}: ");
                    WriteLine(animal.GetInterestingFact());
                    break;
                }
                else
                {
                    WriteLine("Your input wasn't correct, please try again");
                }
            }
        }
        public Food ChooseFood(User user)
        {
            while (true)
            {
                WriteLine($"Enter the number of food, you want to feed animal: (from 0 to {user.food.Length - 1})");
                ShowFood(user);
                string answer = ReadLine();
                int num = 0;
                if (int.TryParse(answer, out num) && int.Parse(answer) >= 0 && int.Parse(answer) < user.food.Length)
                {
                    Food food = user.food[int.Parse(answer)];
                    return food;
                }
                else
                {
                    WriteLine("The wrong num of food, please try again");
                }
            }
        }
        public void ShowAnimals()
        {
            WriteLine("Animals:");
            for (int i = 0; i < animals.Count(); i++)
            {
                Write($"{animals[i].name}({i}); \r\n");
            }
        }
        public void ShowFood(User user)
        {
            WriteLine("Food:");
            for (int i = 0; i < user.food.Length; i++)
            {
                Write($"{user.food[i].product}({i}); \r\n");
            }
        }
    }
}