

public class Program {
  public static int Puzzle(String s) {
	  String answ =  s.trim().replaceAll("[ ]+", " ");
	   		return (answ.length==0)?0:answ.split(" ").length;
  }
}