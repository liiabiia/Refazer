

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
	if (y==true&& y==z) return y;
    if (x==y && y==z ) return x;
	if (x!=y && y!=z && z!=y) return z;
	
	return x;
    
  }
}