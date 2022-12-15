namespace Apartat2
{
    class Program
    {
        static void Main()
        {
            int userCount = 0;
            int aiCount = 0;
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine($"Tu : {userCount} - Maquina : {aiCount}");
                string? input;
                int inputInt = 0;
                int nombre = new Random().Next(1, 4);
                while (true)
                {
                    Console.WriteLine("Quin element vols treure?"+
                                      "\n 1. Pedra"+
                                      "\n 2. Paper"+
                                      "\n 3. Tisores");
                    input = Console.ReadLine();
                    if (input != null)
                    {
                        try
                        {
                            inputInt = int.Parse(input);
                            if (inputInt > 0 && inputInt < 4)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Introdueix un numero entre 1 i 3");
                            }
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("No has introduit un número");
                        }
                    }
                }

                if (inputInt == 1)
                {
                    if (nombre == 1) 
                    { 
                        Console.WriteLine("Ha triat pedra... Has empatat");
                    }
                    
                    else if (nombre == 2) 
                    { 
                        Console.WriteLine("Ha triat paper... Has perdut");
                        aiCount++;
                        i++;
                    }
                    else if (nombre == 3) 
                    { 
                        Console.WriteLine("Ha triat tisores... Has guanyat"); 
                        userCount++;
                        i++;
                    }
                }
                if (inputInt == 2)
                {
                    if (nombre == 1)
                    {
                        Console.WriteLine("Ha triat pedra... Has guanyat");
                        userCount++;
                        i++;
                    }
                    else if (nombre == 2)
                    {
                        Console.WriteLine("Ha triat paper... Has empatat");
                    }
                    else if (nombre == 3)
                    {
                        Console.WriteLine("Ha triat tisores... Has perdut");
                        aiCount++;
                        i++;
                    }
                }

                if (inputInt == 3)
                {
                    if (nombre == 1)
                    {
                        Console.WriteLine("Ha triat pedra... Has perdut");
                        aiCount++;
                        i++;
                    }
                    else if (nombre == 2)
                    {
                        Console.WriteLine("Ha triat paper... Has guanyat");
                        userCount++;
                        i++;
                    }
                    else if (nombre == 3)
                    {
                        Console.WriteLine("Ha triat tisores... Has empatat");
                    }
                }
            }
            Console.WriteLine($"Tu : {userCount} - Maquina : {aiCount}");
            if (userCount >= aiCount) Console.WriteLine("Has guanyat.");
            else Console.WriteLine("Has perdut.");
        }
    }
}