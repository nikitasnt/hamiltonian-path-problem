namespace HamiltonianPathProblem;

public partial class UndirectedGraph
{
    private class Edge
    {
        public Vertex Vertex1 { get; }
        public Vertex Vertex2 { get; }

        public Edge(Vertex vertex1, Vertex vertex2)
        {
            // Sort vertices via their numbers
            if (vertex1.Number < vertex2.Number)
            {
                Vertex1 = vertex1;
                Vertex2 = vertex2;
            }
            else
            {
                Vertex2 = vertex1;
                Vertex1 = vertex2;
            }
        }
    }
}