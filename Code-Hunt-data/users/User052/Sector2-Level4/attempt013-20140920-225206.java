

public class Program {
  public static int Puzzle(int a, int b) {
	int x;
    if(a==b)
		return a;
	else if (a%b==0 || b%a==0)
		return a>b?a:b;
	else{
		x=a;
		
		   if (a == 0)
        return b;

    while (b != 0) {
        if (a > b)
            a = a - b;
        else
            b = b - a;
    }

		return (x*b)/a;}
  }
  
}