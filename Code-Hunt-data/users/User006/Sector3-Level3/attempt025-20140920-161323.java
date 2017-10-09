

public class Program {
  public static int Puzzle(int[] a, int k) {
	  int min = a[0];
	  for(int i = 0; i < a.length; i++)
	  {
		int tmp = 0;
	  	for(int j = i+1; j < a.length; j++)
		{
			if(a[i] == a[j])
				tmp++;
		}
		if(tmp>=k && a[i] < min)
			min = a[i];
	  }
    return min;
  }
}