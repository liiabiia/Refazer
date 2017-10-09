

public class Program {
  public static int Puzzle(String s) {
    char x;
	int i, c=0 ,d=0;
	 
	for (i=0; i<s.lenght(); i++){
		
		if (s.charAt(i)=='('& s.charAt(i+1)='(') c++;
		if (s.charAt(i)==')'& s.charAt(i+1)=')') d++;
		
		
		
		
	}
	if (c==d) return c; else return 0;
  }
}