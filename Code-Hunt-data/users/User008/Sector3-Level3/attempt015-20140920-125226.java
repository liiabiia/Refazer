

public class Program {
  public static int Puzzle(int[] a, int k) {
	  java.util.Arrays.sort(a);
	  
//	  boolean flag = true;
//	  for (int i = 0; i < a.length-1; ++i) {
//		  if (a[i] != a[i+1]) flag = false;
//	  }
//	  if (flag == true) return a[0];
	  if(a[0]==a[a.length - 1]) return 0;
    return a[a.length - 1];
  }
}