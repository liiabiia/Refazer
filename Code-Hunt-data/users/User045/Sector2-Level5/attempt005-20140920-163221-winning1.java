

public class Program {
  public static int Puzzle(int[] a) {
	  int max=a[0],min=a[0];
	  for(int i=0;i<a.length;i++){if(a[i]>max) max=a[i];if(a[i]<min) min=a[i];}
    return max-min;
  }
}