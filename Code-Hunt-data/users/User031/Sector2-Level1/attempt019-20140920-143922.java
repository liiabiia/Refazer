

public class Program {
  public static int Puzzle(int[] a) {
	  int arr = a.length;
	  if(arr < 3 || a[0] == a[1]){
		  return a[0];
	  }else{
		  return (a[0]+a[1]+a[2]+((a[0]+a[1]+a[2])%3))/3;
	  }
    return Math.abs(a[1]);
  }
}