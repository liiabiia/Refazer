

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a>=b&&a%b==0)
	  return a;
	  if(b>=a&&b%a==0)
	  return b;
	  int i=1;
	  for(int i=0;i<a*b;i++)
		   if(i%a==0 && i%b==0)
	   break;
    return i;
  }
}