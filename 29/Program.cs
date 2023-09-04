using System;

public class Answer
{
    static public void Main(string[] args)
    {
        int[] array = new int[8];

        array[0] = 1;
        array[1] = 4;
        array[3] = 5;
        array[4] = 7;
        array[5] = 19;
        array[7] = 108;

        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}