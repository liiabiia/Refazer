

public class Program {
  public static int Puzzle(int[] a) {
    int high = 0, low = a[0];
	for(int i=0; i<a.length; i++) {
		if(a[i] < low) low = a[i];
		if(a[i] > high) high = a[i];
	}
	return high - low;
  }
}