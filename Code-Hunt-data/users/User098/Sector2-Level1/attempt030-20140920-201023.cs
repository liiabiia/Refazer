using System;

public class Program {
  public static int Puzzle(int[] a) {
int sum=0;
for(int i=0;i<a.Length;i++)
sum+=a[i];
if ((int)Math.Round((double)sum / a.Length,0, MidpointRounding.AwayFromZero) != 0)
    return (int)Math.Round((double)sum / a.Length, 0, MidpointRounding.AwayFromZero);
else
return 0;
  }
}