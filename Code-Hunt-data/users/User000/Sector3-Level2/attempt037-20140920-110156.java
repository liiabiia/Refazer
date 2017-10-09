

public class Program {
  public static int Puzzle(int n) {
    return fib(n);
  }
  public static int fib(int n){
	  if(n<=2)return 1;
	  int k=n/2;
	  int a = fib(k+1);
	  int b= fib(k);
	  if(n%2==1)return a*a+b*b;
	  else
	  	return b*(2*a - b);
  }
}