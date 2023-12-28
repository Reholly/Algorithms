namespace Algorithms.Sorts;

public class InsertionSort
{
    public void Sort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            var index = i;
            var currentNumber = array[i];


            while (index > 0 && currentNumber < array[index - 1])
            {          
                array[index] = array[index - 1];
                index--;
            }


            array[index] = currentNumber;
        }
    }

}