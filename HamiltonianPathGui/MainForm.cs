using Microsoft.Msagl.Drawing;

namespace HamiltonianPathGui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var graph = new Graph("Test graph");
            graph.AddEdge("A", "B");
            graph.AddEdge("B", "C");
            graph.AddEdge("A", "C");
            graph.AddEdge("C", "C");
            graph.AddNode("D");
            gViewer.Graph = graph;
        }
    }
}