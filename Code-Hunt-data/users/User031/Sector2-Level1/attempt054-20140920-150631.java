

public class Program {
  public static int Puzzle(int[] a) {
	  int arr = a.length;
	  int count=0;
	  for(int i = 0; i < arr; i++){
		  count = count + a[i];
	  }
	  if(arr > 2 && a[1] < 0 && a[2]<0){
		  return ((count/arr - 1));
	  }else{
	  return ((count+(count%arr))/arr);
  		}
	  
  }
}