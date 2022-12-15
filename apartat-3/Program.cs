namespace Apartat3
{
    class Program
    {
        static void Main()
        {
            uint a;
            while (true)
            {
                Console.WriteLine("Introdueix un número o \"surt\" per finalitzar : ");
                string? input = Console.ReadLine();
                if (input != null)
                {
                    if (input == "surt") break;
                    else
                    {
                        try
                        {
                            a = uint.Parse(input);
                            if (IsPerfect(a)) Console.WriteLine("És un nombre perfecte");
                            else Console.WriteLine("No és un nombre perfecte");
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("El valor introduït no és un número");
                        }
                    }
                }
            }
            
        }

        static bool IsPerfect(uint number)
        {
            uint sum = 0;
            for (uint i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }
    }
}