using System;

namespace ProjectEuler;

/// <summary>
/// Static class for computing the sum of two multiples less than an upper bound.
/// </summary>
/// <remarks>
/// The original problem statement can be viewed at <see href="https://projecteuler.net/problem=1"/>.
/// </remarks>
public static class SumOfMultiples
{
    /// <summary>
    /// Computes the sum of two multiples less than <paramref name="upperBound"/>.
    /// </summary>
    /// <param name="upperBound">The upperBound of values to sum.</param>
    /// <param name="multipleOne">The first multiple.</param>
    /// <param name="multipleTwo">The second multiple.</param>
    /// <returns>A <see cref="ulong"/> representing the sum of all multiples of <paramref name="multipleOne"/> and <paramref name="multipleTwo"/> less than <paramref name="upperBound"/>.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="upperBound"/>, <paramref name="multipleOne"/>, or <paramref name="multipleTwo"/> is zero.</exception>
    public static ulong Compute(ulong upperBound, ulong multipleOne, ulong multipleTwo)
    {
        ArgumentOutOfRangeException.ThrowIfZero(upperBound, nameof(upperBound));
        ArgumentOutOfRangeException.ThrowIfZero(multipleOne, nameof(multipleOne));
        ArgumentOutOfRangeException.ThrowIfZero(multipleTwo, nameof(multipleTwo));

        var leastCommonMultiple = LeastCommonMultiple(multipleOne, multipleTwo);
        return SumOfMultiplesLessThanUpperBound(multipleOne, upperBound) + SumOfMultiplesLessThanUpperBound(multipleTwo, upperBound) - SumOfMultiplesLessThanUpperBound(leastCommonMultiple, upperBound);
    }

    /// <summary>
    /// Computes the sum of multiples of <paramref name="multiple"/> less than <paramref name="upperBound"/>.
    /// </summary>
    /// <param name="multiple">The base multiple to use when computing the sum.</param>
    /// <param name="upperBound">The upperBound of values to sum.</param>
    /// <returns>A <see cref="ulong"/> representing the sum of all multiples of <paramref name="multiple"/> less than <paramref name="upperBound"/>.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="multiple"/> is zero or <paramref name="upperBound"/> is zero.</exception>
    private static ulong SumOfMultiplesLessThanUpperBound(ulong multiple, ulong upperBound)
    {
        ArgumentOutOfRangeException.ThrowIfZero(multiple, nameof(multiple));
        ArgumentOutOfRangeException.ThrowIfZero(upperBound, nameof(upperBound));

        var iterations = upperBound / multiple + (upperBound % multiple == 0ul ? 0ul : 1ul);
        return multiple * iterations * (iterations - 1ul) / 2ul;
    }

    /// <summary>
    /// Computes the Least Common Multiple (LCM) of two <see cref="ulong"/>s.
    /// </summary>
    /// <param name="a">The first value.</param>
    /// <param name="b">The second value.</param>
    /// <returns>A <see cref="ulong"/> representing the least common multiple of <paramref name="a"/> and <paramref name="b"/>.</returns>
    private static ulong LeastCommonMultiple(ulong a, ulong b)
    {
        return a / GreatestCommonDivisor(a, b) * b;
    }

    /// <summary>
    /// Computes the Greatest Common Divisor (GCD) of two <see cref="ulong"/>s.
    /// </summary>
    /// <param name="a">The first value.</param>
    /// <param name="b">The second value.</param>
    /// <returns>A <see cref="ulong"/> representing the greatest common divisor of <paramref name="a"/> and <paramref name="b"/>.</returns>
    private static ulong GreatestCommonDivisor(ulong a, ulong b)
    {
        while (b != 0)
        {
            var temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
