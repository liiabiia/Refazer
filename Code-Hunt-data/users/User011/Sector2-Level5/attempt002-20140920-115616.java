

public class Program {
  public static int Puzzle(int[] a) {
	if(a.length==2)	return Math.abs(a[0]-a[1]);
	int maxi = 0;
	for(int item : a)
		maxi = Math.max(maxi,item);
    return maxi;
  }
}