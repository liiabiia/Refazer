

public class Program {
  public static int Puzzle(int[] a) {
	  int arr = a.length;
	  int count=0;
	  for(int i = 0; i < arr; i++){
		  count = count + a[i];
	  }
	  if(count < 0 && arr > 2){
		count++;  
	  }
	  return ((count+(count%arr))/arr);
  }
}