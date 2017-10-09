

public class Program {
  public static int Puzzle(int[] a) {
    int min=max=a[0];
	for (int i=1;i<a.length;i++){
		if (max<a[i]){
			max=a[i];
		}
		if (min>a[i]){
		    min=a[i];
		}
	}
	return max-min;
  }
}