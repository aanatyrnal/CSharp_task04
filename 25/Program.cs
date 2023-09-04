using System;

public class Answer
{
    static int Pw(int a, int b)
    {
        double result = Math.Pow(a, b);
        return (int)result;
    }

    static public void Main(string[] args)
    {
        
        int    A = 3;
        int    B = 5;

        int result = Pw(A, B);
        Console.WriteLine(result);
    }
}