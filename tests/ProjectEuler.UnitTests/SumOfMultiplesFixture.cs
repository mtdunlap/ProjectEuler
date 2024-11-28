using System.Collections.Generic;

namespace ProjectEuler.UnitTests;

[TestFixture]
internal sealed class SumOfMultiplesFixture
{
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
