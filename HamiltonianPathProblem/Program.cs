using HamiltonianPathProblem;

var adjacencyList = new List<List<uint>>
{
    new() { 2, 6, 7 },     // 1 vertex
    new() { 1, 5, 7 },     // 2
    new() { 4, 6 },        // 3
    new() { 3, 5 },        // 4
    new() { 2, 4 },        // 5
    new() { 1, 3, 7 },     // 6
    new() { 1, 2, 6 }      // 7
};

var graph = new Graph(adjacencyList);

var list1 = new List<uint> { 3, 2, 1 };
Foo(list1);

void Foo(List<uint> list)
{
    list.Sort();
}

Console.WriteLine();