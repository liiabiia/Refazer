

public class Program {
  public static int Puzzle(String s) {
	  String[] palavras = s.split("\\s+");
	  int resultado = palavras.length;
	  if(s.charAt(0) == ' ')
	  	resultado--;
	if(s.charAt(s.length()-1 == ' ')
		resultado--;
	  return palavras.length;
  }
}