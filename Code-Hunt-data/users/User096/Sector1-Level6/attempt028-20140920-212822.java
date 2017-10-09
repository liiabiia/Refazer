public class Program {
  public static int Puzzle(String s) {

	String frase = s;  
    String[] palavras = frase.split("-", s.length());  
	return palavras.length;

  }
}