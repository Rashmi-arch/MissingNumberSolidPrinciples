namespace MissingNumber;

public class ConsoleInputOutput
{
    public int[] ReadInput()
    {
        //string input = "";
        Console.WriteLine("Please enter only comma-separated sequential integers. Sequence can varray eg. 1,4,2,5");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Input is empty or null. Please enter valid numbers.");
            return new int[0];
        }

        try
        {
            int[] numbers = input
                .Split(',')
                .Select(s => int.Parse(s.Trim()))
                .ToArray();

            Console.WriteLine("You entered:");
            Console.WriteLine(string.Join(", ", numbers));

            return input
                .Split(',')
                .Select(s => int.Parse(s.Trim()))
                .ToArray();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter only comma-separated integers.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
        return new int[0];
    }

    public void DisplayResult(int result)
    {
        Console.WriteLine($"Missing number is: {result}");
    }
}