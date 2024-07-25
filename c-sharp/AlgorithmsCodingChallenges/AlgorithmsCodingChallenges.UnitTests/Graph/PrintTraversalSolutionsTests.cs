namespace AlgorithmsCondingChallenges.UnitTests;

using AlgorithmsCodingChallenges;

[TestFixture]
public class PrintTraversalSolutionsTests
{
    private Dictionary<char, List<char>> _graph;
    public PrintTraversalSolutions _depthFirstPrintTraversalSolutions { get; set; }

    [SetUp]
    public void Setup()
    {
        _depthFirstPrintTraversalSolutions = new PrintTraversalSolutions();
        _graph = new Dictionary<char, List<char>>
        {
            { 'a', new List<char> { 'c', 'b' } },
            { 'b', new List<char> { 'd' } },
            { 'c', new List<char> { 'e' } },
            { 'd', new List<char> { 'f' } },
            { 'e', new List<char>() },
            { 'f', new List<char>() }
        };
    }

    [Test]
    [TestCase('a', new char[] {'a', 'b', 'd', 'f', 'c', 'e'})]
    [TestCase('b', new char[] {'b', 'd', 'f' })]
    [TestCase('c', new char[] {'c', 'e' })]
    [TestCase('d', new char[] {'d', 'f' })]
    [TestCase('e', new char[] {'e' })]
    [TestCase('f', new char[] {'f' })]
    public void DepthFirstTraversal_WhenStartingFromNode_ShouldReturnCorrectTraversal(char source, char[] expected)
    {
        var result = _depthFirstPrintTraversalSolutions.DepthFirstPrintGraphValues(_graph, source);
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    [TestCase('a', new char[] {'a', 'c', 'e', 'b', 'd', 'f'})]
    [TestCase('b', new char[] {'b', 'd', 'f' })]
    [TestCase('c', new char[] {'c', 'e' })]
    [TestCase('d', new char[] {'d', 'f' })]
    [TestCase('e', new char[] {'e' })]
    [TestCase('f', new char[] {'f' })]
    public void DepthFirstRecursivelyPrintGraphValues_WhenStartingFromNode_ShouldReturnCorrectTraversal(char source, char[] expected)
    {
        var result = _depthFirstPrintTraversalSolutions.DepthFirstRecursivelyPrintGraphValues(_graph, source);
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    [TestCase('a', new char[] {'a', 'c', 'b', 'e', 'd', 'f'})]
    [TestCase('b', new char[] {'b', 'd', 'f' })]
    [TestCase('c', new char[] {'c', 'e' })]
    [TestCase('d', new char[] {'d', 'f' })]
    [TestCase('e', new char[] {'e' })]
    [TestCase('f', new char[] {'f' })]
    public void BreadthFirstTraversalPrintGraphValues_WhenStartingFromNode_ShouldReturnCorrectTraversal(char source, char[] expected)
    {
        var result = _depthFirstPrintTraversalSolutions.BreadthFirstTraversalPrintGraphValues(_graph, source);
        CollectionAssert.AreEqual(expected, result);
    }
}