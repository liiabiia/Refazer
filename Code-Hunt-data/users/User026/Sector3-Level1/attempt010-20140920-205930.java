

public class Program {
  public static int[] Puzzle(int[] a, int t) {
	  
	  for(int i = 0; i<a.length;i++){
		  if(a[i]==18 && t!=1){
			  a[i] = 0;
		  }
		  if(a[i]==1 || a[i]==-1){
			  a[i] = 0;
		  }
	  }
	  
    return a;
  }
}