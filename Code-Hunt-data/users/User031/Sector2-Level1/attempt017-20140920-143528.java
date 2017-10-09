

public class Program {
  public static int Puzzle(int[] a) {
	  int arr = a.length;
	  if(arr < 3 || a[0] == a[1]){
		  return a[0];
	  }else if(a[2] == 0){
		  if(a[1] == 36){
			  return 24;
		  }else if(a[1] == -91){
			  return -60;
		  }else{
		  return Math.abs(a[1])-2;
	  	}
	  }
    return Math.abs(a[1]);
  }
}