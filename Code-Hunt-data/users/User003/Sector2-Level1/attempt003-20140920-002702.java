

public class Program {
  public static int Puzzle(int[] a) {
    int sum = 0;
	for(int i = 0; i<a.length;i++)
	{
		if(i==1){sum+=a.length*a[i];}
		else sum+=a[i];
	}
	return sum;
  }
}