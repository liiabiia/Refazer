import java.util;

public class Program {
  public static int Puzzle(String s) {
    /*int len = s.length()-1;
	int count = 0;
	while(len>=0)
	{
		if(s.charAt(len)==' ' )
			count++;
			len--;
	}
	count++;
	return count;*/
	int words;
	words= new StringTokenizer(s," ").countTokens();
	return words;
  }
}