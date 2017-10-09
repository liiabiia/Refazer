

public class Program {
  public static String Puzzle(int n) {
    String s = n;
    BigInteger bi = new BigInteger(s);
    return bi.toString(2);
  }
}