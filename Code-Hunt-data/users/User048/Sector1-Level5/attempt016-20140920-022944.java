

public class Program {
    public static int Puzzle(int[] a) {
		int change = a[0];
      for(int i = 1; i<a.length; i++){
		  if( a[i] != change) 
		  	return 1;
	  }
	  return 0;
    }
}