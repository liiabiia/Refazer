

public class Program {
  public static String Puzzle(String s) {
	  Char[] help;
	  Strang ausgabe;
	  for(int i=1;i<s.length-1;i++){
		  help[i] = s.charAt(s.length-i);
	  }
	  help[0] = s.charAt(0);
	  help[s.length-1] = s.charAt(s.length);
	  for(int i=0; i<s.length;i++){
		  ausgabe = ausgabe + help[i];
	  }
    return ausgabe;
  }
}