

public class Program {
  public static int Puzzle(String s) {
	  int words = 0;
	  for(int i = 1; i< s.length(); i++){
		  if(s.charAt(i) == ' '){
			  if(s.charAt(i-1) != ' '){
			  	words += 1;
		  	  }
		  }
	  }
	  if(words > 0){
		  words += 1;
	  }
    return s.split(" ").length;
  }
}