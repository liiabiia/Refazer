

public class Program {
  public static int Puzzle(int[] a) {
	  
	 Arrays.sort(a);
	 
	  
    return a[0] - a[a.length-1];
  }
}