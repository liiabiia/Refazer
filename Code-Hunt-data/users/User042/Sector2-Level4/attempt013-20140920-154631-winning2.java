

public class Program {
  public static int Puzzle(int a, int b) {
   if(a%b==0)
   		return a;
   else if(b%a==0)
   		return b;
   else	   
   {
	    for(int i = 2; i < 10; i++)
		{
			if((a*i)%b==0)
			return a*i;
		}	
   		return a*b;
   }
  }
}