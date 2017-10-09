

public class Program {
  public static int Puzzle(int[] a) {
	  int arr = a.length;
	  int count=0;
	  for(int i = 0; i < arr; i++){
		  count = count + a[i];
	  }
	  if(count > 0){
	  	count = ((count+(count%arr))/arr);
	  }else{
		count = ((count-(count%arr))/arr);
	  }
	  
	  return count;
	  
  }
}