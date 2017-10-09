

public class Program {
  public static int Puzzle(int a, int b) {
   if(a%b==0)
   		return a;
   else
   {
	   int i = 2;
	   while(true)
	   {
		   if((a*i)%6==0)
		   	return a*i;
			i++;
			if(i>10)
			break;	    
	   }
   		return a*b;
   }
  }
}