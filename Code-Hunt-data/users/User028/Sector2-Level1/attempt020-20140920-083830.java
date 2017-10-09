

public class Program {
  public static int Puzzle(int[] a) {
    int sum=0;
	for (int e:a){
		sum+=e;
	}
   return (int)Math.floor((double)(sum/a.length+0.5));
  }
}