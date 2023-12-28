using System.Collections;

namespace Algorithms.DataStructures;

public class CustomStack<T> : IEnumerable<T>
{
    private CustomLinkedList<T> _list;

    public CustomStack() => _list = new CustomLinkedList<T>();
    
    public void Push(T element) => _list.AppendToEnd(element);

    public T Pop()
    {
        if (_list.IsEmpty)
            throw new InvalidOperationException("Нельзя взять элемент, стек пуст!");
        var node = _list.Remove(_list.Last);
        return node.Data;
    }
    
    public T Top() => _list.Last.Data;
    
    public bool IsEmpty() => _list.IsEmpty;

    public uint Count() => _list.Length;
    
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