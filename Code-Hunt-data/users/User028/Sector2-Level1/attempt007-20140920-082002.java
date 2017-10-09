

public class Program {
  public static int Puzzle(int[] a) {
    int sum=0;
	for (int e:a){
		sum+=e;
	}
	double result =sum/a.length;
	return Math.round(result);
  }
}