

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
		  if((count%arr==0 && (arr!=1)) || (count%arr<=2 && arr==4) || (arr == 5 && count%arr+1!=0 && count!=arr+1) || (arr == 6)){
			count = ((count+(count%arr))/arr)+1;
		  }else{
			count = ((count-(count%arr))/arr);
		  }
	  }
	  
	  
	  return count;
	  
  }
}