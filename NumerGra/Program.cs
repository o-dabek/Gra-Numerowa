using System;

namespace NumerGra
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int max = 100;
            int min = 1;

            int guess; // wybór gracza
            int number;  //numer wylosowany

            bool again = true;  //powtórka

            string odp; // odpowiedź na końcu
            odp = "";
           

            while (again)
            { 
                guess = 0;
                number = random.Next(min, max);

                while (guess !=number)  //jeśli nie zgadnie
                {
                    Console.WriteLine("Zgadnij numer w przedziale " + min + "-" + max + ":" );
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Twój wybór: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " to za dużo!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " to za mało!");
                    }
                }

                //jak zgadniemy

                Console.WriteLine("Twój wybór: " + number);
                Console.WriteLine("Brawo! To dobry wybór!");

                Console.WriteLine("Jeszcze raz? TAK/NIE: ");
                odp = Console.ReadLine();

                if (odp == "TAK")
                {
                    again = true;
                }
                else
                {
                    again = false;
                }

               
            }

            Console.WriteLine("Dzięki za grę!");

        }
    }
}
