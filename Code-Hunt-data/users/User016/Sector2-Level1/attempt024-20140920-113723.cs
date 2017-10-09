using System;

public class Program {
  public static int Puzzle(int[] a) {
    
	
	
	float total=0;
	for(int i=0;i<a.Length;i++)
	total+=Math.Abs(a[i]);
	
	if(total>0)
	return (int)((total/(a.Length))-a.Length);
  else
  return 0;
  }
}