// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Net.Http.Headers;
using AlgorithmsCodingChallenges;
using Microsoft.VisualBasic;

public class Program{
    public static void Main(string[] args){
            Console.WriteLine("Hello, World!");
            
            // var graph = new Dictionary<char, List<char>>
            // {
            //     { 'a', new List<char> { 'c', 'b' } },
            //     { 'b', new List<char> { 'd' } },
            //     { 'c', new List<char> { 'e' } },
            //     { 'd', new List<char> { 'f' } },
            //     { 'e', new List<char>() },
            //     { 'f', new List<char>() }
            // };

        // DepthFirstPrint(graph, 'a');
        // Console.WriteLine("-------");
        // DepthFirstRecursivePrint(graph, 'a');

        // Console.WriteLine("-------");
        // BreadthFirstPrint(graph, 'a');

        // var edges = new List<Tuple<string, string>>
        // {
        //     Tuple.Create("i", "j"),
        //     Tuple.Create("k", "i"),
        //     Tuple.Create("m", "k"),
        //     Tuple.Create("k", "l"),
        //     Tuple.Create("o", "n")
        // };

        // Console.WriteLine(UndirectedPath(edges, "j", "m")); // Output: True or False

        var graph = new Dictionary<int, List<int>>
        {
            { 0, new List<int> { 8, 1, 5 } },
            { 1, new List<int> { 0 } },
            { 5, new List<int> { 0, 8 } },
            { 8, new List<int> { 0, 5 } },
            { 2, new List<int> { 3, 4 } },
            { 3, new List<int> { 2, 4 } },
            { 4, new List<int> { 2, 3 } }
        };

        Console.WriteLine(ConnectedComponentsCount(graph)); // Output: 2
    }

    static int ConnectedComponentsCount
    ( Dictionary<int, List<int>> graph)
    {
        var count = 0;
        var visited = new HashSet<int>();

        foreach (var node in graph)
        {
            if(explore(graph, node.Key, visited))
            {
                count++;
            }
        }

        return count;
    }

    public static bool explore
    (Dictionary<int, List<int>> graph, int source, HashSet<int> visited)
    {
        if(visited.Contains(source))
            return false;

        foreach (var neighbor in graph[source])
        {
            explore(graph, neighbor, visited);
        }

        return true;
    }

    static Dictionary<string, List<string>> BuildGraph(List<Tuple<string, string>> edges)
    {
        var graph = new Dictionary<string, List<string>>();

        foreach (var edge in edges)
        {
            var (a, b) = edge;
            if (!graph.ContainsKey(a)) graph[a] = new List<string>();
            if (!graph.ContainsKey(b)) graph[b] = new List<string>();

            graph[a].Add(b);
            graph[b].Add(a);
        }

        return graph;
    }

    static bool UndirectedPath(List<Tuple<string, string>> edges, string nodeA, string nodeB)
    {
        var graph = BuildGraph(edges);
        return HasPath(graph, nodeA, nodeB, new HashSet<string>());
    }

    static bool HasPath
    (Dictionary<string, List<string>> graph, string src, string dst, HashSet<string> visited)
    {
        if (src == dst) return true;
        if (visited.Contains(src)) return false;

        visited.Add(src);

        foreach (var neighbor in graph[src])
        {
            if (HasPath(graph, neighbor, dst, visited))
            {
                return true;
            }
        }

        return false;
    }


    static bool HasPathDepthFirst(Dictionary<char, List<char>> graph, char source, char destination)
    {
        if(source == destination)
        {
            return true;
        }

        foreach(char neighbor in graph[source])
        {
            return HasPathDepthFirst(graph, neighbor, destination);
        }

        return false;
    }
    static bool HasPathBredthFirst(Dictionary<char, List<char>> graph, char source, char destination)
    {
        var queue = new Queue<char>();
        queue.Append(source);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            if ( current == destination)
            {
                return true;
            }

            foreach (char neighbor in graph[current])
            {
                queue.Append(neighbor);
            }
        }

        return false;
    }


    static void DepthFirstPrint(Dictionary<char, List<char>> graph, char source)
    {
        Stack<char> stack = new Stack<char>();
        stack.Push(source);

        while (stack.Count > 0)
        {
            char current = stack.Pop();
            Console.WriteLine(current);

            foreach (char neighbor in graph[current])
            {
                stack.Push(neighbor);
            }
        }
    }

    static void DepthFirstRecursivePrint(Dictionary<char, List<char>> graph, char source)
    {
        Console.WriteLine(source);
        foreach(char neighbor in graph[source])
        {
            DepthFirstRecursivePrint(graph, neighbor);
        }
    }

    static void BreadthFirstPrint(Dictionary<char, List<char>> graph, char source)
    {
        var queue = new Queue<char>();
        queue.Append(source);

        while (queue.Count != 0){
            var current = queue.Dequeue();

            Console.WriteLine(current);
            
            foreach (char neighbor in graph[current]){
                queue.Append(neighbor);
            }
        }
    }
}

