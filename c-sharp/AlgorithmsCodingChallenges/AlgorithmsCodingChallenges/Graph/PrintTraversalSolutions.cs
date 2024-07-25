namespace AlgorithmsCodingChallenges
{
    public class PrintTraversalSolutions
    {
        public List<char> DepthFirstPrintGraphValues(Dictionary<char, List<char>> graph, char sourceNode)
        {
            var output = new List<char>();
            var stack = new Stack<char>();

            stack.Push(sourceNode);

            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();
                Console.WriteLine(currentNode);
                output.Add(currentNode);

                foreach (var neighbor in graph[currentNode])
                {
                    stack.Push(neighbor);
                }
            }

            return output;
        }

        public List<char> DepthFirstRecursivelyPrintGraphValues(Dictionary<char, List<char>> graph, char sourceNode)
        {
            var output = new List<char>(); 

            Console.WriteLine(sourceNode);
            output.Add(sourceNode);

            foreach (var neighbor in graph[sourceNode])
            {
                output.AddRange(DepthFirstRecursivelyPrintGraphValues(graph, neighbor));
            }

            return output;    
        }


        public List<char> BreadthFirstTraversalPrintGraphValues(Dictionary<char, List<char>> graph, char sourceNode)
        {
            var output = new List<char>();
            var queue = new Queue<char>();
            queue.Append(sourceNode);

            while (queue.Any())
            {
                var current = queue.Dequeue();
                Console.WriteLine(current);
                output.Add(current);

                foreach (var neighbor in graph[current])
                {
                    queue.Append(neighbor);                    
                }               
            }

            return output;
        }
    }
}