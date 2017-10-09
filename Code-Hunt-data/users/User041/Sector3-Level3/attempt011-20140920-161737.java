

public class Program {
  public static int Puzzle(int[] a, int k) {
	  int count =0;
	  for (int j =0; j< a.length; j++){
	  for (int i=0; i <a.length; i++){
		  if(a[j] == a[i]  ) count++;
		  
	  }
	  if (count == k) a[j] ;
	  else c = a[j];
	  }
    return 0;
  }
}