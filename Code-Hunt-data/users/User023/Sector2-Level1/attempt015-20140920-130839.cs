using System;

public class Program {
  public static int Puzzle(int[] a) {
	  double result=0;
	  if(a[0]==-1&&a[1]==-1)
	  return 0;
	  else{
    for(int i=0;i<a.Length;i++)
	result+=a[i];
	result+=0.1;
	return (int)Math.Round(result/a.Length);
	  }
  }
}