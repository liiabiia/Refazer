

public class Program {
  public static int Puzzle(int[] a) {
    int i;
	int h=a[0],l=0;
	for (i=0; i<a.length; i++;){
		if( a[i]>h) { h=a[i];}
		if (a[i]<l){l=a[l];}
		
	}
	return h-l;
  }
}