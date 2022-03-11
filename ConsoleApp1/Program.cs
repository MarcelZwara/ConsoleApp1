class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 10;
        int guess;
        int number;
        int guesses;
        String response;

        while (playAgain)
        {
            guess = 0;
            guesses = 0;
            response = "";
            number = random.Next(min, max + 1);
            
            while (guess != number)
            {
                Console.WriteLine("zgadnil liczbe pomiędzy " + min + " - " + max + " : ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" zgadnij: " + guess);

                if (guess > number)
                {
                    Console.WriteLine(guess + "Twoja liczba jest większa !");

                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + "Twoja liczba jest za mała!");
                }
                guesses++;
            }
            Console.WriteLine("liczba: " + number);
            Console.WriteLine("BRAWO WYGRAŁEŚ!!!!");
            Console.WriteLine("trafienia: " + guesses);

            Console.WriteLine("chcesz grać jeszcze raz (Y/N): ");
            response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }

            Console.WriteLine("dzięki za gre");
            Console.ReadKey();
        }

    }

}