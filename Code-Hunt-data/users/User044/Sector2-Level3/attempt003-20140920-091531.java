

public class Program {
  public static String Puzzle(String s) {
String x="";
x=x+s.charAt(0);
for(i=(s.length()-2);i>0;i--)
{x=x+s.charAt(i);
}x=x+s.charAt(s.length()-1);
    return x;
  }
}