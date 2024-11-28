namespace ProjectEuler.UnitTests;

[TestFixture]
internal sealed class SumOfMultiplesFixture
{
    [Test(ExpectedResult = 233168ul)]
    public ulong Should_return_the_sum_of_multiples_of_three_and_five_less_than_1000()
    {
        return SumOfMultiples.Compute();
    }
}
