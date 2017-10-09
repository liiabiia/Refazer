

public class Program {
  public static int Puzzle(int[] a) {
    int min = 1000, max = 0;
	for(int i = 0; i<a.length; i++){
		if(a[i] < min){
			min = a[i];
		}
		if(a[i]>max){
			max = a[i];
		}
	}
	return max-min;
  }
}