

public class Program {
  public static String Puzzle(int n) {
	  StringBuilder binary = "";
	  
	  if (n == 1 || n == 0)
	  {
		  binary.append(Integer.toString(n));
	  }
	  
	  while (n != 0 || n != 1)
	  {
		  binary.append(Integer.toString(n % 2));
		  n %= 2;
	  }
	  
    return binary.toString();
  }
}