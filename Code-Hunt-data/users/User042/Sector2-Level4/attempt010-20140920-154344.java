

public class Program {
  public static int Puzzle(int a, int b) {
   if(a%b==0)
   		return a;
   else
   {
	    if((a*2)%b==0)
			return a*2;
		else	
   		return a*b;
   }
  }
}