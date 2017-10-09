
public class Program {
  public static int Puzzle(String s) {
	  s.replaceAll("\\s+","\n");
String[] arr = s.split("\\n");
return arr.length;


  }
}