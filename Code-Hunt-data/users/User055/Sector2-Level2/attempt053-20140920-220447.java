

public class Program {
  public static int Puzzle(String s) {
    char x;
	int i,tot=0, c=0 ,d=0;
	 
	for (i=0; i<s.length()-1; i++){
		
		if (s.contains(")(")) return 0;
		else {
		if (s.charAt(i)=='('){
			
			c++;
		}
		if (s.charAt(i)==')'){
			
			d++;
		}
		if ((s.charAt(i)=='(')& (s.charAt(i+1)=='(')) c++; 
		else if ((s.charAt(i)==')')& (s.charAt(i+1)==')')) d++; 
		else if ((s.charAt(i)=='(')& (s.charAt(i+1)==')')) {c--; tot++; } 
		else if ((s.charAt(i)==')')& (s.indexOf(')')==-1|s.indexOf('(')<s.indexOf(')'))) {c=0; break;}
			
		
	
		
		
	}

  }
  
  	if ((c==d)&c!=0) return c-1; else return 0;
  }
}