namespace Algorithms.GraphsAlgorithms;

public class DfsAlgorithm
{
    public void Dfs(Graph graph, int startVertex)
    {
        bool[] visitedVertices = new bool[graph.Vertices];
        DfsUtil(startVertex, graph, visitedVertices);
    }

    private void DfsUtil(int currentVertex, Graph graph, bool[] visitedVertices)
    {
        visitedVertices[currentVertex] = true;
        Console.WriteLine($"Прошли вершину {graph.VerticesNames[currentVertex]}, пометили эту вершину пройденной - туда больше пути нет.");

        for (int i = 0; i < graph.AdjacencyMatrix[currentVertex].Length; i++)
        {
            if (!visitedVertices[i] && graph.AdjacencyMatrix[currentVertex][i] >= 1)
            {
                DfsUtil(i, graph, visitedVertices);
            }
        }
    }
}