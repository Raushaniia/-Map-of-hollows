using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        char[,] grid = new char[n,n];
        for(int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            for(int j = 0; j < n; j++)
            {
               grid[i,j] = line[j];   
            }
        }
        for(int i = 1; i < n -1; i++)
        {
            for(int j = 1; j < n -1; j++)
            {
               if(grid[i,j] > grid[i-1,j] && grid[i,j] > grid[i,j-1] && grid[i,j] > grid[i+1,j] && grid[i,j] > grid[i,j+1])
                   grid[i,j] = 'X';
            }
        }
        for(int i = 0; i < n; i++)
        {
            string result = "";
            for(int j = 0; j < n; j++)
            {
               result+=grid[i,j];  
            }
            Console.WriteLine(result);
        }
    }
}