public class Program {
  public static int Puzzle(String s) {

	String frase = s;  
    String[] palavras = frase.split(" ");  
    /*System.out.print(palavras.length);*/
	
	return palavras.length;

  }
}