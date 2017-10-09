

public class Program {
  public static int Puzzle(String s) {
	  int palavras = 0;
    for(int i = 1; i < s.length(); i++){
		if((s.charAt(i) != ' ') && (s.charAt(i-1) == ' ')){
			palavras++;
		}
	}
	if(s.charAt(0) != ' '){
		palavras++;
	}
	return palavras;
  }
}