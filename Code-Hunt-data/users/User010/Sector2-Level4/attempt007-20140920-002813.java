import java.math.BigInteger;

public class Program {
  public static int Puzzle(int a, int b) {
    return BigInteger.valueOf(a).gcd(BigInteger.valueOf(b)).intValue();
  }
}