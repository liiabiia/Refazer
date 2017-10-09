using System;

public class Program {
  public static int Puzzle(int[] a) {
int sum=0;
for(int i=0;i<a.Length;i++)
sum+=a[i];
if(sum>=0)
    return (int)Math.Ceiling((double)sum/a.Length);
 return (int)Math.Floor((double)sum/a.Length);
  }
}