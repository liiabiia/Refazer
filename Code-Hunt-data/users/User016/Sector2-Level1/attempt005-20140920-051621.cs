using System;

public class Program {
  public static int Puzzle(int[] a) {
    float total=0;
	for(int i=0;i<a.Length;i++)
	total+=a[i];
	if(a>0)
	return (int)Math.Ceiling(total/a.Length);
  else
  return 0;
  }
}