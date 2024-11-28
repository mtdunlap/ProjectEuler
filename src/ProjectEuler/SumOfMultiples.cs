using System;

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
        ArgumentOutOfRangeException.ThrowIfZero(upperBound, nameof(upperBound));
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
        ArgumentOutOfRangeException.ThrowIfZero(multiple, nameof(multiple));
        ArgumentOutOfRangeException.ThrowIfZero(upperBound, nameof(upperBound));

        var iterations = upperBound / multiple + (upperBound % multiple == 0ul ? 0ul : 1ul);
        return multiple * iterations * (iterations - 1ul) / 2ul;
    }
}
