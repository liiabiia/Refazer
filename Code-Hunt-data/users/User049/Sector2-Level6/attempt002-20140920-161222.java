

public class Program {
  public static String Puzzle(int n) {
	  String binary = "";
	  while (n != 0 || n != 1)
	  {
		  binary += Integer.toString(n %= 2);
	  }
	  
	  StringBuilder stringBuilder = new StringBuilder(binary);
	  stringBuilder.reverse();
	  
    return stringBuilder.toString();
  }
}