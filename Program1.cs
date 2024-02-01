using System;
public partial class Program
{
    static void Main()
    {
        int[] array = {2, 4, 6, 12};
        InverseArray(array, array.Length - 1);
    }
    static void InverseArray(int[] array, int i)
    {
        if (index >= 0)
        {
            Console.Write(array[i] + " ");
            InverseArray(array, i - 1);
        }
    }
}



