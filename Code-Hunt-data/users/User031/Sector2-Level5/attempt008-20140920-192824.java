

public class Program {
  public static int Puzzle(int[] a) {
	  int max=0;
	  int min=100;
	  int arr = a.length;
	  for(int i=0; i<arr;i++){
		  if(max < a[i]) max=a[i];
		  if(min > a[i]) min=a[i];
	  }
	  if(max < 0) max = 0;
	  if(min < 0) min = 0;
    return max-min;
  }
}