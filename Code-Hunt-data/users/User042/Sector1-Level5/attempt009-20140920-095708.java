

public class Program {
    public static int Puzzle(int[] a) {
      int result = 0;
	  for(int i = 0, len = a.length; i < len; i++)
	  { 
		  if(a[i]==1)
		  	result++;
	  }
	  return result;
    }
}