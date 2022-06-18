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
            _vertices.Add(new Vertex((uint)i + 1));
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

    public bool IsHamiltonian()
    {
        return HamiltonianPath().Count != 0;
    }

    public List<uint> HamiltonianPath()
    {
        // If graph is empty
        if (_vertices.Count == 0)
        {
            return new List<uint>();
        }
        
        // Start from the vertex with max degree
        var traversedVertices = new List<Vertex>();
        var pathWasFound = false;
        HamiltonianPathRecursive(VertexWithMaxDegree(), traversedVertices, ref pathWasFound);

        if (!pathWasFound)
        {
            return new List<uint>();
        }

        return traversedVertices.Select(vertex => vertex.Number).ToList();
    }

    private void HamiltonianPathRecursive(Vertex vertex, List<Vertex> traversedVertices, ref bool pathWasFound)
    {
        if (pathWasFound)
        {
            return;
        }
        
        if (!traversedVertices.Contains(vertex))
        {
            // Add current vertex
            traversedVertices.Add(vertex);
            
            foreach (var nextVertex in vertex.Vertices)
            {
                HamiltonianPathRecursive(nextVertex, traversedVertices, ref pathWasFound);
            }
            
            // Remove current vertex from back
            if (!pathWasFound)
            {
                traversedVertices.RemoveAt(traversedVertices.Count - 1);
            }
        }

        if (traversedVertices.Count == _vertices.Count && vertex == VertexWithMaxDegree())
        {
            traversedVertices.Add(vertex);
            pathWasFound = true;
        }
    }

    private Vertex VertexWithMaxDegree()
    {
        var vertexWithMaxDegree = _vertices.First();
        
        // Search max degree
        foreach (var vertex in _vertices.Where(vertex => vertex.Degree > vertexWithMaxDegree.Degree))
        {
            vertexWithMaxDegree = vertex;
        }

        return vertexWithMaxDegree;
    }
}