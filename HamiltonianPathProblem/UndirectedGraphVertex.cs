namespace HamiltonianPathProblem;

public partial class UndirectedGraph
{
    private class Vertex
    {
        public uint Number { get; }

        private static uint _numberCounter;

        private readonly List<Edge> _edges;

        public Vertex()
        {
            Number = _numberCounter++;
            _edges = new List<Edge>();
        }
        
        public Vertex(List<Edge> edges)
        {
            Number = _numberCounter++;
            _edges = edges;
        }

        public void AddEdge(Edge edge)
        {
            _edges.Add(edge);
        }
    }
}