

public class Program {
  public static Boolean Puzzle(char c) {
			int x = (int)c - 97;
		return ( (x<=11&&x%2==1) || (x==10) || (x<=25&&x>=14&&x!=15&&x!=20);
  }
}