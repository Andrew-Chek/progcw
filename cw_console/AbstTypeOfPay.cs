using static System.Console;
namespace cw_console
{
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
}