

public class Program {
  public static int Puzzle(String s) {
	 int resultado = 0;
	for(int i = 1; i < s.length(); i++){
		if(s.charAt(i) != ' ' && s.charAt(i-1) == ' ') resultado++;
	}
	if(s.charAt(0) != ' ') resultado++;
	return resultado;
}