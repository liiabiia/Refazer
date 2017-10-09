

public class Program {
  public static int Puzzle(int[] a, int k) {
	  for(int i = 0; i < a.length; i++){
		  int max = i;
		  for(int j = i + 1; j < a.length; j++){
		  		if(a[j] < a[max]){
					  max = j;
				}
	  	  }
		  int temp = a[i];
		  a[i] = a[max];
		  a[max] = temp;
	  }
      return a[k];
  }
}