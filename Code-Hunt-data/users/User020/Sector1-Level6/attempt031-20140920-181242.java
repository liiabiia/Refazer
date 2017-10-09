
public class Program {
  private static int count = 0;
  public static int Puzzle(String s) {
	for(char x: s){
		if(x == ' ') count++;
	}
	return count;
  }
}