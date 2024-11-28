using System;
using System.Collections.Generic;

namespace ProjectEuler.UnitTests;

[TestFixture]
internal sealed class SumOfMultiplesFixture
{
    [Test]
    public void Should_throw_an_argument_out_of_range_exception_When_computing_with_an_upper_bound_of_zero()
    {
        Assert.That(() =>
        {
            _ = SumOfMultiples.Compute(0ul);
        }, Throws.TypeOf<ArgumentOutOfRangeException>());
    }

    private static IEnumerable<TestCaseData> Source()
    {
        yield return new TestCaseData(10ul)
            .SetName("Should return the sum of multiples of three and five less than 10.")
            .SetDescription("When computing the sum of multiples of three and five less than 10, then the sum of 23 should be returned.")
            .Returns(23ul);
        yield return new TestCaseData(100ul)
            .SetName("Should return the sum of multiples of three and five less than 100.")
            .SetDescription("When computing the sum of multiples of three and five less than 100, then the sum of 2,318 should be returned.")
            .Returns(2318ul);
        yield return new TestCaseData(1000ul)
            .SetName("Should return the sum of multiples of three and five less than 1000.")
            .SetDescription("When computing the sum of multiples of three and five less than 1000, then the sum of 233,168 should be returned.")
            .Returns(233168ul);
    }

    [Test, TestCaseSource(nameof(Source))]
    public ulong Should_return_the_sum_of_multiples_of_three_and_five_less_than_an_upper_bound(ulong upperBound)
    {
        return SumOfMultiples.Compute(upperBound);
    }
}
