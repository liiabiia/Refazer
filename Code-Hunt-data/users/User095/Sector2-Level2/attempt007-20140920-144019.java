

public class Program {
  public static int Puzzle(String s) {
	 int c=0;
	 for(int i=0;i<s.length()/2;i++){
		 if ((s.charAt(i) == '(') && (s.charAt(s.length()-i) == ')')) {
			 ++c;
		 }
	 }
    return c;
  }
}