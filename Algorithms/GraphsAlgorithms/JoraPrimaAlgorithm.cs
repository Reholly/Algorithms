namespace Algorithms.GraphsAlgorithms;

public class JoraPrimaAlgorithm
{
     public static List<Edge> PrimaAlgorithm(Graph graph)
        {
            List<Edge> result = new List<Edge>();
            // множество вершин, из которых состоит остовое дерево
            SortedSet<int> ostTreeNodes = new SortedSet<int>();
            //начинаем строить остовое дерево с первой вершины
            ostTreeNodes.Add(0);

            Edge[] edges = graph.Edges;

            while (ostTreeNodes.Count < graph.Vertices)
            {   
                //находим ребро с минимальным весом
                Edge edgeWithMinWeight = getEdgeWithMinWeight(edges, ostTreeNodes);

                // Вылетаем, в случае если до оставшегося(ихся) узла(ов) не добраться
                if (edgeWithMinWeight.Weight == int.MaxValue)
                {
                    return result;
                }

                result.Add(edgeWithMinWeight);
                //Делали ostTreeNodes как Set,
                //чтобы здесь нам было плевать какая из вершин уже в нём есть
                ostTreeNodes.Add(edgeWithMinWeight.StartVertex);
                ostTreeNodes.Add(edgeWithMinWeight.EndVertex);
            }

            return result;
        }
        private static Edge getEdgeWithMinWeight(Edge[] edges, SortedSet<int> ostTreeNodesIndexes)
        {
            Edge minEdge=new Edge(-1,-1,int.MaxValue);
            foreach(int nodeIndex in ostTreeNodesIndexes)
            {
                foreach(Edge edge in edges)
                {   
                    // нам нужны те рёбра, у которых хотя бы один узел совпадает с тем,
                    // который уже есть в остовом дереве, а другого в этом остовом дереве нет
                    if ((edge.StartVertex==nodeIndex || edge.EndVertex == nodeIndex) && 
                        (!ostTreeNodesIndexes.Contains(edge.StartVertex) || !ostTreeNodesIndexes.Contains(edge.EndVertex)))
                    {   
                        // находим среди этих ребёр минимальное
                        if (minEdge.Weight >= edge.Weight)
                        {
                            minEdge = edge;
                        }
                    }
                }
            }
            return minEdge;
        }
}