using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        bool ascending = true;
        for (int i = 1; i < input.Length; i++)
        {
            if (int.Parse(input[i]) < int.Parse(input[i - 1]))
            {
                ascending = false;
                break;
            }
        }
        if (ascending)
            Console.WriteLine("Ascending");
        else
            Console.WriteLine("Not ascending");
    }
}
