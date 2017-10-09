

public class Program {
  public static int Puzzle(String s) {
	String k= " ";
    int result = 0;
    Pattern p = Pattern.compile(s);
    Matcher m = p.matcher(k);
    while (m.find()) {
    result++;
    }
    return result;
  }
}