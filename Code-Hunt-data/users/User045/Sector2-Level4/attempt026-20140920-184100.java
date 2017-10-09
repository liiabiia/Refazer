

public class Program {
  public static int Puzzle(int a, int b) {
	int max=a>b?a:b,min=a<b?a:b,x=0;
    for(int i=1;i<=min;i++)
   {
    x=max*i; 
    if(x%min==0) 
     {
      lcm=x; 
      break; 
     }
    }
	return lcm; 
  }
}