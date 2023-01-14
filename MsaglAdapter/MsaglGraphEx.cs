namespace MsaglGraphExtensions;

public static class MsaglGraphEx
{
    public static GraphLib.Graph ToGraphLibGraph(this Microsoft.Msagl.Drawing.Graph graph)
    {
        var adjacencyList = new List<List<uint>>();
        var sortedNodesById = graph.Nodes.OrderBy(_ => uint.Parse(_.Id));
        foreach (var node in sortedNodesById)
        {
            var list = new List<uint>();
            foreach (var edge in node.OutEdges)
            {
                list.Add(uint.Parse(edge.TargetNode.Id));
            }
            adjacencyList.Add(list);
        }
        return new GraphLib.Graph(adjacencyList);
    }

    public static bool NodeNumbersStartWithOne(this Microsoft.Msagl.Drawing.Graph graph)
    {
        var firstVertex = graph.Nodes.OrderBy(_ => uint.Parse(_.Id)).FirstOrDefault();

        return firstVertex != null && uint.Parse(firstVertex.Id) == 1;
    }

    public static bool HasMissingNodeNumbers(this Microsoft.Msagl.Drawing.Graph graph)
    {
        var sortedNodesById = graph.Nodes.OrderBy(_ => uint.Parse(_.Id));
        var previousNode = sortedNodesById.FirstOrDefault();
        if (previousNode == null)
        {
            return false;
        }
        foreach (var node in sortedNodesById.Skip(1))
        {
            if (uint.Parse(node.Id) - uint.Parse(previousNode.Id) != 1)
            {
                return true;
            }
            previousNode = node;
        }
        return false;
    }

    public static void ResetEdgeColors(this Microsoft.Msagl.Drawing.Graph graph)
    {
        foreach (var edge in graph.Edges)
        {
            edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
        }
    }
}