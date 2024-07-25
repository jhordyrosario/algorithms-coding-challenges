namespace AlgorithmsCondingChallenges.UnitTests;

using AlgorithmsCodingChallenges.Graph;

[TestFixture]
public class UndirectedPathSolutionsTests
{
    public UndirectedPathSolutions _undirectedPathSolutions { get; set; }

    [SetUp]
    public void Setup()
    {
        _undirectedPathSolutions = new UndirectedPathSolutions();
    }
    
    [Test]
    public void TestUndirectedPath_JToM()
    {
        var edges = new List<Tuple<char, char>>
        {
            Tuple.Create('i', 'j'),
            Tuple.Create('k', 'i'),
            Tuple.Create('m', 'k'),
            Tuple.Create('k', 'l'),
            Tuple.Create('o', 'n')
        };

        Assert.IsTrue(_undirectedPathSolutions.UndirectedPath(edges, 'j', 'm'));
    }

    [Test]
    public void TestUndirectedPath_MToJ()
    {
        var edges = new List<Tuple<char, char>>
        {
            Tuple.Create('i', 'j'),
            Tuple.Create('k', 'i'),
            Tuple.Create('m', 'k'),
            Tuple.Create('k', 'l'),
            Tuple.Create('o', 'n')
        };

        Assert.IsTrue(_undirectedPathSolutions.UndirectedPath(edges, 'm', 'j'));
    }

    [Test]
    public void TestUndirectedPath_LToJ()
    {
        var edges = new List<Tuple<char, char>>
        {
            Tuple.Create('i', 'j'),
            Tuple.Create('k', 'i'),
            Tuple.Create('m', 'k'),
            Tuple.Create('k', 'l'),
            Tuple.Create('o', 'n')
        };

        Assert.IsTrue(_undirectedPathSolutions.UndirectedPath(edges, 'l', 'j'));
    }

    [Test]
    public void TestUndirectedPath_KToO()
    {
        var edges = new List<Tuple<char, char>>
        {
            Tuple.Create('i', 'j'),
            Tuple.Create('k', 'i'),
            Tuple.Create('m', 'k'),
            Tuple.Create('k', 'l'),
            Tuple.Create('o', 'n')
        };

        Assert.IsFalse(_undirectedPathSolutions.UndirectedPath(edges, 'k', 'o'));
    }

    [Test]
    public void TestUndirectedPath_IToO()
    {
        var edges = new List<Tuple<char, char>>
        {
            Tuple.Create('i', 'j'),
            Tuple.Create('k', 'i'),
            Tuple.Create('m', 'k'),
            Tuple.Create('k', 'l'),
            Tuple.Create('o', 'n')
        };

        Assert.IsFalse(_undirectedPathSolutions.UndirectedPath(edges, 'i', 'o'));
    }

    [Test]
    public void TestUndirectedPath_AToB()
    {
        var edges = new List<Tuple<char, char>>
        {
            Tuple.Create('b', 'a'),
            Tuple.Create('c', 'a'),
            Tuple.Create('b', 'c'),
            Tuple.Create('q', 'r'),
            Tuple.Create('q', 's'),
            Tuple.Create('q', 'u'),
            Tuple.Create('q', 't')
        };

        Assert.IsTrue(_undirectedPathSolutions.UndirectedPath(edges, 'a', 'b'));
    }

    [Test]
    public void TestUndirectedPath_AToC()
    {
        var edges = new List<Tuple<char, char>>
        {
            Tuple.Create('b', 'a'),
            Tuple.Create('c', 'a'),
            Tuple.Create('b', 'c'),
            Tuple.Create('q', 'r'),
            Tuple.Create('q', 's'),
            Tuple.Create('q', 'u'),
            Tuple.Create('q', 't')
        };

        Assert.IsTrue(_undirectedPathSolutions.UndirectedPath(edges, 'a', 'c'));
    }

    [Test]
    public void TestUndirectedPath_RToT()
    {
        var edges = new List<Tuple<char, char>>
        {
            Tuple.Create('b', 'a'),
            Tuple.Create('c', 'a'),
            Tuple.Create('b', 'c'),
            Tuple.Create('q', 'r'),
            Tuple.Create('q', 's'),
            Tuple.Create('q', 'u'),
            Tuple.Create('q', 't')
        };

        Assert.IsTrue(_undirectedPathSolutions.UndirectedPath(edges, 'r', 't'));
    }

    [Test]
    public void TestUndirectedPath_RToB()
    {
        var edges = new List<Tuple<char, char>>
        {
            Tuple.Create('b', 'a'),
            Tuple.Create('c', 'a'),
            Tuple.Create('b', 'c'),
            Tuple.Create('q', 'r'),
            Tuple.Create('q', 's'),
            Tuple.Create('q', 'u'),
            Tuple.Create('q', 't')
        };

        Assert.IsFalse(_undirectedPathSolutions.UndirectedPath(edges, 'r', 'b'));
    }

    [Test]
    public void TestUndirectedPath_RToT_SmallGraph()
    {
        var edges = new List<Tuple<char, char>>
        {
            Tuple.Create('s', 'r'),
            Tuple.Create('t', 'q'),
            Tuple.Create('q', 'r')
        };

        Assert.IsTrue(_undirectedPathSolutions.UndirectedPath(edges, 'r', 't'));
    }
}