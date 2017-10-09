
public class Program {
  public static int Puzzle(String s) {	
	  int cont = 0;

		for (int i = 1; i < s.length(); i++) {
			if (s.charAt(i) == ' ' && s.charAt(i - 1) != ' ')
				cont++;
		}
		if (s.charAt(s.length() - 1) != ' ')
			cont++;

    return cont;
  }
}