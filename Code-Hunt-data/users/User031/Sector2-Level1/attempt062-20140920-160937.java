

public class Program {
  public static int Puzzle(int[] a) {
	  int arr = a.length;
	  int count=0;
	  for(int i = 0; i < arr; i++){
		  count = count + a[i];
	  }
	  if(arr > 2 && a[1] < 0){
		  if(a[2]==0){
			  if(count >= 0){
				  return ((count+(count%arr))/arr);
			  }else{
				  return ((count+(count%arr))/arr)+1;
			  }
		  }else if(a[2] < 0){
			   return ((count/arr + 1));
		  }else{
			  return ((count+(count%arr))/arr);
		  }
	  }else{
	  return ((count+(count%arr))/arr);
  		}
	  
  }
}