namespace AlgorithmsCodingChallenges.Graph;

public class UndirectedPathSolutions
{
    public bool UndirectedPath(List<Tuple<char, char>> edges, char nodeA, char nodeB){
        
        var graph = GetNodes(edges);

        // nodeA = 'a';
        // nodeB = 'e';
        // graph = new Dictionary<char, List<char>> 
        // {
        //     { 'a', new List<char> { 'c', 'd' } },
        //     { 'c', new List<char> { 'b' } },
        //     { 'b', new List<char> { 'a' } },
        //     { 'd', new List<char> { 'e' } },
        // };

        return HasPath(graph, nodeA, nodeB, new HashSet<char>());
    }

    private bool HasPath(Dictionary<char, List<char>> graph, char source, char destination, HashSet<char> visited)
    {
        if(source == destination)
        {
            return true;
        }
        
        // Since is undirected I already visited this node so, its a dead end
        if(visited.Contains(source))
        {
            return false;
        }

        visited.Add(source);

        foreach(var neighbor in graph[source])
        {

            if(HasPath(graph, neighbor, destination, visited) == true)
            {
                return true;
            }
        }
        
        return false;
    }

    //Get Adjencency list
    private Dictionary<char, List<char>> GetNodes(List<Tuple<char, char>> edges)
    {
        var graph = new Dictionary<char, List<char>>();

        foreach (var edge in edges){
            if(!graph.ContainsKey(edge.Item1))
            {
                graph.Add(edge.Item1, new List<char>());
            }
            graph[edge.Item1].Add(edge.Item2);

            if(!graph.ContainsKey(edge.Item2))
            {
                graph.Add(edge.Item2, new List<char>());
            }
            graph[edge.Item2].Add(edge.Item1);
        }

        return graph;

    }
}