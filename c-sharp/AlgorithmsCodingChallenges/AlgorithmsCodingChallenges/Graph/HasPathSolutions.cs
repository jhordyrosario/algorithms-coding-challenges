namespace AlgorithmsCodingChallenges.Graph;

public class HasPathSolutions
{
    //Depth First Recursive
    public bool HasPath(Dictionary<char, List<char>> graph, char source, char destination)
    {
        if(source == destination)
        {
            return true;
        }

        foreach (var neighbor in graph[source])
        {
            if(HasPath(graph, neighbor, destination) == true)
            {
                return true;
            }
        }
        
        return false;
    }
    
    //Depth
    // public bool HasPath(Dictionary<char, List<char>> graph, char source, char destination)
    // {
    //     var stack = new Stack<char>();
    //     stack.Push(source);

    //     while (stack.Count > 0){
    //         var current = stack.Pop();

    //         if (current == destination)
    //         {
    //             return true;
    //         }

    //         foreach (var neighbor in graph[current])
    //         {
    //             stack.Push(neighbor);
    //         }
    //     }

    //     return false;
    // }

    //Breadth
    // public bool HasPath(Dictionary<char, List<char>> graph, char source, char destination)
    // {
    //     var queue = new Queue<char>();
    //     queue.Enqueue(source);

    //     while (queue.Count > 0){
    //         var current = queue.Dequeue();

    //         if (current == destination)
    //         {
    //             return true;
    //         }

    //         foreach (var neighbor in graph[current])
    //         {
    //             queue.Enqueue(neighbor);
    //         }
    //     }

    //     return false;
    // }
}
