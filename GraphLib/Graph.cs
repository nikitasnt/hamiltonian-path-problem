namespace GraphLib;

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
        switch (_vertices.Count)
        {
            // If graph is empty
            case 0:
                return new List<uint>();
            // If graph has one vertex
            case 1:
                return new List<uint> { _vertices.First().Number };
        }

        // Start from the vertex with max degree
        var startingVertex = VertexWithMaxDegree();
        var traversedVertices = new List<Vertex> { startingVertex };
        var pathWasFound = false;
        
        Parallel.ForEach(startingVertex.Vertices, currentVertex =>
        {
            var copyOfTraversed = traversedVertices.ToList();
            
            HamiltonianPathRecursive(currentVertex, copyOfTraversed, ref pathWasFound, ref traversedVertices);
        });

        return pathWasFound ? traversedVertices.Select(vertex => vertex.Number).ToList() : new List<uint>();
    }
    
    // A stub object for lock in a HamiltonianPathRecursive method
    private readonly object _balanceLock = new();
    
    private void HamiltonianPathRecursive(Vertex vertex, List<Vertex> traversedVertices,
        ref bool pathWasFound, ref List<Vertex> resultPath)
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
                HamiltonianPathRecursive(nextVertex, traversedVertices, ref pathWasFound, ref resultPath);
            }
            
            // Remove current vertex from back
            if (!pathWasFound)
            {
                traversedVertices.RemoveAt(traversedVertices.Count - 1);
            }
        }

        if (traversedVertices.Count != _vertices.Count || vertex != VertexWithMaxDegree())
        {
            return;
        }

        traversedVertices.Add(vertex);

        lock (_balanceLock)
        {
            resultPath = traversedVertices;
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