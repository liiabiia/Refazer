

public class Program {
  public static String Puzzle(int n) {
	  String result = Integer.toString(n % 2);
	   int quotient = n/2;
		while(quotient >= 2){
			result = Integer.toString(quotient % 2) + result;
			quotient = quotient/2;
		}
		if(quotient == 0)
			return result;
		else
			return Integer.toString(quotient) + result;
  }
}