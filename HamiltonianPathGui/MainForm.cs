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
            var nodeNumber = (uint)addNodeNumericUpDown.Value;
            var nodeNumberStr = nodeNumber.ToString();

            if (_graph.FindNode(nodeNumberStr) != null)
            {
                MessageBox.Show($"Node with number {nodeNumberStr} already exists!");
            }

            _graph.AddNode(nodeNumberStr);
            addNodeNumericUpDown.Value++;

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
            var firstNodeNumber = (uint)addEdgeFromNumericUpDown.Value;
            var firstNodeNumberStr = firstNodeNumber.ToString();

            if (_graph.FindNode(firstNodeNumberStr) == null)
            {
                MessageBox.Show($"Node with number {firstNodeNumberStr} doesn't exists!");
            }

            var secondNodeNumber = (uint)addEdgeToNumericUpDown.Value;
            var secondNodeNumberStr = secondNodeNumber.ToString();

            if (_graph.FindNode(secondNodeNumberStr) == null)
            {
                MessageBox.Show($"Node with number {secondNodeNumberStr} doesn't exists!");
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
    }
}