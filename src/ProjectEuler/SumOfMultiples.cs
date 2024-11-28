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
    /// Computes the sum of multiples of 3 and 5 less than <paramref name="upperBound"/>.
    /// </summary>
    /// <param name="upperBound">The upperBound of values to sum.</param>
    /// <returns>A <see cref="ulong"/> representing the sum of all multiples of 3 and 5 less than 1000.</returns>
    public static ulong Compute(ulong upperBound)
    {
        return SumOfMultiplesLessThanUpperBound(3, upperBound) + SumOfMultiplesLessThanUpperBound(5, upperBound) - SumOfMultiplesLessThanUpperBound(15, upperBound);
    }

    /// <summary>
    /// Computes the sum of multiples of <paramref name="multiple"/> less than <paramref name="upperBound"/>.
    /// </summary>
    /// <param name="multiple">The base multiple to use when computing the sum.</param>
    /// <param name="upperBound">The upperBound of values to sum.</param>
    /// <returns>A <see cref="ulong"/> representing the sum of all multiples of <paramref name="multiple"/> less than <paramref name="upperBound"/>.</returns>
    private static ulong SumOfMultiplesLessThanUpperBound(ulong multiple, ulong upperBound)
    {
        ulong sum = 0ul;
        ulong iterations = upperBound / multiple + (upperBound % multiple == 0ul ? 0ul : 1ul);
        for (ulong i = 1; i < iterations; i++)
        {
            sum += i;
        }
        return sum * multiple;
    }
}
