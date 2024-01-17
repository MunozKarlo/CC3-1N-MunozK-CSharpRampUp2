namespace CSharpRampUp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO MY CONVERTER, CALCULATOR, STORYBOARD, AND SHAPE MAKER!");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("\n");

            Console.Write("ENTER WEIGHT IN POUNDS (lbs): ");
            double lbs = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.Write("ENTER DISTANCE IN MILES (mi): ");
            double mi = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.Write("ENTER TEMPERATURE IN FAHRENHEIT (fah): ");
            double fah = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("ENTER THE AGE OF 10 STUDENTS\n");
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter an age: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += numbers[i];
            }
            double average = (double)sum / 10;




            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("PART 1 OUTPUTS:");

            double kg = lbs * 0.45359237;
            Console.WriteLine("-" + lbs + " pounds in kilograms is " + kg);

            double km = mi * 1.60934;
            Console.WriteLine("-" + mi + " miles in kilometers is " + km);

            double celc = (fah - 32) * 5 / 9;
            Console.WriteLine("-" + fah + " fahrenheit in celcius is " + celc);

            Console.WriteLine("-The average of the 10 ages you entered is: " + average);

            Console.WriteLine("\n");
            Console.WriteLine("THE STORY");
            Console.WriteLine("\n");

            string char1 = "Coach";
            string char2 = "Ellis";
            string char3 = "Nick";
            string char4 = "Rochelle";
            string char5 = "\'Special Infected\'";

            //the story is from L4D2 lmao

            Console.WriteLine("The story takes place in Savannah, Georgia where an airborne virus called the 'Green Flu' has been spread.");
            Console.WriteLine("The Green Flu makes it's hosts/victims extremely violent with a desire for human flesh, but in some cases,");
            Console.WriteLine("The virus is also able to transform or modify it's host's physiological and anatomical structure, these infected");
            Console.WriteLine("are what we call " + char5 + "; these Special infecteds are able to perform actions beyond the capabilities");
            Console.WriteLine("of a normal human body, some can toss boulders and cars with ease, some can spit acidic vomit, some can even");
            Console.WriteLine("grow body parts that they can weaponize.");

            Console.WriteLine("\n");

            Console.WriteLine("Amidst the virus, there is an unlikely group of survivors that are fully immune to the Greem Flu; their names are");
            Console.WriteLine(char1 + ", " + char2 + ", " + char3 + ", and " + char4 + "; their objective is to reach the evacuation zone in Louisiana");
            Console.WriteLine("before the Military bombs off and closes all the paths and bridges that lead to the infected zones. but through their journey");
            Console.WriteLine("they'll need to fight off hordes of common and special infected before they can reach their destination.");



            Console.WriteLine("-----------------------------------------------------------------");




            Console.WriteLine("\n");
            Console.WriteLine("ENTER A NUMBER AND I WILL MAKE IT INTO AN ISOSCELES RIGHT TRIANGLE:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            if (rows > 0)
            {
                for (int i = 1; i <= rows; i++)
                {
                    int number = 1;
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(number);
                        if (j < i)
                        {
                            Console.Write(" ");
                        }
                        number++;
                    }
                    Console.WriteLine();
                }
            }

            else if (rows <= 0)
            {
                Console.WriteLine("INVALID INPUT, ONLY VALUES ABOVE 0 ARE ALLOWED!");
            }




            Console.WriteLine("\n");
            Console.WriteLine("ENTER A NUMBER AND I WILL SUM IT UP WITH NUMBERS PRECEEDING IT:");
            int numbr = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            int ans = 0;

            if (numbr > 1)
            {
                for (int x = 1; x <= numbr; x++)
                {
                    Console.Write(x + ", ");
                    ans += x;
                }

                Console.WriteLine("\n");
                Console.WriteLine("The sum of 1 to " + numbr + " is " + ans);

            }

            else if (numbr <= 1)
            {
                Console.WriteLine("INVALID INPUT, ONLY VALUES ABOVE 1 ARE ALLOWED!");
            }




            Console.WriteLine("\n");
            Console.WriteLine("ENTER A NUMBER AND I WILL MAKE AN UPSIDE DOWN ISOSCELES TRIANGLE:");
            int last = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            if (last > 0)
            {
                for (int i = last; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }

                Console.ReadLine();
            }

            else if (last <= 0)
            {
                Console.WriteLine("INVALID INPUT, ONLY VAlUES ABOVE 0 ARE ALLOWED!");
            }






            //commit test 01
            //commit test 02
            //commit test 03
            //commit test 04
            //commit test 05
            //commit test 06

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("THIS IS A PLACEHOLDER SO THAT CMD WON'T CLOSE AUTOMATICALLY");
            Console.ReadLine();

            Console.ReadKey();


        }
    }
}
