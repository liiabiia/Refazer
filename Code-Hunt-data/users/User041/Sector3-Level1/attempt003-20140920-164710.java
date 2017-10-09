

public class Program {
  public static int[] Puzzle(int[] a, int t) {
	  for (int i=0; i < a.length(); i++){
				  if (a[i]==t) {
					 if (a[0]<-1){return a;}
				  }
	  }   
	  return a;
  }
}