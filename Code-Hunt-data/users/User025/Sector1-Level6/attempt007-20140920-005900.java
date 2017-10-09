

public class Program {
  public static int Puzzle(String s) {
	  String[] palavras = s.split("\\s+", -1);
	  return palavras.length;
  }
}