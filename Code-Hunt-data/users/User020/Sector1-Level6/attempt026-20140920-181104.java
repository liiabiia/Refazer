import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Program {
  private static String pattern = "[^\\s]+";
  public static int Puzzle(String s) {
    	  Pattern r = Pattern.compile(pattern);
		  Matcher m = r.matcher(s)
   		return m.group(0).length();
  }
}