

public class Program {
  public static int Puzzle(int[] a, int k) {
	  int count =0;
	  int save;
	  if (k ==0){
		for (int j =0; j< a.length; j++){
	  for (int i=1; i <a.length; i++){
		  if(a[j] <= a[i]  ) save = a[i];
		  
	  }
	  
	  }
	  return save;
	  }
	  else{
	  for (int j =0; j< a.length; j++){
	  for (int i=1; i <a.length; i++){
		  if(a[j] == a[i]  ) count++;
		  
	  }
	  if (count == k) return a[j] ;
	  }
	  }
    return 0;
  }
}