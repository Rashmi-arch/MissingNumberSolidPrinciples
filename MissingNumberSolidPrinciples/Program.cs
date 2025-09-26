namespace MissingNumber;

class Program
{
    static void Main(string[] args)
    {
        var io = new ConsoleInputOutput();
        int[] nums = io.ReadInput();

        IMissingNumberFinder finder = new SumBasedMissingNumberFinder(); // OCP: can swap with other strategies
        var service = new MissingNumberService(finder);

        int missingNumber = service.GetMissingNumber(nums);
        io.DisplayResult(missingNumber);
    }
}