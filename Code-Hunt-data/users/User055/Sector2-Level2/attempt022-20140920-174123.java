

public class Program {
  public static int Puzzle(String s) {
    char x;
	int i, c=0 ,d=0;
	 
	for (i=0; i<s.length()-1; i++){
		
		if ((s.charAt(i)=='(')& (s.charAt(i+1)=='(')) c++; else {c=0; break;}
		if ((s.charAt(i)==')')& (s.charAt(i+1)==')')) d++; else {c=0; break;}
		
	
		
		
	}
	if ((c==d)&c!=0) return c+1; else return 0;
  }
}