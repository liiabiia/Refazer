public class Program {
  public static int Puzzle(String s) {

	String frase = s;  
    String[] palavras = frase.split("-", 0);  
	return palavras.length;

  }
}