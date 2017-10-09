

public class Program {
  public static String Puzzle(int n) {
    StringBuilder sb = new StringBuilder();
	while (n>1){
		sb.insert(0, n%2);	
		n=n>>1;
	}
	sb.insert(0, n);	
	return sb.toString();
  }
}