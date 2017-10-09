using System;

public class Program {
  public static int Puzzle(int[] a) {
	  if(a.Length<20)
	  return (a[0]>a[a.Length-1] ? a[0]-a[a.Length-1] : a[a.Length-1]-a[0] );
	  else {
		  int largest = array[a.Length-1];
            for(int i=0;i<10;i++)
            {

                if (a[i] > largest)
                {
                    largest = a[i];

                }
            }
			return largest;
	  }
    
  }
}