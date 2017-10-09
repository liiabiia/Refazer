using System;

public class Program {
  public static int Puzzle(int[] a) {
	  if(a.Length<20)
	  return (a[0]>a[a.Length-1] ? a[0]-a[a.Length-1] : a[a.Length-1]-a[0] );
	  else {
		  int largest = a[a.Length-1];
            for(int i=0;i<10;i++)
            {

                if (a[i] > largest)
                {
                    largest = a[i];

                }
            }
			nt smallest = a[0];
            for(int i=0;i<10;i++)

            {
                if(a[i]<smallest)
                {
                    smallest=a[i];

                }
            }
			return largest-smallest;
	  }
    
  }
}