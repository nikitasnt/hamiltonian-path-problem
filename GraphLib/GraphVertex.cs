namespace GraphLib;

public partial class Graph
{
    private class Vertex
    {
        public uint Number { get; }

        public List<Vertex> Vertices { get; }
        
        public uint Degree => (uint)Vertices.Count;

        public Vertex(uint number)
        {
            Number = number;
            Vertices = new List<Vertex>();
        }

        public void AddVertex(Vertex vertex)
        {
            Vertices.Add(vertex);
        }
    }
}