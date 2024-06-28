namespace AlgorithmsCondingChallenges.UnitTests;

using AlgorithmsCodingChallenges;

[TestFixture]
public class Tests
{
    private TwoSumSolutions _twoSumSolutions { get; set; }

    [SetUp]
    public void Setup()
    {
        _twoSumSolutions = new TwoSumSolutions();
    }

    [Test]
    [TestCase(new int[] {2,7,11,15}, 9, new int[] {0,1})]
    [TestCase(new int[] {3,2,4}, 6, new int[] {1,2})]
    [TestCase(new int[] {3,3}, 6, new int[] {0,1})]
    public void TwoSum_WhenCalled_ShouldReturnCorrectIndexes(int[] nums, int target, int[] response)
    {
        Assert.That(_twoSumSolutions.TwoSum(nums, target), Is.EqualTo(response));
    }
}