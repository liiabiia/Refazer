

public class Program {
  public static Boolean Puzzle(char c) {
	return (int)c%2==0;
    if(c=='b'||c=='j'||c=='q'||c=='s'||c=='w'||c=='h'
	||c=='x')
		return false;
	return true;
  }
}