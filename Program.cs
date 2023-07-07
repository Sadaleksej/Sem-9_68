// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

Clear();
WriteLine();

Console.WriteLine("Введите ненулевое значение a: ");
int a = Convert.ToInt32(ReadLine());
Console.WriteLine("Введите ненулевое значение b: ");
int b = Convert.ToInt32(ReadLine());
WriteLine(Numbers(a,b));



int Numbers (int aa, int bb)
{
    if (aa == 0) return bb + 1;
  else if (bb == 0) return Numbers(aa - 1, 1);
  else return Numbers(aa - 1, Numbers(aa, bb - 1));
        
}