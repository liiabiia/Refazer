

public class Program {
  public static int Puzzle(String s) {
    char x;
	int i, c=0 ,d=0;
	 
	for (i=0; i<s.length()-1; i++){
		
		if ((s.charAt(i)=='(')& (s.charAt(i+1)=='(')) c++;
		if ((s.charAt(i)==')')& (s.charAt(i+1)==')')) d++;
		
		
		
		
	}
	if (c==d) return c+1; else return 0;
  }
}