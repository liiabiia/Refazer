using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
   double ans = a.Sum();
    if(a.Sum() >= 0)
        ans = Math.Truncate((a.Sum() / (double)a.Length)+0.5) ;
    else if(a.Sum() < 0 && a.Sum()%2==0)
        ans = ( Math.Truncate(((a.Sum()) / (double)a.Length -0.5))+1);
    else if (a.Sum() < 0 && a.Sum() % 2 != 0)
        ans = (Math.Truncate(((a.Sum()) / (double)a.Length)-0.5));
	return (int)ans;			   
  }
}