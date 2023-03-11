namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {// test cadre 
            Cadre cadre1 = new Cadre(10002, "cadre", "de cadre", new DateTime(1992, 2, 15), 3);
            Console.WriteLine(cadre1.ToString());
            Console.WriteLine($"Salaire mensuel: {cadre1.Salaire}");
            // test Boss
            Boss.ChiffreAffaires = 1000000;
            Boss _boss = new Boss(10002, "boss", "de boss", new DateTime(1992, 2, 15), 2);
            Console.WriteLine(_boss.ToString());
            Console.WriteLine($"Salaire annuel: {_boss.Salaire}");
        }
    }
}
