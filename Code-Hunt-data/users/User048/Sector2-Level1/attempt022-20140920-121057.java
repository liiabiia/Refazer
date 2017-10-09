

public class Program {
  public static int Puzzle(int[] a) {
    if(a.length == 1)
		return a[0];
	int sum = 0;
	for(int i = 0; i<a.length; i++){
		sum += (int)((double)a[i]/a.length +0.5);
	}
	return sum;
  }
}