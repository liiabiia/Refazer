

public class Program {
  public static String Puzzle(int n) {
	  StringBuilder binary = new StringBuilder("");
	  if (n == 0 || n == 1)
	  {
		  binary.append(Integer.toString(n));
	  }
		  while (n != 0)
		  {
			  binary.append(Integer.toString(n % 2));
			  n /= 2;
		  }
    return binary.reverse().toString();
  }
}