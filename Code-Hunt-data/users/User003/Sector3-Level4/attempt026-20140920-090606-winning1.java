

public class Program {
  public static Boolean Puzzle(char c) {
	char[] tab = new char[]{'b','d','f','l','o','t','v','k','h','j','q','r','s','w','y','x','z'};
    for(char x : tab)
		if(c==x)return false;
	return true;
  }
}