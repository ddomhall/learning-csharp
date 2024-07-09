partial class Part6
{
    public static void throwExceptions()
    {

        /*
                // Prompt the user for the lower and upper bounds
                Console.Write("Enter the lower bound: ");
                int lowerBound = int.Parse(Console.ReadLine());

                Console.Write("Enter the upper bound: ");
                int upperBound = int.Parse(Console.ReadLine());

                decimal averageValue = 0;

                bool exit = false;

                do
                {
                    try
                    {
                        // Calculate the sum of the even numbers between the bounds
                        averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

                        // Display the result to the user
                        Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

                        exit = true;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine("An error has occurred.");
                        Console.WriteLine(ex.Message);
                        Console.WriteLine($"The upper bound must be greater than {lowerBound}");
                        Console.Write($"Enter a new upper bound (or enter Exit to quit): ");
                        string? userResponse = Console.ReadLine();
                        if (userResponse.ToLower().Contains("exit"))
                        {
                            exit = true;
                        }
                        else
                        {
                            exit = false;
                            upperBound = int.Parse(userResponse);
                        }
                    }
                } while (exit == false);

                // Wait for user input
                Console.ReadLine();

                static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
                {
                    if (lowerBound >= upperBound)
                    {
                        throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
                    }

                    int sum = 0;
                    int count = 0;
                    decimal average = 0;

                    for (int i = lowerBound; i <= upperBound; i++)
                    {
                        if (i % 2 == 0)
                        {
                            sum += i;
                            count++;
                        }
                    }

                    average = (decimal)sum / count;

                    return average;
                }

        string[][] userEnteredValues = new string[][]
        {
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
        };

        try
        {
            Workflow1(userEnteredValues);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("\nAn error occurred during 'Workflow1'.");
            Console.WriteLine(ex.Message);
        }

        static void Workflow1(string[][] userEnteredValues)
        {
            foreach (string[] userEntries in userEnteredValues)
            {
                try
                {
                    Process1(userEntries);
                    Console.WriteLine("'Process1' completed successfully.");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\n'Process1' encountered an issue, process aborted.");
                    Console.WriteLine(ex.Message);
                }
            }

            static void Process1(String[] userEntries)
            {
                int valueEntered;

                foreach (string userValue in userEntries)
                {
                    bool integerFormat = int.TryParse(userValue, out valueEntered);

                    if (integerFormat == true)
                    {
                        if (valueEntered != 0)
                        {
                            checked
                            {
                                int calculatedValue = 4 / valueEntered;
                            }
                        }
                        else
                        {
                            throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
                        }

                    }
                    else
                    {
                        throw new FormatException("Invalid data. User input values must be valid integers.");
                    }
                }
            }
        }
        */

    }
}