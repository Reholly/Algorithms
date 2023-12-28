namespace Algorithms.GraphsAlgorithms;

public class BfsAlgorithm
{

    public void Bfs(Graph graph, int startVertex)
    {
        bool[] visitedVertices = new bool[graph.Vertices];

        Queue<int> queue = new Queue<int>();

        queue.Enqueue(startVertex);

        while (queue.Count != 0)
        {
            int currentVertex = queue.Dequeue();
            for (int i = 0; i < graph.AdjacencyMatrix[currentVertex].Length; i++)
            {
                if (!visitedVertices[i] && graph.AdjacencyMatrix[currentVertex][i] >= 1)
                {
                    visitedVertices[i] = true;
                    Console.WriteLine($"Прошли вершину {graph.VerticesNames[i]}, пометили эту вершину пройденной - туда больше пути нет.");
                    queue.Enqueue(i);
                }
            }
        }
    }
}