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
        return SumOfMultiplesLessThanOneThousand(3) + SumOfMultiplesLessThanOneThousand(5) - SumOfMultiplesLessThanOneThousand(15);
    }

    /// <summary>
    /// Computes the sum of multiples of <paramref name="multiple"/> less than 1000.
    /// </summary>
    /// <returns>A <see cref="ulong"/> representing the sum of all multiples of <paramref name="multiple"/> less than 1000.</returns>
    private static ulong SumOfMultiplesLessThanOneThousand(ulong multiple)
    {
        ulong sum = 0ul;
        for (ulong i = 0; i < 1000; i++)
        {
            if (i % multiple == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}
