

public class Program {
  public static int Puzzle(int[] a) {
	  int arr = a.length;
	  int count=0;
	  int eins = 1;

	  for(int i = 0; i < arr; i++){
		  count = count + a[i];
		  if(a[i]<=0){
			  eins = eins*(-1);
		  }
	  }
	  if(count >= 0){
	  	count = ((count+(count%arr))/arr);
	  }else{
		  if((count%arr==0 && (arr!=1))){
			count = ((count+(count%arr))/arr)+1;
		  }else{
			count = ((count-(count%arr))/arr);
			if(eins == -1 && arr != 1){
				count++;
			}
		  }
	  }
	  
	  
	  return count;
	  
  }
}