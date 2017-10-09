

public class Program {
  public static int Puzzle(String s) {
	  int count = 0,ans = 1;
	  while(count < s.length()){
		  if(s.CharAt(count) == " "){
			  ++ans;
		  }
		  ++count;
	  }
    return 0;
  }
}