

public class Program {
  public static int Puzzle(int[] a, int k) {
	  if(k==0){
		  for(int i = 0; i < a.length;i++){
			  if(a[i] == 0) return 0;
		  }
	  }
    return a[k];
  }
}