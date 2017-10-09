

public class Program {
  public static int Puzzle(int[] a) {
    int sum = 0;
	int mult = 0;
	for(int i = 0; i<a.length;i++)
	{
		if(a[i]!=0)mult++;
	}
	for(int i = 0; i<a.length;i++)
	{
		if(i==1){sum+=mult*a[i];}
		else sum+=a[i];
	}
	return sum;
  }
}