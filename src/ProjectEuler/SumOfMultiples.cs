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
        const ulong sumOfMultiplesOfThreeLessThanOneThousand = 166833ul;
        const ulong sumOfMultiplesOfFiveLessThanOneThousand = 99500ul;
        const ulong sumOfMultiplesOfFifteenLessThanOneThousand = 33165ul;
        return sumOfMultiplesOfThreeLessThanOneThousand + sumOfMultiplesOfFiveLessThanOneThousand - sumOfMultiplesOfFifteenLessThanOneThousand;
    }
}
