

public class Program {
  public static int Puzzle(String s) {
	String s= " ";
    int result = 0;
    Pattern p = Pattern.compile(k);
    Matcher m = p.matcher(s);
    while (m.find()) {
    result++;
    }
    return result;
  }
}