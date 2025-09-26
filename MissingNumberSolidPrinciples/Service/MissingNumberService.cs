namespace MissingNumber;
public class MissingNumberService
{
    private readonly IMissingNumberFinder _finder;

    public MissingNumberService(IMissingNumberFinder finder)
    {
        _finder = finder;
    }

    public int GetMissingNumber(int[] nums)
    {
        return _finder.FindMissingNumber(nums);
    }
}