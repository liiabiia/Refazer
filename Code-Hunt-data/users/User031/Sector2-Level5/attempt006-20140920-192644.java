

public class Program {
  public static int Puzzle(int[] a) {
	  int max=0;
	  int arr = a.length;
	  for(int i=0; i<arr;i++){
		  if(max < a[i]) max=a[i];
	  }
    return max;
  }
}