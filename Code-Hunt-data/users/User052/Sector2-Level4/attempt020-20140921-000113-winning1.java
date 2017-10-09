

public class Program {
  public static int Puzzle(int a, int b) {
	int x,y;
    if(a==b)
		return a;
	else if (a%b==0 || b%a==0)
		return a>b?a:b;
	else{
		
    	x=a;
		y=b;
		
		   if (a == 0)
        		return (x*y)/b;
		   else{
    			while (b != 0) {
        			if (a > b)
            			a = a - b;
        			else
            			b = b - a;
    			}
		
			return (x*y)/a;}
	}	
  }
  
}