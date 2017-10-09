

public class Program {
  public static Boolean Puzzle(int x, int y) {
	
  }
  
  boolean istZweierpotenz(long x) {
double zweierLogarithmus = Math.log(x) / Math.log(2.0);
int gerundeterZweierLogarithmus = (int) (zweierLogarithmus + 0.5); // runden
return potenz(2, gerundeterZweierLogarithmus) == x;
}
}