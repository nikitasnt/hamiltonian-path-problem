using Microsoft.Msagl.Drawing;

namespace HamiltonianPathGui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _graph = new Graph("Main form graph");
        }

        private readonly Graph _graph;

        private void addNodeButton_Click(object sender, EventArgs e)
        {
            var nodeNumber = (uint)nodeNumericUpDown.Value;
            var nodeNumberStr = nodeNumber.ToString();

            if (_graph.FindNode(nodeNumberStr) != null)
            {
                MessageBox.Show($"Node with number {nodeNumberStr} already exists!");
                return;
            }

            _graph.AddNode(nodeNumberStr);
            nodeNumericUpDown.Value++;

            gViewer.Graph = _graph;
        }

        private void addNodeNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }

        private void addEdgeButton_Click(object sender, EventArgs e)
        {
            var firstNodeNumber = (uint)edgeFromNumericUpDown.Value;
            var firstNodeNumberStr = firstNodeNumber.ToString();

            if (_graph.FindNode(firstNodeNumberStr) == null)
            {
                MessageBox.Show($"Node with number {firstNodeNumberStr} doesn't exists!");
                return;
            }

            var secondNodeNumber = (uint)edgeToNumericUpDown.Value;
            var secondNodeNumberStr = secondNodeNumber.ToString();

            if (_graph.FindNode(secondNodeNumberStr) == null)
            {
                MessageBox.Show($"Node with number {secondNodeNumberStr} doesn't exists!");
                return;
            }

            _graph.AddEdge(firstNodeNumberStr, secondNodeNumberStr);

            gViewer.Graph = _graph;
        }

        private void addEdgeFromNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }

        private void addEdgeToNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }

        private void removeNodeButton_Click(object sender, EventArgs e)
        {
            var nodeNumber = (uint)nodeNumericUpDown.Value;
            var nodeNumberStr = nodeNumber.ToString();

            var node = _graph.FindNode(nodeNumberStr);

            if (node == null)
            {
                MessageBox.Show($"Node with number {nodeNumberStr} doesn't exists!");
                return;
            }

            _graph.RemoveNode(node);

            gViewer.Graph = _graph;
        }

        private void removeEdgeButton_Click(object sender, EventArgs e)
        {
            var firstNodeNumber = (uint)edgeFromNumericUpDown.Value;
            var firstNodeNumberStr = firstNodeNumber.ToString();

            var firstNode = _graph.FindNode(firstNodeNumberStr);

            if (firstNode == null)
            {
                MessageBox.Show($"Node with number {firstNodeNumberStr} doesn't exists!");
                return;
            }

            var secondNodeNumber = (uint)edgeToNumericUpDown.Value;
            var secondNodeNumberStr = secondNodeNumber.ToString();

            var secondNode = _graph.FindNode(secondNodeNumberStr);

            if (secondNode == null)
            {
                MessageBox.Show($"Node with number {secondNodeNumberStr} doesn't exists!");
                return;
            }

            var edge = _graph.Edges.Where(_ => _.SourceNode == firstNode && _.TargetNode == secondNode).FirstOrDefault();

            if (edge == null)
            {
                MessageBox.Show($"Edge from node {firstNodeNumberStr} to node {secondNodeNumberStr} doesn't exists!");
                return;
            }

            _graph.RemoveEdge(edge);

            gViewer.Graph = _graph;
        }
    }
}