namespace HamiltonianPathProblem;

public partial class Graph
{
    private readonly List<Vertex> _vertices;

    public Graph(List<List<uint>> adjacencyList)
    {
        if (!IsAdjacencyListCorrect(adjacencyList))
        {
            Console.WriteLine("Error: incorrect adjacency list or not sorted");
            Environment.Exit(0);    // TODO Throw exception
        }

        _vertices = new List<Vertex>();
        BuildGraph(adjacencyList);
    }

    public static bool IsAdjacencyListCorrect(List<List<uint>> adjacencyList)
    {
        return true;    // TODO Realize method
    }

    private void BuildGraph(List<List<uint>> adjacencyList)
    {
        // Copy to a new list for sorting
        var adjacencyListCopy = new List<List<uint>>(adjacencyList);
        adjacencyList = adjacencyListCopy;

        // Sorting numbers of vertices
        foreach (var list in adjacencyList)
        {
            list.Sort();
        }

        // Creating vertices
        for (var i = 0; i < adjacencyList.Count; i++)
        {
            _vertices.Add(new Vertex());
        }
        
        // Bunching vertices
        for (var i = 0; i < adjacencyList.Count; i++)
        {
            for (var j = 0; j < adjacencyList[i].Count; j++)
            {
                _vertices[i].AddVertex(GetVertex(adjacencyList[i][j]));
            }
        }
    }

    private Vertex GetVertex(uint number)
    {
        return _vertices.FirstOrDefault(vertex => vertex.Number == number)!;
    }
}