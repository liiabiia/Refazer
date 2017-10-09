

public class Program {
  public static int Puzzle(int[] a) {
    int l,i,max, min;
	l=a.length;
	max=a[0]; min=a[i];
	for(i=1;i<l;i++)
	{
		if(max<a[i])
		max=a[i];
		if(min > a[i])
		min=a[i];
	}
	return (max-min);	
	}
}