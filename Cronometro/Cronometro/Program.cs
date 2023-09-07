internal class Program
{
    private static void Main(string[] args)
    {
        Menu();

        void Menu()
        {
            Console.Clear();
            Console.WriteLine("---| CRONOMETRO |---");
            Console.WriteLine("\nS = Segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo quer contar? ");

            string data = Console.ReadLine()!.ToLower(); //tudo minusculo
            char type = char.Parse(data.Substring(data.Length-1,1)); //converte em char e pega ultimo caracter digitado
            int time = int.Parse(data.Substring(0,data.Length-1)); //converte em char e pega todos exceto o ultimo caracter digitado
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;
            
            if(time == 0) //sair
            {
                Console.Clear();
                Console.WriteLine("\nFECHANDO APLICAÇÃO\n");
                Environment.Exit(0);

            }

            PreStart(time * multiplier);
        }

        void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("\nCarregando...");
            Thread.Sleep(1400);
            Console.Clear();
            Console.WriteLine("\n---INICIADO---");
            Thread.Sleep(1000);
            Start(time);
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
            Console.WriteLine("---Cronometro Finalizado---");
            Thread.Sleep(200);
            Menu();
        }
        
    }
}