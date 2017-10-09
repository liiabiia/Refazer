

public class Program {
  public static String Puzzle(String s) {
String x="";
x=x+s.substring(0,1);
for(i=(s.length()-1);i>0;i--)
{x=x+s.substring(i-1,i);
}x=x+s.substring(s.length()-1,s.length());
    return x;
  }
}