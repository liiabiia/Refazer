

public class Program {
  public static int Puzzle(int a, int b) {
    int max=a>b?a:b;
    int min=a<b?a:b;
	int x,lcm=1;
	for (int i=1;i<=min;i++)
       {
        x=max*i;
        if (x%min==0)
          {
           lcm=x;
           break;
          }
       }
	return lcm;
  }
}