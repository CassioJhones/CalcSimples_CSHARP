internal class Program
{
    private static void Main(string[] args)
    {
        Start(1);
        Menu();



        void Menu()
        {
            Console.Clear();
            Console.WriteLine("---| CRONOMETRO |---");
            Console.WriteLine("\nS = Segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo quer contar? ");

            string data = Console.ReadLine()!.ToLower();
            char type = char.Parse(data.Substring(data.Length-1,1));
            Console.WriteLine(data);
            Console.WriteLine(type);
            
        }



        void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(800);
            }

            Console.Clear();
            Console.WriteLine("Cronometro Finalizado");
            Thread.Sleep(200);
        }

        
    }
}