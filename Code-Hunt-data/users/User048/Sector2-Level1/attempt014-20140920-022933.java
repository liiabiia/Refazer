

public class Program {
  public static int Puzzle(int[] a) {
    if(a.length == 1)
		return a[0];
	double sum = 0;
	for(int i = 0; i<a.length; i++){
		sum += a[i];
	}
	double average = (sum / a.length);
	
	return average < 0 ? (int)(average-0.5) : (int)(average+0.5);
  }
}