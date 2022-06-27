using static System.Console;
using animalfood;
using animalfactory;
using System.IO;
using Newtonsoft.Json;
namespace cw_console
{
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
}