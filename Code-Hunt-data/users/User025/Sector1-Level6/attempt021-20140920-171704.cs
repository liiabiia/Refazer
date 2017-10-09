public class Program {
  public static int Puzzle(string s) {
	  int resultado = 0;
	    for(int i = 1; i < s.length(); i++){
			if(s[i] != ' ' && s[i-1] == ' '){
				resultado++;
				i++;
			}
		}
	return resultado;
  }
}