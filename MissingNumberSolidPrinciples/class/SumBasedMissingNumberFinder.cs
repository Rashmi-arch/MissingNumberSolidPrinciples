
namespace MissingNumber;

public class SumBasedMissingNumberFinder : IMissingNumberFinder
{
    public int FindMissingNumber(int[] nums)
    {
        int missingNumber = 0;
        if (nums != null && nums.Length != 0)
        {
            string stringArray = string.Join(", ", nums);

            int[] numbers = stringArray.Split(',').Select(s => int.Parse(s.Trim())).ToArray();

            Array.Sort(numbers); // Sorts the array in ascending order

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(", ", numbers));
            int shortestNum = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!shortestNum.Equals(numbers[i]))
                {
                    missingNumber = shortestNum;
                }
                shortestNum++;

                if (!missingNumber.Equals(0))
                {
                    break;
                }

            }

        }

        return missingNumber;
    }

}