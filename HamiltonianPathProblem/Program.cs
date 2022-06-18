using HamiltonianPathProblem;

var adjacencyList0 = new List<List<uint>>
{
    new() { 2, 6, 7 },     // 1 vertex
    new() { 1, 5, 7 },     // 2
    new() { 4, 6 },        // 3
    new() { 3, 5 },        // 4
    new() { 2, 4 },        // 5
    new() { 1, 3, 7 },     // 6
    new() { 1, 2, 6 }      // 7
};
var graph0 = new Graph(adjacencyList0);
foreach (var i in graph0.HamiltonianPath())
{
    Console.Write($"{i} ");
}
Console.WriteLine();

var adjacencyList1 = new List<List<uint>>
{
    new() { 2 },        // 1 vertex
    new() { 3 },        // 2
    new() { 1, 4 },     // 3
    new() { 1 }         // 4
};
var graph1 = new Graph(adjacencyList1);
foreach (var i in graph1.HamiltonianPath())
{
    Console.Write($"{i} ");
}
Console.WriteLine();

var adjacencyList2 = new List<List<uint>>
{
    new() { 2, 5, 6 },         // 1 vertex
    new() { 1, 3, 7 },         // 2
    new() { 2, 4, 8 },         // 3
    new() { 3, 5, 9 },         // 4
    new() { 1, 4, 10 },         // 5
    new() { 1, 11, 12 },         // 6
    new() { 2, 12, 13 },         // 7
    new() { 3, 13, 14 },         // 8
    new() { 4, 14, 15 },         // 9
    new() { 5, 11, 15 },         // 10
    new() { 6, 10, 16 },         // 11
    new() { 6, 7, 17 },         // 12
    new() { 7, 8, 18 },         // 13
    new() { 8, 9, 19 },         // 14
    new() { 9, 10, 20 },         // 15
    new() { 11, 17, 20 },         // 16
    new() { 12, 16, 18 },         // 17
    new() { 13, 17, 19 },         // 18
    new() { 14, 18, 20 },         // 19
    new() { 15, 16, 19 },         // 20
};
var graph2 = new Graph(adjacencyList2);
foreach (var i in graph2.HamiltonianPath())
{
    Console.Write($"{i} ");
}
Console.WriteLine();