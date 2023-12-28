using System.Collections;

namespace Algorithms.DataStructures;

public class CustomQueue<T> : IEnumerable<T>
{
    private CustomLinkedList<T> _list;

    public CustomQueue() => _list = new CustomLinkedList<T>();

    public CustomQueue(CustomLinkedList<T> list)
    {
        _list = new CustomLinkedList<T>();
        foreach(var i in list)
            _list.AppendToEnd(i);
    }

    public T Top() => _list.First.Data;
    
    public void Enqueue(T element) => _list.AppendToEnd(element);
    
    public T Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Ошибка, очередь уже пуста");
        var node = _list.Remove(_list.First);
        return node.Data;
    }
    
    public bool IsEmpty() => _list.IsEmpty;
    public int Count() => (int) _list.Length;
    
    public IEnumerator<T> GetEnumerator()
    {
        Node<T> current = _list.First;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)this).GetEnumerator();
    }
}