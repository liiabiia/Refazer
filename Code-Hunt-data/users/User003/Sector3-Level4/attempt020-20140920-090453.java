

public class Program {
  public static Boolean Puzzle(char c) {
	char[] tab = new char[]{'b','d','h','j','q','r','s','w','y','x','z'};
    for(char x : tab)
		if(c==x)return false;
	return true;
  }
}