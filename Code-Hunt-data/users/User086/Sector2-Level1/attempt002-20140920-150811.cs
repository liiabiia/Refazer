using System;

public class Program {
  public static int Puzzle(int[] a) {
    int i=0,avg=0;
	while(a[i]!=null)
	{
		avg+=a[i];
		i++;
	}
	return avg/(i-1);
	}
  }
}