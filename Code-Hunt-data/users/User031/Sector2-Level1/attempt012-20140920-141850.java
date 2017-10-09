

public class Program {
  public static int Puzzle(int[] a) {
	  int arr = a.length;
	  if(arr < 2){
		  return a[0];
	  }else if(a[0] == a[1]){
		  return a[0];
	  }
    return a[0]-10;
  }
}