

public class Program {
  public static int Puzzle(int[] a) {
    int l=a.length;
	int sum=0,i, s,
	double avg, a1;
	for(int i=0;i<l;i++)
	{
		sum=sum+a[i];
	}
	avg=sum/l;
	s=sum/l;
	a1=(double)s;
	if((avg-a1)<0.5)
	return s;
	else
	return (s+1);
  }
}