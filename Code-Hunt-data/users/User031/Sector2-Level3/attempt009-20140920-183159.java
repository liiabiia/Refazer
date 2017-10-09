

public class Program {
  public static String Puzzle(String s) {
	  char[] help;
	  
	  String ausgabe=null;
	  int arr = s.length();
	  help = new char[arr];
	  
	  for(int i=1;i<arr-1;i++){
		  help[i] = s.charAt(arr-i);
	  }
	  help[0] = s.charAt(0);
	  help[arr-1] = s.charAt(arr-1);
	  for(int i=0; i<arr;i++){
		  ausgabe = ausgabe + help[i];
	  }
    return ausgabe;
  }
}