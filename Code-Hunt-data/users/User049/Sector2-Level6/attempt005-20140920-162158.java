

public class Program {
  public static String Puzzle(int n) {
	  String bin = "";
	  
	  binary(n, bin);
    return bin;
  }
  
  int binary(int n, String bin)
  {
	  if (n == 0 || n == 1)
	  {
		  return n;
	  }
	  else
	  {
		  int x = binary(n % 2, bin);
		  bin += Integer.toString(x);
	  }
  }
}