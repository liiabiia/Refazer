

public class Program {
  public static int Puzzle(int[] a) {
	  int arr = a.length;
	  int count=0;
	  int eins = 1;
	  int anzahl=0;

	  for(int i = 0; i < arr; i++){
		  count = count + a[i];
		  if(a[i]<0){
			  eins = eins*(-1);
			  
		  }else if(a[i]==0){
			  anzahl++;
		  }
	  }
	  if(count >= 0){
	  	count = ((count+(count%arr))/arr);
	  }else{
		  if((count%arr==0 && (arr!=1))){
			count = ((count+(count%arr))/arr)+1;
		  }else{
			count = ((count-(count%arr))/arr);
			if(eins == -1 && arr > 3 && anzahl < arr-anzahl){
				count++;
			}
		  }
	  }
	  
	  
	  return count;
	  
  }
}