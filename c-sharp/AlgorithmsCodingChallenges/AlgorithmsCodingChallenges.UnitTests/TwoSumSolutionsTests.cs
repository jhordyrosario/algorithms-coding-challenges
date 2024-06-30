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
    public void TwoSum1_WhenCalled_ShouldReturnCorrectIndexes(int[] nums, int target, int[] response)
    {
        Assert.That(_twoSumSolutions.TwoSum1(nums, target), Is.EqualTo(response));
    }

    [Test]
    [TestCase(new int[] {2,7,11,15}, 9, new int[] {0,1})]
    [TestCase(new int[] {3,2,4}, 6, new int[] {1,2})]
    [TestCase(new int[] {3,3}, 6, new int[] {0,1})]
    public void TwoSum2_WhenCalled_ShouldReturnCorrectIndexes(int[] nums, int target, int[] response)
    {
        Assert.That(_twoSumSolutions.TwoSum2(nums, target), Is.EqualTo(response));
    }

    [Test]
    [TestCase(new int[] {2,7,11,15}, 9, new int[] {0,1})]
    [TestCase(new int[] {3,2,4}, 6, new int[] {1,2})]
    [TestCase(new int[] {3,3}, 6, new int[] {0,1})]
    public void TwoSum3_WhenCalled_ShouldReturnCorrectIndexes(int[] nums, int target, int[] response)
    {
        Assert.That(_twoSumSolutions.TwoSum3(nums, target), Is.EqualTo(response));
    }
}