

public class Program {
  public static String Puzzle(int n) {
   int remainder;
	if (n <=1) {
        return n;

    }

    remainder= n %2; 
    Puzzle(n >>1);
    return remainder;

    { 
    return null;
  }
}