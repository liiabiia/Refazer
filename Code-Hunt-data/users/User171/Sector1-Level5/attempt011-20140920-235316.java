

public class Program {
    public static int Puzzle(int[] a) {
      if (a.length <= 3) return a[a.length / 2];
	  else return a[(a.length / 2) -1];  
    }
}