

public class Program {
  public static int Puzzle(String s) {
	  int k=0,q=0;
	for(int i=0;i<s.length;i++){
		if(s.charAt(i)=='(')
			k++;
		if(s.charAt(i)==')')
			q++;
	}
    return k==q?k:0;
  }
}