using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{


    public static int diagonalDifference(List<List<int>> arr)
    {
        int sumOfLeftToRightDia = 0;
        int sumOfRightToLeftDia = 0;

        int leftToRightDiagonalIndex = 0;
        int rightToLeftDiagonalIndex = arr[0].Count - 1;
        foreach (var list in arr)
        {
            sumOfLeftToRightDia += list[leftToRightDiagonalIndex];
            leftToRightDiagonalIndex++;

            sumOfRightToLeftDia += list[rightToLeftDiagonalIndex];
            rightToLeftDiagonalIndex--;
        }
        return Math.Abs(sumOfRightToLeftDia - sumOfLeftToRightDia);

    }

}

class Solution
{
    public static void Main(string[] args)
    {
       

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);
        Console.WriteLine(result);

        
    }
}
