

public class Program {
  public static int Puzzle(String s) {
	  int x = 0;
	  if(s.charAt(0) != ' ')x++;
	  for(int i=1; i<s.length(); i++){
		  if(s.charAt(i) != ' '){
			  if(s.charAt(i-1) == ' '){
				 x++; 
			  }
		  }
	  }
    return x;
  }
}