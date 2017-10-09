public class Program {
	

 public static String Puzzle(String s) {
	 String res = "";
	 
	 for (int i = 0; i < s.length(); ++i) {
	 char t = (char)(s.charAt(i) + (fibonacci(i+1) % 26));
	 if (t > 'z') t -= (char)('z' - 'a' + 1);
	 if (t < 'a') {
	 t = (char)( 'z'  - ('a' - t) + 1);
	 }
	 s
	res += t;
 }
     return res;
 }
 
 
 public static int fibonacci (int i)
    {
        if (i == 0) return 0;
        if (i<= 2) return 1;

        int fibTerm = fibonacci(i - 1) + fibonacci(i - 2);
        return fibTerm;
    }
 
}