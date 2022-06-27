using System;
using static System.Console;
using System.IO;
using Newtonsoft.Json;
using animalfactory;
using animalfood;

namespace cw_console
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            User user = SetUser();
            AbstZoo zoo = new Zoo();
            AbstZoo controlZoo = new ControlZoo(zoo);
            controlZoo.RunZoo(user);
        }
        public static int EnterIntValue(string value, int upperBorder)
        {
            while (true)
            {
                Write($"Enter your {value}: ");
                string answer = ReadLine();
                int num = -1;
                if (int.TryParse(answer, out num) && int.Parse(answer) >= 0 && int.Parse(answer) < upperBorder)
                {
                    num = int.Parse(answer);
                    return num;
                }
                else
                {
                    WriteLine($"Your {value} wasn't entered successfully; Please, try again.");
                }
            }
        }
        public static User SetUser()
        {
            User user = new User();
            Write("Enter a user's name: ");
            string name = ReadLine();
            user.name = name;
            user.wantedTime = 3;
            user.age = EnterIntValue("age", 70);
            user.cardMoney = EnterIntValue("card money", 10000);
            user.cash = EnterIntValue("cash", 10000);
            user.SetTypeOfTicket();
            return user;
        }
    }
    public abstract class AbstTypeOfPay
    {
        protected int money;
        public abstract bool PayForTicket(int cost);
    }
    public class CashTypeOfPay : AbstTypeOfPay
    {
        public CashTypeOfPay(int money)
        {
            this.money = money;
        }
        public override bool PayForTicket(int cost)
        {
            if (money > cost)
            {
                WriteLine("Here is your rest, happy day");
                return true;
            }
            return false;
        }
    }
    public class CardTypeOfPay : AbstTypeOfPay
    {
        public CardTypeOfPay(int money)
        {
            this.money = money;
        }
        public override bool PayForTicket(int cost)
        {
            WriteLine("Please, put your card to the screen");
            if (money > cost)
            {
                return true;
            }
            return false;
        }
    }
    public abstract class AbstZoo
    {
        protected Dictionary<int, ZooDepartment> departments
            = new Dictionary<int, ZooDepartment>();
        protected AbstTypeOfPay typeOfPay;
        public abstract void RunZoo(User user);
    }
    public class ControlZoo : AbstZoo
    {
        public AbstZoo zoo;
        public ControlZoo(AbstZoo zoo)
        {
            this.zoo = zoo;
        }
        public override void RunZoo(User user)
        {
            while (true)
            {
                WriteLine("Hello, can you pay for a ticket to enter the zoo?");
                SetTypeOfPay(user);
                if (typeOfPay.PayForTicket(user.typeOfTicket["cost"]))
                {
                    WriteLine("Thanks, here is your ticket: ");
                    WriteLine("Also in package with a ticket you can have some food to feed animals");
                    TicketConstructor constructor = new TicketConstructor();
                    TicketBuilder builder = new ZooTicketWrapper(user);
                    constructor.Construct(builder, user);
                    user.ticket = builder.Ticket;
                    user.ticket.Show();
                    string json = JsonConvert.SerializeObject(user, Formatting.Indented);
                    File.WriteAllText(@".\data\data.json", json);
                    Food[] foods = new Food[10]
                    {new Meat(1), new Fish(1), new Eggs(1),
                        new Vegetables(1), new Fruits(1), new Crops(1),
                            new Sweets(1), new Bread(1), new Hay(1), new Porridge(1)};
                    user.food = foods;
                    WriteLine();
                    zoo.RunZoo(user);
                }
                else
                {
                    WriteLine("You don't have enough money");
                }
                break;
            }
        }
        public void SetTypeOfPay(User user)
        {
            while (true)
            {
                WriteLine("Do you want to pay with card or cash?");
                string typeOfPay = ReadLine();
                if (typeOfPay == "card")
                {
                    this.typeOfPay = new CardTypeOfPay(user.cardMoney);
                    break;
                }
                else if (typeOfPay == "cash")
                {
                    this.typeOfPay = new CashTypeOfPay(user.cash);
                    break;
                }
                else
                {
                    WriteLine("We don't understand, what type of pay have you chosen, please try again");
                }
            }
        }
    }
    public class Zoo : AbstZoo
    {
        public Zoo()
        {
            departments[0] = new ZooDepartment(new AfricaFactory(), "Africa");
            departments[1] = new ZooDepartment(new AmericaFactory(), "America");
            departments[2] = new ZooDepartment(new AsiaFactory(), "Asia");
            departments[3] = new ZooDepartment(new AustraliaFactory(), "Australia");
            departments[4] = new ZooDepartment(new EuropeFactory(), "Europe");
        }
        public override void RunZoo(User user)
        {
            WriteLine("Welcome to the zoo, we are happy to see you here");
            WriteLine("Let's start our trip to the animal world in our 5 departments of different animals");
            for (int i = 0; i < 5; i++)
            {
                departments[i].RunZooDepartment(user);
            }
            WriteLine("Thanks for attending, come here again!");
        }
    }
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
    public class TicketConstructor
    {
        public void Construct(TicketBuilder ticketBuilder, User user)
        {
            ticketBuilder.GenerateCode();
            ticketBuilder.GetIssue();
            ticketBuilder.GetValid(user.wantedTime);
        }
    }
    public class Ticket
    {
        private User user;
        private Dictionary<string, string> _parts1 =
            new Dictionary<string, string>();
        private Dictionary<int, DateTime> _parts2 =
            new Dictionary<int, DateTime>();
        public Ticket(User user)
        {
            this.user = user;
        }
        public string this[string key]
        {
            get { return _parts1[key]; }
            set { _parts1[key] = value; }
        }
        public DateTime this[int key]
        {
            get { return _parts2[key]; }
            set { _parts2[key] = value; }
        }
        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Name: {0}", user.name);
            Console.WriteLine(" Age : {0}", user.age);
            Console.WriteLine(" Personal code : {0}", _parts1["code"]);
            Console.WriteLine(" Issued: {0}", _parts2[0]);
            Console.WriteLine(" Valid until: {0}", _parts2[1]);
        }
    }
    public abstract class TicketBuilder
    {
        protected Ticket ticket;
        public Ticket Ticket
        {
            get { return ticket; }
        }
        public abstract void GenerateCode();
        public abstract void GetIssue();
        public abstract void GetValid(int wantedTime);
    }
    class ZooTicketWrapper : TicketBuilder
    {
        public ZooTicketWrapper(User user)
        {
            ticket = new Ticket(user);
        }
        public override void GenerateCode()
        {
            string code = "";
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                code += random.Next(0, 10);
            }
            ticket["code"] = code;
        }
        public override void GetIssue()
        {
            ticket[0] = DateTime.Now;
        }
        public override void GetValid(int wantedTime)
        {
            ticket[1] = DateTime.Now.AddHours(wantedTime);
        }
    }
    public class User
    {
        public Food[] food;
        public string name;
        public int age;
        public int cash;
        public int cardMoney;
        public int wantedTime;
        public Dictionary<string, int> typeOfTicket =
            new Dictionary<string, int>();
        public Ticket ticket;
        public void SetTypeOfTicket()
        {
            if (this.age < 18)
            {
                typeOfTicket["cost"] = 300;
            }
            else
            {
                typeOfTicket["cost"] = 500;
            }
        }
    }
}