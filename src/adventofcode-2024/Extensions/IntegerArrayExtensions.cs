namespace adventofcode_2024.Extensions;

public static class IntegerArrayExtensions
{
    /// <summary>
    /// Extension method to check if an array of integers is increasing
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public static bool IsIncreasing(this int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] >= numbers[i + 1])
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// Extension method to check if an array of integers is decreasing
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public static bool IsDecreasing(this int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i + 1] >= numbers[i])
            {
                return false;
            }
        }

        return true;
    }

    public static bool IsSafe(this int[] numbers)
    {

            if (numbers.IsDecreasing())
            {
                for (int k = 0; k < numbers.Length - 1; k++)
                {
                    var diff = numbers[k] - numbers[k + 1];
                    if (diff >= 4 || diff < 1)
                    {
                        return false;
                    }
                }
                return true;
            }
            
            if (numbers.IsIncreasing())
            {
                for (int m = 0; m < numbers.Length - 1; m++)
                {
                    var diff = numbers[m + 1] - numbers[m];
                    if (diff >= 4 || diff < 1)
                    {
                        return false;
                    }
                }
                return true;
            }

            return true;
    }
    
    public static bool IsSafeAfterRemovingOneLevel(this int[] numbers)
    {
        var result = 0;
        if (numbers.IsDecreasing())
        {
            for (int k = 0; k < numbers.Length - 1; k++)
            {
                var diff = numbers[k] - numbers[k + 1];
                if (diff >= 4 || diff < 1)
                {
                    result++;
                }
            }
            return result <= 1;
        }
            
        if (numbers.IsIncreasing())
        {
            for (int m = 0; m < numbers.Length - 1; m++)
            {
                var diff = numbers[m + 1] - numbers[m];
                if (diff >= 4 || diff < 1)
                {
                    result++;
                }
            }
            return result <= 1;
        }

        return false;
    }
}