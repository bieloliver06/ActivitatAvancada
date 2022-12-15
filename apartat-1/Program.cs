namespace Apartat1
{
    class Program
    {
        static void Main()
        {
            int number;
            while (true)
            {
                Console.WriteLine("Introdueix un nombre : ");
                string? input = Console.ReadLine();
                if (input != null)
                {
                    try
                    {
                        number = int.Parse(input);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("El valor introduït no és un nombre");
                    }
                }
            }
            if (number % 2 == 0)
            {
                Console.WriteLine("El nombre introduït és parell");
            }
            else
            {
                if (isPrime(number))
                {
                    Console.WriteLine("El nombre introduït és primer");
                }
                else
                {
                    Console.WriteLine("El nombre introduït és senar");
                }
            }
        }
        static bool isPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}