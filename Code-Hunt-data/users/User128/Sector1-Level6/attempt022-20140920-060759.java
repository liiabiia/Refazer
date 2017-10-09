

public class Program {
  public static int Puzzle(String s) {
	  int count = 0,ans = 1;
	  char ch = " ";
	  while(count < s.length()){
		  if(s.charAt(count) == ' '){
			  ++ans;
		  }
		  ++count;
	  }
    return 0;
  }
}