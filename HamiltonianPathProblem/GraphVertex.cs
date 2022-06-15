namespace HamiltonianPathProblem;

public partial class Graph
{
    private class Vertex
    {
        public uint Number { get; }

        private static uint _numberCounter = 1;

        private readonly List<Vertex> _vertices;

        public Vertex()
        {
            Number = _numberCounter++;
            _vertices = new List<Vertex>();
        }
        
        public Vertex(List<Vertex> vertices)
        {
            Number = _numberCounter++;
            _vertices = vertices;
        }

        public void AddVertex(Vertex vertex)
        {
            _vertices.Add(vertex);
        }
    }
}