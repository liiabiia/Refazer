

public class Program {
  	public static int Puzzle(String s) {
		int rez=0;
		for(int i=1;i<s.length();i++)
			if(!s.charAt(i).equals(' ') && s.charAt(i-1).equals(' ')) rez++;
    	return rez;
  	}
}