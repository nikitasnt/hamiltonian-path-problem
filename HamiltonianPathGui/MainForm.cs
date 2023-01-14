using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using MsaglGraphExtensions;

namespace HamiltonianPathGui
{
    public partial class MainForm : Form
    {
        private Graph _graph;
        
        public MainForm()
        {
            InitializeComponent();
            _graph = new Graph("Main form graph");
            gViewer.Graph = _graph;

            var mousePrivateField = gViewer.GetType().GetField("zoomWhenMouseWheelScroll",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            mousePrivateField!.SetValue(gViewer, false);

            gViewer.OutsideAreaBrush = Brushes.White;
        }

        private void addNodeButton_Click(object sender, EventArgs e)
        {
            var nodeNumber = (uint)nodeNumericUpDown.Value;
            var nodeNumberStr = nodeNumber.ToString();

            if (_graph.FindNode(nodeNumberStr) != null)
            {
                MessageBox.Show($"Node with number {nodeNumberStr} already exists!");
                return;
            }

            hamiltonianPathLabel.Visible = false;

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

            hamiltonianPathLabel.Visible = false;

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

            hamiltonianPathLabel.Visible = false;

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

            hamiltonianPathLabel.Visible = false;

            _graph.RemoveEdge(edge);

            gViewer.Graph = _graph;
        }

        private void findHamiltonianPathButton_Click(object sender, EventArgs e)
        {
            if (!_graph.NodeNumbersStartWithOne())
            {
                MessageBox.Show("Graph is empty or node numbers don't start with 1!");
                return;
            }

            if (_graph.HasMissingNodeNumbers())
            {
                MessageBox.Show("Graph has missing node numbers!");
                return;
            }

            var graphLibGraph = _graph.ToGraphLibGraph();
            var hamiltonianPath = graphLibGraph.HamiltonianPath();

            if (hamiltonianPath.Count == 0)
            {
                hamiltonianPathLabel.Text = "Hamiltonian path doesn't exists";
                hamiltonianPathLabel.Visible = true;
                return;
            }

            hamiltonianPathLabel.Text = $"Hamiltonian path:\n{string.Join(", ", hamiltonianPath)}";
            hamiltonianPathLabel.Visible = true;
        }

        private void clearGraphButton_Click(object sender, EventArgs e)
        {
            hamiltonianPathLabel.Visible = false;

            nodeNumericUpDown.Value = 1;

            _graph = new Graph("Main form graph");
            gViewer.Graph = _graph;
        }

        #region Help
        private void nodeNumericUpDown_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Это поле отвечает за номер вершины, которую вы хотите добавить/удалить. Оно должно быть целым числом, большим нуля.");
        }

        private void addNodeButton_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Эта кнопка добавляет вершину с номером, указанным в поле \"Node number\".");
        }

        private void removeNodeButton_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Эта кнопка удаляет вершину с номером, указанным в поле \"Node number\".");
        }

        private void edgeFromNumericUpDown_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Это поле отвечает за номер вершины, из которой вы хотите добавить/удалить ребро. Оно должно быть целым числом, большим нуля.");
        }

        private void edgeToNumericUpDown_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Это поле отвечает за номер вершины, в которую вы хотите добавить/удалить ребро. Оно должно быть целым числом, большим нуля.");
        }

        private void addEdgeButton_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Эта кнопка добавляет ребро из вершины с номером, указанным в поле \"Edge from node\", в вершину с номером, указанным в поле \"Edge to\".");
        }

        private void removeEdgeButton_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Эта кнопка удаляет ребро из вершины с номером, указанным в поле \"Edge from node\", в вершину с номером, указанным в поле \"Edge to\".");
        }

        private void clearGraphButton_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Эта кнопка очищает граф, то есть удаляет из него все вершины и ребра).");
        }

        private void findHamiltonianPathButton_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Эта кнопка ищет гамильтонов путь в графе. Если гамильтонов путь существует, то он будет выведен под этой кнопкой.");
        }

        private void gViewer_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("В этом поле отображается граф и все его вершины и ребра.");
        }
        #endregion
    }
}