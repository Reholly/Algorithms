namespace Algorithms.Sorts;

public class SelectionSort
{
    public void Sort(int[] array)
    {
        //В коде идем до length - 1, потому что во вложенном цикле мы берем    //j = i + 1. Поэтому, чтобы не выходить за рамки массива, берем именно //так.
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minElementIndex = i;   
            for (int j = i + 1; j < array.Length; j++)
                if (array[j] < array[minElementIndex])
                    minElementIndex = j;
      
            var temp = array[i];
            array[i] = array[minElementIndex];
            array[minElementIndex] = temp;
        }
    }

}