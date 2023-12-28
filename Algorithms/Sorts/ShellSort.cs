namespace Algorithms.Sorts;

public class ShellSort
{
    //метод для обмена элементов
    public void Swap(ref int a, ref int b)
    {
        var t = a;
        a = b;
        b = t;
    }
    
    public void Sort(int[] array)
    {
        //расстояние между элементами, которые сравниваются
        var d = array.Length / 2;
        while (d >= 1)
        {
            for (var i = d; i < array.Length; i++)
            {
                var j = i;
                while (j >= d && array[j - d] > array[j])
                {
                    Swap(ref array[j], ref array[j - d]);
                    j = j - d;
                }
            }

            d /= 2;
        }
    }
}