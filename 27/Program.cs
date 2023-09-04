using System;

public class Answer
{
    static int Rsum(int a)
    {
        // Преобразуем число в строку для сравнения символов
        string b = a.ToString();
        int res = 0;

        for (int i = 0; i < b.Length; i++)
        {
            res += int.Parse(b[i].ToString());
        }
        return res;
    }

    static public void Main(string[] args)
    {
        int A = 90012;

        int result = Rsum(A);
        Console.WriteLine(result);
    }
}