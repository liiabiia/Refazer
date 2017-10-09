

public class Program {
    public static int Puzzle(int[] a) {
      int largest = a[0];
	  for(int i=1;i<a[a.length-1];i++ ){
		  if(a[i]>largest)
		  largest=a[i];
	  }
	  return largest;
    }
}