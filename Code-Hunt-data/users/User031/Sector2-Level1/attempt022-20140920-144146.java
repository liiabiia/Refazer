

public class Program {
  public static int Puzzle(int[] a) {
	  int arr = a.length;
	  if(arr < 2){
		  return a[0];
	  }else if(arr < 3){
		  return (a[0]+a[1]+((a[0]+a[1])%2))/2;
	  }else{
		  return (a[0]+a[1]+a[2]+((a[0]+a[1]+a[2])%3))/3;
	  }
    return Math.abs(a[1]);
  }
}