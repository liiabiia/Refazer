

public class Program {
  public static int Puzzle(String s) {
	  int count=0;
    for(int i=0;i<s.length();i++){
		if(s.charAt(i)=='(' && s.charAt(s.length()-i-1)=')') count++;
	}
	return count;
  }
}