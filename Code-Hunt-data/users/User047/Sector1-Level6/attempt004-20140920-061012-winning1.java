

public class Program {
  public static int Puzzle(String s) {
	  int words = 0;
	  boolean word = false;
	  for(char a:s.toCharArray()) {
		  
		  if(a!=' ' && !word) {
			  
			  word = true;
			  words++;
		  }else if(a==' ')
		  	word = false;
		  	
		  	
	  }
    return words;
  }
}