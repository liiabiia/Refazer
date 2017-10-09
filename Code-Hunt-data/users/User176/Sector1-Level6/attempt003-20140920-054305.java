

public class Program {
  public static int Puzzle(String s) {
	  int a = 0;
	  for(int i =0;i < s.length();i++) {
		  if(s[i] == ' ') {
			  a++;
		  }
	  }
    return a;
  }
}