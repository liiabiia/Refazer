

public class Program {
  public static int Puzzle(String s) {
	  int count=0;
    for(int i=s.length()/2;i>=0;i--){
		if(s.charAt(i)=='(' && s.charAt(s.length()-i)==')') count++;
                else break;
	}
	return count;
  }
}