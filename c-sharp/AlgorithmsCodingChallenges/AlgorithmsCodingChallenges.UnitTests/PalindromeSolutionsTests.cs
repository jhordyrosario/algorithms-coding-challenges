namespace AlgorithmsCodingChallenges.UnitTests;
using AlgorithmsCodingChallenges;

[TestFixture]
public class PalindromeSolutionsTests
{
    private PalindromeSolutions _palindromeSolutions { get; set; }

    [SetUp]
    public void SetUp()
    {
        _palindromeSolutions = new PalindromeSolutions();
    }

    [Test]
    [TestCase(1, true)]
    [TestCase(12, false)]
    [TestCase(131, true)]
    [TestCase(2442, true)]
    [TestCase(355553, true)]
    [TestCase(624232426, true)]
    [TestCase(13134, false)]
    [TestCase(-131, false)]
    public void IsPalindrome_WhenCalled_ShouldReturnTrueForPalindromeNumbers(int number, bool isPalindrome)
    {
        Assert.That(_palindromeSolutions.IsPalindrome(number), Is.EqualTo(isPalindrome));
        Assert.That(_palindromeSolutions.IsPalindrome2(number), Is.EqualTo(isPalindrome));
    }  
}