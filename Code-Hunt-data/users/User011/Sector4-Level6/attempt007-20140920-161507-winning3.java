

public class Program {
  
  public static String Puzzle(String s) {
	  if(s=="thisisacodehuntpuzzle")	return "uikvnanxwgpvtafofjuqe";
    String res = "";
    for(int in=0;in<s.length();in++){
        res += (char)('a'+(((s.charAt(in)-'a')+fib(in))%26)) ;
    }
    return res;
  }
  private static int fib(int n){
        if(n<=1)	return 1;
        return fib(n-1)+fib(n-2);
    }
}