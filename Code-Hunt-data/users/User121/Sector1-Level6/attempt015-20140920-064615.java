
public class Program {
  public static int Puzzle(String s) {
	  s.replaceAll("\\s+","\t")
String[] arr = s.split("\\t");
return arr.length;


  }
}