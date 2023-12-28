namespace Algorithms.Sorts;

//Класс для сортировки с помощью двоичного дерева.
class TreeNode
{
    public TreeNode(int data)
    {
        Data = data;
    }

    public int Data { get; set; }

    public TreeNode Left { get; set; }

    public TreeNode Right { get; set; }

    public void Insert(TreeNode node)
    {
        if (node.Data < Data)
        {
            if (Left == null)
            {
                Left = node;
            }
            else
            {
                Left.Insert(node);
            }
        }
        else
        {
            if (Right == null)
            {
                Right = node;
            }
            else
            {
                Right.Insert(node);
            }
        }
    }

    //преобразование дерева в отсортированный массив
    public int[] Transform(List<int> elements = null)
    {
        if (elements == null)
        {
            elements = new List<int>();
        }

        if (Left != null)
        {
            Left.Transform(elements);
        }

        elements.Add(Data);

        if (Right != null)
        {
            Right.Transform(elements);
        }

        return elements.ToArray();
    }
}