

public class Program {
 public static int fib(int x){
	 if(x == 1 || x == 0) return 1;
	 return fib(x - 1) + fib(x - 2);
 }


  public static String Puzzle(String s) {
    String result = "";
	String engChars = "abcdefghijklmnopqrstuvwxyz";
	for(int i=0; i<s.length(); i++){
		for(int j=0; j<engChars.length(); j++){
			if(engChars.charAt(j) == s.charAt(i) ){
				result += engChars.charAt((j + fib(i)) % 26) ;
			}
		}
	}
	return result;
  }
}