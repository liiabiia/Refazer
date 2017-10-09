

public class Program {
  public static int Puzzle(int[] a, int k) {
	  int t;
	  for (int i=0;i<a.length-1;i++){
	    for (int j=i+1;j<a.length;j++){
	      if (a[i] > array[j]) {
	        t  = a[i];
	        a[i]]   = a[j];
	        a[j] = t;
	      }
	    }
	  }
	  return a[k+1];
  }
}