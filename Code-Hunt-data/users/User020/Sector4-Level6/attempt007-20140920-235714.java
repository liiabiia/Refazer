

public class Program {
 public static int fib(int x){
	int[] fibArr = new int[x];
	fibArr[0] = 1;
	fibArr[1] = 1;
	for(int i=0; i<x; i++){
		fibArr[i] = fibArr[i-1] + fibArr[i-2];
	}
	return fibArr[fibArr.length - 1];
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