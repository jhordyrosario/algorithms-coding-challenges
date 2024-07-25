using AlgorithmsCodingChallenges.Graph;

namespace AlgorithmsCodingChallenges.UnitTests.Graph
{
    [TestFixture]
    public class HasPathTests
    {
        private HasPathSolutions _hasPathSolutions { get; set; }

        [SetUp]
        public void SetUp(){
            _hasPathSolutions = new HasPathSolutions();
        }

        [Test]
        public void TestHasPath_FromFToK()
        {
            var graph = new Dictionary<char, List<char>>
            {
                { 'f', new List<char> { 'g', 'i' } },
                { 'g', new List<char> { 'h' } },
                { 'h', new List<char>() },
                { 'i', new List<char> { 'g', 'k' } },
                { 'j', new List<char> { 'i' } },
                { 'k', new List<char>() }
            };

            Assert.IsTrue(_hasPathSolutions.HasPath(graph, 'f', 'k'));
        }

        [Test]
        public void TestHasPath_FromFToJ()
        {
            var graph = new Dictionary<char, List<char>>
            {
                { 'f', new List<char> { 'g', 'i' } },
                { 'g', new List<char> { 'h' } },
                { 'h', new List<char>() },
                { 'i', new List<char> { 'g', 'k' } },
                { 'j', new List<char> { 'i' } },
                { 'k', new List<char>() }
            };

            Assert.IsFalse(_hasPathSolutions.HasPath(graph, 'f', 'j'));
        }

        [Test]
        public void TestHasPath_FromIToH()
        {
            var graph = new Dictionary<char, List<char>>
            {
                { 'f', new List<char> { 'g', 'i' } },
                { 'g', new List<char> { 'h' } },
                { 'h', new List<char>() },
                { 'i', new List<char> { 'g', 'k' } },
                { 'j', new List<char> { 'i' } },
                { 'k', new List<char>() }
            };

            Assert.IsTrue(_hasPathSolutions.HasPath(graph, 'i', 'h'));
        }

        [Test]
        public void TestHasPath_FromVToW()
        {
            var graph = new Dictionary<char, List<char>>
            {
                { 'v', new List<char> { 'x', 'w' } },
                { 'w', new List<char>() },
                { 'x', new List<char>() },
                { 'y', new List<char> { 'z' } },
                { 'z', new List<char>() }
            };

            Assert.IsTrue(_hasPathSolutions.HasPath(graph, 'v', 'w'));
        }

        [Test]
        public void TestHasPath_FromVToZ()
        {
            var graph = new Dictionary<char, List<char>>
            {
                { 'v', new List<char> { 'x', 'w' } },
                { 'w', new List<char>() },
                { 'x', new List<char>() },
                { 'y', new List<char> { 'z' } },
                { 'z', new List<char>() }
            };

            Assert.IsFalse(_hasPathSolutions.HasPath(graph, 'v', 'z'));
        }
    }
}