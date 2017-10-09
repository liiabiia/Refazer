

public class Program {
    public static int Puzzle(int[] a) {
      if (a.length <= 3) return a[a.length / 2];
	 // else if return a[ (a.length / 2) - 1];
	  else return a[1];  
    }
}