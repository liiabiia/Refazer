

public class Program {
  public static int Puzzle(String s) {
	  int count=0;
    for(int i=0;i<s.length()/2;i++){
		if(s.charAt(i)=='(' && s.charAt(s.length()-i-1)==')') count++;
	}
	if(count==3)return count;
	else return 0;
  }
}