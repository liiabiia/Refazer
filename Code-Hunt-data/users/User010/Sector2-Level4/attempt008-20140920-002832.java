

public class Program {
  public static int Puzzle(int a, int b) {
    return java.math.BigInteger.valueOf(a).gcd(java.math.BigInteger.valueOf(b)).intValue();
  }
}