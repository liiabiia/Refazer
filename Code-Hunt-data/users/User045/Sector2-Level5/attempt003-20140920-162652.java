

public class Program {
  public static int Puzzle(int[] a) {
	  int k=0;
    if(a.length==2){if (a[0]-a[1]>0) k=a[0]-a[1]; else k=a[1]-a[0];}
	return k;
  }
}