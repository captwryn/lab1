using System;
class MainClass {
    public static void Main() {
        int j = 1;

        while (j < 2)
        {
            Console.Write("Please state if your unit type:");
            string units = Console.ReadLine();
            if (units == "fidget spinners")
            {
                Console.WriteLine("Please enter the amount of fidget spinners:");
                decimal spin;
                spin = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(value: spin + " fidget spinners equal " + (spin / 3.5m) + "in.");
            }
            else if (units == "memes")
            {
                Console.WriteLine("Please enter the amount of memes:");
                decimal meme;
                meme = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(value: meme + " memes equal " + (meme / 5m) + "ft.");
            }
            else if (units == "in")
            {
                Console.WriteLine("Please enter the amount of in:");
                decimal inch;
                inch = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(value: inch + "in equal " + (inch * 3.5m) + "fidget spinners.");
            }
            else if (units == "ft")
            {
                Console.WriteLine("Please enter the amount of ft:");
                decimal feet;
                feet = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(value: feet + "ft equal " + (feet * 5m) + "memes.");
            }
            else Console.WriteLine("Sorry I don't understand, please try again");
            Console.WriteLine("Would you like to try again?");
                string response = Console.ReadLine();
            if (response == "yes") { }
            else
                j++;
            }
        }
    }



