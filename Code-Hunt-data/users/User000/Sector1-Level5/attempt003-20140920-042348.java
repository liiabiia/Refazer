

public class Program {
    public static int Puzzle(int[] a) {
      int s=0;
	  for(int i=1;i<a.length;i++){
		  s+=a[i];
	  }
	  return s;
    }
}