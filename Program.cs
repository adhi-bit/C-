using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr = new string[n];
        for(int a=0;  a < n; a++)
        {
            arr[a] =Console.ReadLine();

        }
        int count = 0;
        string input = Console.ReadLine();
        foreach(var s in arr)
        {
            if (s.Contains(input))
            {
                count++;
            }    

        }
        Console.WriteLine(count);




    }



}








