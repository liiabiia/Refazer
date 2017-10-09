

public class Program {
  public static int Puzzle(int[] a) {
    if(a.length == 1)
		return a[0];
	double sum = 0;
	for(int i = 0; i<a.length; i++){
		sum += ((double)a[i]/a.length);
	}
	if( sum - (int)sum >= 0.5 )
		return (int)sum+1;
	else
		return (int)sum;
  }
}