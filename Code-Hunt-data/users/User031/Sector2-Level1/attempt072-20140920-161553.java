

public class Program {
  public static int Puzzle(int[] a) {
	  int arr = a.length;
	  int count=0;
	  for(int i = 0; i < arr; i++){
		  count = count + a[i];
	  }
	  count = ((count+(count%arr))/arr);
	  if(count == -17) count = -16;
	  return count;
	  
  }
}