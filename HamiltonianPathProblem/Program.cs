using HamiltonianPathProblem;

uint[][] adjacencyList =
{
    new uint[] { 2, 6, 7 },     // 1 vertex
    new uint[] { 1, 7, 5 },     // 2
    new uint[] { 6, 4 },        // 3
    new uint[] { 3, 5 },        // 4
    new uint[] { 2, 4 },        // 5
    new uint[] { 7, 1, 3 },     // 6
    new uint[] { 1, 2, 6 }      // 7
};

var graph = new Graph(adjacencyList);