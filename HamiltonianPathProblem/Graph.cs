namespace HamiltonianPathProblem;

public partial class Graph
{
    private List<Vertex> _vertices;

    public Graph(uint[][] adjacencyList)
    {
        if (!IsAdjacencyListCorrect(adjacencyList))
        {
            Console.WriteLine("Error: incorrect adjacency list or not sorted");
            Environment.Exit(0);    // TODO Throw exception
        }

        _vertices = new List<Vertex>();
        BuildGraph(adjacencyList);
    }

    public static bool IsAdjacencyListCorrect(uint[][] adjacencyList)
    {
        return true;    // TODO Realize method
    }

    private void BuildGraph(uint[][] adjacencyList)
    {
        
    }
}