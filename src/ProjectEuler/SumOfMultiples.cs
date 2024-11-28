namespace ProjectEuler;

/// <summary>
/// Static class for computing the sum of multiples of 3 and 5 less than 1000.
/// </summary>
/// <remarks>
/// The original problem statement can be viewed at <see href="https://projecteuler.net/problem=1"/>.
/// </remarks>
public static class SumOfMultiples
{
    /// <summary>
    /// Computes the sum of multiples of 3 and 5 less than 1000.
    /// </summary>
    /// <returns>A <see cref="ulong"/> representing the sum of all multiples of 3 and 5 less than 1000.</returns>
    public static ulong Compute()
    {
        return SumOfMultiplesOfThreeLessThanOneThousand() + SumOfMultiplesOfFiveLessThanOneThousand() - SumOfMultiplesOfFifteenLessThanOneThousand();
    }

    /// <summary>
    /// Computes the sum of multiples of 3 less than 1000.
    /// </summary>
    /// <returns>A <see cref="ulong"/> representing the sum of all multiples of 3 less than 1000.</returns>
    private static ulong SumOfMultiplesOfThreeLessThanOneThousand()
    {
        ulong sum = 0ul;
        for (ulong i = 0; i < 1000; i++)
        {
            if (i % 3 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }

    /// <summary>
    /// Computes the sum of multiples of 5 less than 1000.
    /// </summary>
    /// <returns>A <see cref="ulong"/> representing the sum of all multiples of 5 less than 1000.</returns>
    private static ulong SumOfMultiplesOfFiveLessThanOneThousand()
    {
        ulong sum = 0ul;
        for (ulong i = 0; i < 1000; i++)
        {
            if (i % 5 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }

    /// <summary>
    /// Computes the sum of multiples of 15 less than 1000.
    /// </summary>
    /// <returns>A <see cref="ulong"/> representing the sum of all multiples of 15 less than 1000.</returns>
    private static ulong SumOfMultiplesOfFifteenLessThanOneThousand()
    {
        ulong sum = 0ul;
        for (ulong i = 0; i < 1000; i++)
        {
            if (i % 15 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}
