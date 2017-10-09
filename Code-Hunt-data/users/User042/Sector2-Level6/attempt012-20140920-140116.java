

public class Program {
  public static String Puzzle(int n) {
      String result = "";
      while(n!=1)
      {
          result = n%2 + result;
          n=n/2;
      }
	  result = 1 + result;
      return result;
  }
}