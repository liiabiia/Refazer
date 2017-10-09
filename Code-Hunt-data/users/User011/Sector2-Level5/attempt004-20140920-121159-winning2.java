

public class Program {
  public static int Puzzle(int[] a) {
	int maxi = a[0] , mini = a[0];
        for(int item : a) {
            maxi = Math.max(maxi,item);
            mini = Math.min(mini,item);
        }
        return maxi-mini;
  }
}