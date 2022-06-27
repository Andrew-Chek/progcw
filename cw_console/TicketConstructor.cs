namespace cw_console
{
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
}