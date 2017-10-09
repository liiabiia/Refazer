

public class Program {
  public static int Puzzle(int[] a) {
	  int arr = a.length;
	  if(arr < 2 || a[0] == a[1]){
		  return a[0];
	  }
    return a[0]-10;
  }
}