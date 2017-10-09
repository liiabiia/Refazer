

public class Program {
  public static int Puzzle(String s) {
    char x;
	int i, c=0 ,d=0;
	 
	for (i=0; i<s.length()-1; i++){
		if (s.charAt(i)=='('){
			
			c++;
		}
		if (s.charAt(i)==')'){
			
			d++;
		}
		if ((s.charAt(i)=='(')& (s.charAt(i+1)=='(')) c++; 
		else if ((s.charAt(i)==')')& (s.charAt(i+1)==')')) d++; 
		else if ((s.charAt(i)=='(')& (s.charAt(i+1)==')')) {c--; d++;} 
				
		
	
		
		
	}
	if ((c==d)&c!=0) return c; else return 0;
  }
}