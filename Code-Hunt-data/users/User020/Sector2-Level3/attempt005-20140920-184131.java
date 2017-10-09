

public class Program {

  public static String Puzzle(String s) {
	String result = s[0];
	for(int i=s.length() - 2; i>0; i--){
		result += s.charAt(i);
	}
	result += s.charAt(s.length() - 1);
    return result;
  }
}