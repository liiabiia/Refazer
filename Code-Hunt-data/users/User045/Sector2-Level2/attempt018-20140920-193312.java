

public class Program {
  public static int Puzzle(String s) {
	  int count=0;
    for(int i=(s.length()/2)-1;i>=0;i--){
		if(s.charAt(i)=='(' && s.charAt(s.length()-i-1)==')') count++;
                else break;
	}
	return count;
  }
}