

public class Program {
  public static int Puzzle(int[] a) {
	 int min = max = a[0];
    for(int i = 1; i < a.length; i++)
	{
		int tmp = a[i];
		if(tmp<min)
			min = tmp;
		if(tmp>max)
			max = tmp;
	}
	return max - min;
  }
}