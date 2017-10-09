

public class Program {
  public static int Puzzle(int[] a) {
    int l,i,max;
	l=a.length;
	if(l==2)
	return (a[1]-a[0]);
	else
	{
	max=a[0];
	for(i=1;i<l;i++)
	{
		if(max<a[i])
		max=a[i];
	}
	return max;
	}	
	}
}