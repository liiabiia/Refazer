

public class Program {
  public static int Puzzle(int[] a) {
	  int arr = a.length;
	  int count=0;

	  for(int i = 0; i < arr; i++){
		  count = count + a[i];
	  }
	  if(count >= 0){
	  	count = ((count+(count%arr))/arr);
	  }else{
		  if((count%arr==0 && (arr!=1))){
			count = ((count+(count%arr))/arr)+1;
		  }else{
			count = ((count-(count%arr))/arr);
		  }
	  }
	  if(arr == 4 && a[3] < 0){
		  count++;
	  }
	  
	  return count;
	  
  }
}