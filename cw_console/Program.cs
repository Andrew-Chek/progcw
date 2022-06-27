using static System.Console;
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