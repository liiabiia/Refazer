

public class Program {
  public static Boolean Puzzle(int x, int y) {
	  long xNew = x;
	  long yNew = y;
	return istZweierpotenz(x);
  }
  
  boolean istZweierpotenz(long x) {
	double zweierLogarithmus = Math.log(x) / Math.log(2.0);
	int gerundeterZweierLogarithmus = (int) (zweierLogarithmus + 0.5); // runden
	return potenz(2, gerundeterZweierLogarithmus) == x;
	}
	
	long potenz(int basis, int exponent) {
if(0 >= exponent) {
return 1;
}
if(istGerade(exponent)) {
return potenz(basis * basis, exponent / 2);
} else {
return basis * potenz(basis * basis, (exponent - 1) / 2);
}
}
 
boolean istGerade(int x) {
return 0 == x % 2; 
}
}