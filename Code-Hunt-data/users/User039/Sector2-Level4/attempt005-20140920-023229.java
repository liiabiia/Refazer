

public class Program {
   private static int gcd(int a, int b)
{
    while (b > 0)
    {
        int temp = b;
        b = a % b; // % is remainder
        a = temp;
    }
    return a;
} 
 
 
private static int lcm(int a, int b)
{
    return a * (b / gcd(a, b));
}
  
  public static int Puzzle(int a, int b) {
	result = lcm(a, b);
	return result;
  }
 
}