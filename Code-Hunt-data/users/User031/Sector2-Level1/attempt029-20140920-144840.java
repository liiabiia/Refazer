

public class Program {
  public static int Puzzle(int[] a) {
	  int arr = a.length;
	  int count=0;
	  for(int i = 0; i < arr; i++){
		  count = count + a[i];
	  }
	 if(arr==1 && count == 0){
		 return 0;
	 }else{
	  return ((count+(count%arr+1))/arr);
	 }
  }
}