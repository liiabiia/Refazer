

public class Program {
  public static String Puzzle(String s) {
    char[] c = s.toCharArray();
	for(int i = 1; i < (c.length/2); i++)
	{
		char aux = c[i];
		c[i] = c[(c.length-1)-i];
		c[(c.length-1)-i] = aux;
	}
	String resultado = new String(c);
	return resultado;
  }
}