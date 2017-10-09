

public class Program {
  public static int Puzzle(String s) {
	  int count = 0,ans = 1;
	
	  while(count+1 < s.length()){
		  if(s.charAt(count+1) == ' ' && s.charAt(count) != ' ' )
		  {
			  ++ans;
		  }
		  ++count;
	  }
    return ans;
  }
}