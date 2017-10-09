

public class Program {
  public static int Puzzle(int a, int b) {
	  int temp=0;int max=a>b?a:b;int min=a<b?a:b;
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