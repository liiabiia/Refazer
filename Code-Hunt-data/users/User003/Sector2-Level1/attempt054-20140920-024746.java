

public class Program {
  public static int Puzzle(int[] a) {
    double sum = 0;
	for(int x : a)if(x>0)sum+=(x%2==0)?x:x+1;
	return (int)sum;
  }
}