

public class Program {
  public static int Puzzle(int a, int b) {
    return a*gcd(a,b);
  }
  public int gcd(int a,int b) {
     return (b==0)?a:gcd(b, a % b);
 } 
}