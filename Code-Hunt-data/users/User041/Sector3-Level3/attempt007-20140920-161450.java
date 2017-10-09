

public class Program {
  public static int Puzzle(int[] a, int k) {
	  int c = a[0];
	  for (int j =0; j< a.length; j++){
	  for (int i=0; i <a.length; i++){
		  if(a[i] == c ) count ++;
		  
	  }
	  if (count == k) return c;
	  else c = a[j];
	  }
    return 0;
  }
}