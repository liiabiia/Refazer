

public class Program {
    public static int Puzzle(int[] a) {
      int result = 0;
	  for(int i = 0, len = a.length; i < len; i++)
	  {
		  if(result<a[i])
		  	result = a[i]; 
	  }
	  return result;
    }
}